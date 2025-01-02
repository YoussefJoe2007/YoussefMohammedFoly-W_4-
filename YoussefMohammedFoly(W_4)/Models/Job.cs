using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YoussefMohammedFoly_W_4_.Models
{
    public class Job
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [RegularExpression("^(Pending|InProgress|Completed)$", ErrorMessage = "Status must be 'Pending', 'InProgress', or 'Completed'")]
        public string Status { get; set; }
        [Required(ErrorMessage = "Priority is required")]
        public string Priority { get; set; }
        [Required(ErrorMessage = "Deadline is required")]
        public DateTime Deadline { get; set; }
        [ForeignKey("ProjectId")]
        [Required(ErrorMessage = "ProjectId is required")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        [ForeignKey("TeamMemberId")]
        [Required(ErrorMessage = "TeamMemberId is required")]
        public int TeamMemberId { get; set; }
        public TeamMember TeamMember { get; set; }






    }
}   
