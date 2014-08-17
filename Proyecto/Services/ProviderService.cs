using System.Collections.Generic;
using Npgsql;
using Proyecto.Models;

namespace Proyecto.Service
{
    public class ProviderService
    {
        const string ConnectionString = "server=192.168.0.9;port=5432;database=Proyecto;user id=postgres; Password=postgres";

        public static bool ExecuteNonQuery(string comando)
        {
            var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            comando = "INSERT INTO delitos (tipo_delito, es_prevenible) VALUES (3, 'N')";
            var command = new NpgsqlCommand(comando, conn);
            var filasCreadas = command.ExecuteNonQuery();
            conn.Close();
            return filasCreadas == 1;
        }

        public static List<Delito> ExecuteReaderDelito(string comando)
        {
            var lista = new List<Delito>();
            var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            var command = new NpgsqlCommand(comando, conn);
            var dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                lista.Add(new Delito()
                {
                    tipo_delito = dataReader.GetInt32(dataReader.GetOrdinal("tipo_delito")),
                    es_prevenible = dataReader.GetChar(dataReader.GetOrdinal("es_prevenible")),

                });
            }
            conn.Close();
            return lista;
        }
    }
}