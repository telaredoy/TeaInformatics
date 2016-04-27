namespace Terminal
{
    partial class frm_Cliente
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
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Filtro = new System.Windows.Forms.MaskedTextBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_NuevoCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Location = new System.Drawing.Point(267, 11);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(108, 34);
            this.btn_Cargar.TabIndex = 1;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CUIT-CUIL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Filtro);
            this.groupBox1.Controls.Add(this.btn_Cerrar);
            this.groupBox1.Controls.Add(this.btn_NuevoCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Cargar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(124, 19);
            this.txt_Filtro.Mask = "99-99999999-9";
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(114, 20);
            this.txt_Filtro.TabIndex = 0;
            this.txt_Filtro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Filtro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(503, 11);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(108, 34);
            this.btn_Cerrar.TabIndex = 3;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_NuevoCliente
            // 
            this.btn_NuevoCliente.Location = new System.Drawing.Point(387, 11);
            this.btn_NuevoCliente.Name = "btn_NuevoCliente";
            this.btn_NuevoCliente.Size = new System.Drawing.Size(108, 34);
            this.btn_NuevoCliente.TabIndex = 2;
            this.btn_NuevoCliente.Text = "Nuevo Cliente";
            this.btn_NuevoCliente.UseVisualStyleBackColor = true;
            this.btn_NuevoCliente.Click += new System.EventHandler(this.ClickEvent);
            // 
            // frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 91);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Cliente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_NuevoCliente;
        private System.Windows.Forms.MaskedTextBox txt_Filtro;
    }
}