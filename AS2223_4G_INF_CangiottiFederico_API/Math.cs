using System.Text.Json.Serialization;

namespace AS2223_4G_INF_CangiottiFederico_API
{
    public class Math
    {
        public enum Status
        {
            OK,
            ERROR,
            WARNING
        }

        public class Result
        {
            // converts enumeration values to and from strings
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public Status Status { get; set; }
            public string Message { get; set; }

            public Result(Status status, string message = "")
            {
                this.Status = status;
                this.Message = message;
            }
        }
    }
}
