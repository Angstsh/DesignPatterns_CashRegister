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
        CashSuper cs = null;

        //策略与简单工厂结合
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    CashNormal cs0 = new CashNormal();
                    cs = cs0;
                    break;
                case "满300返100":
                    CashReturn cr1 = new CashReturn("300","100");
                    cs = cr1;
                    break;
                case "打8折":
                    CashRebate cr2 = new CashRebate("0.8");
                    cs = cr2;
                    break;
            }
        }

        //根据收费策略的不同，获得计算结果
        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
