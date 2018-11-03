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
            this.LabUsuario = new System.Windows.Forms.Label();
            this.LabContrasenia = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBoxContrasenia = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxUsuario = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabUsuario
            // 
            this.LabUsuario.AutoSize = true;
            this.LabUsuario.Location = new System.Drawing.Point(6, 27);
            this.LabUsuario.Name = "LabUsuario";
            this.LabUsuario.Size = new System.Drawing.Size(104, 14);
            this.LabUsuario.TabIndex = 0;
            this.LabUsuario.Text = "Ingrese su usuario:";
            // 
            // LabContrasenia
            // 
            this.LabContrasenia.AutoSize = true;
            this.LabContrasenia.Location = new System.Drawing.Point(6, 62);
            this.LabContrasenia.Name = "LabContrasenia";
            this.LabContrasenia.Size = new System.Drawing.Size(67, 14);
            this.LabContrasenia.TabIndex = 2;
            this.LabContrasenia.Text = "Contraseña";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnIngresar.FlatAppearance.BorderSize = 2;
            this.BtnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Location = new System.Drawing.Point(89, 101);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 28);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBoxContrasenia);
            this.groupBox1.Controls.Add(this.TxtBoxUsuario);
            this.groupBox1.Controls.Add(this.LabUsuario);
            this.groupBox1.Controls.Add(this.BtnIngresar);
            this.groupBox1.Controls.Add(this.LabContrasenia);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 145);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario ";
            // 
            // TxtBoxContrasenia
            // 
            this.TxtBoxContrasenia.Location = new System.Drawing.Point(122, 62);
            this.TxtBoxContrasenia.Name = "TxtBoxContrasenia";
            this.TxtBoxContrasenia.Size = new System.Drawing.Size(125, 22);
            this.TxtBoxContrasenia.TabIndex = 6;
            this.TxtBoxContrasenia.UseSystemPasswordChar = true;
            // 
            // TxtBoxUsuario
            // 
            this.TxtBoxUsuario.Location = new System.Drawing.Point(122, 21);
            this.TxtBoxUsuario.Name = "TxtBoxUsuario";
            this.TxtBoxUsuario.Size = new System.Drawing.Size(125, 22);
            this.TxtBoxUsuario.TabIndex = 5;
            // 
            // AutenticarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(277, 171);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.Name = "AutenticarUsuario";
            this.ShowInTaskbar = false;
            this.Text = "Autenticar usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabUsuario;
        private System.Windows.Forms.Label LabContrasenia;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox TxtBoxContrasenia;
        private System.Windows.Forms.MaskedTextBox TxtBoxUsuario;
    }
}