namespace ProyCheckS_GUI
{
    partial class PacienteMan03
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
            btnCancelar = new Button();
            btnAgregar = new Button();
            cboSangre = new ComboBox();
            cboUbigeo = new ComboBox();
            cboEmpresa = new ComboBox();
            cboCliente = new ComboBox();
            cboSexo = new ComboBox();
            dtpIngreso = new DateTimePicker();
            dtpNacimiento = new DateTimePicker();
            txtNombres = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            txtApellidos = new TextBox();
            label2 = new Label();
            label13 = new Label();
            lblUbigeo = new Label();
            label8 = new Label();
            lblEmpresa = new Label();
            label7 = new Label();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblCodigo = new Label();
            label11 = new Label();
            txtDNI = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(633, 336);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 33);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(490, 336);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 33);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "Grabar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cboSangre
            // 
            cboSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSangre.FormattingEnabled = true;
            cboSangre.Items.AddRange(new object[] { "--Seleccione--", "A+", "B+", "AB+", "O+", "A-", "B-", "AB-", "O-" });
            cboSangre.Location = new Point(574, 25);
            cboSangre.Name = "cboSangre";
            cboSangre.Size = new Size(121, 23);
            cboSangre.TabIndex = 3;
            // 
            // cboUbigeo
            // 
            cboUbigeo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUbigeo.FormattingEnabled = true;
            cboUbigeo.Location = new Point(80, 253);
            cboUbigeo.Name = "cboUbigeo";
            cboUbigeo.Size = new Size(121, 23);
            cboUbigeo.TabIndex = 23;
            // 
            // cboEmpresa
            // 
            cboEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpresa.FormattingEnabled = true;
            cboEmpresa.Location = new Point(540, 169);
            cboEmpresa.Name = "cboEmpresa";
            cboEmpresa.Size = new Size(121, 23);
            cboEmpresa.TabIndex = 19;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Items.AddRange(new object[] { "--Seleccione--", "Gerente", "Administrativo", "Operacional" });
            cboCliente.Location = new Point(574, 133);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(121, 23);
            cboCliente.TabIndex = 15;
            // 
            // cboSexo
            // 
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "--Seleccione--", "Hombre", "Mujer" });
            cboSexo.Location = new Point(69, 177);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(121, 23);
            cboSexo.TabIndex = 17;
            // 
            // dtpIngreso
            // 
            dtpIngreso.Location = new Point(130, 291);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(316, 23);
            dtpIngreso.TabIndex = 27;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(152, 101);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(99, 23);
            dtpNacimiento.TabIndex = 9;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(90, 25);
            txtNombres.MaxLength = 99;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(240, 23);
            txtNombres.TabIndex = 1;
            txtNombres.KeyPress += txtNombres_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(540, 97);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(155, 23);
            txtTelefono.TabIndex = 11;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(524, 61);
            txtEmail.MaxLength = 320;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(91, 215);
            txtDireccion.MaxLength = 20;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(355, 23);
            txtDireccion.TabIndex = 21;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(90, 63);
            txtApellidos.MaxLength = 99;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(240, 23);
            txtApellidos.TabIndex = 5;
            txtApellidos.KeyPress += txtNombres_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 28);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombres:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(479, 102);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 10;
            label13.Text = "Telefono:";
            // 
            // lblUbigeo
            // 
            lblUbigeo.AutoSize = true;
            lblUbigeo.Location = new Point(26, 256);
            lblUbigeo.Name = "lblUbigeo";
            lblUbigeo.Size = new Size(48, 15);
            lblUbigeo.TabIndex = 22;
            lblUbigeo.Text = "Distrito:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(479, 65);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 6;
            label8.Text = "Email:";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(479, 176);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(55, 15);
            lblEmpresa.TabIndex = 18;
            lblEmpresa.Text = "Empresa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(479, 28);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 2;
            label7.Text = "Tipo de sangre:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(479, 139);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 14;
            label10.Text = "Tipo de cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 218);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 20;
            label6.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 180);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 16;
            label5.Text = "Sexo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 294);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 26;
            label9.Text = "Fecha de ingreso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 142);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 12;
            label4.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 104);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha de nacimiento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 66);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Apellidos:";
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.Fixed3D;
            lblCodigo.Location = new Point(608, 259);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(77, 17);
            lblCodigo.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(553, 261);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 24;
            label11.Text = "Codigo:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(69, 139);
            txtDNI.Mask = "99999999";
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 13;
            txtDNI.KeyPress += txtTelefono_KeyPress;
            // 
            // PacienteMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 392);
            Controls.Add(txtDNI);
            Controls.Add(label11);
            Controls.Add(lblCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(cboSangre);
            Controls.Add(cboUbigeo);
            Controls.Add(cboEmpresa);
            Controls.Add(cboCliente);
            Controls.Add(cboSexo);
            Controls.Add(dtpIngreso);
            Controls.Add(dtpNacimiento);
            Controls.Add(txtNombres);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellidos);
            Controls.Add(label2);
            Controls.Add(label13);
            Controls.Add(lblUbigeo);
            Controls.Add(label8);
            Controls.Add(lblEmpresa);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "PacienteMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar paciente";
            Load += PacienteMan03_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAgregar;
        private ComboBox cboSangre;
        private ComboBox cboUbigeo;
        private ComboBox cboEmpresa;
        private ComboBox cboCliente;
        private ComboBox cboSexo;
        private DateTimePicker dtpIngreso;
        private DateTimePicker dtpNacimiento;
        private TextBox txtNombres;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDireccion;
        private TextBox txtApellidos;
        private Label label2;
        private Label label13;
        private Label lblUbigeo;
        private Label label8;
        private Label lblEmpresa;
        private Label label7;
        private Label label10;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lblCodigo;
        private Label label11;
        private MaskedTextBox txtDNI;
    }
}