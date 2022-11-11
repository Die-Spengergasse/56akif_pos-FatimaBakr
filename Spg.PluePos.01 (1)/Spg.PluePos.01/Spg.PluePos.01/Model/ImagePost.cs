using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    public class ImagePost : Post
    {
        private string? url = string.Empty;

        public ImagePost(string Title, DateTime? Created) : base(Title, Created)
        {
        }
        public ImagePost(string Title, string Url):base(Title)
        {
            this.Url = Url;
        }
        public string? Url { get => url; set => url = value; }
        public override string? Html => Url != null ? $"<h1>{Title}</h1><img src={Url} />" : throw new ArgumentNullException("Url war NULL!");
    }
}
