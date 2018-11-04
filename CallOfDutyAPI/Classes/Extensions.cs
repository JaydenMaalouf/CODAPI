namespace CallOfDutyAPI.Classes
{
    public static class Extensions
    {
        public static string GetQueryName(this GameType gameType)
        {
            switch (gameType)
            {
                case GameType.BO4BO:
                    return "bo4";
                case GameType.BO4MP:
                    return "bo4";
                case GameType.BO4Z:
                    return "bo4";
            }
            return gameType.ToString().ToLower();
        }
    }
}
