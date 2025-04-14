namespace ProyCheckS_GUI
{
    partial class MedicoMan03
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
            btnCerrar = new Button();
            btnActualizar = new Button();
            label11 = new Label();
            cboDistrito = new ComboBox();
            cboEspecialidad = new ComboBox();
            dtpIngreso = new DateTimePicker();
            chkestado = new CheckBox();
            dtpNacimiento = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDireccion = new TextBox();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label6 = new Label();
            txtDni = new MaskedTextBox();
            txtNumColegiatura = new MaskedTextBox();
            lblCodigo = new Label();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(656, 311);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(92, 33);
            btnCerrar.TabIndex = 24;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(515, 311);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(92, 33);
            btnActualizar.TabIndex = 23;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(468, 217);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 18;
            label11.Text = "Distrito:";
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(583, 212);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(165, 23);
            cboDistrito.TabIndex = 19;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Location = new Point(583, 166);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(165, 23);
            cboEspecialidad.TabIndex = 15;
            // 
            // dtpIngreso
            // 
            dtpIngreso.Location = new Point(167, 253);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(200, 23);
            dtpIngreso.TabIndex = 21;
            // 
            // chkestado
            // 
            chkestado.AutoSize = true;
            chkestado.Location = new Point(456, 258);
            chkestado.Name = "chkestado";
            chkestado.Size = new Size(73, 19);
            chkestado.TabIndex = 22;
            chkestado.Text = "Activado";
            chkestado.UseVisualStyleBackColor = true;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(167, 208);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(104, 23);
            dtpNacimiento.TabIndex = 17;
            dtpNacimiento.Value = new DateTime(2022, 11, 2, 0, 0, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(431, 170);
            label10.Name = "label10";
            label10.Size = new Size(117, 15);
            label10.TabIndex = 14;
            label10.Text = "Codigo Especialidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 259);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 20;
            label9.Text = "Fecha de ingreso:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(437, 123);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 10;
            label7.Text = "Dirección:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(456, 76);
            label.Name = "label";
            label.Size = new Size(42, 15);
            label.TabIndex = 6;
            label.Text = "Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 213);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 16;
            label5.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 167);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 12;
            label4.Text = "Numero Colegiatura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 121);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 29);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "Dni:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(520, 120);
            txtDireccion.MaxLength = 99;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(228, 23);
            txtDireccion.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(520, 74);
            txtEmail.MaxLength = 320;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(140, 118);
            txtApellido.MaxLength = 20;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(227, 23);
            txtApellido.TabIndex = 9;
            txtApellido.KeyPress += txtNombre_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 73);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 23);
            txtNombre.TabIndex = 5;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 75);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombres:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 29);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 0;
            label6.Text = "Código:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(520, 28);
            txtDni.Mask = "99999999";
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 3;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtNumColegiatura
            // 
            txtNumColegiatura.Location = new Point(167, 163);
            txtNumColegiatura.Mask = "999999999";
            txtNumColegiatura.Name = "txtNumColegiatura";
            txtNumColegiatura.Size = new Size(73, 23);
            txtNumColegiatura.TabIndex = 13;
            txtNumColegiatura.KeyPress += txtDni_KeyPress;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.Fixed3D;
            lblCodigo.Location = new Point(140, 28);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(100, 23);
            lblCodigo.TabIndex = 1;
            // 
            // MedicoMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(787, 359);
            Controls.Add(lblCodigo);
            Controls.Add(txtNumColegiatura);
            Controls.Add(txtDni);
            Controls.Add(label6);
            Controls.Add(btnCerrar);
            Controls.Add(btnActualizar);
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
            Name = "MedicoMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Medico:";
            Load += MedicoMan03_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnActualizar;
        private Label label11;
        private ComboBox cboDistrito;
        private ComboBox cboEspecialidad;
        private DateTimePicker dtpIngreso;
        private CheckBox chkestado;
        private DateTimePicker dtpNacimiento;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label1;
        private Label label6;
        private MaskedTextBox txtDni;
        private MaskedTextBox txtNumColegiatura;
        private Label lblCodigo;
    }
}