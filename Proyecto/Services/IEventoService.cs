using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Models;
namespace Proyecto.Services
{
    public interface IEventoService
    {
        bool AltaEvento(Evento evento);
    }
}