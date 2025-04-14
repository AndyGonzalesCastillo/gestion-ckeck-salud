namespace TestWindows_WCF_CheckSalud
{
    partial class ConsultasAsignadasMedico
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cmbFiltro1 = new ComboBox();
            chkConsulta1 = new CheckBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            codConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomMedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomPacienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            especialidadMedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motivoConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resultadoConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resultConsultasBindingSource = new BindingSource(components);
            cmbMedico = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultConsultasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 101);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Medico:";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbFiltro1);
            groupBox1.Controls.Add(chkConsulta1);
            groupBox1.Location = new Point(279, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 113);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro";
            // 
            // cmbFiltro1
            // 
            cmbFiltro1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro1.FormattingEnabled = true;
            cmbFiltro1.Items.AddRange(new object[] { "-- SELECCIONAR --", "Cancelada", "Pendiente", "Realizada" });
            cmbFiltro1.Location = new Point(108, 51);
            cmbFiltro1.Name = "cmbFiltro1";
            cmbFiltro1.Size = new Size(134, 23);
            cmbFiltro1.TabIndex = 1;
            // 
            // chkConsulta1
            // 
            chkConsulta1.AutoSize = true;
            chkConsulta1.Location = new Point(31, 53);
            chkConsulta1.Name = "chkConsulta1";
            chkConsulta1.Size = new Size(61, 19);
            chkConsulta1.TabIndex = 0;
            chkConsulta1.Text = "Estado";
            chkConsulta1.UseVisualStyleBackColor = true;
            chkConsulta1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(577, 100);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codConsultaDataGridViewTextBoxColumn, nomMedicoDataGridViewTextBoxColumn, nomPacienteDataGridViewTextBoxColumn, especialidadMedicoDataGridViewTextBoxColumn, estadoConsultaDataGridViewTextBoxColumn, fechConsultaDataGridViewTextBoxColumn, motivoConsultaDataGridViewTextBoxColumn, resultadoConsultaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = resultConsultasBindingSource;
            dataGridView1.Location = new Point(21, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(841, 336);
            dataGridView1.TabIndex = 3;
            // 
            // codConsultaDataGridViewTextBoxColumn
            // 
            codConsultaDataGridViewTextBoxColumn.DataPropertyName = "codConsulta";
            codConsultaDataGridViewTextBoxColumn.HeaderText = "ID";
            codConsultaDataGridViewTextBoxColumn.Name = "codConsultaDataGridViewTextBoxColumn";
            // 
            // nomMedicoDataGridViewTextBoxColumn
            // 
            nomMedicoDataGridViewTextBoxColumn.DataPropertyName = "NomMedico";
            nomMedicoDataGridViewTextBoxColumn.HeaderText = "Medico";
            nomMedicoDataGridViewTextBoxColumn.Name = "nomMedicoDataGridViewTextBoxColumn";
            // 
            // nomPacienteDataGridViewTextBoxColumn
            // 
            nomPacienteDataGridViewTextBoxColumn.DataPropertyName = "NomPaciente";
            nomPacienteDataGridViewTextBoxColumn.HeaderText = "Paciente";
            nomPacienteDataGridViewTextBoxColumn.Name = "nomPacienteDataGridViewTextBoxColumn";
            // 
            // especialidadMedicoDataGridViewTextBoxColumn
            // 
            especialidadMedicoDataGridViewTextBoxColumn.DataPropertyName = "especialidadMedico";
            especialidadMedicoDataGridViewTextBoxColumn.HeaderText = "Especialidad";
            especialidadMedicoDataGridViewTextBoxColumn.Name = "especialidadMedicoDataGridViewTextBoxColumn";
            // 
            // estadoConsultaDataGridViewTextBoxColumn
            // 
            estadoConsultaDataGridViewTextBoxColumn.DataPropertyName = "estadoConsulta";
            estadoConsultaDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoConsultaDataGridViewTextBoxColumn.Name = "estadoConsultaDataGridViewTextBoxColumn";
            // 
            // fechConsultaDataGridViewTextBoxColumn
            // 
            fechConsultaDataGridViewTextBoxColumn.DataPropertyName = "fechConsulta";
            fechConsultaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechConsultaDataGridViewTextBoxColumn.Name = "fechConsultaDataGridViewTextBoxColumn";
            // 
            // motivoConsultaDataGridViewTextBoxColumn
            // 
            motivoConsultaDataGridViewTextBoxColumn.DataPropertyName = "motivoConsulta";
            motivoConsultaDataGridViewTextBoxColumn.HeaderText = "Motivo";
            motivoConsultaDataGridViewTextBoxColumn.Name = "motivoConsultaDataGridViewTextBoxColumn";
            // 
            // resultadoConsultaDataGridViewTextBoxColumn
            // 
            resultadoConsultaDataGridViewTextBoxColumn.DataPropertyName = "resultadoConsulta";
            resultadoConsultaDataGridViewTextBoxColumn.HeaderText = "Resultado";
            resultadoConsultaDataGridViewTextBoxColumn.Name = "resultadoConsultaDataGridViewTextBoxColumn";
            // 
            // resultConsultasBindingSource
            // 
            resultConsultasBindingSource.DataSource = typeof(ProxyConsultas.ResultConsultas);
            // 
            // cmbMedico
            // 
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(102, 97);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(146, 23);
            cmbMedico.TabIndex = 4;
            // 
            // ConsultasAsignadasMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 561);
            Controls.Add(cmbMedico);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultasAsignadasMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultasAsignadasMedico";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultConsultasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cmbFiltro1;
        private CheckBox chkConsulta1;
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource resultConsultasBindingSource;
        private ComboBox cmbMedico;
        private DataGridViewTextBoxColumn codConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomMedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomPacienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn especialidadMedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motivoConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resultadoConsultaDataGridViewTextBoxColumn;
    }
}