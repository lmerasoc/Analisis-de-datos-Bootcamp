using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Biblioteca
{
    #region Autores
    public class Autores
    {
        #region Member Variables
        protected int _ID_Autor;
        protected string _Nombre;
        protected string _Nacionalidad;
        protected unknown _Fecha_Nacimiento;
        #endregion
        #region Constructors
        public Autores() { }
        public Autores(string Nombre, string Nacionalidad, unknown Fecha_Nacimiento)
        {
            this._Nombre=Nombre;
            this._Nacionalidad=Nacionalidad;
            this._Fecha_Nacimiento=Fecha_Nacimiento;
        }
        #endregion
        #region Public Properties
        public virtual int ID_Autor
        {
            get {return _ID_Autor;}
            set {_ID_Autor=value;}
        }
        public virtual string Nombre
        {
            get {return _Nombre;}
            set {_Nombre=value;}
        }
        public virtual string Nacionalidad
        {
            get {return _Nacionalidad;}
            set {_Nacionalidad=value;}
        }
        public virtual unknown Fecha_Nacimiento
        {
            get {return _Fecha_Nacimiento;}
            set {_Fecha_Nacimiento=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Biblioteca
{
    #region Categoría
    public class Categoría
    {
        #region Member Variables
        protected int _ID_Categoría;
        protected string _Nombre_Categoría;
        #endregion
        #region Constructors
        public Categoría() { }
        public Categoría(string Nombre_Categoría)
        {
            this._Nombre_Categoría=Nombre_Categoría;
        }
        #endregion
        #region Public Properties
        public virtual int ID_Categoría
        {
            get {return _ID_Categoría;}
            set {_ID_Categoría=value;}
        }
        public virtual string Nombre_Categoría
        {
            get {return _Nombre_Categoría;}
            set {_Nombre_Categoría=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Biblioteca
{
    #region Libros
    public class Libros
    {
        #region Member Variables
        protected int _ID_Libro;
        protected string _Título;
        protected int _ID_Autor;
        protected int _ID_Categoría;
        protected unknown _Año_Publicación;
        protected bool _Disponible;
        #endregion
        #region Constructors
        public Libros() { }
        public Libros(string Título, int ID_Autor, int ID_Categoría, unknown Año_Publicación, bool Disponible)
        {
            this._Título=Título;
            this._ID_Autor=ID_Autor;
            this._ID_Categoría=ID_Categoría;
            this._Año_Publicación=Año_Publicación;
            this._Disponible=Disponible;
        }
        #endregion
        #region Public Properties
        public virtual int ID_Libro
        {
            get {return _ID_Libro;}
            set {_ID_Libro=value;}
        }
        public virtual string Título
        {
            get {return _Título;}
            set {_Título=value;}
        }
        public virtual int ID_Autor
        {
            get {return _ID_Autor;}
            set {_ID_Autor=value;}
        }
        public virtual int ID_Categoría
        {
            get {return _ID_Categoría;}
            set {_ID_Categoría=value;}
        }
        public virtual unknown Año_Publicación
        {
            get {return _Año_Publicación;}
            set {_Año_Publicación=value;}
        }
        public virtual bool Disponible
        {
            get {return _Disponible;}
            set {_Disponible=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Biblioteca
{
    #region Prestamo_usuarios
    public class Prestamo_usuarios
    {
        #region Member Variables
        protected int _ID_Prestamo;
        protected int _ID_Usuario;
        protected int _ID_Libro;
        protected unknown _Fecha_Prestamo;
        protected unknown _Fecha_Devolución;
        #endregion
        #region Constructors
        public Prestamo_usuarios() { }
        public Prestamo_usuarios(int ID_Usuario, int ID_Libro, unknown Fecha_Prestamo, unknown Fecha_Devolución)
        {
            this._ID_Usuario=ID_Usuario;
            this._ID_Libro=ID_Libro;
            this._Fecha_Prestamo=Fecha_Prestamo;
            this._Fecha_Devolución=Fecha_Devolución;
        }
        #endregion
        #region Public Properties
        public virtual int ID_Prestamo
        {
            get {return _ID_Prestamo;}
            set {_ID_Prestamo=value;}
        }
        public virtual int ID_Usuario
        {
            get {return _ID_Usuario;}
            set {_ID_Usuario=value;}
        }
        public virtual int ID_Libro
        {
            get {return _ID_Libro;}
            set {_ID_Libro=value;}
        }
        public virtual unknown Fecha_Prestamo
        {
            get {return _Fecha_Prestamo;}
            set {_Fecha_Prestamo=value;}
        }
        public virtual unknown Fecha_Devolución
        {
            get {return _Fecha_Devolución;}
            set {_Fecha_Devolución=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Biblioteca
{
    #region Usuarios
    public class Usuarios
    {
        #region Member Variables
        protected int _ID_Usuario;
        protected string _Nombre;
        protected string _Dirección;
        protected string _Telefono;
        #endregion
        #region Constructors
        public Usuarios() { }
        public Usuarios(string Nombre, string Dirección, string Telefono)
        {
            this._Nombre=Nombre;
            this._Dirección=Dirección;
            this._Telefono=Telefono;
        }
        #endregion
        #region Public Properties
        public virtual int ID_Usuario
        {
            get {return _ID_Usuario;}
            set {_ID_Usuario=value;}
        }
        public virtual string Nombre
        {
            get {return _Nombre;}
            set {_Nombre=value;}
        }
        public virtual string Dirección
        {
            get {return _Dirección;}
            set {_Dirección=value;}
        }
        public virtual string Telefono
        {
            get {return _Telefono;}
            set {_Telefono=value;}
        }
        #endregion
    }
    #endregion
}