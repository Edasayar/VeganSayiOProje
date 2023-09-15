using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.Core.Enums;

namespace VeganCounter.UI.LoginUser
{
    public static class ActiveUser
    {
        public static string ActiveUserEmail { get; set; }

        public static Role Role { get; set; }
    }
}
