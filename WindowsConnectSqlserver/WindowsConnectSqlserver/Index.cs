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
    public partial class Index : Form
    {
        public Index(UserTModel model)
        {
            InitializeComponent();
            label1.Text = $"欢迎您,登录本系统：{model.NickName}";
        }

        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//关闭掉隐藏的主窗口
        }

        private void Index_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoGenerateColumns = false;
            InitUsers();
        }

        public void InitUsers() //初始化绑定dataGridView
        {
            List<UserTModel> lstUsers = new List<UserTModel>();


            using (MyDBContext myDB = new MyDBContext())
            {
                lstUsers = myDB.UserTForWinform.ToList();//查出完整表
            }

            dataGridView1.DataSource = lstUsers;//绑定表
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.ColumnIndex == 3)//设置点击指定位置，打开编辑窗口
            {
                //获取当前的用户名
               string userName =  dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();

               //Rows[e.RowIndex]`：获取** 当前点击的那一行**，Cells["UserName"],UserName的值


                //弹出编辑窗口                  //把此行用户名和当前界面传过去，可以调用Index里的InitUsers,刷新绑定表
                EditForm editForm = new EditForm(userName,this);

                editForm.ShowDialog();
            }
        }
    }
}
