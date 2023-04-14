namespace SeasonTableFun
{
    internal class SeasonTable
    {
        private readonly List<Match> _matches;
        private readonly Team[] _teams;

        public SeasonTable(Team[] teams)
        {
            _matches = new List<Match>();
            _teams = teams;
        }

        public void AddMatch(Match match)
        {

        }

        public void Show()
        {

        }
    }
}
