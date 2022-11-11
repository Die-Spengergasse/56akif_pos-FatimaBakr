using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    public class TextPost : Post
    {
        public TextPost(string Title, DateTime? Created) : base(Title, Created)
        {
        }
        public TextPost(string Title) : base(Title)
        {

        }
        public string Content { get; set; } = string.Empty;
        private int contentLength;

        public int ContentLength
        {
            get
            {
                return Content.Length == null ? 0 : contentLength;
            }
        }

        public override string? Html => Content!=null? $"<h1>{Title}</h1><p>{Content}</p>":throw new ArgumentNullException("Content war NULL!");
    }
}
