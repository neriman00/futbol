using FootBall.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBall
{
    public partial class Form1 : Form
    {
        FootBallEntities db = new FootBallEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtemail.Text;
            string Password=txtpassword.Text;
            if(Email!=string.Empty && Password != string.Empty)
            {
                admin adm = db.admins.FirstOrDefault(a => a.email == Email);
                if (adm.email==Email)
                {
                    if (adm.password == Password)
                    {
                        stadion st = new stadion();
                        st.ShowDialog();
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "Zehmet olmasa duzgun password daxil edin";
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Zehmet olmasa duzgun email daxil edin";
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Zehmet olmasa email ve password daxil edin";
            }
        }
    }
}
