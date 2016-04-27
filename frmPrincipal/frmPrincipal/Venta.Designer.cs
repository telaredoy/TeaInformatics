namespace frmPrincipal
{
    partial class Venta
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Ticket = new System.Windows.Forms.Label();
            this.lv_Detalle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Cliente = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Descontar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Descuento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Ticket :";
            // 
            // lb_Ticket
            // 
            this.lb_Ticket.AutoSize = true;
            this.lb_Ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ticket.Location = new System.Drawing.Point(293, 33);
            this.lb_Ticket.Name = "lb_Ticket";
            this.lb_Ticket.Size = new System.Drawing.Size(0, 16);
            this.lb_Ticket.TabIndex = 1;
            // 
            // lv_Detalle
            // 
            this.lv_Detalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_Detalle.FullRowSelect = true;
            this.lv_Detalle.GridLines = true;
            this.lv_Detalle.Location = new System.Drawing.Point(35, 81);
            this.lv_Detalle.MultiSelect = false;
            this.lv_Detalle.Name = "lv_Detalle";
            this.lv_Detalle.Size = new System.Drawing.Size(597, 231);
            this.lv_Detalle.TabIndex = 2;
            this.lv_Detalle.UseCompatibleStateImageBehavior = false;
            this.lv_Detalle.View = System.Windows.Forms.View.Details;
            this.lv_Detalle.Click += new System.EventHandler(this.ClickEvent);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripcion";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 246;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio Unitario";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Precio Total";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente:";
            // 
            // lb_Cliente
            // 
            this.lb_Cliente.AutoSize = true;
            this.lb_Cliente.Location = new System.Drawing.Point(80, 65);
            this.lb_Cliente.Name = "lb_Cliente";
            this.lb_Cliente.Size = new System.Drawing.Size(0, 13);
            this.lb_Cliente.TabIndex = 4;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(414, 337);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(170, 23);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Borrar Ticket";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(238, 337);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(170, 23);
            this.btn_Borrar.TabIndex = 6;
            this.btn_Borrar.Text = "Borrar item";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Descontar
            // 
            this.btn_Descontar.Location = new System.Drawing.Point(54, 337);
            this.btn_Descontar.Name = "btn_Descontar";
            this.btn_Descontar.Size = new System.Drawing.Size(178, 23);
            this.btn_Descontar.TabIndex = 7;
            this.btn_Descontar.Text = "Devolver Cantidad";
            this.btn_Descontar.UseVisualStyleBackColor = true;
            this.btn_Descontar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(139, 368);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(93, 23);
            this.btn_Guardar.TabIndex = 8;
            this.btn_Guardar.Text = "Guardar Cambios";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(238, 368);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(170, 23);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.ClickEvent);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(94, 368);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Cantidad.Size = new System.Drawing.Size(39, 20);
            this.txt_Cantidad.TabIndex = 11;
            this.txt_Cantidad.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha:";
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Location = new System.Drawing.Point(457, 65);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(0, 13);
            this.lb_Fecha.TabIndex = 14;
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(557, 315);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(0, 13);
            this.lb_Total.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total:";
            // 
            // lb_Descuento
            // 
            this.lb_Descuento.AutoSize = true;
            this.lb_Descuento.Location = new System.Drawing.Point(339, 315);
            this.lb_Descuento.Name = "lb_Descuento";
            this.lb_Descuento.Size = new System.Drawing.Size(0, 13);
            this.lb_Descuento.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Descuento:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 392);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb_Descuento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Descontar);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.lb_Cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lv_Detalle);
            this.Controls.Add(this.lb_Ticket);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Ticket;
        private System.Windows.Forms.ListView lv_Detalle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Cliente;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Descontar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_Descuento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}