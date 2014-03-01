namespace XMLAdventureGame
{
    partial class AGWindow
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
            this.inventoryButton = new System.Windows.Forms.Button();
            this.doActionButton = new System.Windows.Forms.Button();
            this.pageText = new System.Windows.Forms.Label();
            this.actionBox = new System.Windows.Forms.ListView();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.openAdventureGameDialog = new System.Windows.Forms.OpenFileDialog();
            this.aboutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryButton
            // 
            this.inventoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryButton.Location = new System.Drawing.Point(608, 410);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(75, 23);
            this.inventoryButton.TabIndex = 1;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // doActionButton
            // 
            this.doActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.doActionButton.Location = new System.Drawing.Point(0, 410);
            this.doActionButton.Name = "doActionButton";
            this.doActionButton.Size = new System.Drawing.Size(149, 23);
            this.doActionButton.TabIndex = 3;
            this.doActionButton.Text = "Do Action";
            this.doActionButton.UseVisualStyleBackColor = true;
            this.doActionButton.Click += new System.EventHandler(this.doActionButton_Click);
            // 
            // pageText
            // 
            this.pageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageText.Location = new System.Drawing.Point(155, 280);
            this.pageText.Name = "pageText";
            this.pageText.Size = new System.Drawing.Size(597, 127);
            this.pageText.TabIndex = 4;
            // 
            // actionBox
            // 
            this.actionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.actionBox.Location = new System.Drawing.Point(0, 280);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(149, 124);
            this.actionBox.TabIndex = 5;
            this.actionBox.UseCompatibleStateImageBehavior = false;
            this.actionBox.View = System.Windows.Forms.View.List;
            // 
            // imageBox
            // 
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageBox.Location = new System.Drawing.Point(0, 0);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(764, 274);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // openAdventureGameDialog
            // 
            this.openAdventureGameDialog.Filter = "Adventure Games | *.xmlag";
            this.openAdventureGameDialog.Title = "Open Adventure Game";
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutButton.Location = new System.Drawing.Point(689, 410);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 6;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // AGWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(764, 436);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.actionBox);
            this.Controls.Add(this.pageText);
            this.Controls.Add(this.doActionButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.imageBox);
            this.MinimumSize = new System.Drawing.Size(772, 463);
            this.Name = "AGWindow";
            this.Text = "XMLAdventureGame";
            this.Load += new System.EventHandler(this.AGWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button doActionButton;
        private System.Windows.Forms.Label pageText;
        private System.Windows.Forms.ListView actionBox;
        private System.Windows.Forms.OpenFileDialog openAdventureGameDialog;
        private System.Windows.Forms.Button aboutButton;
    }
}

