using GenericCourses.Domain.Entities;

public class VideoProgress{

  public Guid id { get; set; }
  public Video video { get; set; }
  public Guid videoId { get; set; }
  public Module module { get; set; }
  public Guid moduleId { get; set; }
}
