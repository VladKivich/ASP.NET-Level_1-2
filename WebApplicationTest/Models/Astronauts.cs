using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    public enum Status
    {
        Former = 0,
        Active = 1
    }

    public enum Gender
    {
        male = 1,
        female = 2
    }

    public class Astronauts
    {
        public byte ID;

        public string Name;

        public string GroupSet;

        private DateTime Data;

        public string Post;

        public Status Status;

        public int NumberOfFlights;

        public Gender Gender;

        public Astronauts(byte ID, string Name, string Group, DateTime Data, string Post, Status Status, int NumberOfFlights, Gender Gender)
        {
            this.ID = ID;
            this.Name = Name;
            GroupSet = Group;
            this.Data = Data;
            this.Post = Post;
            this.Status = Status;
            this.NumberOfFlights = NumberOfFlights;
            this.Gender = Gender;
        }

        public int Year
        {
            get
            {
                return Data.Year;
            }
        }
    }
}
