namespace GameStore.Domain.Entities
{
    public class Game
    {
        /// <summary>
        /// Id
        /// </summary>
        public int GameId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание игры
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
    }
}
