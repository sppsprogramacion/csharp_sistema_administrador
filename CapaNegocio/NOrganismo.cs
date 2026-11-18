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
    public class NOrganismo
    {
        //RETORNAR ORGANISMO DESTINO TODOS
        public async Task<(List<DOrganismo>, string error)> RetornarOrganismoDestinoTodos()
        {
            IOrganismoDao organismoDao = new OrganismoDaoImpl();

            (List<DOrganismo> listaOrganismoResponse, string errorResponse) = await organismoDao.retornarListaOrganismos();


            return (listaOrganismoResponse, errorResponse);
        }
        //FIN RETORNAR ORGANISMO DESTINO TODOS..................................
    }
}
