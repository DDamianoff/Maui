using System;

namespace Maui.Backend.Models.General
{
    /// <summary>
    /// clase destinada a los miembros del grupo.
    /// la foto de perfil se trabaja como un ID.
    /// se cuenta con que en la base de datos existe
    /// una foto con su docketId como nombre, por lo que
    /// podrá restaurarse usando un método:
    /// "getPicturebyID"
    /// </summary>
    public class Worker
    {
        /// <summary>
        ///  número de legajo. (de estudiante)
        /// </summary>
        public uint DocketId { get; set; }
        public string FirstName { get;set; }
        public string LastName { get;set; }
        public uint Dni { get; set;}
        public uint Age { get; set;}
        public DateTime BirthDate { get;set; }
        public string ProfilePictureId { get; set;}
        
        public Worker(string firstName,
            string lastName,
            uint dni,
            uint docketId,
            uint age,
            DateTime birthDate,
            string profilePictureId)
        {
            FirstName = firstName;
            LastName = lastName;
            Dni = dni;
            DocketId = docketId;
            Age = age;
            BirthDate = birthDate;
            ProfilePictureId = profilePictureId;
        }
        
    }
}