using System.Runtime.Serialization;

namespace Crossover.AMS.Contracts.Communication
{
    [DataContract]
    public enum ConferenceState
    {
        [EnumMember] Active,
        [EnumMember] Closed
    }
}