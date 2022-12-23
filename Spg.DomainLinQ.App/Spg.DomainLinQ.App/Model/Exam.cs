using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Date (?)
    /// * Lesson (int?)
    /// * Created
    /// * Guid
    /// * Grade (Note 1-5)
    /// (4P)
    /// </summary>
    public class Exam : EntityBase
    {
        protected Exam()
        {

        }

        public Exam(DateTime? date, int? lesson, string created, int guid, int grade)
        {
            Date = date;
            Lesson = lesson;
            Created = created;
            Guid = guid;
            Grade = grade;
        }

        // TODO: Implementation
        List<Subject> subjects { get; set; }= new();
        public DateTime? Date { get; private set; }
        public int? Lesson { get; set; }
        public string Created { get; set; } = string.Empty;
        public int? Guid { get; set; } 
        public int Grade { get; set; }

    }
}
