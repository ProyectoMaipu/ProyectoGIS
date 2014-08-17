using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Evento
    {
        public int id { get; set; }
        public string longitud { get; set; }
        public string latitud { get; set; }
        public string fecha { get; set; }
        public string denunciante { get; set; }
        public string victimas { get; set; }
        public string detalle { get; set; }
        public int tipo_delito { get; set; }
        public string direccion { get; set; }
    }
}