using System.Globalization;
using System.Text.RegularExpressions;
using static PersonDataHanterare.Person;
using static System.Net.Mime.MediaTypeNames;

namespace PersonDataHanterare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string birth = "";
            string haircolor = "";
            string hairlenght = "";

            bool Restart = true;
            bool Menu = true;
            bool BirthSelector = true;
            bool HairColorSelector = true;
            bool HairLenghtSelector = true;

            while (Restart)
            {
                Menu = true;

                while (Menu)
                {
                    BirthSelector = true;
                    HairColorSelector = true;
                    HairLenghtSelector = true;

                    while (BirthSelector)
                    {
                        Console.WriteLine("Skriv när du var född (åååå-mm-dd)");
                        birth = Console.ReadLine();

                        if (Regex.IsMatch(birth, @"^\d+-\d+-\d+$"))
                        {
                            BirthSelector = false;
                        }
                        else
                        {
                            Console.WriteLine("Fel Format! försök igen!");
                        }

                    }

                    Console.WriteLine("Vad är ditt förnamn?");
                    string firstname = Console.ReadLine();
                    firstname = firstname.ToLower();
                    firstname = char.ToUpper(firstname[0]) + firstname.Substring(1);

                    Console.WriteLine("Vad är ditt efternamn?");
                    string surname = Console.ReadLine();
                    surname = surname.ToLower();
                    surname = char.ToUpper(surname[0]) + surname.Substring(1);

                    Console.WriteLine("Vad är ditt kön? (Kvinna, Man, IckeBinär, annat)");
                    string mygender = Console.ReadLine();

                    Console.WriteLine("Vilken ögonfärg har du? (brun, blå, grå, grön, annat)");
                    string myeyecolor = Console.ReadLine();

                    while (HairLenghtSelector)
                    {
                        Console.WriteLine("Hur långt är ditt hår? (kort, medium, långt)");
                        hairlenght = Console.ReadLine();
                        hairlenght = hairlenght.ToLower();

                        switch (hairlenght)
                        {
                            case "kort":
                                HairLenghtSelector = false;
                                break;
                            case "medium":
                                HairLenghtSelector = false;
                                break;
                            case "långt":
                                HairLenghtSelector = false;
                                break;
                            default:
                                Console.WriteLine("Du valde fel!");
                                break;
                        }
                    }

                    while (HairColorSelector)
                    {
                        Console.WriteLine("Vilken hårfärg har du?");
                        haircolor = Console.ReadLine();

                        if (Regex.IsMatch(haircolor, @"^\d$"))
                        {
                            Console.WriteLine("Fel Format");
                        }
                        else
                        {
                            HairColorSelector = false;
                        }
                    }
                    Console.Clear();
                    Person p = new Person(birth, hairlenght, haircolor, mygender, myeyecolor, firstname, surname);
                    people.Add(p);

                    foreach (Person person in people)
                    {

                        Console.WriteLine($"{person}");

                    }
                    Console.WriteLine("Vill du lägga till en till person? Ja/Nej");
                    string input = Console.ReadLine();
                    input = input.ToLower();
                    bool extrapersonselector = true;

                    while (extrapersonselector)
                    {
                        switch (input)
                        {
                            case "ja":
                                extrapersonselector = false;
                                Console.Clear();
                                break;
                            case "nej":
                                extrapersonselector = false;
                                Menu = false;
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Du valde fel!");
                                break;
                        }
                    }

                }
                bool PersonSelector = true;
                while (PersonSelector)
                {


                    Console.WriteLine("Vem vill du ha information om?");
                    Console.Write("Förnamn: ");
                    string SelectedPersonFirstName = Console.ReadLine();
                    SelectedPersonFirstName = SelectedPersonFirstName.ToLower();
                    SelectedPersonFirstName = char.ToUpper(SelectedPersonFirstName[0]) + SelectedPersonFirstName.Substring(1);

                    Console.Write("Efternamn: ");
                    string SelecetedPersonSurname = Console.ReadLine();
                    SelecetedPersonSurname = SelecetedPersonSurname.ToLower();
                    SelecetedPersonSurname = char.ToUpper(SelecetedPersonSurname[0]) + SelecetedPersonSurname.Substring(1);

                    for (int i = 0; i < people.Count; i++)
                    {
                        if (SelectedPersonFirstName == people[i].UserName.FirstName[0] && SelecetedPersonSurname == people[i].UserName.SurName[0])
                        {
                            Console.WriteLine(people[i]);
                        }

                    }

                    Console.WriteLine("Vill du ha information om någon annan? ja/nej");
                    string input = Console.ReadLine();
                    input = input.ToLower();

                    bool Moreinformation = true;
                    while (Moreinformation)
                    {
                        switch (input)
                        {
                            case "ja":
                                Console.Clear();
                                Moreinformation = false;
                                break;
                            case "nej":
                                Moreinformation = false;
                                PersonSelector = false;
                                break;
                            default:
                                Console.WriteLine("Du valde fel!");
                                break;
                        }
                    }
                }

                Console.WriteLine("Vill du lägga till en person till(Ja/Nej)?");
                string Restartinput = Console.ReadLine();
                Restartinput = Restartinput.ToLower();
                bool RestartPerson = true;
                while (RestartPerson)
                {
                    switch (Restartinput)
                    {
                        case "ja":
                            RestartPerson = false;
                            Console.Clear();
                            break;
                        case "nej":
                            Restart = false;
                            RestartPerson = false;
                            break;
                        default:
                            Console.WriteLine("Du valde fel!");
                            break;
                    }
                }
            }
        }
    }
}