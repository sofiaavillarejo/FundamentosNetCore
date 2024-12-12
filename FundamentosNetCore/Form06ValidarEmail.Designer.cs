namespace FundamentosNetCore
{
    partial class Form06ValidarEmail
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
            txtEmail = new TextBox();
            btnValidarMail = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 55);
            label1.Name = "label1";
            label1.Size = new Size(280, 41);
            label1.TabIndex = 0;
            label1.Text = "Introduzca un email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(416, 47);
            txtEmail.TabIndex = 1;
            // 
            // btnValidarMail
            // 
            btnValidarMail.Location = new Point(94, 176);
            btnValidarMail.Name = "btnValidarMail";
            btnValidarMail.Size = new Size(416, 56);
            btnValidarMail.TabIndex = 2;
            btnValidarMail.Text = "Validar Mail";
            btnValidarMail.UseVisualStyleBackColor = true;
            btnValidarMail.Click += btnValidarMail_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(94, 280);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(156, 41);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // Form06ValidarEmail
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnValidarMail);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "Form06ValidarEmail";
            Text = "Form06ValidarEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnValidarMail;
        private Label lblResultado;
    }
}