using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CKQXM.API.Model
{
    public class LoginModel
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public string AccountPassword { get; set; }
    }
}
