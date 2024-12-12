namespace FundamentosNetCore
{
    partial class Form07SumarNumeros
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
            txtNumeros = new TextBox();
            btnSumar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 58);
            label1.Name = "label1";
            label1.Size = new Size(283, 41);
            label1.TabIndex = 0;
            label1.Text = "introduzca numeros";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(94, 126);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(250, 47);
            txtNumeros.TabIndex = 1;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(460, 105);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(219, 68);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(356, 284);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 41);
            lblResultado.TabIndex = 3;
            // 
            // Form07SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnSumar);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form07SumarNumeros";
            Text = "Form07SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Button btnSumar;
        private Label lblResultado;
    }
}