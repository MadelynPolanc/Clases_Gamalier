namespace MadelynDesafio_2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            cboCurso = new ComboBox();
            cboSeccion = new ComboBox();
            cboArea = new ComboBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            txtN3 = new TextBox();
            txtN4 = new TextBox();
            txtPromedio = new TextBox();
            label11 = new Label();
            txtCondicion = new TextBox();
            btnL = new Button();
            btnC = new Button();
            btnS = new Button();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(49, 63);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(50, 94);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 1;
            label2.Text = "Curso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(49, 131);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 2;
            label3.Text = "Seccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(50, 169);
            label4.Name = "label4";
            label4.Size = new Size(36, 17);
            label4.TabIndex = 3;
            label4.Text = "Area";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // cboCurso
            // 
            cboCurso.BackColor = Color.White;
            cboCurso.FormattingEnabled = true;
            cboCurso.Items.AddRange(new object[] { "4to", "5to", "6to" });
            cboCurso.Location = new Point(146, 86);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new Size(121, 23);
            cboCurso.TabIndex = 5;
            // 
            // cboSeccion
            // 
            cboSeccion.BackColor = Color.White;
            cboSeccion.FormattingEnabled = true;
            cboSeccion.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cboSeccion.Location = new Point(146, 123);
            cboSeccion.Name = "cboSeccion";
            cboSeccion.Size = new Size(121, 23);
            cboSeccion.TabIndex = 6;
            // 
            // cboArea
            // 
            cboArea.BackColor = Color.White;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Enfermeria", "Informatica", "Gastronomia", "Electricidad", "Contabilidad" });
            cboArea.Location = new Point(146, 161);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(121, 23);
            cboArea.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(49, 212);
            label5.Name = "label5";
            label5.Size = new Size(37, 17);
            label5.TabIndex = 8;
            label5.Text = "Sexo";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(127, 210);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(38, 21);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "M";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(228, 208);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(33, 21);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "F";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(47, 277);
            label6.Name = "label6";
            label6.Size = new Size(25, 17);
            label6.TabIndex = 11;
            label6.Text = "N1";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(181, 277);
            label7.Name = "label7";
            label7.Size = new Size(25, 17);
            label7.TabIndex = 12;
            label7.Text = "N2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(47, 353);
            label8.Name = "label8";
            label8.Size = new Size(25, 17);
            label8.TabIndex = 13;
            label8.Text = "N3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.Location = new Point(181, 353);
            label9.Name = "label9";
            label9.Size = new Size(25, 17);
            label9.TabIndex = 14;
            label9.Text = "N4";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(-1, 426);
            label10.Name = "label10";
            label10.Size = new Size(68, 17);
            label10.TabIndex = 15;
            label10.Text = "Promedio";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(75, 277);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(35, 23);
            txtN1.TabIndex = 16;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(209, 277);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(35, 23);
            txtN2.TabIndex = 17;
            // 
            // txtN3
            // 
            txtN3.Location = new Point(75, 350);
            txtN3.Name = "txtN3";
            txtN3.Size = new Size(35, 23);
            txtN3.TabIndex = 18;
            // 
            // txtN4
            // 
            txtN4.Location = new Point(209, 350);
            txtN4.Name = "txtN4";
            txtN4.Size = new Size(35, 23);
            txtN4.TabIndex = 19;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(64, 423);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(88, 23);
            txtPromedio.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(181, 426);
            label11.Name = "label11";
            label11.Size = new Size(70, 17);
            label11.TabIndex = 21;
            label11.Text = "Condicion";
            // 
            // txtCondicion
            // 
            txtCondicion.Location = new Point(256, 423);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(100, 23);
            txtCondicion.TabIndex = 22;
            // 
            // btnL
            // 
            btnL.Location = new Point(34, 500);
            btnL.Name = "btnL";
            btnL.Size = new Size(75, 23);
            btnL.TabIndex = 23;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = true;
            btnL.Click += btnL_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(146, 500);
            btnC.Name = "btnC";
            btnC.Size = new Size(75, 23);
            btnC.TabIndex = 24;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnS
            // 
            btnS.Location = new Point(256, 500);
            btnS.Name = "btnS";
            btnS.Size = new Size(75, 23);
            btnS.TabIndex = 25;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = true;
            btnS.Click += btnS_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(64, 19);
            label12.Name = "label12";
            label12.Size = new Size(232, 21);
            label12.TabIndex = 26;
            label12.Text = "Calculadora de calificaciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 535);
            Controls.Add(label12);
            Controls.Add(btnS);
            Controls.Add(btnC);
            Controls.Add(btnL);
            Controls.Add(txtCondicion);
            Controls.Add(label11);
            Controls.Add(txtPromedio);
            Controls.Add(txtN4);
            Controls.Add(txtN3);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(cboArea);
            Controls.Add(cboSeccion);
            Controls.Add(cboCurso);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private ComboBox cboCurso;
        private ComboBox cboSeccion;
        private ComboBox cboArea;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox txtN3;
        private TextBox txtN4;
        private TextBox txtPromedio;
        private Label label11;
        private TextBox txtCondicion;
        private Button btnL;
        private Button btnC;
        private Button btnS;
        private Label label12;
    }
}
