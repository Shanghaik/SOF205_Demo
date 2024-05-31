using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.Forms
{
    public partial class Form_Login : Form
    {
        AccountServices _services = new AccountServices();
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tbt_Username.Text;
            string password = tbt_Password.Text;    
            if(_services.Login(username, password)) // đăng nhập thành công
            {
                MessageBox.Show("Đăng nhập thành công");
                Form_Main main = new Form_Main();
                main.Show();
            }else MessageBox.Show("Đăng nhập thất bại, mời kiểm tra lại thông tin");
        }

        private void btn_Forget_Click(object sender, EventArgs e)
        {
            string username = tbt_Username.Text;
            string forget = _services.ForgetPassword(username);
            MessageBox.Show(forget);
        }
    }
}
