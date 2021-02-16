
namespace WebBrowser.UI
{
    partial class BookmarkForm
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
            this.bookmarkListBox = new System.Windows.Forms.ListBox();
            this.bookSearchTextBox = new System.Windows.Forms.TextBox();
            this.bookSearchButton = new System.Windows.Forms.Button();
            this.bookDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookmarkListBox
            // 
            this.bookmarkListBox.FormattingEnabled = true;
            this.bookmarkListBox.ItemHeight = 20;
            this.bookmarkListBox.Location = new System.Drawing.Point(495, 235);
            this.bookmarkListBox.Name = "bookmarkListBox";
            this.bookmarkListBox.Size = new System.Drawing.Size(369, 244);
            this.bookmarkListBox.TabIndex = 0;
            // 
            // bookSearchTextBox
            // 
            this.bookSearchTextBox.Location = new System.Drawing.Point(94, 88);
            this.bookSearchTextBox.Multiline = true;
            this.bookSearchTextBox.Name = "bookSearchTextBox";
            this.bookSearchTextBox.Size = new System.Drawing.Size(276, 44);
            this.bookSearchTextBox.TabIndex = 1;
            // 
            // bookSearchButton
            // 
            this.bookSearchButton.Location = new System.Drawing.Point(94, 235);
            this.bookSearchButton.Name = "bookSearchButton";
            this.bookSearchButton.Size = new System.Drawing.Size(75, 35);
            this.bookSearchButton.TabIndex = 2;
            this.bookSearchButton.Text = "Search";
            this.bookSearchButton.UseVisualStyleBackColor = true;
            this.bookSearchButton.Click += new System.EventHandler(this.bookSearchButton_Click);
            // 
            // bookDeleteButton
            // 
            this.bookDeleteButton.Location = new System.Drawing.Point(94, 329);
            this.bookDeleteButton.Name = "bookDeleteButton";
            this.bookDeleteButton.Size = new System.Drawing.Size(75, 36);
            this.bookDeleteButton.TabIndex = 3;
            this.bookDeleteButton.Text = "Delete";
            this.bookDeleteButton.UseVisualStyleBackColor = true;
            this.bookDeleteButton.Click += new System.EventHandler(this.bookDeleteButton_Click);
            // 
            // BookmarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 583);
            this.Controls.Add(this.bookDeleteButton);
            this.Controls.Add(this.bookSearchButton);
            this.Controls.Add(this.bookSearchTextBox);
            this.Controls.Add(this.bookmarkListBox);
            this.Name = "BookmarkForm";
            this.Text = "BookmarkForm";
            this.Load += new System.EventHandler(this.BookmarkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bookmarkListBox;
        private System.Windows.Forms.TextBox bookSearchTextBox;
        private System.Windows.Forms.Button bookSearchButton;
        private System.Windows.Forms.Button bookDeleteButton;
    }
}