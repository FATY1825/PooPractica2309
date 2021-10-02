using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPractica2309
{
    class Cliente
    {
        //definir mienbros de la clase
        //Propiedades|Atributos|Datos 

        private int _clienteId;
        private string _names;
        public string _address { get; set; }
        private int _telephon;
        private int _mobile;

        //metodo constructor
        public Cliente(int clienteId, string names, 
            string address, int telephon, int mobile) //metodo constructor vacio
        {
            _clienteId = clienteId;
            _names = names;
            _address = address;
            _telephon = telephon;
            _mobile = mobile;
        }

        //metodo de propiedad
        //get -- obtener el valor almacenado en la propiedad

        //set -- asignar el valor a la variable de propiedad

        public void setClienteId (int clienteId)
        {
            _clienteId = clienteId;
        }

        public int getClienteId()
        {
            return _clienteId;
        }

        public void setNames (string names)
        {
            _names = names;
        }

        public string getNames()
        {
            return _names;
        }

        public void setTelephon (int telephon)
        {
            _telephon = telephon;
        }

        public int getTelephon()
        {
            return _telephon;
        }

        public void setMobile (int mobile)
        {
            _mobile = mobile;
        }

        public int getMobile()
        {
            return _mobile;
        }
    }

}
