using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsConnectSqlserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string passWord = textBox2.Text;

            if(string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("请输入你的用户名");
                return;
            }
            if(string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("请输入你的密码");
                return;
            }

            UserTModel model = null;
            //建立EF查询
            using (MyDBContext myDB = new MyDBContext())
            {
                model=myDB.UserTForWinform.FirstOrDefault(x => x.UserName == userName && x.Password == passWord);
                //查账号密码对应的条
                //去表里查有没有对应的账号密码
            }

            if (model == null)//未查到对应的账号密码
            {
                MessageBox.Show($"用户名：{userName}  密码：{passWord}  不好意思，你来错地方了，我们这里没有你的信息");
                return;
            }

            MessageBox.Show("登陆成功");

            Index index = new Index(model);
            index.Show(); // 打开首页

            this.Hide();//隐藏登录主页
        }

        private void label3_Click(object sender, EventArgs e) //注册
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();//showDialog,创建一个窗口，且不能操作其他窗口
        }
    }
}
