using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEmpresaPortatiles.Datos;
using System.Data;

namespace AppEmpresaPortatiles.Logica
{
    internal class ClsPortatil
    {
        ClsDatos dt = new ClsDatos();


        public DataSet obtPortatil()
        {
            return dt.obtenerPortatil();
        }
        public int IngresarPortatil(int serial, string marca, int capacidad,string tipo,string fecha)
        {
            int resultado=0;
            return resultado;
        }
        public int RegistrarPortEmp(int serial, int nit)
        {
            int resultado = 0;
            return resultado;
        }
        public DataSet ConsultarPortatil(int nit)
        {
            return dt.obtenerPortatilEmpresa(nit);
        }
    }
}
