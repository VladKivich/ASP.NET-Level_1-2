using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    public enum Status
    {
        Former = 0,
        Active = 1,
        Unknown = 2
    }

    public enum Gender
    {
        male = 1,
        female = 2,
        Unknown = 3
    }

    public class Astronauts
    {
        public byte ID { get; set; }

        public string Name { get; set; }

        public string GroupSet { get; set; }

        public DateTime Data { get; private set; }

        public string Post { get; set; }

        public Status Status { get; set; }

        public int NumberOfFlights { get; set; }

        public Gender Gender { get; set; }

        public Astronauts(byte ID, string Name, string Group, int Year, string Post, Status Status, int NumberOfFlights, Gender Gender)
        {
            this.ID = ID;
            this.Name = Name;
            GroupSet = Group;
            this.Data = new DateTime(Year, 1, 1);
            this.Post = Post;
            this.Status = Status;
            this.NumberOfFlights = NumberOfFlights;
            this.Gender = Gender;
        }

        public Astronauts()
        {
            this.ID = 0;
            this.Name = "Unknown";
            GroupSet = "Unknown";
            this.Data = DateTime.Now;
            this.Post = "Unknown";
            this.Status = Status.Unknown;
            this.NumberOfFlights = 0;
            this.Gender = Gender.Unknown;
        }

        public void ChangeData(Astronauts NewAstroData)
        {
            ID = NewAstroData.ID;
            Name = NewAstroData.Name;
            GroupSet = NewAstroData.GroupSet;
            Data = NewAstroData.Data;
            Post = NewAstroData.Post;
            Status = NewAstroData.Status;
            NumberOfFlights = NewAstroData.NumberOfFlights;
            Gender = NewAstroData.Gender;
        }

        public int Year
        {
            get
            {
                return Data.Year;
            }
        }

        public Astronauts GetAstro
        {
            get
            {
                return this;
            }
        }
    }
}
