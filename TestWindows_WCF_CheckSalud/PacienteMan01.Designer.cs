namespace ProyCheckS_GUI
{
    partial class PacienteMan01
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
            txtFiltro = new TextBox();
            dtgDatos = new DataGridView();
            CodPaciente = new DataGridViewTextBoxColumn();
            ApeNomPaciente = new DataGridViewTextBoxColumn();
            FecNacPaciente = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            TipoSangre = new DataGridViewTextBoxColumn();
            DniPaciente = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            DirecPaciente = new DataGridViewTextBoxColumn();
            EmailPaciente = new DataGridViewTextBoxColumn();
            TelPaciente = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            LugarTrabajo = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lblRegistros = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese filtro por apellido";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(181, 17);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(304, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { CodPaciente, ApeNomPaciente, FecNacPaciente, Edad, TipoSangre, DniPaciente, Sexo, DirecPaciente, EmailPaciente, TelPaciente, Tipo, LugarTrabajo });
            dtgDatos.Location = new Point(12, 54);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.Size = new Size(1001, 420);
            dtgDatos.TabIndex = 2;
            // 
            // CodPaciente
            // 
            CodPaciente.DataPropertyName = "CodPaciente";
            CodPaciente.HeaderText = "Codigo";
            CodPaciente.Name = "CodPaciente";
            CodPaciente.ReadOnly = true;
            CodPaciente.Width = 65;
            // 
            // ApeNomPaciente
            // 
            ApeNomPaciente.DataPropertyName = "ApeNomPaciente";
            ApeNomPaciente.HeaderText = "Apellidos y Nombres";
            ApeNomPaciente.Name = "ApeNomPaciente";
            ApeNomPaciente.ReadOnly = true;
            ApeNomPaciente.Width = 130;
            // 
            // FecNacPaciente
            // 
            FecNacPaciente.DataPropertyName = "FecNacPaciente";
            FecNacPaciente.HeaderText = "Fecha de Nacimiento";
            FecNacPaciente.Name = "FecNacPaciente";
            FecNacPaciente.ReadOnly = true;
            FecNacPaciente.Width = 75;
            // 
            // Edad
            // 
            Edad.DataPropertyName = "Edad";
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            Edad.Width = 40;
            // 
            // TipoSangre
            // 
            TipoSangre.DataPropertyName = "TipoSangre";
            TipoSangre.HeaderText = "TipoSangre";
            TipoSangre.Name = "TipoSangre";
            TipoSangre.ReadOnly = true;
            TipoSangre.Width = 80;
            // 
            // DniPaciente
            // 
            DniPaciente.DataPropertyName = "DniPaciente";
            DniPaciente.HeaderText = "Dni";
            DniPaciente.Name = "DniPaciente";
            DniPaciente.ReadOnly = true;
            DniPaciente.Width = 70;
            // 
            // Sexo
            // 
            Sexo.DataPropertyName = "Sexo";
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            Sexo.Width = 70;
            // 
            // DirecPaciente
            // 
            DirecPaciente.DataPropertyName = "DirecPaciente";
            DirecPaciente.HeaderText = "Direccion";
            DirecPaciente.Name = "DirecPaciente";
            DirecPaciente.ReadOnly = true;
            // 
            // EmailPaciente
            // 
            EmailPaciente.DataPropertyName = "EmailPaciente";
            EmailPaciente.HeaderText = "Correo";
            EmailPaciente.Name = "EmailPaciente";
            EmailPaciente.ReadOnly = true;
            // 
            // TelPaciente
            // 
            TelPaciente.DataPropertyName = "TelPaciente";
            TelPaciente.HeaderText = "Telefono";
            TelPaciente.Name = "TelPaciente";
            TelPaciente.ReadOnly = true;
            TelPaciente.Width = 80;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo Cliente";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 90;
            // 
            // LugarTrabajo
            // 
            LugarTrabajo.DataPropertyName = "LugarTrabajo";
            LugarTrabajo.HeaderText = "LugarTrabajo";
            LugarTrabajo.Name = "LugarTrabajo";
            LugarTrabajo.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(850, 480);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Registros";
            // 
            // lblRegistros
            // 
            lblRegistros.BackColor = SystemColors.Control;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.ForeColor = SystemColors.ControlText;
            lblRegistros.Location = new Point(911, 479);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 25);
            lblRegistros.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(515, 518);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 33);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(627, 518);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(95, 33);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(739, 518);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 33);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(900, 518);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(95, 33);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // PacienteMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1025, 561);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgDatos);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Name = "PacienteMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de pacientes";
            Load += PacienteMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltro;
        private DataGridView dtgDatos;
        private Label label2;
        private Label lblRegistros;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private DataGridViewTextBoxColumn CodPaciente;
        private DataGridViewTextBoxColumn ApeNomPaciente;
        private DataGridViewTextBoxColumn FecNacPaciente;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn TipoSangre;
        private DataGridViewTextBoxColumn DniPaciente;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn DirecPaciente;
        private DataGridViewTextBoxColumn EmailPaciente;
        private DataGridViewTextBoxColumn TelPaciente;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn LugarTrabajo;
    }
}