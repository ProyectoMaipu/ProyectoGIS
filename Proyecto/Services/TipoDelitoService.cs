
using Proyecto.Models;
using Proyecto.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Services
{
    public class TipoDelitoService:ITipoDelitoService
    {
             public readonly IProviderService _providerService;
        //
        // GET: /TipoDelito/
        public TipoDelitoService(IProviderService providerService)
        {
            _providerService = providerService;
        }

        public bool AltaTipoDelito(TipoDelito tipoDelito)
        {
            return _providerService.ExecuteNonQuery(String.Format(@"INSERT INTO tipodelitos (nombre, esprevenible) VALUES ('{0}', '{1}')", tipoDelito.Nombre, tipoDelito.EsPrevenible));
        }

        public  bool BajaTipoDelito(int tipoDelitoID)
        {
            return _providerService.ExecuteNonQuery(@"DELETE FROM tipodelitos WHERE id = " + tipoDelitoID);
        }

        public bool ActualizarTipoDelito(TipoDelito tipoDelito)
        {
            return _providerService.ExecuteNonQuery(String.Format(@"UPDATE tipodelitos SET nombre='{0}',   esprevenible='{1}' WHERE id='{2}'", tipoDelito.Nombre, tipoDelito.EsPrevenible, tipoDelito.Id));
        }

        public  List<TipoDelito> GetAll()
        {
            return _providerService.ExecuteReaderTipoDelito("SELECT id, nombre, esprevenible FROM tipodelitos ORDER BY 1 ASC");
        }


    }
}