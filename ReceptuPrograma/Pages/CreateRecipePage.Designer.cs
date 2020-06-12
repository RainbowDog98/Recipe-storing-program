namespace ReceptuPrograma.Pages
{
    partial class CreateRecipePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleBox = new MetroFramework.Controls.MetroTextBox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.LinkBox = new MetroFramework.Controls.MetroTextBox();
            this.CategoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CustomCategoryBox = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TagBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pavadinimas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuoroda:";
            // 
            // TitleBox
            // 
            // 
            // 
            // 
            this.TitleBox.CustomButton.Image = null;
            this.TitleBox.CustomButton.Location = new System.Drawing.Point(617, 1);
            this.TitleBox.CustomButton.Name = "";
            this.TitleBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TitleBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TitleBox.CustomButton.TabIndex = 1;
            this.TitleBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TitleBox.CustomButton.UseSelectable = true;
            this.TitleBox.CustomButton.Visible = false;
            this.TitleBox.Lines = new string[0];
            this.TitleBox.Location = new System.Drawing.Point(151, 26);
            this.TitleBox.MaxLength = 32767;
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.PasswordChar = '\0';
            this.TitleBox.PromptText = "Pavadinimas";
            this.TitleBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TitleBox.SelectedText = "";
            this.TitleBox.SelectionLength = 0;
            this.TitleBox.SelectionStart = 0;
            this.TitleBox.ShortcutsEnabled = true;
            this.TitleBox.Size = new System.Drawing.Size(639, 23);
            this.TitleBox.TabIndex = 3;
            this.TitleBox.UseSelectable = true;
            this.TitleBox.WaterMark = "Pavadinimas";
            this.TitleBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TitleBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // LinkBox
            // 
            // 
            // 
            // 
            this.LinkBox.CustomButton.Image = null;
            this.LinkBox.CustomButton.Location = new System.Drawing.Point(659, 1);
            this.LinkBox.CustomButton.Name = "";
            this.LinkBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LinkBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LinkBox.CustomButton.TabIndex = 1;
            this.LinkBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LinkBox.CustomButton.UseSelectable = true;
            this.LinkBox.CustomButton.Visible = false;
            this.LinkBox.Lines = new string[0];
            this.LinkBox.Location = new System.Drawing.Point(109, 52);
            this.LinkBox.MaxLength = 32767;
            this.LinkBox.Name = "LinkBox";
            this.LinkBox.PasswordChar = '\0';
            this.LinkBox.PromptText = "Nuoroda";
            this.LinkBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LinkBox.SelectedText = "";
            this.LinkBox.SelectionLength = 0;
            this.LinkBox.SelectionStart = 0;
            this.LinkBox.ShortcutsEnabled = true;
            this.LinkBox.Size = new System.Drawing.Size(681, 23);
            this.LinkBox.TabIndex = 5;
            this.LinkBox.UseSelectable = true;
            this.LinkBox.WaterMark = "Nuoroda";
            this.LinkBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LinkBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.ItemHeight = 23;
            this.CategoryComboBox.Location = new System.Drawing.Point(124, 76);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.PromptText = "Pasirinkite";
            this.CategoryComboBox.Size = new System.Drawing.Size(220, 29);
            this.CategoryComboBox.TabIndex = 6;
            this.CategoryComboBox.UseSelectable = true;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CategoryLabel.Location = new System.Drawing.Point(3, 76);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(115, 25);
            this.CategoryLabel.TabIndex = 7;
            this.CategoryLabel.Text = "Kategorija:";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.DescriptionBox.Location = new System.Drawing.Point(8, 120);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(782, 410);
            this.DescriptionBox.TabIndex = 8;
            this.DescriptionBox.Text = "";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AddBtn.Location = new System.Drawing.Point(562, 533);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(111, 31);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Pridėti";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button2.Location = new System.Drawing.Point(679, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Atšaukti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomCategoryBox
            // 
            // 
            // 
            // 
            this.CustomCategoryBox.CustomButton.Image = null;
            this.CustomCategoryBox.CustomButton.Location = new System.Drawing.Point(321, 1);
            this.CustomCategoryBox.CustomButton.Name = "";
            this.CustomCategoryBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustomCategoryBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomCategoryBox.CustomButton.TabIndex = 1;
            this.CustomCategoryBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomCategoryBox.CustomButton.UseSelectable = true;
            this.CustomCategoryBox.CustomButton.Visible = false;
            this.CustomCategoryBox.Lines = new string[0];
            this.CustomCategoryBox.Location = new System.Drawing.Point(350, 81);
            this.CustomCategoryBox.MaxLength = 32767;
            this.CustomCategoryBox.Name = "CustomCategoryBox";
            this.CustomCategoryBox.PasswordChar = '\0';
            this.CustomCategoryBox.PromptText = "Jei nėra norimos kategorijos, čia galima irašyti naują kategoriją";
            this.CustomCategoryBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomCategoryBox.SelectedText = "";
            this.CustomCategoryBox.SelectionLength = 0;
            this.CustomCategoryBox.SelectionStart = 0;
            this.CustomCategoryBox.ShortcutsEnabled = true;
            this.CustomCategoryBox.Size = new System.Drawing.Size(343, 23);
            this.CustomCategoryBox.TabIndex = 11;
            this.CustomCategoryBox.UseSelectable = true;
            this.CustomCategoryBox.WaterMark = "Jei nėra norimos kategorijos, čia galima irašyti naują kategoriją";
            this.CustomCategoryBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomCategoryBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(8, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Žymės:";
            // 
            // TagBox
            // 
            this.TagBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.TagBox.CustomButton.Image = null;
            this.TagBox.CustomButton.Location = new System.Drawing.Point(386, 1);
            this.TagBox.CustomButton.Name = "";
            this.TagBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TagBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TagBox.CustomButton.TabIndex = 1;
            this.TagBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TagBox.CustomButton.UseSelectable = true;
            this.TagBox.CustomButton.Visible = false;
            this.TagBox.Lines = new string[0];
            this.TagBox.Location = new System.Drawing.Point(96, 539);
            this.TagBox.MaxLength = 32767;
            this.TagBox.Name = "TagBox";
            this.TagBox.PasswordChar = '\0';
            this.TagBox.PromptText = "Nubūtina, bet galime įvesti pvz. \"#keptas, #orkaitėje\"";
            this.TagBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TagBox.SelectedText = "";
            this.TagBox.SelectionLength = 0;
            this.TagBox.SelectionStart = 0;
            this.TagBox.ShortcutsEnabled = true;
            this.TagBox.Size = new System.Drawing.Size(408, 23);
            this.TagBox.TabIndex = 13;
            this.TagBox.UseSelectable = true;
            this.TagBox.WaterMark = "Nubūtina, bet galime įvesti pvz. \"#keptas, #orkaitėje\"";
            this.TagBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TagBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CreateRecipePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TagBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomCategoryBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.LinkBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateRecipePage";
            this.Size = new System.Drawing.Size(793, 567);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox TitleBox;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private MetroFramework.Controls.MetroTextBox LinkBox;
        private MetroFramework.Controls.MetroComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroTextBox CustomCategoryBox;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox TagBox;
    }
}
