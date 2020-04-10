using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace learnink
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string login, password;
            login = lTextBox.Text;
            password = PTextBox.Text;
            using (StreamReader rlogs = new StreamReader("data_base.txt"))
            {
                for (; !rlogs.EndOfStream;)
                {

                    if ((login == rlogs.ReadLine()) && (password == rlogs.ReadLine()))
                    {
                        MessageBox.Show("succes");
                    }
                    if (rlogs.EndOfStream)
                    {
                        MessageBox.Show("unsucces");
                    }

                }
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
        }
    }
}
