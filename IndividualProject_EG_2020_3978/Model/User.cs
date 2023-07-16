using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Desktop01.Model
{
    public class User
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public BitmapImage Image { get; set; }  

        public string  DateOfBirth{ get; set; }
        public Double GPA { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
         
        

        public String ImagePath
        {
            get { return $"/Model/Images/{Image}"; }
        }

        public string AcademicAdvisor { get; set; }

        public User(int id,int age, string firstName, string lastName, string dateOfBirth,BitmapImage  image,string email, string phoneNumber )
        {
            Id = id;
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Image = image;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public User()
        {
        }
    }
}
