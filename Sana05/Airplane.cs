using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Airplane
    {
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public MyDate StartDate { get; set; }
        public MyDate FinishDate { get; set; }
        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate) 
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new MyDate(startDate);
            FinishDate = new MyDate(finishDate);
        }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = MyDate.DefaultDate;
            FinishDate = MyDate.DefaultDate;
        }
        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = airplane.StartDate;
            FinishDate = airplane.FinishDate;
        }
        public Airplane()
        {
            StartCity = "None";
            FinishCity = "None";
            StartDate = MyDate.DefaultDate;
            FinishDate = MyDate.DefaultDate;
        }
        public int GetTotalTime()
        {
            return 
                FinishDate.Minute - StartDate.Minute + 
                FinishDate.Hour*60 - StartDate.Hour*60 +
                FinishDate.Day*24*60 - StartDate.Day*24*60 +
                FinishDate.Month*30*24*60 - StartDate.Month*30*24*60 +
                FinishDate.Year*365*24*60 - StartDate.Year*365*24*60;
        }
        public bool IsArrivingToday()
        {
            return StartDate.Year == FinishDate.Year && StartDate.Month == FinishDate.Month && FinishDate.Day == StartDate.Day;
        }
    }
}
