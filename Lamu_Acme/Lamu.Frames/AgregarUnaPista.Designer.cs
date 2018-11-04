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
            this.TxtBoxGenero = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxInterprete = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxSubtitulo = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxTitulo = new System.Windows.Forms.MaskedTextBox();
            this.LGenero = new System.Windows.Forms.Label();
            this.LInterprete = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgregarPista
            // 
            this.AgregarPista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarPista.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AgregarPista.FlatAppearance.BorderSize = 2;
            this.AgregarPista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AgregarPista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AgregarPista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarPista.Location = new System.Drawing.Point(83, 178);
            this.AgregarPista.Name = "AgregarPista";
            this.AgregarPista.Size = new System.Drawing.Size(78, 27);
            this.AgregarPista.TabIndex = 8;
            this.AgregarPista.Text = "Guardar";
            this.AgregarPista.UseVisualStyleBackColor = true;
            this.AgregarPista.Click += new System.EventHandler(this.AgregarPista_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBoxGenero);
            this.groupBox1.Controls.Add(this.TxtBoxInterprete);
            this.groupBox1.Controls.Add(this.TxtBoxSubtitulo);
            this.groupBox1.Controls.Add(this.TxtBoxTitulo);
            this.groupBox1.Controls.Add(this.LGenero);
            this.groupBox1.Controls.Add(this.LInterprete);
            this.groupBox1.Controls.Add(this.LSubtitulo);
            this.groupBox1.Controls.Add(this.LTitulo);
            this.groupBox1.Controls.Add(this.AgregarPista);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 222);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario Pista";
            // 
            // TxtBoxGenero
            // 
            this.TxtBoxGenero.Location = new System.Drawing.Point(126, 136);
            this.TxtBoxGenero.Name = "TxtBoxGenero";
            this.TxtBoxGenero.Size = new System.Drawing.Size(112, 22);
            this.TxtBoxGenero.TabIndex = 16;
            // 
            // TxtBoxInterprete
            // 
            this.TxtBoxInterprete.Location = new System.Drawing.Point(126, 103);
            this.TxtBoxInterprete.Name = "TxtBoxInterprete";
            this.TxtBoxInterprete.Size = new System.Drawing.Size(112, 22);
            this.TxtBoxInterprete.TabIndex = 15;
            // 
            // TxtBoxSubtitulo
            // 
            this.TxtBoxSubtitulo.Location = new System.Drawing.Point(126, 64);
            this.TxtBoxSubtitulo.Name = "TxtBoxSubtitulo";
            this.TxtBoxSubtitulo.Size = new System.Drawing.Size(112, 22);
            this.TxtBoxSubtitulo.TabIndex = 14;
            // 
            // TxtBoxTitulo
            // 
            this.TxtBoxTitulo.Location = new System.Drawing.Point(126, 27);
            this.TxtBoxTitulo.Name = "TxtBoxTitulo";
            this.TxtBoxTitulo.Size = new System.Drawing.Size(112, 22);
            this.TxtBoxTitulo.TabIndex = 13;
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Location = new System.Drawing.Point(6, 141);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(102, 14);
            this.LGenero.TabIndex = 12;
            this.LGenero.Text = "Ingrese el Género:";
            // 
            // LInterprete
            // 
            this.LInterprete.AutoSize = true;
            this.LInterprete.Location = new System.Drawing.Point(6, 106);
            this.LInterprete.Name = "LInterprete";
            this.LInterprete.Size = new System.Drawing.Size(117, 14);
            this.LInterprete.TabIndex = 11;
            this.LInterprete.Text = "Ingrese el Interprete:";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Location = new System.Drawing.Point(6, 67);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(110, 14);
            this.LSubtitulo.TabIndex = 10;
            this.LSubtitulo.Text = "Ingrese el Subtítulo:";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Location = new System.Drawing.Point(6, 27);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(93, 14);
            this.LTitulo.TabIndex = 9;
            this.LTitulo.Text = "Ingrese el Título:";
            // 
            // AgregarUnaPista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(279, 246);
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
        private System.Windows.Forms.MaskedTextBox TxtBoxGenero;
        private System.Windows.Forms.MaskedTextBox TxtBoxInterprete;
        private System.Windows.Forms.MaskedTextBox TxtBoxSubtitulo;
        private System.Windows.Forms.MaskedTextBox TxtBoxTitulo;
    }
}