using System.ComponentModel.DataAnnotations;

namespace student.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        [StringLength(1)]
        public string Sex { get; set; }
        [Range(1, 200, ErrorMessage = "年龄应在0-200之间")]
        public int Age { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(13)]
        public string Phone { get; set; }
        [Range(30, 50)]
        public int Temperature { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
