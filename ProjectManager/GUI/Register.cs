using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            tbPass1.isPassword = true;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(tbUserName.Text))
            {
                lbNotify.Text = "Ten dang nhap khong duoc de trong";
                return;
            }

            if (String.IsNullOrEmpty(tbName.Text))
            {
                lbNotify.Text = "Ten nguoi dung khong duoc de trong";
                return;
            }

            if (String.IsNullOrEmpty(tbPass1.Text))
            {
                lbNotify.Text = "Mat khau khong duoc de trong";
                return;
            }

            if (tbPass1.Text!=tbPass2.Text)
            {
                lbNotify.Text = "Mat khau khong trung khop";
                return;
            }

            UserBLL userBLL = new UserBLL();
            UserDTO user = userBLL.GetUser(tbUserName.Text);
            if(user!=null)
            {
                lbNotify.Text = "Ten dang nhap da ton tai";
                return;
            }

            user = new UserDTO(tbUserName.Text, tbPass1.Text, tbName.Text);
            try
            {
                userBLL.InsertUser(user);
                this.Close();
                return;
            }
            catch
            {
                lbNotify.Text = "Dang ky that bai!!!";
            }
        }
    }
}
