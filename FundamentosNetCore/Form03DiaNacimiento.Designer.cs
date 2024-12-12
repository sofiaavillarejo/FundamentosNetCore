namespace FundamentosNetCore
{
    partial class Form03DiaNacimiento
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
            label3 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnyo = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 41);
            label1.Name = "label1";
            label1.Size = new Size(61, 41);
            label1.TabIndex = 0;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 163);
            label2.Name = "label2";
            label2.Size = new Size(74, 41);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 284);
            label3.Name = "label3";
            label3.Size = new Size(72, 41);
            label3.TabIndex = 2;
            label3.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(65, 99);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(250, 47);
            txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(65, 207);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(250, 47);
            txtMes.TabIndex = 4;
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(65, 328);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(250, 47);
            txtAnyo.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(459, 132);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(205, 103);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular día";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 10F);
            lblResultado.Location = new Point(459, 308);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(183, 46);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado: ";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAnyo);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnyo;
        private Button btnCalcular;
        private Label lblResultado;
    }
}