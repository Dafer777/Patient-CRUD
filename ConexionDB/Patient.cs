using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    class Patient
    {
        
        //definir miembros de la clase
        //propiedades,atributos datos
        public string names { get; set; }
        public string NumberPhone { get; set; }
        public string Years { get; set; }
        public string sickNess { get; set; }


        public Patient()
        { }
        public Patient(string names, string numberPhone, string years, string sick) //Metodo contructor
        {
            this.names = names;
            this.NumberPhone = numberPhone;
            this.Years = years;
            this.sickNess = sick;

        }

      
    }
}
