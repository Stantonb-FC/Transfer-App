using System.Text.Json.Serialization;


namespace Warehouse_Transfer_Finder
{

    public class JsonModel
    {

        public class RootModel
        {
            public Monday[] Monday { get; set; }
            public Tuesday[] Tuesday { get; set; }
            public Wednesday[] Wednesday { get; set; }
            public Thursday[] Thursday { get; set; }
            public Friday[] Friday { get; set; }
            public Saturday[] Saturday { get; set; }
            public Sunday[] Sunday { get; set; }
        }

        public class Monday
        {
            [JsonInclude]
            public int Store { get; set; }
            [JsonInclude]
            public string City { get; set; }
        }

        public class Tuesday
        {
            [JsonInclude]
            public int Store { get; set; }
            [JsonInclude]
            public string City { get; set; }
        }

        public class Wednesday
        {
            [JsonInclude]
            public int Store { get; set; }
            [JsonInclude]
            public string City { get; set; }
        }

        public class Thursday
        {
            [JsonInclude]
            public int Store { get; set; }
            [JsonInclude]
            public string City { get; set; }
        }

        public class Friday
        {
            [JsonInclude]
            public int Store { get; set; }
            [JsonInclude]
            public string City { get; set; }
        }

        public class Saturday
        {
            [JsonInclude]
            public int Store { get; set; }
            [JsonInclude]
            public string City { get; set; }
        }

        public class Sunday
        {
            [JsonInclude]
            public int Store { get; set; }
            [JsonInclude]
            public string City { get; set; }
        }

    }
}
