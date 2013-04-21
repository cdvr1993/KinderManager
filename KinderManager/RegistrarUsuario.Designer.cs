namespace KinderManager
{
    partial class RegistrarUsuario
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblSangre = new System.Windows.Forms.Label();
            this.cmbSangre = new System.Windows.Forms.ComboBox();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.gpbDireccion = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.lblColonia = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.gpbAdmin = new System.Windows.Forms.GroupBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCURP = new System.Windows.Forms.TextBox();
            this.lblCURP = new System.Windows.Forms.Label();
            this.chkCopiasCartilla = new System.Windows.Forms.CheckBox();
            this.chkCopiaActa = new System.Windows.Forms.CheckBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.chkActa = new System.Windows.Forms.CheckBox();
            this.gpbDatos.SuspendLayout();
            this.gpbDireccion.SuspendLayout();
            this.gpbAdmin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(812, 354);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(188, 43);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1027, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(188, 43);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(4, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 24);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre*";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(8, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 26);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(6, 114);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(105, 24);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellidos*";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(6, 141);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(343, 26);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(4, 182);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(218, 24);
            this.lblNacimiento.TabIndex = 7;
            this.lblNacimiento.Text = "Fecha de Nacimiento*";
            // 
            // cmbDay
            // 
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDay.Location = new System.Drawing.Point(9, 221);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(51, 24);
            this.cmbDay.TabIndex = 9;
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Ene",
            "Feb",
            "Mar",
            "Abr",
            "May",
            "Jun",
            "Jul",
            "Ago",
            "Sep",
            "Oct",
            "Nov",
            "Dic"});
            this.cmbMes.Location = new System.Drawing.Point(75, 221);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(72, 24);
            this.cmbMes.TabIndex = 10;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034"});
            this.cmbYear.Location = new System.Drawing.Point(152, 221);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(91, 24);
            this.cmbYear.TabIndex = 11;
            // 
            // lblSangre
            // 
            this.lblSangre.AutoSize = true;
            this.lblSangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSangre.Location = new System.Drawing.Point(15, 264);
            this.lblSangre.Name = "lblSangre";
            this.lblSangre.Size = new System.Drawing.Size(163, 24);
            this.lblSangre.TabIndex = 12;
            this.lblSangre.Text = "Tipo de Sangre*";
            // 
            // cmbSangre
            // 
            this.cmbSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSangre.FormattingEnabled = true;
            this.cmbSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmbSangre.Location = new System.Drawing.Point(10, 311);
            this.cmbSangre.Name = "cmbSangre";
            this.cmbSangre.Size = new System.Drawing.Size(88, 24);
            this.cmbSangre.TabIndex = 13;
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.txtNombre);
            this.gpbDatos.Controls.Add(this.cmbSangre);
            this.gpbDatos.Controls.Add(this.lblNombre);
            this.gpbDatos.Controls.Add(this.lblSangre);
            this.gpbDatos.Controls.Add(this.txtApellido);
            this.gpbDatos.Controls.Add(this.cmbDay);
            this.gpbDatos.Controls.Add(this.cmbMes);
            this.gpbDatos.Controls.Add(this.cmbYear);
            this.gpbDatos.Controls.Add(this.lblApellido);
            this.gpbDatos.Controls.Add(this.lblNacimiento);
            this.gpbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatos.Location = new System.Drawing.Point(12, 12);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(357, 401);
            this.gpbDatos.TabIndex = 14;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos Personales";
            // 
            // gpbDireccion
            // 
            this.gpbDireccion.Controls.Add(this.txtTel);
            this.gpbDireccion.Controls.Add(this.txtCalle);
            this.gpbDireccion.Controls.Add(this.lblCalle);
            this.gpbDireccion.Controls.Add(this.txtColonia);
            this.gpbDireccion.Controls.Add(this.lblColonia);
            this.gpbDireccion.Controls.Add(this.lblTel);
            this.gpbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDireccion.Location = new System.Drawing.Point(397, 199);
            this.gpbDireccion.Name = "gpbDireccion";
            this.gpbDireccion.Size = new System.Drawing.Size(383, 214);
            this.gpbDireccion.TabIndex = 15;
            this.gpbDireccion.TabStop = false;
            this.gpbDireccion.Text = "Dirección";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(6, 182);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(367, 26);
            this.txtTel.TabIndex = 8;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPressNumber);
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(6, 60);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(371, 26);
            this.txtCalle.TabIndex = 4;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(4, 33);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(229, 24);
            this.lblCalle.TabIndex = 3;
            this.lblCalle.Text = "Calle (incluya número)*";
            // 
            // txtColonia
            // 
            this.txtColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Location = new System.Drawing.Point(6, 121);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(367, 26);
            this.txtColonia.TabIndex = 6;
            this.txtColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColonia.Location = new System.Drawing.Point(6, 94);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(89, 24);
            this.lblColonia.TabIndex = 5;
            this.lblColonia.Text = "Colonia*";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(6, 155);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(101, 24);
            this.lblTel.TabIndex = 7;
            this.lblTel.Text = "Teléfono*\r\n";
            // 
            // gpbAdmin
            // 
            this.gpbAdmin.Controls.Add(this.lblGrupo);
            this.gpbAdmin.Controls.Add(this.cmbGrupo);
            this.gpbAdmin.Controls.Add(this.cmbPago);
            this.gpbAdmin.Controls.Add(this.cmbGrado);
            this.gpbAdmin.Controls.Add(this.lblGrado);
            this.gpbAdmin.Controls.Add(this.lblPago);
            this.gpbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAdmin.Location = new System.Drawing.Point(397, 12);
            this.gpbAdmin.Name = "gpbAdmin";
            this.gpbAdmin.Size = new System.Drawing.Size(383, 170);
            this.gpbAdmin.TabIndex = 17;
            this.gpbAdmin.TabStop = false;
            this.gpbAdmin.Text = "Administración";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(103, 33);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(76, 24);
            this.lblGrupo.TabIndex = 20;
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
            this.cmbGrupo.Location = new System.Drawing.Point(107, 60);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(51, 24);
            this.cmbGrupo.TabIndex = 19;
            // 
            // cmbPago
            // 
            this.cmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Location = new System.Drawing.Point(9, 132);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(368, 24);
            this.cmbPago.TabIndex = 18;
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
            this.cmbGrado.Location = new System.Drawing.Point(10, 60);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(51, 24);
            this.cmbGrado.TabIndex = 10;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.Location = new System.Drawing.Point(4, 33);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(75, 24);
            this.lblGrado.TabIndex = 3;
            this.lblGrado.Text = "Grado*";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(6, 94);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(198, 24);
            this.lblPago.TabIndex = 5;
            this.lblPago.Text = "Modalidad de pago*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCURP);
            this.groupBox1.Controls.Add(this.lblCURP);
            this.groupBox1.Controls.Add(this.chkCopiasCartilla);
            this.groupBox1.Controls.Add(this.chkCopiaActa);
            this.groupBox1.Controls.Add(this.lblInstrucciones);
            this.groupBox1.Controls.Add(this.chkActa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(812, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 226);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentación";
            // 
            // txtCURP
            // 
            this.txtCURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCURP.Location = new System.Drawing.Point(20, 177);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(353, 26);
            this.txtCURP.TabIndex = 27;
            // 
            // lblCURP
            // 
            this.lblCURP.AutoSize = true;
            this.lblCURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCURP.Location = new System.Drawing.Point(16, 145);
            this.lblCURP.Name = "lblCURP";
            this.lblCURP.Size = new System.Drawing.Size(387, 20);
            this.lblCURP.TabIndex = 26;
            this.lblCURP.Text = "Ingrese CURP (Si no lo tiene, déjelo en blanco)";
            // 
            // chkCopiasCartilla
            // 
            this.chkCopiasCartilla.AutoSize = true;
            this.chkCopiasCartilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkCopiasCartilla.Location = new System.Drawing.Point(207, 105);
            this.chkCopiasCartilla.Name = "chkCopiasCartilla";
            this.chkCopiasCartilla.Size = new System.Drawing.Size(192, 28);
            this.chkCopiasCartilla.TabIndex = 25;
            this.chkCopiasCartilla.Text = "Copias de Cartilla";
            this.chkCopiasCartilla.UseVisualStyleBackColor = true;
            // 
            // chkCopiaActa
            // 
            this.chkCopiaActa.AutoSize = true;
            this.chkCopiaActa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkCopiaActa.Location = new System.Drawing.Point(10, 103);
            this.chkCopiaActa.Name = "chkCopiaActa";
            this.chkCopiaActa.Size = new System.Drawing.Size(170, 28);
            this.chkCopiaActa.TabIndex = 24;
            this.chkCopiaActa.Text = "Copias de Acta";
            this.chkCopiaActa.UseVisualStyleBackColor = true;
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblInstrucciones.Location = new System.Drawing.Point(6, 38);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(386, 24);
            this.lblInstrucciones.TabIndex = 23;
            this.lblInstrucciones.Text = "Seleccione los documentos entregados.";
            // 
            // chkActa
            // 
            this.chkActa.AutoSize = true;
            this.chkActa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkActa.Location = new System.Drawing.Point(163, 69);
            this.chkActa.Name = "chkActa";
            this.chkActa.Size = new System.Drawing.Size(70, 28);
            this.chkActa.TabIndex = 22;
            this.chkActa.Text = "Acta";
            this.chkActa.UseVisualStyleBackColor = true;
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbAdmin);
            this.Controls.Add(this.gpbDireccion);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "RegistrarUsuario";
            this.Text = "Registro de Alumno Nuevo";
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.gpbDireccion.ResumeLayout(false);
            this.gpbDireccion.PerformLayout();
            this.gpbAdmin.ResumeLayout(false);
            this.gpbAdmin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblSangre;
        private System.Windows.Forms.ComboBox cmbSangre;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.GroupBox gpbDireccion;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.GroupBox gpbAdmin;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCURP;
        private System.Windows.Forms.Label lblCURP;
        private System.Windows.Forms.CheckBox chkCopiasCartilla;
        private System.Windows.Forms.CheckBox chkCopiaActa;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.CheckBox chkActa;
    }
}