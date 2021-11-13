using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Maui.Backend.Models.DataBase
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
        
        // TODO - Clave foranea para Pictures?.
        public string ProfilePictureId { get; set;}
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        
        public ICollection<Transaction> Transactions { get; set; }
    }
}