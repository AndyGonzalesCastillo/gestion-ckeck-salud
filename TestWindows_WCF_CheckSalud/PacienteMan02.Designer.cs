namespace ProyCheckS_GUI
{
    partial class PacienteMan02
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
            label1 = new Label();
            txtApellidos = new TextBox();
            label2 = new Label();
            txtNombres = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDireccion = new TextBox();
            dtpNacimiento = new DateTimePicker();
            cboSexo = new ComboBox();
            label7 = new Label();
            cboSangre = new ComboBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            dtpIngreso = new DateTimePicker();
            label10 = new Label();
            cboCliente = new ComboBox();
            lblEmpresa = new Label();
            cboEmpresa = new ComboBox();
            lblUbigeo = new Label();
            cboUbigeo = new ComboBox();
            label13 = new Label();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            txtDNI = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 73);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(90, 70);
            txtApellidos.MaxLength = 99;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(240, 23);
            txtApellidos.TabIndex = 5;
            txtApellidos.KeyPress += txtNombres_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 35);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombres:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(90, 32);
            txtNombres.MaxLength = 99;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(240, 23);
            txtNombres.TabIndex = 1;
            txtNombres.KeyPress += txtNombres_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 111);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 149);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 12;
            label4.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 187);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 16;
            label5.Text = "Sexo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 225);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 20;
            label6.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(90, 222);
            txtDireccion.MaxLength = 20;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(355, 23);
            txtDireccion.TabIndex = 21;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(152, 108);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(99, 23);
            dtpNacimiento.TabIndex = 9;
            dtpNacimiento.Value = new DateTime(2022, 11, 2, 0, 0, 0, 0);
            // 
            // cboSexo
            // 
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "--Seleccione--", "Hombre", "Mujer" });
            cboSexo.Location = new Point(71, 184);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(121, 23);
            cboSexo.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(479, 30);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 2;
            label7.Text = "Tipo de sangre:";
            // 
            // cboSangre
            // 
            cboSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSangre.FormattingEnabled = true;
            cboSangre.Items.AddRange(new object[] { "--Seleccione--", "A+", "B+", "AB+", "O+", "A-", "B-", "AB-", "O-" });
            cboSangre.Location = new Point(586, 27);
            cboSangre.Name = "cboSangre";
            cboSangre.Size = new Size(121, 23);
            cboSangre.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(479, 68);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 6;
            label8.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(524, 65);
            txtEmail.MaxLength = 320;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 23);
            txtEmail.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 301);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 24;
            label9.Text = "Fecha de ingreso:";
            // 
            // dtpIngreso
            // 
            dtpIngreso.Location = new Point(130, 298);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(316, 23);
            dtpIngreso.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(479, 144);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 14;
            label10.Text = "Tipo de cliente:";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Items.AddRange(new object[] { "--Seleccione--", "Gerente", "Administrativo", "Operacional" });
            cboCliente.Location = new Point(574, 141);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(121, 23);
            cboCliente.TabIndex = 15;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(479, 182);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(55, 15);
            lblEmpresa.TabIndex = 18;
            lblEmpresa.Text = "Empresa:";
            // 
            // cboEmpresa
            // 
            cboEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpresa.FormattingEnabled = true;
            cboEmpresa.Location = new Point(540, 179);
            cboEmpresa.Name = "cboEmpresa";
            cboEmpresa.Size = new Size(121, 23);
            cboEmpresa.TabIndex = 19;
            // 
            // lblUbigeo
            // 
            lblUbigeo.AutoSize = true;
            lblUbigeo.Location = new Point(26, 263);
            lblUbigeo.Name = "lblUbigeo";
            lblUbigeo.Size = new Size(48, 15);
            lblUbigeo.TabIndex = 22;
            lblUbigeo.Text = "Distrito:";
            // 
            // cboUbigeo
            // 
            cboUbigeo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUbigeo.FormattingEnabled = true;
            cboUbigeo.Location = new Point(80, 260);
            cboUbigeo.Name = "cboUbigeo";
            cboUbigeo.Size = new Size(121, 23);
            cboUbigeo.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(479, 106);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 10;
            label13.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(540, 103);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(155, 23);
            txtTelefono.TabIndex = 11;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(490, 343);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 33);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(633, 343);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 33);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(71, 146);
            txtDNI.Mask = "99999999";
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 13;
            txtDNI.KeyPress += txtTelefono_KeyPress;
            // 
            // PacienteMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 388);
            Controls.Add(txtDNI);
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
            Name = "PacienteMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo paciente";
            Load += PacienteMan02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtApellidos;
        private Label label2;
        private TextBox txtNombres;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDireccion;
        private DateTimePicker dtpNacimiento;
        private ComboBox cboSexo;
        private Label label7;
        private ComboBox cboSangre;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private DateTimePicker dtpIngreso;
        private Label label10;
        private ComboBox cboCliente;
        private Label lblEmpresa;
        private ComboBox cboEmpresa;
        private Label lblUbigeo;
        private ComboBox cboUbigeo;
        private Label label13;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Button btnCancelar;
        private MaskedTextBox txtDNI;
    }
}