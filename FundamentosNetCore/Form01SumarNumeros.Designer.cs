namespace FundamentosNetCore
{
    partial class Form01SumarNumeros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnSumar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 55);
            label1.Name = "label1";
            label1.Size = new Size(99, 41);
            label1.TabIndex = 0;
            label1.Text = "Num1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 219);
            label2.Name = "label2";
            label2.Size = new Size(99, 41);
            label2.TabIndex = 1;
            label2.Text = "Num2";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(84, 99);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(250, 47);
            txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(84, 263);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(250, 47);
            txtNumero2.TabIndex = 3;
            txtNumero2.TextChanged += txtNumero2_TextChanged;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(484, 159);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(240, 90);
            btnSumar.TabIndex = 4;
            btnSumar.Text = "Calcular";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = SystemColors.GradientInactiveCaption;
            lblResultado.ForeColor = SystemColors.ControlText;
            lblResultado.Location = new Point(555, 321);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 41);
            lblResultado.TabIndex = 5;
            lblResultado.Click += label3_Click;
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnSumar);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            Load += Form01SumarNumeros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnSumar;
        private Label lblResultado;
    }
}