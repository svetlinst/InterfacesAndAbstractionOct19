namespace MilitaryElite.Contracts
{
    using System.Collections.Generic;

    public interface ISpecialisedSoldier : IPrivate
    {
        public IReadOnlyCollection<ISoldier> corps { get; }
    }
}
