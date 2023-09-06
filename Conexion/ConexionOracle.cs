using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Conexion
{
    public class ConexionOracle
    {
        private String connectionString; // Cadena de conexión a la base de datos
        private String sqlString;
        private DataSet dbDataSet;
        private String tableName;
        private Boolean esSelect;
        private String nombreBaseDeDatos;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public string SqlString { get => sqlString; set => sqlString = value; }
        public DataSet DbDataSet { get => dbDataSet; set => dbDataSet = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public bool EsSelect { get => esSelect; set => esSelect = value; }
        public string NombreBaseDeDatos { get => nombreBaseDeDatos; set => nombreBaseDeDatos = value; }

        public ConexionOracle(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public ConexionOracle()
        {
        }

        public OracleConnection CrearConexion()
        {
            return new OracleConnection(ConnectionString);
        }

        public void Conectar()
        {
            using (OracleConnection con = new OracleConnection(this.ConnectionString))
            {
                if (this.EsSelect)
                {
                    try
                    {
                        con.Open();
                        Console.WriteLine("Conectado a la base de datos");
                        Console.WriteLine();

                        OracleDataAdapter dbAdapter = new OracleDataAdapter
                        {
                            SelectCommand = new OracleCommand(this.SqlString, con)
                        };

                        this.DbDataSet = new DataSet();
                        dbAdapter.Fill(this.DbDataSet, this.TableName);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos " + ex.Message, "Mensaje Sistema");
                        return;
                    }
                }
            }
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            if (this.DbDataSet != null)
            {
                this.DbDataSet.Dispose();
            }
        }

        public void ejecutarProcedimiento(String nombreProcedimiento, String[] parametros, OracleDbType[] tipos, Object[] valores)
        {
            using (OracleConnection con = new OracleConnection(this.ConnectionString))
            {
                OracleCommand cmd = new OracleCommand();
                cmd = new OracleCommand(nombreProcedimiento, con);
                cmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < parametros.Length; i++)
                {
                    cmd.Parameters.Add(parametros[i], tipos[i]).Value = valores[i];
                }
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }

    }
}
