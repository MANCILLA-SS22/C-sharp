namespace ComboBox_x2
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
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.txtbMaterias = new System.Windows.Forms.TextBox();
            this.btmMaterias = new System.Windows.Forms.Button();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Items.AddRange(new object[] {
            "Programacion Visual",
            "Fisica de semiconductores",
            "Maquinas electricas",
            "Mecanica clasica"});
            this.cmbMaterias.Location = new System.Drawing.Point(139, 73);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(212, 23);
            this.cmbMaterias.TabIndex = 0;
            this.cmbMaterias.Text = "Materias";
            this.cmbMaterias.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbMaterias.BackColorChanged += new System.EventHandler(this.cmbDeportes_BackColorChanged);
            // 
            // txtbMaterias
            // 
            this.txtbMaterias.Location = new System.Drawing.Point(42, 186);
            this.txtbMaterias.Name = "txtbMaterias";
            this.txtbMaterias.Size = new System.Drawing.Size(133, 23);
            this.txtbMaterias.TabIndex = 1;
            this.txtbMaterias.TextChanged += new System.EventHandler(this.txtbDeportes_TextChanged);
            // 
            // btmMaterias
            // 
            this.btmMaterias.Location = new System.Drawing.Point(297, 186);
            this.btmMaterias.Name = "btmMaterias";
            this.btmMaterias.Size = new System.Drawing.Size(114, 29);
            this.btmMaterias.TabIndex = 2;
            this.btmMaterias.Text = "Presionar";
            this.btmMaterias.UseVisualStyleBackColor = true;
            this.btmMaterias.Click += new System.EventHandler(this.btmDeportes_Click);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(42, 124);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(110, 15);
            this.lblIndice.TabIndex = 3;
            this.lblIndice.Text = "Numero de materia";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(297, 124);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(38, 15);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 317);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.btmMaterias);
            this.Controls.Add(this.txtbMaterias);
            this.Controls.Add(this.cmbMaterias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.TextBox txtbMaterias;
        private System.Windows.Forms.Button btmMaterias;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lblTexto;
    }
}

