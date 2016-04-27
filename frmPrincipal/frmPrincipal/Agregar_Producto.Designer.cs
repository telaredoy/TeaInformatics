namespace frmPrincipal
{
    partial class Agregar_Producto
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
            this.Txt_CodigoProducto = new System.Windows.Forms.TextBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_DescripcionTicket = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Txt_CantidadParticionable = new System.Windows.Forms.TextBox();
            this.Txt_CantidadTotal = new System.Windows.Forms.TextBox();
            this.Txt_PrecioCosto = new System.Windows.Forms.TextBox();
            this.Txt_PorcentajeGanancia = new System.Windows.Forms.TextBox();
            this.Txt_StockCritico = new System.Windows.Forms.TextBox();
            this.Txt_PrecioVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.lb_Alerta = new System.Windows.Forms.Label();
            this.cb_prove = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Txt_Rubro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Rubro = new System.Windows.Forms.Button();
            this.btn_Proovedor = new System.Windows.Forms.Button();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.cb_Rubro = new System.Windows.Forms.ComboBox();
            this.cb_Proveedor = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lv_productos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_CodigoProducto
            // 
            this.Txt_CodigoProducto.Location = new System.Drawing.Point(10, 47);
            this.Txt_CodigoProducto.MaxLength = 25;
            this.Txt_CodigoProducto.Name = "Txt_CodigoProducto";
            this.Txt_CodigoProducto.Size = new System.Drawing.Size(128, 20);
            this.Txt_CodigoProducto.TabIndex = 0;
            this.Txt_CodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_CodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotLetter);
            this.Txt_CodigoProducto.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(143, 47);
            this.Txt_Descripcion.MaxLength = 100;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(128, 20);
            this.Txt_Descripcion.TabIndex = 1;
            // 
            // Txt_DescripcionTicket
            // 
            this.Txt_DescripcionTicket.Location = new System.Drawing.Point(277, 47);
            this.Txt_DescripcionTicket.MaxLength = 50;
            this.Txt_DescripcionTicket.Name = "Txt_DescripcionTicket";
            this.Txt_DescripcionTicket.Size = new System.Drawing.Size(128, 20);
            this.Txt_DescripcionTicket.TabIndex = 2;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(411, 47);
            this.Txt_Cantidad.MaxLength = 25;
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(128, 20);
            this.Txt_Cantidad.TabIndex = 3;
            this.Txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Cantidad.TextChanged += new System.EventHandler(this.Event_TextChange);
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotLetter);
            this.Txt_Cantidad.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // Txt_CantidadParticionable
            // 
            this.Txt_CantidadParticionable.Location = new System.Drawing.Point(411, 92);
            this.Txt_CantidadParticionable.Name = "Txt_CantidadParticionable";
            this.Txt_CantidadParticionable.Size = new System.Drawing.Size(128, 20);
            this.Txt_CantidadParticionable.TabIndex = 4;
            this.Txt_CantidadParticionable.TabStop = false;
            this.Txt_CantidadParticionable.Text = "1";
            this.Txt_CantidadParticionable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_CantidadParticionable.TextChanged += new System.EventHandler(this.Event_TextChange);
            this.Txt_CantidadParticionable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotLetter);
            // 
            // Txt_CantidadTotal
            // 
            this.Txt_CantidadTotal.Enabled = false;
            this.Txt_CantidadTotal.Location = new System.Drawing.Point(411, 136);
            this.Txt_CantidadTotal.Name = "Txt_CantidadTotal";
            this.Txt_CantidadTotal.Size = new System.Drawing.Size(128, 20);
            this.Txt_CantidadTotal.TabIndex = 5;
            this.Txt_CantidadTotal.TabStop = false;
            this.Txt_CantidadTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_CantidadTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotLetter);
            // 
            // Txt_PrecioCosto
            // 
            this.Txt_PrecioCosto.Location = new System.Drawing.Point(545, 47);
            this.Txt_PrecioCosto.MaxLength = 15;
            this.Txt_PrecioCosto.Name = "Txt_PrecioCosto";
            this.Txt_PrecioCosto.Size = new System.Drawing.Size(128, 20);
            this.Txt_PrecioCosto.TabIndex = 6;
            this.Txt_PrecioCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_PrecioCosto.TextChanged += new System.EventHandler(this.Event_TextChange);
            this.Txt_PrecioCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotLetter);
            this.Txt_PrecioCosto.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // Txt_PorcentajeGanancia
            // 
            this.Txt_PorcentajeGanancia.Enabled = false;
            this.Txt_PorcentajeGanancia.Location = new System.Drawing.Point(679, 92);
            this.Txt_PorcentajeGanancia.MaxLength = 5;
            this.Txt_PorcentajeGanancia.Name = "Txt_PorcentajeGanancia";
            this.Txt_PorcentajeGanancia.Size = new System.Drawing.Size(128, 20);
            this.Txt_PorcentajeGanancia.TabIndex = 8;
            this.Txt_PorcentajeGanancia.TabStop = false;
            this.Txt_PorcentajeGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_PorcentajeGanancia.TextChanged += new System.EventHandler(this.Event_TextChange);
            this.Txt_PorcentajeGanancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotLetter);
            this.Txt_PorcentajeGanancia.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // Txt_StockCritico
            // 
            this.Txt_StockCritico.Location = new System.Drawing.Point(947, 47);
            this.Txt_StockCritico.MaxLength = 5;
            this.Txt_StockCritico.Name = "Txt_StockCritico";
            this.Txt_StockCritico.Size = new System.Drawing.Size(128, 20);
            this.Txt_StockCritico.TabIndex = 10;
            this.Txt_StockCritico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_StockCritico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotLetter);
            // 
            // Txt_PrecioVenta
            // 
            this.Txt_PrecioVenta.Enabled = false;
            this.Txt_PrecioVenta.Location = new System.Drawing.Point(679, 47);
            this.Txt_PrecioVenta.MaxLength = 16;
            this.Txt_PrecioVenta.Name = "Txt_PrecioVenta";
            this.Txt_PrecioVenta.Size = new System.Drawing.Size(128, 20);
            this.Txt_PrecioVenta.TabIndex = 7;
            this.Txt_PrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_PrecioVenta.TextChanged += new System.EventHandler(this.Event_TextChange);
            this.Txt_PrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotLetter);
            this.Txt_PrecioVenta.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Código producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descripción Ticket:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad Particionable:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cantidad Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio Costo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Porcentaje de Ganancia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(676, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Precio Venta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(810, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Proveedor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(944, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Stock Crítico:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1078, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Rubro:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btn_Borrar);
            this.groupBox1.Controls.Add(this.lb_Alerta);
            this.groupBox1.Controls.Add(this.cb_prove);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btn_Actualizar);
            this.groupBox1.Controls.Add(this.Btn_Cancelar);
            this.groupBox1.Controls.Add(this.Btn_Aceptar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Txt_StockCritico);
            this.groupBox1.Controls.Add(this.Txt_Rubro);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Txt_CodigoProducto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Txt_Descripcion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Txt_DescripcionTicket);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Txt_Cantidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Txt_CantidadParticionable);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txt_CantidadTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_PrecioCosto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_PorcentajeGanancia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_PrecioVenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 167);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Producto";
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(813, 126);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(128, 35);
            this.btn_Borrar.TabIndex = 27;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Visible = false;
            this.btn_Borrar.Click += new System.EventHandler(this.Event_click);
            // 
            // lb_Alerta
            // 
            this.lb_Alerta.AutoSize = true;
            this.lb_Alerta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Alerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Alerta.ForeColor = System.Drawing.Color.Red;
            this.lb_Alerta.Location = new System.Drawing.Point(7, 70);
            this.lb_Alerta.Name = "lb_Alerta";
            this.lb_Alerta.Size = new System.Drawing.Size(159, 15);
            this.lb_Alerta.TabIndex = 26;
            this.lb_Alerta.Text = "CÓDIGO YA EXISTENTE";
            this.lb_Alerta.Visible = false;
            // 
            // cb_prove
            // 
            this.cb_prove.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_prove.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_prove.DisplayMember = "Cod_Proveedor";
            this.cb_prove.FormattingEnabled = true;
            this.cb_prove.Location = new System.Drawing.Point(813, 46);
            this.cb_prove.Name = "cb_prove";
            this.cb_prove.Size = new System.Drawing.Size(121, 21);
            this.cb_prove.TabIndex = 25;
            this.cb_prove.ValueMember = "Cod_Proveedor";
            this.cb_prove.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(682, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "%";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(947, 126);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(128, 36);
            this.btn_Actualizar.TabIndex = 23;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Visible = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.Event_click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(1081, 126);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(128, 36);
            this.Btn_Cancelar.TabIndex = 13;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Event_click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Location = new System.Drawing.Point(947, 125);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(128, 36);
            this.Btn_Aceptar.TabIndex = 12;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Event_click);
            // 
            // Txt_Rubro
            // 
            this.Txt_Rubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Rubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Rubro.Location = new System.Drawing.Point(1081, 47);
            this.Txt_Rubro.MaxLength = 100;
            this.Txt_Rubro.Name = "Txt_Rubro";
            this.Txt_Rubro.Size = new System.Drawing.Size(128, 20);
            this.Txt_Rubro.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btn_Rubro);
            this.groupBox2.Controls.Add(this.btn_Proovedor);
            this.groupBox2.Controls.Add(this.txt_filtro);
            this.groupBox2.Controls.Add(this.cb_Rubro);
            this.groupBox2.Controls.Add(this.cb_Proveedor);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lv_productos);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1222, 363);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock de Productos";
            // 
            // btn_Rubro
            // 
            this.btn_Rubro.Location = new System.Drawing.Point(561, 77);
            this.btn_Rubro.Name = "btn_Rubro";
            this.btn_Rubro.Size = new System.Drawing.Size(28, 23);
            this.btn_Rubro.TabIndex = 8;
            this.btn_Rubro.Text = ">";
            this.btn_Rubro.UseVisualStyleBackColor = true;
            this.btn_Rubro.Click += new System.EventHandler(this.Event_click);
            // 
            // btn_Proovedor
            // 
            this.btn_Proovedor.Location = new System.Drawing.Point(274, 77);
            this.btn_Proovedor.Name = "btn_Proovedor";
            this.btn_Proovedor.Size = new System.Drawing.Size(28, 23);
            this.btn_Proovedor.TabIndex = 7;
            this.btn_Proovedor.Text = ">";
            this.btn_Proovedor.UseVisualStyleBackColor = true;
            this.btn_Proovedor.Click += new System.EventHandler(this.Event_click);
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(160, 40);
            this.txt_filtro.MaxLength = 100;
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(430, 20);
            this.txt_filtro.TabIndex = 6;
            this.txt_filtro.TextChanged += new System.EventHandler(this.Event_TextChange);
            // 
            // cb_Rubro
            // 
            this.cb_Rubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_Rubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Rubro.DisplayMember = "Cod_Producto";
            this.cb_Rubro.FormattingEnabled = true;
            this.cb_Rubro.Location = new System.Drawing.Point(356, 78);
            this.cb_Rubro.Name = "cb_Rubro";
            this.cb_Rubro.Size = new System.Drawing.Size(199, 21);
            this.cb_Rubro.TabIndex = 5;
            this.cb_Rubro.ValueMember = "Cod_Producto";
            // 
            // cb_Proveedor
            // 
            this.cb_Proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_Proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Proveedor.DisplayMember = "Cod_Proveedor";
            this.cb_Proveedor.FormattingEnabled = true;
            this.cb_Proveedor.Location = new System.Drawing.Point(72, 78);
            this.cb_Proveedor.Name = "cb_Proveedor";
            this.cb_Proveedor.Size = new System.Drawing.Size(199, 21);
            this.cb_Proveedor.TabIndex = 4;
            this.cb_Proveedor.ValueMember = "Cod_Proveedor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(311, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Rubro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Proveedor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Filtrar por Descripción/Código:";
            // 
            // lv_productos
            // 
            this.lv_productos.BackColor = System.Drawing.Color.LightSlateGray;
            this.lv_productos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_productos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader11});
            this.lv_productos.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lv_productos.FullRowSelect = true;
            this.lv_productos.GridLines = true;
            this.lv_productos.Location = new System.Drawing.Point(6, 110);
            this.lv_productos.MultiSelect = false;
            this.lv_productos.Name = "lv_productos";
            this.lv_productos.Size = new System.Drawing.Size(1199, 247);
            this.lv_productos.TabIndex = 0;
            this.lv_productos.UseCompatibleStateImageBehavior = false;
            this.lv_productos.View = System.Windows.Forms.View.Details;
            this.lv_productos.DoubleClick += new System.EventHandler(this.lv_productos_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código del Producto:";
            this.columnHeader1.Width = 112;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripción:";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descripción Ticket:";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cantidad:";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Candtidad Particionable:";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 131;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cantidad Total:";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 88;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Precio de Venta:";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 93;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Costo:";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 46;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Porcentaje de Ganancia:";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 130;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Proveedor:";
            this.columnHeader10.Width = 123;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Rubro:";
            this.columnHeader12.Width = 88;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Stock Crítico:";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 84;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cerrar.Location = new System.Drawing.Point(1225, -1);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(25, 23);
            this.btn_Cerrar.TabIndex = 24;
            this.btn_Cerrar.Text = "X";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.Event_click);
            // 
            // Agregar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1249, 594);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregar_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_CodigoProducto;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.TextBox Txt_DescripcionTicket;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.TextBox Txt_CantidadParticionable;
        private System.Windows.Forms.TextBox Txt_CantidadTotal;
        private System.Windows.Forms.TextBox Txt_PrecioCosto;
        private System.Windows.Forms.TextBox Txt_PorcentajeGanancia;
        private System.Windows.Forms.TextBox Txt_StockCritico;
        private System.Windows.Forms.TextBox Txt_PrecioVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.ListView lv_productos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.ComboBox cb_Rubro;
        private System.Windows.Forms.ComboBox cb_Proveedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_prove;
        private System.Windows.Forms.TextBox Txt_Rubro;
        private System.Windows.Forms.Label lb_Alerta;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Rubro;
        private System.Windows.Forms.Button btn_Proovedor;
        
    }
}