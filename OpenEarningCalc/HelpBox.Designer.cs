namespace GanhosMae
{
    partial class HelpBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpBox));
            this.btnAccept = new System.Windows.Forms.Button();
            this.HelpText1 = new System.Windows.Forms.TextBox();
            this.linklblGithub = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(15, 171);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(641, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Ok";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // HelpText1
            // 
            this.HelpText1.Location = new System.Drawing.Point(12, 13);
            this.HelpText1.Multiline = true;
            this.HelpText1.Name = "HelpText1";
            this.HelpText1.ReadOnly = true;
            this.HelpText1.Size = new System.Drawing.Size(641, 45);
            this.HelpText1.TabIndex = 1;
            this.HelpText1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linklblGithub
            // 
            this.linklblGithub.AutoSize = true;
            this.linklblGithub.Location = new System.Drawing.Point(12, 61);
            this.linklblGithub.Name = "linklblGithub";
            this.linklblGithub.Size = new System.Drawing.Size(134, 14);
            this.linklblGithub.TabIndex = 2;
            this.linklblGithub.TabStop = true;
            this.linklblGithub.Text = "https://github.com/wooZbr";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 87);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HelpBox
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(668, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linklblGithub);
            this.Controls.Add(this.HelpText1);
            this.Controls.Add(this.btnAccept);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HelpBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.HelpBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox HelpText1;
        private System.Windows.Forms.LinkLabel linklblGithub;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}