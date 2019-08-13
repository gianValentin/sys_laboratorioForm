namespace Sys_Laboratorio
{
    partial class frmExamenes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamenes));
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFAtencion = new System.Windows.Forms.Label();
            this.lblFNacimiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblIdPacietne = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstExamenes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsAbrirArchivo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.cmsAbrirArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(615, 307);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 36);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paciente:";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePaciente.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblNombrePaciente.Location = new System.Drawing.Point(115, 18);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(186, 24);
            this.lblNombrePaciente.TabIndex = 2;
            this.lblNombrePaciente.Text = "NombrePaciente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFAtencion);
            this.groupBox1.Controls.Add(this.lblFNacimiento);
            this.groupBox1.Controls.Add(this.lblGenero);
            this.groupBox1.Controls.Add(this.lblIdPacietne);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // lblFAtencion
            // 
            this.lblFAtencion.AutoSize = true;
            this.lblFAtencion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblFAtencion.Location = new System.Drawing.Point(372, 47);
            this.lblFAtencion.Name = "lblFAtencion";
            this.lblFAtencion.Size = new System.Drawing.Size(87, 17);
            this.lblFAtencion.TabIndex = 8;
            this.lblFAtencion.Text = "lblFAtencion";
            // 
            // lblFNacimiento
            // 
            this.lblFNacimiento.AutoSize = true;
            this.lblFNacimiento.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblFNacimiento.Location = new System.Drawing.Point(372, 19);
            this.lblFNacimiento.Name = "lblFNacimiento";
            this.lblFNacimiento.Size = new System.Drawing.Size(105, 17);
            this.lblFNacimiento.TabIndex = 7;
            this.lblFNacimiento.Text = "lblFNacimiento";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblGenero.Location = new System.Drawing.Point(108, 47);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(71, 17);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "lblGenero";
            // 
            // lblIdPacietne
            // 
            this.lblIdPacietne.AutoSize = true;
            this.lblIdPacietne.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblIdPacietne.Location = new System.Drawing.Point(108, 19);
            this.lblIdPacietne.Name = "lblIdPacietne";
            this.lblIdPacietne.Size = new System.Drawing.Size(92, 17);
            this.lblIdPacietne.TabIndex = 5;
            this.lblIdPacietne.Text = "lblIdPacietne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id Paciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha Aencion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha Nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Genero:";
            // 
            // lstExamenes
            // 
            this.lstExamenes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstExamenes.ContextMenuStrip = this.cmsAbrirArchivo;
            this.lstExamenes.FullRowSelect = true;
            this.lstExamenes.GridLines = true;
            this.lstExamenes.Location = new System.Drawing.Point(20, 149);
            this.lstExamenes.Name = "lstExamenes";
            this.lstExamenes.Size = new System.Drawing.Size(557, 194);
            this.lstExamenes.TabIndex = 4;
            this.lstExamenes.UseCompatibleStateImageBehavior = false;
            this.lstExamenes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Examen";
            this.columnHeader2.Width = 320;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha de Examen";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 160;
            // 
            // cmsAbrirArchivo
            // 
            this.cmsAbrirArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirExamenToolStripMenuItem});
            this.cmsAbrirArchivo.Name = "cmsAbrirArchivo";
            this.cmsAbrirArchivo.Size = new System.Drawing.Size(208, 26);
            // 
            // abrirExamenToolStripMenuItem
            // 
            this.abrirExamenToolStripMenuItem.Name = "abrirExamenToolStripMenuItem";
            this.abrirExamenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.abrirExamenToolStripMenuItem.Text = "Generar Examen en Word";
            this.abrirExamenToolStripMenuItem.Click += new System.EventHandler(this.abrirExamenToolStripMenuItem_Click);
            // 
            // frmExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 393);
            this.ControlBox = false;
            this.Controls.Add(this.lstExamenes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExamenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examenes ";
            this.Load += new System.EventHandler(this.frmExamenes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsAbrirArchivo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblIdPacietne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstExamenes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblFAtencion;
        private System.Windows.Forms.ContextMenuStrip cmsAbrirArchivo;
        private System.Windows.Forms.ToolStripMenuItem abrirExamenToolStripMenuItem;
    }
}