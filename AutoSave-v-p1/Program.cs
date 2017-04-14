using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSave_v_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your open app will be saved every 5 minutes");
            var timer = new System.Threading.Timer((e) =>
            {
                Save();
            }, null, 0, (int)TimeSpan.FromMinutes(5).TotalMilliseconds);

            Application.Run();
        }

        private static void Save()
        {
            SendKeys.SendWait("^s");
            Console.WriteLine("Saving files!");
        }
    }
}
