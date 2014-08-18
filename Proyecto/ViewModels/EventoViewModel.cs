using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Models;

namespace Proyecto.ViewModels
{
    public class EventoViewModel
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Denunciante { get; set; }
        public string Victimas { get; set; }
        public string Detalle { get; set; }
        public List<TipoDelito> TiposDelitos { get; set; }
        public int? TipoDelitoId { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
    }
}