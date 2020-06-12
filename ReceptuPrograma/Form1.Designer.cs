namespace ReceptuPrograma
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ForwardsBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.TabSelectionPanel = new System.Windows.Forms.Panel();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.CategoryBtn = new System.Windows.Forms.Button();
            this.AllRecepiesBtn = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.SearchBox = new MetroFramework.Controls.MetroTextBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TabSelectionPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ForwardsBtn
            // 
            this.ForwardsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ForwardsBtn.Image")));
            this.ForwardsBtn.Location = new System.Drawing.Point(95, 3);
            this.ForwardsBtn.Name = "ForwardsBtn";
            this.ForwardsBtn.Size = new System.Drawing.Size(40, 40);
            this.ForwardsBtn.TabIndex = 3;
            this.ForwardsBtn.UseVisualStyleBackColor = true;
            this.ForwardsBtn.Click += new System.EventHandler(this.ForwardsBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.Location = new System.Drawing.Point(3, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(40, 40);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // TabSelectionPanel
            // 
            this.TabSelectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TabSelectionPanel.AutoScroll = true;
            this.TabSelectionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TabSelectionPanel.Controls.Add(this.AboutBtn);
            this.TabSelectionPanel.Controls.Add(this.CategoryBtn);
            this.TabSelectionPanel.Controls.Add(this.AllRecepiesBtn);
            this.TabSelectionPanel.Location = new System.Drawing.Point(11, 60);
            this.TabSelectionPanel.Name = "TabSelectionPanel";
            this.TabSelectionPanel.Size = new System.Drawing.Size(184, 635);
            this.TabSelectionPanel.TabIndex = 1;
            // 
            // AboutBtn
            // 
            this.AboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AboutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AboutBtn.Location = new System.Drawing.Point(5, 563);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(176, 54);
            this.AboutBtn.TabIndex = 3;
            this.AboutBtn.Text = "Apie";
            this.AboutBtn.UseVisualStyleBackColor = false;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CategoryBtn.Location = new System.Drawing.Point(5, 96);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Size = new System.Drawing.Size(176, 54);
            this.CategoryBtn.TabIndex = 1;
            this.CategoryBtn.Text = "Kategorijos";
            this.CategoryBtn.UseVisualStyleBackColor = true;
            this.CategoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // AllRecepiesBtn
            // 
            this.AllRecepiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllRecepiesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AllRecepiesBtn.Location = new System.Drawing.Point(5, 36);
            this.AllRecepiesBtn.Name = "AllRecepiesBtn";
            this.AllRecepiesBtn.Size = new System.Drawing.Size(176, 54);
            this.AllRecepiesBtn.TabIndex = 0;
            this.AllRecepiesBtn.Text = "Visi receptai";
            this.AllRecepiesBtn.UseVisualStyleBackColor = true;
            this.AllRecepiesBtn.Click += new System.EventHandler(this.AllRecepiesBtn_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.AutoScroll = true;
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.ControlPanel.Controls.Add(this.SearchBox);
            this.ControlPanel.Controls.Add(this.RemoveBtn);
            this.ControlPanel.Controls.Add(this.AddBtn);
            this.ControlPanel.Controls.Add(this.EditBtn);
            this.ControlPanel.Controls.Add(this.HomeBtn);
            this.ControlPanel.Controls.Add(this.pictureBox1);
            this.ControlPanel.Controls.Add(this.BackBtn);
            this.ControlPanel.Controls.Add(this.ForwardsBtn);
            this.ControlPanel.Location = new System.Drawing.Point(203, 60);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(980, 46);
            this.ControlPanel.TabIndex = 2;
            // 
            // SearchBox
            // 
            // 
            // 
            // 
            this.SearchBox.CustomButton.Image = null;
            this.SearchBox.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.SearchBox.CustomButton.Name = "";
            this.SearchBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchBox.CustomButton.TabIndex = 1;
            this.SearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchBox.CustomButton.UseSelectable = true;
            this.SearchBox.CustomButton.Visible = false;
            this.SearchBox.Lines = new string[0];
            this.SearchBox.Location = new System.Drawing.Point(141, 13);
            this.SearchBox.MaxLength = 32767;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PromptText = "Ieškoti";
            this.SearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchBox.SelectedText = "";
            this.SearchBox.SelectionLength = 0;
            this.SearchBox.SelectionStart = 0;
            this.SearchBox.ShortcutsEnabled = true;
            this.SearchBox.ShowClearButton = true;
            this.SearchBox.Size = new System.Drawing.Size(199, 23);
            this.SearchBox.TabIndex = 9;
            this.SearchBox.UseSelectable = true;
            this.SearchBox.WaterMark = "Ieškoti";
            this.SearchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RemoveBtn.Location = new System.Drawing.Point(722, 3);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(120, 40);
            this.RemoveBtn.TabIndex = 8;
            this.RemoveBtn.Text = "Pašalinti";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AddBtn.Location = new System.Drawing.Point(596, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(120, 40);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Pridėti";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.EditBtn.Location = new System.Drawing.Point(848, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(120, 40);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Redaguoti";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(49, 3);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(40, 40);
            this.HomeBtn.TabIndex = 6;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MainPanel.Location = new System.Drawing.Point(203, 106);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(980, 590);
            this.MainPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.TabSelectionPanel);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Receptai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabSelectionPanel.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TabSelectionPanel;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button AllRecepiesBtn;
        private System.Windows.Forms.Button ForwardsBtn;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button CategoryBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Panel MainPanel;
        private MetroFramework.Controls.MetroTextBox SearchBox;
    }
}

