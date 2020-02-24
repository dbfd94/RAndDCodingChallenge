using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class People
    {
        private int PersonID { get; set; }
        private string Name { get; set; }
        private string LastName { get; set; }
        private string CurrentRole { get; set; }
        private string Country { get; set; }
        private string Industry { get; set; }
        private int NumberOfRecommendations { get; set; }
        private int NumberOfConnections { get; set; }
        public People(int personID, string name, string lastName, string currentRole, string country, string industry,
            int numberOfRecommendations, int numberOfConnections)
        {
            this.PersonID = personID;
            this.Name = name;
            this.LastName = lastName;
            this.CurrentRole = currentRole;
            this.Country = country;
            this.Industry = industry;
            this.NumberOfRecommendations = numberOfRecommendations;
            this.NumberOfConnections = numberOfConnections;
        }
        public override string ToString()
        {
            return $"PersonID: {PersonID} \nName: {Name} \nLast Name: {LastName} \nCurrent Role: {CurrentRole} \nCountry: {Country} " +
                $"\nIndustry: {Industry} \nNumber of Recommendations:{NumberOfRecommendations} " +
                $"\nNumber of Connections:{NumberOfConnections}";
        }

    }
}
