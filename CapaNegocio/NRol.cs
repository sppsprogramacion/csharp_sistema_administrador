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
    public class NRol
    {


        //BUSCAR USUARIO X ID
        public async Task<(DRol, string error)> BuscarRolXID(string idRol)
        {
            IRolDao rolDao = new RolDaoImplement();

            (DRol rolResponse, string error) = await rolDao.BuscarRolXId(idRol);


            return (rolResponse, error);
        }
        //FIN BUSCAR USUARIO XID
        //........................................................................................


        //LISTA ROLES
        public async Task<(List<DRol>, string error)> ListaRoles()
        {
            IRolDao rolDao = new RolDaoImplement();

            (List<DRol> listaRolesResponse, string errorResponse) = await rolDao.listaRoles();


            return (listaRolesResponse, errorResponse);
        }
        //FIN LISTA ROLES
        //...........................................................................

    }
}
