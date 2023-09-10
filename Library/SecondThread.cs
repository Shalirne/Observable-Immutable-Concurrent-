using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class SecondThread
    {
        public async Task Percent()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (Program.library.Count != 0)
                {
                    foreach (var pair in Program.library)
                    {
                        if (pair.Value < 100)
                        {
                            Program.library[pair.Key] = pair.Value + 1;
                        }
                    }
                }
            }
        }
    }
}