using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Delito
    {
        public int id { get; set; }
        public int tipo_delito { get; set; }
        public bool es_prevenible { get; set; }
    }
}