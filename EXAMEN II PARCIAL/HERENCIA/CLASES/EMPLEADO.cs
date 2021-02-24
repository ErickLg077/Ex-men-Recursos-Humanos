using System;
using System.Collections.Generic;
using System.Text;

namespace CLASES
{
    public class EMPLEADO : PERSONA
    {
        //ATRIBUTOS
        private String TIPO;
        private String TIPOCONTRATO;
        private double SUELDO;
        private String CEDULAEMPLEADO;
        //PROPIEDADES
        public string TIPO1 
        {
            get => TIPO; 
            set => TIPO = value;
        }
        public string TIPOCONTRATO1 
        { 
            get => TIPOCONTRATO; 
            set => TIPOCONTRATO = value;
        }
        public double SUELDO1 
        { 
            get => SUELDO; 
            set => SUELDO = value; 
        }
        public string CEDULAEMPLEADO1
        {
            get => CEDULAEMPLEADO; 
            set => CEDULAEMPLEADO = value;
        }

        //PROCEDIMIENTOS, OPERACIONES O MÉTODOS
        public void GENERARLISTACEDULACLIENTE()
        {
            this.CEDULAEMPLEADO1 = "C" + this.CEDULAEMPLEADO1.Substring(0, 10);
        }
        public void CALCULARSUELDO(Double SUELDOBASE)
        {
            if (this.TIPO1=="GERENTE")
            {
                if (this.TIPOCONTRATO1 == "NUEVO")
                {
                    SUELDO1 = 2 * SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATO1 == "LONGEVO")
                {
                    SUELDO1 = 2 * SUELDOBASE + 1500;
                }
            }
            else if (this.TIPO1 =="VENDEDOR")
            {
                if (this.TIPOCONTRATO1 == "NUEVO")
                {
                    SUELDO1 = SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATO1 == "LONGEVO")
                {
                    SUELDO1 = SUELDOBASE + 1500;
                }
            }
            else
            {
                this.SUELDO1 = 0;
            }
        }
    }
}
