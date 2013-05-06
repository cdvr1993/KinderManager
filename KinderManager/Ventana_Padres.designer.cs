namespace KinderManager
{
    partial class Ventana_Padres
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt1_email = new System.Windows.Forms.TextBox();
            this.cmb1_MH = new System.Windows.Forms.ComboBox();
            this.b1_actualizar = new System.Windows.Forms.Button();
            this.b1_registrar = new System.Windows.Forms.Button();
            this.mtxt_celular = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt1_empresa = new System.Windows.Forms.TextBox();
            this.txt1_ocupacion = new System.Windows.Forms.TextBox();
            this.txt1_apellido = new System.Windows.Forms.TextBox();
            this.txt1_nombre = new System.Windows.Forms.TextBox();
            this.l1_email = new System.Windows.Forms.Label();
            this.l1_celular = new System.Windows.Forms.Label();
            this.l1_telefono = new System.Windows.Forms.Label();
            this.l1_empresa = new System.Windows.Forms.Label();
            this.l1_ocupacion = new System.Windows.Forms.Label();
            this.l1_apellido = new System.Windows.Forms.Label();
            this.l1_nombre = new System.Windows.Forms.Label();
            this.l1_mensaje = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.b2_eliminar = new System.Windows.Forms.Button();
            this.b2_buscar = new System.Windows.Forms.Button();
            this.b2_cargardatos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt2_buscarapellido = new System.Windows.Forms.TextBox();
            this.txt2_buscarnombre = new System.Windows.Forms.TextBox();
            this.cmb2_selec = new System.Windows.Forms.ComboBox();
            this.l3_apellido = new System.Windows.Forms.Label();
            this.l2_nombre = new System.Windows.Forms.Label();
            this.l2_mensaje = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 340);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt1_email);
            this.tabPage1.Controls.Add(this.cmb1_MH);
            this.tabPage1.Controls.Add(this.b1_actualizar);
            this.tabPage1.Controls.Add(this.b1_registrar);
            this.tabPage1.Controls.Add(this.mtxt_celular);
            this.tabPage1.Controls.Add(this.mtxt_telefono);
            this.tabPage1.Controls.Add(this.txt1_empresa);
            this.tabPage1.Controls.Add(this.txt1_ocupacion);
            this.tabPage1.Controls.Add(this.txt1_apellido);
            this.tabPage1.Controls.Add(this.txt1_nombre);
            this.tabPage1.Controls.Add(this.l1_email);
            this.tabPage1.Controls.Add(this.l1_celular);
            this.tabPage1.Controls.Add(this.l1_telefono);
            this.tabPage1.Controls.Add(this.l1_empresa);
            this.tabPage1.Controls.Add(this.l1_ocupacion);
            this.tabPage1.Controls.Add(this.l1_apellido);
            this.tabPage1.Controls.Add(this.l1_nombre);
            this.tabPage1.Controls.Add(this.l1_mensaje);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar y Actualizar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt1_email
            // 
            this.txt1_email.Location = new System.Drawing.Point(229, 243);
            this.txt1_email.Name = "txt1_email";
            this.txt1_email.Size = new System.Drawing.Size(100, 20);
            this.txt1_email.TabIndex = 17;
            // 
            // cmb1_MH
            // 
            this.cmb1_MH.FormattingEnabled = true;
            this.cmb1_MH.Items.AddRange(new object[] {
            "Madres",
            "Padres"});
            this.cmb1_MH.Location = new System.Drawing.Point(50, 74);
            this.cmb1_MH.Name = "cmb1_MH";
            this.cmb1_MH.Size = new System.Drawing.Size(122, 21);
            this.cmb1_MH.TabIndex = 16;
            this.cmb1_MH.SelectedIndex = 0;
            // 
            // b1_actualizar
            // 
            this.b1_actualizar.Location = new System.Drawing.Point(75, 240);
            this.b1_actualizar.Name = "b1_actualizar";
            this.b1_actualizar.Size = new System.Drawing.Size(75, 23);
            this.b1_actualizar.TabIndex = 15;
            this.b1_actualizar.Text = "Actualizar";
            this.b1_actualizar.UseVisualStyleBackColor = true;
            // 
            // b1_registrar
            // 
            this.b1_registrar.Location = new System.Drawing.Point(75, 147);
            this.b1_registrar.Name = "b1_registrar";
            this.b1_registrar.Size = new System.Drawing.Size(75, 23);
            this.b1_registrar.TabIndex = 14;
            this.b1_registrar.Text = "Registrar";
            this.b1_registrar.UseVisualStyleBackColor = true;
            // 
            // mtxt_celular
            // 
            this.mtxt_celular.Location = new System.Drawing.Point(411, 182);
            this.mtxt_celular.Mask = "000-000-0000";
            this.mtxt_celular.Name = "mtxt_celular";
            this.mtxt_celular.Size = new System.Drawing.Size(100, 20);
            this.mtxt_celular.TabIndex = 13;
            // 
            // mtxt_telefono
            // 
            this.mtxt_telefono.Location = new System.Drawing.Point(229, 182);
            this.mtxt_telefono.Mask = "0000-0000";
            this.mtxt_telefono.Name = "mtxt_telefono";
            this.mtxt_telefono.Size = new System.Drawing.Size(100, 20);
            this.mtxt_telefono.TabIndex = 12;
            // 
            // txt1_empresa
            // 
            this.txt1_empresa.Location = new System.Drawing.Point(411, 131);
            this.txt1_empresa.Name = "txt1_empresa";
            this.txt1_empresa.Size = new System.Drawing.Size(100, 20);
            this.txt1_empresa.TabIndex = 11;
            // 
            // txt1_ocupacion
            // 
            this.txt1_ocupacion.Location = new System.Drawing.Point(229, 131);
            this.txt1_ocupacion.Name = "txt1_ocupacion";
            this.txt1_ocupacion.Size = new System.Drawing.Size(100, 20);
            this.txt1_ocupacion.TabIndex = 10;
            // 
            // txt1_apellido
            // 
            this.txt1_apellido.Location = new System.Drawing.Point(411, 74);
            this.txt1_apellido.Name = "txt1_apellido";
            this.txt1_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt1_apellido.TabIndex = 9;
            // 
            // txt1_nombre
            // 
            this.txt1_nombre.Location = new System.Drawing.Point(229, 74);
            this.txt1_nombre.Name = "txt1_nombre";
            this.txt1_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt1_nombre.TabIndex = 8;
            // 
            // l1_email
            // 
            this.l1_email.AutoSize = true;
            this.l1_email.Location = new System.Drawing.Point(226, 227);
            this.l1_email.Name = "l1_email";
            this.l1_email.Size = new System.Drawing.Size(32, 13);
            this.l1_email.TabIndex = 7;
            this.l1_email.Text = "Email";
            // 
            // l1_celular
            // 
            this.l1_celular.AutoSize = true;
            this.l1_celular.Location = new System.Drawing.Point(408, 166);
            this.l1_celular.Name = "l1_celular";
            this.l1_celular.Size = new System.Drawing.Size(39, 13);
            this.l1_celular.TabIndex = 6;
            this.l1_celular.Text = "Celular";
            // 
            // l1_telefono
            // 
            this.l1_telefono.AutoSize = true;
            this.l1_telefono.Location = new System.Drawing.Point(226, 166);
            this.l1_telefono.Name = "l1_telefono";
            this.l1_telefono.Size = new System.Drawing.Size(49, 13);
            this.l1_telefono.TabIndex = 5;
            this.l1_telefono.Text = "Telefono";
            // 
            // l1_empresa
            // 
            this.l1_empresa.AutoSize = true;
            this.l1_empresa.Location = new System.Drawing.Point(408, 115);
            this.l1_empresa.Name = "l1_empresa";
            this.l1_empresa.Size = new System.Drawing.Size(48, 13);
            this.l1_empresa.TabIndex = 4;
            this.l1_empresa.Text = "Empresa";
            // 
            // l1_ocupacion
            // 
            this.l1_ocupacion.AutoSize = true;
            this.l1_ocupacion.Location = new System.Drawing.Point(226, 115);
            this.l1_ocupacion.Name = "l1_ocupacion";
            this.l1_ocupacion.Size = new System.Drawing.Size(59, 13);
            this.l1_ocupacion.TabIndex = 3;
            this.l1_ocupacion.Text = "Ocupación";
            // 
            // l1_apellido
            // 
            this.l1_apellido.AutoSize = true;
            this.l1_apellido.Location = new System.Drawing.Point(408, 58);
            this.l1_apellido.Name = "l1_apellido";
            this.l1_apellido.Size = new System.Drawing.Size(44, 13);
            this.l1_apellido.TabIndex = 2;
            this.l1_apellido.Text = "Apellido";
            // 
            // l1_nombre
            // 
            this.l1_nombre.AutoSize = true;
            this.l1_nombre.Location = new System.Drawing.Point(226, 58);
            this.l1_nombre.Name = "l1_nombre";
            this.l1_nombre.Size = new System.Drawing.Size(44, 13);
            this.l1_nombre.TabIndex = 1;
            this.l1_nombre.Text = "Nombre";
            // 
            // l1_mensaje
            // 
            this.l1_mensaje.AutoSize = true;
            this.l1_mensaje.Location = new System.Drawing.Point(16, 17);
            this.l1_mensaje.Name = "l1_mensaje";
            this.l1_mensaje.Size = new System.Drawing.Size(97, 13);
            this.l1_mensaje.TabIndex = 0;
            this.l1_mensaje.Text = "Registro de Padres";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.b2_eliminar);
            this.tabPage2.Controls.Add(this.b2_buscar);
            this.tabPage2.Controls.Add(this.b2_cargardatos);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.txt2_buscarapellido);
            this.tabPage2.Controls.Add(this.txt2_buscarnombre);
            this.tabPage2.Controls.Add(this.cmb2_selec);
            this.tabPage2.Controls.Add(this.l3_apellido);
            this.tabPage2.Controls.Add(this.l2_nombre);
            this.tabPage2.Controls.Add(this.l2_mensaje);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar y Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // b2_eliminar
            // 
            this.b2_eliminar.Location = new System.Drawing.Point(364, 280);
            this.b2_eliminar.Name = "b2_eliminar";
            this.b2_eliminar.Size = new System.Drawing.Size(107, 23);
            this.b2_eliminar.TabIndex = 9;
            this.b2_eliminar.Text = "Eliminar";
            this.b2_eliminar.UseVisualStyleBackColor = true;
            // 
            // b2_buscar
            // 
            this.b2_buscar.Location = new System.Drawing.Point(470, 59);
            this.b2_buscar.Name = "b2_buscar";
            this.b2_buscar.Size = new System.Drawing.Size(75, 23);
            this.b2_buscar.TabIndex = 8;
            this.b2_buscar.Text = "Buscar";
            this.b2_buscar.UseVisualStyleBackColor = true;
            // 
            // b2_cargardatos
            // 
            this.b2_cargardatos.Location = new System.Drawing.Point(76, 280);
            this.b2_cargardatos.Name = "b2_cargardatos";
            this.b2_cargardatos.Size = new System.Drawing.Size(186, 23);
            this.b2_cargardatos.TabIndex = 7;
            this.b2_cargardatos.Text = "Cargar Datos Para Actualizar";
            this.b2_cargardatos.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(21, 110);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Celular";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txt2_buscarapellido
            // 
            this.txt2_buscarapellido.Location = new System.Drawing.Point(331, 63);
            this.txt2_buscarapellido.Name = "txt2_buscarapellido";
            this.txt2_buscarapellido.Size = new System.Drawing.Size(100, 20);
            this.txt2_buscarapellido.TabIndex = 5;
            // 
            // txt2_buscarnombre
            // 
            this.txt2_buscarnombre.Location = new System.Drawing.Point(190, 63);
            this.txt2_buscarnombre.Name = "txt2_buscarnombre";
            this.txt2_buscarnombre.Size = new System.Drawing.Size(100, 20);
            this.txt2_buscarnombre.TabIndex = 4;
            // 
            // cmb2_selec
            // 
            this.cmb2_selec.FormattingEnabled = true;
            this.cmb2_selec.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Alumno"});
            this.cmb2_selec.Location = new System.Drawing.Point(21, 62);
            this.cmb2_selec.Name = "cmb2_selec";
            this.cmb2_selec.Size = new System.Drawing.Size(121, 21);
            this.cmb2_selec.TabIndex = 3;
            this.cmb2_selec.SelectedIndex = 0;
            // 
            // l3_apellido
            // 
            this.l3_apellido.AutoSize = true;
            this.l3_apellido.Location = new System.Drawing.Point(332, 40);
            this.l3_apellido.Name = "l3_apellido";
            this.l3_apellido.Size = new System.Drawing.Size(44, 13);
            this.l3_apellido.TabIndex = 2;
            this.l3_apellido.Text = "Apellido";
            // 
            // l2_nombre
            // 
            this.l2_nombre.AutoSize = true;
            this.l2_nombre.Location = new System.Drawing.Point(187, 40);
            this.l2_nombre.Name = "l2_nombre";
            this.l2_nombre.Size = new System.Drawing.Size(44, 13);
            this.l2_nombre.TabIndex = 1;
            this.l2_nombre.Text = "Nombre";
            // 
            // l2_mensaje
            // 
            this.l2_mensaje.AutoSize = true;
            this.l2_mensaje.Location = new System.Drawing.Point(24, 18);
            this.l2_mensaje.Name = "l2_mensaje";
            this.l2_mensaje.Size = new System.Drawing.Size(118, 13);
            this.l2_mensaje.TabIndex = 0;
            this.l2_mensaje.Text = "Bucar Padres o Madres";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Ventana_Padres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Ventana_Padres";
            this.Size = new System.Drawing.Size(592, 378);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label l1_email;
        private System.Windows.Forms.Label l1_celular;
        private System.Windows.Forms.Label l1_telefono;
        private System.Windows.Forms.Label l1_empresa;
        private System.Windows.Forms.Label l1_ocupacion;
        private System.Windows.Forms.Label l1_apellido;
        private System.Windows.Forms.Label l1_nombre;
        private System.Windows.Forms.Label l1_mensaje;
        private System.Windows.Forms.TextBox txt1_empresa;
        private System.Windows.Forms.TextBox txt1_ocupacion;
        private System.Windows.Forms.TextBox txt1_apellido;
        private System.Windows.Forms.TextBox txt1_nombre;
        private System.Windows.Forms.MaskedTextBox mtxt_celular;
        private System.Windows.Forms.MaskedTextBox mtxt_telefono;
        private System.Windows.Forms.ComboBox cmb1_MH;
        private System.Windows.Forms.Button b1_actualizar;
        private System.Windows.Forms.Button b1_registrar;
        private System.Windows.Forms.TextBox txt1_email;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt2_buscarapellido;
        private System.Windows.Forms.TextBox txt2_buscarnombre;
        private System.Windows.Forms.ComboBox cmb2_selec;
        private System.Windows.Forms.Label l3_apellido;
        private System.Windows.Forms.Label l2_nombre;
        private System.Windows.Forms.Label l2_mensaje;
        private System.Windows.Forms.Button b2_cargardatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button b2_buscar;
        private System.Windows.Forms.Button b2_eliminar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}
