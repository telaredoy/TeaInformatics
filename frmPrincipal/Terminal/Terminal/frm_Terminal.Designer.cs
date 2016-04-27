namespace Terminal
{
    partial class frm_Terminal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lv_Detalle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label_Cliente = new System.Windows.Forms.Label();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btn_Retiros = new System.Windows.Forms.Button();
            this.btn_Ventas = new System.Windows.Forms.Button();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_ImprimirB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Ticket = new System.Windows.Forms.Label();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ImprimirC = new System.Windows.Forms.Button();
            this.btn_VentaACredito = new System.Windows.Forms.Button();
            this.btn_PagarDeuda = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Total);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(767, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(110, 113);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(217, 73);
            this.label_Total.TabIndex = 5;
            this.label_Total.Text = "$ 0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 73);
            this.label3.TabIndex = 4;
            this.label3.Text = "TOTAL";
            // 
            // lv_Detalle
            // 
            this.lv_Detalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_Detalle.FullRowSelect = true;
            this.lv_Detalle.GridLines = true;
            this.lv_Detalle.Location = new System.Drawing.Point(31, 244);
            this.lv_Detalle.MultiSelect = false;
            this.lv_Detalle.Name = "lv_Detalle";
            this.lv_Detalle.Size = new System.Drawing.Size(722, 377);
            this.lv_Detalle.TabIndex = 1;
            this.lv_Detalle.UseCompatibleStateImageBehavior = false;
            this.lv_Detalle.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo ";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripcion";
            this.columnHeader2.Width = 294;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cantidad";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio Unitario";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio Total";
            this.columnHeader4.Width = 137;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Label_Cliente);
            this.groupBox2.Controls.Add(this.btn_CerrarSesion);
            this.groupBox2.Controls.Add(this.btn_Retiros);
            this.groupBox2.Controls.Add(this.btn_Ventas);
            this.groupBox2.Controls.Add(this.btn_Cliente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Cantidad);
            this.groupBox2.Controls.Add(this.txt_Codigo);
            this.groupBox2.Location = new System.Drawing.Point(30, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Label_Cliente
            // 
            this.Label_Cliente.AutoSize = true;
            this.Label_Cliente.Location = new System.Drawing.Point(46, 30);
            this.Label_Cliente.Name = "Label_Cliente";
            this.Label_Cliente.Size = new System.Drawing.Size(0, 13);
            this.Label_Cliente.TabIndex = 8;
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Location = new System.Drawing.Point(513, 127);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(125, 59);
            this.btn_CerrarSesion.TabIndex = 7;
            this.btn_CerrarSesion.Text = "Cerrar Sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.EventClick);
            // 
            // btn_Retiros
            // 
            this.btn_Retiros.Location = new System.Drawing.Point(354, 127);
            this.btn_Retiros.Name = "btn_Retiros";
            this.btn_Retiros.Size = new System.Drawing.Size(125, 59);
            this.btn_Retiros.TabIndex = 6;
            this.btn_Retiros.Text = "Retiros";
            this.btn_Retiros.UseVisualStyleBackColor = true;
            this.btn_Retiros.Click += new System.EventHandler(this.EventClick);
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.Enabled = false;
            this.btn_Ventas.Location = new System.Drawing.Point(194, 127);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Size = new System.Drawing.Size(125, 59);
            this.btn_Ventas.TabIndex = 5;
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.UseVisualStyleBackColor = true;
            this.btn_Ventas.Click += new System.EventHandler(this.EventClick);
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.Location = new System.Drawing.Point(37, 127);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(125, 59);
            this.btn_Cliente.TabIndex = 4;
            this.btn_Cliente.Text = "Cliente";
            this.btn_Cliente.UseVisualStyleBackColor = true;
            this.btn_Cliente.Click += new System.EventHandler(this.EventClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(528, 65);
            this.txt_Cantidad.MaxLength = 3;
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(54, 20);
            this.txt_Cantidad.TabIndex = 1;
            this.txt_Cantidad.Text = "1";
            this.txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            this.txt_Cantidad.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(136, 65);
            this.txt_Codigo.MaxLength = 30;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(314, 20);
            this.txt_Codigo.TabIndex = 0;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // txt_Nota
            // 
            this.txt_Nota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nota.Location = new System.Drawing.Point(856, 285);
            this.txt_Nota.MaxLength = 254;
            this.txt_Nota.Multiline = true;
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(352, 206);
            this.txt_Nota.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1004, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "NOTA";
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(752, 244);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(17, 377);
            this.btn_Borrar.TabIndex = 5;
            this.btn_Borrar.Text = "BORRAR";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.EventClick);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(847, 584);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(121, 48);
            this.btn_Imprimir.TabIndex = 6;
            this.btn_Imprimir.Text = "Imprimir T";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.EventClick);
            // 
            // btn_ImprimirB
            // 
            this.btn_ImprimirB.Location = new System.Drawing.Point(974, 584);
            this.btn_ImprimirB.Name = "btn_ImprimirB";
            this.btn_ImprimirB.Size = new System.Drawing.Size(121, 48);
            this.btn_ImprimirB.TabIndex = 7;
            this.btn_ImprimirB.Text = "Imprimir T-F";
            this.btn_ImprimirB.UseVisualStyleBackColor = true;
            this.btn_ImprimirB.Click += new System.EventHandler(this.EventClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nº Ticket :";
            // 
            // lb_Ticket
            // 
            this.lb_Ticket.AutoSize = true;
            this.lb_Ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ticket.Location = new System.Drawing.Point(93, 228);
            this.lb_Ticket.Name = "lb_Ticket";
            this.lb_Ticket.Size = new System.Drawing.Size(0, 15);
            this.lb_Ticket.TabIndex = 9;
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.Location = new System.Drawing.Point(1008, 226);
            this.txt_Descuento.MaxLength = 2;
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Descuento.Size = new System.Drawing.Size(71, 20);
            this.txt_Descuento.TabIndex = 10;
            this.txt_Descuento.Text = "0";
            this.txt_Descuento.Visible = false;
            this.txt_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(887, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descuento:    %";
            this.label6.Visible = false;
            // 
            // btn_ImprimirC
            // 
            this.btn_ImprimirC.Location = new System.Drawing.Point(1101, 584);
            this.btn_ImprimirC.Name = "btn_ImprimirC";
            this.btn_ImprimirC.Size = new System.Drawing.Size(121, 48);
            this.btn_ImprimirC.TabIndex = 12;
            this.btn_ImprimirC.Text = "Imprimir T-F Credito";
            this.btn_ImprimirC.UseVisualStyleBackColor = true;
            this.btn_ImprimirC.Click += new System.EventHandler(this.EventClick);
            // 
            // btn_VentaACredito
            // 
            this.btn_VentaACredito.Location = new System.Drawing.Point(847, 520);
            this.btn_VentaACredito.Name = "btn_VentaACredito";
            this.btn_VentaACredito.Size = new System.Drawing.Size(121, 48);
            this.btn_VentaACredito.TabIndex = 13;
            this.btn_VentaACredito.Text = "Venta a credito";
            this.btn_VentaACredito.UseVisualStyleBackColor = true;
            this.btn_VentaACredito.Visible = false;
            this.btn_VentaACredito.Click += new System.EventHandler(this.EventClick);
            // 
            // btn_PagarDeuda
            // 
            this.btn_PagarDeuda.Location = new System.Drawing.Point(974, 520);
            this.btn_PagarDeuda.Name = "btn_PagarDeuda";
            this.btn_PagarDeuda.Size = new System.Drawing.Size(121, 48);
            this.btn_PagarDeuda.TabIndex = 14;
            this.btn_PagarDeuda.Text = "Pagar deuda";
            this.btn_PagarDeuda.UseVisualStyleBackColor = true;
            this.btn_PagarDeuda.Visible = false;
            this.btn_PagarDeuda.Click += new System.EventHandler(this.EventClick);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(1101, 520);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(121, 48);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Visible = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.EventClick);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(15, 243);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(17, 378);
            this.btn_Limpiar.TabIndex = 16;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.EventClick);
            // 
            // frm_Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1286, 644);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_PagarDeuda);
            this.Controls.Add(this.btn_VentaACredito);
            this.Controls.Add(this.btn_ImprimirC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Descuento);
            this.Controls.Add(this.lb_Ticket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ImprimirB);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Nota);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lv_Detalle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_Terminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Terminal_FormClosing);
            this.Load += new System.EventHandler(this.frm_Terminal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lv_Detalle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Nota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Button btn_Retiros;
        private System.Windows.Forms.Button btn_Ventas;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_ImprimirB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Ticket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ImprimirC;
        private System.Windows.Forms.Label Label_Cliente;
        private System.Windows.Forms.Button btn_VentaACredito;
        private System.Windows.Forms.Button btn_PagarDeuda;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Limpiar;
        public System.Windows.Forms.TextBox txt_Descuento;
    }
}

