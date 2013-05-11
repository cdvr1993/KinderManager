namespace KinderManager
{
    partial class ReporteAlumnos
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
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sangre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDatosAlumno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaUser
            // 
            this.tablaUser.AllowUserToAddRows = false;
            this.tablaUser.AllowUserToDeleteRows = false;
            this.tablaUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.Nombre,
            this.Nacimiento,
            this.Sangre,
            this.Grado,
            this.Grupo,
            this.Calle,
            this.Colonia,
            this.Tel});
            this.tablaUser.Location = new System.Drawing.Point(46, 46);
            this.tablaUser.Name = "tablaUser";
            this.tablaUser.ReadOnly = true;
            this.tablaUser.Size = new System.Drawing.Size(1013, 239);
            this.tablaUser.TabIndex = 5;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellidos";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
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
            // Tel
            // 
            this.Tel.HeaderText = "Teléfono";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // lblDatosAlumno
            // 
            this.lblDatosAlumno.AutoSize = true;
            this.lblDatosAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosAlumno.Location = new System.Drawing.Point(448, 19);
            this.lblDatosAlumno.Name = "lblDatosAlumno";
            this.lblDatosAlumno.Size = new System.Drawing.Size(213, 24);
            this.lblDatosAlumno.TabIndex = 18;
            this.lblDatosAlumno.Text = "Datos de los Alumnos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seleccione el Grado y Grupo de los alumnos que quiere buscar ";
            // 
            // cmbGrado
            // 
            this.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbGrado.Location = new System.Drawing.Point(46, 349);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(51, 24);
            this.cmbGrado.TabIndex = 21;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.Location = new System.Drawing.Point(42, 312);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(75, 24);
            this.lblGrado.TabIndex = 22;
            this.lblGrado.Text = "Grado*";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(133, 312);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(76, 24);
            this.lblGrupo.TabIndex = 23;
            this.lblGrupo.Text = "Grupo*";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "No",
            "A",
            "B",
            "C"});
            this.cmbGrupo.Location = new System.Drawing.Point(137, 349);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(51, 24);
            this.cmbGrupo.TabIndex = 24;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(671, 349);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(188, 43);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(884, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(188, 43);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ReporteAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatosAlumno);
            this.Controls.Add(this.tablaUser);
            this.Name = "ReporteAlumnos";
            this.Size = new System.Drawing.Size(1100, 418);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaUser;
        private System.Windows.Forms.Label lblDatosAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sangre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
    }
}