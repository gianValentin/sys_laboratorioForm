namespace Sys_Laboratorio
{
    partial class frmNuevaAtencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaAtencion));
            this.gbxDatosPaciente = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPacientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCodigoAtencion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxTipoExamen = new System.Windows.Forms.ComboBox();
            this.lblExamen = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaExamen = new System.Windows.Forms.DateTimePicker();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGuargarDatos = new System.Windows.Forms.Button();
            this.gbxPacientesRegistrados = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBusquedaApellido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBusquedaNombre = new System.Windows.Forms.TextBox();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbxDatosPaciente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.gbxPacientesRegistrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatosPaciente
            // 
            this.gbxDatosPaciente.Controls.Add(this.dtpFechaNacimiento);
            this.gbxDatosPaciente.Controls.Add(this.label5);
            this.gbxDatosPaciente.Controls.Add(this.cbxGenero);
            this.gbxDatosPaciente.Controls.Add(this.label4);
            this.gbxDatosPaciente.Controls.Add(this.txtApellidos);
            this.gbxDatosPaciente.Controls.Add(this.label3);
            this.gbxDatosPaciente.Controls.Add(this.txtNombres);
            this.gbxDatosPaciente.Controls.Add(this.label2);
            this.gbxDatosPaciente.Controls.Add(this.txtIdPaciente);
            this.gbxDatosPaciente.Controls.Add(this.label1);
            this.gbxDatosPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosPaciente.Location = new System.Drawing.Point(12, 98);
            this.gbxDatosPaciente.Name = "gbxDatosPaciente";
            this.gbxDatosPaciente.Size = new System.Drawing.Size(438, 172);
            this.gbxDatosPaciente.TabIndex = 0;
            this.gbxDatosPaciente.TabStop = false;
            this.gbxDatosPaciente.Text = "Datos de Paciente";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(133, 141);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(119, 21);
            this.dtpFechaNacimiento.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // cbxGenero
            // 
            this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbxGenero.Location = new System.Drawing.Point(133, 112);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(164, 23);
            this.cbxGenero.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Género:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(133, 82);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(164, 21);
            this.txtApellidos.TabIndex = 5;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(133, 53);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(164, 21);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(133, 26);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.ReadOnly = true;
            this.txtIdPaciente.Size = new System.Drawing.Size(93, 21);
            this.txtIdPaciente.TabIndex = 1;
            this.txtIdPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Paciente:";
            // 
            // lstPacientes
            // 
            this.lstPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstPacientes.FullRowSelect = true;
            this.lstPacientes.GridLines = true;
            this.lstPacientes.Location = new System.Drawing.Point(10, 46);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(475, 157);
            this.lstPacientes.TabIndex = 1;
            this.lstPacientes.UseCompatibleStateImageBehavior = false;
            this.lstPacientes.View = System.Windows.Forms.View.Details;
            this.lstPacientes.SelectedIndexChanged += new System.EventHandler(this.lstPacientes_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombres";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellidos";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Género";
            this.columnHeader4.Width = 74;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "F Nacimiento";
            this.columnHeader5.Width = 79;
            // 
            // lblCodigoAtencion
            // 
            this.lblCodigoAtencion.AutoSize = true;
            this.lblCodigoAtencion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAtencion.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblCodigoAtencion.Location = new System.Drawing.Point(202, 19);
            this.lblCodigoAtencion.Name = "lblCodigoAtencion";
            this.lblCodigoAtencion.Size = new System.Drawing.Size(203, 25);
            this.lblCodigoAtencion.TabIndex = 4;
            this.lblCodigoAtencion.Text = "lblCodigoAtencion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Codigo Atencion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tipo de Examen:";
            // 
            // cbxTipoExamen
            // 
            this.cbxTipoExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoExamen.FormattingEnabled = true;
            this.cbxTipoExamen.Location = new System.Drawing.Point(207, 289);
            this.cbxTipoExamen.Name = "cbxTipoExamen";
            this.cbxTipoExamen.Size = new System.Drawing.Size(343, 21);
            this.cbxTipoExamen.TabIndex = 11;
            this.cbxTipoExamen.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblExamen
            // 
            this.lblExamen.AutoSize = true;
            this.lblExamen.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamen.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblExamen.Location = new System.Drawing.Point(128, 16);
            this.lblExamen.Name = "lblExamen";
            this.lblExamen.Size = new System.Drawing.Size(119, 25);
            this.lblExamen.TabIndex = 13;
            this.lblExamen.Text = "lblExamen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Examen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFechaExamen);
            this.groupBox2.Controls.Add(this.ptbImagen);
            this.groupBox2.Controls.Add(this.pnlControl);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblExamen);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(939, 505);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Examen";
            // 
            // dtpFechaExamen
            // 
            this.dtpFechaExamen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaExamen.Location = new System.Drawing.Point(133, 58);
            this.dtpFechaExamen.Name = "dtpFechaExamen";
            this.dtpFechaExamen.Size = new System.Drawing.Size(119, 21);
            this.dtpFechaExamen.TabIndex = 11;
            // 
            // ptbImagen
            // 
            this.ptbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbImagen.Location = new System.Drawing.Point(561, 56);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(343, 443);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImagen.TabIndex = 53;
            this.ptbImagen.TabStop = false;
            // 
            // pnlControl
            // 
            this.pnlControl.AutoScroll = true;
            this.pnlControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlControl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlControl.Location = new System.Drawing.Point(46, 114);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(492, 341);
            this.pnlControl.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Fecha";
            // 
            // btnGuargarDatos
            // 
            this.btnGuargarDatos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuargarDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnGuargarDatos.Image")));
            this.btnGuargarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuargarDatos.Location = new System.Drawing.Point(828, 827);
            this.btnGuargarDatos.Name = "btnGuargarDatos";
            this.btnGuargarDatos.Size = new System.Drawing.Size(113, 44);
            this.btnGuargarDatos.TabIndex = 17;
            this.btnGuargarDatos.Text = "Guardar";
            this.btnGuargarDatos.UseVisualStyleBackColor = true;
            this.btnGuargarDatos.Click += new System.EventHandler(this.btnGuargarDatos_Click);
            // 
            // gbxPacientesRegistrados
            // 
            this.gbxPacientesRegistrados.Controls.Add(this.label12);
            this.gbxPacientesRegistrados.Controls.Add(this.txtBusquedaApellido);
            this.gbxPacientesRegistrados.Controls.Add(this.label10);
            this.gbxPacientesRegistrados.Controls.Add(this.txtBusquedaNombre);
            this.gbxPacientesRegistrados.Controls.Add(this.lstPacientes);
            this.gbxPacientesRegistrados.Location = new System.Drawing.Point(456, 61);
            this.gbxPacientesRegistrados.Name = "gbxPacientesRegistrados";
            this.gbxPacientesRegistrados.Size = new System.Drawing.Size(495, 208);
            this.gbxPacientesRegistrados.TabIndex = 18;
            this.gbxPacientesRegistrados.TabStop = false;
            this.gbxPacientesRegistrados.Text = "Pacientes Registrados";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Apellidos:";
            // 
            // txtBusquedaApellido
            // 
            this.txtBusquedaApellido.Location = new System.Drawing.Point(264, 19);
            this.txtBusquedaApellido.Name = "txtBusquedaApellido";
            this.txtBusquedaApellido.Size = new System.Drawing.Size(123, 20);
            this.txtBusquedaApellido.TabIndex = 4;
            this.txtBusquedaApellido.TextChanged += new System.EventHandler(this.txtBusquedaApellido_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nombres:";
            // 
            // txtBusquedaNombre
            // 
            this.txtBusquedaNombre.Location = new System.Drawing.Point(71, 19);
            this.txtBusquedaNombre.Name = "txtBusquedaNombre";
            this.txtBusquedaNombre.Size = new System.Drawing.Size(123, 20);
            this.txtBusquedaNombre.TabIndex = 2;
            this.txtBusquedaNombre.TextChanged += new System.EventHandler(this.txtBusquedaNombre_TextChanged);
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.Enabled = false;
            this.btnNuevoPaciente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPaciente.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNuevoPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoPaciente.Image")));
            this.btnNuevoPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPaciente.Location = new System.Drawing.Point(294, 61);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(156, 31);
            this.btnNuevoPaciente.TabIndex = 19;
            this.btnNuevoPaciente.Text = "Nuevo Paciente";
            this.btnNuevoPaciente.UseVisualStyleBackColor = true;
            this.btnNuevoPaciente.Click += new System.EventHandler(this.btnNuevoPaciente_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(12, 827);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 44);
            this.btnCerrar.TabIndex = 54;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmNuevaAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(972, 878);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevoPaciente);
            this.Controls.Add(this.gbxPacientesRegistrados);
            this.Controls.Add(this.btnGuargarDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbxTipoExamen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCodigoAtencion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbxDatosPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNuevaAtencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevaAtencion";
            this.Load += new System.EventHandler(this.frmNuevaAtencion_Load);
            this.gbxDatosPaciente.ResumeLayout(false);
            this.gbxDatosPaciente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.gbxPacientesRegistrados.ResumeLayout(false);
            this.gbxPacientesRegistrados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatosPaciente;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstPacientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblCodigoAtencion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxTipoExamen;
        private System.Windows.Forms.Label lblExamen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnGuargarDatos;
        private System.Windows.Forms.GroupBox gbxPacientesRegistrados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBusquedaApellido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBusquedaNombre;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DateTimePicker dtpFechaExamen;
    }
}