using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    public class VisszavalthatoPalack : Palack
    {
        private int palackdij;

        public VisszavalthatoPalack(string ital, int maxUrtartalom, int jelenlegiUrtartalom = 1, int palackdij = 25)
            : base(ital, maxUrtartalom, jelenlegiUrtartalom)
        {
            this.palackdij = palackdij;
        }

        public override string ToString()
        {
            return $"Visszavaltható palack, benne levo ital: {ital}, jelenleg {jelenlegiUrtartalom} ml van benne, maximum {maxUrtartalom} ml fer bele.";
        }

        public int Palackdij
        {
            get { return palackdij; }
        }
    }

}
