using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalGroupProject_Group6
{
    internal class Stats
    {
        public int playerWins;
        public int AiWins;
        public int Ties;

        //total games
        public int totalGames => playerWins + AiWins + Ties;


        // win percentages
        public double playerWinpercentage => playerWins / totalGames;
        public double AiWinpercentage => AiWins / totalGames;



        // stats into a single line for saving
        public override string ToString()
        {
            return $"{playerWins}, {AiWins}, {Ties}";
        }

       
       
        

        //==================Setters+
        public void setPlayerWs(int ws)
        {
            playerWins = ws;
        }
        public void setAiWs(int aws)
        {
            AiWins = aws;
        }
        public void setTies(int t)
        {
            Ties = t;
        }

        //==================EndOFSetters+


        //==================Getters-
        public int getPlayerWs()
        {
            return playerWins;
        }
        public int getAiWs()
        {
            return AiWins;
        }
        public int getTies()
        {
            return Ties;
        }


        // This method loads stats from a text file
        public static Stats LoadStats()
        {
            //Create a new Stats object to hold the data
            Stats tempStats = new Stats();

            //Path to the text file
            string filePath = "../../stats.cs/stats.txt";

            // If the file doesn't exist, return an empty stats object
            if (!File.Exists(filePath))
                return tempStats;

            // Open the file for reading using StreamReader
            using (StreamReader file = new StreamReader(filePath))
            {
                // Read the first (and only) line from the file
                string line = file.ReadLine();

                // Make sure the line is not null (i.e., the file isn't empty)
                if (line != null)
                {
                    // Split the line into parts using ',' as the separator
                    // Example line: "3,5,2" → parts[0]="3", parts[1]="5", parts[2]="2"
                    char delim = ',';
                    string[] parts = line.Split(delim);

                    // Make sure there are exactly 3 parts
                    if (parts.Length == 3)
                    {
                        // Convert the string parts to integers and assign to the stats
                        tempStats.playerWins = int.Parse(parts[0]);
                        tempStats.AiWins = int.Parse(parts[1]);
                        tempStats.Ties = int.Parse(parts[2]);
                    }
                }
            }

            //Return the loaded stats
            return tempStats;
        }

        //This method saves the current stats to the file
        public void SaveStats()
        {
            // Path to the text file
            string filePath = "../../stats.cs/stats.txt";

            // Format the data as a single line like "3,5,2"
            string line = $"{playerWins},{AiWins},{Ties}";

            // Write the line to the file (this will overwrite existing contents)
            File.WriteAllText(filePath, line);
        }
    }

}
}
