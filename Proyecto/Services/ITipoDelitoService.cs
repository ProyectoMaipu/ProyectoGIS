using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Models;

namespace Proyecto.Services
{
    public interface ITipoDelitoService
    {
        bool AltaTipoDelito(TipoDelito tipoDelito);
        bool BajaTipoDelito(int tipoDelitoID);
        bool ActualizarTipoDelito(TipoDelito tipoDelito);
        List<TipoDelito> GetAll();
    }
}