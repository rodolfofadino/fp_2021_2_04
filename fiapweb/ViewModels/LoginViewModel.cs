﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiapweb.ViewModels
{
    public class LoginViewModel
    {
        public string UserName{ get; set; }
        public string Password{ get; set; }
        public bool IsPersistent{ get; set; }
    }
}
