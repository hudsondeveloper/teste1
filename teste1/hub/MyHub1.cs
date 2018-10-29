﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace teste1.hub
{
    public class MyHub1 : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void send(string nome, string mensagem)
        {
            Clients.All.broadcastMenssage(nome, mensagem);
        }
    }
}