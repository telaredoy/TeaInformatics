namespace Terminal
{
    partial class Retiro
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
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Empleado = new System.Windows.Forms.Label();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto:";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Enabled = false;
            this.txt_Monto.Location = new System.Drawing.Point(130, 47);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(100, 20);
            this.txt_Monto.TabIndex = 1;
            // 
            // txt_Nota
            // 
            this.txt_Nota.Enabled = false;
            this.txt_Nota.Location = new System.Drawing.Point(48, 91);
            this.txt_Nota.Multiline = true;
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(239, 119);
            this.txt_Nota.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleado:";
            // 
            // lb_Empleado
            // 
            this.lb_Empleado.AutoSize = true;
            this.lb_Empleado.Location = new System.Drawing.Point(93, 230);
            this.lb_Empleado.Name = "lb_Empleado";
            this.lb_Empleado.Size = new System.Drawing.Size(0, 13);
            this.lb_Empleado.TabIndex = 4;
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Location = new System.Drawing.Point(213, 230);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(34, 13);
            this.lb_Fecha.TabIndex = 5;
            this.lb_Fecha.Text = "08:30";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(310, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Retiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.lb_Empleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nota);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Retiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retiro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.TextBox txt_Nota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Empleado;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.Button button1;
    }
}