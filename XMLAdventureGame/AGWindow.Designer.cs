﻿namespace XMLAdventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AGWindow));
            this.inventoryButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doActionButton = new System.Windows.Forms.Button();
            this.pageText = new System.Windows.Forms.Label();
            this.actionBox = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryButton
            // 
            this.inventoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryButton.Location = new System.Drawing.Point(677, 410);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(75, 23);
            this.inventoryButton.TabIndex = 1;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(764, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.pageText.Text = resources.GetString("pageText.Text");
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
            // AGWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(764, 436);
            this.Controls.Add(this.actionBox);
            this.Controls.Add(this.pageText);
            this.Controls.Add(this.doActionButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(772, 463);
            this.Name = "AGWindow";
            this.Text = "XMLAdventureGame";
            this.Load += new System.EventHandler(this.AGWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button doActionButton;
        private System.Windows.Forms.Label pageText;
        private System.Windows.Forms.ListView actionBox;
    }
}

