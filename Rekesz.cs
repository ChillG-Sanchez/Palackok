using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    public class Rekesz
    {
        private int maxTeherbiras;
        private List<Palack> palackok;

        public Rekesz(int maxTeherbiras)
        {
            this.maxTeherbiras = maxTeherbiras;
            this.palackok = new List<Palack>();
        }

        public double Suly()
        {
            double totalWeight = 0;
            foreach (var palack in palackok)
            {
                totalWeight += palack.Suly();
            }
            return totalWeight;
        }

        public void UjPalack(Palack ujPalack)
        {
            if (Suly() + ujPalack.Suly() <= maxTeherbiras)
            {
                palackok.Add(ujPalack);
            }
        }

        public int OsszesPenz()
        {
            int totalPenz = 0;
            foreach (var palack in palackok)
            {
                if (palack is VisszavalthatoPalack visszavalthato)
                {
                    totalPenz += visszavalthato.Palackdij;
                }
            }
            return totalPenz;
        }
    }
}
