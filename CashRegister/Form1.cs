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
            //计算每个商品合计
            double totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
            //将每个商品合计计入总计
            total = total + totalPrices;
            //在列表框中显示信息
            lbxList.Items.Add("单价："+txtPrice.Text+"数量："+txtNum.Text+"合计："+totalPrices.ToString());
            //在lblResult标签上显示总计数
            lblResult.Text = total.ToString();
        }
    }
}
