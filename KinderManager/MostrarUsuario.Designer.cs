namespace KinderManager
{
    partial class MostrarUsuario
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
            this.tablaUser = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sangre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaDir = new System.Windows.Forms.DataGridView();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaPadre = new System.Windows.Forms.DataGridView();
            this.Nombre_Madre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Madre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_Madre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaMadre = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaAdmin = new System.Windows.Forms.DataGridView();
            this.Modalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adeudos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copy_Acta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copy_Cartilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDatosAlumno = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblAdministracion = new System.Windows.Forms.Label();
            this.lblMadre = new System.Windows.Forms.Label();
            this.lblPadre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPadre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMadre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaUser
            // 
            this.tablaUser.AllowUserToAddRows = false;
            this.tablaUser.AllowUserToDeleteRows = false;
            this.tablaUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Nacimiento,
            this.Sangre,
            this.Grado,
            this.Grupo});
            this.tablaUser.Location = new System.Drawing.Point(228, 46);
            this.tablaUser.Name = "tablaUser";
            this.tablaUser.ReadOnly = true;
            this.tablaUser.Size = new System.Drawing.Size(663, 45);
            this.tablaUser.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 150;
            // 
            // Nacimiento
            // 
            this.Nacimiento.HeaderText = "Nacimiento";
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.ReadOnly = true;
            this.Nacimiento.Width = 120;
            // 
            // Sangre
            // 
            this.Sangre.HeaderText = "Tipo Sangre";
            this.Sangre.Name = "Sangre";
            this.Sangre.ReadOnly = true;
            // 
            // Grado
            // 
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            this.Grado.Width = 50;
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            this.Grupo.Width = 50;
            // 
            // tablaDir
            // 
            this.tablaDir.AllowUserToAddRows = false;
            this.tablaDir.AllowUserToDeleteRows = false;
            this.tablaDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Calle,
            this.Colonia,
            this.Telefono});
            this.tablaDir.Location = new System.Drawing.Point(13, 240);
            this.tablaDir.Name = "tablaDir";
            this.tablaDir.ReadOnly = true;
            this.tablaDir.Size = new System.Drawing.Size(395, 45);
            this.tablaDir.TabIndex = 5;
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Width = 150;
            // 
            // Colonia
            // 
            this.Colonia.HeaderText = "Colonia";
            this.Colonia.Name = "Colonia";
            this.Colonia.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 102;
            // 
            // tablaPadre
            // 
            this.tablaPadre.AllowUserToAddRows = false;
            this.tablaPadre.AllowUserToDeleteRows = false;
            this.tablaPadre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPadre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Madre,
            this.Apellido_Madre,
            this.Telefono_Madre});
            this.tablaPadre.Location = new System.Drawing.Point(434, 240);
            this.tablaPadre.Name = "tablaPadre";
            this.tablaPadre.ReadOnly = true;
            this.tablaPadre.Size = new System.Drawing.Size(343, 45);
            this.tablaPadre.TabIndex = 6;
            // 
            // Nombre_Madre
            // 
            this.Nombre_Madre.HeaderText = "Nombre";
            this.Nombre_Madre.Name = "Nombre_Madre";
            this.Nombre_Madre.ReadOnly = true;
            // 
            // Apellido_Madre
            // 
            this.Apellido_Madre.HeaderText = "Apellido";
            this.Apellido_Madre.Name = "Apellido_Madre";
            this.Apellido_Madre.ReadOnly = true;
            // 
            // Telefono_Madre
            // 
            this.Telefono_Madre.HeaderText = "Celular";
            this.Telefono_Madre.Name = "Telefono_Madre";
            this.Telefono_Madre.ReadOnly = true;
            // 
            // tablaMadre
            // 
            this.tablaMadre.AllowUserToAddRows = false;
            this.tablaMadre.AllowUserToDeleteRows = false;
            this.tablaMadre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMadre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tablaMadre.Location = new System.Drawing.Point(798, 240);
            this.tablaMadre.Name = "tablaMadre";
            this.tablaMadre.ReadOnly = true;
            this.tablaMadre.Size = new System.Drawing.Size(343, 45);
            this.tablaMadre.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tablaAdmin
            // 
            this.tablaAdmin.AllowUserToAddRows = false;
            this.tablaAdmin.AllowUserToDeleteRows = false;
            this.tablaAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modalidad,
            this.Adeudos,
            this.Acta,
            this.Copy_Acta,
            this.Copy_Cartilla,
            this.CURP});
            this.tablaAdmin.Location = new System.Drawing.Point(158, 141);
            this.tablaAdmin.Name = "tablaAdmin";
            this.tablaAdmin.ReadOnly = true;
            this.tablaAdmin.Size = new System.Drawing.Size(835, 45);
            this.tablaAdmin.TabIndex = 8;
            // 
            // Modalidad
            // 
            this.Modalidad.HeaderText = "Modalidad de pago";
            this.Modalidad.Name = "Modalidad";
            this.Modalidad.ReadOnly = true;
            this.Modalidad.Width = 250;
            // 
            // Adeudos
            // 
            this.Adeudos.HeaderText = "Adeudo Total";
            this.Adeudos.Name = "Adeudos";
            this.Adeudos.ReadOnly = true;
            this.Adeudos.Width = 102;
            // 
            // Acta
            // 
            this.Acta.HeaderText = "Acta";
            this.Acta.Name = "Acta";
            this.Acta.ReadOnly = true;
            // 
            // Copy_Acta
            // 
            this.Copy_Acta.HeaderText = "Copias de Acta";
            this.Copy_Acta.Name = "Copy_Acta";
            this.Copy_Acta.ReadOnly = true;
            this.Copy_Acta.Width = 120;
            // 
            // Copy_Cartilla
            // 
            this.Copy_Cartilla.HeaderText = "Copias de Cartilla";
            this.Copy_Cartilla.Name = "Copy_Cartilla";
            this.Copy_Cartilla.ReadOnly = true;
            this.Copy_Cartilla.Width = 120;
            // 
            // CURP
            // 
            this.CURP.HeaderText = "CURP";
            this.CURP.Name = "CURP";
            this.CURP.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(520, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 41);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDatosAlumno
            // 
            this.lblDatosAlumno.AutoSize = true;
            this.lblDatosAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosAlumno.Location = new System.Drawing.Point(487, 19);
            this.lblDatosAlumno.Name = "lblDatosAlumno";
            this.lblDatosAlumno.Size = new System.Drawing.Size(175, 24);
            this.lblDatosAlumno.TabIndex = 17;
            this.lblDatosAlumno.Text = "Datos del Alumno";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(133, 213);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(99, 24);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblAdministracion
            // 
            this.lblAdministracion.AutoSize = true;
            this.lblAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministracion.Location = new System.Drawing.Point(504, 114);
            this.lblAdministracion.Name = "lblAdministracion";
            this.lblAdministracion.Size = new System.Drawing.Size(148, 24);
            this.lblAdministracion.TabIndex = 19;
            this.lblAdministracion.Text = "Administración";
            // 
            // lblMadre
            // 
            this.lblMadre.AutoSize = true;
            this.lblMadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadre.Location = new System.Drawing.Point(922, 213);
            this.lblMadre.Name = "lblMadre";
            this.lblMadre.Size = new System.Drawing.Size(127, 24);
            this.lblMadre.TabIndex = 20;
            this.lblMadre.Text = "Datos Madre";
            // 
            // lblPadre
            // 
            this.lblPadre.AutoSize = true;
            this.lblPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadre.Location = new System.Drawing.Point(545, 213);
            this.lblPadre.Name = "lblPadre";
            this.lblPadre.Size = new System.Drawing.Size(123, 24);
            this.lblPadre.TabIndex = 21;
            this.lblPadre.Text = "Datos Padre";
            // 
            // MostrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPadre);
            this.Controls.Add(this.lblMadre);
            this.Controls.Add(this.lblAdministracion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDatosAlumno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tablaAdmin);
            this.Controls.Add(this.tablaMadre);
            this.Controls.Add(this.tablaPadre);
            this.Controls.Add(this.tablaDir);
            this.Controls.Add(this.tablaUser);
            this.Name = "MostrarUsuario";
            this.Size = new System.Drawing.Size(1161, 364);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPadre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMadre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sangre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridView tablaDir;
        private System.Windows.Forms.DataGridView tablaPadre;
        private System.Windows.Forms.DataGridView tablaMadre;
        private System.Windows.Forms.DataGridView tablaAdmin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDatosAlumno;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblAdministracion;
        private System.Windows.Forms.Label lblMadre;
        private System.Windows.Forms.Label lblPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Madre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Madre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_Madre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adeudos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copy_Acta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copy_Cartilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURP;
    }
}