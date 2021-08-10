using System.ComponentModel.DataAnnotations;

namespace Portfolio_Client.Model
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string ShortDescription { get; set; }
        [Required] public string Description { get; set; }
        public string GithubUrl { get; set; }
        public string ProjectUrl { get; set; }
        public bool Featured { get; set; }
        public string ImageUrls { get; set; }
    }
}