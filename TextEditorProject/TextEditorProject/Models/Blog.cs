using System.ComponentModel.DataAnnotations;

namespace TextEditorProject.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
