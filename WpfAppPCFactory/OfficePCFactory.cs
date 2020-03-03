using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPCFactory
{
    class OfficePCFactory : IPCFactory
    {
        public Box CreateBox()
        {
            return new WorkBox();
        }
        public Processor CreateProcessor()
        {
            return new WorkProcessor();
        }
        public MainBoard CreateMainBoard()
        {
            return new WorkMainBoard();
        }
        public SDD CreateSDD()
        {
            return new WorkSDD();
        }
        public Memory CreateMemory()
        {
            return new WorkMemory();
        }


    }
}
