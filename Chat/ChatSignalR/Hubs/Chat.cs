using System;
using ChatSignalR.DAO.Hubs;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs; 

namespace ChatSignalR.Hubs
{
    [HubName("chathub")]
    public class Chat : Hub
    {
        //Deve ter um metodo EnviarMensagem no JavaScript 
        public void EnviarMensagem(string remetente, string mensagem)
        {
            DateTime dataHora = DateTime.Now;

            //new ChatDAO().AdicionarMensagem(remetente, mensagem, dataHora);

            //Chama um metodo implementado no cliente via JavaScript
            Clients.All.adicionarMensagem(dataHora.ToString("HH:mm:ss"), remetente, mensagem);
        
        }
    }
}