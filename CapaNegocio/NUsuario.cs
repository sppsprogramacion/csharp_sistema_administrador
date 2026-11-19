using CapaDatos;
using DAO;
using DAOImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NUsuario
    {

        //CREAR USUARIO
        public async Task<(DUsuario, string error)> CrearProhibicion(string usuarioData)
        {
            IUsuarioDao usuarioDao = new UsuarioDaoImplement(); 
            (DUsuario usuarioREsponse, string errorResponse) = await usuarioDao.CrearUsuario(usuarioData);

            return (usuarioREsponse, errorResponse);
        }
        //FIN CREAR USUARIO..................................

        //EDITAR PROHIBICION
        public async Task<(bool, string error)> EditarUsuario(int id, string prohibicioVisita)
        {
            IProhibicionVisitaDao prohibicionVisitaDao = new ProhibicinVisitaDaoImpl();

            (bool prohibicionResponse, string error) = await prohibicionVisitaDao.EditarProhibicionVisita(id, prohibicioVisita);

            return (prohibicionResponse, error);
        }
        //FIN EDITAR PROHIBICION..................................


        //CAMBIAR MI PASSWORD
        public async Task<(bool, string error)> CambiarMiPassword(string dataEditar)
        {
            IUsuarioDao usuarioDao = new UsuarioDaoImplement();

            (bool edicionResponse, string error) = await usuarioDao.CambiarMiPassword(dataEditar);

            return (edicionResponse, error);
        }
        //FIN CAMBIAR MI PASSWORD
        //..........................................................................................

        //DESHABILITAR USUARIO
        public async Task<(bool, string error)> DeshabilitarUsuario(int idUsuario)
        {
            IUsuarioDao usuarioDao = new UsuarioDaoImplement();

            (bool edicionResponse, string error) = await usuarioDao.DeshabilitarUsuario(idUsuario);

            return (edicionResponse, error);
        }
        //FIN DESHABILITAR USUARIO
        //..........................................................................................


        //DESHABILITAR ROL DEL USUARIO
        public async Task<(bool, string error)> DeshabilitarRolDelUsuario(int idUsuarioRol)
        {
            IUsuarioDao usuarioDao = new UsuarioDaoImplement();

            (bool edicionResponse, string error) = await usuarioDao.DeshabilitarRolDelUsuario(idUsuarioRol);

            return (edicionResponse, error);
        }
        //FIN DESHABILITAR ROL DEL USUARIO
        //..........................................................................................




        //BUSCAR USUARIO MI CUENTA
        public async Task<(DUsuario, string error)> BuscarUsuarioMiCuenta()
        {
            IUsuarioDao usuarioDao = new UsuarioDaoImplement();

            (DUsuario usuarioResponse, string error) = await usuarioDao.BuscarUsuarioMicuenta();


            return (usuarioResponse, error);
        }
        //FIN BUSCAR USUARIO MI CUENTA
        //........................................................................................


        //BUSCAR USUARIO X ID
        public async Task<(DUsuario, string error)> BuscarUsuarioXID(int idUsuario)
        {
            IUsuarioDao usuarioDao = new UsuarioDaoImplement();

            (DUsuario usuarioResponse, string error) = await usuarioDao.BuscarUsuarioXId(idUsuario);


            return (usuarioResponse, error);
        }
        //FIN BUSCAR USUARIO XID
        //........................................................................................


        //LISTA USUARIOS ACTIVOS
        public async Task<(List<DUsuario>, string error)> ListaUsuariosActivos()
        {
            IUsuarioDao usuarioDao = new UsuarioDaoImplement();

            (List<DUsuario> listaUsuarios, string errorResponse) = await usuarioDao.ListaUsuariosActivos();


            return (listaUsuarios, errorResponse);
        }
        //FIN LISTA USUARIOS ACTIVOS
        //...........................................................................

        //LISTA USUARIOS ACTIVOS XORGANISMO
        public async Task<(List<DUsuario>, string error)> ListaUsuariosActivosXOrganismo(int idOrganismo)
        {
            IUsuarioDao usuarioDao = new UsuarioDaoImplement();

            (List<DUsuario> listaUsuarios, string errorResponse) = await usuarioDao.ListaUsuariosActivosXOrganismo(idOrganismo);


            return (listaUsuarios, errorResponse);
        }
        //FIN LISTA USUARIOS ACTIVOS XORGANISMO
        //...........................................................................


        //LISTA USUARIOS INACTIVOS
        public async Task<(List<DUsuario>, string error)> ListaUsuariosInactivos()
        {
            IUsuarioDao usuarioDao = new UsuarioDaoImplement();

            (List<DUsuario> listaUsuarios, string errorResponse) = await usuarioDao.ListaUsuariosInactivos();


            return (listaUsuarios, errorResponse);
        }
        //FIN LISTA USUARIOS INACTIVOS
        //...........................................................................


        //LISTA ROLES DEL USUARIO
        public async Task<(List<DUsuarioRol>, string error)> ListaUsuarioRoles(int idUsuario)
        {
            IUsuarioDao usuarioDao = new UsuarioDaoImplement();

            (List<DUsuarioRol> listaUsuarioRoles, string errorResponse) = await usuarioDao.ListaUsuarioRolesXUsuario(idUsuario);


            return (listaUsuarioRoles, errorResponse);
        }
        //FIN LISTA ROLES DEL USUARIO
        //...........................................................................


    }
}
