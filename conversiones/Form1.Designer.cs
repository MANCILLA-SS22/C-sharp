namespace conversiones
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.cbConvertFrom = new System.Windows.Forms.ComboBox();
            this.lblConvertedAmount = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbConverTo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convert form";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Convert to";
            // 
            // txtEnter
            // 
            this.txtEnter.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter.Location = new System.Drawing.Point(208, 107);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(133, 25);
            this.txtEnter.TabIndex = 4;
            // 
            // cbConvertFrom
            // 
            this.cbConvertFrom.FormattingEnabled = true;
            this.cbConvertFrom.Items.AddRange(new object[] {
            "Pesos",
            "Dollar",
            "Euro"});
            this.cbConvertFrom.Location = new System.Drawing.Point(205, 173);
            this.cbConvertFrom.Name = "cbConvertFrom";
            this.cbConvertFrom.Size = new System.Drawing.Size(133, 21);
            this.cbConvertFrom.TabIndex = 5;
            // 
            // lblConvertedAmount
            // 
            this.lblConvertedAmount.AutoSize = true;
            this.lblConvertedAmount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertedAmount.Location = new System.Drawing.Point(125, 343);
            this.lblConvertedAmount.Name = "lblConvertedAmount";
            this.lblConvertedAmount.Size = new System.Drawing.Size(123, 17);
            this.lblConvertedAmount.TabIndex = 7;
            this.lblConvertedAmount.Text = "Converted amount: ";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(387, 107);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(102, 25);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cbConverTo
            // 
            this.cbConverTo.FormattingEnabled = true;
            this.cbConverTo.Items.AddRange(new object[] {
            "Pesos",
            "Dollar",
            "Euro"});
            this.cbConverTo.Location = new System.Drawing.Point(205, 241);
            this.cbConverTo.Name = "cbConverTo";
            this.cbConverTo.Size = new System.Drawing.Size(133, 21);
            this.cbConverTo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.cbConverTo);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblConvertedAmount);
            this.Controls.Add(this.cbConvertFrom);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.ComboBox cbConvertFrom;
        private System.Windows.Forms.Label lblConvertedAmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cbConverTo;
    }
}

