using CapaDatos;
using CapaNegocio;
using CapaPresentacion.FuncionesGenerales;
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
    public partial class FormUsuarioNuevo : Form
    {
        public FormUsuarioNuevo()
        {
            InitializeComponent();
        }

        private async void FormUsuarioNuevo_Load(object sender, EventArgs e)
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
            cmbOrganismos.DataSource = listaOrganismoResponse;


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


        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            NProhibicionVisita nProhibicionVisita = new NProhibicionVisita();


            //NUEVO
           
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
                    apellido = txtApellido.Text,
                    nombre = txtNombre.Text,
                    dni = Convert.ToInt32(txtDni.Text),
                    legajo = Convert.ToInt32(txtDni.Text),
                    
                };

                string dataProhibicion = JsonConvert.SerializeObject(data);

                this.Enabled = false;
                (DProhibicionVisita dataRespuesta, string errorResponse) = await nProhibicionVisita.CrearProhibicion(dataProhibicion);
                this.Enabled = true;

                if (dataRespuesta != null)
                {
                    MessageBox.Show("El usuario se guardo correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(errorResponse, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            
            //FIN NUEVO............................................................
        }
    }
}
