
namespace WebBrowser.UI
{
    partial class HistoryForm
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
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.histSearchBox = new System.Windows.Forms.TextBox();
            this.histSearchButton = new System.Windows.Forms.Button();
            this.histDeleteButton = new System.Windows.Forms.Button();
            this.histClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyListBox
            // 
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 20;
            this.historyListBox.Location = new System.Drawing.Point(487, 214);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(482, 304);
            this.historyListBox.TabIndex = 0;
            // 
            // histSearchBox
            // 
            this.histSearchBox.Location = new System.Drawing.Point(108, 82);
            this.histSearchBox.Multiline = true;
            this.histSearchBox.Name = "histSearchBox";
            this.histSearchBox.Size = new System.Drawing.Size(407, 47);
            this.histSearchBox.TabIndex = 1;
            // 
            // histSearchButton
            // 
            this.histSearchButton.Location = new System.Drawing.Point(108, 214);
            this.histSearchButton.Name = "histSearchButton";
            this.histSearchButton.Size = new System.Drawing.Size(75, 41);
            this.histSearchButton.TabIndex = 2;
            this.histSearchButton.Text = "Search";
            this.histSearchButton.UseVisualStyleBackColor = true;
            this.histSearchButton.Click += new System.EventHandler(this.histSearchButton_Click);
            // 
            // histDeleteButton
            // 
            this.histDeleteButton.Location = new System.Drawing.Point(108, 343);
            this.histDeleteButton.Name = "histDeleteButton";
            this.histDeleteButton.Size = new System.Drawing.Size(75, 38);
            this.histDeleteButton.TabIndex = 3;
            this.histDeleteButton.Text = "Delete";
            this.histDeleteButton.UseVisualStyleBackColor = true;
            this.histDeleteButton.Click += new System.EventHandler(this.histDeleteButton_Click);
            // 
            // histClearButton
            // 
            this.histClearButton.Location = new System.Drawing.Point(108, 480);
            this.histClearButton.Name = "histClearButton";
            this.histClearButton.Size = new System.Drawing.Size(75, 38);
            this.histClearButton.TabIndex = 4;
            this.histClearButton.Text = "Clear";
            this.histClearButton.UseVisualStyleBackColor = true;
            this.histClearButton.Click += new System.EventHandler(this.histClearButton_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 590);
            this.Controls.Add(this.histClearButton);
            this.Controls.Add(this.histDeleteButton);
            this.Controls.Add(this.histSearchButton);
            this.Controls.Add(this.histSearchBox);
            this.Controls.Add(this.historyListBox);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.TextBox histSearchBox;
        private System.Windows.Forms.Button histSearchButton;
        private System.Windows.Forms.Button histDeleteButton;
        private System.Windows.Forms.Button histClearButton;
    }
}