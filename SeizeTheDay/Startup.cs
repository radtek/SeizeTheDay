﻿using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SeizeTheDay.Startup))]
namespace SeizeTheDay
{
    public partial class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            HubConfiguration config = new HubConfiguration
            {
                EnableJavaScriptProxies = true
            };
            app.MapSignalR();
        }
    }
}
