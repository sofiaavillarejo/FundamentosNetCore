namespace FundamentosNetCore
{
    partial class Form13ColeccionNumeros
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
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnMostrar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            txtImpares = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 32);
            label1.Name = "label1";
            label1.Size = new Size(140, 41);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(63, 103);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(300, 209);
            lstNumeros.TabIndex = 1;
            lstNumeros.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(457, 32);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(188, 58);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(457, 129);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(244, 75);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 373);
            label2.Name = "label2";
            label2.Size = new Size(124, 41);
            label2.TabIndex = 4;
            label2.Text = "Impares";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 308);
            label3.Name = "label3";
            label3.Size = new Size(88, 41);
            label3.TabIndex = 5;
            label3.Text = "Pares";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 231);
            label4.Name = "label4";
            label4.Size = new Size(92, 41);
            label4.TabIndex = 6;
            label4.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(561, 228);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(187, 47);
            txtSuma.TabIndex = 7;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(561, 305);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(187, 47);
            txtPares.TabIndex = 8;
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(561, 373);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(187, 47);
            txtImpares.TabIndex = 9;
            // 
            // Form13ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtImpares);
            Controls.Add(txtPares);
            Controls.Add(txtSuma);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Name = "Form13ColeccionNumeros";
            Text = "Form13ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button btnMostrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSuma;
        private TextBox txtPares;
        private TextBox txtImpares;
    }
}