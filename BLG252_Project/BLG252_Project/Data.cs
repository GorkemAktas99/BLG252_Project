using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace BLG252_Project
{
    public class Data
    {
        private string[] allLines = System.IO.File.ReadAllLines(@"C:\Users\90535\Desktop\FearStudyData.csv");
        private string[] fear = new string[80];
        private string[] greatest = new string[80];
        private string[] impact = new string[80];
        private string[] past = new string[80];
        private string[] encounter = new string[80];
        private string[] overcome = new string[80];
        private string[] embarrassed = new string[80];
        private int i = 0;
        private double successedCounter , dataCounter = 0;
        private double successedProportion;

        public void Reading()
        {
            var query = from line in allLines
                let data = line.Split(',') //Ayraç;
                select new
                {
                    Fear = data[0],
                    Greatest = data[1],
                    Impact = data[2],
                    Past = data[3],
                    Encounter = data[4],
                    Overcome = data[5],
                    Embarrassed = data[6],
                };
            
            foreach (var item in query)
            {
                fear[i] = item.Fear;
                greatest[i] = item.Greatest;
                impact[i] = item.Impact;
                past[i] = item.Past;
                encounter[i] = item.Encounter;
                overcome[i] = item.Overcome;
                embarrassed[i] = item.Embarrassed;
                i++;
            }
        }

        public void ShowData()
        {
            for (i = 0; i < 80; i++)
            {
                
                Console.WriteLine($"{i}.Line - {fear[i]} - {greatest[i]} - {impact[i]} - {past[i]} - {encounter[i]} - {overcome[i]} - {embarrassed[i]}");
            }
        }

        public void CollectFear(string keyWord)
        {
            for (i = 0; i < 80; i++)
            {
                if (keyWord == fear[i])
                {
                    Console.WriteLine($"{i}.Line - {fear[i]} - {greatest[i]} - {impact[i]} - {past[i]} - {encounter[i]} - {overcome[i]} - {embarrassed[i]}");
                }
            }
        }

        public double OvercomingFear(string keyWord)
        {
            successedCounter = 0;
            dataCounter = 0;
            for (i = 0; i < 80; i++)
            {
                if (keyWord == fear[i])
                {
                    if (overcome[i] == "Yes")
                    {
                        successedCounter++;
                        dataCounter++;
                    }
                    else if (overcome[i] == "No")
                    {
                        dataCounter++;
                    }
                }
            }

            successedProportion = Convert.ToDouble(successedCounter / dataCounter);
            return successedProportion*100;
        }
        
    }
}