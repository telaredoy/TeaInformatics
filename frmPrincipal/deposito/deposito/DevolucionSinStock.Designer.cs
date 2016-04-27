namespace deposito
{
    partial class DevolucionSinStock
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
            this.tb_Nota = new System.Windows.Forms.TextBox();
            this.tb_Monto = new System.Windows.Forms.TextBox();
            this.cb_Proveedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Devolver = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Nota
            // 
            this.tb_Nota.Location = new System.Drawing.Point(12, 44);
            this.tb_Nota.Multiline = true;
            this.tb_Nota.Name = "tb_Nota";
            this.tb_Nota.Size = new System.Drawing.Size(267, 164);
            this.tb_Nota.TabIndex = 0;
            // 
            // tb_Monto
            // 
            this.tb_Monto.Location = new System.Drawing.Point(179, 214);
            this.tb_Monto.Name = "tb_Monto";
            this.tb_Monto.Size = new System.Drawing.Size(100, 20);
            this.tb_Monto.TabIndex = 1;
            // 
            // cb_Proveedores
            // 
            this.cb_Proveedores.FormattingEnabled = true;
            this.cb_Proveedores.Location = new System.Drawing.Point(74, 6);
            this.cb_Proveedores.Name = "cb_Proveedores";
            this.cb_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.cb_Proveedores.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto:";
            // 
            // btn_Devolver
            // 
            this.btn_Devolver.Enabled = false;
            this.btn_Devolver.Location = new System.Drawing.Point(299, 71);
            this.btn_Devolver.Name = "btn_Devolver";
            this.btn_Devolver.Size = new System.Drawing.Size(122, 42);
            this.btn_Devolver.TabIndex = 5;
            this.btn_Devolver.Text = "Devolver";
            this.btn_Devolver.UseVisualStyleBackColor = true;
            this.btn_Devolver.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(299, 137);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(122, 42);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // DevolucionSinStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 244);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Devolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Proveedores);
            this.Controls.Add(this.tb_Monto);
            this.Controls.Add(this.tb_Nota);
            this.Name = "DevolucionSinStock";
            this.Text = "Devoluciones articulos no deseados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Nota;
        private System.Windows.Forms.TextBox tb_Monto;
        private System.Windows.Forms.ComboBox cb_Proveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Devolver;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}