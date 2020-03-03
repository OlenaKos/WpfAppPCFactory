using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPCFactory
{
    class GamePCFactory : IPCFactory
    {

        public Box CreateBox()
        {
            return new GameBox();
        }
        public Processor CreateProcessor()
        {
            return new GameProcessor();
        }
        public MainBoard CreateMainBoard()
        {
            return new GameMainBoard();
        }
        public SDD CreateSDD()
        {
            return new GameSDD();
        }
        public Memory CreateMemory()
        {
            return new GameMemory();
        }
    }
}
