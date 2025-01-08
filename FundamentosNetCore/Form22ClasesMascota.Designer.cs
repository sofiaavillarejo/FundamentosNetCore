namespace FundamentosNetCore
{
    partial class Form22ClasesMascota
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnNew = new Button();
            btnRead = new Button();
            btnSave = new Button();
            label3 = new Label();
            lstMascotas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 48);
            label1.Name = "label1";
            label1.Size = new Size(128, 41);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 178);
            label2.Name = "label2";
            label2.Size = new Size(80, 41);
            label2.TabIndex = 1;
            label2.Text = "Raza";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 3;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(114, 326);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(250, 67);
            btnNew.TabIndex = 4;
            btnNew.Text = "Nueva Mascota";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(114, 416);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(250, 67);
            btnRead.TabIndex = 5;
            btnRead.Text = "Leer mascotas";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(114, 507);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 67);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar mascotas";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(662, 48);
            label3.Name = "label3";
            label3.Size = new Size(143, 41);
            label3.TabIndex = 7;
            label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(662, 102);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(300, 209);
            lstMascotas.TabIndex = 8;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Form22ClasesMascota
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 599);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(btnRead);
            Controls.Add(btnNew);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form22ClasesMascota";
            Text = "Form22ClasesMascota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnNew;
        private Button btnRead;
        private Button btnSave;
        private Label label3;
        private ListBox lstMascotas;
    }
}