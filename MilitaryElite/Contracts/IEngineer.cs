
namespace MilitaryElite.Contracts
{
    using System.Collections.Generic;

    public interface IEngineer : ISpecialisedSoldier
    {
        List<IRepair> repairs { get; }
    }
}
