using MinhaAPI.Business.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaAPI.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();

        List<Notificacao> GetNotificacoes();

        void Handle(Notificacao notificacao);
    }
}
