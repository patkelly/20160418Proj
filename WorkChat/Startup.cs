﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WorkChat.Startup))]

namespace WorkChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //var idProvider = new CustomUserIdProvider();

            //GlobalHost.DependencyResolver.Register(typeof(IUserIdProvider), () => idProvider);
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.MapSignalR();
        }
    }
}
