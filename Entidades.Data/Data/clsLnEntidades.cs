using Entidades.capas.Data.Models;
using System.Data.SqlClient;
using System.Data;
using System;
using Entidades.capas.Data;
//using System.Windows.Forms;

public class clsLnEntidades {

		public clsBeEntidades Cargar( DataRow dr) {
		try
		{
			clsBeEntidades oBeEntidades = new clsBeEntidades();
			oBeEntidades.IdEntidad = String.IsNullOrEmpty(dr["IdEntidad"].ToString()) == true ? "" : dr["IdEntidad"].ToString();
			oBeEntidades.Descripcion = String.IsNullOrEmpty(dr["Descripcion"].ToString()) == true ? "" : dr["Descripcion"].ToString();
			oBeEntidades.Direccion = String.IsNullOrEmpty(dr["Direccion"].ToString()) == true ? "" : dr["Direccion"].ToString();
			oBeEntidades.Localidad = String.IsNullOrEmpty(dr["Localidad"].ToString()) == true ? "" : dr["Localidad"].ToString();
			oBeEntidades.TipoEntidad = String.IsNullOrEmpty(dr["TipoEntidad"].ToString()) == true ? "" : dr["TipoEntidad"].ToString();
			oBeEntidades.TipoDocumento = String.IsNullOrEmpty(dr["TipoDocumento"].ToString()) == true ? "" : dr["TipoDocumento"].ToString();
			oBeEntidades.NumeroDocumento = String.IsNullOrEmpty(dr["NumeroDocumento"].ToString()) == true ? "" : dr["NumeroDocumento"].ToString();
			oBeEntidades.Teléfonos = String.IsNullOrEmpty(dr["Teléfonos"].ToString()) == true ? "" : dr["Teléfonos"].ToString();
			oBeEntidades.URLPaginaWeb = String.IsNullOrEmpty(dr["URLPaginaWeb"].ToString()) == true ? "" : dr["URLPaginaWeb"].ToString();
			oBeEntidades.URLFacebook = String.IsNullOrEmpty(dr["URLFacebook"].ToString()) == true ? "" : dr["URLFacebook"].ToString();
			oBeEntidades.URLInstagram = String.IsNullOrEmpty(dr["URLInstagram"].ToString()) == true ? "" : dr["URLInstagram"].ToString();
			oBeEntidades.URLTwitter = String.IsNullOrEmpty(dr["URLTwitter"].ToString()) == true ? "" : dr["URLTwitter"].ToString();
			oBeEntidades.URLTikTok = String.IsNullOrEmpty(dr["URLTikTok"].ToString()) == true ? "" : dr["URLTikTok"].ToString();
			oBeEntidades.CodigoPostal = String.IsNullOrEmpty(dr["CodigoPostal"].ToString()) == true ? "" : dr["CodigoPostal"].ToString();
			oBeEntidades.CoordenadasGPS = String.IsNullOrEmpty(dr["CoordenadasGPS"].ToString()) == true ? "" : dr["CoordenadasGPS"].ToString();
			oBeEntidades.LimiteCredito = String.IsNullOrEmpty(dr["LimiteCredito"].ToString()) == true ? "" : dr["LimiteCredito"].ToString();
			oBeEntidades.UserNameEntidad = String.IsNullOrEmpty(dr["UserNameEntidad"].ToString()) == true ? "" : dr["UserNameEntidad"].ToString();
			oBeEntidades.PassworEntidad = String.IsNullOrEmpty(dr["PassworEntidad"].ToString()) == true ? "" : dr["PassworEntidad"].ToString();
			oBeEntidades.RolUserEntidad = String.IsNullOrEmpty(dr["RolUserEntidad"].ToString()) == true ? "" : dr["RolUserEntidad"].ToString();
			oBeEntidades.Comentario = String.IsNullOrEmpty(dr["Comentario"].ToString()) == true ? "" : dr["Comentario"].ToString();
			oBeEntidades.Estatus = String.IsNullOrEmpty(dr["Estatus"].ToString()) == true ? "" : dr["Estatus"].ToString();
			oBeEntidades.NoEliminable = Convert.ToInt32(dr["NoEliminable"]);
			oBeEntidades.FechaRegistro = String.IsNullOrEmpty(dr["FechaRegistro"].ToString()) == true ? "" : dr["FechaRegistro"].ToString();
			return oBeEntidades;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}


			public int Insertar(ref clsBeEntidades oBeEntidades) {
				try 
				{
					string sp = "SpEntidadesInsertar";
			 
					SqlConnection cnn = new SqlConnection(ConexionDB.stringconnection);
					SqlCommand cmd = new SqlCommand(sp, cnn);
					cmd.CommandType = CommandType.StoredProcedure;


					int rowsAffected = 0;
					cnn.Open();

					cmd.Parameters.Add(new SqlParameter("@Descripcion", oBeEntidades.Descripcion));						
					cmd.Parameters.Add(new SqlParameter("@DIRECCION", oBeEntidades.Direccion));
					cmd.Parameters.Add(new SqlParameter("@LOCALIDAD", oBeEntidades.Localidad));
					cmd.Parameters.Add(new SqlParameter("@TIPOENTIDAD", oBeEntidades.TipoEntidad));
					cmd.Parameters.Add(new SqlParameter("@TIPODOCUMENTO", oBeEntidades.TipoDocumento));
					cmd.Parameters.Add(new SqlParameter("@NUMERODOCUMENTO", oBeEntidades.NumeroDocumento));
					cmd.Parameters.Add(new SqlParameter("@TELÉFONOS", oBeEntidades.Teléfonos));
					cmd.Parameters.Add(new SqlParameter("@URLPAGINAWEB", oBeEntidades.URLPaginaWeb));
					cmd.Parameters.Add(new SqlParameter("@URLFACEBOOK", oBeEntidades.URLFacebook));
					cmd.Parameters.Add(new SqlParameter("@URLINSTAGRAM", oBeEntidades.URLInstagram));
					cmd.Parameters.Add(new SqlParameter("@URLTWITTER", oBeEntidades.URLTwitter));
					cmd.Parameters.Add(new SqlParameter("@URLTIKTOK", oBeEntidades.URLTikTok));
					cmd.Parameters.Add(new SqlParameter("@CODIGOPOSTAL", oBeEntidades.CodigoPostal));
					cmd.Parameters.Add(new SqlParameter("@COORDENADASGPS", oBeEntidades.CoordenadasGPS));
					cmd.Parameters.Add(new SqlParameter("@LIMITECREDITO", oBeEntidades.LimiteCredito));
					cmd.Parameters.Add(new SqlParameter("@USERNAMEENTIDAD", oBeEntidades.UserNameEntidad));
					cmd.Parameters.Add(new SqlParameter("@PASSWORENTIDAD", oBeEntidades.PassworEntidad));
					cmd.Parameters.Add(new SqlParameter("@ROLUSERENTIDAD", oBeEntidades.RolUserEntidad));
					cmd.Parameters.Add(new SqlParameter("@COMENTARIO", oBeEntidades.Comentario));
					cmd.Parameters.Add(new SqlParameter("@ESTATUS", oBeEntidades.Estatus));
					cmd.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeEntidades.NoEliminable));
					cmd.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeEntidades.FechaRegistro));
					rowsAffected = cmd.ExecuteNonQuery();
					

			
					return rowsAffected;
			
				}
				catch (Exception ex) {
					throw ex;
				}
			}

			public int Actualizar(ref clsBeEntidades oBeEntidades) 
			{
				try 
				{
					string sp = "SpEntidadesActualizar";
			
					SqlConnection cnn = new SqlConnection(ConexionDB.stringconnection);
					SqlCommand cmd = new SqlCommand(sp, cnn);
					cmd.CommandType = CommandType.StoredProcedure;
					int rowsAffected = 0;
					cnn.Open();
			
					cmd.Parameters.Add(new SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
					cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeEntidades.Descripcion));
					cmd.Parameters.Add(new SqlParameter("@DIRECCION", oBeEntidades.Direccion));
					cmd.Parameters.Add(new SqlParameter("@LOCALIDAD", oBeEntidades.Localidad));
					cmd.Parameters.Add(new SqlParameter("@TIPOENTIDAD", oBeEntidades.TipoEntidad));
					cmd.Parameters.Add(new SqlParameter("@TIPODOCUMENTO", oBeEntidades.TipoDocumento));
					cmd.Parameters.Add(new SqlParameter("@NUMERODOCUMENTO", oBeEntidades.NumeroDocumento.ToString()));
					cmd.Parameters.Add(new SqlParameter("@TELÉFONOS", oBeEntidades.Teléfonos));
					cmd.Parameters.Add(new SqlParameter("@URLPAGINAWEB", oBeEntidades.URLPaginaWeb));
					cmd.Parameters.Add(new SqlParameter("@URLFACEBOOK", oBeEntidades.URLFacebook));
					cmd.Parameters.Add(new SqlParameter("@URLINSTAGRAM", oBeEntidades.URLInstagram));
					cmd.Parameters.Add(new SqlParameter("@URLTWITTER", oBeEntidades.URLTwitter));
					cmd.Parameters.Add(new SqlParameter("@URLTIKTOK", oBeEntidades.URLTikTok));
					cmd.Parameters.Add(new SqlParameter("@CODIGOPOSTAL", oBeEntidades.CodigoPostal));
					cmd.Parameters.Add(new SqlParameter("@COORDENADASGPS", oBeEntidades.CoordenadasGPS));
					cmd.Parameters.Add(new SqlParameter("@LIMITECREDITO", oBeEntidades.LimiteCredito));
					cmd.Parameters.Add(new SqlParameter("@USERNAMEENTIDAD", oBeEntidades.UserNameEntidad));
					cmd.Parameters.Add(new SqlParameter("@PASSWORENTIDAD", oBeEntidades.PassworEntidad));
					cmd.Parameters.Add(new SqlParameter("@ROLUSERENTIDAD", oBeEntidades.RolUserEntidad));
					cmd.Parameters.Add(new SqlParameter("@COMENTARIO", oBeEntidades.Comentario));
					cmd.Parameters.Add(new SqlParameter("@ESTATUS", oBeEntidades.Estatus));
					cmd.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeEntidades.NoEliminable));
					cmd.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeEntidades.FechaRegistro));
			
					rowsAffected = cmd.ExecuteNonQuery();
			
					return rowsAffected;
			
				}
				catch (Exception ex) {
					throw ex;
				}
			}

			public int Eliminar(ref String id) 
			{
				try {
					string sp = "SpEntidadesEliminar";
			
					SqlConnection cnn = new SqlConnection(ConexionDB.stringconnection);
					SqlCommand cmd = new SqlCommand(sp, cnn);
					cmd.CommandType = CommandType.StoredProcedure;


					int rowsAffected = 0;
							cnn.Open();
			
					cmd.Parameters.Add(new SqlParameter("@IDENTIDAD", id));
			
					rowsAffected = cmd.ExecuteNonQuery();
			
					return rowsAffected;
			
				}
				catch (Exception ex) {
					throw ex;
				}
			}

			public DataTable Listar() {
				try {
					string sp = "SpEntidadesListar";
			
					SqlConnection cnn = new SqlConnection(ConexionDB.stringconnection);
					SqlCommand cmd = new SqlCommand(sp, cnn);
					cmd.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
					DataTable dt = new DataTable();
					dad.Fill(dt);
			
					return dt;
			
				}
				catch (Exception ex) {
					throw ex;
				}
			}


			public DataTable Busqueda(String temp)
			{
					DataTable dt = new DataTable();
					try
				{
					string sp = "SpEntidadesBuscar";

					SqlConnection cnn = new SqlConnection(ConexionDB.stringconnection);
					SqlCommand cmd = new SqlCommand(sp, cnn);
					cmd.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter dad = new SqlDataAdapter(cmd);
					dad.SelectCommand.Parameters.Add(new SqlParameter("@username", temp));
					

					
					dad.Fill(dt);

					if ((dt.Rows.Count == 1))
					{
				
					}
					else
					{
						throw new Exception("No se pudo obtener el registro");
					}


			return dt;

				}
				catch (Exception ex)
				{
					return dt;
					throw ex;
				}
			}

	public bool Obtener(ref clsBeEntidades oBeEntidades) {
				try {
					string sp = "SP_loggin";
			
					SqlConnection cnn = new SqlConnection(ConexionDB.stringconnection);
					SqlCommand cmd = new SqlCommand(sp, cnn);
					cmd.CommandType = CommandType.StoredProcedure;
			
					SqlDataAdapter dad = new SqlDataAdapter(cmd);
					dad.SelectCommand.Parameters.Add(new SqlParameter("@UserNameEntidad", oBeEntidades.UserNameEntidad));
					dad.SelectCommand.Parameters.Add(new SqlParameter("@PassworEntidad", oBeEntidades.PassworEntidad));

					DataTable dt = new DataTable();
					dad.Fill(dt);

					if ((dt.Rows.Count == 1)) {
						Cargar( dt.Rows[0]); 
					}
					else {
						throw new Exception("No se pudo obtener el registro");
					}
			
					return true;
			
				}
				catch (Exception ex) {
			return false;
			throw ex;
			
		}
			}
	public static bool PrimeraVez()
	{

		try
		{
			string sp = "SpEntidadesListar";

			SqlConnection cnn = new SqlConnection(ConexionDB.stringconnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter dad = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			dad.Fill(dt);

			if ((dt.Rows.Count == 0))
			{
				//MessageBox.Show("Bienvenido, debe crear su usuario para poder continuar.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else return false;
			

		}
		catch (Exception ex)
		{
			throw ex;
		}
					}



		public clsBeEntidades UsuarioConectado(String usuario)
	{
		clsBeEntidades validacion;
		try
		{
			string sp = "SpUsuarioConectado";


			SqlConnection cnn = new SqlConnection(ConexionDB.stringconnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlParameter("@UserNameEntidad", usuario));

			DataTable dt = new DataTable();
			dad.Fill(dt);

			if ((dt.Rows.Count == 1))
			{
				validacion = Cargar(dt.Rows[0]);

			}
			else
			{
				throw new Exception("No se pudo obtener el registro");
			}

			return validacion;

		}
		catch (Exception ex)
		{
			throw ex;
		}

	}
}
