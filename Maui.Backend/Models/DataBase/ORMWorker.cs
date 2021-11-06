using System;

namespace Maui.Backend.Models.DataBase
{
    public class OrmWorker
    {
        public uint DocketId { get; init; }

        public string FirstName { get;init; }

        public string LastName { get;init; }

        public uint Dni { get; init;}

        public uint Age { get; init;}

        public DateTime BirthDate { get;init; }

        public string ProfilePictureId { get; init;}
    }
}