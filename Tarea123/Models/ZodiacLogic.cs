using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea123.Models
{
    public class ZodiacLogic
    {



        public static string YourZsing(String Bmonth, int day)
        {
            if (((Bmonth == "Enero") && (day >= 20 || day <= 31)) || ((Bmonth == "Febrero") && (day >= 1 || day <= 18)))
            {
                return "Acuario";
            }
            else if (((Bmonth == "Febrero") && (day >= 19 || day <= 31)) || ((Bmonth == "Marzo") && (day >= 1 || day <= 20)))
            {
                return "Piscis";
            }
            else if (((Bmonth == "Marzo") && (day >= 21 || day <= 31)) || ((Bmonth == "Abril") && (day >= 1 || day <= 20)))
            {
                return "Aries";
            }
            else if (((Bmonth == "Abril") && (day >= 21 || day <= 31)) || ((Bmonth == "Mayo") && (day >= 1 || day <= 20)))
            {
                return "Tauro";
            }
            else if (((Bmonth == "Mayo") && (day >= 21 || day <= 31)) || ((Bmonth == "Junio") && (day >= 1 || day <= 24)))
            {
                return "Géminis";
            }
            else if (((Bmonth == "Junio") && (day >= 25 || day <= 31)) || ((Bmonth == "Julio") && (day >= 1 || day <= 22)))
            {
                return "Cáncer";
            }
            else if (((Bmonth == "Julio") && (day >= 23 || day <= 31)) || ((Bmonth == "Agosto") && (day >= 1 || day <= 23)))
            {
                return "Leo";
            }
            else if (((Bmonth == "Agosto") && (day >= 24 || day <= 31)) || ((Bmonth == "Septiembre") && (day >= 1 || day <= 23)))
            {
                return "Virgo";
            }
            else if (((Bmonth == "Septiembre") && (day >= 24 || day <= 31)) || ((Bmonth == "Octubre") && (day >= 1 || day <= 22)))
            {
                return "Libra";
            }
            else if (((Bmonth == "Octubre") && (day >= 23 || day <= 31)) || ((Bmonth == "Noviembre") && (day >= 1 || day <= 22)))
            {
                return "Escorpio";
            }
            else if (((Bmonth == "Agosto") && (day >= 24 || day <= 31)) || ((Bmonth == "Septiembre") && (day >= 1 || day <= 21)))
            {
                return "Sagitario";
            }
            else if (((Bmonth == "Diciembre") && (day >= 22 || day <= 31)) || ((Bmonth == "Enero") && (day >= 1 || day <= 19)))
            {
                return "Capricornio";
            }
            else

            {
                return "No valido";
            }


        }


    }

}