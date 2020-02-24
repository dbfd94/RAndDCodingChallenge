using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path + the file name:");
            string filePath = Console.ReadLine();

            string[] userInfo = File.ReadAllLines(filePath);
            int amountOfUsersInFile = userInfo.Length;
            Console.WriteLine($"The file has a total of {amountOfUsersInFile} users.");

            var persons = new List<People>(amountOfUsersInFile);

            int[] personIDs = new int[amountOfUsersInFile];
            string[] names = new string[amountOfUsersInFile];
            string[] lastNames = new string[amountOfUsersInFile];
            string[] currentRoles = new string[amountOfUsersInFile];
            string[] countrys = new string[amountOfUsersInFile];
            string[] industries = new string[amountOfUsersInFile];
            int[] numberOfRecommendationss = new int[amountOfUsersInFile];
            int[] numberOfConnectionss = new int[amountOfUsersInFile];

            int counter = 0;
            int pipeLocation;
            string infoModified;
            foreach (string info in userInfo)
            {

                pipeLocation = info.IndexOf('|');
                personIDs[counter] = int.Parse(info.Substring(0, pipeLocation));
                infoModified = info.Substring(pipeLocation + 1);
                pipeLocation = infoModified.IndexOf('|');
                names[counter] = infoModified.Substring(0, pipeLocation);
                infoModified = infoModified.Substring(pipeLocation + 1);
                pipeLocation = infoModified.IndexOf('|');
                lastNames[counter] = infoModified.Substring(0, pipeLocation);
                infoModified = infoModified.Substring(pipeLocation + 1);
                pipeLocation = infoModified.IndexOf('|');
                currentRoles[counter] = infoModified.Substring(0, pipeLocation);
                infoModified = infoModified.Substring(pipeLocation + 1);
                pipeLocation = infoModified.IndexOf('|');
                countrys[counter] = infoModified.Substring(0, pipeLocation);
                infoModified = infoModified.Substring(pipeLocation + 1);
                pipeLocation = infoModified.IndexOf('|');
                industries[counter] = infoModified.Substring(0, pipeLocation);
                infoModified = infoModified.Substring(pipeLocation + 1);
                pipeLocation = infoModified.IndexOf('|');
                numberOfRecommendationss[counter] = int.Parse(info.Substring(0, pipeLocation));
                infoModified = infoModified.Substring(pipeLocation + 1);
                pipeLocation = infoModified.IndexOf('|');
                numberOfConnectionss[counter] = int.Parse(infoModified);
                counter++;
            }
            for(int i = 0; i < amountOfUsersInFile; i++)
            {
                persons.Add(new People(personIDs[i], names[i], lastNames[i], currentRoles[i], countrys[i], industries[i],
                    numberOfRecommendationss[i], numberOfConnectionss[i]));
            }

            Console.WriteLine("The industries people in the file work at are the following:");
            string industriesConcat = "";
            int numberOfIndustries = 0;

            foreach (string industry in industries)
            {
                if (industriesConcat.IndexOf(industry) < 0)
                {
                    industriesConcat += industry;
                    Console.WriteLine(industry);
                    numberOfIndustries++;
                }
            }
            Console.WriteLine($"There are a total of {numberOfIndustries} industries.");
            Console.WriteLine(persons[1906]);





        }
    }
}
