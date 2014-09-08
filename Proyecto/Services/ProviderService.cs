using System.Collections.Generic;
using Npgsql;
using Proyecto.Models;
using Proyecto.Services;

namespace Proyecto.Service
{
    public class ProviderService:IProviderService
    {
        const string ConnectionString = "server=192.168.0.16;port=5432;database=Proyecto;user id=postgres; Password=postgres";

        public bool ExecuteNonQuery(string comando)
        {
            var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            var command = new NpgsqlCommand(comando, conn);
            var filasCreadas = command.ExecuteNonQuery();
            conn.Close();
            return filasCreadas == 1;
        }

        public List<TipoDelito> ExecuteReaderTipoDelito(string comando)
        {
            var lista = new List<TipoDelito>();
            var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            var command = new NpgsqlCommand(comando, conn);
            var dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                lista.Add(new TipoDelito()
                {
                    Id = dataReader.GetInt32(dataReader.GetOrdinal("id")),
                    Nombre = dataReader.GetString(dataReader.GetOrdinal("nombre")),
                    EsPrevenible = dataReader.GetBoolean(dataReader.GetOrdinal("esPrevenible")),

                });
            }
            conn.Close();
            return lista;
        }
    }
}