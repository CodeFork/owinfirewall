﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Daenet.Owin;

[assembly: OwinStartup(typeof(OwinASPNet.Startup))]

namespace OwinASPNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseOwinFirewall(new Daenet.Owin.OwinFirewallOptions(new List<string>() { "79.206.242.74", "::21", "localhost", "212.144.228.0/24", "62.96.6.0/27" }));

            app.Use((context, next) =>
            {
                return next.Invoke();
            });
           
        }
    }
}