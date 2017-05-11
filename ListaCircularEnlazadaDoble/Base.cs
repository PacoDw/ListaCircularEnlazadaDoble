using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularEnlazadaDoble
{
    class Base
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //ATRIBUTOS DE LA CLASE
        private string _nombre;
        DateTime _fecha;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //PROPIEDADES DE LA CLASE
        public DateTime Fecha { get { return _fecha; } }

        private int _minutos;
        public int Minutos { get { return _minutos; } set { _minutos = value; } }

        private Base _siguiente;
        public Base Siguiente { get { return _siguiente; } set { _siguiente = value; } }

        private Base _anterior;
        public Base Anterior { get { return _anterior; } set { _anterior = value; } }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE
        public Base()
        {
            this._nombre = string.Empty;
            this._siguiente = null;
            this._fecha = new DateTime();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO SET NOMBRE
        public void setNombre(string nombre)
        {
            this._nombre = nombre;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METOD GET NOMBRE
        public string getNombre()
        {
            return this._nombre;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO SET FECHA
        public void setFecha(DateTime fecha)
        {
            this._fecha = fecha;
        }

        public override string ToString()
        {
            return _nombre + " " + _fecha.Hour + ":" + _fecha.Minute;
        }
    }
}
