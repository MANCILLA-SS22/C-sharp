namespace CheckedListBox
{
    partial class Form1
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnGetItem = new System.Windows.Forms.Button();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetIndex = new System.Windows.Forms.Button();
            this.listBoxIndex = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "C",
            "C++",
            "C#",
            "Python",
            "Java",
            "PHP",
            "Ruby",
            "HTML"});
            this.checkedListBox1.Location = new System.Drawing.Point(36, 58);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(336, 256);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnGetItem
            // 
            this.btnGetItem.Location = new System.Drawing.Point(37, 358);
            this.btnGetItem.Name = "btnGetItem";
            this.btnGetItem.Size = new System.Drawing.Size(149, 45);
            this.btnGetItem.TabIndex = 1;
            this.btnGetItem.Text = "Get Item";
            this.btnGetItem.UseVisualStyleBackColor = true;
            this.btnGetItem.Click += new System.EventHandler(this.btnGetItem_Click);
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.ItemHeight = 15;
            this.listBoxItem.Location = new System.Drawing.Point(37, 409);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(180, 124);
            this.listBoxItem.TabIndex = 2;
            this.listBoxItem.SelectedIndexChanged += new System.EventHandler(this.listBoxItem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Programming Languages";
            // 
            // btnGetIndex
            // 
            this.btnGetIndex.Location = new System.Drawing.Point(223, 358);
            this.btnGetIndex.Name = "btnGetIndex";
            this.btnGetIndex.Size = new System.Drawing.Size(149, 45);
            this.btnGetIndex.TabIndex = 1;
            this.btnGetIndex.Text = "Get Index";
            this.btnGetIndex.UseVisualStyleBackColor = true;
            this.btnGetIndex.Click += new System.EventHandler(this.btnGetIndex_Click);
            // 
            // listBoxIndex
            // 
            this.listBoxIndex.FormattingEnabled = true;
            this.listBoxIndex.ItemHeight = 15;
            this.listBoxIndex.Location = new System.Drawing.Point(223, 409);
            this.listBoxIndex.Name = "listBoxIndex";
            this.listBoxIndex.Size = new System.Drawing.Size(180, 124);
            this.listBoxIndex.TabIndex = 2;
            this.listBoxIndex.SelectedIndexChanged += new System.EventHandler(this.listBoxIndex_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 570);
            this.Controls.Add(this.listBoxIndex);
            this.Controls.Add(this.btnGetIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.btnGetItem);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnGetItem;
        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetIndex;
        private System.Windows.Forms.ListBox listBoxIndex;
    }
}

