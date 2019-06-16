namespace K3011_1C2019_G3_TPSuperior
{
    partial class Transformaciones
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
            this.titulo = new System.Windows.Forms.Label();
            this.textBoxComplejo = new System.Windows.Forms.TextBox();
            this.buttonTransformar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(27, 24);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(307, 26);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Transformar un númeo complejo";
            // 
            // textBoxComplejo
            // 
            this.textBoxComplejo.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.textBoxComplejo.Location = new System.Drawing.Point(294, 86);
            this.textBoxComplejo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComplejo.Name = "textBoxComplejo";
            this.textBoxComplejo.Size = new System.Drawing.Size(219, 31);
            this.textBoxComplejo.TabIndex = 3;
            // 
            // buttonTransformar
            // 
            this.buttonTransformar.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.buttonTransformar.Location = new System.Drawing.Point(315, 135);
            this.buttonTransformar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTransformar.Name = "buttonTransformar";
            this.buttonTransformar.Size = new System.Drawing.Size(180, 39);
            this.buttonTransformar.TabIndex = 8;
            this.buttonTransformar.Text = "TRANSFORMAR";
            this.buttonTransformar.UseVisualStyleBackColor = true;
            this.buttonTransformar.Click += new System.EventHandler(this.buttonTransformar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resultado:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(337, 232);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(33, 26);
            this.labelResultado.TabIndex = 10;
            this.labelResultado.Text = "...";
            // 
            // Transformaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 288);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTransformar);
            this.Controls.Add(this.textBoxComplejo);
            this.Controls.Add(this.titulo);
            this.Name = "Transformaciones";
            this.Text = "Transformaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.TextBox textBoxComplejo;
        private System.Windows.Forms.Button buttonTransformar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResultado;
    }
}