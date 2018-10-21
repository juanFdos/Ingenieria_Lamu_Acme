namespace Lamu.Frames
{
    partial class AutenticarUsuario
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
            this.Lusuario = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.LContrasenia = new System.Windows.Forms.Label();
            this.Contrasenia = new System.Windows.Forms.TextBox();
            this.Validar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lusuario
            // 
            this.Lusuario.AutoSize = true;
            this.Lusuario.Location = new System.Drawing.Point(32, 27);
            this.Lusuario.Name = "Lusuario";
            this.Lusuario.Size = new System.Drawing.Size(43, 13);
            this.Lusuario.TabIndex = 0;
            this.Lusuario.Text = "Usuario";
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(125, 27);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(122, 20);
            this.Usuario.TabIndex = 1;
            // 
            // LContrasenia
            // 
            this.LContrasenia.AutoSize = true;
            this.LContrasenia.Location = new System.Drawing.Point(32, 69);
            this.LContrasenia.Name = "LContrasenia";
            this.LContrasenia.Size = new System.Drawing.Size(61, 13);
            this.LContrasenia.TabIndex = 2;
            this.LContrasenia.Text = "Contraseña";
            // 
            // Contrasenia
            // 
            this.Contrasenia.Location = new System.Drawing.Point(125, 66);
            this.Contrasenia.Name = "Contrasenia";
            this.Contrasenia.PasswordChar = '*';
            this.Contrasenia.Size = new System.Drawing.Size(122, 20);
            this.Contrasenia.TabIndex = 3;
            // 
            // Validar
            // 
            this.Validar.Location = new System.Drawing.Point(91, 108);
            this.Validar.Name = "Validar";
            this.Validar.Size = new System.Drawing.Size(75, 23);
            this.Validar.TabIndex = 4;
            this.Validar.Text = "Validar";
            this.Validar.UseVisualStyleBackColor = true;
            // 
            // AutenticarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 159);
            this.Controls.Add(this.Validar);
            this.Controls.Add(this.Contrasenia);
            this.Controls.Add(this.LContrasenia);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Lusuario);
            this.Name = "AutenticarUsuario";
            this.ShowInTaskbar = false;
            this.Text = "Autenticación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lusuario;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label LContrasenia;
        private System.Windows.Forms.TextBox Contrasenia;
        private System.Windows.Forms.Button Validar;
    }
}