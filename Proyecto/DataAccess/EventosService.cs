using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Models;

namespace Proyecto.DataAccess
{
    public class EventosService : DBService
    {
            public void UpdateEvento(Evento evento)
            {
                Update(evento);
            }
            public void CreateEvento(Evento evento)
            {
                Create(evento);
            }
    }
}