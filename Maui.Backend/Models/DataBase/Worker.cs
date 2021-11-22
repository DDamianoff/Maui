using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Maui.Backend.Models.DataBase;

// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace Ma.Backend.Models.DataBase
{
    public class Worker
    {
        /// <summary>
        /// Número de legajo.
        /// </summary>
        [Key] public uint DocketId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Dni { get; set;}
        public uint Age { get; set;}
        public DateTime BirthDate { get; set; }
        
        public string ProfilePicturePermalink { get; set;}

        public bool IsActive { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// Se espera un valor aRGB (base 16)  
        /// </summary>
        public uint FavoriteBackColor { get; set; }

        /// <summary>
        /// Se espera un valor aRGB (base 16)  
        /// </summary>
        public uint FavoriteForeColor { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
