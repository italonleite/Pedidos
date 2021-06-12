﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace Pedidos.API.Controllers
{

    public class AppBaseController : ControllerBase
    {
        protected readonly IServiceProvider ServiceProvider;
        public AppBaseController(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
        
    }
}
