using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THIS_IS_THE_HOUSE_THAT_JACK_BUILT
{
    internal class Part2
    {
        public ImmutableList<string> Poem { get; set; }

        public void AddPart(ImmutableList<string> a)
        {
            ImmutableList<string> oldPoem = a;
            ImmutableList<string> newPoem = a.Add("А это пшеница,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.");
            Poem = newPoem;
        }
    }
}
