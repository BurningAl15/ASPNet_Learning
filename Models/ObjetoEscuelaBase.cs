using System;

namespace holaMundo.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ObjetoEscuelaBase()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Name},{Id}";
        }
    }
}