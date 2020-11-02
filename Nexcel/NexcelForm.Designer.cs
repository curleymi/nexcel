namespace Nexcel
{
    partial class NexcelForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.nexcelMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateButton = new System.Windows.Forms.Button();
            this.selectedCellTextBox = new System.Windows.Forms.TextBox();
            this.sheetTabControl = new System.Windows.Forms.TabControl();
            this.selectedCellComboBox = new System.Windows.Forms.ComboBox();
            this.addSheetButton = new System.Windows.Forms.Button();
            this.addSheetTextBox = new System.Windows.Forms.TextBox();
            this.addSheetIndexComboBox = new System.Windows.Forms.ComboBox();
            this.sheetComboBox = new System.Windows.Forms.ComboBox();
            this.deleteSheetButton = new System.Windows.Forms.Button();
            this.decreaseSheetIndexButton = new System.Windows.Forms.Button();
            this.increaseSheetIndexButton = new System.Windows.Forms.Button();
            this.moveSheetLabel = new System.Windows.Forms.Label();
            this.nexcelMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nexcelMenuStrip
            // 
            this.nexcelMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nexcelMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.insertToolStripMenuItem});
            this.nexcelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.nexcelMenuStrip.Name = "nexcelMenuStrip";
            this.nexcelMenuStrip.Size = new System.Drawing.Size(882, 28);
            this.nexcelMenuStrip.TabIndex = 0;
            this.nexcelMenuStrip.Text = "nexcelMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(800, 35);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 32);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // selectedCellTextBox
            // 
            this.selectedCellTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCellTextBox.Location = new System.Drawing.Point(90, 38);
            this.selectedCellTextBox.Name = "selectedCellTextBox";
            this.selectedCellTextBox.Size = new System.Drawing.Size(704, 27);
            this.selectedCellTextBox.TabIndex = 1;
            // 
            // sheetTabControl
            // 
            this.sheetTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sheetTabControl.Location = new System.Drawing.Point(12, 84);
            this.sheetTabControl.Name = "sheetTabControl";
            this.sheetTabControl.SelectedIndex = 0;
            this.sheetTabControl.Size = new System.Drawing.Size(858, 281);
            this.sheetTabControl.TabIndex = 3;
            // 
            // selectedCellComboBox
            // 
            this.selectedCellComboBox.FormattingEnabled = true;
            this.selectedCellComboBox.Location = new System.Drawing.Point(12, 38);
            this.selectedCellComboBox.Name = "selectedCellComboBox";
            this.selectedCellComboBox.Size = new System.Drawing.Size(72, 28);
            this.selectedCellComboBox.TabIndex = 4;
            // 
            // addSheetButton
            // 
            this.addSheetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addSheetButton.Location = new System.Drawing.Point(289, 409);
            this.addSheetButton.Name = "addSheetButton";
            this.addSheetButton.Size = new System.Drawing.Size(95, 32);
            this.addSheetButton.TabIndex = 5;
            this.addSheetButton.Text = "Add Sheet";
            this.addSheetButton.UseVisualStyleBackColor = true;
            this.addSheetButton.Click += new System.EventHandler(this.addSheetButton_Click);
            // 
            // addSheetTextBox
            // 
            this.addSheetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addSheetTextBox.Location = new System.Drawing.Point(12, 412);
            this.addSheetTextBox.Name = "addSheetTextBox";
            this.addSheetTextBox.Size = new System.Drawing.Size(271, 27);
            this.addSheetTextBox.TabIndex = 6;
            // 
            // addSheetIndexComboBox
            // 
            this.addSheetIndexComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addSheetIndexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addSheetIndexComboBox.FormattingEnabled = true;
            this.addSheetIndexComboBox.Items.AddRange(new object[] {
            "Before",
            "After"});
            this.addSheetIndexComboBox.Location = new System.Drawing.Point(390, 412);
            this.addSheetIndexComboBox.Name = "addSheetIndexComboBox";
            this.addSheetIndexComboBox.Size = new System.Drawing.Size(72, 28);
            this.addSheetIndexComboBox.TabIndex = 7;
            // 
            // sheetComboBox
            // 
            this.sheetComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sheetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sheetComboBox.FormattingEnabled = true;
            this.sheetComboBox.Location = new System.Drawing.Point(468, 412);
            this.sheetComboBox.Name = "sheetComboBox";
            this.sheetComboBox.Size = new System.Drawing.Size(192, 28);
            this.sheetComboBox.TabIndex = 8;
            // 
            // deleteSheetButton
            // 
            this.deleteSheetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSheetButton.Location = new System.Drawing.Point(704, 409);
            this.deleteSheetButton.Name = "deleteSheetButton";
            this.deleteSheetButton.Size = new System.Drawing.Size(166, 32);
            this.deleteSheetButton.TabIndex = 9;
            this.deleteSheetButton.Text = "Delete Current Sheet";
            this.deleteSheetButton.UseVisualStyleBackColor = true;
            this.deleteSheetButton.Click += new System.EventHandler(this.deleteSheetButton_Click);
            // 
            // decreaseSheetIndexButton
            // 
            this.decreaseSheetIndexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.decreaseSheetIndexButton.Location = new System.Drawing.Point(12, 371);
            this.decreaseSheetIndexButton.Name = "decreaseSheetIndexButton";
            this.decreaseSheetIndexButton.Size = new System.Drawing.Size(32, 32);
            this.decreaseSheetIndexButton.TabIndex = 10;
            this.decreaseSheetIndexButton.Text = "<";
            this.decreaseSheetIndexButton.UseVisualStyleBackColor = true;
            this.decreaseSheetIndexButton.Click += new System.EventHandler(this.decreaseSheetIndexButton_Click);
            // 
            // increaseSheetIndexButton
            // 
            this.increaseSheetIndexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.increaseSheetIndexButton.Location = new System.Drawing.Point(143, 371);
            this.increaseSheetIndexButton.Name = "increaseSheetIndexButton";
            this.increaseSheetIndexButton.Size = new System.Drawing.Size(32, 32);
            this.increaseSheetIndexButton.TabIndex = 10;
            this.increaseSheetIndexButton.Text = ">";
            this.increaseSheetIndexButton.UseVisualStyleBackColor = true;
            this.increaseSheetIndexButton.Click += new System.EventHandler(this.increaseSheetIndexButton_Click);
            // 
            // moveSheetLabel
            // 
            this.moveSheetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveSheetLabel.AutoSize = true;
            this.moveSheetLabel.Location = new System.Drawing.Point(50, 377);
            this.moveSheetLabel.Name = "moveSheetLabel";
            this.moveSheetLabel.Size = new System.Drawing.Size(87, 20);
            this.moveSheetLabel.TabIndex = 11;
            this.moveSheetLabel.Text = "Move Sheet";
            // 
            // NexcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.moveSheetLabel);
            this.Controls.Add(this.increaseSheetIndexButton);
            this.Controls.Add(this.decreaseSheetIndexButton);
            this.Controls.Add(this.deleteSheetButton);
            this.Controls.Add(this.sheetComboBox);
            this.Controls.Add(this.addSheetIndexComboBox);
            this.Controls.Add(this.addSheetTextBox);
            this.Controls.Add(this.addSheetButton);
            this.Controls.Add(this.selectedCellComboBox);
            this.Controls.Add(this.sheetTabControl);
            this.Controls.Add(this.selectedCellTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.nexcelMenuStrip);
            this.MainMenuStrip = this.nexcelMenuStrip;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "NexcelForm";
            this.Text = "Nexcel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.nexcelMenuStrip.ResumeLayout(false);
            this.nexcelMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip nexcelMenuStrip;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox selectedCellTextBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl sheetTabControl;
        private System.Windows.Forms.ComboBox selectedCellComboBox;
        private System.Windows.Forms.Button addSheetButton;
        private System.Windows.Forms.TextBox addSheetTextBox;
        private System.Windows.Forms.ComboBox addSheetIndexComboBox;
        private System.Windows.Forms.ComboBox sheetComboBox;
        private System.Windows.Forms.Button deleteSheetButton;
        private System.Windows.Forms.Button decreaseSheetIndexButton;
        private System.Windows.Forms.Button increaseSheetIndexButton;
        private System.Windows.Forms.Label moveSheetLabel;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
    }
}

