using System;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;

namespace X.MediaResolver.Models
{
    public class XDownloader
    {
        /// <summary>
        /// 完成事件
        /// </summary>
        public event AsyncCompletedEventHandler OnFinished;

        /// <summary>
        /// 下载进度更新事件
        /// </summary>
        public event DownloadProgressChangedEventHandler OnChanged;

        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="config">配置</param>
        /// <param name="fileurl">源文件地址</param>
        /// <param name="hash">哈希</param>
        /// <param name="ext">扩展名</param>
        /// <param name="isevent">是否订阅事件</param>
        /// <returns></returns>
        public async Task Download(XConfig config, string fileurl, string hash, string ext, bool isevent = false)
        {
            try
            {
                WebClient client = new WebClient
                {
                    Headers =
                    {
                        ["Hash"] = hash
                    }
                };
                if (isevent)
                {
                    client.DownloadProgressChanged += OnChanged;
                    client.DownloadFileCompleted += OnFinished;
                }

                string filename = config.SavePath.EndsWith(@"\")
                    ? config.SavePath + hash +(ext.Contains(".")? ext:"."+ext)
                    : config.SavePath + @"\" + hash + (ext.Contains(".") ? ext : "." + ext);
                await client.DownloadFileTaskAsync(new Uri(fileurl), filename);
            }
            catch (Exception e)
            {
                await Task.Delay(1000);
            }
        }
    }
}