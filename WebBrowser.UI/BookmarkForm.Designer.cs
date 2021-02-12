
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
            this.SuspendLayout();
            // 
            // bookmarkListBox
            // 
            this.bookmarkListBox.FormattingEnabled = true;
            this.bookmarkListBox.ItemHeight = 20;
            this.bookmarkListBox.Location = new System.Drawing.Point(419, 103);
            this.bookmarkListBox.Name = "bookmarkListBox";
            this.bookmarkListBox.Size = new System.Drawing.Size(369, 244);
            this.bookmarkListBox.TabIndex = 0;
            // 
            // BookmarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookmarkListBox);
            this.Name = "BookmarkForm";
            this.Text = "BookmarkForm";
            this.Load += new System.EventHandler(this.BookmarkForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox bookmarkListBox;
    }
}