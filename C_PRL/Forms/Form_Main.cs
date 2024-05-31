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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent(); // Phuong thức khỏi tạo giao diện
        }


        private void btn_Home_MouseHover(object sender, EventArgs e)
        {
            btn_Home.BackColor = Color.White;
        }

        private void btn_Home_MouseLeave(object sender, EventArgs e)
        {
            btn_Home.BackColor = Color.Orange;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear(); // Xóa hết các thành phần đã có trên panel
            pn_Show.BackgroundImage = Image.FromFile(@"C:\Users\Acer\Desktop\Hello.png");
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear(); // Xóa hết các thành phần đã có trên panel
            // Thêm Form_CRUD vào Panel_Show trên form Main
            // Về mặt Level của các control thì Form luôn là lớn nhất => TopLevel
            // Để có thêm thêm được form vào panel => Set Toplevel = false
            Form_CRUD crud = new Form_CRUD();
            crud.TopLevel = false;
            // Thêm form vào trong panel
            pn_Show.Controls.Add(crud);
            // Cấu hình khung viên
            crud.FormBorderStyle = FormBorderStyle.None;
            // Hiển thị form
            crud.Show(); // Show khác ShowDialog
        }

        private void btn_Rules_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear(); // Xóa hết các thành phần đã có trên panel
            // Thêm Form_CRUD vào Panel_Show trên form Main
            // Về mặt Level của các control thì Form luôn là lớn nhất => TopLevel
            // Để có thêm thêm được form vào panel => Set Toplevel = false
            Form_Rules rules = new Form_Rules();
            rules.TopLevel = false;
            // Thêm form vào trong panel
            pn_Show.Controls.Add(rules);
            // Cấu hình khung viên
            rules.FormBorderStyle = FormBorderStyle.None;
            // Hiển thị form
            rules.Show(); // Show khác ShowDialog
        }
    }
}
// Đợi các bạn vào đông thêm tí chúng ta start nhé
