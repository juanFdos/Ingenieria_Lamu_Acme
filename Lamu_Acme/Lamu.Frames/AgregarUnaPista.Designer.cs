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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxBoxGenero = new System.Windows.Forms.MaskedTextBox();
            this.TxBoxInterprete = new System.Windows.Forms.MaskedTextBox();
            this.TxBoxSubtitulo = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxtitulo = new System.Windows.Forms.MaskedTextBox();
            this.LabSubtitulo = new System.Windows.Forms.Label();
            this.LabGenero = new System.Windows.Forms.Label();
            this.LabInterprete = new System.Windows.Forms.Label();
            this.LabTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxBoxGenero);
            this.groupBox1.Controls.Add(this.TxBoxInterprete);
            this.groupBox1.Controls.Add(this.TxBoxSubtitulo);
            this.groupBox1.Controls.Add(this.TxtBoxtitulo);
            this.groupBox1.Controls.Add(this.LabSubtitulo);
            this.groupBox1.Controls.Add(this.LabGenero);
            this.groupBox1.Controls.Add(this.LabInterprete);
            this.groupBox1.Controls.Add(this.LabTitulo);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario pista";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatAppearance.BorderSize = 2;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(96, 177);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 27);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxBoxGenero
            // 
            this.TxBoxGenero.Location = new System.Drawing.Point(128, 135);
            this.TxBoxGenero.Name = "TxBoxGenero";
            this.TxBoxGenero.PasswordChar = '*';
            this.TxBoxGenero.Size = new System.Drawing.Size(141, 22);
            this.TxBoxGenero.TabIndex = 20;
            // 
            // TxBoxInterprete
            // 
            this.TxBoxInterprete.Location = new System.Drawing.Point(128, 97);
            this.TxBoxInterprete.Name = "TxBoxInterprete";
            this.TxBoxInterprete.PasswordChar = '*';
            this.TxBoxInterprete.Size = new System.Drawing.Size(141, 22);
            this.TxBoxInterprete.TabIndex = 19;
            // 
            // TxBoxSubtitulo
            // 
            this.TxBoxSubtitulo.Location = new System.Drawing.Point(128, 58);
            this.TxBoxSubtitulo.Name = "TxBoxSubtitulo";
            this.TxBoxSubtitulo.Size = new System.Drawing.Size(141, 22);
            this.TxBoxSubtitulo.TabIndex = 18;
            // 
            // TxtBoxtitulo
            // 
            this.TxtBoxtitulo.Location = new System.Drawing.Point(128, 21);
            this.TxtBoxtitulo.Name = "TxtBoxtitulo";
            this.TxtBoxtitulo.Size = new System.Drawing.Size(141, 22);
            this.TxtBoxtitulo.TabIndex = 17;
            // 
            // LabSubtitulo
            // 
            this.LabSubtitulo.AutoSize = true;
            this.LabSubtitulo.Location = new System.Drawing.Point(4, 61);
            this.LabSubtitulo.Name = "LabSubtitulo";
            this.LabSubtitulo.Size = new System.Drawing.Size(35, 14);
            this.LabSubtitulo.TabIndex = 16;
            this.LabSubtitulo.Text = "Label";
            // 
            // LabGenero
            // 
            this.LabGenero.AutoSize = true;
            this.LabGenero.Location = new System.Drawing.Point(4, 138);
            this.LabGenero.Name = "LabGenero";
            this.LabGenero.Size = new System.Drawing.Size(35, 14);
            this.LabGenero.TabIndex = 15;
            this.LabGenero.Text = "Label";
            // 
            // LabInterprete
            // 
            this.LabInterprete.AutoSize = true;
            this.LabInterprete.Location = new System.Drawing.Point(4, 100);
            this.LabInterprete.Name = "LabInterprete";
            this.LabInterprete.Size = new System.Drawing.Size(32, 14);
            this.LabInterprete.TabIndex = 14;
            this.LabInterprete.Text = "label";
            // 
            // LabTitulo
            // 
            this.LabTitulo.AutoSize = true;
            this.LabTitulo.Location = new System.Drawing.Point(4, 24);
            this.LabTitulo.Name = "LabTitulo";
            this.LabTitulo.Size = new System.Drawing.Size(35, 14);
            this.LabTitulo.TabIndex = 13;
            this.LabTitulo.Text = "Label";
            // 
            // AgregarUnaPista
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(312, 235);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.Name = "AgregarUnaPista";
            this.Text = "Agregar una nueva pista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.MaskedTextBox TxBoxGenero;
        private System.Windows.Forms.MaskedTextBox TxBoxInterprete;
        private System.Windows.Forms.MaskedTextBox TxBoxSubtitulo;
        private System.Windows.Forms.MaskedTextBox TxtBoxtitulo;
        private System.Windows.Forms.Label LabSubtitulo;
        private System.Windows.Forms.Label LabGenero;
        private System.Windows.Forms.Label LabInterprete;
        private System.Windows.Forms.Label LabTitulo;
    }
}