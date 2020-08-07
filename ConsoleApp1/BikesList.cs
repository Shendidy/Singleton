using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BikesList
    {
        private static readonly BikesList _instance = new BikesList();
        private List<string> bikesList = new List<string>();
        private int bikeInTurnIndex { get; set; }
        private BikesList()
        {
            bikesList.Add("Bike-01");
            bikesList.Add("Bike-02");
            bikesList.Add("Bike-03");
            bikesList.Add("Bike-04");

            bikeInTurnIndex = 0;
        }

        public string GetBikeInTurn()
        {
            var bike = bikesList[bikeInTurnIndex];
            bikeInTurnIndex++;
            if (bikeInTurnIndex >= bikesList.Count) bikeInTurnIndex = 0;
            return bike;
        }

        public static BikesList GetBikesList() => _instance;
        public int GetBikeInTurnIndex() => bikeInTurnIndex;
    }
}
// IOC rather than singleton
// codility for practicing coding tests