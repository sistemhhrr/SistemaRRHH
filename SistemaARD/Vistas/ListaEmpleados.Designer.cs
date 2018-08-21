﻿namespace SistemaARD.Vistas
{
    partial class ListaEmpleados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afp_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Afp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Isss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombres,
            this.Apellidos,
            this.FechaNacimiento,
            this.Direccion,
            this.N_Dui,
            this.N_Nit,
            this.Afp_Id,
            this.N_Afp,
            this.N_Isss,
            this.FechaIngreso,
            this.Estado_Id});
            this.dataGridView1.Location = new System.Drawing.Point(12, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(488, 19);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(110, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido del empleado";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(604, 16);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(713, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Visible = false;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // N_Dui
            // 
            this.N_Dui.DataPropertyName = "N_Dui";
            this.N_Dui.HeaderText = "DUI";
            this.N_Dui.Name = "N_Dui";
            this.N_Dui.ReadOnly = true;
            // 
            // N_Nit
            // 
            this.N_Nit.DataPropertyName = "N_Nit";
            this.N_Nit.HeaderText = "NIT";
            this.N_Nit.Name = "N_Nit";
            this.N_Nit.ReadOnly = true;
            // 
            // Afp_Id
            // 
            this.Afp_Id.DataPropertyName = "Afp_Id";
            this.Afp_Id.HeaderText = "AFP";
            this.Afp_Id.Name = "Afp_Id";
            this.Afp_Id.ReadOnly = true;
            this.Afp_Id.Visible = false;
            // 
            // N_Afp
            // 
            this.N_Afp.DataPropertyName = "N_Afp";
            this.N_Afp.HeaderText = "NUP";
            this.N_Afp.Name = "N_Afp";
            this.N_Afp.ReadOnly = true;
            // 
            // N_Isss
            // 
            this.N_Isss.DataPropertyName = "N_Isss";
            this.N_Isss.HeaderText = "ISSS";
            this.N_Isss.Name = "N_Isss";
            this.N_Isss.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Fecha de ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            // 
            // Estado_Id
            // 
            this.Estado_Id.DataPropertyName = "Estado_Id";
            this.Estado_Id.HeaderText = "Estado";
            this.Estado_Id.Name = "Estado_Id";
            this.Estado_Id.ReadOnly = true;
            this.Estado_Id.Visible = false;
            // 
            // ListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaEmpleados";
            this.Text = "Lista de empleados";
            this.Load += new System.EventHandler(this.ListaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afp_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Afp;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Isss;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Id;
    }
}