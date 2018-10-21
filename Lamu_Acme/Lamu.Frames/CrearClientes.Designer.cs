namespace Lamu.Frames
{
    partial class CrearClientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBoxContrasenia = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxNombre = new System.Windows.Forms.MaskedTextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LabContrasenia = new System.Windows.Forms.Label();
            this.LabNombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBoxContrasenia);
            this.groupBox1.Controls.Add(this.TxtBoxNombre);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.LabContrasenia);
            this.groupBox1.Controls.Add(this.LabNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario para clientes";
            // 
            // TxtBoxContrasenia
            // 
            this.TxtBoxContrasenia.Location = new System.Drawing.Point(122, 71);
            this.TxtBoxContrasenia.Name = "TxtBoxContrasenia";
            this.TxtBoxContrasenia.Size = new System.Drawing.Size(113, 22);
            this.TxtBoxContrasenia.TabIndex = 4;
            // 
            // TxtBoxNombre
            // 
            this.TxtBoxNombre.Location = new System.Drawing.Point(122, 34);
            this.TxtBoxNombre.Name = "TxtBoxNombre";
            this.TxtBoxNombre.Size = new System.Drawing.Size(113, 22);
            this.TxtBoxNombre.TabIndex = 3;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatAppearance.BorderSize = 2;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(81, 109);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(76, 28);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LabContrasenia
            // 
            this.LabContrasenia.AutoSize = true;
            this.LabContrasenia.Location = new System.Drawing.Point(6, 63);
            this.LabContrasenia.Name = "LabContrasenia";
            this.LabContrasenia.Size = new System.Drawing.Size(35, 14);
            this.LabContrasenia.TabIndex = 1;
            this.LabContrasenia.Text = "label:";
            // 
            // LabNombre
            // 
            this.LabNombre.AutoSize = true;
            this.LabNombre.Location = new System.Drawing.Point(6, 37);
            this.LabNombre.Name = "LabNombre";
            this.LabNombre.Size = new System.Drawing.Size(110, 14);
            this.LabNombre.TabIndex = 0;
            this.LabNombre.Text = "Ingrese un nombre:";
            // 
            // CrearClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(273, 176);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.Name = "CrearClientes";
            this.Text = "Crear clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabContrasenia;
        private System.Windows.Forms.Label LabNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.MaskedTextBox TxtBoxContrasenia;
        private System.Windows.Forms.MaskedTextBox TxtBoxNombre;
    }
}