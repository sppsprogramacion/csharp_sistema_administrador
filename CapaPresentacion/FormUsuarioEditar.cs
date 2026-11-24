using CapaDatos;
using CapaNegocio;
using CapaPresentacion.FuncionesGenerales;
using CapaPresentacion.Validaciones.AdminVisita.EdicionProhibicion;
using CapaPresentacion.Validaciones;
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
    public partial class FormUsuarioEditar : Form
    {
        public bool isEditadoGlobal = false;

        private int idUsduarioglobal = 0;
        private DUsuario usuarioGlobal = null;


        public FormUsuarioEditar(int idUsduarioglobal)
        {
            InitializeComponent();
            this.idUsduarioglobal = idUsduarioglobal;
        }

        private async void FormUsuarioEditar_Load(object sender, EventArgs e)
        {
            //// Ajustar el tamaño del formulario            
            FormularioAyudas.AjustarFormulario(this);

            //CARGAR COMBO ORGANISMO
            NOrganismo nOrganismo = new NOrganismo();
            (List<DOrganismo> listaOrganismoResponse, string errorResponse1) = await nOrganismo.RetornarOrganismoDestinoTodos();

            if (listaOrganismoResponse == null)
            {
                MessageBox.Show("Advertencia al cargar lista de Organismos: " + errorResponse1, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            cmbOrganismos.ValueMember = "id_organismo";
            cmbOrganismos.DisplayMember = "organismo";
            cmbOrganismos.DataSource = listaOrganismoResponse.ToArray();


            //Carga de combo sexo
            NSexo nSexo = new NSexo();
            (List<DSexo> listaSexo, string errorResponse2) = await nSexo.RetornarListaSexo();
            if (listaSexo == null)
            {
                MessageBox.Show("Advertencia al cargar lista de sexo: " + errorResponse1, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            cmbSexo.ValueMember = "id_sexo";
            cmbSexo.DisplayMember = "sexo";
            cmbSexo.DataSource = listaSexo;

            //Carga de combo roles
            NRol nRol = new NRol();
            (List<DRol> listaRolesResponse, string errorRolResponse2) = await nRol.ListaRoles();
            if (listaRolesResponse == null)
            {
                MessageBox.Show("Advertencia al cargar lista de roles: " + errorResponse1, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            cmbRoles.ValueMember = "id_rol";
            cmbRoles.DisplayMember = "rol";
            cmbRoles.DataSource = listaRolesResponse;


            //CARGA DE DATOS DE USUARIO
            //NUsuario nUsuario = new NUsuario();
            //this.Enabled = false;
            //(DUsuario usuarioResponse, string errorResponse) = await nUsuario.BuscarUsuarioXID(idUsduarioglobal);
            //this.Enabled = true;


            //if (usuarioResponse == null)
            //{

            //    MessageBox.Show(errorResponse, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            ////asignar a usuario glogal
            //usuarioGlobal = usuarioResponse;

            bool resultadobuscar = await this.BuscarUsuario(this.idUsduarioglobal);

            if (resultadobuscar)
            {
                //CARGAR CONTROLES DATOS DEL USUARIO
                this.CargarControlesUsuario(usuarioGlobal);

                //CARGAR ROLES
                this.CargarRolesUsuario();
            }

            


        }


        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtIdUsuario.Text == string.Empty)
            {

                MessageBox.Show("Debe seleccionar un usuario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //limpiar errores de provider
            //errorProvider.Clear();

            //validacion de formulario
            //var datosFormulario = new ProhibicionDatos
            //{
            //    txtDisposicion = txtDisposicion.Text,
            //    txtDetalle = txtDetalle.Text,
            //    dtpFechaInicio = dtpFechaInicio.Value,
            //    dtpFechaFin = dtpFechaFin.Value,
            //    txtMotivo = txtMotivo.Text,
            //};

            //var validatorEdicion = new ProhibicionEdicionValidator();
            //var result = validatorEdicion.Validate(datosFormulario);

            //if (!result.IsValid)
            //{
            //    MessageBox.Show("Complete correctamente los campos del formulario", "Restriccion Visitas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    foreach (var failure in result.Errors)
            //    {

            //        Control control = Controls.Find(failure.PropertyName, true)[0];
            //        errorProvider.SetError(control, failure.ErrorMessage);
            //    }
            //    return;
            //}

            //enviar datos
            var data = new
            {
                apellido = txtApellido.Text.Trim(),
                nombre = txtNombre.Text.Trim(),
                dni = Convert.ToInt32(txtDni.Text),
                legajo = Convert.ToInt32(txtDni.Text),
                sexo_id = Convert.ToInt32(cmbSexo.SelectedValue),
                telefono = txtTelefono.Text.Trim(),
                email = txtEmail.Text.Trim(),
                organismo_id = Convert.ToInt32(cmbOrganismos.SelectedValue),
            };

            string dataUsuario = JsonConvert.SerializeObject(data);

            NUsuario nUsuario = new NUsuario();
            this.Enabled = false;
            (bool respuestaEditar, string errorResponse) = await nUsuario.EditarUsuario(Convert.ToInt32(txtIdUsuario.Text), dataUsuario);
            this.Enabled = true;

            if (respuestaEditar)
            {

                MessageBox.Show("La edición del usuario se realizó correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.isEditadoGlobal = true;

                bool resultadobuscar = await this.BuscarUsuario(this.idUsduarioglobal);

                if (resultadobuscar)
                {
                    //CARGAR CONTROLES DATOS DEL USUARIO
                    this.CargarControlesUsuario(usuarioGlobal);

                }
            }
            else
            {
                MessageBox.Show(errorResponse, "Restrición Visitas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-------------------------------------------------------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargarControlesUsuario(this.usuarioGlobal);
        }
        //-------------------------------------------------------------------------------

        private async void btnHabilitarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                MessageBox.Show("Debe seleccionar una usuario.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            NUsuario nUsuario = new NUsuario();

            try
            {
                this.Enabled = false;
                (bool respuestaEditar, string errorResponse) = await nUsuario.HabilitarUsuario(Convert.ToInt32(txtIdUsuario.Text));
                this.Enabled = true;

                if (respuestaEditar)
                {
                    MessageBox.Show("Se habilito correctamente al usuario en el sistema", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.isEditadoGlobal = true;

                    bool resultadobuscar = await this.BuscarUsuario(this.idUsduarioglobal);

                    if (resultadobuscar)
                    {
                        //CARGAR CONTROLES DATOS DEL USUARIO
                        this.CargarControlesUsuario(usuarioGlobal);

                    }

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
        //-------------------------------------------------------------------------------

        private async void btnGuardarRol_Click(object sender, EventArgs e)
        {
            NUsuario nUsuario = new NUsuario();

            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                MessageBox.Show("Debe seleccionar una usuario.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //limpiar errores de provider
            //errorProvider.Clear();

            //validacion de formulario
            //var datosFormulario = new ProhibicionDatos
            //{
            //    txtIdCiudadano = txtIdCiudadano.Text,
            //    txtDisposicion = txtDisposicion.Text,
            //    txtDetalle = txtDetalle.Text,
            //    dtpFechaInicio = dtpFechaInicio.Value,
            //    dtpFechaFin = dtpFechaFin.Value,
            //};

            //var validator = new ProhibicionNuevaValidator();
            //var result = validator.Validate(datosFormulario);

            //if (!result.IsValid)
            //{
            //    MessageBox.Show("Complete correctamente los campos del formulario", "Restriccion Visitas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    foreach (var failure in result.Errors)
            //    {

            //        Control control = Controls.Find(failure.PropertyName, true)[0];
            //        errorProvider.SetError(control, failure.ErrorMessage);
            //    }
            //    return;
            //}

            //enviar datos si son correctos
            var data = new
            {
                usuario_id = Convert.ToInt32(txtIdUsuario.Text),
                rol_id = cmbRoles.SelectedValue,

            };

            string dataUsuario = JsonConvert.SerializeObject(data);

            this.Enabled = false;
            (DUsuarioRol dataRespuesta, string errorResponse) = await nUsuario.CrearRol(dataUsuario);
            this.Enabled = true;

            if (dataRespuesta != null)
            {
                MessageBox.Show("El rol se guardo correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.isEditadoGlobal = true;

                this.CargarRolesUsuario();
            }
            else
            {
                MessageBox.Show(errorResponse, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //----------------------------------------------------------------------------------

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK; // Para indicar que cerró bien
            this.Close();
        }
        //----------------------------------------------------------------------------------



        //-------------------------------------------------------------------------------
        //METODOS
        //-------------------------------------------------------------------------------

        //BUSCAR USUARIO
        private async Task<bool> BuscarUsuario(int idUsuario)
        {
            NUsuario nUsuario = new NUsuario();
            this.Enabled = false;
            (DUsuario usuarioResponse, string errorResponse) = await nUsuario.BuscarUsuarioXID(idUsuario);
            this.Enabled = true;


            if (usuarioResponse == null)
            {

                MessageBox.Show(errorResponse, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                //asignar a usuario glogal
                usuarioGlobal = usuarioResponse;

                return true;
            }
        }
        //FIN BUSCAR USUARIO
        //--------------------------------------------------------------------


        //CARGAR CONTROLES EDITAR USUARIO
        private void CargarControlesUsuario(DUsuario usuario)
        {
            //CARGAR DATOS DEL USUARIO
            txtIdUsuario.Text = usuario.id_usuario.ToString();
            txtApellido.Text = usuario.apellido;
            txtNombre.Text = usuario.nombre;
            txtDni.Text = usuario.dni.ToString();
            txtLegajo.Text = usuario.legajo.ToString();
            cmbSexo.Text = usuario.sexo.sexo;
            txtTelefono.Text = usuario.telefono;
            cmbOrganismos.Text = usuario.organismo.organismo;
            txtEmail.Text = usuario.email;

            if (usuario.activo)
            {
                lblEstado.Text = "USUARIO ACTIVO";
            }
            else
            {
                lblEstado.Text = "USUARIO INACTIVO";
            }
        }
        //FIN CARGAR CONTROLES EDITAR USUARIO
        //-----------------------------------------------------------------------

        //CARGAR ROLES DEL USUARIO
        private async void CargarRolesUsuario()
        {
            NUsuario nUsuario = new NUsuario();

            if (this.txtIdUsuario.Text == string.Empty)
            {
                
                MessageBox.Show("Debe seleccionar un usuario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
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
                    MessageBox.Show("No se encontraron registros de roles del usuario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCancelarCambiarContrasenia_Click(object sender, EventArgs e)
        {

            txtContrasenia.Text = string.Empty;
            txtContraseniaRepetir.Text = string.Empty;
        }

        private async void btnGuardarContrasenia_Click(object sender, EventArgs e)
        {
            if (this.txtIdUsuario.Text == string.Empty)
            {

                MessageBox.Show("Debe seleccionar un usuario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (txtContrasenia.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La <NUEVA CONTRASEÑA> esta vacia.", "Restricción Visitas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtContrasenia.Text.Trim() != txtContraseniaRepetir.Text.Trim())
            {
                MessageBox.Show("<NUEVA CONTRASEÑA> y <REPETIR CONTRASEÑA> deben ser iguales", "Restricción Visitas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NUsuario nUsuario = new NUsuario();

            var data = new
            {
                clave = txtContrasenia.Text.Trim()
            };

            string dataEditar = JsonConvert.SerializeObject(data);

            try
            {
                this.Enabled = false;
                (bool respuestaEditar, string errorResponse) = await nUsuario.CambiarPasswordDeUsuario(Convert.ToInt32(txtIdUsuario.Text), dataEditar);
                this.Enabled = true;

                if (respuestaEditar)
                {
                    MessageBox.Show("El cambio de contraseña se realizó correctamente", "Restricción Visitas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtContrasenia.Text = string.Empty;
                    txtContraseniaRepetir.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show(errorResponse, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                // Manejo de otros tipos de errores MySQL
                MessageBox.Show("Error: " + ex.Message);
            }
        }       
        //FIN CARGAR ROLES DEL USUARIO
        //---------------------------------------------------------------------
    }
}
