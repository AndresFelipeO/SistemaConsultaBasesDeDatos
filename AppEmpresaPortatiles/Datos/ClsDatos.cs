using System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data;

namespace AppEmpresaPortatiles.Datos
{
    class ClsDatos
    {
        OracleConnection miConexion = new OracleConnection("Data Source=localhost;User ID=BD2A;Password=123456");

        public int registrarEmpresaBD(int nit, String nom, string fecha)
        {
            //abrimos conexion
            miConexion.Open();
            //creo un objeto de tipo Comando
            OracleCommand miComando = new OracleCommand("BD2A.prcIngresarEmpresa", miConexion);
            int comando = 0;
            miComando.Parameters.Add("V_NIT", OracleDbType.Int32, nit, ParameterDirection.Input);
            miComando.Parameters.Add("V_NOMEMP", OracleDbType.Varchar2, 30, nom, ParameterDirection.Input);
            miComando.Parameters.Add("V_FECHA", OracleDbType.Varchar2, 30,fecha, ParameterDirection.Input);
            try
            {
                miComando.CommandType = CommandType.StoredProcedure;
                comando = miComando.ExecuteNonQuery();
            }
            catch
            {
                miConexion.Close();
                return 0;
            }
            miConexion.Close();
            return comando;
        }
        public DataSet obtenerEmpresas()
        {
            //abrimos conexion
            miConexion.Open();
            //creo un objeto de tipo Comando
            OracleCommand miComando = new OracleCommand("BD2A.prcConsultarEmpresas", miConexion);
            miComando.Parameters.Add("cr_CantidadEmpresas", OracleDbType.RefCursor, ParameterDirection.Output);
            miComando.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "DTObjetos");
            miConexion.Close();
            return ds;
        }

        public DataSet obtenerPortatil()
        {
            //abrimos conexion
            miConexion.Open();
            //creo un objeto de tipo Comando
            OracleCommand miComando = new OracleCommand("BD2A.prcConsultarPort", miConexion);
            miComando.Parameters.Add("cr_CantidadPortatiles", OracleDbType.RefCursor, ParameterDirection.Output);
            miComando.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "DTObjetos");
            miConexion.Close();
            return ds;
        }
        public DataSet obtenerPortatilEmpresa(int nit)
        {
            //abrimos conexion
            miConexion.Open();
            //creo un objeto de tipo Comando
            OracleCommand miComando = new OracleCommand("BD2A.prcConsultarPortatil", miConexion);
            miComando.Parameters.Add("V_NIT", OracleDbType.Decimal, nit, ParameterDirection.Input);
            miComando.Parameters.Add("cr_CantidadPortatiles", OracleDbType.RefCursor, ParameterDirection.Output);
            miComando.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "DTObjetos");
            miConexion.Close();
            return ds;
        }
        public int registrarPortatilBD(int serial,string marca,float capacidadD,string tipoD,float capacidadR,string fecha,int nit)
        {
            //abrimos conexion
            miConexion.Open();
            //creo un objeto de tipo Comando
            OracleCommand miComando = new OracleCommand("BD2A.prcIngresarPortatil", miConexion);
            int comando = 0;
            miComando.Parameters.Add("V_SERIAL", OracleDbType.Int32, serial, ParameterDirection.Input);
            miComando.Parameters.Add("V_MARCA", OracleDbType.Varchar2, 30, marca, ParameterDirection.Input);
            miComando.Parameters.Add("V_CAPADISCO", OracleDbType.Decimal,capacidadD, ParameterDirection.Input);
            miComando.Parameters.Add("V_TIPODISC", OracleDbType.Varchar2, 30, tipoD, ParameterDirection.Input);
            miComando.Parameters.Add("V_CAPRAM", OracleDbType.Decimal, capacidadR, ParameterDirection.Input);
            miComando.Parameters.Add("V_FECHA", OracleDbType.Varchar2, 30, fecha, ParameterDirection.Input);
            miComando.Parameters.Add("V_NIT", OracleDbType.Int32, nit, ParameterDirection.Input);

            try
            {
                miComando.CommandType = CommandType.StoredProcedure;
                comando = miComando.ExecuteNonQuery();
            }
            catch
            {
                miConexion.Close();
                return 0;
            }
            miConexion.Close();
            return comando;
        }
    }
}
