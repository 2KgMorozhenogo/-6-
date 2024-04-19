namespace Lab2
{
    partial class MainMenu
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
            this.Back = new System.Windows.Forms.Panel();
            this.SpravB = new System.Windows.Forms.Button();
            this.StopB = new System.Windows.Forms.Button();
            this.StartB = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Label();
            this.Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ControlText;
            this.Back.Controls.Add(this.SpravB);
            this.Back.Controls.Add(this.StopB);
            this.Back.Controls.Add(this.StartB);
            this.Back.Controls.Add(this.Menu);
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(668, 461);
            this.Back.TabIndex = 0;
            // 
            // SpravB
            // 
            this.SpravB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SpravB.Location = new System.Drawing.Point(509, 419);
            this.SpravB.Name = "SpravB";
            this.SpravB.Size = new System.Drawing.Size(159, 42);
            this.SpravB.TabIndex = 3;
            this.SpravB.Text = "Справка";
            this.SpravB.UseVisualStyleBackColor = true;
            this.SpravB.Click += new System.EventHandler(this.SpravB_Click);
            // 
            // StopB
            // 
            this.StopB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StopB.Location = new System.Drawing.Point(142, 197);
            this.StopB.Name = "StopB";
            this.StopB.Size = new System.Drawing.Size(400, 53);
            this.StopB.TabIndex = 2;
            this.StopB.Text = "Выйти из программы";
            this.StopB.UseVisualStyleBackColor = true;
            this.StopB.Click += new System.EventHandler(this.StopB_Click);
            // 
            // StartB
            // 
            this.StartB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartB.Location = new System.Drawing.Point(142, 117);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(400, 53);
            this.StartB.TabIndex = 1;
            this.StartB.Text = "Запустить программу";
            this.StartB.UseVisualStyleBackColor = true;
            this.StartB.Click += new System.EventHandler(this.StartB_Click);
            // 
            // Menu
            // 
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(668, 45);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Главное меню";
            this.Menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(668, 461);
            this.Controls.Add(this.Back);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainMenu";
            this.Text = "MainMenu (Прокопович Д.Е.) №4; 26032024)";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Back.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Back;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Button StartB;
        private System.Windows.Forms.Button StopB;
        private System.Windows.Forms.Button SpravB;
    }
}