namespace CSharpBasics
{


    public class PlayerScore
    {

        private int _points;
        private int level;
        private string ssn;   
        
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int BonusPoints { get; private set; } = 250;
        public int MaxLevel { get; } = 50;

        /*

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        */

        public string FullName
        {
            get { return $"{Name} {LastName}"; }
        }
        public string Ssn
        {
            get { return ssn.Substring(ssn.Length-4); }
            set { ssn = value; }
        }
     
        public int Level
        {
            get { return level; }
            set {
                if (value < 1) { level = 1; }
                else { level = value; }
            }
        }
        public int Points
        {
            get { return _points; }
            set { 
            if (value < 0) { _points = 0; }
            else { _points = value; }                    
             }            
        }

        public PlayerScore()
        {
            
        }

        public PlayerScore(string playerName)
        {
            Name = playerName;
            Points = 0;
            Level = 1;
        }

        private  PlayerScore(string playerName, int startingLevel)
        {
            Name = playerName;
            Level = level;
            Points = 0;
        }

        private PlayerScore(string playerName, int startingPoints, int startingLevel)
        {
            Name = playerName;
            Points = startingPoints;
            Level = startingLevel;
        }

        // Garbage One, no reason to swap the parameters around
        private PlayerScore(int ipoints, string sname,  int ilevel)
        {
            Name = sname;
            Points = ipoints;
            Level = ilevel;
        }

        public bool EarnedStar()
        {          
            int value =  (Points / Level);
            if (value > 1000)
            {
                return true;
            }
            else {  return false; }

            // If there is something 
            throw new ArgumentException("PlayerScore.EarnedStar needs a Manager object not anything else");
        }

        private void UpdatePoints(int pointIncrease)
        {
            Points = Points += pointIncrease;
            Level = (int) Math.Ceiling((double) Points / 1000);
        }

        public void AdjustForLost()
        {
            UpdatePoints(-200);
        }
        public void AdjustForWin()
        {
            UpdatePoints(500);
        }
    }
}
