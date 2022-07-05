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

            miComando.Parameters.Add("V_NIT", OracleDbType.Int32, nit, ParameterDirection.Input);
            miComando.Parameters.Add("V_NOMEMP", OracleDbType.Varchar2, 30, nom, ParameterDirection.Input);
            miComando.Parameters.Add("V_FECHA", OracleDbType.Date, fecha, ParameterDirection.Input);
            miComando.CommandType = CommandType.StoredProcedure;
            return miComando.ExecuteNonQuery();
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
            miComando.Parameters.Add("cr_CantidadPortatiles", OracleDbType.RefCursor, ParameterDirection.Output);
            miComando.Parameters.Add("V_NIT", OracleDbType.Int32, nit, ParameterDirection.Input);
            miComando.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "DTObjetos");
            miConexion.Close();
            return ds;
        }

    }
}
