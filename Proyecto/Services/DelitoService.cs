
using Proyecto.Models;
using Proyecto.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Services
{
    public class DelitoService
    {
        public static bool AltaDelito(Delito delito)
        {
            return ProviderService.ExecuteNonQuery(String.Format(@"INSERT INTO delitos (tipo_delito, es_prevenible) VALUES ('{0}', '{1}')" , delito.tipo_delito, delito.es_prevenible));
        }

        public static bool BajaDelito(int delitoID)
        {
            return ProviderService.ExecuteNonQuery(@"DELETE FROM delitos WHERE id = " + delitoID);
        }

        public static bool ActualizarDelito(Delito delito)
        {
            return ProviderService.ExecuteNonQuery(String.Format(@"UPDATE delitos SET tipo_delito='{0}',  es_prevenible='{1}' WHERE id='{2}'",delito.tipo_delito ,delito.es_prevenible,delito.id);
        }


    }
}