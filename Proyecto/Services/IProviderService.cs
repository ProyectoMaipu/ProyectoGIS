using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Models;

namespace Proyecto.Services
{
   public interface IProviderService
    {
       List<TipoDelito> ExecuteReaderTipoDelito(string comando);
       bool ExecuteNonQuery(string comando);
    }
}
