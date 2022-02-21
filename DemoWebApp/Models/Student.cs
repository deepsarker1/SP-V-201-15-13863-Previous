using System.Text.RegularExpressions;
namespace DemoWebApp.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        public string BirthDate { get; set; }
        public int Age
        {
        get {
                string[] BirthDateSplitted = this.BirthDate.Split("-");
                string[] CurrentDateSplitted = DateTime.Now.ToString("d-M-yyyy").Split("-");
                int age = Int16.Parse(CurrentDateSplitted[2])-Int16.Parse(BirthDateSplitted[2]);
                if(Int16.Parse(CurrentDateSplitted[0])<Int16.Parse(BirthDateSplitted[0]) &&
                    Int16.Parse(CurrentDateSplitted[1]) < Int16.Parse(BirthDateSplitted[1])){
                    age -= 1;
                }
                return age ; }
        set {;}
        }

        public string Gender { get; set; }

        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string University { get; set; }

    }
}
