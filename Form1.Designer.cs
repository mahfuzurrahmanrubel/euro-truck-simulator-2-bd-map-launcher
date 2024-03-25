 namespace copy_maker
// namespace MyDesktopApp
{
    partial class MainForm
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
            txtGameLocation = new TextBox();
            btnBrowse = new Button();
            btnLaunchGame = new Button();
            btnCopyAssets = new Button();
            SuspendLayout();
            // 
            // txtGameLocation
            // 
            txtGameLocation.Location = new Point(77, 119);
            txtGameLocation.Name = "txtGameLocation";
            txtGameLocation.ReadOnly = true;
            txtGameLocation.Size = new Size(598, 35);
            txtGameLocation.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(702, 119);
            btnBrowse.Margin = new Padding(6, 7, 6, 7);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(145, 35);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnLaunchGame
            // 
            btnLaunchGame.Location = new Point(588, 291);
            btnLaunchGame.Margin = new Padding(6, 7, 6, 7);
            btnLaunchGame.Name = "btnLaunchGame";
            btnLaunchGame.Size = new Size(300, 115);
            btnLaunchGame.TabIndex = 2;
            btnLaunchGame.Text = "Launch Game";
            btnLaunchGame.UseVisualStyleBackColor = true;
            btnLaunchGame.Click += btnLaunchGame_Click;
            // 
            // btnCopyAssets
            // 
            btnCopyAssets.Location = new Point(148, 291);
            btnCopyAssets.Name = "btnCopyAssets";
            btnCopyAssets.Size = new Size(385, 115);
            btnCopyAssets.TabIndex = 3;
            btnCopyAssets.Text = "Copy Assets";
            btnCopyAssets.UseVisualStyleBackColor = true;
            btnCopyAssets.Click += btnCopyAssets_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 559);
            Controls.Add(btnLaunchGame);
            Controls.Add(btnBrowse);
            Controls.Add(btnCopyAssets);
            Controls.Add(txtGameLocation);
            Margin = new Padding(6, 7, 6, 7);
            Name = "MainForm";
            Text = "Euro Truck Simulator Config";
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion
    }
}
