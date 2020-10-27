using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //声明一个double变量total来计算总计
        double total = 0.0d;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CashSuper csuper = CashFactory.createCashAccept(cbxType.SelectedItem.ToString());
            double totalPrices = 0d;
            totalPrices = csuper.acceptCash(Convert.ToDouble(txtPrice.Text)
                *Convert.ToDouble(txtNum.Text));
            total = total + totalPrices;
            lbxList.Items.Add("单价："+txtPrice.Text+"数量："+txtNum.Text+
                " "+cbxType.SelectedItem+" 合计："+totalPrices.ToString());
            lblResult.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在ComBox中加下拉选项
            cbxType.Items.AddRange(new object[] { "正常收费", "满300返100", "打8折" });
            cbxType.SelectedIndex = 0;
        }
    }
}
