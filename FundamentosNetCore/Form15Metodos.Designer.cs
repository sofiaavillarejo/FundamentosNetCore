namespace FundamentosNetCore
{
    partial class Form15Metodos
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
            lblResultado = new Label();
            btnDobleValor = new Button();
            btnDobleRef = new Button();
            btnObjetoRef = new Button();
            txtNumero = new TextBox();
            textBox1 = new TextBox();
            txtNumeros = new Label();
            txtLetras = new TextBox();
            label3 = new Label();
            lblRaton = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 10);
            label1.Name = "label1";
            label1.Size = new Size(127, 41);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(33, 111);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(164, 41);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Resultado: ";
            lblResultado.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(33, 187);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(188, 58);
            btnDobleValor.TabIndex = 2;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleRef
            // 
            btnDobleRef.Location = new Point(33, 276);
            btnDobleRef.Name = "btnDobleRef";
            btnDobleRef.Size = new Size(188, 58);
            btnDobleRef.TabIndex = 3;
            btnDobleRef.Text = "Doble Ref";
            btnDobleRef.UseVisualStyleBackColor = true;
            btnDobleRef.Click += btnDobleRef_Click;
            // 
            // btnObjetoRef
            // 
            btnObjetoRef.Location = new Point(33, 369);
            btnObjetoRef.Name = "btnObjetoRef";
            btnObjetoRef.Size = new Size(188, 58);
            btnObjetoRef.TabIndex = 4;
            btnObjetoRef.Text = "Objeto Ref";
            btnObjetoRef.UseVisualStyleBackColor = true;
            btnObjetoRef.Click += btnObjetoRef_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(33, 54);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(250, 47);
            txtNumero.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(383, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 7;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // txtNumeros
            // 
            txtNumeros.AutoSize = true;
            txtNumeros.Location = new Point(383, 10);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(202, 41);
            txtNumeros.TabIndex = 6;
            txtNumeros.Text = "Sólo numeros";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(383, 155);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(250, 47);
            txtLetras.TabIndex = 9;
            txtLetras.KeyPress += txtLetras_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 111);
            label3.Name = "label3";
            label3.Size = new Size(156, 41);
            label3.TabIndex = 8;
            label3.Text = "Sólo letras";
            // 
            // lblRaton
            // 
            lblRaton.Location = new Point(289, 226);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(477, 201);
            lblRaton.TabIndex = 10;
            lblRaton.Text = "lblRaton";
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // Form15Metodos
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRaton);
            Controls.Add(txtLetras);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(txtNumeros);
            Controls.Add(txtNumero);
            Controls.Add(btnObjetoRef);
            Controls.Add(btnDobleRef);
            Controls.Add(btnDobleValor);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "Form15Metodos";
            Text = "Form15Metodos";
            FormClosed += Form15Metodos_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private Button btnDobleValor;
        private Button btnDobleRef;
        private Button btnObjetoRef;
        private TextBox txtNumero;
        private TextBox textBox1;
        private Label txtNumeros;
        private TextBox txtLetras;
        private Label label3;
        private Label lblRaton;
    }
}