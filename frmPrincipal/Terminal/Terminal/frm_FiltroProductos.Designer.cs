namespace Terminal
{
    partial class frm_FiltroProductos
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
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.lv_Productos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Location = new System.Drawing.Point(224, 191);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(124, 40);
            this.btn_Cargar.TabIndex = 3;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.ClickBotton);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(364, 191);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(124, 40);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.ClickBotton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcion:";
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(121, 24);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(367, 20);
            this.txt_Filtro.TabIndex = 0;
            this.txt_Filtro.TextChanged += new System.EventHandler(this.TextChange);
            this.txt_Filtro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // lv_Productos
            // 
            this.lv_Productos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_Productos.FullRowSelect = true;
            this.lv_Productos.GridLines = true;
            this.lv_Productos.Location = new System.Drawing.Point(37, 61);
            this.lv_Productos.MultiSelect = false;
            this.lv_Productos.Name = "lv_Productos";
            this.lv_Productos.Size = new System.Drawing.Size(451, 109);
            this.lv_Productos.TabIndex = 1;
            this.lv_Productos.UseCompatibleStateImageBehavior = false;
            this.lv_Productos.View = System.Windows.Forms.View.Details;
            this.lv_Productos.Click += new System.EventHandler(this.DobleClickEvent);
            this.lv_Productos.DoubleClick += new System.EventHandler(this.DobleClickEvent);
            this.lv_Productos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nº Codigo ";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripcion";
            this.columnHeader2.Width = 263;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            this.columnHeader3.Width = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad:";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Enabled = false;
            this.txt_Cantidad.Location = new System.Drawing.Point(92, 202);
            this.txt_Cantidad.MaxLength = 5;
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Cantidad.Size = new System.Drawing.Size(33, 20);
            this.txt_Cantidad.TabIndex = 2;
            this.txt_Cantidad.Text = "1";
            this.txt_Cantidad.TextChanged += new System.EventHandler(this.TextChange);
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // frm_FiltroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 277);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lv_Productos);
            this.Controls.Add(this.txt_Filtro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Cargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_FiltroProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_FiltroProductos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Filtro;
        private System.Windows.Forms.ListView lv_Productos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cantidad;
    }
}