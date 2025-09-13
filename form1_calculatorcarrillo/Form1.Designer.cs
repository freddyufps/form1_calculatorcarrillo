namespace form1_calculatorcarrillo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtProcedimiento;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnLimpiar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtProcedimiento = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.Location = new System.Drawing.Point(12, 12);
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.Size = new System.Drawing.Size(276, 30);
            this.txtProcedimiento.TabIndex = 0;
            this.txtProcedimiento.ReadOnly = true;
            this.txtProcedimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProcedimiento.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProcedimiento.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // Botones de números y operaciones organizados
            // 
            int btnWidth = 60, btnHeight = 45, margin = 8;
            // Fila 1: 7 8 9 /
            this.btn7.Location = new System.Drawing.Point(12, 60);
            this.btn7.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn7.Text = "7";
            this.btn7.BackColor = System.Drawing.Color.LightGray;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Click += btn_Click;

            this.btn8.Location = new System.Drawing.Point(12 + (btnWidth + margin), 60);
            this.btn8.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn8.Text = "8";
            this.btn8.BackColor = System.Drawing.Color.LightGray;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Click += btn_Click;

            this.btn9.Location = new System.Drawing.Point(12 + 2 * (btnWidth + margin), 60);
            this.btn9.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn9.Text = "9";
            this.btn9.BackColor = System.Drawing.Color.LightGray;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Click += btn_Click;

            this.btnDivide.Location = new System.Drawing.Point(12 + 3 * (btnWidth + margin), 60);
            this.btnDivide.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnDivide.Text = "/";
            this.btnDivide.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Click += btn_Click;

            // Fila 2: 4 5 6 *
            this.btn4.Location = new System.Drawing.Point(12, 60 + (btnHeight + margin));
            this.btn4.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn4.Text = "4";
            this.btn4.BackColor = System.Drawing.Color.LightGray;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Click += btn_Click;

            this.btn5.Location = new System.Drawing.Point(12 + (btnWidth + margin), 60 + (btnHeight + margin));
            this.btn5.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn5.Text = "5";
            this.btn5.BackColor = System.Drawing.Color.LightGray;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Click += btn_Click;

            this.btn6.Location = new System.Drawing.Point(12 + 2 * (btnWidth + margin), 60 + (btnHeight + margin));
            this.btn6.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn6.Text = "6";
            this.btn6.BackColor = System.Drawing.Color.LightGray;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Click += btn_Click;

            this.btnMultiplica.Location = new System.Drawing.Point(12 + 3 * (btnWidth + margin), 60 + (btnHeight + margin));
            this.btnMultiplica.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnMultiplica.Text = "*";
            this.btnMultiplica.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMultiplica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplica.Click += btn_Click;

            // Fila 3: 1 2 3 -
            this.btn1.Location = new System.Drawing.Point(12, 60 + 2 * (btnHeight + margin));
            this.btn1.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn1.Text = "1";
            this.btn1.BackColor = System.Drawing.Color.LightGray;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Click += btn_Click;

            this.btn2.Location = new System.Drawing.Point(12 + (btnWidth + margin), 60 + 2 * (btnHeight + margin));
            this.btn2.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn2.Text = "2";
            this.btn2.BackColor = System.Drawing.Color.LightGray;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Click += btn_Click;

            this.btn3.Location = new System.Drawing.Point(12 + 2 * (btnWidth + margin), 60 + 2 * (btnHeight + margin));
            this.btn3.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn3.Text = "3";
            this.btn3.BackColor = System.Drawing.Color.LightGray;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Click += btn_Click;

            this.btnResta.Location = new System.Drawing.Point(12 + 3 * (btnWidth + margin), 60 + 2 * (btnHeight + margin));
            this.btnResta.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnResta.Text = "-";
            this.btnResta.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnResta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResta.Click += btn_Click;

            // Fila 4: 0 C + =
            this.btn0.Location = new System.Drawing.Point(12, 60 + 3 * (btnHeight + margin));
            this.btn0.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn0.Text = "0";
            this.btn0.BackColor = System.Drawing.Color.LightGray;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Click += btn_Click;

            this.btnLimpiar.Location = new System.Drawing.Point(12 + (btnWidth + margin), 60 + 3 * (btnHeight + margin));
            this.btnLimpiar.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnLimpiar.Text = "C";
            this.btnLimpiar.BackColor = System.Drawing.Color.LightCoral;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Click += btnLimpiar_Click;

            this.btnSuma.Location = new System.Drawing.Point(12 + 2 * (btnWidth + margin), 60 + 3 * (btnHeight + margin));
            this.btnSuma.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnSuma.Text = "+";
            this.btnSuma.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSuma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuma.Click += btn_Click;

            this.btnIgual.Location = new System.Drawing.Point(12 + 3 * (btnWidth + margin), 60 + 3 * (btnHeight + margin));
            this.btnIgual.Size = new System.Drawing.Size(btnWidth, btnHeight * 2 + margin);
            this.btnIgual.Text = "=";
            this.btnIgual.BackColor = System.Drawing.Color.LightGreen;
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.Click += btnIgual_Click;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 320);
            this.Name = "Form1";
            this.Text = "Calculadora Básica";
            this.Load += Form1_Load;
            this.Controls.Add(this.txtProcedimiento);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnLimpiar);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
