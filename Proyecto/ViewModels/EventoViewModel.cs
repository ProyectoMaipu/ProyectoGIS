using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Models;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.ViewModels
{
    public class EventoViewModel
    {   
        public int? Id { get; set; }
        [Display(Name="Dirección")]
        public string Direccion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Denunciante { get; set; }
        public string Victimas { get; set; }
        public string Detalle { get; set; }
        public string Imputados { get; set; }
        public List<TipoDelito> TiposDelitos { get; set; }
        [Display(Name = "Tipo de Delito")]
        public int? TipoDelito { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string Geom { get; set; }
    }
}