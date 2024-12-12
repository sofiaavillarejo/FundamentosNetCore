namespace FundamentosNetCore
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            label1 = new Label();
            btnInvertirStringBuilder = new Button();
            btnInvertirString = new Button();
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(89, 110);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(816, 390);
            txtTexto.TabIndex = 0;
            txtTexto.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 66);
            label1.Name = "label1";
            label1.Size = new Size(377, 41);
            label1.TabIndex = 1;
            label1.Text = "Copie el texto para trabajar";
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.Location = new Point(537, 578);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(368, 97);
            btnInvertirStringBuilder.TabIndex = 2;
            btnInvertirStringBuilder.Text = "Invertir StringBuilder";
            btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // btnInvertirString
            // 
            btnInvertirString.Location = new Point(89, 578);
            btnInvertirString.Name = "btnInvertirString";
            btnInvertirString.Size = new Size(368, 97);
            btnInvertirString.TabIndex = 3;
            btnInvertirString.Text = "Invertir String";
            btnInvertirString.UseVisualStyleBackColor = true;
            btnInvertirString.Click += btnInvertirString_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(89, 534);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(134, 41);
            lblTiempo.TabIndex = 4;
            lblTiempo.Text = "Tiempo: ";
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 739);
            Controls.Add(lblTiempo);
            Controls.Add(btnInvertirString);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(label1);
            Controls.Add(txtTexto);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtTexto;
        private Label label1;
        private Button btnInvertirStringBuilder;
        private Button btnInvertirString;
        private Label lblTiempo;
    }
}