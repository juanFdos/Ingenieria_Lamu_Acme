namespace Lamu.Frames
{
    partial class AgregarUnaPista
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
            this.AgregarPista = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LGenero = new System.Windows.Forms.Label();
            this.LInterprete = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgregarPista
            // 
            this.AgregarPista.Location = new System.Drawing.Point(72, 164);
            this.AgregarPista.Name = "AgregarPista";
            this.AgregarPista.Size = new System.Drawing.Size(78, 27);
            this.AgregarPista.TabIndex = 8;
            this.AgregarPista.Text = "Agregar Pista";
            this.AgregarPista.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LGenero);
            this.groupBox1.Controls.Add(this.LInterprete);
            this.groupBox1.Controls.Add(this.LSubtitulo);
            this.groupBox1.Controls.Add(this.LTitulo);
            this.groupBox1.Controls.Add(this.AgregarPista);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 198);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario Pista";
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Location = new System.Drawing.Point(6, 111);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(45, 14);
            this.LGenero.TabIndex = 12;
            this.LGenero.Text = "Género";
            // 
            // LInterprete
            // 
            this.LInterprete.AutoSize = true;
            this.LInterprete.Location = new System.Drawing.Point(6, 82);
            this.LInterprete.Name = "LInterprete";
            this.LInterprete.Size = new System.Drawing.Size(60, 14);
            this.LInterprete.TabIndex = 11;
            this.LInterprete.Text = "Interprete";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Location = new System.Drawing.Point(6, 55);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(53, 14);
            this.LSubtitulo.TabIndex = 10;
            this.LSubtitulo.Text = "Subtítulo";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Location = new System.Drawing.Point(6, 27);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(36, 14);
            this.LTitulo.TabIndex = 9;
            this.LTitulo.Text = "Título";
            // 
            // AgregarUnaPista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(241, 215);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.Name = "AgregarUnaPista";
            this.Text = "Agregar Una Pista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AgregarPista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LGenero;
        private System.Windows.Forms.Label LInterprete;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.Label LTitulo;
    }
}