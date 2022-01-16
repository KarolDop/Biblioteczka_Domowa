namespace homeLibary
{
    partial class homePageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePageForm));
            this.addButton = new System.Windows.Forms.Button();
            this.delateButton = new System.Windows.Forms.Button();
            this.modyficationButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.CreateNewDBLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addButton.FlatAppearance.BorderSize = 20;
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // delateButton
            // 
            resources.ApplyResources(this.delateButton, "delateButton");
            this.delateButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delateButton.FlatAppearance.BorderSize = 20;
            this.delateButton.Name = "delateButton";
            this.delateButton.UseVisualStyleBackColor = false;
            // 
            // modyficationButton
            // 
            resources.ApplyResources(this.modyficationButton, "modyficationButton");
            this.modyficationButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modyficationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modyficationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.modyficationButton.FlatAppearance.BorderSize = 20;
            this.modyficationButton.Name = "modyficationButton";
            this.modyficationButton.UseVisualStyleBackColor = false;
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchButton.FlatAppearance.BorderSize = 20;
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginButton.FlatAppearance.BorderSize = 20;
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // CreateNewDBLinkLabel
            // 
            resources.ApplyResources(this.CreateNewDBLinkLabel, "CreateNewDBLinkLabel");
            this.CreateNewDBLinkLabel.Name = "CreateNewDBLinkLabel";
            this.CreateNewDBLinkLabel.TabStop = true;
            // 
            // homePageForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.CreateNewDBLinkLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.modyficationButton);
            this.Controls.Add(this.delateButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "homePageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addButton;
        private Button delateButton;
        private Button modyficationButton;
        private Button searchButton;
        private Button loginButton;
        private LinkLabel CreateNewDBLinkLabel;
    }
}