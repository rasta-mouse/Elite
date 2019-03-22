// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EventModel
    {
        /// <summary>
        /// Initializes a new instance of the EventModel class.
        /// </summary>
        public EventModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventModel class.
        /// </summary>
        /// <param name="level">Possible values include: 'Silent', 'Info',
        /// 'Warning', 'Highlight', 'Error'</param>
        /// <param name="type">Possible values include: 'Normal',
        /// 'Download'</param>
        public EventModel(int? id = default(int?), System.DateTime? time = default(System.DateTime?), string messageHeader = default(string), string messageBody = default(string), EventLevel? level = default(EventLevel?), EventType? type = default(EventType?), string context = default(string))
        {
            Id = id;
            Time = time;
            MessageHeader = messageHeader;
            MessageBody = messageBody;
            Level = level;
            Type = type;
            Context = context;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public System.DateTime? Time { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messageHeader")]
        public string MessageHeader { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messageBody")]
        public string MessageBody { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Silent', 'Info', 'Warning',
        /// 'Highlight', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public EventLevel? Level { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Normal', 'Download'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public EventType? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public string Context { get; set; }

    }
}
