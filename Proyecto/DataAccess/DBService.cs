using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using Proyecto.Models;

namespace Proyecto.DataAccess
{
    public class DBService
    {
        private ISession _mSession;

        public void SetSession(ISession session)
        {
            _mSession = session;
        }

        public void Update(Object obj)
        {

            using (var transaction = _mSession.BeginTransaction())
            {
                _mSession.Update(obj);
                transaction.Commit();
            }


        }

        public void Delete(Object obj)
        {

            using (var transaction = _mSession.BeginTransaction())
            {
                _mSession.Delete(obj);
                transaction.Commit();
            }


        }

        public void Create(Object obj)
        {

            using (var transaction = _mSession.BeginTransaction())
            {
                _mSession.Save(obj);
                transaction.Commit();
            }


        }

        public Evento GetEvento(int eventoId)
        {
            //Revisar si esta bien planteado
            using (var transaction = _mSession.BeginTransaction())
            {
              var evento=(Evento)  _mSession.Get("Evento",eventoId);
              transaction.Dispose();
              return evento;
            }


        }
    }
}