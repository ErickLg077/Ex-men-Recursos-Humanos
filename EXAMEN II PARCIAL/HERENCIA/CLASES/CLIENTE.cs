using System;
using System.Collections.Generic;
using System.Text;

namespace CLASES
{
    public class CLIENTE :PERSONA
    {
        //ATRIBUTOS
        private String CATEGORIA;
        private String CODIGODEPEDIDO;
        private String CEDULACLIENTE;
        //PROPIEDADES
        public string CATEGORIA1 
        {
            get => CATEGORIA; 
            set => CATEGORIA = value;
        }
        public string CODIGODEPEDIDO1 
        { 
            get => CODIGODEPEDIDO; 
            set => CODIGODEPEDIDO = value;
        }
        public string CEDULACLIENTE1 
        { 
            get => CEDULACLIENTE; 
            set => CEDULACLIENTE = value; 
        }

        //PROCEDIMIENTOS, OPERACIONES O MÉTODOS
        public void GENERARCODIGODEPEDIDO()
        {
            this.CODIGODEPEDIDO1 = "C" + this.APPATERNO1.Substring(0, 3);
        }
        public void GENERARLISTACEDULACLIENTE()
        {
            this.CEDULACLIENTE1 = "C" + this.CEDULACLIENTE1.Substring(0, 10);
        }
    }
}
