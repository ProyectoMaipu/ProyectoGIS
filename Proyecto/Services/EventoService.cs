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
            return _providerService.ExecuteNonQuery(String.Format(@"INSERT INTO evento (the_geom, fecha, denunciante, victimas, detalle, tipo_delito, direccion) VALUES (ST_GeomFromText('POINT({0} {1})', 4326)), '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", evento.Longitud, evento.Latitud,evento.Fecha, evento.Denunciante, evento.Victimas, evento.Detalle, evento.TipoDelito, evento.Direccion));
        }
    }
}