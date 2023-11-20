using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLogin
{
    public interface IPanelNavbar
    {
        void PanelNavBar_MouseDown(object sender, MouseEventArgs e);
        void PanelNavBar_MouseUp(object sender, MouseEventArgs e);
        void PanelNavBar_MouseMove(object sender, MouseEventArgs e);
    }
}
