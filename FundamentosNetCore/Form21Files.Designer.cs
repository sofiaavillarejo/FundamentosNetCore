namespace FundamentosNetCore
{
    partial class Form21Files
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
            txtContenido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            btnNuevo = new Button();
            btnRead = new Button();
            btnWrite = new Button();
            label3 = new Label();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(39, 83);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(353, 390);
            txtContenido.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 27);
            label1.Name = "label1";
            label1.Size = new Size(211, 41);
            label1.TabIndex = 1;
            label1.Text = "Contenido File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 27);
            label2.Name = "label2";
            label2.Size = new Size(128, 41);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(435, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 47);
            txtNombre.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(435, 174);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(188, 90);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo nombre";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(435, 284);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(188, 58);
            btnRead.TabIndex = 5;
            btnRead.Text = "Read File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(435, 364);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(188, 58);
            btnWrite.TabIndex = 6;
            btnWrite.Text = "Write File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(707, 27);
            label3.Name = "label3";
            label3.Size = new Size(141, 41);
            label3.TabIndex = 8;
            label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(719, 103);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(373, 332);
            lstNombres.TabIndex = 9;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 525);
            Controls.Add(lstNombres);
            Controls.Add(label3);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Controls.Add(btnNuevo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(txtContenido);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContenido;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Button btnNuevo;
        private Button btnRead;
        private Button btnWrite;
        private Label label3;
        private ListBox lstNombres;
    }
}