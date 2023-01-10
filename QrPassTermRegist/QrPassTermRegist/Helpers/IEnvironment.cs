using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QrPassTermRegist.Helpers
{
    public interface IEnvironment
    {        
        void SetStatusBarColor(Color color, bool darkStatusBarTint);
    }
}
