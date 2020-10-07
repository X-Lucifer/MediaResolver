using System;
using Newtonsoft.Json;

namespace X.MediaResolver.Models
{
    /// <summary>
    /// 系统配置
    /// </summary>
    [JsonObject]
    public class XConfig
    {
        /// <summary>
        /// 保存路径
        /// </summary>
        [JsonProperty(PropertyName = "SavePath")]
        public string SavePath { get; set; }

        /// <summary>
        /// 是否下载封面
        /// </summary>
        [JsonProperty(PropertyName = "IsDownloadPoster")]
        public bool IsDownloadPoster { get; set; }

        /// <summary>
        /// 是否下载音频
        /// </summary>
        [JsonProperty(PropertyName = "IsDownloadVoice")]
        public bool IsDownloadVoice { get; set; }
    }
}