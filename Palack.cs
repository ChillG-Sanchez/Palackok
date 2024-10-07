using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    public class Palack
    {
        protected string ital;
        protected int maxUrtartalom;
        protected int jelenlegiUrtartalom;

        public Palack(string ital, int maxUrtartalom, int jelenlegiUrtartalom = 1)
        {
            this.ital = ital;
            this.maxUrtartalom = maxUrtartalom;
            this.JelenlegiUrtartalom = jelenlegiUrtartalom;
        }

        public Palack(string ital, int maxUrtartalom, int jelenlegiUrtartalom, int initialUrtartalom) : this(ital, maxUrtartalom, jelenlegiUrtartalom)
{
    JelenlegiUrtartalom = initialUrtartalom;
}

        public int JelenlegiUrtartalom
        {
            get { return jelenlegiUrtartalom; }
            set
            {
                if (value > maxUrtartalom)
                {
                    jelenlegiUrtartalom = maxUrtartalom;
                }
                else
                {
                    jelenlegiUrtartalom = value;
                }

                if (jelenlegiUrtartalom == 0)
                {
                    ital = null;
                }
            }
        }

        public double Suly()
        {
            return (double)maxUrtartalom / 35 + jelenlegiUrtartalom;
        }

        public override string ToString()
        {
            return $"Palack, benne levo ital: {(string.IsNullOrEmpty(ital) ? "üres palack" : ital)}, jelenleg {jelenlegiUrtartalom} ml van benne, maximum {maxUrtartalom} ml fer bele.";
        }

        public override bool Equals(object obj)
        {
            if (obj is Palack other)
            {
                return this.ital == other.ital &&
                       this.maxUrtartalom == other.maxUrtartalom &&
                       this.jelenlegiUrtartalom == other.jelenlegiUrtartalom;
            }
            return false;
        }

        public void HozzaOnt(Palack masikPalack)
        {
            if (this.ital == null || masikPalack.ital == null) return;

            if (this.ital != masikPalack.ital)
            {
                if (this.jelenlegiUrtartalom > 0)
                {
                    this.ital = "keverek";
                }
                else
                {
                    this.ital = masikPalack.ital;
                }
            }

            this.JelenlegiUrtartalom += masikPalack.jelenlegiUrtartalom;
        }
    }
}
