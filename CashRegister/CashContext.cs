using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    class CashContext
    {
        //声明一个CashSuper对象
        private CashSuper cs;

        //通过构造方法，传入具体的收费策略
        public CashContext(CashSuper csuper)
        {
            this.cs = csuper;
        }

        //根据收费策略的不同，获得计算结果
        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
