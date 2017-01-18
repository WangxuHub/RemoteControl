using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 远程控制
{
    public class AppConfig
    {
        public static string host = ConfigurationManager.AppSettings["hostPort"];
    }
}
