namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Exhibition event, e.g. at a museum, library, archive, tradeshow, ...
    /// </summary>
    [DataContract]
    public partial class ExhibitionEvent : Event
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ExhibitionEvent";
    }
}
