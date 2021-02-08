using System;

namespace s1d0r.marketplace
{
    public interface IMarketPlace
    {
        /// <summary>
        ///     Получение баланса
        /// </summary>
        /// <returns></returns>
        string GetBalance();

        /// <summary>
        /// Создание заявки на продажу
        /// </summary>
        /// <returns></returns>
        bool PlaseSellOrder();

        /// <summary>
        /// Создание заявки на покупку
        /// </summary>
        /// <returns></returns>
        bool PlaseBuyOrder();

        /// <summary>
        /// Стату выполнения заявки
        /// </summary>
        /// <returns></returns>
        bool StatusOrder();

        /// <summary>
        /// Удаление заявки на продажу/покупку
        /// </summary>
        /// <returns></returns>
        bool RemoveOrder();

        /// <summary>
        /// Список открытых заявок
        /// </summary>
        /// <returns></returns>
        string GetOrders();

        /// <summary>
        /// Получение рыночной цены
        /// </summary>
        /// <returns></returns>
        string GetTiker();
    }
}
