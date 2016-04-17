using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumeler_WF
{
    class Kume
    {
        public string KumeAd { get; set; }
        public List<object> KumeElemanlari { get; set; }
        public double AltKume(int x)
        {
            return Math.Pow(2, x);
        }
        public double OzAltKume(int x)
        {
            return Math.Pow(2, x) - 1;
        }
        public double İkiElemanli(int x)
        {
            return (x * (x - 1)) / 2;
        }
        public double UcElemanli(int x)
        {
            return (x * (x - 1) * (x - 2)) / 6;
        }
        public double DortElemanli(int x)
        {
            return (x * (x - 1) * (x - 2) * (x - 3)) / 24;
        }
        public double BesElemanli(int x)
        {
            return (x * (x - 1) * (x - 2) * (x - 3) * (x - 4)) / 120;
        }
        public double AltiElemanli(int x)
        {
            return (x * (x - 1) * (x - 2) * (x - 3) * (x - 4) * (x - 5)) / 720;
        }

    }
}
