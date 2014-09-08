using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Service;

namespace Proyecto.Services
{
    public class EventoService:IEventoService
    {

        public readonly IProviderService _providerService;
        //
        // GET: /TipoDelito/
        public EventoService()
        {
          var _providerService = new ProviderService();
        }

        public bool AltaEvento(Evento evento)
        {
            var _providerService = new ProviderService();
            var fechaParseada = String.Format("{0:yyyy-MM-dd HH:mm:ss}", evento.Fecha);
            return _providerService.ExecuteNonQuery(String.Format(@"INSERT INTO eventos (the_geom, fecha, denunciante, victimas, detalle, tipodelito, direccion) VALUES (ST_GeomFromText('POINT({0} {1})', 4326), '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", evento.Longitud, evento.Latitud, fechaParseada, evento.Denunciante, evento.Victimas, evento.Detalle, evento.TipoDelito, evento.Direccion));
        }
    }
}