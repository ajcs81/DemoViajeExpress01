using System;
using System.Collections.Generic;
using System.Text;
using Nimbussoft.BaseDeDatos;

namespace viaje.express.model.ModelRuta
{
    public class InsertarRuta
    {
        [Columna("id_cooperativa")]
        public int id_cooperativa { get; set; }

        [Columna("nombre_ruta")]
        public string nombre_ruta { get; set; }

        [Columna("origen_lat")]
        public double origen_lat { get; set; }

        [Columna("origen_lng")]
        public double origen_lng { get; set; }

        [Columna("destino_lat")]
        public double destino_lat { get; set; }

        [Columna("destino_lng")]
        public double destino_lng { get; set; }

        [Columna("distancia")]
        public double distancia { get; set; }

        [Columna("tiempo")]
        public double tiempo { get; set; }

        [Columna("monto")]
        public double monto { get; set; }

        [Columna("created_by")]
        public int created_by { get; set; }
    }
}
