namespace Lamu.Frames
{
    partial class CrearUsuarios
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LabNombre = new System.Windows.Forms.Label();
            this.LabContrasenia = new System.Windows.Forms.Label();
            this.LabConfirmacionContrasenia = new System.Windows.Forms.Label();
            this.LabCorreo = new System.Windows.Forms.Label();
            this.TxtBoxNombre = new System.Windows.Forms.MaskedTextBox();
            this.TxBoxCorreo = new System.Windows.Forms.MaskedTextBox();
            this.TxBoxContrasenia = new System.Windows.Forms.MaskedTextBox();
            this.TxBoxConfirmacionContrasenia = new System.Windows.Forms.MaskedTextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.TxBoxConfirmacionContrasenia);
            this.groupBox.Controls.Add(this.TxBoxContrasenia);
            this.groupBox.Controls.Add(this.TxBoxCorreo);
            this.groupBox.Controls.Add(this.TxtBoxNombre);
            this.groupBox.Controls.Add(this.LabCorreo);
            this.groupBox.Controls.Add(this.LabConfirmacionContrasenia);
            this.groupBox.Controls.Add(this.LabContrasenia);
            this.groupBox.Controls.Add(this.LabNombre);
            this.groupBox.Controls.Add(this.BtnGuardar);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(280, 229);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Datos";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatAppearance.BorderSize = 3;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnGuardar.Location = new System.Drawing.Point(98, 189);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LabNombre
            // 
            this.LabNombre.AutoSize = true;
            this.LabNombre.Location = new System.Drawing.Point(6, 32);
            this.LabNombre.Name = "LabNombre";
            this.LabNombre.Size = new System.Drawing.Size(0, 14);
            this.LabNombre.TabIndex = 1;
            // 
            // LabContrasenia
            // 
            this.LabContrasenia.AutoSize = true;
            this.LabContrasenia.Location = new System.Drawing.Point(6, 105);
            this.LabContrasenia.Name = "LabContrasenia";
            this.LabContrasenia.Size = new System.Drawing.Size(0, 14);
            this.LabContrasenia.TabIndex = 2;
            // 
            // LabConfirmacionContrasenia
            // 
            this.LabConfirmacionContrasenia.AutoSize = true;
            this.LabConfirmacionContrasenia.Location = new System.Drawing.Point(6, 138);
            this.LabConfirmacionContrasenia.Name = "LabConfirmacionContrasenia";
            this.LabConfirmacionContrasenia.Size = new System.Drawing.Size(0, 14);
            this.LabConfirmacionContrasenia.TabIndex = 3;
            // 
            // LabCorreo
            // 
            this.LabCorreo.AutoSize = true;
            this.LabCorreo.Location = new System.Drawing.Point(6, 63);
            this.LabCorreo.Name = "LabCorreo";
            this.LabCorreo.Size = new System.Drawing.Size(0, 14);
            this.LabCorreo.TabIndex = 4;
            // 
            // TxtBoxNombre
            // 
            this.TxtBoxNombre.Location = new System.Drawing.Point(130, 29);
            this.TxtBoxNombre.Name = "TxtBoxNombre";
            this.TxtBoxNombre.Size = new System.Drawing.Size(141, 22);
            this.TxtBoxNombre.TabIndex = 9;
            // 
            // TxBoxCorreo
            // 
            this.TxBoxCorreo.Location = new System.Drawing.Point(130, 63);
            this.TxBoxCorreo.Name = "TxBoxCorreo";
            this.TxBoxCorreo.Size = new System.Drawing.Size(141, 22);
            this.TxBoxCorreo.TabIndex = 10;
            // 
            // TxBoxContrasenia
            // 
            this.TxBoxContrasenia.Location = new System.Drawing.Point(130, 102);
            this.TxBoxContrasenia.Name = "TxBoxContrasenia";
            this.TxBoxContrasenia.PasswordChar = '*';
            this.TxBoxContrasenia.Size = new System.Drawing.Size(141, 22);
            this.TxBoxContrasenia.TabIndex = 11;
            // 
            // TxBoxConfirmacionContrasenia
            // 
            this.TxBoxConfirmacionContrasenia.Location = new System.Drawing.Point(130, 135);
            this.TxBoxConfirmacionContrasenia.Name = "TxBoxConfirmacionContrasenia";
            this.TxBoxConfirmacionContrasenia.PasswordChar = '*';
            this.TxBoxConfirmacionContrasenia.Size = new System.Drawing.Size(141, 22);
            this.TxBoxConfirmacionContrasenia.TabIndex = 12;
            // 
            // CrearUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(297, 247);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.Name = "CrearUsuarios";
            this.Text = "Crear  usuarios";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LabCorreo;
        private System.Windows.Forms.Label LabConfirmacionContrasenia;
        private System.Windows.Forms.Label LabContrasenia;
        private System.Windows.Forms.Label LabNombre;
        private System.Windows.Forms.MaskedTextBox TxBoxConfirmacionContrasenia;
        private System.Windows.Forms.MaskedTextBox TxBoxContrasenia;
        private System.Windows.Forms.MaskedTextBox TxBoxCorreo;
        private System.Windows.Forms.MaskedTextBox TxtBoxNombre;
    }
}