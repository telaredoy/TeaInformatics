namespace Terminal
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
            this.lv_Detalle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_Ticket = new System.Windows.Forms.Label();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.btn_Cantidad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_EliminarTicket = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lv_Detalle.Location = new System.Drawing.Point(21, 80);
            this.lv_Detalle.MultiSelect = false;
            this.lv_Detalle.Name = "lv_Detalle";
            this.lv_Detalle.Size = new System.Drawing.Size(734, 250);
            this.lv_Detalle.TabIndex = 2;
            this.lv_Detalle.UseCompatibleStateImageBehavior = false;
            this.lv_Detalle.View = System.Windows.Forms.View.Details;
            this.lv_Detalle.Click += new System.EventHandler(this.ClickEvent);
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
            this.columnHeader4.Width = 143;
            // 
            // lb_Ticket
            // 
            this.lb_Ticket.AutoSize = true;
            this.lb_Ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ticket.Location = new System.Drawing.Point(305, 34);
            this.lb_Ticket.Name = "lb_Ticket";
            this.lb_Ticket.Size = new System.Drawing.Size(123, 24);
            this.lb_Ticket.TabIndex = 3;
            this.lb_Ticket.Text = "TICKET Nº :";
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(356, 336);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(113, 30);
            this.btn_Borrar.TabIndex = 4;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(231, 336);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(119, 30);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Text = "Guardar Cambios";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(475, 336);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(131, 30);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.Location = new System.Drawing.Point(655, 34);
            this.txt_Descuento.MaxLength = 2;
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Descuento.Size = new System.Drawing.Size(100, 20);
            this.txt_Descuento.TabIndex = 7;
            this.txt_Descuento.Text = "0";
            this.txt_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descuento otorgado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "TICKET Nº :";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(59, 342);
            this.txt_Cantidad.MaxLength = 3;
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Cantidad.Size = new System.Drawing.Size(31, 20);
            this.txt_Cantidad.TabIndex = 10;
            this.txt_Cantidad.Text = "0";
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // btn_Cantidad
            // 
            this.btn_Cantidad.Location = new System.Drawing.Point(96, 336);
            this.btn_Cantidad.Name = "btn_Cantidad";
            this.btn_Cantidad.Size = new System.Drawing.Size(129, 30);
            this.btn_Cantidad.TabIndex = 11;
            this.btn_Cantidad.Text = "Cantidad a devolver";
            this.btn_Cantidad.UseVisualStyleBackColor = true;
            this.btn_Cantidad.Click += new System.EventHandler(this.ClickEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cant:";
            // 
            // btn_EliminarTicket
            // 
            this.btn_EliminarTicket.Location = new System.Drawing.Point(612, 336);
            this.btn_EliminarTicket.Name = "btn_EliminarTicket";
            this.btn_EliminarTicket.Size = new System.Drawing.Size(143, 30);
            this.btn_EliminarTicket.TabIndex = 13;
            this.btn_EliminarTicket.Text = "Eliminar Ticket";
            this.btn_EliminarTicket.UseVisualStyleBackColor = true;
            this.btn_EliminarTicket.Click += new System.EventHandler(this.ClickEvent);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_EliminarTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Cantidad);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Descuento);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.lb_Ticket);
            this.Controls.Add(this.lv_Detalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Detalle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lb_Ticket;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Button btn_Cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_EliminarTicket;
        private System.Windows.Forms.Button button1;
    }
}