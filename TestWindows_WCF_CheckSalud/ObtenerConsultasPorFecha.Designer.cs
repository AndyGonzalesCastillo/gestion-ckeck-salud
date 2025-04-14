namespace TestWindows_WCF_CheckSalud
{
    partial class ObtenerConsultasPorFecha
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            fechConsulta = new DataGridViewTextBoxColumn();
            codConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NomMedico = new DataGridViewTextBoxColumn();
            NomPaciente = new DataGridViewTextBoxColumn();
            estadoConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motivoConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resultConsultasBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultConsultasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(134, 91);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 95);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingresar Fecha:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fechConsulta, codConsultaDataGridViewTextBoxColumn, NomMedico, NomPaciente, estadoConsultaDataGridViewTextBoxColumn, fechConsultaDataGridViewTextBoxColumn, motivoConsultaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = resultConsultasBindingSource;
            dataGridView1.Location = new Point(12, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(742, 267);
            dataGridView1.TabIndex = 2;
            // 
            // fechConsulta
            // 
            fechConsulta.DataPropertyName = "fechConsulta";
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            fechConsulta.DefaultCellStyle = dataGridViewCellStyle1;
            fechConsulta.HeaderText = "Hora";
            fechConsulta.Name = "fechConsulta";
            // 
            // codConsultaDataGridViewTextBoxColumn
            // 
            codConsultaDataGridViewTextBoxColumn.DataPropertyName = "codConsulta";
            codConsultaDataGridViewTextBoxColumn.HeaderText = "ID";
            codConsultaDataGridViewTextBoxColumn.Name = "codConsultaDataGridViewTextBoxColumn";
            // 
            // NomMedico
            // 
            NomMedico.DataPropertyName = "NomMedico";
            NomMedico.HeaderText = "Medico";
            NomMedico.Name = "NomMedico";
            // 
            // NomPaciente
            // 
            NomPaciente.DataPropertyName = "NomPaciente";
            NomPaciente.HeaderText = "Paciente";
            NomPaciente.Name = "NomPaciente";
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
            dataGridViewCellStyle2.Format = "M";
            dataGridViewCellStyle2.NullValue = null;
            fechConsultaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            fechConsultaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechConsultaDataGridViewTextBoxColumn.Name = "fechConsultaDataGridViewTextBoxColumn";
            // 
            // motivoConsultaDataGridViewTextBoxColumn
            // 
            motivoConsultaDataGridViewTextBoxColumn.DataPropertyName = "motivoConsulta";
            motivoConsultaDataGridViewTextBoxColumn.HeaderText = "Motivo";
            motivoConsultaDataGridViewTextBoxColumn.Name = "motivoConsultaDataGridViewTextBoxColumn";
            // 
            // resultConsultasBindingSource
            // 
            resultConsultasBindingSource.DataSource = typeof(ProxyConsultas.ResultConsultas);
            // 
            // button1
            // 
            button1.Location = new Point(357, 93);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ObtenerConsultasPorFecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ObtenerConsultasPorFecha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ObtenerConsultasPorFecha";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultConsultasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource resultConsultasBindingSource;
        private Button button1;
        private DataGridViewTextBoxColumn fechConsulta;
        private DataGridViewTextBoxColumn codConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NomMedico;
        private DataGridViewTextBoxColumn NomPaciente;
        private DataGridViewTextBoxColumn estadoConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motivoConsultaDataGridViewTextBoxColumn;
    }
}