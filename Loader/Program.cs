using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using undericalloader.Auth;

namespace undericalloader
{
    internal static class Program
    {
        public static api KeyAuthApp = new api(
            name: "FiveM1", // change
            ownerid: "PwBTV43ofz", // change
            secret: "226b407f71d9c16679b3c42401bcb21a2f651375df726c7f247b6b325fd21272", // change
            version: "1.0" // change
        );
        [STAThread]
        static void Main()
        {
            KeyAuthApp.init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
