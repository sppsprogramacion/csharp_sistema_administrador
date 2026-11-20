namespace CapaPresentacion
{
    partial class FormAdministrarUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrganismo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.btnDeshabilitarUsuario = new System.Windows.Forms.Button();
            this.btnVerUsuariosActivos = new System.Windows.Forms.Button();
            this.btnVerUsuariosInactivos = new System.Windows.Forms.Button();
            this.cmbOrganismos = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVerActivosPorOrganismo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuitarRol = new System.Windows.Forms.Button();
            this.txtIdUsuarioRol = new System.Windows.Forms.TextBox();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgUsuarios);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1015, 310);
            this.groupBox3.TabIndex = 92;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "USUARIOS";
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(6, 20);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.Size = new System.Drawing.Size(1003, 275);
            this.dtgUsuarios.TabIndex = 2;
            this.dtgUsuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgvProhibiciones_KeyDown);
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(9, 75);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(240, 21);
            this.txtDni.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 96;
            this.label1.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 97;
            this.label3.Text = "SEXO:";
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoNombre.Location = new System.Drawing.Point(104, 33);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.ReadOnly = true;
            this.txtApellidoNombre.Size = new System.Drawing.Size(402, 21);
            this.txtApellidoNombre.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 99;
            this.label4.Text = "APELLIDO Y NOMBRE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 15);
            this.label6.TabIndex = 101;
            this.label6.Text = "CORREO ELECTRONICO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(263, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 102;
            this.label7.Text = "LEGAJO:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(266, 117);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(240, 21);
            this.txtTelefono.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 103;
            this.label8.Text = "TELEFONO:";
            // 
            // txtSexo
            // 
            this.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(9, 117);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(240, 21);
            this.txtSexo.TabIndex = 104;
            // 
            // txtLegajo
            // 
            this.txtLegajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegajo.Location = new System.Drawing.Point(266, 75);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.ReadOnly = true;
            this.txtLegajo.Size = new System.Drawing.Size(240, 21);
            this.txtLegajo.TabIndex = 105;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(9, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(240, 21);
            this.txtEmail.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(263, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 107;
            this.label9.Text = "ORGANISMO";
            // 
            // txtOrganismo
            // 
            this.txtOrganismo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrganismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganismo.Location = new System.Drawing.Point(266, 159);
            this.txtOrganismo.Name = "txtOrganismo";
            this.txtOrganismo.ReadOnly = true;
            this.txtOrganismo.Size = new System.Drawing.Size(240, 21);
            this.txtOrganismo.TabIndex = 108;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditarUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdUsuario);
            this.groupBox1.Controls.Add(this.btnDeshabilitarUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtOrganismo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtApellidoNombre);
            this.groupBox1.Controls.Add(this.txtLegajo);
            this.groupBox1.Controls.Add(this.txtSexo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(7, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 240);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 112;
            this.label2.Text = "ID USUARIO:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(8, 32);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(86, 21);
            this.txtIdUsuario.TabIndex = 110;
            // 
            // btnDeshabilitarUsuario
            // 
            this.btnDeshabilitarUsuario.BackColor = System.Drawing.Color.Crimson;
            this.btnDeshabilitarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitarUsuario.Location = new System.Drawing.Point(324, 191);
            this.btnDeshabilitarUsuario.Name = "btnDeshabilitarUsuario";
            this.btnDeshabilitarUsuario.Size = new System.Drawing.Size(182, 40);
            this.btnDeshabilitarUsuario.TabIndex = 109;
            this.btnDeshabilitarUsuario.Text = "DESHABILITAR USUARIO";
            this.btnDeshabilitarUsuario.UseVisualStyleBackColor = false;
            this.btnDeshabilitarUsuario.Click += new System.EventHandler(this.btnDeshabilitarUsuario_Click);
            // 
            // btnVerUsuariosActivos
            // 
            this.btnVerUsuariosActivos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVerUsuariosActivos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerUsuariosActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerUsuariosActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerUsuariosActivos.ForeColor = System.Drawing.Color.White;
            this.btnVerUsuariosActivos.Location = new System.Drawing.Point(214, 3);
            this.btnVerUsuariosActivos.Name = "btnVerUsuariosActivos";
            this.btnVerUsuariosActivos.Size = new System.Drawing.Size(160, 40);
            this.btnVerUsuariosActivos.TabIndex = 111;
            this.btnVerUsuariosActivos.Text = "USUARIOS ACTIVOS";
            this.btnVerUsuariosActivos.UseVisualStyleBackColor = false;
            this.btnVerUsuariosActivos.Click += new System.EventHandler(this.btnVerUsuariosActivos_Click);
            // 
            // btnVerUsuariosInactivos
            // 
            this.btnVerUsuariosInactivos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVerUsuariosInactivos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerUsuariosInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerUsuariosInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerUsuariosInactivos.ForeColor = System.Drawing.Color.White;
            this.btnVerUsuariosInactivos.Location = new System.Drawing.Point(379, 3);
            this.btnVerUsuariosInactivos.Name = "btnVerUsuariosInactivos";
            this.btnVerUsuariosInactivos.Size = new System.Drawing.Size(165, 40);
            this.btnVerUsuariosInactivos.TabIndex = 112;
            this.btnVerUsuariosInactivos.Text = "USUARIOS INACTIVOS";
            this.btnVerUsuariosInactivos.UseVisualStyleBackColor = false;
            this.btnVerUsuariosInactivos.Click += new System.EventHandler(this.btnVerUsuariosInactivos_Click);
            // 
            // cmbOrganismos
            // 
            this.cmbOrganismos.FormattingEnabled = true;
            this.cmbOrganismos.Location = new System.Drawing.Point(567, 21);
            this.cmbOrganismos.Name = "cmbOrganismos";
            this.cmbOrganismos.Size = new System.Drawing.Size(260, 21);
            this.cmbOrganismos.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(565, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 114;
            this.label11.Text = "ORGANISMO";
            // 
            // btnVerActivosPorOrganismo
            // 
            this.btnVerActivosPorOrganismo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVerActivosPorOrganismo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerActivosPorOrganismo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerActivosPorOrganismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerActivosPorOrganismo.ForeColor = System.Drawing.Color.White;
            this.btnVerActivosPorOrganismo.Location = new System.Drawing.Point(839, 3);
            this.btnVerActivosPorOrganismo.Name = "btnVerActivosPorOrganismo";
            this.btnVerActivosPorOrganismo.Size = new System.Drawing.Size(175, 40);
            this.btnVerActivosPorOrganismo.TabIndex = 115;
            this.btnVerActivosPorOrganismo.Text = "VER POR ORGANISMO";
            this.btnVerActivosPorOrganismo.UseVisualStyleBackColor = false;
            this.btnVerActivosPorOrganismo.Click += new System.EventHandler(this.btnVerActivosPorOrganismo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnQuitarRol);
            this.groupBox2.Controls.Add(this.txtIdUsuarioRol);
            this.groupBox2.Controls.Add(this.dgvRoles);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtRol);
            this.groupBox2.Location = new System.Drawing.Point(532, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 237);
            this.groupBox2.TabIndex = 116;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ROLES DEL USUARIO";
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.Indigo;
            this.btnEditarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEditarUsuario.Location = new System.Drawing.Point(191, 191);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(127, 40);
            this.btnEditarUsuario.TabIndex = 119;
            this.btnEditarUsuario.Text = "EDITAR USUARIO";
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 118;
            this.label5.Text = "ID USUARIO-ROL:";
            // 
            // btnQuitarRol
            // 
            this.btnQuitarRol.BackColor = System.Drawing.Color.Crimson;
            this.btnQuitarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarRol.ForeColor = System.Drawing.Color.White;
            this.btnQuitarRol.Location = new System.Drawing.Point(302, 189);
            this.btnQuitarRol.Name = "btnQuitarRol";
            this.btnQuitarRol.Size = new System.Drawing.Size(182, 40);
            this.btnQuitarRol.TabIndex = 115;
            this.btnQuitarRol.Text = "QUITAR ROL";
            this.btnQuitarRol.UseVisualStyleBackColor = false;
            this.btnQuitarRol.Click += new System.EventHandler(this.btnQuitarRol_Click);
            // 
            // txtIdUsuarioRol
            // 
            this.txtIdUsuarioRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdUsuarioRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuarioRol.Location = new System.Drawing.Point(7, 158);
            this.txtIdUsuarioRol.Name = "txtIdUsuarioRol";
            this.txtIdUsuarioRol.ReadOnly = true;
            this.txtIdUsuarioRol.Size = new System.Drawing.Size(117, 21);
            this.txtIdUsuarioRol.TabIndex = 117;
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(6, 19);
            this.dgvRoles.Name = "dgvRoles";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRoles.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoles.Size = new System.Drawing.Size(478, 119);
            this.dgvRoles.TabIndex = 70;
            this.dgvRoles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRoles_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(127, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 15);
            this.label12.TabIndex = 116;
            this.label12.Text = "ROL:";
            // 
            // txtRol
            // 
            this.txtRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRol.Location = new System.Drawing.Point(130, 159);
            this.txtRol.Name = "txtRol";
            this.txtRol.ReadOnly = true;
            this.txtRol.Size = new System.Drawing.Size(160, 21);
            this.txtRol.TabIndex = 115;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.Indigo;
            this.btnNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(13, 3);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(139, 40);
            this.btnNuevoUsuario.TabIndex = 120;
            this.btnNuevoUsuario.Text = "NUEVO USUARIO";
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // FormAdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 621);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVerActivosPorOrganismo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbOrganismos);
            this.Controls.Add(this.btnVerUsuariosInactivos);
            this.Controls.Add(this.btnVerUsuariosActivos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdministrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRAR USUARIOS";
            this.Load += new System.EventHandler(this.FormAdministrarUsuarios_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrganismo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeshabilitarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Button btnVerUsuariosActivos;
        private System.Windows.Forms.Button btnVerUsuariosInactivos;
        private System.Windows.Forms.ComboBox cmbOrganismos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVerActivosPorOrganismo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button btnQuitarRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdUsuarioRol;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
    }
}