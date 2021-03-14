using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Util
{
    public class PrimeNumbers
    {
        public int GetPrimesCount(int start, int count)
        {
            return Enumerable.Range(start, count).Count(n =>
            Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0));
        }

        public Task<int> GetPrimesCountAsync(int start, int count)
        {
            return Task.Run(() =>
            ParallelEnumerable.Range(start, count).Count(n =>
            Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));
        }


    }
}
