using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 远程控制
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartHost();  //
        }

        public void StartHost() {
            using (WebApp.Start<Startup>(AppConfig.host))
            {
                Console.WriteLine("server running...");
                Console.ReadLine();
            }
        }
    }

    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ;
        }
    }
}
