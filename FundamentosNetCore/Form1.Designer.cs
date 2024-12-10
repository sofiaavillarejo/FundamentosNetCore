namespace FundamentosNetCore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPulsar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnPulsar
            // 
            btnPulsar.Location = new Point(84, 210);
            btnPulsar.Name = "btnPulsar";
            btnPulsar.Size = new Size(222, 65);
            btnPulsar.TabIndex = 0;
            btnPulsar.Text = "button1";
            btnPulsar.UseVisualStyleBackColor = true;
            btnPulsar.Click += btnPulsar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 40);
            label1.Name = "label1";
            label1.Size = new Size(314, 41);
            label1.TabIndex = 1;
            label1.Text = "Introduzca un nombre";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(56, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 47);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnPulsar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPulsar;
        private Label label1;
        private TextBox txtNombre;
    }
}
