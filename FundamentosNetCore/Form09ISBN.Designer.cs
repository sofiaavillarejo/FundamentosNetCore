namespace FundamentosNetCore
{
    partial class Form09ISBN
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
            txtISBN = new TextBox();
            btnValidar = new Button();
            lblValidacion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 49);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 0;
            label1.Text = "Introduzca ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(80, 93);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(417, 47);
            txtISBN.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(217, 203);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(392, 74);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar ISBN";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblValidacion
            // 
            lblValidacion.AutoSize = true;
            lblValidacion.Location = new Point(94, 325);
            lblValidacion.Name = "lblValidacion";
            lblValidacion.Size = new Size(0, 41);
            lblValidacion.TabIndex = 3;
            // 
            // Form09ISBN
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValidacion);
            Controls.Add(btnValidar);
            Controls.Add(txtISBN);
            Controls.Add(label1);
            Name = "Form09ISBN";
            Text = "Form09ISBN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtISBN;
        private Button btnValidar;
        private Label lblValidacion;
    }
}