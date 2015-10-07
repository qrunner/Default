using System.Collections.Generic;
using Fortius.Domain;
using Fortius.Structures;

namespace Accounting
{
    /// <summary>
    /// Категория регистров
    /// </summary>
    public interface IRegisterCategory : INamedEntity<int>, ITreeNode<IRegisterCategory>
    {
        /// <summary>
        /// Регистры категории
        /// </summary>
        IEnumerable<IRegister> Registers { get; }
    }
}