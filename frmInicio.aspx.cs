using ASP.NET_FRAMEWORK.CLASES.Archivos;
using ASP.NET_FRAMEWORK.CLASES.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_FRAMEWORK
{
    public partial class frmInicio : System.Web.UI.Page
    {
        int x = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void cargarArchivoExterno()
        {
            string fuente = @"C:\Users\alumno\Desktop\C# Arreglos\crudDB.csv";
            ClsArchivos ar = new ClsArchivos();
            //obtner todo el archivo, linea por linea dentro de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencia_sql = "";
            int Numerolinea = 0;

            ClsConexion cn = new ClsConexion();
            ClsConexionMySQL mysql = new ClsConexionMySQL();
            ClsConexionOracle or = new ClsConexionOracle();

            
            foreach (string linea in ArregloNotas)
            {
                //obtener datos
                String[] datos = linea.Split(';');
                if (Numerolinea > 0)
                {
                    sentencia_sql = sentencia_sql + $"insert into tb_Alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n ";
                }
                Numerolinea++;
            }

            switch (x)
            {
                case 1:
                    cn.EjecutaSQLDirecto(sentencia_sql);
                    break;
                case 2:
                    mysql.EjecutaSQLDirecto(sentencia_sql);
                    break;
                case 3:
                    or.EjecutaSQLDirecto(sentencia_sql);
                    break;

            }
        }

        protected void ButtonCargarInfo_Click(object sender, EventArgs e)
        {
            x = 1;
            cargarArchivoExterno();
        }

        protected void ButtonConexionMySQL_Click(object sender, EventArgs e)
        {
            x = 2;
            cargarArchivoExterno();
        }

        protected void ButtonConexionOracle_Click(object sender, EventArgs e)
        {
            x = 3;
            cargarArchivoExterno();
        }
    }
}