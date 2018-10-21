namespace Lamu.Frames
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnHU1 = new System.Windows.Forms.Button();
            this.BtnHU4 = new System.Windows.Forms.Button();
            this.BtnHU6 = new System.Windows.Forms.Button();
            this.BtnHU5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnHU1
            // 
            this.BtnHU1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnHU1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnHU1.FlatAppearance.BorderSize = 2;
            this.BtnHU1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnHU1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnHU1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHU1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHU1.Location = new System.Drawing.Point(6, 30);
            this.BtnHU1.Name = "BtnHU1";
            this.BtnHU1.Size = new System.Drawing.Size(89, 45);
            this.BtnHU1.TabIndex = 0;
            this.BtnHU1.Text = "Autenticarse";
            this.BtnHU1.UseVisualStyleBackColor = true;
            this.BtnHU1.Click += new System.EventHandler(this.BtnHU1_Click);
            // 
            // BtnHU4
            // 
            this.BtnHU4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnHU4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnHU4.FlatAppearance.BorderSize = 2;
            this.BtnHU4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnHU4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnHU4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHU4.Location = new System.Drawing.Point(113, 30);
            this.BtnHU4.Name = "BtnHU4";
            this.BtnHU4.Size = new System.Drawing.Size(75, 45);
            this.BtnHU4.TabIndex = 1;
            this.BtnHU4.Text = "Crear usuarios";
            this.BtnHU4.UseVisualStyleBackColor = false;
            this.BtnHU4.Click += new System.EventHandler(this.BtnHU4_Click);
            // 
            // BtnHU6
            // 
            this.BtnHU6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnHU6.FlatAppearance.BorderSize = 2;
            this.BtnHU6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnHU6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnHU6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHU6.Location = new System.Drawing.Point(15, 91);
            this.BtnHU6.Name = "BtnHU6";
            this.BtnHU6.Size = new System.Drawing.Size(75, 45);
            this.BtnHU6.TabIndex = 2;
            this.BtnHU6.Text = "Agregar pista";
            this.BtnHU6.UseVisualStyleBackColor = true;
            this.BtnHU6.Click += new System.EventHandler(this.BtnHU6_Click);
            // 
            // BtnHU5
            // 
            this.BtnHU5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnHU5.FlatAppearance.BorderSize = 2;
            this.BtnHU5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnHU5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnHU5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHU5.Location = new System.Drawing.Point(15, 30);
            this.BtnHU5.Name = "BtnHU5";
            this.BtnHU5.Size = new System.Drawing.Size(75, 45);
            this.BtnHU5.TabIndex = 3;
            this.BtnHU5.Text = "Crear clientes";
            this.BtnHU5.UseVisualStyleBackColor = true;
            this.BtnHU5.Click += new System.EventHandler(this.BtnHU5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnHU1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnHU6);
            this.groupBox2.Controls.Add(this.BtnHU4);
            this.groupBox2.Controls.Add(this.BtnHU5);
            this.groupBox2.Location = new System.Drawing.Point(119, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 153);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrador";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(335, 177);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHU1;
        private System.Windows.Forms.Button BtnHU4;
        private System.Windows.Forms.Button BtnHU6;
        private System.Windows.Forms.Button BtnHU5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

