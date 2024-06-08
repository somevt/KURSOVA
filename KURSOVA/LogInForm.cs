using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSOVA
{
    public partial class LogInForm : Form
    {
        public List<User> list = new List<User>();
        public LogInForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            User u = new User("Nastya", "Samosvatova", "12345", "nastya@gmail.com", false);
            list.Add(u);
            u = new User("admin", "admin", "adminpassword", "admin@example.com", true);
            list.Add(u);
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Go();
        }
        private void LogInForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    MessageBox.Show("Help: Enter your login email and password. Press Enter to login.");
                    break;
                case Keys.Enter:
                    Go();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Tab:
                    if (e.Shift)
                    {
                       
                        this.SelectNextControl(this.ActiveControl, false, true, true, true);
                    }
                    else
                    {
                        
                        this.SelectNextControl(this.ActiveControl, true, true, true, true);
                    }
                    e.Handled = true; 
                    break;
            }
        }

        private void Go()
        {
            if (!string.IsNullOrEmpty(txtLogin.Text)&& !string.IsNullOrEmpty(txtPassword.Text))
            {
                bool isPas = false;
                foreach (User user in list)
                {
                    isPas = true;
                    if (user.Password==txtPassword.Text&&user.Email==txtLogin.Text)
                    {
                        if (user.IsAdmin)
                        {
                            Main_Menu admin = new Main_Menu(user);
                            this.Hide();
                            admin.ShowDialog();
                        }
                        else
                        {
                           
                            User_Menu user_M = new User_Menu(user);
                            this.Hide();
                            user_M.ShowDialog();
                            user_M.booking.SaveTicketsToFile("Tickets.txt");
                            user_M.schedule.SaveToFile("Schedule.txt");
                            this.Close();
                        }
                    }
                    
                }
                if (isPas==false)
                {
                    MessageBox.Show("Incorrect login or password");
                }
               
            }
        }
    }
}
