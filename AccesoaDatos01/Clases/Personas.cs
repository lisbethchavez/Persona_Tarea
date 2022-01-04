using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoaDatos01.Clases
{
    public static class Personas
    {
        private static string cadenacon = @"server=DESKTOP-83B08MV\SQLEXPRESS;database=TI2021; Integrated Security=true";

        public static int insertar(string cedula, string apellidos, string nombres, DateTime fechaNac, double peso)
        {
            SqlConnection conexion = new SqlConnection(cadenacon);

            //2. Definir una operacion 
            string sql = "insert into personas(cedula,apellidos,nombres,fechaNacimiento,peso) ";
            sql += "values (@cedula,@apellidos,@nombres,@fechaNacimiento,@peso)";

            //3. Ejecutar la operacion 
            SqlCommand comando = new SqlCommand(sql, conexion);

            //3.1 configurar los parametros:@cedula,@apellidos,@nombres,@fechaNacimiento,@peso

            comando.Parameters.Add(new SqlParameter("@cedula", cedula));
            comando.Parameters.Add(new SqlParameter("@apellidos", apellidos));
            comando.Parameters.Add(new SqlParameter("@nombres", nombres));
            comando.Parameters.Add(new SqlParameter("@fechaNacimiento", fechaNac));
            comando.Parameters.Add(new SqlParameter("@peso", peso));

            //3.2 Abrir conexion 

            conexion.Open();

            //3.3 Insertar el registro en la base de datos BDD

            int res = comando.ExecuteNonQuery();

            //4. Cerrar la conexion 
            conexion.Close();

            return res;
        }

        public static int borrar(string cedula)
        {
            SqlConnection conexion = new SqlConnection(cadenacon);

            //2. Definir una operacion 
            string sql = "delete from personas ";
            sql += "where cedula=@cedula";

            //3. Ejecutar la operacion 
            SqlCommand comando = new SqlCommand(sql, conexion);

            //3.1 configurar el parametro:@cedula

            comando.Parameters.Add(new SqlParameter("@cedula", cedula));
            //3.2 Abrir conexion 

            conexion.Open();

            //3.3 Borra el registro en la base de datos BDD

            int res = comando.ExecuteNonQuery();

            //4. Cerrar la conexion 
            conexion.Close();

            return res;
        }

        public static DataTable getPersona()
        {
            SqlConnection conexion = new SqlConnection(cadenacon);

            string sql = "";

            sql = "select cedula as Cédula , upper(apellidos+' '+ nombres) as [Nombre Completo], fechNacimiento as [Fecha de Nacimiento], Peso";
            sql += "from personas order by apellidos, nombres";



            SqlCommand comando = new SqlCommand(sql, conexion);
            SqlDataAdapter ad1 = new SqlDataAdapter(comando);

            //Nota: pasar los datos desde el adaptador a un datatable
            DataTable dt = new DataTable();
            ad1.Fill(dt);
            return dt;
        }

        private static DataTable getPersona()
        {
            SqlConnection conexion = new SqlConnection(cadenacon);

            string sql = "";
            sql = "select cedula, upper(apellidos+' '+ nombres) as nombreCompleto, fechNacimiento, peso";
            sql += "from personas order by apellidos, nombres";

            SqlCommand comando = new SqlCommand(sql, conexion);
            SqlDataAdapter ad1 = new SqlDataAdapter(comando);

            //Nota: pasar los datos desde el adaptador a un datatable
            DataTable dt = new DataTable();
            ad1.Fill(dt);
            return dt;
        }

    }

}
