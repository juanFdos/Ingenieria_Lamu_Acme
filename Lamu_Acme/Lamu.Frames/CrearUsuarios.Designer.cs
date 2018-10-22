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
            this.LabIdCliente = new System.Windows.Forms.Label();
            this.CBoxIdCliente = new System.Windows.Forms.ComboBox();
            this.TxtBoxConfirmacionContrasenia = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxContrasenia = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxIdentifiacion = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxNombre = new System.Windows.Forms.MaskedTextBox();
            this.LabIdentificacion = new System.Windows.Forms.Label();
            this.LabConfirmacionContrasenia = new System.Windows.Forms.Label();
            this.LabContrasenia = new System.Windows.Forms.Label();
            this.LabNombre = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.LabIdCliente);
            this.groupBox.Controls.Add(this.CBoxIdCliente);
            this.groupBox.Controls.Add(this.TxtBoxConfirmacionContrasenia);
            this.groupBox.Controls.Add(this.TxtBoxContrasenia);
            this.groupBox.Controls.Add(this.TxtBoxIdentifiacion);
            this.groupBox.Controls.Add(this.TxtBoxNombre);
            this.groupBox.Controls.Add(this.LabIdentificacion);
            this.groupBox.Controls.Add(this.LabConfirmacionContrasenia);
            this.groupBox.Controls.Add(this.LabContrasenia);
            this.groupBox.Controls.Add(this.LabNombre);
            this.groupBox.Controls.Add(this.BtnGuardar);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(278, 279);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Formulario usuarios";
            // 
            // LabIdCliente
            // 
            this.LabIdCliente.AutoSize = true;
            this.LabIdCliente.Location = new System.Drawing.Point(6, 186);
            this.LabIdCliente.Name = "LabIdCliente";
            this.LabIdCliente.Size = new System.Drawing.Size(35, 14);
            this.LabIdCliente.TabIndex = 14;
            this.LabIdCliente.Text = "Label";
            // 
            // CBoxIdCliente
            // 
            this.CBoxIdCliente.AllowDrop = true;
            this.CBoxIdCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CBoxIdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxIdCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBoxIdCliente.FormattingEnabled = true;
            this.CBoxIdCliente.Location = new System.Drawing.Point(130, 195);
            this.CBoxIdCliente.MaxDropDownItems = 20;
            this.CBoxIdCliente.Name = "CBoxIdCliente";
            this.CBoxIdCliente.Size = new System.Drawing.Size(141, 22);
            this.CBoxIdCliente.TabIndex = 13;
            this.CBoxIdCliente.TabStop = false;
            this.CBoxIdCliente.SelectionChangeCommitted += new System.EventHandler(this.CBoxIdCliente_SelectionChangeCommitted);
            // 
            // TxtBoxConfirmacionContrasenia
            // 
            this.TxtBoxConfirmacionContrasenia.Location = new System.Drawing.Point(130, 143);
            this.TxtBoxConfirmacionContrasenia.Name = "TxtBoxConfirmacionContrasenia";
            this.TxtBoxConfirmacionContrasenia.PasswordChar = '*';
            this.TxtBoxConfirmacionContrasenia.Size = new System.Drawing.Size(141, 22);
            this.TxtBoxConfirmacionContrasenia.TabIndex = 12;
            // 
            // TxtBoxContrasenia
            // 
            this.TxtBoxContrasenia.Location = new System.Drawing.Point(131, 105);
            this.TxtBoxContrasenia.Name = "TxtBoxContrasenia";
            this.TxtBoxContrasenia.PasswordChar = '*';
            this.TxtBoxContrasenia.Size = new System.Drawing.Size(141, 22);
            this.TxtBoxContrasenia.TabIndex = 11;
            // 
            // TxtBoxIdentifiacion
            // 
            this.TxtBoxIdentifiacion.Location = new System.Drawing.Point(130, 66);
            this.TxtBoxIdentifiacion.Mask = "9999999999";
            this.TxtBoxIdentifiacion.Name = "TxtBoxIdentifiacion";
            this.TxtBoxIdentifiacion.Size = new System.Drawing.Size(141, 22);
            this.TxtBoxIdentifiacion.TabIndex = 10;
            this.TxtBoxIdentifiacion.ValidatingType = typeof(int);
            // 
            // TxtBoxNombre
            // 
            this.TxtBoxNombre.Location = new System.Drawing.Point(130, 29);
            this.TxtBoxNombre.Name = "TxtBoxNombre";
            this.TxtBoxNombre.Size = new System.Drawing.Size(141, 22);
            this.TxtBoxNombre.TabIndex = 9;
            // 
            // LabIdentificacion
            // 
            this.LabIdentificacion.AutoSize = true;
            this.LabIdentificacion.Location = new System.Drawing.Point(6, 61);
            this.LabIdentificacion.Name = "LabIdentificacion";
            this.LabIdentificacion.Size = new System.Drawing.Size(35, 14);
            this.LabIdentificacion.TabIndex = 4;
            this.LabIdentificacion.Text = "Label";
            // 
            // LabConfirmacionContrasenia
            // 
            this.LabConfirmacionContrasenia.AutoSize = true;
            this.LabConfirmacionContrasenia.Location = new System.Drawing.Point(6, 139);
            this.LabConfirmacionContrasenia.Name = "LabConfirmacionContrasenia";
            this.LabConfirmacionContrasenia.Size = new System.Drawing.Size(35, 14);
            this.LabConfirmacionContrasenia.TabIndex = 3;
            this.LabConfirmacionContrasenia.Text = "Label";
            // 
            // LabContrasenia
            // 
            this.LabContrasenia.AutoSize = true;
            this.LabContrasenia.Location = new System.Drawing.Point(6, 101);
            this.LabContrasenia.Name = "LabContrasenia";
            this.LabContrasenia.Size = new System.Drawing.Size(32, 14);
            this.LabContrasenia.TabIndex = 2;
            this.LabContrasenia.Text = "label";
            // 
            // LabNombre
            // 
            this.LabNombre.AutoSize = true;
            this.LabNombre.Location = new System.Drawing.Point(6, 32);
            this.LabNombre.Name = "LabNombre";
            this.LabNombre.Size = new System.Drawing.Size(35, 14);
            this.LabNombre.TabIndex = 1;
            this.LabNombre.Text = "Label";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatAppearance.BorderSize = 2;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(102, 238);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 30);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CrearUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(302, 303);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.Name = "CrearUsuarios";
            this.Text = "Crear  usuarios";
            this.Load += new System.EventHandler(this.CrearUsuarios_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LabConfirmacionContrasenia;
        private System.Windows.Forms.Label LabContrasenia;
        private System.Windows.Forms.Label LabNombre;
        private System.Windows.Forms.MaskedTextBox TxtBoxConfirmacionContrasenia;
        private System.Windows.Forms.MaskedTextBox TxtBoxContrasenia;
        private System.Windows.Forms.MaskedTextBox TxtBoxIdentifiacion;
        private System.Windows.Forms.MaskedTextBox TxtBoxNombre;
        private System.Windows.Forms.ComboBox CBoxIdCliente;
        private System.Windows.Forms.Label LabIdCliente;
        private System.Windows.Forms.Label LabIdentificacion;
    }
}