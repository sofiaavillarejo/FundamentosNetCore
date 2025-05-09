﻿namespace FundamentosNetCore
{
    partial class Form12ColeccionMultiple
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
            lblIndexSelect = new Label();
            lblItemSelect = new Label();
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtTexto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lstElementos = new ListBox();
            btnSeleccionados = new Button();
            lblSeleccionados = new Label();
            SuspendLayout();
            // 
            // lblIndexSelect
            // 
            lblIndexSelect.AutoSize = true;
            lblIndexSelect.Location = new Point(52, 344);
            lblIndexSelect.Name = "lblIndexSelect";
            lblIndexSelect.Size = new Size(286, 41);
            lblIndexSelect.TabIndex = 17;
            lblIndexSelect.Text = "index seleccionado: ";
            // 
            // lblItemSelect
            // 
            lblItemSelect.AutoSize = true;
            lblItemSelect.Location = new Point(52, 293);
            lblItemSelect.Name = "lblItemSelect";
            lblItemSelect.Size = new Size(273, 41);
            lblItemSelect.TabIndex = 16;
            lblItemSelect.Text = "item seleccionado: ";
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(499, 293);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(188, 58);
            btnBorrarTodo.TabIndex = 15;
            btnBorrarTodo.Text = "borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Highlight;
            btnEliminar.Location = new Point(499, 215);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 58);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = SystemColors.Info;
            btnInsertar.Location = new Point(499, 140);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(188, 58);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(474, 78);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(250, 47);
            txtTexto.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 20);
            label2.Name = "label2";
            label2.Size = new Size(239, 41);
            label2.TabIndex = 11;
            label2.Text = "Nuevo elemento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 20);
            label1.Name = "label1";
            label1.Size = new Size(156, 41);
            label1.TabIndex = 10;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.BackColor = SystemColors.GradientInactiveCaption;
            lstElementos.FormattingEnabled = true;
            lstElementos.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            lstElementos.Location = new Point(41, 64);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(300, 209);
            lstElementos.TabIndex = 9;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.FlatStyle = FlatStyle.Flat;
            btnSeleccionados.Location = new Point(499, 367);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(225, 58);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // lblSeleccionados
            // 
            lblSeleccionados.AutoSize = true;
            lblSeleccionados.Location = new Point(52, 400);
            lblSeleccionados.Name = "lblSeleccionados";
            lblSeleccionados.Size = new Size(299, 41);
            lblSeleccionados.TabIndex = 19;
            lblSeleccionados.Text = "index seleccionados: ";
            lblSeleccionados.TextAlign = ContentAlignment.TopCenter;
            lblSeleccionados.Click += label3_Click;
            // 
            // Form12ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSeleccionados);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblIndexSelect);
            Controls.Add(lblItemSelect);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtTexto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form12ColeccionMultiple";
            Text = "Form12ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndexSelect;
        private Label lblItemSelect;
        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtTexto;
        private Label label2;
        private Label label1;
        private ListBox lstElementos;
        private Button btnSeleccionados;
        private Label lblSeleccionados;
    }
}