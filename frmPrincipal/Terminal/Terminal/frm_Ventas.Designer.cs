namespace Terminal
{
    partial class frm_Ventas
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
            this.lv_Ventas = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NueroTicket = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Ventas
            // 
            this.lv_Ventas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader1});
            this.lv_Ventas.FullRowSelect = true;
            this.lv_Ventas.GridLines = true;
            this.lv_Ventas.Location = new System.Drawing.Point(26, 80);
            this.lv_Ventas.Name = "lv_Ventas";
            this.lv_Ventas.Size = new System.Drawing.Size(688, 165);
            this.lv_Ventas.TabIndex = 0;
            this.lv_Ventas.UseCompatibleStateImageBehavior = false;
            this.lv_Ventas.View = System.Windows.Forms.View.Details;
            this.lv_Ventas.DoubleClick += new System.EventHandler(this.DobleClickEvent);
            this.lv_Ventas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NueroTicket_KeyPress);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hora";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "NºTicket / Nº Retiro";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Empleado";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 155;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Monto";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 131;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Retiro/Ticket";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Ticket";
            // 
            // txt_NueroTicket
            // 
            this.txt_NueroTicket.Location = new System.Drawing.Point(251, 36);
            this.txt_NueroTicket.MaxLength = 100;
            this.txt_NueroTicket.Name = "txt_NueroTicket";
            this.txt_NueroTicket.Size = new System.Drawing.Size(226, 20);
            this.txt_NueroTicket.TabIndex = 2;
            this.txt_NueroTicket.TextChanged += new System.EventHandler(this.EventTextChange);
            this.txt_NueroTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NueroTicket_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_NueroTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_Ventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frm_Ventas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Ventas_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NueroTicket;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView lv_Ventas;
    }
}