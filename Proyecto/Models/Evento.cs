using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public DateTime Fecha { get; set; }
        public string Denunciante { get; set; }
        public string Victimas { get; set; }
        public string Detalle { get; set; }
        public int TipoDelitoId { get; set; }
        public TipoDelito TipoDelito { get; set; }
        public string Direccion { get; set; }
    }
}