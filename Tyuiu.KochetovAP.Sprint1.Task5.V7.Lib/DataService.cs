using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KochetovAP.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            double totalHours = f / 3.00;
            int hours = (int)totalHours;
            int minutes = (int)((totalHours - hours) * 60);
            return hours; 
            return minutes;



        }
    }
}
