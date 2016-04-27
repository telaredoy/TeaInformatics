namespace Terminal
{
    partial class Control
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
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btn_ControlCaja = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Location = new System.Drawing.Point(22, 41);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(123, 46);
            this.btn_CerrarSesion.TabIndex = 0;
            this.btn_CerrarSesion.Text = "Cerrar Sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_ControlCaja
            // 
            this.btn_ControlCaja.Location = new System.Drawing.Point(165, 41);
            this.btn_ControlCaja.Name = "btn_ControlCaja";
            this.btn_ControlCaja.Size = new System.Drawing.Size(123, 46);
            this.btn_ControlCaja.TabIndex = 1;
            this.btn_ControlCaja.Text = "Controlar Caja";
            this.btn_ControlCaja.UseVisualStyleBackColor = true;
            this.btn_ControlCaja.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(312, 41);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(123, 46);
            this.btn_Cerrar.TabIndex = 2;
            this.btn_Cerrar.Text = "Cerrar Punto de venta";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(439, -3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(32, 29);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.ClickEvent);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 105);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_ControlCaja);
            this.Controls.Add(this.btn_CerrarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Button btn_ControlCaja;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Close;
    }
}