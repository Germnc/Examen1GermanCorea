using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Examen1GermanCorea.Models
{
    public class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string Apellidos { get; set; }

        
        public int Edad { get; set; }

        [MaxLength(20)]
        public string Pais { get; set; }

        public string Nota { get; set; }

        public double Latitud { get; set; }

        public double Longitud { get; set; }

    }
}
