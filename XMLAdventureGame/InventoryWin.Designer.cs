namespace XMLAdventureGame
{
    partial class InventoryWin
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Test Item",
            "Yes"}, -1);
            this.invList = new System.Windows.Forms.ListView();
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.haveIt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // invList
            // 
            this.invList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.haveIt});
            this.invList.Dock = System.Windows.Forms.DockStyle.Top;
            this.invList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.invList.Location = new System.Drawing.Point(0, 0);
            this.invList.Name = "invList";
            this.invList.Size = new System.Drawing.Size(352, 317);
            this.invList.TabIndex = 0;
            this.invList.UseCompatibleStateImageBehavior = false;
            this.invList.View = System.Windows.Forms.View.Details;
            // 
            // itemName
            // 
            this.itemName.Text = "Item Name";
            this.itemName.Width = 288;
            // 
            // haveIt
            // 
            this.haveIt.Text = "Have It";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(265, 326);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // InventoryWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 361);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.invList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InventoryWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView invList;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader haveIt;
    }
}