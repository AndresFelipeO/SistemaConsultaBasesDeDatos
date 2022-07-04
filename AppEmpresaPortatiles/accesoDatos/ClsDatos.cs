using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace AppEmpresaPortatiles.accesoDatos
{
    internal class ClsDatos
    {
        string cadenaConexion = "Data Source=localhost;User ID=BD1a;Password=123456";
        //metodo para ejecutar una sentencia insert, update o delete
        public int EjecutarDML(string consulta)
        {
            int filasAfectadas=0;
            //paso 1: creo una conexion
            OracleConnection miConecion = new OracleConnection(cadenaConexion);
            //paso 2: creo un comando
            OracleCommand comando = new OracleCommand(consulta, miConecion);
            //paso 3 Abrir una conexion
            try
            {
                miConecion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error! datos inconrrectos", "Mesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 0;
            }
            
            miConecion.Close();
            return filasAfectadas;
        }
        public DataSet EjecutarSelect(String consulta)
        {
            //paso 1: crea una dataset vacion
            DataSet ds = new DataSet();
            //paso 2: cree un adapador
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta, cadenaConexion);
            //paso 3: llena el dataset ds a traves del apadaptador
            adaptador.Fill(ds, "ResultadoDatos");
            return ds;
        }
    }
}
