﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BikesList
    {
        private List<string> bikesList = new List<string>();
        private int bikeInTurnIndex = 0;
        public BikesList()
        {
            bikesList.Add("Bike-01");
            bikesList.Add("Bike-02");
            bikesList.Add("Bike-03");
            bikesList.Add("Bike-04");
        }

        public string GetBikeInTurn()
        {
            var bike = bikesList[bikeInTurnIndex];
            bikeInTurnIndex++;
            if (bikeInTurnIndex >= bikesList.Count) bikeInTurnIndex = 0;
            return bike;
        }
    }
}