﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaARD.Vistas
{
    public partial class ListaEmpleados : Form
    {
        private Empleados empleados = new Empleados();
        public ListaEmpleados()
        {
            InitializeComponent();
        }

        private void ListaEmpleados_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        void CargarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dataGridView1.DataSource = db.Empleados.ToList<Empleados>();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var employee = db.Empleados.Where(a => a.Apellidos == txtApellido.Text);
                if(employee == null)
                {
                    MessageBox.Show("El empleado que intenta buscar no existe");
                }
                else
                {
                    dataGridView1.DataSource = employee;
                }
            }
        }
    }
}