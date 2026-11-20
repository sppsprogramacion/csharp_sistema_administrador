using CapaDatos;
using CapaNegocio;
using CapaPresentacion.FuncionesGenerales;
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
        private int idUsduarioglobal = 0;


        public FormUsuarioEditar(int idUsduarioglobal)
        {
            InitializeComponent();
            this.idUsduarioglobal = idUsduarioglobal;
        }

        private async void FormUsuarioEditar_Load(object sender, EventArgs e)
        {
            //// Ajustar el tamaño del formulario            
            FormularioAyudas.AjustarFormulario(this);


            NUsuario nUsuario = new NUsuario();
            this.Enabled = false;
            (DUsuario usuarioResponse, string errorResponse) = await nUsuario.BuscarUsuarioXID(idUsduarioglobal);
            this.Enabled = true;


            if (usuarioResponse == null)
            {

                MessageBox.Show(errorResponse, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //CARGAR DATOS DEL CIUDADANO
            txtIdUsuario.Text = usuarioResponse.id_usuario.ToString();
            txtApellido.Text = usuarioResponse.apellido;
            txtNombre.Text = usuarioResponse.nombre;
            txtDni.Text = usuarioResponse.dni.ToString();
            txtLegajo.Text = usuarioResponse.legajo.ToString();
            cmbSexo.Text = usuarioResponse.sexo.sexo;
            txtTelefono.Text = usuarioResponse.telefono;
            cmbOrganismos.Text = usuarioResponse.organismo.organismo;
            txtEmail.Text = usuarioResponse.email;

            //CARGAR ROLES
            this.CargarRolesUsuario();


        }



        //CARGAR ROLES DEL USUARIO
        private async void CargarRolesUsuario()
        {
            NUsuario nUsuario = new NUsuario();

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
        }

        //FIN CARGAR ROLES DEL USUARIO
        //---------------------------------------------------------------------
    }
}
