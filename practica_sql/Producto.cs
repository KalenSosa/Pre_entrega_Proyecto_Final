using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_sql
{
    internal class Producto
    {
        private long Id;
        private string Descripciones;
        private float Costo;
        private float PrecioVenta;
        private int Stock;
        private long IdUsuario;

        public long Id1 { get => Id; set => Id = value; }
        public string Descripciones1 { get => Descripciones; set => Descripciones = value; }
        public float Costo1 { get => Costo; set => Costo = value; }
        public float PrecioVenta1 { get => PrecioVenta; set => PrecioVenta = value; }
        public int Stock1 { get => Stock; set => Stock = value; }
        public long IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
    }
}
