namespace deposito
{
    partial class frm_deposito
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
            this.btn_ABProductos = new System.Windows.Forms.Button();
            this.btn_CargarStock = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Devolucion = new System.Windows.Forms.Button();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_CerraTerminal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Actualizado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ABProductos
            // 
            this.btn_ABProductos.Location = new System.Drawing.Point(12, 63);
            this.btn_ABProductos.Name = "btn_ABProductos";
            this.btn_ABProductos.Size = new System.Drawing.Size(276, 51);
            this.btn_ABProductos.TabIndex = 0;
            this.btn_ABProductos.Text = "A B PRODUCTOS";
            this.btn_ABProductos.UseVisualStyleBackColor = true;
            this.btn_ABProductos.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_CargarStock
            // 
            this.btn_CargarStock.Location = new System.Drawing.Point(12, 120);
            this.btn_CargarStock.Name = "btn_CargarStock";
            this.btn_CargarStock.Size = new System.Drawing.Size(276, 51);
            this.btn_CargarStock.TabIndex = 1;
            this.btn_CargarStock.Text = "CARGAR STOCK";
            this.btn_CargarStock.UseVisualStyleBackColor = true;
            this.btn_CargarStock.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(12, 177);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(276, 51);
            this.btn_Imprimir.TabIndex = 2;
            this.btn_Imprimir.Text = "IMPRIMIR";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Devolucion
            // 
            this.btn_Devolucion.Location = new System.Drawing.Point(12, 234);
            this.btn_Devolucion.Name = "btn_Devolucion";
            this.btn_Devolucion.Size = new System.Drawing.Size(276, 51);
            this.btn_Devolucion.TabIndex = 3;
            this.btn_Devolucion.Text = "DEVOLVER A PROVEEDOR";
            this.btn_Devolucion.UseVisualStyleBackColor = true;
            this.btn_Devolucion.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Location = new System.Drawing.Point(12, 291);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(276, 51);
            this.btn_CerrarSesion.TabIndex = 4;
            this.btn_CerrarSesion.Text = "CERRAR SESIÓN";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(12, 6);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(276, 51);
            this.btn_Actualizar.TabIndex = 5;
            this.btn_Actualizar.Text = "ACTUALIZAR DATOS";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_CerraTerminal
            // 
            this.btn_CerraTerminal.Location = new System.Drawing.Point(12, 348);
            this.btn_CerraTerminal.Name = "btn_CerraTerminal";
            this.btn_CerraTerminal.Size = new System.Drawing.Size(276, 51);
            this.btn_CerraTerminal.TabIndex = 6;
            this.btn_CerraTerminal.Text = "CERRAR TERMINAL";
            this.btn_CerraTerminal.UseVisualStyleBackColor = true;
            this.btn_CerraTerminal.Click += new System.EventHandler(this.ClickEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Datos actualizados :";
            // 
            // lb_Actualizado
            // 
            this.lb_Actualizado.AutoSize = true;
            this.lb_Actualizado.Location = new System.Drawing.Point(155, 402);
            this.lb_Actualizado.Name = "lb_Actualizado";
            this.lb_Actualizado.Size = new System.Drawing.Size(0, 13);
            this.lb_Actualizado.TabIndex = 8;
            // 
            // frm_deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 422);
            this.ControlBox = false;
            this.Controls.Add(this.lb_Actualizado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CerraTerminal);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Controls.Add(this.btn_Devolucion);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.btn_CargarStock);
            this.Controls.Add(this.btn_ABProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_deposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depósito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_deposito_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ABProductos;
        private System.Windows.Forms.Button btn_CargarStock;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_Devolucion;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_CerraTerminal;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_Actualizado;
    }
}