using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    public abstract class Post
    {
        public Post(string Title, DateTime? Created)
        {
            title = Title;
            this.Created = Created;
        }
        public Post(string Title)
        {
            this.Created = DateTime.Now;
        }


        public string Title => title != null ? title : throw new ArgumentNullException("Titel war NULL");

        private string title;

        public DateTime? Created { get; }
        private int rating;
        private SmartPhoneApp? smartPhone;
        private readonly string? html;

        public int Rating
        {
            get
            {
                if (rating >= 1 && rating <= 5)
                {
                    return rating;
                }
                throw new ArgumentOutOfRangeException("Range muss zwischen 1 und 5 liegen!");
            }

        }
        public abstract string? Html { get; }
    }
}
