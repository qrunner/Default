namespace Crossover.AMS.Contracts.Communication
{
    /// <summary>
    /// Conferention (virtual room)
    /// </summary>
    public interface IConference
    {
        long Id { get; }

        long AccidentId { get; }

        string Title { get; set; }

        ConferenceState State { get; set; }
    }
}