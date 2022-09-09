using NetworkLibrary.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator
{
    public class BaseInfoControl : UserControl
    {
        public ActionInfo CurrentInfo { get; protected set; } =  new ActionInfo();

        public ServerHost Server { get; set; }

    }
}
