namespace kardex
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboState3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.cboState1 = new System.Windows.Forms.ComboBox();
            this.cboState2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.lblMsg3 = new System.Windows.Forms.Label();
            this.lblMsg5 = new System.Windows.Forms.Label();
            this.lblMsg4 = new System.Windows.Forms.Label();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(337, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kardex";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese su nombre";
            // 
            // cboState3
            // 
            this.cboState3.FormattingEnabled = true;
            this.cboState3.Items.AddRange(new object[] {
            "1er semestre",
            "2do semestre",
            "3er semestre",
            "4to semestre",
            "5to semestre",
            "6to semestre",
            "7mo semestre",
            "8vo semestre",
            "9no semestre",
            "10mo semestre",
            "11vo semestre",
            "12vo semestre"});
            this.cboState3.Location = new System.Drawing.Point(326, 287);
            this.cboState3.Name = "cboState3";
            this.cboState3.Size = new System.Drawing.Size(214, 23);
            this.cboState3.TabIndex = 3;
            this.cboState3.SelectedIndexChanged += new System.EventHandler(this.cboState3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccion de semestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seleccione su ciclo escolar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ingrese el nombre de su carrera";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Seleccionar materias que este cursando";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(44, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Seleccione su grupo (turno)";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Calculo diferencial",
            "Calculo integral",
            "Calculo vectorial",
            "Ecuaciones diferenciales",
            "Mecanica clasica",
            "Quimica",
            "Taller de etica",
            "Fundamentos de investigacion",
            "Comunicacion humana",
            "Probabilidad estadistica",
            "Desarrollo sustentable",
            "Mediciones electricas",
            "Topicos selesctos de fisica",
            "Desarrollo humano",
            "Electromagnetismo",
            "Algebra lineal",
            "Fisica de semiconductores",
            "Programacion estructurada",
            "circuitos electricos l",
            "circuitos electricos ll",
            "Marco legal de la empresa",
            "Analisis numerico",
            "Diseno digital",
            "Programacion visual",
            "Diodos y transistores",
            "Diseno con transistores",
            "Teoria electromagnetica",
            "Maquinas electricas ",
            "Control l",
            "Control ll",
            "Control digital",
            "Fundamentos financieros",
            "Desarrollo profecional",
            "Microcontroladores",
            "Taller de investigacion l",
            "Taller de investigacion ll",
            "amplificadores operacionales",
            "Instrumentacion",
            "Optoelectronica",
            "Telecomunicaciones",
            "Controladores logicos programables",
            "Electronica de potencia ",
            "Administracion general",
            "Desarrollo y evaluacion de proyectos ",
            "Residencia "});
            this.checkedListBox2.Location = new System.Drawing.Point(324, 353);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(216, 166);
            this.checkedListBox2.TabIndex = 9;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // cboState1
            // 
            this.cboState1.FormattingEnabled = true;
            this.cboState1.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino"});
            this.cboState1.Location = new System.Drawing.Point(324, 134);
            this.cboState1.Name = "cboState1";
            this.cboState1.Size = new System.Drawing.Size(216, 23);
            this.cboState1.TabIndex = 10;
            this.cboState1.SelectedIndexChanged += new System.EventHandler(this.cboState1_SelectedIndexChanged);
            // 
            // cboState2
            // 
            this.cboState2.FormattingEnabled = true;
            this.cboState2.Items.AddRange(new object[] {
            "Agosto - Diciembre",
            "Enero - Junio"});
            this.cboState2.Location = new System.Drawing.Point(326, 186);
            this.cboState2.Name = "cboState2";
            this.cboState2.Size = new System.Drawing.Size(214, 23);
            this.cboState2.TabIndex = 10;
            this.cboState2.SelectedIndexChanged += new System.EventHandler(this.cboState2_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(326, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(794, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Datos del estudiante ";
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsg1.Location = new System.Drawing.Point(875, 78);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(13, 20);
            this.lblMsg1.TabIndex = 2;
            this.lblMsg1.Text = "-";
            // 
            // lblMsg3
            // 
            this.lblMsg3.AutoSize = true;
            this.lblMsg3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsg3.Location = new System.Drawing.Point(875, 179);
            this.lblMsg3.Name = "lblMsg3";
            this.lblMsg3.Size = new System.Drawing.Size(13, 20);
            this.lblMsg3.TabIndex = 2;
            this.lblMsg3.Text = "-";
            // 
            // lblMsg5
            // 
            this.lblMsg5.AutoSize = true;
            this.lblMsg5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsg5.Location = new System.Drawing.Point(875, 290);
            this.lblMsg5.Name = "lblMsg5";
            this.lblMsg5.Size = new System.Drawing.Size(13, 20);
            this.lblMsg5.TabIndex = 2;
            this.lblMsg5.Text = "-";
            // 
            // lblMsg4
            // 
            this.lblMsg4.AutoSize = true;
            this.lblMsg4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsg4.Location = new System.Drawing.Point(875, 236);
            this.lblMsg4.Name = "lblMsg4";
            this.lblMsg4.Size = new System.Drawing.Size(13, 20);
            this.lblMsg4.TabIndex = 2;
            this.lblMsg4.Text = "-";
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsg2.Location = new System.Drawing.Point(875, 123);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(13, 20);
            this.lblMsg2.TabIndex = 2;
            this.lblMsg2.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(503, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(765, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Materias seleccionadas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(765, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(765, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Turno:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(765, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Ciclo escolar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(765, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Carrera";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(765, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Semestre:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(768, 401);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 169);
            this.listBox1.TabIndex = 13;
            this.listBox1.Tag = ".";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 608);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMsg2);
            this.Controls.Add(this.lblMsg4);
            this.Controls.Add(this.lblMsg5);
            this.Controls.Add(this.lblMsg3);
            this.Controls.Add(this.lblMsg1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cboState2);
            this.Controls.Add(this.cboState1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboState3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboState3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.ComboBox cboState1;
        private System.Windows.Forms.ComboBox cboState2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.Label lblMsg3;
        private System.Windows.Forms.Label lblMsg5;
        private System.Windows.Forms.Label lblMsg4;
        private System.Windows.Forms.Label lblMsg2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label label9;
    }
}

