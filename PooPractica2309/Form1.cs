using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooPractica2309
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instancia de la clase cliente 

            Cliente cliente1 = new Cliente( 0001, "Jose Natanael Ayala Castellon ", 
                "Ave. 23 de enero, Uluazapa, San Miguel", 26193678, 77546792);

            Cliente cliente2 = new Cliente(0002, "Margarita Rosibel Garcia Cuadros",
                "Colonia Santa Clara, San Bernardo", 26879234, 78549312);


            //Mostrar datos del cliente1
             MessageBox.Show(cliente1.getClienteId() + " " + cliente1.getNames() + " " + cliente1._address + " " 
                 + cliente1.getTelephon() + " " + cliente1.getMobile());

             MessageBox.Show(cliente2.getClienteId() + " " +  cliente2.getNames() +  " " + cliente2._address + " "
                    + cliente2.getTelephon() + " " + cliente2.getMobile());

            //Mediante metodo de propiedad 
            //creamos objeto cliente
            //cliente.setClienteId(0001);
            //cliente.setNames("Jose Natanael Ayala Castellon");

            //Mostrar los datos 
            //MessageBox.Show(cliente.getClienteId() + " " +cliente.getNames());

            //PROPIEDAD AUTOIMPLEMENTADA
            //DIRECCION
            //SET
            //cliente._address = "Ave. 23 de enero, Uluazapa, San Miguel";

            //GET
            //MessageBox.Show(cliente._address);

            //Metodo de propiedad 
            //cliente.setTelephon(26193678);
            //cliente.setMobile(77546792);

            //Mostrar los datos 
            //MessageBox.Show(cliente.getTelephon() + " " + cliente.getMobile())
;        }
    }
}
