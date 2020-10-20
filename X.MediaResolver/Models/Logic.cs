using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace X.MediaResolver.Models
{
    public static class Logic
    {
        /// <summary>
        /// 获取url地址
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string GetUrl(string content)
        {
            string result = "";
            var match = Regex.Match(content,
                @"(https?|ftp|file)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]");
            if (match.Length > 0)
            {
                return match.Value;
            }
            return result;
        }

        /// <summary>
        /// 匹配数字
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private static string GetNumber(string content)
        {
            string result = "";
            var match = Regex.Match(content,@"\d+");
            if (match.Length > 0)
            {
                return match.Value;
            }
            return result;
        }

        /// <summary>
        /// 解析抖音真实地址
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<Douyin.DouyinResult>  GetDouyin(string url)
        {
            var result = new Douyin.DouyinResult
            {
                status_code = -1
            };
            try
            {
                var xresult = await XRequest.GetResponse(url);
                if (xresult == null || string.IsNullOrEmpty(xresult.GetResponseHeader("Location")))
                {
                    return result;
                }
                var xurl = xresult.GetResponseHeader("Location");
                var id = GetNumber(xurl);
                if (string.IsNullOrEmpty(id))
                {
                    return result;
                }

                string rurl = $"https://www.iesdouyin.com/web/api/v2/aweme/iteminfo/?item_ids={id}";
                string agent = "Mozilla/5.0 (iPhone; CPU iPhone OS 13_2_3 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.3 Mobile/15E148 Safari/604.1";
                var zresult = await XRequest.Get(rurl, null, agent);
                if (string.IsNullOrEmpty(zresult))
                {
                    return result;
                }
                result = JsonConvert.DeserializeObject<Douyin.DouyinResult>(zresult);
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        /// <summary>
        /// 读取配置
        /// </summary>
        /// <returns></returns>
        public static async Task<XConfig> ReadConfig()
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "config.json";
                if (!File.Exists(path))
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        Formatting = Formatting.Indented,
                        NullValueHandling = NullValueHandling.Include
                    };
                    XConfig data = new XConfig
                    {
                        SavePath = AppDomain.CurrentDomain.BaseDirectory + "Douyin",
                        IsDownloadVoice = true,
                        IsDownloadPoster = false
                    };
                    var json = JsonConvert.SerializeObject(data, settings);
                    using (var file = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                    {
                        using (var writer = new StreamWriter(file, Encoding.UTF8))
                        {
                            using (var jsonwriter = new JsonTextWriter(writer))
                            {
                                await jsonwriter.WriteRawAsync(json);
                            }
                        }
                    }

                    return data;
                }

                using (var file = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new StreamReader(file, Encoding.UTF8))
                    {
                        var json = await reader.ReadToEndAsync();
                        return JsonConvert.DeserializeObject<XConfig>(json);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 写入配置
        /// </summary>
        /// <param name="data">配置参数</param>
        public static async Task WriteConfig(XConfig data)
        {
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Include
                };
                var json = JsonConvert.SerializeObject(data, settings);
                string path = AppDomain.CurrentDomain.BaseDirectory + @"config.json";
                using (var file = new FileStream(path, FileMode.Truncate, FileAccess.ReadWrite))
                {
                    using (var writer = new StreamWriter(file, Encoding.UTF8))
                    {
                        using (var jsonwriter = new JsonTextWriter(writer))
                        {
                            await jsonwriter.WriteRawAsync(json);
                        }
                    }
                }
            }
            catch (Exception)
            {
                await Task.Delay(300);
            }
        }

        /// <summary>
        /// 获取音乐
        /// </summary>
        /// <param name="item"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public static XMusic GetXMusic(Douyin.Music item, string hash)
        {
            var xitem = new XMusic();
            try
            {
                if (item == null)
                {
                    return xitem;
                }
                xitem.Hash = hash;
                xitem.Name = item.author;
                xitem.Desc = item.title;
                xitem.MusicUrl = item.play_url?.url_list.FirstOrDefault() ?? "";
                xitem.PosterUrl = item.cover_hd != null
                    ? item.cover_hd?.url_list.FirstOrDefault()
                    : item.cover_medium != null
                        ? item.cover_medium?.url_list.FirstOrDefault()
                        : item.cover_thumb != null
                            ? item.cover_thumb?.url_list.FirstOrDefault()
                            : "";
                return xitem;
            }
            catch (Exception)
            {
                return xitem;
            }
        }

        /// <summary>
        /// 获取视频
        /// </summary>
        /// <param name="item"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public static async Task<XVideo> GetXVideo(Douyin.Video item, string hash)
        {
            var xitem = new XVideo();
            try
            {
                if (item == null)
                {
                    return xitem;
                }
                xitem.Hash = hash;
                xitem.PosterUrl = item.origin_cover != null
                    ? item.origin_cover?.url_list.FirstOrDefault()
                    : item.cover != null
                        ? item.cover?.url_list.FirstOrDefault()
                        : item.dynamic_cover != null
                            ? item.dynamic_cover?.url_list.FirstOrDefault()
                            : "";
                if (!string.IsNullOrEmpty(xitem.PosterUrl))
                {
                    xitem.Poster = await GetPoster(xitem.PosterUrl);
                }

                var vurl = item.play_addr?.url_list.FirstOrDefault() ?? "";
                if (!string.IsNullOrEmpty(vurl))
                {
                    xitem.VideoUrl = vurl.Replace("playwm", "play");
                }
                return xitem;
            }
            catch (Exception)
            {
                return xitem;
            }
        }

        /// <summary>
        /// 获取作者
        /// </summary>
        /// <param name="item"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public static async Task<XAuthor> GetXAuthor(Douyin.Author item, string hash)
        {
            var xitem = new XAuthor();
            try
            {
                if (item == null)
                {
                    return xitem;
                }
                xitem.Hash = hash;
                xitem.Name = item.nickname ?? "";
                xitem.UniqueId = item.unique_id ?? "";
                xitem.AvatarUrl = item.avatar_larger != null
                    ? item.avatar_larger?.url_list.FirstOrDefault()
                    : item.avatar_medium != null
                        ? item.avatar_medium?.url_list.FirstOrDefault()
                        : item.avatar_thumb != null
                            ? item.avatar_medium?.url_list.FirstOrDefault()
                            : "";
                if (!string.IsNullOrEmpty(xitem.AvatarUrl))
                {
                    xitem.Avatar = await GetPoster(xitem.AvatarUrl);
                }

                return xitem;
            }
            catch (Exception)
            {
                return xitem;
            }
        }

        /// <summary>
        /// 获取封面图
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static async Task<Image> GetPoster(string url)
        {
            Image image = Properties.Resources.vc;
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    return image;
                }
                using (var client = new WebClient())
                {
                    var bites = await client.DownloadDataTaskAsync(new Uri(url));
                    using (var stream = new MemoryStream())
                    {
                        await stream.WriteAsync(bites, 0, bites.Length);
                        image = Image.FromStream(stream, true);
                    }
                }
                return image;
            }
            catch (Exception)
            {
                return image;
            }
        }
    }
}