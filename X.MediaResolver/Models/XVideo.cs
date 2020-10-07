using System.Drawing;

namespace X.MediaResolver.Models
{
    public class XVideo
    {
        public string Hash { get; set; }

        public string PosterUrl { get; set; }

        public Image Poster { get; set; }

        public string VideoUrl { get; set; }
    }
}