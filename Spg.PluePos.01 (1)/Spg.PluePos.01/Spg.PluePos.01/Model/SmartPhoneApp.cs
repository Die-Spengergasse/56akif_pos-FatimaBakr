using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    public abstract class SmartPhoneApp : List<SmartPhoneApp>
    {
        private string smartphoneId;

        public SmartPhoneApp(string SmartphoneId)
        {
            SmartphoneId = smartphoneId;
        }
        public string SmartphoneId { get; set; } = string.Empty;
        public List<Post> posts { get; set; } = new();
        public new void Add(Post p)
        {
            if (p is null)
            {
                throw new ArgumentNullException("P is null");
            }
            if (posts.Contains(p))
            {
                throw new ArgumentNullException("P ist schon vorhanden");
            }
            posts.Add(p);
        }
        public int CalcRating
        {
            get
            {
               

                for (int i = 0; i < posts.Count; i++)
                {
                    count++;
                }
            }
        }

        public string Title { get; } = string.Empty;
        
    }
}
