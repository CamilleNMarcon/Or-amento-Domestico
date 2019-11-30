using System;
using System.Collections.Generic;
using System.Text;

namespace FLORICULTURA
{
    public class Flores : Encomenda
    {
       
     public Dictionary <string, double> FloresNoSistema = new Dictionary<string, double>();

       
        public void PreencherFlores()
       {
            FloresNoSistema.Add("rosa", 8.0);
            FloresNoSistema.Add("lirios", 15.0);
            FloresNoSistema.Add("margaridas", 10.0);
            FloresNoSistema.Add("cravos", 20.0);
            FloresNoSistema.Add("orquideas", 15.0);
            FloresNoSistema.Add("gerberas", 9.5);
            FloresNoSistema.Add("lisianthus", 7.0);
            FloresNoSistema.Add("astromelias", 7.5);

            
        }  

    }
}
