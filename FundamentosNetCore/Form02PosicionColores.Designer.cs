namespace FundamentosNetCore
{
    partial class Form02PosicionColores
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
            label4 = new Label();
            label5 = new Label();
            btnCambiarPosicion = new Button();
            txtRojo = new TextBox();
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            btnCambiarColor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 55);
            label1.Name = "label1";
            label1.Size = new Size(161, 41);
            label1.TabIndex = 0;
            label1.Text = "Posición X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 163);
            label2.Name = "label2";
            label2.Size = new Size(168, 41);
            label2.TabIndex = 1;
            label2.Text = "Posición Y: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 65);
            label3.Name = "label3";
            label3.Size = new Size(78, 41);
            label3.TabIndex = 2;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 147);
            label4.Name = "label4";
            label4.Size = new Size(95, 41);
            label4.TabIndex = 3;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(488, 235);
            label5.Name = "label5";
            label5.Size = new Size(75, 41);
            label5.TabIndex = 4;
            label5.Text = "Azul";
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(56, 244);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(301, 58);
            btnCambiarPosicion.TabIndex = 5;
            btnCambiarPosicion.Text = "Cambiar posicion";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += btnCambiarPosicion_Click;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(627, 62);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(140, 47);
            txtRojo.TabIndex = 6;
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(223, 49);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(139, 47);
            txtPosX.TabIndex = 7;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(223, 157);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(139, 47);
            txtPosY.TabIndex = 8;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(628, 147);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(139, 47);
            txtVerde.TabIndex = 9;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(628, 235);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(139, 47);
            txtAzul.TabIndex = 10;
            // 
            // btnCambiarColor
            // 
            btnCambiarColor.Location = new Point(466, 335);
            btnCambiarColor.Name = "btnCambiarColor";
            btnCambiarColor.Size = new Size(301, 58);
            btnCambiarColor.TabIndex = 11;
            btnCambiarColor.Text = "Cambiar color";
            btnCambiarColor.UseVisualStyleBackColor = true;
            btnCambiarColor.Click += btnCambiarColor_Click;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarColor);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtPosY);
            Controls.Add(txtPosX);
            Controls.Add(txtRojo);
            Controls.Add(btnCambiarPosicion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCambiarPosicion;
        private TextBox txtRojo;
        private TextBox txtPosX;
        private TextBox txtPosY;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnCambiarColor;
    }
}