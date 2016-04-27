namespace deposito
{
    partial class frm_ABProductos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.btn_NuevoProveedor = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Ganancia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CantT = new System.Windows.Forms.TextBox();
            this.txt_CantP = new System.Windows.Forms.TextBox();
            this.txt_StockCritico = new System.Windows.Forms.TextBox();
            this.txt_PrecioV = new System.Windows.Forms.TextBox();
            this.txt_PrecioC = new System.Windows.Forms.TextBox();
            this.txt_Rubro = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_DesTicket = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lv_Productos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            this.btn_Elminar = new System.Windows.Forms.Button();
            this.btn_Refrescar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.btn_Cargar);
            this.groupBox1.Controls.Add(this.btn_NuevoProveedor);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_Ganancia);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_CantT);
            this.groupBox1.Controls.Add(this.txt_CantP);
            this.groupBox1.Controls.Add(this.txt_StockCritico);
            this.groupBox1.Controls.Add(this.txt_PrecioV);
            this.groupBox1.Controls.Add(this.txt_PrecioC);
            this.groupBox1.Controls.Add(this.txt_Rubro);
            this.groupBox1.Controls.Add(this.txt_Cantidad);
            this.groupBox1.Controls.Add(this.txt_DesTicket);
            this.groupBox1.Controls.Add(this.txt_Descripcion);
            this.groupBox1.Controls.Add(this.txt_Codigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de producto";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(286, 229);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(145, 23);
            this.btn_Cancelar.TabIndex = 46;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Location = new System.Drawing.Point(286, 200);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(145, 23);
            this.btn_Cargar.TabIndex = 45;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_NuevoProveedor
            // 
            this.btn_NuevoProveedor.Location = new System.Drawing.Point(264, 75);
            this.btn_NuevoProveedor.Name = "btn_NuevoProveedor";
            this.btn_NuevoProveedor.Size = new System.Drawing.Size(182, 22);
            this.btn_NuevoProveedor.TabIndex = 44;
            this.btn_NuevoProveedor.Text = "Nuevo Proveedor";
            this.btn_NuevoProveedor.UseVisualStyleBackColor = true;
            this.btn_NuevoProveedor.Click += new System.EventHandler(this.ClickEvent);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(264, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(317, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Proveedor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Ganancia : %";
            // 
            // txt_Ganancia
            // 
            this.txt_Ganancia.Location = new System.Drawing.Point(349, 158);
            this.txt_Ganancia.MaxLength = 6;
            this.txt_Ganancia.Name = "txt_Ganancia";
            this.txt_Ganancia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Ganancia.Size = new System.Drawing.Size(100, 20);
            this.txt_Ganancia.TabIndex = 11;
            this.txt_Ganancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            this.txt_Ganancia.Leave += new System.EventHandler(this.txt_Ganancia_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Cantidad Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Cantidad Particionable:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Stock Critico:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Precio venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Precio costo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Rubro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Descripcion Ticket:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Codigo:";
            // 
            // txt_CantT
            // 
            this.txt_CantT.Enabled = false;
            this.txt_CantT.Location = new System.Drawing.Point(349, 129);
            this.txt_CantT.Name = "txt_CantT";
            this.txt_CantT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CantT.Size = new System.Drawing.Size(100, 20);
            this.txt_CantT.TabIndex = 10;
            this.txt_CantT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // txt_CantP
            // 
            this.txt_CantP.Location = new System.Drawing.Point(158, 129);
            this.txt_CantP.MaxLength = 5;
            this.txt_CantP.Name = "txt_CantP";
            this.txt_CantP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CantP.Size = new System.Drawing.Size(100, 20);
            this.txt_CantP.TabIndex = 4;
            this.txt_CantP.Text = "1";
            this.txt_CantP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            this.txt_CantP.Leave += new System.EventHandler(this.txt_CantP_Leave);
            // 
            // txt_StockCritico
            // 
            this.txt_StockCritico.Location = new System.Drawing.Point(158, 207);
            this.txt_StockCritico.MaxLength = 4;
            this.txt_StockCritico.Name = "txt_StockCritico";
            this.txt_StockCritico.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_StockCritico.Size = new System.Drawing.Size(100, 20);
            this.txt_StockCritico.TabIndex = 7;
            this.txt_StockCritico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // txt_PrecioV
            // 
            this.txt_PrecioV.Location = new System.Drawing.Point(158, 181);
            this.txt_PrecioV.MaxLength = 10;
            this.txt_PrecioV.Name = "txt_PrecioV";
            this.txt_PrecioV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_PrecioV.Size = new System.Drawing.Size(100, 20);
            this.txt_PrecioV.TabIndex = 6;
            this.txt_PrecioV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            this.txt_PrecioV.Leave += new System.EventHandler(this.txt_PrecioV_Leave);
            // 
            // txt_PrecioC
            // 
            this.txt_PrecioC.Location = new System.Drawing.Point(158, 155);
            this.txt_PrecioC.MaxLength = 10;
            this.txt_PrecioC.Name = "txt_PrecioC";
            this.txt_PrecioC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_PrecioC.Size = new System.Drawing.Size(100, 20);
            this.txt_PrecioC.TabIndex = 5;
            this.txt_PrecioC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // txt_Rubro
            // 
            this.txt_Rubro.Location = new System.Drawing.Point(158, 232);
            this.txt_Rubro.MaxLength = 50;
            this.txt_Rubro.Name = "txt_Rubro";
            this.txt_Rubro.Size = new System.Drawing.Size(100, 20);
            this.txt_Rubro.TabIndex = 8;
            this.txt_Rubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(158, 103);
            this.txt_Cantidad.MaxLength = 4;
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 3;
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // txt_DesTicket
            // 
            this.txt_DesTicket.Location = new System.Drawing.Point(158, 77);
            this.txt_DesTicket.MaxLength = 100;
            this.txt_DesTicket.Name = "txt_DesTicket";
            this.txt_DesTicket.Size = new System.Drawing.Size(100, 20);
            this.txt_DesTicket.TabIndex = 2;
            this.txt_DesTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(158, 51);
            this.txt_Descripcion.MaxLength = 100;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_Descripcion.TabIndex = 1;
            this.txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(158, 25);
            this.txt_Codigo.MaxLength = 50;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo.TabIndex = 0;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            this.txt_Codigo.Leave += new System.EventHandler(this.txt_Codigo_Leave);
            // 
            // lv_Productos
            // 
            this.lv_Productos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_Productos.FullRowSelect = true;
            this.lv_Productos.GridLines = true;
            this.lv_Productos.Location = new System.Drawing.Point(516, 66);
            this.lv_Productos.MultiSelect = false;
            this.lv_Productos.Name = "lv_Productos";
            this.lv_Productos.Size = new System.Drawing.Size(419, 184);
            this.lv_Productos.TabIndex = 1;
            this.lv_Productos.UseCompatibleStateImageBehavior = false;
            this.lv_Productos.View = System.Windows.Forms.View.Details;
            this.lv_Productos.Click += new System.EventHandler(this.ClickEvent);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripcion";
            this.columnHeader2.Width = 173;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Proveedor";
            this.columnHeader3.Width = 165;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(519, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Buscar por codigo:";
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.Location = new System.Drawing.Point(621, 37);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Buscador.Size = new System.Drawing.Size(180, 20);
            this.txt_Buscador.TabIndex = 45;
            this.txt_Buscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // btn_Elminar
            // 
            this.btn_Elminar.Location = new System.Drawing.Point(516, 256);
            this.btn_Elminar.Name = "btn_Elminar";
            this.btn_Elminar.Size = new System.Drawing.Size(419, 26);
            this.btn_Elminar.TabIndex = 47;
            this.btn_Elminar.Text = "Eliminar producto";
            this.btn_Elminar.UseVisualStyleBackColor = true;
            this.btn_Elminar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.Location = new System.Drawing.Point(807, 37);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(128, 21);
            this.btn_Refrescar.TabIndex = 48;
            this.btn_Refrescar.Text = "Refrescar Lista";
            this.btn_Refrescar.UseVisualStyleBackColor = true;
            this.btn_Refrescar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // frm_ABProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 301);
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.btn_Elminar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lv_Productos);
            this.Controls.Add(this.txt_Buscador);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_ABProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AB Productos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_NuevoProveedor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Ganancia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CantT;
        private System.Windows.Forms.TextBox txt_CantP;
        private System.Windows.Forms.TextBox txt_StockCritico;
        private System.Windows.Forms.TextBox txt_PrecioV;
        private System.Windows.Forms.TextBox txt_PrecioC;
        private System.Windows.Forms.TextBox txt_Rubro;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_DesTicket;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.ListView lv_Productos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Buscador;
        private System.Windows.Forms.Button btn_Elminar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.Button btn_Refrescar;
    }
}