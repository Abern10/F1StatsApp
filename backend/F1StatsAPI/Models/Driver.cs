// backend/F1StatsAPI/Models/Driver.cs

namespace F1StatesAPI.Models {
    public class Driver {
        public int DriverId {get; set;}
        public string PermanentNumber{get; set;} = string.Empty;
        public string Code {get; set;} = string.Empty;
        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public string DateOfBirth {get; set;} = string.Empty;
        public string Nationality {get; set;} = string.Empty;
        public string TeamName {get; set;} = string.Empty;
        public int? TeamId {get; set;}
    }
}