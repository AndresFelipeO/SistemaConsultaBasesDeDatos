using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEmpresaPortatiles.accesoDatos;
using System.Data;

namespace AppEmpresaPortatiles.Logica
{
    internal class ClsPortatil
    {
        ClsDatos dt = new ClsDatos();
        public int IngresarPortatil(int serial, string marca, int capacidad,string tipo,string fecha)
        {
            int resultado;
            string consulta;
            consulta = "Insert into Portatil(portNumSerial,portMarca,portCapacidadDiscD,portTipoDisDuro,portFechaEnsamblaje) values(" +
                serial + ",'" + marca+ "'," + capacidad + ",'"+tipo+"','"+fecha+"')";
            resultado = dt.EjecutarDML(consulta);
            return resultado;
        }
        public int RegistrarPortEmp(int serial, int nit)
        {
            int resultado;
            string consulta;
            consulta = "Insert into Vende(empNit,portNumSerial) values("+nit+","+serial+")";
            resultado = dt.EjecutarDML(consulta);
            return resultado;
        }
        public DataSet ConsultarPortatil(int nit)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select empNombre as Empresa, portNumSerial as serial, portMarca as marca,portTipoDisDuro as TipoDisco, portCapacidadDiscD as capacidad,portFechaEnsamblaje as FechaEnsamblaje " + 
            "from Empresa natural join Vende natural join portatil "+
            "where empNit = "+nit;
            miDS = dt.EjecutarSelect(consulta);
            return miDS;
        }
    }
}
