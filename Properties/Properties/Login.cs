using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using System.Text.RegularExpressions;
using Properties;

namespace _3_TIER_PRAC_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DataAccessLayer dal = new DataAccessLayer();
        BusinessLogicLayer bll = new BusinessLogicLayer();

        Information info;
        int count = 3, Timer = 0;

        private async void Login_Load(object sender, EventArgs e)
        {
            lblUserName.Visible = false;
            lblPassword.Visible = false;
            lblError.Visible = false;

            txtUserName.Visible = false;
            txtPassWord.Visible = false;

            lblUserName.Visible = true;
            txtUserName.Visible = true;

            await Task.Delay(900);

            lblPassword.Visible = true;
            txtPassWord.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            bool validated = true;
            //info = new Information(txtPassWord.Text, txtUserName.Text);

            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassWord.Text))
            {
                errorProvider1.SetError(txtUserName, "THE USERNAME CANNOT BE EMPTY");
                txtUserName.BackColor = Color.DarkRed;

                txtPassWord.BackColor = Color.DarkRed;
                errorProvider1.SetError(txtPassWord, "THE PASSWORD CANNOT BE EMPTY");

                validated = false;
            }
           
            if (validated == true)
            {
                //DataTable x = bll.LOGINUSER(info);

                //if (x.Rows.Count > 0)
                //{
                //    MessageBox.Show("WELCOME: " + x.Rows[0]["USERNAME"].ToString());
                //    btnLogin.ForeColor = Color.Green;
                   
                //}
                //else
                //{
                //    MessageBox.Show("USER ACCOUNT DOES NOT EXIST");
                //    Console.Beep();
                //}
            }
            else
            {
                MessageBox.Show("PLEASE TRY AGAIN");
                txtUserName.BackColor= Color.White;
                btnLogin.ForeColor = Color.White;

                txtPassWord.BackColor= Color.White;
                Console.Beep();
            }

            count--;

            if(count == 1)
            {
                Timer = 10;
                lblError.Visible = true;

                lblError.Text = "YOU HAVE REACHED THE DAILY LIMIT";

                await Task.Delay(2000);
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private async void timer1_Tick_1(object sender, EventArgs e)
        {
            lblError.Text = "SHUTTING DOWN IN " + Timer--.ToString();
            Console.Beep();

            if (Timer == 0)
            {
                await Task.Delay(500);
                this.Close();
                timer1.Stop();
            }
            
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            bool validated = true;
            //info = new Information(txtPassWord.Text, txtUserName.Text);

            if (!Regex.IsMatch(txtPassWord.Text, "@^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$"))
            {
                errorProvider1.SetError(txtPassWord, "PASSWORD DOES NOT MEET THE REQUIRED LENGTH");
                errorProvider2.SetError(txtPassWord, "Minimum eight characters, at least one upper case English letter, one lower case English letter, one number and one special character");
            }
            
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassWord.Text))
            {
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    errorProvider1.SetError(txtUserName, "THE USERNAME CANNOT BE EMPTY");
                }

               if(string.IsNullOrEmpty(txtPassWord.Text))
                {
                    errorProvider1.SetError(txtPassWord, "THE PASSWORD CANNOT BE EMPTY");
                }
                validated = false;
            }

            if (txtPassWord.TextLength >= 8)
            {
                validated = true;
            }
            else
            {
                validated = false;
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }

            if (validated == true)
            {
                //int x = bll.INSERTUSER(info);

                //if (x > 0)
                //{
                //    MessageBox.Show("ACCOUNT CREATED");
                //}
                //else
                //{
                //    Console.Beep();
                //}
            }
            else
            {
                MessageBox.Show("PLEASE TRY AGAIN");
                txtUserName.BackColor = Color.White;
                txtPassWord.BackColor = Color.White;
                Console.Beep();
            }


           
        }
    }
}
