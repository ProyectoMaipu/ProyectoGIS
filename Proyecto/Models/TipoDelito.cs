using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class TipoDelito
    {
        public int Id { get; set; }
        public int Nombre { get; set; }
        public bool EsPrevenible { get; set; }
    }
}