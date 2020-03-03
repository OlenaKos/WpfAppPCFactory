using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPCFactory
{
    class PCConfigurator
    {
        public PC CreatePC(IPCFactory factory)
        {
            PC pc = new PC(factory);
            return pc;
        }
    }
}
