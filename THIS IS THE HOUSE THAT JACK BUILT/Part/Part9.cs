﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace THIS_IS_THE_HOUSE_THAT_JACK_BUILT
{
    internal class Part9
    {
        public ImmutableList<string> Poem { get; set; }

        public void AddPart(ImmutableList<string> a)
        {
            ImmutableList<string> oldPoem = a;
            ImmutableList<string> newPoem = a.Add("Вот два петуха,\r\nКоторые будят того пастуха,\r\nКоторый бранится с коровницей строгою,\r\nКоторая доит корову безрогую,\r\nЛягнувшую старого пса без хвоста,\r\nКоторый за шиворот треплет кота,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.");
            Poem = newPoem;
        }
    }
}
