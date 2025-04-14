namespace ProyCheckS_GUI
{
    partial class MDIPrincipal
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
            menuStrip1 = new MenuStrip();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            pacienteToolStripMenuItem = new ToolStripMenuItem();
            medicoToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            listaDeConsultasDePacientesToolStripMenuItem = new ToolStripMenuItem();
            obtenerConsultasPorFechaToolStripMenuItem = new ToolStripMenuItem();
            nConsultasPorEspecialidadToolStripMenuItem = new ToolStripMenuItem();
            consultasAsigandasAMedicoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientosToolStripMenuItem, consultasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pacienteToolStripMenuItem, medicoToolStripMenuItem });
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(106, 20);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.Image = TestWindows_WCF_CheckSalud.Properties.Resources.paciente;
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(119, 22);
            pacienteToolStripMenuItem.Text = "Paciente";
            pacienteToolStripMenuItem.Click += pacienteToolStripMenuItem_Click;
            // 
            // medicoToolStripMenuItem
            // 
            medicoToolStripMenuItem.Image = TestWindows_WCF_CheckSalud.Properties.Resources.doctor;
            medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            medicoToolStripMenuItem.Size = new Size(119, 22);
            medicoToolStripMenuItem.Text = "Medico";
            medicoToolStripMenuItem.Click += medicoToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeConsultasDePacientesToolStripMenuItem, obtenerConsultasPorFechaToolStripMenuItem, nConsultasPorEspecialidadToolStripMenuItem, consultasAsigandasAMedicoToolStripMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(71, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listaDeConsultasDePacientesToolStripMenuItem
            // 
            listaDeConsultasDePacientesToolStripMenuItem.Name = "listaDeConsultasDePacientesToolStripMenuItem";
            listaDeConsultasDePacientesToolStripMenuItem.Size = new Size(233, 22);
            listaDeConsultasDePacientesToolStripMenuItem.Text = "Listar Consultas por Paciente";
            listaDeConsultasDePacientesToolStripMenuItem.Click += listaDeConsultasDePacientesToolStripMenuItem_Click;
            // 
            // obtenerConsultasPorFechaToolStripMenuItem
            // 
            obtenerConsultasPorFechaToolStripMenuItem.Name = "obtenerConsultasPorFechaToolStripMenuItem";
            obtenerConsultasPorFechaToolStripMenuItem.Size = new Size(233, 22);
            obtenerConsultasPorFechaToolStripMenuItem.Text = "Obtener Consultas por Fecha";
            obtenerConsultasPorFechaToolStripMenuItem.Click += obtenerConsultasPorFechaToolStripMenuItem_Click;
            // 
            // nConsultasPorEspecialidadToolStripMenuItem
            // 
            nConsultasPorEspecialidadToolStripMenuItem.Name = "nConsultasPorEspecialidadToolStripMenuItem";
            nConsultasPorEspecialidadToolStripMenuItem.Size = new Size(233, 22);
            nConsultasPorEspecialidadToolStripMenuItem.Text = "N° Consultas por Especialidad";
            nConsultasPorEspecialidadToolStripMenuItem.Click += nConsultasPorEspecialidadToolStripMenuItem_Click;
            // 
            // consultasAsigandasAMedicoToolStripMenuItem
            // 
            consultasAsigandasAMedicoToolStripMenuItem.Name = "consultasAsigandasAMedicoToolStripMenuItem";
            consultasAsigandasAMedicoToolStripMenuItem.Size = new Size(233, 22);
            consultasAsigandasAMedicoToolStripMenuItem.Text = "Consultas asigandas a Medico";
            consultasAsigandasAMedicoToolStripMenuItem.Click += consultasAsigandasAMedicoToolStripMenuItem_Click;
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            BackgroundImage = TestWindows_WCF_CheckSalud.Properties.Resources.wallpaperbetter;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MDIPrincipal";
            Text = "MDIPrincipal";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            FormClosed += MDIPrincipal_FormClosed;
            Load += MDIPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem pacienteToolStripMenuItem;
        private ToolStripMenuItem medicoToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem listaDeConsultasDePacientesToolStripMenuItem;
        private ToolStripMenuItem obtenerConsultasPorFechaToolStripMenuItem;
        private ToolStripMenuItem nConsultasPorEspecialidadToolStripMenuItem;
        private ToolStripMenuItem consultasAsigandasAMedicoToolStripMenuItem;
    }
}