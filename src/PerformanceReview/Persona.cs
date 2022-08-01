using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReview
{
    public class Persona
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Persona(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public Persona() {
        }

        public List<string> GetMails(List<Persona> personas) {
            var query=personas.Select(persona => persona.Email).ToList();
            return query;
        }

        public Persona MayorPrimero(List<Persona> personas)
        {
            var query = personas.Where(persona=>persona.BirthDate>DateTime.Parse("08/15/1999"));
            return query.First();
        }
    }
}
