using System.ComponentModel.DataAnnotations;

namespace student.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public int Temperature { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
