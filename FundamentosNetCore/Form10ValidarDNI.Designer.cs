namespace FundamentosNetCore
{
    partial class Form10ValidarDNI
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
            lblValidacion = new Label();
            btnValidar = new Button();
            txtDNI = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblValidacion
            // 
            lblValidacion.AutoSize = true;
            lblValidacion.Location = new Point(90, 333);
            lblValidacion.Name = "lblValidacion";
            lblValidacion.Size = new Size(0, 41);
            lblValidacion.TabIndex = 7;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(194, 188);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(392, 74);
            btnValidar.TabIndex = 6;
            btnValidar.Text = "Validar DNI";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(76, 101);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(417, 47);
            txtDNI.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 57);
            label1.Name = "label1";
            label1.Size = new Size(218, 41);
            label1.TabIndex = 4;
            label1.Text = "Introduzca DNI";
            // 
            // Form10ValidarDNI
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValidacion);
            Controls.Add(btnValidar);
            Controls.Add(txtDNI);
            Controls.Add(label1);
            Name = "Form10ValidarDNI";
            Text = "Form10ValidarDNI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValidacion;
        private Button btnValidar;
        private TextBox txtDNI;
        private Label label1;
    }
}