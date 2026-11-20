using CapaDatos;
using CapaNegocio;
using CapaPresentacion.FuncionesGenerales;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormAdministrarUsuarios : Form
    {
        public FormAdministrarUsuarios()
        {
            InitializeComponent();
        }

        private  async void FormAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            //// Ajustar el tamaño del formulario            
            FormularioAyudas.AjustarFormulario(this);

            //CARGAR COMBO ORGANISMO
            NOrganismo nOrganismo = new NOrganismo();
            (List<DOrganismo> listaOrganismoResponse, string errorResponse) = await nOrganismo.RetornarOrganismoDestinoTodos();

            if (listaOrganismoResponse == null)
            {
                MessageBox.Show("Advertencia al cargar lista de Organismos: " + errorResponse, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            cmbOrganismos.ValueMember = "id_organismo";
            cmbOrganismos.DisplayMember = "organismo";
            cmbOrganismos.DataSource = listaOrganismoResponse;
        }

        
        private async void btnVerUsuariosActivos_Click(object sender, EventArgs e)
        {
            NUsuario nUsuario = new NUsuario();
            this.Enabled = false;
            (List<DUsuario> listaUsuariosResponse, string errorResponse) = await nUsuario.ListaUsuariosActivos();
            this.Enabled = true;

            if (listaUsuariosResponse == null)
            {
                MessageBox.Show(errorResponse, "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            this.CargarDataGridUsuarios(listaUsuariosResponse);

        }

        private async void btnVerUsuariosInactivos_Click(object sender, EventArgs e)
        {
            NUsuario nUsuario = new NUsuario();
            this.Enabled = false;
            (List<DUsuario> listaUsuariosResponse, string errorResponse) = await nUsuario.ListaUsuariosInactivos();
            this.Enabled = true;

            if (listaUsuariosResponse == null)
            {
                MessageBox.Show(errorResponse, "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            this.CargarDataGridUsuarios(listaUsuariosResponse);
        }

        private async void btnVerActivosPorOrganismo_Click(object sender, EventArgs e)
        {
            int idOrganismo = Convert.ToInt32(cmbOrganismos.SelectedValue);
            NUsuario nUsuario = new NUsuario();
            this.Enabled = false;
            (List<DUsuario> listaUsuariosResponse, string errorResponse) = await nUsuario.ListaUsuariosActivosXOrganismo(idOrganismo);
            this.Enabled = true;

            if (listaUsuariosResponse == null)
            {
                MessageBox.Show(errorResponse, "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.CargarDataGridUsuarios(listaUsuariosResponse);
        }



        private async void dtgvProhibiciones_KeyDown(object sender, KeyEventArgs e)
        {
            //AL PRESIONAR ENTER MOSTRAR
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (dtgUsuarios.SelectedRows.Count > 0)
                {
                    int idUsuario;
                    idUsuario = Convert.ToInt32(dtgUsuarios.CurrentRow.Cells["ID"].Value.ToString());

                    if (idUsuario > 0)
                    {
                        txtIdUsuario.Text = idUsuario.ToString();
                        txtApellidoNombre.Text = dtgUsuarios.CurrentRow.Cells["ApellidoNombre"].Value.ToString();
                        txtDni.Text = dtgUsuarios.CurrentRow.Cells["Dni"].Value.ToString();
                        txtLegajo.Text = dtgUsuarios.CurrentRow.Cells["Legajo"].Value.ToString();
                        txtSexo.Text = dtgUsuarios.CurrentRow.Cells["Sexo"].Value.ToString();
                        txtEmail.Text = dtgUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                        txtTelefono.Text = dtgUsuarios.CurrentRow.Cells["Telefono"].Value.ToString();
                        txtOrganismo.Text = dtgUsuarios.CurrentRow.Cells["Organismo"].Value.ToString();


                        //CARGAR ROLES

                        if (this.txtIdUsuario.Text == string.Empty)
                        {
                            MessageBox.Show("Debe seleccionar un usuario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            NUsuario nUsuario = new NUsuario();
                            this.Enabled = false;
                            (List<DUsuarioRol> listaUsuarioRolesRespnse, string errorResponse) = await nUsuario.ListaUsuarioRoles(Convert.ToInt32(this.txtIdUsuario.Text));
                            this.Enabled = true;

                            if (listaUsuarioRolesRespnse == null)
                            {
                                MessageBox.Show(errorResponse, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }


                            var datosFiltrados = listaUsuarioRolesRespnse
                            .Select(c => new
                            {
                                Id = c.id_usuario_rol,
                                Rol = c.rol_id,
                                FechaAlta = c.fecha_alta,
                                RolActivo = c.activo

                            })
                            .ToList();

                            dgvRoles.DataSource = datosFiltrados;

                            if (listaUsuarioRolesRespnse.Count == 0)
                            {
                                MessageBox.Show("No se encontraron registros", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {

                                dgvRoles.Columns[0].Width = 50;
                                dgvRoles.Columns[1].Width = 150;
                                dgvRoles.Columns[2].Width = 80;
                                dgvRoles.Columns[2].Width = 80;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una usuario.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        
        }



        private async void btnDeshabilitarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                MessageBox.Show("Debe seleccionar una usuario.", "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            NUsuario nUsuario = new NUsuario();

            try
            {
                this.Enabled = false;
                (bool respuestaEditar, string errorResponse) = await nUsuario.DeshabilitarUsuario(Convert.ToInt32(txtIdUsuario.Text));
                this.Enabled = true;

                if (respuestaEditar)
                {
                    MessageBox.Show("Se quito correctamente al usuario del sistema", "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //buscar lista actualizada
                    this.Enabled = false;
                    (List<DUsuario> listaUsuariosResponse, string errorResponse2) = await nUsuario.ListaUsuariosActivos();
                    this.Enabled = true;

                    if (listaUsuariosResponse == null)
                    {
                        MessageBox.Show(errorResponse2, "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    txtIdUsuario.Text = string.Empty;
                    txtApellidoNombre.Text = string.Empty;
                    txtDni.Text = string.Empty;
                    txtLegajo.Text = string.Empty;
                    txtSexo.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtTelefono.Text = string.Empty;
                    txtOrganismo.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show(errorResponse, "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                // Manejo de otros tipos de errores MySQL
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       

        //------------------------------------------------------------------------------------

        //METODO PARA OBTENER LA LISTA DE USUARIOS DE RESTRICCION
        private void CargarDataGridUsuarios(List<DUsuario> listaUsuarios)
        {
            //NUsuario nUsuario = new NUsuario();
            //this.Enabled = false;
            //(List<DUsuario> listaUsuariosResponse, string errorResponse) = await nUsuario.ListaUsuariosActivos();
            //this.Enabled = true;

            
            var datosfiltrados = listaUsuarios
                .Select(c => new
                {
                    Id = c.id_usuario,
                    ApellidoNombre = c.apellido + " " + c.nombre,
                    Dni = c.dni,
                    Legajo = c.legajo,
                    Sexo = c.sexo.sexo,
                    Email = c.email,
                    Telefono = c.telefono,
                    Organismo = c.organismo.organismo,
                    Roles = string.Join(", ", c.roles),

                })
                .ToList();

            dtgUsuarios.DataSource = datosfiltrados;

            if (listaUsuarios.Count == 0)
            {
                MessageBox.Show("No se encontraron registros", "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                dtgUsuarios.Columns[0].Width = 50;
                dtgUsuarios.Columns[1].Width = 150;
                dtgUsuarios.Columns[2].Width = 150;
                dtgUsuarios.Columns[3].Width = 80;
                dtgUsuarios.Columns[4].Width = 80;
                dtgUsuarios.Columns[5].Width = 80;
                dtgUsuarios.Columns[6].Width = 150;
                dtgUsuarios.Columns[7].Width = 80;
                dtgUsuarios.Columns[8].Width = 180;
            }
        }

        //FIN METODO  PARA OBTENER LA LISTA DE USUARIOS DE RESTRICCION
        //............................................................................
        private void dgvRoles_KeyDown(object sender, KeyEventArgs e)
        {
            //AL PRESIONAR ENTER MOSTRAR
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (dgvRoles.SelectedRows.Count > 0)
                {
                    int idUsuarioRol;
                    idUsuarioRol = Convert.ToInt32(dtgUsuarios.CurrentRow.Cells["Id"].Value.ToString());

                    if (idUsuarioRol > 0)
                    {
                        txtIdUsuarioRol.Text = idUsuarioRol.ToString();
                        txtRol.Text = dgvRoles.CurrentRow.Cells["Rol"].Value.ToString();                        

                        
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un rol.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private async void btnQuitarRol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdUsuarioRol.Text))
            {
                MessageBox.Show("Debe seleccionar un rol.", "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            NUsuario nUsuario = new NUsuario();

            try
            {
                this.Enabled = false;
                (bool respuestaEditar, string errorResponse) = await nUsuario.DeshabilitarRolDelUsuario(Convert.ToInt32(txtIdUsuarioRol.Text));
                this.Enabled = true;

                if (respuestaEditar)
                {
                    MessageBox.Show("Se quito correctamente el rol del usuario", "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //CARGAR ROLES

                    if (this.txtIdUsuario.Text == string.Empty)
                    {
                        MessageBox.Show("Debe seleccionar un usuario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.Enabled = false;
                        (List<DUsuarioRol> listaUsuarioRolesRespnse, string errorResponse2) = await nUsuario.ListaUsuarioRoles(Convert.ToInt32(this.txtIdUsuario.Text));
                        this.Enabled = true;

                        if (listaUsuarioRolesRespnse == null)
                        {
                            MessageBox.Show(errorResponse2, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }


                        var datosFiltrados = listaUsuarioRolesRespnse
                        .Select(c => new
                        {
                            Id = c.id_usuario_rol,
                            Rol = c.rol_id,
                            FechaAlta = c.fecha_alta,
                            RolActivo = c.activo

                        })
                        .ToList();

                        dgvRoles.DataSource = datosFiltrados;

                        if (listaUsuarioRolesRespnse.Count == 0)
                        {
                            MessageBox.Show("No se encontraron registros", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {

                            dgvRoles.Columns[0].Width = 50;
                            dgvRoles.Columns[1].Width = 150;
                            dgvRoles.Columns[2].Width = 80;
                            dgvRoles.Columns[2].Width = 80;
                        }
                    }


                    txtIdUsuarioRol.Text = string.Empty;
                    txtRol.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show(errorResponse, "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                // Manejo de otros tipos de errores MySQL
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
