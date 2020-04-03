namespace MilitaryElite.Contracts
{
    using System.Collections.Generic;

    public interface ILeutenantGeneral  : IPrivate
    {
        public IReadOnlyCollection<IPrivate> privates { get; }
    }
}
