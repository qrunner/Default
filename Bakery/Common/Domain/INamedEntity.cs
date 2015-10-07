namespace Fortius.Domain
{
    /// <summary>
    /// Представляет идентифицирумцю и именованную сущность
    /// </summary>
    /// <typeparam name="T">Тип идентификатора</typeparam>
    public interface INamedEntity<out T> : INamed, IEntity<T> where T : struct
    {
        
    }
}
