namespace deposito
{
    partial class Imprimir
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
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rubro = new System.Windows.Forms.RadioButton();
            this.codigo = new System.Windows.Forms.RadioButton();
            this.cb_Rubros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Copias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(0, 76);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(355, 38);
            this.btn_Imprimir.TabIndex = 0;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rubro);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.cb_Rubros);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Copias);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Codigo);
            this.groupBox1.Controls.Add(this.btn_Imprimir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imprimir";
            // 
            // rubro
            // 
            this.rubro.AutoSize = true;
            this.rubro.Location = new System.Drawing.Point(6, 25);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(73, 17);
            this.rubro.TabIndex = 9;
            this.rubro.TabStop = true;
            this.rubro.Text = "Por Rubro";
            this.rubro.UseVisualStyleBackColor = true;
            this.rubro.CheckedChanged += new System.EventHandler(this.rubro_CheckedChanged);
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(6, 51);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(77, 17);
            this.codigo.TabIndex = 8;
            this.codigo.TabStop = true;
            this.codigo.Text = "Por Codigo";
            this.codigo.UseVisualStyleBackColor = true;
            this.codigo.CheckedChanged += new System.EventHandler(this.codigo_CheckedChanged);
            // 
            // cb_Rubros
            // 
            this.cb_Rubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Rubros.Enabled = false;
            this.cb_Rubros.FormattingEnabled = true;
            this.cb_Rubros.Location = new System.Drawing.Point(162, 24);
            this.cb_Rubros.Name = "cb_Rubros";
            this.cb_Rubros.Size = new System.Drawing.Size(172, 21);
            this.cb_Rubros.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Copias";
            // 
            // txt_Copias
            // 
            this.txt_Copias.Enabled = false;
            this.txt_Copias.Location = new System.Drawing.Point(299, 50);
            this.txt_Copias.Name = "txt_Copias";
            this.txt_Copias.Size = new System.Drawing.Size(35, 20);
            this.txt_Copias.TabIndex = 3;
            this.txt_Copias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Location = new System.Drawing.Point(162, 50);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(85, 20);
            this.txt_Codigo.TabIndex = 1;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 144);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Imprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rubro;
        private System.Windows.Forms.RadioButton codigo;
        private System.Windows.Forms.ComboBox cb_Rubros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Copias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}