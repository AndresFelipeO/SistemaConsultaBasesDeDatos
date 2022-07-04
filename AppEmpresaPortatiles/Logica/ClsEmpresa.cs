using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEmpresaPortatiles.accesoDatos;


namespace AppEmpresaPortatiles.Logica
{
    internal class ClsEmpresa
    {
        ClsDatos dt = new ClsDatos();
        public int IngresarEmpresa(int nit,string nombre,string fecha)
        {
            int resultado;
            string consulta;
            consulta = "Insert into Empresa(empNit,empNombre,empFechaCreacion) values("+
                nit+",'"+nombre+"','"+fecha+"')";
            resultado = dt.EjecutarDML(consulta);
            return resultado;
        }
    }
}
