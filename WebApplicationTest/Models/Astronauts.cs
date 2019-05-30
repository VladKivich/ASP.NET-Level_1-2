using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    /// <summary>
    /// Свой атрибут
    /// </summary>
    public class MyRangeAttribute : RangeAttribute
    {
        private int maximum;
        private int minimum;


        public MyRangeAttribute(int minimum, int maximum):base(minimum, maximum)
        {
            this.minimum = minimum;
            this.maximum = maximum;
        }

        public override bool IsValid(object value)
        {
            bool Result = (value is int) ? InRange(Convert.ToInt32(value)) : false;

            if(Convert.ToInt32(value) < minimum)
            {
                ErrorMessage = "Don't mess with Gagarin!";
            }
            else if(Convert.ToInt32(value) > DateTime.Now.Year)
            {
                ErrorMessage = "Time travel is not allowed!";
            }

            return Result;
        }

        private bool InRange(int value)
        {
            return (value >= minimum & value <= maximum) ? true : false;
        }
    }

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

        [Required(AllowEmptyStrings =false, ErrorMessage = "Enter the name")]
        [StringLength(maximumLength:50,MinimumLength =3, ErrorMessage = "Maximum Name Lenght = 50 symbols, Minimum Name Lenght = 3 symbols")]
        public string Name { get; set; }
        
        [Display(Name ="Группа вылета")]
        public string GroupSet { get; set; }
        
        public DateTime Data { get; private set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter your post in mission")]
        [StringLength(maximumLength:30, MinimumLength=5, ErrorMessage = "Maximum Post Lenght = 30 symbols, Minimum Name Lenght = 10 symbols")]
        public string Post { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter your status")]
        public Status Status { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter your status")]
        [Range(minimum:0, maximum:50, ErrorMessage ="Incorrect number! Max range = 50")]
        public int NumberOfFlights { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter your gender")]
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

        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Flight year")]
        [MyRange(1961, 2019)]
        public int Year
        {
            get
            {
                return Data.Year;
            }

            set
            {
                Data = new DateTime(Math.Abs(value) > 0 ? Math.Abs(value) : 1, 1, 1);
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
