using System;

namespace Accounting
{
    /// <summary>
    /// Относительный времени
    /// </summary>
    internal interface ITemporary
    {
        DateTime ValidFrom { get; }

        DateTime ValidTo { get; }
    }
}