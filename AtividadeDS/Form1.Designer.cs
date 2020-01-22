namespace AtividadeDS
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.formas = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formas
            // 
            this.formas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.formas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.formas.FlatAppearance.BorderSize = 2;
            this.formas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.formas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.formas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formas.Font = new System.Drawing.Font("dacasa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(172)))), ((int)(((byte)(254)))));
            this.formas.Location = new System.Drawing.Point(153, 120);
            this.formas.Name = "formas";
            this.formas.Size = new System.Drawing.Size(110, 46);
            this.formas.TabIndex = 0;
            this.formas.Text = "Formas";
            this.formas.UseVisualStyleBackColor = false;
            this.formas.Click += new System.EventHandler(this.formas_Click);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.calcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.calcular.FlatAppearance.BorderSize = 2;
            this.calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcular.Font = new System.Drawing.Font("dacasa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(172)))), ((int)(((byte)(254)))));
            this.calcular.Location = new System.Drawing.Point(153, 172);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(110, 46);
            this.calcular.TabIndex = 1;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 327);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.formas);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button formas;
        private System.Windows.Forms.Button calcular;

    }
}

