namespace TestWindows_WCF_CheckSalud
{
    partial class ListarConsultaPacientes
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            cmbFiltro1 = new ComboBox();
            chkConsulta1 = new CheckBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            nomMedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomPacienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codMedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codPacienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            especialidadMedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motivoConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resultadoConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalConsultasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resultConsultasBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultConsultasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(607, 121);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbFiltro1);
            groupBox1.Controls.Add(chkConsulta1);
            groupBox1.Location = new Point(309, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 113);
            groupBox1.TabIndex = 7;
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
            chkConsulta1.CheckedChanged += chkConsulta1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 122);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Paciente(DNI)";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nomMedicoDataGridViewTextBoxColumn, nomPacienteDataGridViewTextBoxColumn, codConsultaDataGridViewTextBoxColumn, codMedicoDataGridViewTextBoxColumn, codPacienteDataGridViewTextBoxColumn, especialidadMedicoDataGridViewTextBoxColumn, estadoConsultaDataGridViewTextBoxColumn, fechConsultaDataGridViewTextBoxColumn, motivoConsultaDataGridViewTextBoxColumn, resultadoConsultaDataGridViewTextBoxColumn, totalConsultasDataGridViewTextBoxColumn });
            dataGridView1.DataSource = resultConsultasBindingSource;
            dataGridView1.Location = new Point(32, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(863, 311);
            dataGridView1.TabIndex = 9;
            // 
            // nomMedicoDataGridViewTextBoxColumn
            // 
            nomMedicoDataGridViewTextBoxColumn.DataPropertyName = "NomMedico";
            nomMedicoDataGridViewTextBoxColumn.HeaderText = "NomMedico";
            nomMedicoDataGridViewTextBoxColumn.Name = "nomMedicoDataGridViewTextBoxColumn";
            // 
            // nomPacienteDataGridViewTextBoxColumn
            // 
            nomPacienteDataGridViewTextBoxColumn.DataPropertyName = "NomPaciente";
            nomPacienteDataGridViewTextBoxColumn.HeaderText = "NomPaciente";
            nomPacienteDataGridViewTextBoxColumn.Name = "nomPacienteDataGridViewTextBoxColumn";
            // 
            // codConsultaDataGridViewTextBoxColumn
            // 
            codConsultaDataGridViewTextBoxColumn.DataPropertyName = "codConsulta";
            codConsultaDataGridViewTextBoxColumn.HeaderText = "codConsulta";
            codConsultaDataGridViewTextBoxColumn.Name = "codConsultaDataGridViewTextBoxColumn";
            // 
            // codMedicoDataGridViewTextBoxColumn
            // 
            codMedicoDataGridViewTextBoxColumn.DataPropertyName = "codMedico";
            codMedicoDataGridViewTextBoxColumn.HeaderText = "codMedico";
            codMedicoDataGridViewTextBoxColumn.Name = "codMedicoDataGridViewTextBoxColumn";
            // 
            // codPacienteDataGridViewTextBoxColumn
            // 
            codPacienteDataGridViewTextBoxColumn.DataPropertyName = "codPaciente";
            codPacienteDataGridViewTextBoxColumn.HeaderText = "codPaciente";
            codPacienteDataGridViewTextBoxColumn.Name = "codPacienteDataGridViewTextBoxColumn";
            // 
            // especialidadMedicoDataGridViewTextBoxColumn
            // 
            especialidadMedicoDataGridViewTextBoxColumn.DataPropertyName = "especialidadMedico";
            especialidadMedicoDataGridViewTextBoxColumn.HeaderText = "especialidadMedico";
            especialidadMedicoDataGridViewTextBoxColumn.Name = "especialidadMedicoDataGridViewTextBoxColumn";
            // 
            // estadoConsultaDataGridViewTextBoxColumn
            // 
            estadoConsultaDataGridViewTextBoxColumn.DataPropertyName = "estadoConsulta";
            estadoConsultaDataGridViewTextBoxColumn.HeaderText = "estadoConsulta";
            estadoConsultaDataGridViewTextBoxColumn.Name = "estadoConsultaDataGridViewTextBoxColumn";
            // 
            // fechConsultaDataGridViewTextBoxColumn
            // 
            fechConsultaDataGridViewTextBoxColumn.DataPropertyName = "fechConsulta";
            fechConsultaDataGridViewTextBoxColumn.HeaderText = "fechConsulta";
            fechConsultaDataGridViewTextBoxColumn.Name = "fechConsultaDataGridViewTextBoxColumn";
            // 
            // motivoConsultaDataGridViewTextBoxColumn
            // 
            motivoConsultaDataGridViewTextBoxColumn.DataPropertyName = "motivoConsulta";
            motivoConsultaDataGridViewTextBoxColumn.HeaderText = "motivoConsulta";
            motivoConsultaDataGridViewTextBoxColumn.Name = "motivoConsultaDataGridViewTextBoxColumn";
            // 
            // resultadoConsultaDataGridViewTextBoxColumn
            // 
            resultadoConsultaDataGridViewTextBoxColumn.DataPropertyName = "resultadoConsulta";
            resultadoConsultaDataGridViewTextBoxColumn.HeaderText = "resultadoConsulta";
            resultadoConsultaDataGridViewTextBoxColumn.Name = "resultadoConsultaDataGridViewTextBoxColumn";
            // 
            // totalConsultasDataGridViewTextBoxColumn
            // 
            totalConsultasDataGridViewTextBoxColumn.DataPropertyName = "totalConsultas";
            totalConsultasDataGridViewTextBoxColumn.HeaderText = "totalConsultas";
            totalConsultasDataGridViewTextBoxColumn.Name = "totalConsultasDataGridViewTextBoxColumn";
            // 
            // resultConsultasBindingSource
            // 
            resultConsultasBindingSource.DataSource = typeof(ProxyConsultas.ResultConsultas);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 119);
            textBox1.MaxLength = 8;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 10;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // ListarConsultaPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 563);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListarConsultaPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarConsultaPacientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultConsultasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private ComboBox cmbFiltro1;
        private CheckBox chkConsulta1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nomMedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomPacienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codMedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codPacienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn especialidadMedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motivoConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resultadoConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalConsultasDataGridViewTextBoxColumn;
        private BindingSource resultConsultasBindingSource;
        private TextBox textBox1;
    }
}