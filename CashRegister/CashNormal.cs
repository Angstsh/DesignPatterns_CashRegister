using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    //正常收费子类
    class CashNormal:CashSuper
    {
        public override double acceptCash(double money)
        {
            //正常收费，原价返回
            return money;
        }
    }
}
