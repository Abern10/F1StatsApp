// backend/F1StatsAPI/Models/Team.cs

using F1StatesAPI.Models;

namespace F1Stats.F1StatsAPI.Models {
    public class Team {
        public int TeamId {get; set;}
        public string Name {get; set;} = string.Empty;
        public string Nationality {get; set;} = string.Empty;
        public string Constructor {get; set;} = string.Empty;
        public List<Driver> Drivers {get; set;} = new List<Driver>();
    }
}