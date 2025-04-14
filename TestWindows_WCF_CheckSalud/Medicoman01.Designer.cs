namespace ProyCheckS_GUI
{
    partial class Medicoman01
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
            txt1 = new Label();
            txtFiltro = new TextBox();
            dtgDatos = new DataGridView();
            lbl2 = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            lblRegistro = new Label();
            codMedico = new DataGridViewTextBoxColumn();
            nomMedico = new DataGridViewTextBoxColumn();
            apeMedico = new DataGridViewTextBoxColumn();
            numColegiatura = new DataGridViewTextBoxColumn();
            FecNacMedico = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            Especialidad = new DataGridViewTextBoxColumn();
            LoginUsuario = new DataGridViewTextBoxColumn();
            DirecMedico = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.Location = new Point(109, 26);
            txt1.Name = "txt1";
            txt1.Size = new Size(161, 15);
            txt1.TabIndex = 0;
            txt1.Text = "Ingrese filtro por descripcion:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(288, 23);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(246, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { codMedico, nomMedico, apeMedico, numColegiatura, FecNacMedico, Edad, estado, Especialidad, LoginUsuario, DirecMedico });
            dtgDatos.Location = new Point(0, 56);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(978, 370);
            dtgDatos.TabIndex = 2;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(783, 440);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(50, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "Registro";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(602, 474);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(693, 474);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(783, 474);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(877, 474);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblRegistro
            // 
            lblRegistro.BackColor = SystemColors.Control;
            lblRegistro.BorderStyle = BorderStyle.FixedSingle;
            lblRegistro.Location = new Point(839, 439);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(100, 23);
            lblRegistro.TabIndex = 3;
            // 
            // codMedico
            // 
            codMedico.DataPropertyName = "codMedico";
            codMedico.FillWeight = 50F;
            codMedico.HeaderText = "Codigo";
            codMedico.Name = "codMedico";
            codMedico.ReadOnly = true;
            codMedico.Width = 60;
            // 
            // nomMedico
            // 
            nomMedico.DataPropertyName = "nomMedico";
            nomMedico.HeaderText = "Nombre";
            nomMedico.Name = "nomMedico";
            nomMedico.ReadOnly = true;
            // 
            // apeMedico
            // 
            apeMedico.DataPropertyName = "apeMedico";
            apeMedico.HeaderText = "Apellidos";
            apeMedico.Name = "apeMedico";
            apeMedico.ReadOnly = true;
            // 
            // numColegiatura
            // 
            numColegiatura.DataPropertyName = "numColegiatura";
            numColegiatura.HeaderText = "Numero de colegiatura";
            numColegiatura.Name = "numColegiatura";
            numColegiatura.ReadOnly = true;
            // 
            // FecNacMedico
            // 
            FecNacMedico.DataPropertyName = "FecNacMedico";
            FecNacMedico.HeaderText = "Fecha de Nacimiento";
            FecNacMedico.Name = "FecNacMedico";
            FecNacMedico.ReadOnly = true;
            // 
            // Edad
            // 
            Edad.DataPropertyName = "Edad";
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            // 
            // estado
            // 
            estado.DataPropertyName = "estado";
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // Especialidad
            // 
            Especialidad.DataPropertyName = "Especialidad";
            Especialidad.HeaderText = "Especialidad";
            Especialidad.Name = "Especialidad";
            Especialidad.ReadOnly = true;
            // 
            // LoginUsuario
            // 
            LoginUsuario.DataPropertyName = "LoginUsuario";
            LoginUsuario.HeaderText = "Login de Usuario";
            LoginUsuario.Name = "LoginUsuario";
            LoginUsuario.ReadOnly = true;
            // 
            // DirecMedico
            // 
            DirecMedico.DataPropertyName = "DirecMedico";
            DirecMedico.HeaderText = "Direccion";
            DirecMedico.Name = "DirecMedico";
            DirecMedico.ReadOnly = true;
            // 
            // Medicoman01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(999, 502);
            Controls.Add(lblRegistro);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(lbl2);
            Controls.Add(dtgDatos);
            Controls.Add(txtFiltro);
            Controls.Add(txt1);
            Name = "Medicoman01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Medicos";
            Load += Medicoman01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt1;
        private TextBox txtFiltro;
        private DataGridView dtgDatos;
        private Label lbl2;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label lblRegistro;
        private DataGridViewTextBoxColumn codMedico;
        private DataGridViewTextBoxColumn nomMedico;
        private DataGridViewTextBoxColumn apeMedico;
        private DataGridViewTextBoxColumn numColegiatura;
        private DataGridViewTextBoxColumn FecNacMedico;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn Especialidad;
        private DataGridViewTextBoxColumn LoginUsuario;
        private DataGridViewTextBoxColumn DirecMedico;
    }
}