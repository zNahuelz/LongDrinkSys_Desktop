using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongDrinkSys_Local.Utils
{
    public class Tools
    {
        public static void Next(Control c, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) { c.Focus(); }
        }
    }
}
