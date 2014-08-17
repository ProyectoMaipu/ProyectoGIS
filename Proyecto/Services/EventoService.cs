using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Service;

namespace Proyecto.Services
{
    public class EventoService
    {
        public static bool AltaEvento(Evento evento)
        {
            return ProviderService.ExecuteNonQuery(String.Format(@"INSERT INTO evento (the_geom, fecha, denunciante, victimas, detalle, tipo_delito, direccion) VALUES (ST_GeomFromText('POINT({0} {1})', 4326)), '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", evento.longitud, evento.latitud,evento.fecha, evento.denunciante, evento.victimas, evento.detalle, evento.tipo_delito, evento.direccion));
        }
    }
}