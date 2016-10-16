using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waluta
{
    public class Currency
    {
        protected int amount;
        public Currency(int _amount)
        {
            amount = _amount;
        }
        public float Multiplition(int a)
        {
            return a * amount;
        }
        public bool equals(object obj)
        {
            Currency wal = (Currency)obj;
            return amount == wal.amount && GetType().Equals(wal.GetType());
        }
    }
}
