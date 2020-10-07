using System.Drawing;

namespace X.MediaResolver.Models
{
    public class XAuthor
    {
        public string Hash { get; set; }

        public string Name { get; set; }

        public string UniqueId { get; set; }

        public string AvatarUrl { get; set; }

        public Image Avatar { get; set; }
    }
}