using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularEnlazadaDoble
{
    class Ruta
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //ATRIBUTOS DE LA CLASE
        Base _inicio;
        Base _ultimo;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //PROPIEDADES DE LA CLASE
        private int _count;
        public int Count { get { return _count; } }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE
        public Ruta()
        {
            this._inicio = null;
            this._ultimo = null;
            this._count = 0;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO AGREGAR DE FORMA ORDENADA
        public void Agregar(Base nuevo)
        {
            Base temp = _inicio;

            if (_inicio == null)
            {
                _inicio = nuevo;
                _ultimo = nuevo;
                _count++;
            }
            else
            {
                if (_inicio.Fecha > nuevo.Fecha)
                {
                    agregarInicio(nuevo);
                }
                else if (_ultimo.Fecha < nuevo.Fecha)
                {
                    agregarFinal(nuevo);
                }
                else
                {
                    while (temp.Siguiente != _inicio && temp.Fecha < nuevo.Fecha)
                    {
                        if (temp.Siguiente.Fecha > nuevo.Fecha)
                        {
                            nuevo.Siguiente = temp.Siguiente;
                            nuevo.Anterior = temp;

                            nuevo.Siguiente.Anterior = nuevo;
                            nuevo.Anterior.Siguiente = nuevo;
                        }
                        temp = temp.Siguiente;
                    }
                    _count++;
                }
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO AGREGAR AL PRINCIPIO
        public void agregarInicio(Base nuevo)
        {
            nuevo.Siguiente = _inicio;

            if (_inicio != null)
            {
                _inicio.Anterior = nuevo;
                _ultimo.Siguiente = nuevo;
                nuevo.Anterior = _ultimo;
            }
            else
                _ultimo = nuevo;

            _inicio = nuevo;
            _count++;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO AGREGAR AL FINAL
        public void agregarFinal(Base nuevo)
        {
            nuevo.Anterior = _ultimo;

            if (_ultimo != null)
            {
                _ultimo.Siguiente = nuevo;
                _inicio.Anterior = nuevo;
                nuevo.Siguiente = _inicio;
            }
            else
                _inicio = nuevo;

            _ultimo = nuevo;
            _count++;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //INSERTAR DEPUES DE ALGUN ELEMENTO 
        public bool insertarDespuesDe(string nombre, Base nuevo)
        {
            bool insertado = false;
            Base temp = null;

            if (_inicio != null)
            {
                temp = _inicio;

                if(_inicio.getNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase) && _inicio.Siguiente == null)
                {
                    agregarFinal(nuevo);
                    insertado = true;
                }
                else if(_ultimo.getNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    agregarFinal(nuevo);
                    insertado = true;
                }

                while(temp.Siguiente != _inicio && !insertado)
                {
                    if (temp.getNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        nuevo.Siguiente = temp.Siguiente;
                        nuevo.Siguiente.Anterior = nuevo;
                        nuevo.Anterior = temp;
                        temp.Siguiente = nuevo;
                        insertado = true;
                    }
                    temp = temp.Siguiente;
                }
            }
            _count++;
            return insertado;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO BUSCAR
        public Base Buscar(string nombre)
        {
            Base temp = null;

            if(_inicio != null)
            {
                temp = _inicio;

                if (_ultimo.getNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    return _ultimo;

                while (temp.Siguiente != _inicio)
                {
                    if (temp.getNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                        return temp;
                    temp = temp.Siguiente;
                }
            }
            return temp;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ELIMINAR
        public void Eliminar(string nombre)
        {
            Base temp = _inicio;
            bool encontrado = false;

            if(_inicio != null)
            {
                if (_ultimo.getNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    eliminarUltimo();
                    _count--;
                }
                else
                {
                    while (temp.Siguiente != _inicio && encontrado != true)
                    {
                        if(temp.getNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                        {
                            temp.Anterior.Siguiente = temp.Siguiente;
                            temp.Siguiente.Anterior = temp.Anterior;

                            encontrado = true;
                            _count--;
                        }
                        temp = temp.Siguiente;
                    }
                }
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ELIMINAR PRIMER ELEMENTO
        public void eliminarPrimero()
        {
            if(_inicio != null)
            {
                if(_count == 1)
                {
                    _inicio = null;
                    _ultimo = null;
                }
                else
                {
                    _ultimo.Siguiente = _inicio.Siguiente;
                    _inicio = _inicio.Siguiente;
                    _inicio.Anterior = _ultimo;
                }
                _count--;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ELIMINAR ULTIMO ELEMENTO
        public void eliminarUltimo()
        {
            if(_ultimo != null)
            {
                if(_count == 1)
                {
                    _inicio = null;
                    _ultimo = null;
                }
                else
                {
                    _inicio.Anterior = _ultimo.Anterior;
                    _ultimo = _ultimo.Anterior;
                    _ultimo.Siguiente = _inicio;
                }
                _count--;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO REPORTE RECORRIDO
        public string recorrido(string nombre, DateTime horaInicio, DateTime horaFin)
        {
            Base temp = null;
            Base tempInicio = _inicio;
            bool encontrado = false;

            string cadena = string.Empty;
            int cont = 1;

            if(_inicio != null)
            {
                temp = _inicio;

                while (temp.Siguiente != tempInicio && tempInicio != null && !encontrado)
                {
                    if (temp.getNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        if(temp.Fecha.Hour == horaInicio.Hour && temp.Fecha.Minute <= (horaInicio.Minute + 10)
                        && temp.Fecha.Minute >= (horaInicio.Minute - 10))
                        {
                            tempInicio = temp;
                            encontrado = true;
                        }
                    }
                    temp = temp.Siguiente;
                }
                encontrado = false;

                   while(!encontrado)
                    {
                    if(tempInicio.getNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        if (tempInicio.Fecha.Hour == horaFin.Hour &&
                            tempInicio.Fecha.Minute <= (horaFin.Minute + 20) && tempInicio.Fecha.Minute >= (horaFin.Minute - 20))
                        {
                            encontrado = true;
                        }
                    }


                        cadena += tempInicio.ToString();

                        if (cont % 10 == 0)
                            cadena += Environment.NewLine + Environment.NewLine;
                        else
                            cadena += "    |    ";

                        cont++;

                    tempInicio = tempInicio.Siguiente;
                }
            }
            return cadena;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO REPORTE 
        public override string ToString()
        {
            string cadena = "No se encontro ninguna base";
            int cont = 1;

            if(_inicio != null)
            {
                cadena = string.Empty;
                Base temp = _inicio.Siguiente;
                cadena += _inicio;

                if(_inicio.Siguiente != null)
                {
                    while (temp != _inicio && temp.Siguiente != null)
                    {
                        if (cont % 10 == 0)
                            cadena += Environment.NewLine + Environment.NewLine;
                        else
                            cadena += "    |    ";

                        cadena += temp.ToString();

                        temp = temp.Siguiente;
                        cont++;
                    }
                }
            }
            return cadena;
        }


    }
}
