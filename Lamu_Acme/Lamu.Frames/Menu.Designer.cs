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
            this.SuspendLayout();
            // 
            // BtnHU1
            // 
            this.BtnHU1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnHU1.FlatAppearance.BorderSize = 3;
            this.BtnHU1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnHU1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnHU1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnHU1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHU1.Location = new System.Drawing.Point(28, 22);
            this.BtnHU1.Name = "BtnHU1";
            this.BtnHU1.Size = new System.Drawing.Size(75, 45);
            this.BtnHU1.TabIndex = 0;
            this.BtnHU1.Text = "historia Usuario #1";
            this.BtnHU1.UseVisualStyleBackColor = true;
            this.BtnHU1.Click += new System.EventHandler(this.BtnHU1_Click);
            // 
            // BtnHU4
            // 
            this.BtnHU4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnHU4.FlatAppearance.BorderSize = 3;
            this.BtnHU4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnHU4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnHU4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnHU4.Location = new System.Drawing.Point(171, 22);
            this.BtnHU4.Name = "BtnHU4";
            this.BtnHU4.Size = new System.Drawing.Size(75, 45);
            this.BtnHU4.TabIndex = 1;
            this.BtnHU4.Text = "historia Usuario #4";
            this.BtnHU4.UseVisualStyleBackColor = true;
            this.BtnHU4.Click += new System.EventHandler(this.BtnHU4_Click);
            // 
            // BtnHU6
            // 
            this.BtnHU6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnHU6.FlatAppearance.BorderSize = 3;
            this.BtnHU6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnHU6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnHU6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnHU6.Location = new System.Drawing.Point(171, 89);
            this.BtnHU6.Name = "BtnHU6";
            this.BtnHU6.Size = new System.Drawing.Size(75, 45);
            this.BtnHU6.TabIndex = 2;
            this.BtnHU6.Text = "historia Usuario #6";
            this.BtnHU6.UseVisualStyleBackColor = true;
            this.BtnHU6.Click += new System.EventHandler(this.BtnHU6_Click);
            // 
            // BtnHU5
            // 
            this.BtnHU5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnHU5.FlatAppearance.BorderSize = 3;
            this.BtnHU5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnHU5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnHU5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnHU5.Location = new System.Drawing.Point(28, 89);
            this.BtnHU5.Name = "BtnHU5";
            this.BtnHU5.Size = new System.Drawing.Size(75, 45);
            this.BtnHU5.TabIndex = 3;
            this.BtnHU5.Text = "historia Usuario #5";
            this.BtnHU5.UseVisualStyleBackColor = true;
            this.BtnHU5.Click += new System.EventHandler(this.BtnHU5_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 157);
            this.Controls.Add(this.BtnHU5);
            this.Controls.Add(this.BtnHU6);
            this.Controls.Add(this.BtnHU4);
            this.Controls.Add(this.BtnHU1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.HelpButton = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHU1;
        private System.Windows.Forms.Button BtnHU4;
        private System.Windows.Forms.Button BtnHU6;
        private System.Windows.Forms.Button BtnHU5;
    }
}

