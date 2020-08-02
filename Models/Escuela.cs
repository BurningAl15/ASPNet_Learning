using System;
using System.Collections.Generic;

namespace holaMundo.Models
{
    public class Escuela:ObjetoEscuelaBase
    {
        public int CreationYear { get; set; }

        public string Country { get; set; }
        public string City { get; set; }

        public string Direction { get; set; }

        public TiposEscuela school_Type { get; set; }
        public List<Curso> Courses { get; set; }

        public Escuela(string _name, int _year) => (_name, CreationYear) = (_name, _year);

        public Escuela(string _name, int _year, 
                       TiposEscuela schoolType, 
                       string Country = "", string City = "") : base()
        {
            (_name, CreationYear) = (_name, _year);
            this.Country = Country;
            this.City = City;
        }

        public override string ToString()
        {
            return $"_name: \"{Name}\", Tipo: {school_Type} {System.Environment.NewLine} Country: {Country}, City:{City}";
        }

    }
}
