namespace ProyCheckS_GUI
{
    partial class MedicoMan02
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            dtpNacimiento = new DateTimePicker();
            chkestado = new CheckBox();
            dtpIngreso = new DateTimePicker();
            cboEspecialidad = new ComboBox();
            cboDistrito = new ComboBox();
            label11 = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            txtLogin = new TextBox();
            txtDni = new MaskedTextBox();
            txtNumColegiatura = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 28);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 23);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(112, 77);
            txtApellido.MaxLength = 20;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(223, 23);
            txtApellido.TabIndex = 5;
            txtApellido.KeyPress += txtNombre_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(522, 77);
            txtEmail.MaxLength = 320;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(522, 126);
            txtDireccion.MaxLength = 99;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(240, 23);
            txtDireccion.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 31);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "Dni:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 80);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 129);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 8;
            label4.Text = "Numero Colegiatura:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 178);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 12;
            label5.Text = "Fecha de nacimiento:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(456, 80);
            label.Name = "label";
            label.Size = new Size(42, 15);
            label.TabIndex = 6;
            label.Text = "Email: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(438, 129);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 10;
            label7.Text = "Dirección:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 227);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 16;
            label9.Text = "Fecha de ingreso:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(425, 178);
            label10.Name = "label10";
            label10.Size = new Size(117, 15);
            label10.TabIndex = 14;
            label10.Text = "Codigo Especialidad:";
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(155, 175);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(96, 23);
            dtpNacimiento.TabIndex = 13;
            dtpNacimiento.Value = new DateTime(2022, 11, 2, 0, 0, 0, 0);
            // 
            // chkestado
            // 
            chkestado.AutoSize = true;
            chkestado.Location = new Point(462, 273);
            chkestado.Name = "chkestado";
            chkestado.Size = new Size(73, 19);
            chkestado.TabIndex = 22;
            chkestado.Text = "Activado";
            chkestado.UseVisualStyleBackColor = true;
            // 
            // dtpIngreso
            // 
            dtpIngreso.Location = new Point(155, 224);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(200, 23);
            dtpIngreso.TabIndex = 17;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Location = new Point(563, 175);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(187, 23);
            cboEspecialidad.TabIndex = 15;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(563, 224);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(187, 23);
            cboDistrito.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(487, 227);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 18;
            label11.Text = "Distrito:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(510, 326);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 36);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(650, 326);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 36);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 276);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 20;
            label6.Text = "Login Usuario: ";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(155, 273);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(200, 23);
            txtLogin.TabIndex = 21;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(522, 28);
            txtDni.Mask = "99999999";
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 3;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtNumColegiatura
            // 
            txtNumColegiatura.Location = new Point(155, 126);
            txtNumColegiatura.Mask = "999999999";
            txtNumColegiatura.Name = "txtNumColegiatura";
            txtNumColegiatura.Size = new Size(67, 23);
            txtNumColegiatura.TabIndex = 9;
            txtNumColegiatura.KeyPress += txtDni_KeyPress;
            // 
            // MedicoMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 391);
            Controls.Add(txtNumColegiatura);
            Controls.Add(txtDni);
            Controls.Add(txtLogin);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(label11);
            Controls.Add(cboDistrito);
            Controls.Add(cboEspecialidad);
            Controls.Add(dtpIngreso);
            Controls.Add(chkestado);
            Controls.Add(dtpNacimiento);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "MedicoMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Medico:";
            Load += MedicoMan02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtDireccion;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label;
        private Label label7;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpNacimiento;
        private CheckBox chkestado;
        private DateTimePicker dtpIngreso;
        private ComboBox cboEspecialidad;
        private ComboBox cboDistrito;
        private Label label11;
        private Button btnAgregar;
        private Button btnCancelar;
        private Label label6;
        private TextBox txtLogin;
        private MaskedTextBox txtDni;
        private MaskedTextBox txtNumColegiatura;
    }
}