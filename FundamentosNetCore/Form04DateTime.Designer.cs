namespace FundamentosNetCore
{
    partial class Form04DateTime
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
            txtFecha = new TextBox();
            chkCambiarFormato = new CheckBox();
            groupBox1 = new GroupBox();
            rdbDia = new RadioButton();
            rdbMes = new RadioButton();
            rdbAnyo = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            label5 = new Label();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 60);
            label1.Name = "label1";
            label1.Size = new Size(181, 41);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(75, 116);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(402, 47);
            txtFecha.TabIndex = 1;
            // 
            // chkCambiarFormato
            // 
            chkCambiarFormato.AutoSize = true;
            chkCambiarFormato.Location = new Point(75, 196);
            chkCambiarFormato.Name = "chkCambiarFormato";
            chkCambiarFormato.Size = new Size(354, 45);
            chkCambiarFormato.TabIndex = 2;
            chkCambiarFormato.Text = "cambiar formato fecha";
            chkCambiarFormato.UseVisualStyleBackColor = true;
            chkCambiarFormato.CheckedChanged += chkCambiarFormato_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbAnyo);
            groupBox1.Controls.Add(rdbMes);
            groupBox1.Controls.Add(rdbDia);
            groupBox1.Location = new Point(75, 275);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 277);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "fecha";
            // 
            // rdbDia
            // 
            rdbDia.AutoSize = true;
            rdbDia.Location = new Point(39, 83);
            rdbDia.Name = "rdbDia";
            rdbDia.Size = new Size(111, 45);
            rdbDia.TabIndex = 0;
            rdbDia.TabStop = true;
            rdbDia.Text = "Días";
            rdbDia.UseVisualStyleBackColor = true;
            // 
            // rdbMes
            // 
            rdbMes.AutoSize = true;
            rdbMes.Location = new Point(39, 134);
            rdbMes.Name = "rdbMes";
            rdbMes.Size = new Size(140, 45);
            rdbMes.TabIndex = 1;
            rdbMes.TabStop = true;
            rdbMes.Text = "Meses";
            rdbMes.UseVisualStyleBackColor = true;
            // 
            // rdbAnyo
            // 
            rdbAnyo.AutoSize = true;
            rdbAnyo.Location = new Point(39, 185);
            rdbAnyo.Name = "rdbAnyo";
            rdbAnyo.Size = new Size(122, 45);
            rdbAnyo.TabIndex = 2;
            rdbAnyo.TabStop = true;
            rdbAnyo.Text = "Años";
            rdbAnyo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 61);
            label2.Name = "label2";
            label2.Size = new Size(169, 41);
            label2.TabIndex = 4;
            label2.Text = "incremento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 116);
            label3.Name = "label3";
            label3.Size = new Size(0, 41);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 167);
            label4.Name = "label4";
            label4.Size = new Size(0, 41);
            label4.TabIndex = 6;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(349, 117);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(156, 47);
            txtIncremento.TabIndex = 4;
            // 
            // btnIncrementar
            // 
            btnIncrementar.BackColor = SystemColors.GradientActiveCaption;
            btnIncrementar.Location = new Point(306, 185);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(249, 69);
            btnIncrementar.TabIndex = 7;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = false;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 596);
            label5.Name = "label5";
            label5.Size = new Size(181, 41);
            label5.TabIndex = 4;
            label5.Text = "Nueva fecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(75, 640);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(597, 47);
            txtNuevaFecha.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 833);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(chkCambiarFormato);
            Controls.Add(txtFecha);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFecha;
        private CheckBox chkCambiarFormato;
        private GroupBox groupBox1;
        private Button btnIncrementar;
        private TextBox txtIncremento;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton rdbAnyo;
        private RadioButton rdbMes;
        private RadioButton rdbDia;
        private Label label5;
        private TextBox txtNuevaFecha;
    }
}