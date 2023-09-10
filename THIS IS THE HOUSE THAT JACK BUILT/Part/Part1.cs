using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THIS_IS_THE_HOUSE_THAT_JACK_BUILT;

namespace THIS_IS_THE_HOUSE_THAT_JACK_BUILT
{
    internal class Part1
    {
        public ImmutableList<string> Poem { get; set; }

        public void AddPart()
        {
            ImmutableList<string> newPoem = ImmutableList.Create("Вот дом,\r\nКоторый построил Джек.");
            Poem = newPoem;
        }
    }
}
