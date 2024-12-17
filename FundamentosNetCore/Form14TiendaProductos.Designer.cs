namespace FundamentosNetCore
{
    partial class Form14TiendaProductos
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
            txtProducto = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            label2 = new Label();
            btnSeleccion = new Button();
            btnTodos = new Button();
            Almacén = new Label();
            btnSubir = new Button();
            btnBajar = new Button();
            lstTienda = new ListBox();
            lstAlmacen = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 57);
            label1.Name = "label1";
            label1.Size = new Size(140, 41);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(37, 113);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(188, 47);
            txtProducto.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(37, 204);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(188, 58);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(37, 283);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 58);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(37, 367);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(188, 58);
            btnBorrarTodo.TabIndex = 4;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 57);
            label2.Name = "label2";
            label2.Size = new Size(107, 41);
            label2.TabIndex = 5;
            label2.Text = "Tienda";
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(583, 149);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(158, 58);
            btnSeleccion.TabIndex = 7;
            btnSeleccion.Text = "Selección";
            btnSeleccion.TextAlign = ContentAlignment.MiddleRight;
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(583, 256);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(162, 58);
            btnTodos.TabIndex = 8;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // Almacén
            // 
            Almacén.AutoSize = true;
            Almacén.Location = new Point(831, 57);
            Almacén.Name = "Almacén";
            Almacén.Size = new Size(132, 41);
            Almacén.TabIndex = 9;
            Almacén.Text = "Almacén";
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(1123, 149);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(158, 58);
            btnSubir.TabIndex = 11;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(1123, 256);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(158, 58);
            btnBajar.TabIndex = 12;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(255, 132);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(300, 209);
            lstTienda.TabIndex = 13;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(787, 132);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(300, 209);
            lstAlmacen.TabIndex = 14;
            // 
            // Form14TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 453);
            Controls.Add(lstAlmacen);
            Controls.Add(lstTienda);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(Almacén);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(label2);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Name = "Form14TiendaProductos";
            Text = "Form14TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label label2;
        private Button btnSeleccion;
        private Button btnTodos;
        private Label Almacén;
        private Button btnSubir;
        private Button btnBajar;
        private ListBox lstTienda;
        private ListBox lstAlmacen;
    }
}