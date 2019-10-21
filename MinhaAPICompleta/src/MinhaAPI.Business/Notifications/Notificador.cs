using MinhaAPI.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaAPI.Business.Notifications
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacaos;

        public Notificador()
        {
            _notificacaos = new List<Notificacao>();
        }

        public List<Notificacao> GetNotificacoes()
        {
            throw new NotImplementedException();
        }

        public void Handle(Notificacao notificacao)
        {
            throw new NotImplementedException();
        }

        public bool TemNotificacao()
        {
            throw new NotImplementedException();
        }
    }
}
