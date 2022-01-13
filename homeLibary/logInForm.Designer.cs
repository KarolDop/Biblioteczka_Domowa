namespace homeLibary
{
    partial class logInForm
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logInForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.dontHaveLibaryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.bookPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logInButton
            // 
            resources.ApplyResources(this.logInButton, "logInButton");
            this.logInButton.Name = "logInButton";
            this.logInButton.UseVisualStyleBackColor = true;
            // 
            // dontHaveLibaryLinkLabel
            // 
            resources.ApplyResources(this.dontHaveLibaryLinkLabel, "dontHaveLibaryLinkLabel");
            this.dontHaveLibaryLinkLabel.Name = "dontHaveLibaryLinkLabel";
            this.dontHaveLibaryLinkLabel.TabStop = true;
            // 
            // loginLabel
            // 
            resources.ApplyResources(this.loginLabel, "loginLabel");
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Name = "loginLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // bookPictureBox
            // 
            resources.ApplyResources(this.bookPictureBox, "bookPictureBox");
            this.bookPictureBox.Image = global::homeLibary.Properties.Resources.IMG_20190630_213036;
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.TabStop = false;
            // 
            // logInForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.dontHaveLibaryLinkLabel);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bookPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "logInForm";
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitButton;
        private Button logInButton;
        private LinkLabel dontHaveLibaryLinkLabel;
        private Label loginLabel;
        private Label passwordLabel;
        private PictureBox bookPictureBox;
    }
}