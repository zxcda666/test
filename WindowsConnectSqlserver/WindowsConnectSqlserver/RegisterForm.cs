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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取用户名
            string userNmae = textUserName.Text;
            //获取密码 确认密码
            string password = textPassword.Text;
            string confimPassword = textBox3.Text;
            
            if(password==null||confimPassword==null)
            {
                MessageBox.Show("密码不能为空");
            }
            
            if (password != confimPassword)
            {
                MessageBox.Show("两次密码输入不一致");
                return;
            }
            //获取昵称
            string nickName = textBox4.Text;

            //获取性别
            string gender = null;
            if (radioButton1.Checked)
            {
                gender = "1";
            }
            else
            {
                gender = "2";
            }

            UserTModel model = new UserTModel();
            model.UserName = userNmae;
            model.NickName = nickName;
            model.Gender = gender;
            model.Password = password;
            int i = 0;//受影响行数
            using (MyDBContext myDB=new MyDBContext())
            {
                int count = myDB.UserTForWinform.Count(m => m.UserName == userNmae);//查找用户名有没有重复的
                if ((count>0))
                {
                    MessageBox.Show("不好意思，已存在当前用户名");
                    return;
                }
                //将当前注册信息加到表里！！！
                myDB.UserTForWinform.Attach(model);
                myDB.Entry(model).State = System.Data.Entity.EntityState.Added;//添加一行数据
                
                i = myDB.SaveChanges();//提交至数据库,返回受影响的行数
            }
            if(i<=0)
            {
                MessageBox.Show("注册失败");
            }
            else
            {
                MessageBox.Show("注册成功");
                this.Close();
            }
        }
    }
}
