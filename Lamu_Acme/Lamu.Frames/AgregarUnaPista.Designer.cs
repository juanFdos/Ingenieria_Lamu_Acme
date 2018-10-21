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
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.LInterprete = new System.Windows.Forms.Label();
            this.LGenero = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.Subtitulo = new System.Windows.Forms.TextBox();
            this.Interprete = new System.Windows.Forms.TextBox();
            this.Genero = new System.Windows.Forms.TextBox();
            this.AgregarPista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Location = new System.Drawing.Point(43, 32);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(35, 13);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Título";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Location = new System.Drawing.Point(43, 61);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(50, 13);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Subtítulo";
            // 
            // LInterprete
            // 
            this.LInterprete.AutoSize = true;
            this.LInterprete.Location = new System.Drawing.Point(43, 89);
            this.LInterprete.Name = "LInterprete";
            this.LInterprete.Size = new System.Drawing.Size(52, 13);
            this.LInterprete.TabIndex = 2;
            this.LInterprete.Text = "Interprete";
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Location = new System.Drawing.Point(43, 117);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(42, 13);
            this.LGenero.TabIndex = 3;
            this.LGenero.Text = "Género";
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(129, 29);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(100, 20);
            this.Titulo.TabIndex = 4;
            // 
            // Subtitulo
            // 
            this.Subtitulo.Location = new System.Drawing.Point(129, 54);
            this.Subtitulo.Name = "Subtitulo";
            this.Subtitulo.Size = new System.Drawing.Size(100, 20);
            this.Subtitulo.TabIndex = 5;
            // 
            // Interprete
            // 
            this.Interprete.Location = new System.Drawing.Point(129, 86);
            this.Interprete.Name = "Interprete";
            this.Interprete.Size = new System.Drawing.Size(100, 20);
            this.Interprete.TabIndex = 6;
            // 
            // Genero
            // 
            this.Genero.Location = new System.Drawing.Point(129, 114);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(100, 20);
            this.Genero.TabIndex = 7;
            // 
            // AgregarPista
            // 
            this.AgregarPista.Location = new System.Drawing.Point(98, 150);
            this.AgregarPista.Name = "AgregarPista";
            this.AgregarPista.Size = new System.Drawing.Size(89, 35);
            this.AgregarPista.TabIndex = 8;
            this.AgregarPista.Text = "Agregar Pista";
            this.AgregarPista.UseVisualStyleBackColor = true;
            // 
            // AgregarUnaPista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 196);
            this.Controls.Add(this.AgregarPista);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.Interprete);
            this.Controls.Add(this.Subtitulo);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.LGenero);
            this.Controls.Add(this.LInterprete);
            this.Controls.Add(this.LSubtitulo);
            this.Controls.Add(this.LTitulo);
            this.Name = "AgregarUnaPista";
            this.Text = "Agregar Una Pista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.Label LInterprete;
        private System.Windows.Forms.Label LGenero;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.TextBox Subtitulo;
        private System.Windows.Forms.TextBox Interprete;
        private System.Windows.Forms.TextBox Genero;
        private System.Windows.Forms.Button AgregarPista;
    }
}