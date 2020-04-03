namespace MilitaryElite.Contracts
{
    using System.Collections.Generic;

    public interface ICommando : ISpecialisedSoldier
    {
        List<IMission> missions { get; }
    }
}
