using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;

[assembly: OwinStartup(typeof(MVC_Day4.Startup))]

namespace MVC_Day4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
