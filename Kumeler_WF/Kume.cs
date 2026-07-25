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
        public List<string> KumeElemanlari { get; set; }

        /// <summary>
        /// Calculates the number of subsets of a set with n elements (2^n).
        /// </summary>
        public long AltKume(int n)
        {
            if (n < 0) throw new ArgumentException("Element count cannot be negative", nameof(n));
            if (n > 62) throw new OverflowException("Element count too large - would overflow long type");
            return 1L << n;
        }

        /// <summary>
        /// Calculates the number of proper subsets (2^n - 1).
        /// </summary>
        public long OzAltKume(int n)
        {
            if (n < 0) throw new ArgumentException("Element count cannot be negative", nameof(n));
            if (n > 62) throw new OverflowException("Element count too large - would overflow long type");
            return (1L << n) - 1;
        }

        /// <summary>
        /// Alias for AltKume - calculates 2^n.
        /// </summary>
        public long Gicik(int n)
        {
            return AltKume(n);
        }

        /// <summary>
        /// Calculates the binomial coefficient C(n, k) - number of k-element subsets from n elements.
        /// </summary>
        private long Kombinasyon(int n, int k)
        {
            if (k < 0 || k > n) return 0;
            if (k == 0 || k == n) return 1;
            
            // Optimize by using smaller k value
            k = Math.Min(k, n - k);
            
            long result = 1;
            for (int i = 1; i <= k; i++)
            {
                checked
                {
                    result = result * (n - i + 1) / i;
                }
            }
            return result;
        }

        public long İkiElemanli(int n) => Kombinasyon(n, 2);
        public long UcElemanli(int n) => Kombinasyon(n, 3);
        public long DortElemanli(int n) => Kombinasyon(n, 4);
        public long BesElemanli(int n) => Kombinasyon(n, 5);
        public long AltiElemanli(int n) => Kombinasyon(n, 6);
        public long YediElemanli(int n) => Kombinasyon(n, 7);

        /// <summary>
        /// Calculates the number of subsets with at most 2 elements.
        /// </summary>
        public long EnFazlaIkiElemanli(int n)
        {
            return 1 + n + İkiElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at most 3 elements.
        /// </summary>
        public long EnFazlaUcElemanli(int n)
        {
            return 1 + n + İkiElemanli(n) + UcElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at most 4 elements.
        /// </summary>
        public long EnFazlaDortElemanli(int n)
        {
            return 1 + n + İkiElemanli(n) + UcElemanli(n) + DortElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at most 5 elements.
        /// </summary>
        public long EnFazlaBesElemanli(int n)
        {
            return 1 + n + İkiElemanli(n) + UcElemanli(n) + DortElemanli(n) + BesElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at most 6 elements.
        /// </summary>
        public long EnFazlaAltiElemanli(int n)
        {
            return 1 + n + İkiElemanli(n) + UcElemanli(n) + DortElemanli(n) + BesElemanli(n) + AltiElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at least 2 elements.
        /// Returns null if n < 2 (no valid result possible).
        /// </summary>
        public long? EnAzİkiElemanli(int n)
        {
            if (n < 0) throw new ArgumentException("Element count cannot be negative", nameof(n));
            if (n < 2) return null;
            return AltKume(n) - 1 - n;
        }

        /// <summary>
        /// Calculates the number of subsets with at least 3 elements.
        /// Returns null if n < 3 (no valid result possible).
        /// </summary>
        public long? EnAzUcElemanli(int n)
        {
            if (n < 0) throw new ArgumentException("Element count cannot be negative", nameof(n));
            if (n < 3) return null;
            return AltKume(n) - 1 - n - İkiElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at least 4 elements.
        /// Returns null if n < 4 (no valid result possible).
        /// </summary>
        public long? EnAzDortElemanli(int n)
        {
            if (n < 0) throw new ArgumentException("Element count cannot be negative", nameof(n));
            if (n < 4) return null;
            return AltKume(n) - 1 - n - İkiElemanli(n) - UcElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at least 5 elements.
        /// Returns null if n < 5 (no valid result possible).
        /// </summary>
        public long? EnAzBesElemanli(int n)
        {
            if (n < 0) throw new ArgumentException("Element count cannot be negative", nameof(n));
            if (n < 5) return null;
            return AltKume(n) - 1 - n - İkiElemanli(n) - UcElemanli(n) - DortElemanli(n);
        }

        /// <summary>
        /// Calculates the number of subsets with at least 6 elements.
        /// Returns null if n < 6 (no valid result possible).
        /// </summary>
        public long? EnAzAltiElemanli(int n)
        {
            if (n < 0) throw new ArgumentException("Element count cannot be negative", nameof(n));
            if (n < 6) return null;
            return AltKume(n) - 1 - n - İkiElemanli(n) - UcElemanli(n) - DortElemanli(n) - BesElemanli(n);
        }

        /// <summary>
        /// Finds the number of elements given the count of 2-element subsets.
        /// </summary>
        /// <param name="isValid">Whether the input is valid</param>
        /// <param name="subsetCount">The number of 2-element subsets</param>
        /// <returns>The number of elements, or null if not found</returns>
        public int? EnCokİkiElemanliAltKümeSayisiVerilen(bool isValid, int subsetCount)
        {
            if (!isValid || subsetCount < 0) return null;
            
            // Search range expanded to handle larger values
            for (int n = 0; n <= 1000; n++)
            {
                if (İkiElemanli(n) == subsetCount)
                {
                    return n;
                }
                if (İkiElemanli(n) > subsetCount)
                {
                    break; // No need to continue searching
                }
            }
            return null;
        }

        /// <summary>
        /// Finds the number of elements given the count of 3-element subsets.
        /// </summary>
        /// <param name="isValid">Whether the input is valid</param>
        /// <param name="subsetCount">The number of 3-element subsets</param>
        /// <returns>The number of elements, or null if not found</returns>
        public int? EnCokUcElemanliAltKumeSayisiVerilirse(bool isValid, int subsetCount)
        {
            if (!isValid || subsetCount < 0) return null;
            
            // Search range expanded to handle larger values
            for (int n = 0; n <= 1000; n++)
            {
                if (UcElemanli(n) == subsetCount)
                {
                    return n;
                }
                if (UcElemanli(n) > subsetCount)
                {
                    break; // No need to continue searching
                }
            }
            return null;
        }
    }
}
