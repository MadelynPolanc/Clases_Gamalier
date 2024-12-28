namespace Madelyn_PruebaTecnica3
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtSueldo_Neto = new TextBox();
            txtTotal_Descuentos = new TextBox();
            txtISR = new TextBox();
            txtSFS = new TextBox();
            txtAFP = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtSueldo_Ingreso = new TextBox();
            txtHijos = new TextBox();
            txtSueldo = new TextBox();
            txtCargo = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Hijos = new DataGridViewTextBoxColumn();
            Sueldo_Neto = new DataGridViewTextBoxColumn();
            Total_Deduciones = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            btnCalcular = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(749, 373);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtSueldo_Neto);
            tabPage1.Controls.Add(txtTotal_Descuentos);
            tabPage1.Controls.Add(txtISR);
            tabPage1.Controls.Add(txtSFS);
            tabPage1.Controls.Add(txtAFP);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtSueldo_Ingreso);
            tabPage1.Controls.Add(txtHijos);
            tabPage1.Controls.Add(txtSueldo);
            tabPage1.Controls.Add(txtCargo);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(741, 345);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSueldo_Neto
            // 
            txtSueldo_Neto.Location = new Point(483, 226);
            txtSueldo_Neto.Name = "txtSueldo_Neto";
            txtSueldo_Neto.Size = new Size(100, 23);
            txtSueldo_Neto.TabIndex = 19;
            // 
            // txtTotal_Descuentos
            // 
            txtTotal_Descuentos.Location = new Point(483, 180);
            txtTotal_Descuentos.Name = "txtTotal_Descuentos";
            txtTotal_Descuentos.Size = new Size(100, 23);
            txtTotal_Descuentos.TabIndex = 18;
            // 
            // txtISR
            // 
            txtISR.Location = new Point(483, 126);
            txtISR.Name = "txtISR";
            txtISR.Size = new Size(100, 23);
            txtISR.TabIndex = 17;
            // 
            // txtSFS
            // 
            txtSFS.Location = new Point(483, 79);
            txtSFS.Name = "txtSFS";
            txtSFS.Size = new Size(100, 23);
            txtSFS.TabIndex = 16;
            // 
            // txtAFP
            // 
            txtAFP.Location = new Point(483, 42);
            txtAFP.Name = "txtAFP";
            txtAFP.Size = new Size(100, 23);
            txtAFP.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(390, 234);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 14;
            label10.Text = "Sueldo_Neto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(379, 183);
            label9.Name = "label9";
            label9.Size = new Size(98, 15);
            label9.TabIndex = 13;
            label9.Text = "Total_Descuentos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(416, 134);
            label8.Name = "label8";
            label8.Size = new Size(23, 15);
            label8.TabIndex = 12;
            label8.Text = "ISR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 79);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 11;
            label7.Text = "SFS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 41);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 10;
            label6.Text = "AFP";
            // 
            // txtSueldo_Ingreso
            // 
            txtSueldo_Ingreso.Location = new Point(154, 226);
            txtSueldo_Ingreso.Name = "txtSueldo_Ingreso";
            txtSueldo_Ingreso.Size = new Size(100, 23);
            txtSueldo_Ingreso.TabIndex = 9;
            // 
            // txtHijos
            // 
            txtHijos.Location = new Point(154, 180);
            txtHijos.Name = "txtHijos";
            txtHijos.Size = new Size(100, 23);
            txtHijos.TabIndex = 8;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(154, 126);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(100, 23);
            txtSueldo.TabIndex = 7;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(154, 76);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(154, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 234);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 4;
            label5.Text = "Sueldo + Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 188);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Hijos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 134);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Sueldo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 79);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Cargo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(741, 345);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Cargo, Hijos, Sueldo_Neto, Total_Deduciones });
            dataGridView1.Location = new Point(35, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(668, 336);
            dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            Cargo.Width = 125;
            // 
            // Hijos
            // 
            Hijos.HeaderText = "Hijos";
            Hijos.Name = "Hijos";
            Hijos.Width = 125;
            // 
            // Sueldo_Neto
            // 
            Sueldo_Neto.HeaderText = "Sueldo_Neto";
            Sueldo_Neto.Name = "Sueldo_Neto";
            Sueldo_Neto.Width = 125;
            // 
            // Total_Deduciones
            // 
            Total_Deduciones.HeaderText = "Total_Deduciones";
            Total_Deduciones.Name = "Total_Deduciones";
            Total_Deduciones.Width = 125;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(51, 436);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(145, 436);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(248, 436);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(418, 436);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(524, 436);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(615, 436);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 509);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCalcular);
            Controls.Add(btnGuardar);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtSueldo_Ingreso;
        private TextBox txtHijos;
        private TextBox txtSueldo;
        private TextBox txtCargo;
        private TextBox txtSueldo_Neto;
        private TextBox txtTotal_Descuentos;
        private TextBox txtISR;
        private TextBox txtSFS;
        private TextBox txtAFP;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnGuardar;
        private Button btnCalcular;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Hijos;
        private DataGridViewTextBoxColumn Sueldo_Neto;
        private DataGridViewTextBoxColumn Total_Deduciones;
    }
}
