namespace highScores {
    class Player {
        private string initials;
        private int score;
        public string Initials {
            get => initials;
            set => initials = value;}
        public int Score {
            get => score;
            set => score = value;
        }

        public Player(string tInitials, int tScore) {
            initials = tInitials;
            score = tScore;
        }
    }
}