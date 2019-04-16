using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class Login : Form
    {
        bool isMouseDown=false;
        Point startLocation = new Point();

        //=====================================================
        public Login()
        {
            InitializeComponent();
            this.lbResult.Text = "";
            this.tbPassWord.isPassword = true;
        }

        //=====================================================
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            this.isMouseDown = true;
            startLocation.X = e.X;
            startLocation.Y = e.Y;
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            this.isMouseDown = false;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.isMouseDown)
            {
                this.Location = new Point(this.Location.X+e.X-startLocation.X, this.Location.Y+e.Y-startLocation.Y);
            }
        }


        //======================================================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbuserName.Text))
            {
                lbResult.Text = "User name is can't empty";
                return;
            }

            if (string.IsNullOrEmpty(tbPassWord.Text))
            {
                lbResult.Text = "Password is can't empty";
                return;
            }


            DbBLL database = new DbBLL();
            database.ConnectToDatabase();
            UserBLL userBLL = new UserBLL();
            UserDTO user = userBLL.GetUser(tbuserName.Text);
            if (user == null)
            {
                lbResult.Text = "The user not found, try another acount";
                return;
            }

            if (user.Password != tbPassWord.Text)
            {
                lbResult.Text = "The password is not correct, try again";
            }

            WorkSpace wp = new WorkSpace(user);
            Global.user = user;
            this.Hide();
            wp.Show();
            ////this.Show();
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
    }
}
