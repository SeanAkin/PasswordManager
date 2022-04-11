using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;


namespace PasswordManager
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(this.usernameInput.Text);
            Debug.WriteLine(this.passwordInput.Text);
            string passwordHash = BC.HashPassword(passwordInput.Text);
            Debug.WriteLine(passwordHash);
        }
    }
}
