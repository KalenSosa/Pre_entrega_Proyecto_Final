using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_sql
{
    internal class Venta
    {
        private long Id;
        private string Comentarios;
        private long IdUsuario;

        public long Id1 { get => Id; set => Id = value; }
        public string Comentarios1 { get => Comentarios; set => Comentarios = value; }
        public long IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
    }
}
