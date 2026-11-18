using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface IUsuarioDao
    {

        Task<(bool, string error)> DeshabilitarUsuario(int idUsuario);
        Task<(bool, string error)> DeshabilitarRolDelUsuario(int idUsuarioRol);
        Task<(bool, string error)> CambiarMiPassword(string dataEditar);
        Task<(DUsuario, string error)> BuscarUsuarioMicuenta();
        Task<(DUsuario, string error)> BuscarUsuarioXId(int idUsuario);
        Task<(List<DUsuario>, string error)> ListaUsuariosActivos();
        Task<(List<DUsuario>, string error)> ListaUsuariosInactivos();
        Task<(List<DUsuario>, string error)> ListaUsuariosActivosXOrganismo(int idOrganismo);
        Task<(List<DUsuarioRol>, string error)> ListaUsuarioRolesXUsuario(int idUsuario);

    }
}
