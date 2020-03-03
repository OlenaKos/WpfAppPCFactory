using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPCFactory
{
    class HomePCFactory : IPCFactory
    {

        public Box CreateBox()
        {
            return new HomeBox();
        }
        public Processor CreateProcessor()
        {
            return new HomeProcessor();
        }
        public MainBoard CreateMainBoard()
        {
            return new HomeMainBoard();
        }
        public SDD CreateSDD()
        {
            return new HomeSDD();
        }
        public Memory CreateMemory()
        {
            return new HomeMemory();
        }
    }
}
