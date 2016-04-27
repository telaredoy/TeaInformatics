namespace deposito
{
    partial class frm_CargarStock
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
            this.tb_Descripcion = new System.Windows.Forms.TextBox();
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lv_productos = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelarr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Cantidad = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Descripcion
            // 
            this.tb_Descripcion.Location = new System.Drawing.Point(104, 67);
            this.tb_Descripcion.MaxLength = 100;
            this.tb_Descripcion.Name = "tb_Descripcion";
            this.tb_Descripcion.Size = new System.Drawing.Size(222, 26);
            this.tb_Descripcion.TabIndex = 1;
            this.tb_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.Location = new System.Drawing.Point(104, 22);
            this.tb_Codigo.MaxLength = 50;
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(222, 26);
            this.tb_Codigo.TabIndex = 0;
            this.tb_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Codigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_Descripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 121);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(458, 59);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(56, 26);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(431, 247);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(131, 45);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.ClickEvent);
            // 
            // lv_productos
            // 
            this.lv_productos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_productos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Descripcion,
            this.Cantidad});
            this.lv_productos.FullRowSelect = true;
            this.lv_productos.GridLines = true;
            this.lv_productos.Location = new System.Drawing.Point(12, 139);
            this.lv_productos.MultiSelect = false;
            this.lv_productos.Name = "lv_productos";
            this.lv_productos.Size = new System.Drawing.Size(413, 153);
            this.lv_productos.TabIndex = 7;
            this.lv_productos.UseCompatibleStateImageBehavior = false;
            this.lv_productos.View = System.Windows.Forms.View.Details;
            this.lv_productos.DoubleClick += new System.EventHandler(this.DoubleClickEvent);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            this.Codigo.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripción";
            this.Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Descripcion.Width = 222;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cantidad.Width = 65;
            // 
            // tb_Cantidad
            // 
            this.tb_Cantidad.Location = new System.Drawing.Point(393, 63);
            this.tb_Cantidad.MaxLength = 5;
            this.tb_Cantidad.Name = "tb_Cantidad";
            this.tb_Cantidad.Size = new System.Drawing.Size(59, 20);
            this.tb_Cantidad.TabIndex = 2;
            this.tb_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(431, 196);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(131, 45);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Cancelarr
            // 
            this.btn_Cancelarr.Location = new System.Drawing.Point(520, 59);
            this.btn_Cancelarr.Name = "btn_Cancelarr";
            this.btn_Cancelarr.Size = new System.Drawing.Size(60, 26);
            this.btn_Cancelarr.TabIndex = 4;
            this.btn_Cancelarr.Text = "Cancelar";
            this.btn_Cancelarr.UseVisualStyleBackColor = true;
            this.btn_Cancelarr.Click += new System.EventHandler(this.ClickEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad de modificaciones:";
            // 
            // lb_Cantidad
            // 
            this.lb_Cantidad.AutoSize = true;
            this.lb_Cantidad.Location = new System.Drawing.Point(422, 296);
            this.lb_Cantidad.Name = "lb_Cantidad";
            this.lb_Cantidad.Size = new System.Drawing.Size(13, 13);
            this.lb_Cantidad.TabIndex = 12;
            this.lb_Cantidad.Text = "0";
            // 
            // frm_CargarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 315);
            this.Controls.Add(this.lb_Cantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Cancelarr);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Cantidad);
            this.Controls.Add(this.lv_productos);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_CargarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Stock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Descripcion;
        private System.Windows.Forms.TextBox tb_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ListView lv_productos;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.TextBox tb_Cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelarr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Cantidad;
    }
}