﻿namespace ReservacionesHoteles
{
    partial class MDIMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMenu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDeHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaDeHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeClientesToolStripMenuItem,
            this.gestionDeHabitacionesToolStripMenuItem,
            this.gestionDeReservasToolStripMenuItem,
            this.SalirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDeClientesToolStripMenuItem});
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            // 
            // informacionDeClientesToolStripMenuItem
            // 
            this.informacionDeClientesToolStripMenuItem.Name = "informacionDeClientesToolStripMenuItem";
            this.informacionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.informacionDeClientesToolStripMenuItem.Text = "Informacion de Clientes";
            this.informacionDeClientesToolStripMenuItem.Click += new System.EventHandler(this.InformacionDeClientesToolStripMenuItem_Click);
            // 
            // gestionDeHabitacionesToolStripMenuItem
            // 
            this.gestionDeHabitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDeHabitacionesToolStripMenuItem});
            this.gestionDeHabitacionesToolStripMenuItem.Name = "gestionDeHabitacionesToolStripMenuItem";
            this.gestionDeHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.gestionDeHabitacionesToolStripMenuItem.Text = "Gestion de Habitaciones";
            // 
            // informacionDeHabitacionesToolStripMenuItem
            // 
            this.informacionDeHabitacionesToolStripMenuItem.Name = "informacionDeHabitacionesToolStripMenuItem";
            this.informacionDeHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.informacionDeHabitacionesToolStripMenuItem.Text = "Informacion de Habitaciones";
            // 
            // gestionDeReservasToolStripMenuItem
            // 
            this.gestionDeReservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaDeHabitacionesToolStripMenuItem});
            this.gestionDeReservasToolStripMenuItem.Name = "gestionDeReservasToolStripMenuItem";
            this.gestionDeReservasToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.gestionDeReservasToolStripMenuItem.Text = "Gestion de Reservas";
            // 
            // reservaDeHabitacionesToolStripMenuItem
            // 
            this.reservaDeHabitacionesToolStripMenuItem.Name = "reservaDeHabitacionesToolStripMenuItem";
            this.reservaDeHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.reservaDeHabitacionesToolStripMenuItem.Text = "Reserva de Habitaciones";
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.SalirToolStripMenuItem.Text = "Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.Size = new System.Drawing.Size(884, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MDIMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 621);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIMenu";
            this.Text = "MDIMenu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDeHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaDeHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
    }
}



