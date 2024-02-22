using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Counter
    {
        public int count = 0;
        private static Counter? instance = null;

        private Counter() { }

        public static Counter Create()
        {
            if(instance == null)
            {
                instance = new Counter();
            }
            return instance;
        }

        public  void Add()
        {
            count++;
        }
        

    }
}
