 class ScrabbleScore
    {
        Dictionary<int, string> PointScores = new Dictionary<int, string>
        {
            { 1, "AEIOULNRST" },
            { 2, "DG" },
            { 3, "BCMP" },
            { 4, "FHVWY" },
            { 5, "K" },
            { 8, "JX" },
            { 10, "QZ" },
        };
    
        const string OnePointScore = "AEIOULNRST";
        const string TwoPointScore = "DG";
        const string ThreePointScore = "BCMP";
        const string FourPointScore = "FHVWY";
        const string FivePointScore = "K";
        const string EightPointScore = "JX";
        const string TenPointScore = "QZ";

        public int GetScrabbleScore(string word)
        {
            int wordScore = 0;

            foreach(char c in word.ToUpper())
            {
                foreach(int score in PointScores.Keys)
            {
                if (PointScores[score].Contains(c))
                {
                    wordScore += score;
                }
            }
            }

            return wordScore;
        }
    }
