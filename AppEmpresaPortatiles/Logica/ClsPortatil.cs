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
        public int IngresarPortatil(int serial, string marca, float capacidad,string tipo,float ram,string fecha,int nit)
        {
            return dt.registrarPortatilBD(serial,marca,capacidad,tipo,ram,fecha,nit);
        }
        
        public DataSet ConsultarPortatil(int nit)
        {
            return dt.obtenerPortatilEmpresa(nit);
        }
    }
}
