namespace frmPrincipal
{
    partial class Frm_AjustesProducto
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
            this.lv_AjusteProducto = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_CostoPorcentaje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Rubro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Proveedor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_AjusteProducto
            // 
            this.lv_AjusteProducto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_AjusteProducto.FullRowSelect = true;
            this.lv_AjusteProducto.GridLines = true;
            this.lv_AjusteProducto.Location = new System.Drawing.Point(16, 98);
            this.lv_AjusteProducto.Name = "lv_AjusteProducto";
            this.lv_AjusteProducto.Size = new System.Drawing.Size(953, 275);
            this.lv_AjusteProducto.TabIndex = 0;
            this.lv_AjusteProducto.UseCompatibleStateImageBehavior = false;
            this.lv_AjusteProducto.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripción";
            this.columnHeader2.Width = 435;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio Costo";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio Venta";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Proveedor";
            this.columnHeader5.Width = 215;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Rubro";
            this.columnHeader6.Width = 172;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Salir);
            this.groupBox1.Controls.Add(this.btn_Aceptar);
            this.groupBox1.Controls.Add(this.txt_CostoPorcentaje);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Rubro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Proveedor);
            this.groupBox1.Controls.Add(this.lv_AjusteProducto);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajustar precios";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(486, 388);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(177, 50);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(317, 388);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(163, 50);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // txt_CostoPorcentaje
            // 
            this.txt_CostoPorcentaje.Location = new System.Drawing.Point(178, 404);
            this.txt_CostoPorcentaje.MaxLength = 4;
            this.txt_CostoPorcentaje.Name = "txt_CostoPorcentaje";
            this.txt_CostoPorcentaje.Size = new System.Drawing.Size(109, 20);
            this.txt_CostoPorcentaje.TabIndex = 6;
            this.txt_CostoPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CostoPorcentaje_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modificar porcentaje costo:";
            // 
            // txt_Rubro
            // 
            this.txt_Rubro.Location = new System.Drawing.Point(400, 44);
            this.txt_Rubro.Name = "txt_Rubro";
            this.txt_Rubro.Size = new System.Drawing.Size(153, 20);
            this.txt_Rubro.TabIndex = 4;
            this.txt_Rubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Rubro.TextChanged += new System.EventHandler(this.TxtChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtrar por rubro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por proveedor:";
            // 
            // txt_Proveedor
            // 
            this.txt_Proveedor.Location = new System.Drawing.Point(125, 44);
            this.txt_Proveedor.Name = "txt_Proveedor";
            this.txt_Proveedor.Size = new System.Drawing.Size(153, 20);
            this.txt_Proveedor.TabIndex = 1;
            this.txt_Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Proveedor.TextChanged += new System.EventHandler(this.TxtChange);
            // 
            // Frm_AjustesProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 466);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_AjustesProducto";
            this.Text = "Ajustes Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_AjusteProducto;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox txt_CostoPorcentaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Rubro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Proveedor;
    }
}