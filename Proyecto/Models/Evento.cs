using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Evento
    {
        public virtual int Id { get; set; }
        public virtual string Longitud { get; set; }
        public virtual string Latitud { get; set; }
        public virtual string Imputados { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual string Denunciante { get; set; }
        public virtual string Victimas { get; set; }
        public virtual string Detalle { get; set; }
        public virtual int TipoDelito { get; set; }
        public virtual string Direccion { get; set; }
        public virtual string TheGeom { get; set; }
    }
}