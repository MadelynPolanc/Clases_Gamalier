namespace Madelyn_desafio1
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNombre = new TextBox();
            txtCargo = new TextBox();
            txtSueldo = new TextBox();
            txtHijos = new TextBox();
            txtAFP = new TextBox();
            txtSFS = new TextBox();
            txtISR = new TextBox();
            txtnumHijos = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label11 = new Label();
            txtSueldoNETO = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 23);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Sueldo Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 62);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 98);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Cargo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 137);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Sueldo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 178);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 4;
            label5.Text = "Hijos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 23);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 5;
            label6.Text = "Total Sueldo Incentivo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 62);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 6;
            label7.Text = "AFP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(345, 98);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 7;
            label8.Text = "SFS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(347, 137);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 8;
            label9.Text = "ISR";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(345, 178);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 9;
            label10.Text = "Otros";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(148, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 13;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(148, 98);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 14;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(148, 137);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(100, 23);
            txtSueldo.TabIndex = 15;
            // 
            // txtHijos
            // 
            txtHijos.Location = new Point(148, 178);
            txtHijos.Name = "txtHijos";
            txtHijos.Size = new Size(100, 23);
            txtHijos.TabIndex = 16;
            // 
            // txtAFP
            // 
            txtAFP.Location = new Point(429, 59);
            txtAFP.Name = "txtAFP";
            txtAFP.Size = new Size(100, 23);
            txtAFP.TabIndex = 17;
            txtAFP.TextChanged += txtAFP_TextChanged;
            // 
            // txtSFS
            // 
            txtSFS.Location = new Point(429, 95);
            txtSFS.Name = "txtSFS";
            txtSFS.Size = new Size(100, 23);
            txtSFS.TabIndex = 18;
            // 
            // txtISR
            // 
            txtISR.Location = new Point(429, 134);
            txtISR.Name = "txtISR";
            txtISR.Size = new Size(100, 23);
            txtISR.TabIndex = 19;
            // 
            // txtnumHijos
            // 
            txtnumHijos.Location = new Point(429, 175);
            txtnumHijos.Name = "txtnumHijos";
            txtnumHijos.Size = new Size(100, 23);
            txtnumHijos.TabIndex = 20;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(117, 234);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 21;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(276, 234);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(443, 234);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(201, 338);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 24;
            label11.Text = "Sueldo Neto";
            // 
            // txtSueldoNETO
            // 
            txtSueldoNETO.Location = new Point(345, 330);
            txtSueldoNETO.Name = "txtSueldoNETO";
            txtSueldoNETO.Size = new Size(100, 23);
            txtSueldoNETO.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSueldoNETO);
            Controls.Add(label11);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtnumHijos);
            Controls.Add(txtISR);
            Controls.Add(txtSFS);
            Controls.Add(txtAFP);
            Controls.Add(txtHijos);
            Controls.Add(txtSueldo);
            Controls.Add(txtCargo);
            Controls.Add(txtNombre);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtNombre;
        private TextBox txtCargo;
        private TextBox txtSueldo;
        private TextBox txtHijos;
        private TextBox txtAFP;
        private TextBox txtSFS;
        private TextBox txtISR;
        private TextBox txtnumHijos;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label11;
        private TextBox txtSueldoNETO;
    }
}
