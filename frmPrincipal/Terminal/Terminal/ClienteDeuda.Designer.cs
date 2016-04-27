namespace Terminal
{
    partial class ClienteDeuda
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_DetalleDeuda = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lb_TotalDeuda = new System.Windows.Forms.Label();
            this.btn_Abonar = new System.Windows.Forms.Button();
            this.txt_Abonar = new System.Windows.Forms.TextBox();
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Pagos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Cliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credito Cliente";
            // 
            // lv_DetalleDeuda
            // 
            this.lv_DetalleDeuda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_DetalleDeuda.FullRowSelect = true;
            this.lv_DetalleDeuda.GridLines = true;
            this.lv_DetalleDeuda.Location = new System.Drawing.Point(12, 64);
            this.lv_DetalleDeuda.MultiSelect = false;
            this.lv_DetalleDeuda.Name = "lv_DetalleDeuda";
            this.lv_DetalleDeuda.Size = new System.Drawing.Size(596, 162);
            this.lv_DetalleDeuda.TabIndex = 2;
            this.lv_DetalleDeuda.UseCompatibleStateImageBehavior = false;
            this.lv_DetalleDeuda.View = System.Windows.Forms.View.Details;
            this.lv_DetalleDeuda.DoubleClick += new System.EventHandler(this.lv_DetalleDeuda_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nº Ticket";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descripcion";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 181;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TOTAL ADEUDADO:";
            // 
            // lb_TotalDeuda
            // 
            this.lb_TotalDeuda.AutoSize = true;
            this.lb_TotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalDeuda.Location = new System.Drawing.Point(526, 241);
            this.lb_TotalDeuda.Name = "lb_TotalDeuda";
            this.lb_TotalDeuda.Size = new System.Drawing.Size(43, 13);
            this.lb_TotalDeuda.TabIndex = 4;
            this.lb_TotalDeuda.Text = "$ 0,00";
            // 
            // btn_Abonar
            // 
            this.btn_Abonar.Location = new System.Drawing.Point(529, 274);
            this.btn_Abonar.Name = "btn_Abonar";
            this.btn_Abonar.Size = new System.Drawing.Size(88, 28);
            this.btn_Abonar.TabIndex = 5;
            this.btn_Abonar.Text = "Abonar";
            this.btn_Abonar.UseVisualStyleBackColor = true;
            this.btn_Abonar.Click += new System.EventHandler(this.btn_Abonar_Click);
            // 
            // txt_Abonar
            // 
            this.txt_Abonar.Location = new System.Drawing.Point(423, 279);
            this.txt_Abonar.MaxLength = 10;
            this.txt_Abonar.Name = "txt_Abonar";
            this.txt_Abonar.Size = new System.Drawing.Size(100, 20);
            this.txt_Abonar.TabIndex = 6;
            this.txt_Abonar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Abonar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Abonar_KeyPress);
            // 
            // txt_Nota
            // 
            this.txt_Nota.Location = new System.Drawing.Point(12, 252);
            this.txt_Nota.MaxLength = 254;
            this.txt_Nota.Multiline = true;
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(195, 61);
            this.txt_Nota.TabIndex = 7;
            this.txt_Nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "NOTA";
            // 
            // cb_Pagos
            // 
            this.cb_Pagos.FormattingEnabled = true;
            this.cb_Pagos.Items.AddRange(new object[] {
            "Efectivo",
            "Cheque",
            "Otro"});
            this.cb_Pagos.Location = new System.Drawing.Point(244, 268);
            this.cb_Pagos.Name = "cb_Pagos";
            this.cb_Pagos.Size = new System.Drawing.Size(116, 21);
            this.cb_Pagos.TabIndex = 10;
            this.cb_Pagos.Text = "Efectivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Metodo de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cliente : ";
            // 
            // lb_Cliente
            // 
            this.lb_Cliente.AutoSize = true;
            this.lb_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cliente.Location = new System.Drawing.Point(82, 8);
            this.lb_Cliente.Name = "lb_Cliente";
            this.lb_Cliente.Size = new System.Drawing.Size(0, 13);
            this.lb_Cliente.TabIndex = 13;
            // 
            // ClienteDeuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 325);
            this.Controls.Add(this.lb_Cliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Pagos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nota);
            this.Controls.Add(this.txt_Abonar);
            this.Controls.Add(this.btn_Abonar);
            this.Controls.Add(this.lb_TotalDeuda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lv_DetalleDeuda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ClienteDeuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteDeuda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClienteDeuda_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_DetalleDeuda;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_TotalDeuda;
        private System.Windows.Forms.Button btn_Abonar;
        private System.Windows.Forms.TextBox txt_Abonar;
        private System.Windows.Forms.TextBox txt_Nota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Pagos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Cliente;
    }
}