using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //add("TXX", "123456");
            //MessageBox.Show(FindById("send a card"));
            /*string res = SellFloor(120, 5000, out string wantprice);
            MessageBox.Show(res);
            MessageBox.Show(wantprice);*/

            //调用带有ref类型参数时，必须对传参进行赋值
            /*string message = "100011fsw";
            string res1 = SendMessage(ref message);*/

            MessageBox.Show(BuyWatermelon(1.9m, 23m, 0.75m).ToString());

        }

        public void add(string account,string pwd) {
            MessageBox.Show("尊敬的" + account + ",您的账户注册成功，密码是" + pwd);
        }
        /// <summary>
        /// 查找随机数
        /// </summary>
        /// <param name="id">任意字符串内容</param>
        /// <returns></returns>
        public string FindById(string id) {
            Random r = new Random();
            int num = r.Next(1, 100);
            return id + num;
        }

        public string SendMessage(ref string want) {

            return want+"邮件已送达，请自行取件";

        }
        public string SellFloor(int area, int price, out string wantprice)
        {

            //out类型参数，必须在方法内先对out的参数赋值，即使wantprice作为全局变量都赋值，在这里还是要重新赋值，不然return无法确定返回值
            wantprice = "愿意出价" + area * price * 0.8;

            return "李四想买这套房";

        }

        public decimal BuyWatermelon(decimal price, decimal weight,decimal discount) {
            decimal total = price * weight; ;
            decimal totalres = 0;
            int x = (int)(total / 10);//可以打折扣的次数
            decimal totalprice;
            for (int i = 0; i < x; i++)
            {
                totalres = totalres + Decimal.Parse((10 * 0.75).ToString());
            }
            decimal totalless = total % 10;
            totalprice = totalless + totalres;
            return totalprice;
        }

    }
}
