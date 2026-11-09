namespace CodeFirst.VidApp.Models;

public class Video
{
    // Id oder CourseId wird autom. zum PK oder [Key]
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public DateTime ReleaseDate { get; set; }
}