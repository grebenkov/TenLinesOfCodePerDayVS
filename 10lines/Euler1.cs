using System;

namespace TenLines
{
    class Euler1
    {
        public ulong SumMultiplesBrute(ulong factorFirst, ulong factorSecond, ulong limit)
        {
            ulong result = 0;
            for (ulong i = 0; i < limit; ++i)
            {
                if (i % factorFirst == 0 || i % factorSecond == 0)
                {
                    result += i;
                }
            }
            return result;
        }

        private ulong SumDivisebleBy(ulong factor, ulong limit)
        {
            return factor * (limit / factor) * (limit / factor + 1) / 2;
        }

        public ulong SumMultiplesSmart(ulong factorFirst, ulong factorSecond, ulong limit)
        {
            return SumDivisebleBy(factorFirst, limit) + SumDivisebleBy(factorSecond, limit) - 
                SumDivisebleBy(factorFirst * factorSecond, limit);
        }
    }
}
