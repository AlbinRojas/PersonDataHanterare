using PersonDataHanterare.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static PersonDataHanterare.Person;

namespace PersonDataHanterare
{
    internal class Person
    {
        public Birth Age { get; set; }
        public Hair HairInfo { get; set; }
        public List<Gender> MyGender { get; set; }
        public List<EyeColor> MyEyeColor { get; set; }
        public Name UserName { get; set; }



        public Person(string birth, string hairlength, string haircolor, string mygender, string eyecolor, string firstname, string surname)
        {

            UserName = new Name();
            HairInfo = new Hair();
            Age = new Birth();

            string[] Dates = birth.Split('-');

            if (Dates.Length == 3)
            {
                Age.Year.Add(int.Parse(Dates[0]));
                Age.Month.Add(int.Parse(Dates[1]));
                Age.Day.Add(int.Parse(Dates[2]));
            }

            UserName.FirstName.Add(firstname);
            UserName.SurName.Add(surname);

            HairInfo.HairColor.Add(haircolor);
            HairInfo.HairLength.Add(hairlength);

            MyGender = new List<Gender>();
            MyEyeColor = new List<EyeColor>();

            try
            {
                MyGender.Add((Gender)Enum.Parse(typeof(Gender), mygender, true));
            }
            catch
            {
                Console.WriteLine("Ogiltigt kön valt! Det sätts som Annat\n");
                MyGender.Add(Gender.Annat);
            }

            try
            {
                MyEyeColor.Add((EyeColor)Enum.Parse(typeof(EyeColor), eyecolor, true));
            }
            catch
            {
                Console.WriteLine("Ogiltig Ögonfärg valts! Det sätts som Annat\n");
                MyEyeColor.Add(EyeColor.Annat);
            }
        }
        public override string ToString()
        {

            return $"Ditt namn är: {UserName.FirstName[0]} {UserName.SurName[0]}\n" +
                   $"Kön: {MyGender[0]}\n" +
                   $"Ålder: {Age.Year[0]}-{Age.Month[0].ToString("D2")}-{Age.Day[0].ToString("D2")}\n" +
                   $"Dit hår har längden: {HairInfo.HairLength[0]}, Din hårfärg är: {HairInfo.HairColor[0]}\n" +
                   $"Din ögon färg är: {MyEyeColor[0]}";

        }
    }
}