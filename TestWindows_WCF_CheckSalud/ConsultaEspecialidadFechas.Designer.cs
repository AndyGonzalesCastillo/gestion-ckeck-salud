namespace TestWindows_WCF_CheckSalud
{
    partial class ConsultaEspecialidadFechas
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
            dataGridView1 = new DataGridView();
            especialidadMedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalConsultasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resultConsultasBindingSource = new BindingSource(components);
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultConsultasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { especialidadMedicoDataGridViewTextBoxColumn, totalConsultasDataGridViewTextBoxColumn });
            dataGridView1.DataSource = resultConsultasBindingSource;
            dataGridView1.Location = new Point(117, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(292, 205);
            dataGridView1.TabIndex = 0;
            // 
            // especialidadMedicoDataGridViewTextBoxColumn
            // 
            especialidadMedicoDataGridViewTextBoxColumn.DataPropertyName = "especialidadMedico";
            especialidadMedicoDataGridViewTextBoxColumn.HeaderText = "Especialidad";
            especialidadMedicoDataGridViewTextBoxColumn.Name = "especialidadMedicoDataGridViewTextBoxColumn";
            // 
            // totalConsultasDataGridViewTextBoxColumn
            // 
            totalConsultasDataGridViewTextBoxColumn.DataPropertyName = "totalConsultas";
            totalConsultasDataGridViewTextBoxColumn.HeaderText = "Total de Consultas";
            totalConsultasDataGridViewTextBoxColumn.Name = "totalConsultasDataGridViewTextBoxColumn";
            totalConsultasDataGridViewTextBoxColumn.Width = 150;
            // 
            // resultConsultasBindingSource
            // 
            resultConsultasBindingSource.DataSource = typeof(ProxyConsultas.ResultConsultas);
            // 
            // button1
            // 
            button1.Location = new Point(116, 173);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(194, 74);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 77);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Fecha Inicio:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(194, 119);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(214, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 125);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha Final";
            // 
            // ConsultaEspecialidadFechas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultaEspecialidadFechas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaEspecialidadFechas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultConsultasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DataGridViewTextBoxColumn especialidadMedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalConsultasDataGridViewTextBoxColumn;
        private BindingSource resultConsultasBindingSource;
    }
}