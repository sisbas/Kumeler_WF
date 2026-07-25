using System;
using System.Collections.Generic;

namespace Kumeler_WF
{
    /// <summary>
    /// Represents a mathematical set and provides methods for calculating subset properties.
    /// </summary>
    public class Kume
    {
        public string KumeAd { get; set; }
        public List<object> KumeElemanlari { get; set; }

        /// <summary>
        /// Calculates the number of subsets of a set with n elements (2^n).
        /// </summary>
        public double AltKume(int n)
        {
            return Math.Pow(2, n);
        }

        /// <summary>
        /// Calculates the number of proper subsets (2^n - 1).
        /// </summary>
        public double OzAltKume(int n)
        {
            return Math.Pow(2, n) - 1;
        }

        /// <summary>
        /// Alias for AltKume - calculates 2^n.
        /// </summary>
        public double Gicik(int n)
        {
            return Math.Pow(2, n);
        }

        /// <summary>
        /// Calculates the binomial coefficient C(n, k) - number of k-element subsets from n elements.
        /// </summary>
        private double Kombinasyon(int n, int k)
        {
            if (k < 0 || k > n) return 0;
            if (k == 0 || k == n) return 1;
            
            long result = 1;
            for (int i = 0; i < k; i++)
            {
                result = result * (n - i) / (i + 1);
            }
            return result;
        }

        public double İkiElemanli(int n) => Kombinasyon(n, 2);
        public double UcElemanli(int n) => Kombinasyon(n, 3);
        public double DortElemanli(int n) => Kombinasyon(n, 4);
        public double BesElemanli(int n) => Kombinasyon(n, 5);
        public double AltiElemanli(int n) => Kombinasyon(n, 6);
        public double YediElemanli(int n) => Kombinasyon(n, 7);

        /// <summary>
        /// Calculates the number of subsets with at most 2 elements.
        /// </summary>
        public double EnFazlaIkiElemanli(int n)
        {
            return 1 + n + İkiElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at most 3 elements.
        /// </summary>
        public double EnFazlaUcElemanli(int n)
        {
            return 1 + n + İkiElemanli(n) + UcElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at most 4 elements.
        /// </summary>
        public double EnFazlaDortElemanli(int n)
        {
            return 1 + n + İkiElemanli(n) + UcElemanli(n) + DortElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at most 5 elements.
        /// </summary>
        public double EnFazlaBesElemanli(int n)
        {
            return 1 + n + İkiElemanli(n) + UcElemanli(n) + DortElemanli(n) + BesElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at most 6 elements.
        /// </summary>
        public double EnFazlaAltiElemanli(int n)
        {
            return 1 + n + İkiElemanli(n) + UcElemanli(n) + DortElemanli(n) + BesElemanli(n) + AltiElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at least 2 elements.
        /// </summary>
        public double EnAzİkiElemanli(int n)
        {
            if (n < 2) return -1;
            return AltKume(n) - 1 - n;
        }

        /// <summary>
        /// Calculates the number of subsets with at least 3 elements.
        /// </summary>
        public double EnAzUcElemanli(int n)
        {
            if (n < 3) return -1;
            return AltKume(n) - 1 - n - İkiElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at least 4 elements.
        /// </summary>
        public double EnAzDortElemanli(int n)
        {
            if (n < 4) return -1;
            return AltKume(n) - 1 - n - İkiElemanli(n) - UcElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at least 5 elements.
        /// </summary>
        public double EnAzBesElemanli(int n)
        {
            if (n < 5) return -1;
            return AltKume(n) - 1 - n - İkiElemanli(n) - UcElemanli(n) - DortElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at least 6 elements.
        /// </summary>
        public double EnAzAltiElemanli(int n)
        {
            if (n < 6) return -1;
            return AltKume(n) - 1 - n - İkiElemanli(n) - UcElemanli(n) - DortElemanli(n) - BesElemanli(n);
        }

        /// <summary>
        /// Finds the number of elements given the count of 2-element subsets.
        /// </summary>
        public double EnCokİkiElemanliAltKümeSayisiVerilen(bool isValid, int x)
        {
            if (!isValid) return 0;
            
            for (int n = 0; n < 10; n++)
            {
                if (İkiElemanli(n) == x - 1)
                {
                    return n;
                }
            }
            return -1;
        }

        /// <summary>
        /// Finds the number of elements given the count of 3-element subsets.
        /// </summary>
        public double EnCokUcElemanliAltKumeSayisiVerilirse(bool isValid, int x)
        {
            if (!isValid) return -1;
            
            for (int n = 0; n < 11; n++)
            {
                if (UcElemanli(n) == x - 1)
                {
                    return n;
                }
            }
            return -1;
        }
    }
}
