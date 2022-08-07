using System.Data.SqlClient;
using System.Windows;
using System;


namespace Entidades.capas.Data.Models
{

	public class clsBeEntidades : ICloneable
	{

		private int mIdEntidad = 0;
		private string mDescripcion = "";
		private string mDireccion = "";
		private string mLocalidad = "";
		private string mTipoEntidad = "";
		private string mTipoDocumento = "";
		private string mNumeroDocumento = "0";
		private string mTeléfonos = "";
		private string mURLPaginaWeb = "";
		private string mURLFacebook = "";
		private string mURLInstagram = "";
		private string mURLTwitter = "";
		private string mURLTikTok = "";
		private string mCodigoPostal = "";
		private string mCoordenadasGPS = "";
		private string mLimiteCredito = "0";
		private string mUserNameEntidad = "";
		private string mPassworEntidad = "";
		private string mRolUserEntidad = "";
		private string mComentario = "";
		private string mEstatus = "";
		private int mNoEliminable = 0;
		private string mFechaRegistro = DateTime.Now.ToString();

		public int IdEntidad
		{
			get
			{
				return mIdEntidad;
			}
			set
			{
				mIdEntidad = value;
			}
		}

		public string Descripcion
		{
			get
			{
				return mDescripcion;
			}
			set
			{
				mDescripcion = value;
			}
		}

		public string Direccion
		{
			get
			{
				return mDireccion;
			}
			set
			{
				mDireccion = value;
			}
		}

		public string Localidad
		{
			get
			{
				return mLocalidad;
			}
			set
			{
				mLocalidad = value;
			}
		}

		public string TipoEntidad
		{
			get
			{
				return mTipoEntidad;
			}
			set
			{
				mTipoEntidad = value;
			}
		}

		public string TipoDocumento
		{
			get
			{
				return mTipoDocumento;
			}
			set
			{
				mTipoDocumento = value;
			}
		}

		public string NumeroDocumento
		{
			get
			{
				return mNumeroDocumento;
			}
			set
			{
				mNumeroDocumento = value;
			}
		}

		public string Teléfonos
		{
			get
			{
				return mTeléfonos;
			}
			set
			{
				mTeléfonos = value;
			}
		}

		public string URLPaginaWeb
		{
			get
			{
				return mURLPaginaWeb;
			}
			set
			{
				mURLPaginaWeb = value;
			}
		}

		public string URLFacebook
		{
			get
			{
				return mURLFacebook;
			}
			set
			{
				mURLFacebook = value;
			}
		}

		public string URLInstagram
		{
			get
			{
				return mURLInstagram;
			}
			set
			{
				mURLInstagram = value;
			}
		}

		public string URLTwitter
		{
			get
			{
				return mURLTwitter;
			}
			set
			{
				mURLTwitter = value;
			}
		}

		public string URLTikTok
		{
			get
			{
				return mURLTikTok;
			}
			set
			{
				mURLTikTok = value;
			}
		}

		public string CodigoPostal
		{
			get
			{
				return mCodigoPostal;
			}
			set
			{
				mCodigoPostal = value;
			}
		}

		public string CoordenadasGPS
		{
			get
			{
				return mCoordenadasGPS;
			}
			set
			{
				mCoordenadasGPS = value;
			}
		}

		public string LimiteCredito
		{
			get
			{
				return mLimiteCredito;
			}
			set
			{
				mLimiteCredito = value;
			}
		}

		public string UserNameEntidad
		{
			get
			{
				return mUserNameEntidad;
			}
			set
			{
				mUserNameEntidad = value;
			}
		}

		public string PassworEntidad
		{
			get
			{
				return mPassworEntidad;
			}
			set
			{
				mPassworEntidad = value;
			}
		}

		public string RolUserEntidad
		{
			get
			{
				return mRolUserEntidad;
			}
			set
			{
				mRolUserEntidad = value;
			}
		}

		public string Comentario
		{
			get
			{
				return mComentario;
			}
			set
			{
				mComentario = value;
			}
		}

		public string Estatus
		{
			get
			{
				return mEstatus;
			}
			set
			{
				mEstatus = value;
			}
		}

		public int NoEliminable
		{
			get
			{
				return mNoEliminable;
			}
			set
			{
				mNoEliminable = value;
			}
		}

		public string FechaRegistro
		{
			get
			{
				return mFechaRegistro;
			}
			set
			{
				mFechaRegistro = value;
			}
		}

		public clsBeEntidades()
		{
		}

		public clsBeEntidades(ref int IdEntidad, string Descripcion, string Direccion, string Localidad, string TipoEntidad, string TipoDocumento, string NumeroDocumento, string Teléfonos, string URLPaginaWeb, string URLFacebook, string URLInstagram, string URLTwitter, string URLTikTok, string CodigoPostal, string CoordenadasGPS, string LimiteCredito, string UserNameEntidad, string PassworEntidad, string RolUserEntidad, string Comentario, string Estatus, int NoEliminable, string FechaRegistro)
		{
			mIdEntidad = IdEntidad;
			mDescripcion = Descripcion;
			mDireccion = Direccion;
			mLocalidad = Localidad;
			mTipoEntidad = TipoEntidad;
			mTipoDocumento = TipoDocumento;
			mNumeroDocumento = NumeroDocumento;
			mTeléfonos = Teléfonos;
			mURLPaginaWeb = URLPaginaWeb;
			mURLFacebook = URLFacebook;
			mURLInstagram = URLInstagram;
			mURLTwitter = URLTwitter;
			mURLTikTok = URLTikTok;
			mCodigoPostal = CodigoPostal;
			mCoordenadasGPS = CoordenadasGPS;
			mLimiteCredito = LimiteCredito;
			mUserNameEntidad = UserNameEntidad;
			mPassworEntidad = PassworEntidad;
			mRolUserEntidad = RolUserEntidad;
			mComentario = Comentario;
			mEstatus = Estatus;
			mNoEliminable = NoEliminable;
			mFechaRegistro = FechaRegistro;
		}

		//Constructor para registro de nuevas entidades
		public clsBeEntidades(ref string Descripcion, string Direccion, string Localidad, string TipoEntidad, string TipoDocumento,
			string NumeroDocumento, string Teléfonos, string URLPaginaWeb, string URLFacebook, string URLInstagram, 
			string URLTwitter, string URLTikTok, string CodigoPostal, string CoordenadasGPS, string LimiteCredito, 
			string UserNameEntidad, string PassworEntidad, string RolUserEntidad, string Comentario, string Estatus, int NoEliminable)
		{
			
			mDescripcion = Descripcion;
			mDireccion = Direccion;
			mLocalidad = Localidad;
			mTipoEntidad = TipoEntidad;
			mTipoDocumento = TipoDocumento;
			mNumeroDocumento = NumeroDocumento;
			mTeléfonos = Teléfonos;
			mURLPaginaWeb = URLPaginaWeb;
			mURLFacebook = URLFacebook;
			mURLInstagram = URLInstagram;
			mURLTwitter = URLTwitter;
			mURLTikTok = URLTikTok;
			mCodigoPostal = CodigoPostal;
			mCoordenadasGPS = CoordenadasGPS;
			mLimiteCredito = LimiteCredito;
			mUserNameEntidad = UserNameEntidad;
			mPassworEntidad = PassworEntidad;
			mRolUserEntidad = RolUserEntidad;
			mComentario = Comentario;
			mEstatus = Estatus;
			mNoEliminable = NoEliminable;
			
		}

		public object Clone()
		{
			return base.MemberwiseClone();
		}

	}

}