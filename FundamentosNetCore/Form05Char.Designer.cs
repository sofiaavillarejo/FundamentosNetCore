namespace FundamentosNetCore
{
    partial class Form05Char
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
            txtLetras = new TextBox();
            label2 = new Label();
            txtSimbolos = new TextBox();
            label3 = new Label();
            txtPuntuacion = new TextBox();
            Puntuación = new Label();
            btnRecorrer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 24);
            label1.Name = "label1";
            label1.Size = new Size(140, 41);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(113, 83);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(370, 161);
            txtNumeros.TabIndex = 1;
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(752, 83);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(370, 161);
            txtLetras.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(752, 24);
            label2.Name = "label2";
            label2.Size = new Size(96, 41);
            label2.TabIndex = 2;
            label2.Text = "Letras";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(113, 352);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(370, 161);
            txtSimbolos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 293);
            label3.Name = "label3";
            label3.Size = new Size(141, 41);
            label3.TabIndex = 4;
            label3.Text = "Símbolos";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(752, 352);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(370, 161);
            txtPuntuacion.TabIndex = 7;
            // 
            // Puntuación
            // 
            Puntuación.AutoSize = true;
            Puntuación.Location = new Point(752, 293);
            Puntuación.Name = "Puntuación";
            Puntuación.Size = new Size(97, 41);
            Puntuación.TabIndex = 6;
            Puntuación.Text = "label4";
            // 
            // btnRecorrer
            // 
            btnRecorrer.Location = new Point(521, 544);
            btnRecorrer.Name = "btnRecorrer";
            btnRecorrer.Size = new Size(188, 58);
            btnRecorrer.TabIndex = 8;
            btnRecorrer.Text = "Run";
            btnRecorrer.UseVisualStyleBackColor = true;
            btnRecorrer.Click += btnRecorrer_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 629);
            Controls.Add(btnRecorrer);
            Controls.Add(txtPuntuacion);
            Controls.Add(Puntuación);
            Controls.Add(txtSimbolos);
            Controls.Add(label3);
            Controls.Add(txtLetras);
            Controls.Add(label2);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private TextBox txtLetras;
        private Label label2;
        private TextBox txtSimbolos;
        private Label label3;
        private TextBox txtPuntuacion;
        private Label Puntuación;
        private Button btnRecorrer;
    }
}