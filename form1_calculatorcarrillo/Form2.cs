using System;
using System.Windows.Forms;

namespace form1_calculatorcarrillo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            if (usuario.Equals("freddy", StringComparison.OrdinalIgnoreCase) && contraseña == "1234")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
