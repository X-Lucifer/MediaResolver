using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace X.MediaResolver.Models
{
    public sealed class XRequest
    {
        /// <summary>
        /// 带Cookie请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="json">请求参数</param>
        /// <param name="cookie">Cookie</param>
        /// <returns></returns>
        public static async Task<string> PostWithCookie(string url, JObject json, string cookie)
        {
            string result = string.Empty;
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(json.ToString());
                HttpWebRequest request = WebRequest.CreateHttp(url);
                request.Method = "POST";
                request.Accept = "application/json; charset=utf-8";
                request.ContentType = "application/json";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.75 Safari/537.36";
                request.Timeout = 60000;
                request.Headers[HttpRequestHeader.Cookie] = cookie;
                request.ContentLength = data.Length;
                Stream requeststream = await request.GetRequestStreamAsync();
                await requeststream.WriteAsync(data, 0, data.Length);
                await requeststream.FlushAsync();
                requeststream.Close();
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                Stream backstream = response.GetResponseStream();
                if (backstream == null)
                {
                    return result;
                }

                var encode = !string.IsNullOrEmpty(response.ContentEncoding) ? response.ContentEncoding : "";
                StreamReader reader;
                switch (encode.ToLower())
                {
                    case "gzip":
                        reader = new StreamReader(new GZipStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    case "deflate":
                        reader = new StreamReader(new DeflateStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    default:
                        reader = new StreamReader(backstream, Encoding.UTF8);
                        break;
                }
                result = await reader.ReadToEndAsync();
                reader.Close();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 带Cookie请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="dic">请求参数</param>
        /// <param name="cookie">Cookie</param>
        /// <returns></returns>
        public static async Task<string> PostWithCookie(string url, Dictionary<string, string> dic, string cookie)
        {
            string result = string.Empty;
            try
            {
                StringBuilder sb = new StringBuilder();
                if (dic != null && dic.Count > 0)
                {
                    foreach (KeyValuePair<string, string> item in dic)
                    {
                        if (sb.Length > 0)
                        {
                            sb.Append("&");
                        }
                        sb.AppendFormat("{0}={1}", item.Key, item.Value);
                    }
                }
                byte[] data = Encoding.UTF8.GetBytes(sb.ToString());
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                request.Referer = url;
                request.Accept = "*";
                request.Timeout = 60000;
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.75 Safari/537.36";
                request.Method = "POST";
                request.Headers[HttpRequestHeader.Cookie] = cookie;
                request.ContentLength = data.Length;
                Stream stream = await request.GetRequestStreamAsync();
                await stream.WriteAsync(data, 0, data.Length);
                await stream.FlushAsync();
                stream.Close();
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                Stream backstream = response.GetResponseStream();
                if (backstream == null)
                {
                    return result;
                }

                var encode = !string.IsNullOrEmpty(response.ContentEncoding) ? response.ContentEncoding : "";
                StreamReader reader;
                switch (encode.ToLower())
                {
                    case "gzip":
                        reader = new StreamReader(new GZipStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    case "deflate":
                        reader = new StreamReader(new DeflateStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    default:
                        reader = new StreamReader(backstream, Encoding.UTF8);
                        break;
                }
                result = await reader.ReadToEndAsync();
                reader.Close();
                response.Close();
                request.Abort();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<ResponseInfo> PostFetchCookie(string url, Dictionary<string, string> dic)
        {
            ResponseInfo result = new ResponseInfo();
            try
            {
                StringBuilder sb = new StringBuilder();
                if (dic != null && dic.Count > 0)
                {
                    foreach (KeyValuePair<string, string> item in dic)
                    {
                        if (sb.Length > 0)
                        {
                            sb.Append("&");
                        }
                        sb.AppendFormat("{0}={1}", item.Key, item.Value);
                    }
                }
                byte[] data = Encoding.UTF8.GetBytes(sb.ToString());
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                request.Referer = url;
                request.Accept = "*";
                request.Timeout = 60000;
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.75 Safari/537.36";
                request.Method = "POST";
                request.ContentLength = data.Length;
                Stream stream = await request.GetRequestStreamAsync();
                await stream.WriteAsync(data, 0, data.Length);
                await stream.FlushAsync();
                stream.Close();
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                Stream backstream = response.GetResponseStream();
                if (backstream == null)
                {
                    return result;
                }

                var encode = !string.IsNullOrEmpty(response.ContentEncoding) ? response.ContentEncoding : "";
                StreamReader reader;
                switch (encode.ToLower())
                {
                    case "gzip":
                        reader = new StreamReader(new GZipStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    case "deflate":
                        reader = new StreamReader(new DeflateStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    default:
                        reader = new StreamReader(backstream, Encoding.UTF8);
                        break;
                }

                var xcookie = response.GetResponseHeader("Set-Cookie");
                if (!string.IsNullOrEmpty(xcookie))
                {
                    var xtemp = xcookie.Split(';');
                    if (xtemp.Length >= 1)
                    {
                        result.Cookie = xtemp[0];
                    }
                }
                result.Result = await reader.ReadToEndAsync();
                reader.Close();
                response.Close();
                request.Abort();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #region POST请求

        /// <summary>
        /// 发送POST请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="param">参数字符串</param>
        public static async Task<string> Post(string url, string param)
        {
            string result = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.22 Safari/537.36 SE 2.X MetaSr 1.0";
                request.ContentType = "application/x-www-form-urlencoded";
                request.Accept = "*/*";
                request.Timeout = 60000;
                request.AllowAutoRedirect = false;
                StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.UTF8);
                await writer.WriteAsync(param);
                writer.Close();
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                Stream backstream = response.GetResponseStream();
                if (backstream == null)
                {
                    return result;
                }

                var encode = !string.IsNullOrEmpty(response.ContentEncoding) ? response.ContentEncoding : "";
                StreamReader reader;
                switch (encode.ToLower())
                {
                    case "gzip":
                        reader = new StreamReader(new GZipStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    case "deflate":
                        reader = new StreamReader(new DeflateStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    default:
                        reader = new StreamReader(backstream, Encoding.UTF8);
                        break;
                }
                result = await reader.ReadToEndAsync();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 发送POST请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="param">参数字符串</param>
        /// <param name="contenttype">请求内容类型</param>
        public static async Task<string> Post(string url, string param, string contenttype)
        {
            string result = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.22 Safari/537.36 SE 2.X MetaSr 1.0";
                request.ContentType = contenttype;
                request.Accept = "*/*";
                request.Timeout = 60000;
                request.AllowAutoRedirect = false;
                StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.UTF8);
                await writer.WriteAsync(param);
                writer.Close();
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                Stream backstream = response.GetResponseStream();
                if (backstream == null)
                {
                    return result;
                }

                var encode = !string.IsNullOrEmpty(response.ContentEncoding) ? response.ContentEncoding : "";
                StreamReader reader;
                switch (encode.ToLower())
                {
                    case "gzip":
                        reader = new StreamReader(new GZipStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    case "deflate":
                        reader = new StreamReader(new DeflateStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    default:
                        reader = new StreamReader(backstream, Encoding.UTF8);
                        break;
                }
                result = await reader.ReadToEndAsync();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 以JSON格式发起Post请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="json">json数据</param>
        /// <returns></returns>
        public static async Task<string> Post(string url, JObject json)
        {
            string result = string.Empty;
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(json.ToString());
                HttpWebRequest request = WebRequest.CreateHttp(url);
                request.Method = "POST";
                request.Accept = "application/json; charset=utf-8";
                request.ContentType = "application/json";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.75 Safari/537.36";
                request.Timeout = 60000;
                request.ContentLength = data.Length;
                Stream requeststream = await request.GetRequestStreamAsync();
                await requeststream.WriteAsync(data, 0, data.Length);
                await requeststream.FlushAsync();
                requeststream.Close();
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                Stream backstream = response.GetResponseStream();
                if (backstream == null)
                {
                    return result;
                }

                var encode = !string.IsNullOrEmpty(response.ContentEncoding) ? response.ContentEncoding : "";
                StreamReader reader;
                switch (encode.ToLower())
                {
                    case "gzip":
                        reader = new StreamReader(new GZipStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    case "deflate":
                        reader = new StreamReader(new DeflateStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    default:
                        reader = new StreamReader(backstream, Encoding.UTF8);
                        break;
                }
                result = await reader.ReadToEndAsync();
                reader.Close();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 模拟表单方式发起Post请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="dic">请求参数</param>
        /// <returns></returns>
        public static async Task<string> Post(string url, Dictionary<string, string> dic)
        {
            string result = string.Empty;
            try
            {
                StringBuilder sb = new StringBuilder();
                if (dic != null && dic.Count > 0)
                {
                    foreach (KeyValuePair<string, string> item in dic)
                    {
                        if (sb.Length > 0)
                        {
                            sb.Append("&");
                        }
                        sb.AppendFormat("{0}={1}", item.Key, item.Value);
                    }
                }
                byte[] data = Encoding.UTF8.GetBytes(sb.ToString());
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                request.Referer = url;
                request.Accept = "*";
                request.Timeout = 60000;
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.75 Safari/537.36";
                request.Method = "POST";
                request.ContentLength = data.Length;
                Stream stream = await request.GetRequestStreamAsync();
                await stream.WriteAsync(data, 0, data.Length);
                await stream.FlushAsync();
                stream.Close();
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                Stream backstream = response.GetResponseStream();
                if (backstream == null)
                {
                    return result;
                }

                var encode = !string.IsNullOrEmpty(response.ContentEncoding) ? response.ContentEncoding : "";
                StreamReader reader;
                switch (encode.ToLower())
                {
                    case "gzip":
                        reader = new StreamReader(new GZipStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    case "deflate":
                        reader = new StreamReader(new DeflateStream(backstream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    default:
                        reader = new StreamReader(backstream, Encoding.UTF8);
                        break;
                }
                result = await reader.ReadToEndAsync();
                reader.Close();
                response.Close();
                request.Abort();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region GET请求

        public static async Task<string> GetWithCookie(string url, string cookie)
        {
            string result = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.UserAgent =
                    "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.22 Safari/537.36 SE 2.X MetaSr 1.0";
                request.Accept = "*/*";
                request.Timeout = 60000;
                request.AllowAutoRedirect = false;
                request.Headers[HttpRequestHeader.Cookie] = cookie;
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                Stream stream = response.GetResponseStream();
                if (stream == null)
                {
                    return result;
                }

                var encode = !string.IsNullOrEmpty(response.ContentEncoding) ? response.ContentEncoding : "";
                StreamReader reader;
                switch (encode.ToLower())
                {
                    case "gzip":
                        reader = new StreamReader(new GZipStream(stream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    case "deflate":
                        reader = new StreamReader(new DeflateStream(stream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    default:
                        reader = new StreamReader(stream, Encoding.UTF8);
                        break;
                }
                result = await reader.ReadToEndAsync();
                reader.Close();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public static async Task<HttpWebResponse> GetResponse(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.UserAgent =
                    "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.22 Safari/537.36 SE 2.X MetaSr 1.0";
                request.Accept = "*/*";
                request.Timeout = 60000;
                request.AllowAutoRedirect = false;
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                return response;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static async Task<string> Get(string url, Dictionary<string, string> headers = null, string agent = "")
        {
            string result = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
                request.Method = "GET";
                request.UserAgent = agent ??
                                    "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.22 Safari/537.36 SE 2.X MetaSr 1.0";
                request.Accept = "*/*";
                request.Timeout = 60000;
                request.AllowAutoRedirect = false;
                if (headers != null && headers.Count > 0)
                {
                    foreach (var item in headers)
                    {
                        if (!string.IsNullOrEmpty(request.Headers.Get(item.Key)))
                        {
                            continue;
                        }

                        request.Headers.Add(item.Key, item.Value);
                    }
                }

                HttpWebResponse response = (HttpWebResponse) await request.GetResponseAsync();
                Stream stream = response.GetResponseStream();
                if (stream == null)
                {
                    return result;
                }

                var encode = !string.IsNullOrEmpty(response.ContentEncoding) ? response.ContentEncoding : "";
                StreamReader reader;
                switch (encode.ToLower())
                {
                    case "gzip":
                        reader = new StreamReader(new GZipStream(stream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    case "deflate":
                        reader = new StreamReader(new DeflateStream(stream, CompressionMode.Decompress), Encoding.UTF8);
                        break;
                    default:
                        reader = new StreamReader(stream, Encoding.UTF8);
                        break;
                }

                result = await reader.ReadToEndAsync();
                reader.Close();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

    }
}