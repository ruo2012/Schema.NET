namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical procedure involving an incision with instruments; performed for diagnose, or therapeutic purposes.
    /// </summary>
    [DataContract]
    public class SurgicalProcedure : MedicalProcedure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SurgicalProcedure";
    }
}