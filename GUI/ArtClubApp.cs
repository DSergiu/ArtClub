using Controlller.Classes;
using Controlller.Interfaces;
using Domain;
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
    public partial class ArtClubApp : Form
    {
        public ArtClubApp()
        {
            InitializeComponent();

        }

        static Member loginmember { get; set; }

        private void ArtClubApp_Load(object sender, EventArgs e)
        {
            login_panel.Visible = true;
            panel_main.Visible = false;

            login_email.Text = "danalachisergiu@gmail.dk";
        }


        private void login_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void DoLogin() 
        {
            SetError("");
            string email = login_email.Text;
            string password = login_pass.Text;

            try
            {
                loginmember = MemberCtrl.Login(email, password);
                Login();
            }
            catch (InvalidMemberException)
            {
                SetError("Member does not exist or is not part of the board.");
            }
            catch (InvalidCredentialsException)
            {
                SetError("Invalid credentials.");
            }
        }

        private void Login() 
        {
            SetError("");
            login_panel.Visible = false;
            panel_main.Visible = true;

            loggedin_lbl.Text = "Welcome " + login_email.Text;

            MemberLoad();
        }

        private void SetError(string error, bool iserr = true)
        {
            lbl_errors.Text = error;
            if (iserr)
                lbl_errors.ForeColor = Color.Red;
            else
                lbl_errors.ForeColor = Color.Green;
        }


        private void panel_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (panel_main.SelectedIndex)
            {
                case 0: MemberLoad(); break;
                case 1: ArtitemLoad(); break;
            }
        }

        
    }
}
