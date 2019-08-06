using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CasperAsp.Models
{
    public class Users
    {
        [DisplayName("Identifiant")]
        public string UserName { get; set; }

        [DisplayName("PassWord")]
        public string UserPassword { get; set; }
    }
}