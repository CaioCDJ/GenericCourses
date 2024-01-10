using GenericCourses.Domain.Entities;

public class ModuleProgress{

  public Guid id { get; set; }
  public Module module { get; set; }
  public Guid moduleId { get; set; }
  public CourseProgress courseProgress { get; set; }
  public Guid courseProgressId { get; set; }
  public bool done { get; set; }

}
