namespace frmPrincipal
{
    partial class RegistroDeVentas
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
            this.lv_Ventas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_Terminal = new System.Windows.Forms.ComboBox();
            this.btn_Terminal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_NTicket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTROS DE VENTAS";
            // 
            // lv_Ventas
            // 
            this.lv_Ventas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6});
            this.lv_Ventas.FullRowSelect = true;
            this.lv_Ventas.GridLines = true;
            this.lv_Ventas.Location = new System.Drawing.Point(12, 72);
            this.lv_Ventas.MultiSelect = false;
            this.lv_Ventas.Name = "lv_Ventas";
            this.lv_Ventas.Size = new System.Drawing.Size(1046, 252);
            this.lv_Ventas.TabIndex = 1;
            this.lv_Ventas.UseCompatibleStateImageBehavior = false;
            this.lv_Ventas.View = System.Windows.Forms.View.Details;
            this.lv_Ventas.DoubleClick += new System.EventHandler(this.lv_Ventas_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nº Ticket";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cliente";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 213;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Terminal";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 79;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nota";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 237;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Descuento";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 67;
            // 
            // cb_Terminal
            // 
            this.cb_Terminal.FormattingEnabled = true;
            this.cb_Terminal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_Terminal.Location = new System.Drawing.Point(561, 45);
            this.cb_Terminal.Name = "cb_Terminal";
            this.cb_Terminal.Size = new System.Drawing.Size(80, 21);
            this.cb_Terminal.TabIndex = 2;
            this.cb_Terminal.Text = "Seleccionar";
            // 
            // btn_Terminal
            // 
            this.btn_Terminal.Location = new System.Drawing.Point(647, 45);
            this.btn_Terminal.Name = "btn_Terminal";
            this.btn_Terminal.Size = new System.Drawing.Size(27, 21);
            this.btn_Terminal.TabIndex = 3;
            this.btn_Terminal.Text = "->";
            this.btn_Terminal.UseVisualStyleBackColor = true;
            this.btn_Terminal.Click += new System.EventHandler(this.btn_Terminal_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 21);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_NTicket
            // 
            this.txt_NTicket.Location = new System.Drawing.Point(233, 45);
            this.txt_NTicket.MaxLength = 20;
            this.txt_NTicket.Name = "txt_NTicket";
            this.txt_NTicket.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_NTicket.Size = new System.Drawing.Size(71, 20);
            this.txt_NTicket.TabIndex = 5;
            this.txt_NTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NTicket_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nº Ticket:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1034, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nº Terminal:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(367, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 21);
            this.button3.TabIndex = 9;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RegistroDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 340);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NTicket);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Terminal);
            this.Controls.Add(this.cb_Terminal);
            this.Controls.Add(this.lv_Ventas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroDeVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroDeVentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_Ventas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cb_Terminal;
        private System.Windows.Forms.Button btn_Terminal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_NTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}