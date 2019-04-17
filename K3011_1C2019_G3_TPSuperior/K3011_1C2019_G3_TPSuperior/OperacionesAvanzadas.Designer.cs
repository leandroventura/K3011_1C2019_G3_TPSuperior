namespace K3011_1C2019_G3_TPSuperior
{
    partial class OperacionesAvanzadas
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
            this.labelResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOperar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComplejo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOperaciones = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.labelResultado.Location = new System.Drawing.Point(264, 174);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(170, 22);
            this.labelResultado.TabIndex = 16;
            this.labelResultado.Text = "Acá iría el resultado...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Resultado:";
            // 
            // buttonOperar
            // 
            this.buttonOperar.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.buttonOperar.Location = new System.Drawing.Point(256, 119);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(135, 32);
            this.buttonOperar.TabIndex = 14;
            this.buttonOperar.Text = "OPERAR";
            this.buttonOperar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingrese un Número Complejo:";
            // 
            // textBoxComplejo
            // 
            this.textBoxComplejo.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.textBoxComplejo.Location = new System.Drawing.Point(496, 60);
            this.textBoxComplejo.Name = "textBoxComplejo";
            this.textBoxComplejo.Size = new System.Drawing.Size(165, 26);
            this.textBoxComplejo.TabIndex = 12;
            this.textBoxComplejo.Text = "(a;b) o [a;b]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleccione una operación:";
            // 
            // comboBoxOperaciones
            // 
            this.comboBoxOperaciones.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperaciones.FormattingEnabled = true;
            this.comboBoxOperaciones.Location = new System.Drawing.Point(53, 69);
            this.comboBoxOperaciones.Name = "comboBoxOperaciones";
            this.comboBoxOperaciones.Size = new System.Drawing.Size(157, 28);
            this.comboBoxOperaciones.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // OperacionesAvanzadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 213);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOperar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxComplejo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOperaciones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OperacionesAvanzadas";
            this.Text = "Operaciones Avanzadas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxComplejo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOperaciones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}