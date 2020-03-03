using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPCFactory
{
    class PC
    {

        public Box box { get; set; }
        public Processor processor { get; set; }
        public MainBoard mainBoard { get; set; }
        public SDD sdd { get; set; }
        public Memory memory { get; set; }

        public PC(IPCFactory factory)
        {
            box = factory.CreateBox();
            processor = factory.CreateProcessor();
            mainBoard = factory.CreateMainBoard();
            sdd = factory.CreateSDD();
            memory = factory.CreateMemory();
        }
    }
}
