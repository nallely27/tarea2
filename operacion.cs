using System;

namespace tarea2
{
	public class operacion
	{
        protected int valor1;
        protected int valor2;
        protected int resultado;

        public int Valor1 
        {
            set 
            {
                valor1=value;
            }
            get
            {
                return valor1;
            }
        }

        public int Valor2 
        {
            set 
            {
                valor2=value;
            }
            get
            {
                return valor2;
            }
        }

        public int Resultado
        {
            protected set 
            {
               resultado=value;
            }
            get
            {
                return resultado;
            }
        }        
    }


    
}

