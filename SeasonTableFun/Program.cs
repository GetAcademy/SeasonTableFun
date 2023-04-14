using SeasonTableFun;

var teamA = new Team("Lag A");
var teamB = new Team("Lag B");
var seasonTable = new SeasonTable(new[] {teamA, teamB,});

seasonTable.AddMatch(new Match(teamA, teamB, 3, 2));
seasonTable.AddMatch(new Match(teamB, teamA, 0, 0));
