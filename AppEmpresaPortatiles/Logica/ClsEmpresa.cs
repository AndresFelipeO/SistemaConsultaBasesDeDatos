using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEmpresaPortatiles.Datos;


namespace AppEmpresaPortatiles.Logica
{
    internal class ClsEmpresa
    {
        ClsDatos dt = new ClsDatos();
        public int IngresarEmpresa(int nit,string nombre,string fecha)
        {
            return dt.registrarEmpresaBD(nit,nombre,fecha);
        }
        public DataSet obtEmpresas()
        {
            return dt.obtenerEmpresas();
        }
    }
}
