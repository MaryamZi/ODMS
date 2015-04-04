using ODMS.Main;
using ODMS.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginValidate newvalidation = new LoginValidate(txtUsername.Text,txtPassword.Text);
            if (newvalidation.validateLogin())
            {
                Mainfrm mainWin = new Mainfrm();
                mainWin.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Check login and retry");
            }
        }

        
    }
}
