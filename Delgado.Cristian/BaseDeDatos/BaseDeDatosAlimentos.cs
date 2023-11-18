using System.Drawing;
using Microsoft.Data.SqlClient;
using LibreriaDeClases;

namespace BaseDeDatos
{
    public class BaseDeDatosAlimentos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        private static string cadenaConexion;

        static BaseDeDatosAlimentos()
        {
            cadenaConexion = Properties.Resources.miConexion;
        }
        public BaseDeDatosAlimentos()
        {
            this.conexion = new SqlConnection(cadenaConexion);
        }

        public List<Alimento> CrearListaGenerica(List<Alimento> listaGenerica)
        {
            List<Alimento> listFrutas = ObtenerListaDatos("fruta");
            List<Alimento> listaVerduras = ObtenerListaDatos("verdura");
            List<Alimento> listaCarnes = ObtenerListaDatos("carne");
            foreach (var item in listFrutas)
            {
                listaGenerica.Add(item);
            }
            foreach (var item in listaVerduras)
            {
                listaGenerica.Add(item);
            }
            foreach (var item in listaCarnes)
            {
                listaGenerica.Add(item);
            }
            return listaGenerica;
        }

        public bool PruebaConexion()
        {
            bool retorno = false;
            try
            {
                this.conexion.Open();
                retorno = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }
        public bool AgregarAlimento(Fruta? fruta, Verdura? verdura, Carne? carne)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                if (fruta is not null)
                {
                    this.comando.CommandText = "insert into tabla_Frutas (Nombre, Color, Codigo, Unidad, Empresa, EsCitrico, CascaraComestible) values('" + fruta.Nombre + "', " + (int)fruta.ColorDelAlimento + ", '" + fruta.Codigo + "', "
                        + fruta.Unidades + ", '" + fruta.Empresa + "','" + fruta.EsCitrico.ToString() + "', '" + fruta.CascaraComestible.ToString() + "')";
                }
                else if (verdura is not null)
                {
                    this.comando.CommandText = "insert into tabla_Verduras (Nombre, Color, Codigo, Unidad, Empresa, SeCocina, EsUnaHoja) values('" + verdura.Nombre + "', " + (int)verdura.ColorDelAlimento + ",'" + verdura.Codigo + "', '"
                        + verdura.Unidades + "', '" + verdura.Empresa + "','" + verdura.SeCocina.ToString() + "', '" + verdura.EsUnaHoja.ToString() + "')";
                }
                else if (carne is not null)
                {
                    this.comando.CommandText = "insert into tabla_Carnes (Nombre, Color, Codigo, Unidad, Empresa, Origen, UbicacionCorte) values('" + carne.Nombre + "', " + (int)carne.ColorDelAlimento + ",'" + carne.Codigo + "', '"
                        + carne.Unidades + "', '" + carne.Empresa + "','" + carne.OrigenDeLaCarne + "', '" + carne.UbicacionDelCorte + "')";
                }
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                { retorno = true; }
            }
            catch (Exception ex)
            {

            }
            finally { if (this.conexion.State == System.Data.ConnectionState.Open) { this.conexion.Close(); } }
            return retorno;
        }

        public List<Alimento> ObtenerListaDatos(string clave)
        {
            List<Alimento> lista = new List<Alimento>();
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                if (clave == "fruta")
                {
                    this.comando.CommandText = "select Nombre, Color, Codigo, Unidad, Empresa, EsCitrico, CascaraComestible from tabla_Frutas";

                }
                else if (clave == "verdura")
                {
                    this.comando.CommandText = "select Nombre, Color, Codigo, Unidad, Empresa, SeCocina, EsUnaHoja from tabla_Verduras";
                }
                else if (clave == "carne")
                {
                    this.comando.CommandText = "select Nombre, Color, Codigo, Unidad, Empresa, Origen, UbicacionCorte from tabla_Carnes";
                }
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (lector.Read())
                {
                    string nombre = (string)this.lector["Nombre"];
                    string codigo = (string)this.lector["Codigo"];
                    string empresa = (string)this.lector["Empresa"];
                    int unidades = (int)this.lector["Unidad"];
                    int intColor = (int)this.lector["Color"];
                    ColorAlimento color = (ColorAlimento)intColor;

                    if (clave == "fruta")
                    {
                        bool esCitrico = false;
                        bool cascaraComestible = false;
                        string strEsCitrico = (string)this.lector["EsCitrico"];
                        string strCascaraComestible = (string)this.lector["CascaraComestible"];
                        if (strEsCitrico == "True")
                            esCitrico = true;

                        if (strCascaraComestible == "True")
                            cascaraComestible = true;

                        Fruta fruta = new Fruta(nombre, color, codigo, unidades,
                            empresa, esCitrico, cascaraComestible);

                        lista.Add(fruta);
                    }
                    else if (clave == "verdura")
                    {
                        bool seCocina = false;
                        bool esUnaHoja = false;
                        string strSeCocina = (string)this.lector["SeCocina"];
                        string strEsUnaHoja = (string)this.lector["EsUnaHoja"];
                        if (strSeCocina == "True")
                            seCocina = true;

                        if (strEsUnaHoja == "True")
                            esUnaHoja = true;

                        Verdura verdura = new Verdura(nombre, color, codigo, unidades,
                            empresa, seCocina, esUnaHoja);

                        lista.Add(verdura);
                    }
                    else if (clave == "carne")
                    {
                        string origen = (string)this.lector["Origen"];
                        string ubicacionCorte = (string)this.lector["UbicacionCorte"];
                        Carne carne = new Carne(nombre, color, codigo, unidades,
                            empresa, origen, ubicacionCorte);

                        lista.Add(carne);
                    }

                }
                lector.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open) { this.conexion.Close(); }
            }
            return lista;
        }
        public bool ModificarAlimento(Fruta? fruta, Verdura? verdura, Carne? carne)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                if (fruta is not null)
                {
                    this.comando.Parameters.AddWithValue("@Nombre", fruta.Nombre);
                    this.comando.Parameters.AddWithValue("@Color", (int)fruta.ColorDelAlimento);
                    this.comando.Parameters.AddWithValue("@Codigo", fruta.Codigo);
                    this.comando.Parameters.AddWithValue("@Unidad", fruta.Unidades);
                    this.comando.Parameters.AddWithValue("@Empresa", fruta.Empresa);
                    this.comando.Parameters.AddWithValue("@EsCitrico", fruta.EsCitrico.ToString());
                    this.comando.Parameters.AddWithValue("@CascaraComestible", fruta.CascaraComestible.ToString());
                    this.comando.CommandType = System.Data.CommandType.Text;
                    this.comando.CommandText = "update tabla_Frutas set Nombre = @Nombre, Color = @Color, Unidad = @Unidad, Empresa = @Empresa, EsCitrico = @EsCitrico where Codigo = @Codigo and Empresa = @Empresa";
                }
                else if (verdura is not null)
                {
                    this.comando.Parameters.AddWithValue("@Nombre", verdura.Nombre);
                    this.comando.Parameters.AddWithValue("@Color", (int)verdura.ColorDelAlimento);
                    this.comando.Parameters.AddWithValue("@Codigo", verdura.Codigo);
                    this.comando.Parameters.AddWithValue("@Unidad", verdura.Unidades);
                    this.comando.Parameters.AddWithValue("@Empresa", verdura.Empresa);
                    this.comando.Parameters.AddWithValue("@SeCocina", verdura.SeCocina.ToString());
                    this.comando.Parameters.AddWithValue("@EsUnaHoja", verdura.EsUnaHoja.ToString());
                    this.comando.CommandType = System.Data.CommandType.Text;
                    this.comando.CommandText = "update tabla_Verduras set Nombre = @Nombre, Color = @Color, Unidad = @Unidad, Empresa = @Empresa, SeCocina = @SeCocina, EsUnaHoja = @EsUnaHoja where Codigo = @Codigo and Empresa = @Empresa";
                }
                else if (carne is not null)
                {
                    this.comando.Parameters.AddWithValue("@Nombre", carne.Nombre);
                    this.comando.Parameters.AddWithValue("@Color", (int)carne.ColorDelAlimento);
                    this.comando.Parameters.AddWithValue("@Codigo", carne.Codigo);
                    this.comando.Parameters.AddWithValue("@Unidad", carne.Unidades);
                    this.comando.Parameters.AddWithValue("@Empresa", carne.Empresa);
                    this.comando.Parameters.AddWithValue("@OrigenDeLaCarne", carne.OrigenDeLaCarne);
                    this.comando.Parameters.AddWithValue("@UbicacionDelCorte", carne.UbicacionDelCorte);
                    this.comando.CommandType = System.Data.CommandType.Text;
                    this.comando.CommandText = "update tabla_Carnes set Nombre = @Nombre, Color = @Color, Unidad = @Unidad, Empresa = @Empresa, Origen = @OrigenDeLaCarne, UbicacionCorte = @UbicacionDelCorte where Codigo = @Codigo and Empresa = @Empresa";
                }
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                { retorno = true; }
            }
            catch (Exception ex)
            {

            }
            finally { if (this.conexion.State == System.Data.ConnectionState.Open) { this.conexion.Close(); } }
            return retorno;
        }
        public bool EliminarRegistroAlimento(Alimento alimento)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Codigo", alimento.Codigo);
                this.comando.Parameters.AddWithValue("@Empresa", alimento.Empresa);
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "delete tabla_Frutas where Codigo = @Codigo and Empresa = @Empresa";

                this.comando.Connection = this.conexion;
                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                { retorno = true; }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }

    }
}