using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Problemario_1.Deportes
{
    class Deportistas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Deporte { get; set; }
        public string Horario { get; set; }
        public string Sexo { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - {Deporte} - {Horario}-{Sexo}";
        }
    }
}
