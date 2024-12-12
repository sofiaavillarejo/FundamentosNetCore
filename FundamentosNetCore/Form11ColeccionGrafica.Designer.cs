namespace FundamentosNetCore
{
    partial class Form11ColeccionGrafica
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
            lstElementos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtTexto = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            lblItemSelect = new Label();
            lblIndexSelect = new Label();
            SuspendLayout();
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            lstElementos.Location = new Point(60, 88);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(300, 209);
            lstElementos.TabIndex = 0;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 44);
            label1.Name = "label1";
            label1.Size = new Size(156, 41);
            label1.TabIndex = 1;
            label1.Text = "Elementos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 44);
            label2.Name = "label2";
            label2.Size = new Size(239, 41);
            label2.TabIndex = 2;
            label2.Text = "Nuevo elemento";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(493, 102);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(250, 47);
            txtTexto.TabIndex = 3;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(518, 197);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(188, 58);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(518, 283);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 58);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(518, 358);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(188, 58);
            btnBorrarTodo.TabIndex = 6;
            btnBorrarTodo.Text = "borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // lblItemSelect
            // 
            lblItemSelect.AutoSize = true;
            lblItemSelect.Location = new Point(71, 326);
            lblItemSelect.Name = "lblItemSelect";
            lblItemSelect.Size = new Size(273, 41);
            lblItemSelect.TabIndex = 7;
            lblItemSelect.Text = "item seleccionado: ";
            // 
            // lblIndexSelect
            // 
            lblIndexSelect.AutoSize = true;
            lblIndexSelect.Location = new Point(71, 391);
            lblIndexSelect.Name = "lblIndexSelect";
            lblIndexSelect.Size = new Size(286, 41);
            lblIndexSelect.TabIndex = 8;
            lblIndexSelect.Text = "index seleccionado: ";
            // 
            // Form11ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIndexSelect);
            Controls.Add(lblItemSelect);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtTexto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form11ColeccionGrafica";
            Text = "Form11ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstElementos;
        private Label label1;
        private Label label2;
        private TextBox txtTexto;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label lblItemSelect;
        private Label lblIndexSelect;
    }
}