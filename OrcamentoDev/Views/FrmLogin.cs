using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrcamentoDev.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Admin" && txtSenha.Text == "1234")
            {
                FrmMenu menu = new FrmMenu();
                menu.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario/Senha invalidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
