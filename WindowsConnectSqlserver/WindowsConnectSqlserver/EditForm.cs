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
    
    public partial class EditForm : Form
    {
        public string currentUserName = null;

        Index currentIndexForm = null;
        public EditForm(string userName,Index indexForm)
        {
            InitializeComponent();
            label1.Text = $"编辑对象：{userName}";

            currentUserName = userName;
            currentIndexForm = indexForm;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            UserTModel model = null;
            using (MyDBContext myDB = new MyDBContext())
            {
                model = myDB.UserTForWinform.FirstOrDefault(x => x.UserName == currentUserName);
            }
            if (model == null)
            {
                MessageBox.Show("未查出数据!");
                return;
            }

            textBox1.Text = model.NickName;
            textBox2.Text = model.Gender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MyDBContext myDB = new MyDBContext())
            {
                UserTModel  model =  myDB.UserTForWinform.Find(currentUserName);

                if (model == null)
                {
                    MessageBox.Show("未查出相关数据");
                }

                model.NickName = textBox1.Text;
                model.Gender = textBox2.Text;

                myDB.SaveChanges();
                MessageBox.Show("修改成功");
            }

            this.Close();
            currentIndexForm.InitUsers();

            //要刷新index界面
        }
    }
}
