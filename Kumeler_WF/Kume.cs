using System;
using System.Collections;
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
        public double YediElemanli(int x)
        {
            return (x * (x - 1) * (x - 2) * (x - 3) * (x - 4) * (x - 5) * (x - 6)) / 5040;
        }
        public double EnFazlaIkiElemanli(int x)
        {
            return 1 + x + İkiElemanli(x);
        }
        public double EnFazlaUcElemanli(int x)
        {
            return 1 + x + İkiElemanli(x) + UcElemanli(x);
        }
        public double EnFazlaDortElemanli(int x)
        {
            return 1 + x + İkiElemanli(x) + UcElemanli(x);
        }
        public double EnFazlaBesElemanli(int x)
        {
            return 1 + x + İkiElemanli(x) + UcElemanli(x) + DortElemanli(x);
        }
        public double EnFazlaAltiElemanli(int x)
        {
            return 1 + x + İkiElemanli(x) + UcElemanli(x) + DortElemanli(x) + BesElemanli(x);
        }
        public double EnAzİkiElemanli(int x)
        {
            switch (x)
            {
                case 2: return 1;
                case 3: return 1 + İkiElemanli(x);
                case 4: return 1 + UcElemanli(x) + İkiElemanli(x);
                case 5: return 1 + DortElemanli(x) + UcElemanli(x) + İkiElemanli(x);
                case 6: return 1 + BesElemanli(x) + DortElemanli(x) + UcElemanli(x) + İkiElemanli(x);
                case 7: return 1 + AltiElemanli(x) + BesElemanli(x) + DortElemanli(x) + UcElemanli(x) + İkiElemanli(x);
                default:
                    return -1;
            }
        }
        public double EnAzUcElemanli(int x)
        {
            switch (x)
            {
                case 3: return 1;
                case 4: return 1 + UcElemanli(x);
                case 5: return 1 + DortElemanli(x) + UcElemanli(x);
                case 6: return 1 + BesElemanli(x) + DortElemanli(x) + UcElemanli(x);
                case 7: return 1 + AltiElemanli(x) + BesElemanli(x) + DortElemanli(x) + UcElemanli(x);
                default:
                    return -1;
            }
        }
        public double EnAzDortElemanli(int x)
        {
            switch (x)
            {
                case 4: return 1;
                case 5: return 1 + DortElemanli(x);
                case 6: return 1 + BesElemanli(x) + DortElemanli(x);
                case 7: return 1 + AltiElemanli(x) + BesElemanli(x) + DortElemanli(x);
                default:
                    return -1;
            }
        }
        public double EnAzBesElemanli(int x)
        {
            switch (x)
            {
                case 5: return 1;
                case 6: return 1 + BesElemanli(x);
                case 7: return 1 + AltiElemanli(x) + BesElemanli(x);
                default:
                    return -1;
            }
        }
        public double EnAzAltiElemanli(int x)
        {
            switch (x)
            {
                case 6: return 1;
                case 7: return 1 + AltiElemanli(x);
                default:
                    return -1;
            }
        }
        public double EnCokİkiElemanliAltKümeSayisiVerilen(bool b, int x)
        {
            var y = 0;
            if (b)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        if ((i * j) == ((x - 1) * 2))
                        {
                            y = j; break;
                        }
                    }
                    if (y > 0) break;
                }
            }

            return y;
        }
        public double EnCokUcElemanliAltKumeSayisiVerilirse(bool b, int x)
        {
            var y = -1;
            if (b)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = i + 2; j < 11; j++)
                    {
                        if (((i * j) + 6) * (i + 1) == ((x - 1) * 6))
                        {
                            y = i + 1; break;
                        }
                    }
                    if (y > 0)
                    {
                        break;
                    }
                }
            }
            return y;
        }
    }
}
