using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface IRolDao
    {
        Task<(DRol, string error)> BuscarRolXId(string idRol);
        Task<(List<DRol>, string error)> listaRoles();
    }
}
