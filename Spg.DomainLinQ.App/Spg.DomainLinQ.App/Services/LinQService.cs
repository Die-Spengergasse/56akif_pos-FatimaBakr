using Microsoft.EntityFrameworkCore.Query.Internal;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Services
{
    /// <summary>
    /// (8P)
    /// </summary>
    public class LinQService
    {
        private readonly School2000Context _db;
        public LinQService(School2000Context db)
        {
            _db = db;
        }

        public void Start()
        {
            // Gebe jenen Student mit der ID=12 zurück.
            var result01 = _db.students.SingleOrDefault(s => s.RegistrationNumber == 12);
           

            // Erstelle eine Liste aller Fächer, die eine negative Note haben.
            var result02 = _db.exams.Where(e => e.Grade > 4).ToList();

            // Erstelle eine Liste aller Fächer, die eine negative Note in POS haben.
            var result03 = _db.exams.Where(e => e.Grade > 4 && ).ToList();

            // Erstelle eine Liste aller Fächer, die nur positive Noten haben.
            var result04 = _db.subjects.Include(s => s.exams.Where(e => e.Grade < 5)).ToList();
            
   
            // Erstelle eine Liste aller Lehrer, die POS unterrichten
            var result05 = _db.teachers.Where(t => t.subjects.Any(s => s.Id == "POS")).ToList;

            // Erstelle eine Liste aller Students mit einer "hotmail"-E-Mail-Adresse
            var result06 = _db.students.Where(s => s.EMail.Contains("hotmail")).ToList();

            // Ermittle die schlechteste Note im Fach POS
            var result07 = _db.exams.Where(e => e.Grade > 4).ToList(); ;

            // Ermittle den Notendurchschnitt im Fach DBI
            var result08 = _db.exams.Where(e => e.subjects.Any (s => s)).avg();
        }
    }
}
