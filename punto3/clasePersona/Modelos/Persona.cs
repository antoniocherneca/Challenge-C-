using System;

namespace clasePersona.Modelos
{
	class Persona
	{
		private int _IdPersona;
		private string _Dni;
		private string _Apellido;
		private string _Nombre;
		private DateTime _FechaNacimiento;
		private string _Telefono;
		private string _Email;
		private string _Domicilio;
		private bool _Activo;

		public int IdPersona
		{
			get { return _IdPersona; }
			set { _IdPersona = value; }
		}

		public string Dni
		{
			get { return _Dni; }
			set { _Dni = value; }
		}

		public string Apellido
		{
			get { return _Apellido; }
			set { _Apellido = value; }
		}

		public string Nombre
		{
			get { return _Nombre; }
			set { _Nombre = value; }
		}

		public DateTime FechaNacimiento
		{
			get { return _FechaNacimiento; }
			set { _FechaNacimiento = value; }
		}

		public string Telefono
		{
			get { return _Telefono; }
			set { _Telefono = value; }
		}

		public string Email
		{
			get { return _Email; }
			set { _Email = value; }
		}

		public string Domicilio
		{
			get { return _Domicilio; }
			set { _Domicilio = value; }
		}

		public bool Activo
		{
			get { return _Activo; }
			set { _Activo = value; }
		}

		public Persona() { }

		public Persona(int IdPersona, string Dni, string Apellido, string Nombre, DateTime FechaNac,
			string Telefono, string Email, string Domicilio, bool Activo)
		{
			_IdPersona = IdPersona;
			_Dni = Dni;
			_Apellido = Apellido;
			_Nombre = Nombre;
			_FechaNacimiento = FechaNac;
			_Telefono = Telefono;
			_Email = Email;
			_Domicilio = Domicilio;
			_Activo = Activo;
		}

	}
}
