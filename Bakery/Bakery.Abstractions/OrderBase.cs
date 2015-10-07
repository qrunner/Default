using System;

namespace Bakery.Model
{
    /// <summary>
    /// Базовый класс заказа
    /// </summary>
    public class OrderBase : Entity
    {
        /// <summary>
        /// Дата выполнения заказа
        /// </summary>
        public DateTime ExecutionDate { get; set; }

        /// <summary>
        /// Состояние заказа
        /// </summary>
        public OrderState State { get; protected set; }

        public virtual void TakeToProcess()
        {
            if (State != OrderState.Draft)
                throw new InvalidOperationException("Текущий статус заказа не позволяет взять его в работу");

            State = OrderState.TakedToProcess;
        }

        public virtual void MarkExecuted()
        {
            if (State != OrderState.TakedToProcess)
                throw new InvalidOperationException("Текущий статус заказа не позволяет отметить его выполненным");

            State = OrderState.Executed;
        }
    }
}