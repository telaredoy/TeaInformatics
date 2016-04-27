namespace Terminal
{
    partial class frm_NuevoCliente
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
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Telefono_Responsable = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Responsable = new System.Windows.Forms.TextBox();
            this.txt_Ciudad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_Filtro = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(156, 19);
            this.txt_Nombre.MaxLength = 100;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(215, 20);
            this.txt_Nombre.TabIndex = 0;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEvent);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(156, 150);
            this.txt_Email.MaxLength = 100;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(215, 20);
            this.txt_Email.TabIndex = 4;
            this.txt_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEvent);
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(156, 85);
            this.txt_Direccion.MaxLength = 100;
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(215, 20);
            this.txt_Direccion.TabIndex = 2;
            this.txt_Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEvent);
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(156, 118);
            this.txt_Telefono.MaxLength = 100;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(215, 20);
            this.txt_Telefono.TabIndex = 3;
            this.txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Razon Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CUIT-CUIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-mail";
            // 
            // txt_Telefono_Responsable
            // 
            this.txt_Telefono_Responsable.Location = new System.Drawing.Point(156, 250);
            this.txt_Telefono_Responsable.MaxLength = 100;
            this.txt_Telefono_Responsable.Name = "txt_Telefono_Responsable";
            this.txt_Telefono_Responsable.Size = new System.Drawing.Size(215, 20);
            this.txt_Telefono_Responsable.TabIndex = 7;
            this.txt_Telefono_Responsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEvent);
            // 
            // txt_Nombre_Responsable
            // 
            this.txt_Nombre_Responsable.Location = new System.Drawing.Point(156, 217);
            this.txt_Nombre_Responsable.MaxLength = 100;
            this.txt_Nombre_Responsable.Name = "txt_Nombre_Responsable";
            this.txt_Nombre_Responsable.Size = new System.Drawing.Size(215, 20);
            this.txt_Nombre_Responsable.TabIndex = 6;
            this.txt_Nombre_Responsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEvent);
            // 
            // txt_Ciudad
            // 
            this.txt_Ciudad.Location = new System.Drawing.Point(156, 184);
            this.txt_Ciudad.MaxLength = 100;
            this.txt_Ciudad.Name = "txt_Ciudad";
            this.txt_Ciudad.Size = new System.Drawing.Size(215, 20);
            this.txt_Ciudad.TabIndex = 5;
            this.txt_Ciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEvent);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Teléfono Responsable";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nombre Responsable";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ciudad";
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Location = new System.Drawing.Point(81, 307);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(118, 27);
            this.btn_Cargar.TabIndex = 8;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(253, 307);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(118, 27);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.ClickEvent);
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(156, 51);
            this.txt_Filtro.Mask = "99-99999999-9";
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(215, 20);
            this.txt_Filtro.TabIndex = 1;
            this.txt_Filtro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 346);
            this.Controls.Add(this.txt_Filtro);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Ciudad);
            this.Controls.Add(this.txt_Nombre_Responsable);
            this.Controls.Add(this.txt_Telefono_Responsable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_NuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Telefono_Responsable;
        private System.Windows.Forms.TextBox txt_Nombre_Responsable;
        private System.Windows.Forms.TextBox txt_Ciudad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.MaskedTextBox txt_Filtro;
    }
}