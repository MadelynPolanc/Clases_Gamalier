namespace MadelynDesafio_3
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
            txtCliente = new TextBox();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lbox_reserva = new ListBox();
            DateTimeEntrada = new DateTimePicker();
            DateTimeSalida = new DateTimePicker();
            cmbTipoHab = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 25);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 0;
            label1.Text = "Gestion de reservas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 57);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 117);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha_Entrada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 178);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha_Salida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 239);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 4;
            label5.Text = "Tipo_habitacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 294);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 5;
            label6.Text = "Precio";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.White;
            txtCliente.Location = new Point(35, 75);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(228, 23);
            txtCliente.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.Location = new Point(35, 312);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(228, 23);
            txtPrecio.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Aquamarine;
            btnAgregar.Location = new Point(328, 75);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Aquamarine;
            btnEliminar.Location = new Point(328, 152);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Aquamarine;
            btnLimpiar.Location = new Point(328, 235);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Aquamarine;
            btnSalir.Location = new Point(328, 311);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lbox_reserva
            // 
            lbox_reserva.FormattingEnabled = true;
            lbox_reserva.ItemHeight = 15;
            lbox_reserva.Location = new Point(68, 359);
            lbox_reserva.Name = "lbox_reserva";
            lbox_reserva.Size = new Size(286, 109);
            lbox_reserva.TabIndex = 16;
            // 
            // DateTimeEntrada
            // 
            DateTimeEntrada.CalendarMonthBackground = Color.White;
            DateTimeEntrada.Location = new Point(35, 135);
            DateTimeEntrada.Name = "DateTimeEntrada";
            DateTimeEntrada.Size = new Size(228, 23);
            DateTimeEntrada.TabIndex = 17;
            // 
            // DateTimeSalida
            // 
            DateTimeSalida.Location = new Point(35, 196);
            DateTimeSalida.Name = "DateTimeSalida";
            DateTimeSalida.Size = new Size(228, 23);
            DateTimeSalida.TabIndex = 18;
            // 
            // cmbTipoHab
            // 
            cmbTipoHab.BackColor = Color.White;
            cmbTipoHab.FormattingEnabled = true;
            cmbTipoHab.Items.AddRange(new object[] { "Individual", "Suit", "Familiar" });
            cmbTipoHab.Location = new Point(35, 257);
            cmbTipoHab.Name = "cmbTipoHab";
            cmbTipoHab.Size = new Size(228, 23);
            cmbTipoHab.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 493);
            Controls.Add(cmbTipoHab);
            Controls.Add(DateTimeSalida);
            Controls.Add(DateTimeEntrada);
            Controls.Add(lbox_reserva);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCliente);
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
        private TextBox txtCliente;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnSalir;
        private ListBox lbox_reserva;
        private DateTimePicker DateTimeEntrada;
        private DateTimePicker DateTimeSalida;
        private ComboBox cmbTipoHab;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
