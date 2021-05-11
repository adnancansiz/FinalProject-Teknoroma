using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.ViewModels
{
    public class LoginVM
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsPersistant { get; set; }

    }
}
