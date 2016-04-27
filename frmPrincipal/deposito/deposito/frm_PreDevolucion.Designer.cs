namespace deposito
{
    partial class frm_PreDevolucion
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
            this.btn_EnStock = new System.Windows.Forms.Button();
            this.btn_SinStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_EnStock
            // 
            this.btn_EnStock.Location = new System.Drawing.Point(12, 12);
            this.btn_EnStock.Name = "btn_EnStock";
            this.btn_EnStock.Size = new System.Drawing.Size(141, 56);
            this.btn_EnStock.TabIndex = 0;
            this.btn_EnStock.Text = "Cargado en Stock";
            this.btn_EnStock.UseVisualStyleBackColor = true;
            this.btn_EnStock.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_SinStock
            // 
            this.btn_SinStock.Location = new System.Drawing.Point(12, 74);
            this.btn_SinStock.Name = "btn_SinStock";
            this.btn_SinStock.Size = new System.Drawing.Size(141, 56);
            this.btn_SinStock.TabIndex = 1;
            this.btn_SinStock.Text = "Sin cargar en el Stock";
            this.btn_SinStock.UseVisualStyleBackColor = true;
            this.btn_SinStock.Click += new System.EventHandler(this.ClickEvent);
            // 
            // frm_PreDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 135);
            this.Controls.Add(this.btn_SinStock);
            this.Controls.Add(this.btn_EnStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PreDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_EnStock;
        private System.Windows.Forms.Button btn_SinStock;
    }
}