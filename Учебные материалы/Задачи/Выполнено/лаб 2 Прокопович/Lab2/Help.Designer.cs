namespace Lab2
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpravTB = new System.Windows.Forms.TextBox();
            this.SpravT = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.SpravTB);
            this.panel1.Controls.Add(this.SpravT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 530);
            this.panel1.TabIndex = 0;
            // 
            // SpravTB
            // 
            this.SpravTB.BackColor = System.Drawing.SystemColors.ControlText;
            this.SpravTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpravTB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpravTB.ForeColor = System.Drawing.Color.White;
            this.SpravTB.Location = new System.Drawing.Point(0, 51);
            this.SpravTB.Multiline = true;
            this.SpravTB.Name = "SpravTB";
            this.SpravTB.ReadOnly = true;
            this.SpravTB.Size = new System.Drawing.Size(853, 479);
            this.SpravTB.TabIndex = 1;
            this.SpravTB.Text = resources.GetString("SpravTB.Text");
            this.SpravTB.TextChanged += new System.EventHandler(this.SpravTB_TextChanged);
            // 
            // SpravT
            // 
            this.SpravT.BackColor = System.Drawing.SystemColors.ControlText;
            this.SpravT.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpravT.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpravT.ForeColor = System.Drawing.Color.White;
            this.SpravT.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SpravT.Location = new System.Drawing.Point(0, 0);
            this.SpravT.Name = "SpravT";
            this.SpravT.Size = new System.Drawing.Size(853, 51);
            this.SpravT.TabIndex = 0;
            this.SpravT.Text = "Краткая справка:";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SpravTB;
        private System.Windows.Forms.Label SpravT;
    }
}