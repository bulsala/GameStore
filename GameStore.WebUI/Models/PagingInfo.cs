﻿namespace GameStore.WebUI.Models
{
    using System;

    public class PagingInfo
    {
        /// <summary>
        /// Кол-во товаров
        /// </summary>
        public int TotalItems { get; set; }

        /// <summary>
        /// Кол-во товаров на одной странице
        /// </summary>
        public int ItemsPerPage { get; set; }

        /// <summary>
        /// Номер текущей страницы
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Общее кол-во страниц
        /// </summary>
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}