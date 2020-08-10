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
        public List<Curso> Cursos { get; set; }

        public Escuela(){
            this.Name="Camacho's School";
            this.CreationYear=2005;
        }

        public Escuela(string _name, int _year){
            this.Name=_name;
            this.CreationYear=_year;
        }

        public override string ToString()
        {
            return $"_name: \"{Name}\", Tipo: {school_Type} {System.Environment.NewLine} Country: {Country}, City:{City}";
        }

    }
}
