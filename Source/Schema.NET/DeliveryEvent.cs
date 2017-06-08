namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An event involving the delivery of an item.
    /// </summary>
    [DataContract]
    public class DeliveryEvent : Event
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DeliveryEvent";

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        [DataMember(Name = "hasDeliveryMethod")]
        public DeliveryMethod HasDeliveryMethod { get; set; }

        /// <summary>
        /// After this date, the item will no longer be available for pickup.
        /// </summary>
        [DataMember(Name = "availableThrough")]
        public DateTimeOffset AvailableThrough { get; set; }

        /// <summary>
        /// When the item is available for pickup from the store, locker, etc.
        /// </summary>
        [DataMember(Name = "availableFrom")]
        public DateTimeOffset AvailableFrom { get; set; }

        /// <summary>
        /// Password, PIN, or access code needed for delivery (e.g. from a locker).
        /// </summary>
        [DataMember(Name = "accessCode")]
        public string AccessCode { get; set; }
    }
}