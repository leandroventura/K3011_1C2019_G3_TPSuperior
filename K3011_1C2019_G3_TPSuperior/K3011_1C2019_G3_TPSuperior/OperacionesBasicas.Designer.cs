namespace K3011_1C2019_G3_TPSuperior
{
    partial class OperacionesBasicas
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
            this.comboBoxOperaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxComplejo1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxComplejo2 = new System.Windows.Forms.TextBox();
            this.buttonOperar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxOperaciones
            // 
            this.comboBoxOperaciones.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperaciones.FormattingEnabled = true;
            this.comboBoxOperaciones.Items.AddRange(new object[] {
            "Sumar",
            "Restar",
            "Multiplicar",
            "Dividir"});
            this.comboBoxOperaciones.Location = new System.Drawing.Point(71, 90);
            this.comboBoxOperaciones.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOperaciones.Name = "comboBoxOperaciones";
            this.comboBoxOperaciones.Size = new System.Drawing.Size(208, 32);
            this.comboBoxOperaciones.TabIndex = 0;
            this.comboBoxOperaciones.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperaciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione una operación:";
            // 
            // textBoxComplejo1
            // 
            this.textBoxComplejo1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.textBoxComplejo1.Location = new System.Drawing.Point(659, 71);
            this.textBoxComplejo1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComplejo1.Name = "textBoxComplejo1";
            this.textBoxComplejo1.Size = new System.Drawing.Size(219, 31);
            this.textBoxComplejo1.TabIndex = 2;
            this.textBoxComplejo1.TextChanged += new System.EventHandler(this.textBoxComplejo1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese un Número Complejo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.label3.Location = new System.Drawing.Point(320, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese otro Número Complejo:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(888, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.salirToolStripMenuItem.Text = "Cerrar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // textBoxComplejo2
            // 
            this.textBoxComplejo2.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.textBoxComplejo2.Location = new System.Drawing.Point(659, 124);
            this.textBoxComplejo2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComplejo2.Name = "textBoxComplejo2";
            this.textBoxComplejo2.Size = new System.Drawing.Size(219, 31);
            this.textBoxComplejo2.TabIndex = 6;
            // 
            // buttonOperar
            // 
            this.buttonOperar.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.buttonOperar.Location = new System.Drawing.Point(343, 187);
            this.buttonOperar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(180, 39);
            this.buttonOperar.TabIndex = 7;
            this.buttonOperar.Text = "OPERAR";
            this.buttonOperar.UseVisualStyleBackColor = true;
            this.buttonOperar.Click += new System.EventHandler(this.buttonOperar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.labelResultado.Location = new System.Drawing.Point(353, 255);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(33, 26);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "...";
            // 
            // OperacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 299);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOperar);
            this.Controls.Add(this.textBoxComplejo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxComplejo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOperaciones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OperacionesBasicas";
            this.Text = "Operaciones Básicas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOperaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxComplejo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxComplejo2;
        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelResultado;
    }
}