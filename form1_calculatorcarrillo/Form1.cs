using System.Data;

namespace form1_calculatorcarrillo
{
    public partial class Form1 : Form
    {
        private string procedimiento = "";
        private bool ultimoFueOperador = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Puedes dejarlo vac�o o agregar inicializaci�n si lo necesitas
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string valor = btn.Text;

            // Solo permite n�meros y operadores v�lidos
            if ("0123456789".Contains(valor))
            {
                procedimiento += valor;
                ultimoFueOperador = false;
            }
            else if ("+-*/".Contains(valor))
            {
                // No permite dos operadores seguidos ni empezar con operador (excepto '-')
                if (procedimiento.Length == 0 && valor != "-") return;
                if (ultimoFueOperador) return;
                procedimiento += valor;
                ultimoFueOperador = true;
            }
            txtProcedimiento.Text = procedimiento;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                // No eval�a si termina en operador
                if (procedimiento.Length == 0 || "+-*/".Contains(procedimiento[^1].ToString()))
                {
                    txtProcedimiento.Text = "Expresi�n inv�lida";
                    procedimiento = "";
                    ultimoFueOperador = false;
                    return;
                }
                var resultado = new DataTable().Compute(procedimiento, null);
                txtProcedimiento.Text = procedimiento + " = " + resultado.ToString();
                procedimiento = "";
                ultimoFueOperador = false;
            }
            catch
            {
                txtProcedimiento.Text = "Error en la operaci�n";
                procedimiento = "";
                ultimoFueOperador = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            procedimiento = "";
            ultimoFueOperador = false;
            txtProcedimiento.Text = "";
        }
    }
}
