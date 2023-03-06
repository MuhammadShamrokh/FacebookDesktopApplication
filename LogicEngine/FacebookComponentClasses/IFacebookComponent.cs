using System;

namespace LogicEngine
{
    public interface IFacebookComponent : IComparable<IFacebookComponent>
    {
        string Name { get; }

        string ImageURL { get; }

        new int CompareTo(IFacebookComponent other);
    }
}