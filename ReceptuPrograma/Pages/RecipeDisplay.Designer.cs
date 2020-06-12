namespace ReceptuPrograma.Pages
{
    partial class RecipeDisplay
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
            this.RecipeList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RecipeList
            // 
            this.RecipeList.BackColor = System.Drawing.SystemColors.Control;
            this.RecipeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecipeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecipeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RecipeList.FormattingEnabled = true;
            this.RecipeList.HorizontalScrollbar = true;
            this.RecipeList.IntegralHeight = false;
            this.RecipeList.ItemHeight = 31;
            this.RecipeList.Location = new System.Drawing.Point(0, 0);
            this.RecipeList.Name = "RecipeList";
            this.RecipeList.Size = new System.Drawing.Size(775, 507);
            this.RecipeList.TabIndex = 0;
            // 
            // RecipeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RecipeList);
            this.Name = "RecipeDisplay";
            this.Size = new System.Drawing.Size(775, 507);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox RecipeList;
    }
}
