﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaARD.Vistas
{
    public partial class RegistroEmpleados : Form
    {
        private Empleados empleado = new Empleados();
        public string texto = "";
        
        public RegistroEmpleados()
        {
            InitializeComponent();
        }

        private void RegistroEmpleados_Load(object sender, EventArgs e)
        {
            Clear();
            CargarGeneros();
            CargarAfps();
            CargarEstados();
            lblId.Text = texto;
            if(texto != "")
            {
                LlenarTextbox();
                btnRegistrar.Text = "Actualizar";
                
            }
        }

        void Clear()
        {
            txtNombres.Text = txtApellidos.Text = txtDireccion.Text = txtNumeroDui.Text = txtNumeroNit.Text = txtNumeroIsss.Text = txtNup.Text = "";
            cbxEstado.Text = "";
            cbxNombreAfp.Text = "";
            cbxGenero.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaIngreso.Value = DateTime.Now;
        }

        void CargarGeneros()
        {
            using (DBEntities db = new DBEntities())
            {
                cbxGenero.DataSource = db.Generos.ToList<Generos>();
                
                cbxGenero.DisplayMember = "Nombre";
                cbxGenero.ValueMember = "Id";
            }

        }

        void CargarAfps()
        {
            using (DBEntities db = new DBEntities())
            {
                cbxNombreAfp.DataSource = db.Afps.ToList<Afps>();

                cbxNombreAfp.DisplayMember = "Nombre";
                cbxNombreAfp.ValueMember = "Id";
            }

        }

        void CargarEstados()
        {
            using (DBEntities db = new DBEntities())
            {
                cbxEstado.DataSource = db.Estados.ToList<Estados>();

                cbxEstado.DisplayMember = "Nombre";
                cbxEstado.ValueMember = "Id";
            }

        }

        void LlenarTextbox()
        {
            
                int id = int.Parse(texto);
                using (DBEntities db = new DBEntities())
                {
                    empleado = db.Empleados.Where(x => x.Id == id).FirstOrDefault();
                    txtNombres.Text = empleado.Nombres;
                    txtApellidos.Text = empleado.Apellidos;
                    dtpFechaNacimiento.Value = empleado.FechaNacimiento;
                    txtDireccion.Text = empleado.Direccion;
                    cbxGenero.SelectedValue = empleado.Genero_Id;
                    txtNumeroDui.Text = empleado.N_Dui;
                    txtNumeroNit.Text = empleado.N_Nit;
                    cbxNombreAfp.SelectedValue = empleado.Afp_Id;
                    txtNup.Text = empleado.N_Afp;
                    txtNumeroIsss.Text = empleado.N_Isss;
                    dtpFechaIngreso.Value = empleado.FechaIngreso;
                    cbxEstado.SelectedValue = empleado.Estado_Id;
                }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe ingresar todos los campos");
            }
            else
            {
                
                    empleado.Nombres = txtNombres.Text.Trim();
                    empleado.Apellidos = txtApellidos.Text.Trim();
                    empleado.FechaNacimiento = dtpFechaNacimiento.Value;
                    empleado.Direccion = txtDireccion.Text.Trim();
                    empleado.Genero_Id = Convert.ToInt32(cbxGenero.SelectedValue);
                    empleado.N_Dui = txtNumeroDui.Text;
                    empleado.Afp_Id = Convert.ToInt32(cbxNombreAfp.SelectedValue);

                    empleado.N_Afp = txtNup.Text;
                    empleado.N_Isss = txtNumeroIsss.Text;
                    empleado.N_Nit = txtNumeroNit.Text;

                    empleado.FechaIngreso = dtpFechaIngreso.Value;
                    empleado.Estado_Id = Convert.ToInt32(cbxEstado.SelectedValue);

                using (DBEntities db = new DBEntities())
                {
                    
                        try
                        {
                            if (btnRegistrar.Text == "Registrar")
                            {
                                db.Empleados.Add(empleado);
                            }
                            else
                            {
                                db.Entry(empleado).State = EntityState.Modified;
                                texto = "";
                                btnRegistrar.Text = "Registrar";
                                this.Close();
                                MainForm principal = new MainForm();
                                principal.Show();
                            }
                            db.SaveChanges();
                            MessageBox.Show("Datos del empleado almacenados correctamente");
                        }
                        catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                        {
                            Exception raise = dbEx;
                            foreach (var validationErrors in dbEx.EntityValidationErrors)
                            {
                                foreach (var validationError in validationErrors.ValidationErrors)
                                {
                                    string message = string.Format("{0}:{1}",
                                        validationErrors.Entry.Entity.ToString(),
                                        validationError.ErrorMessage);
                                    // raise a new exception nesting
                                    // the current instance as InnerException
                                    raise = new InvalidOperationException(message, raise);
                                }
                            }
                            throw raise;
                        }
                    
                    Clear();
                }

            }

        }
    }
}
