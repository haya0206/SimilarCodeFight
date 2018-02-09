using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFight
{
    public partial class Form2 : Form
    {
        String userName;
        String enemyName;
        public Form2(String userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }
    }
}
