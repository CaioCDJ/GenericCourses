namespace GenericCourses.Domain.Entities;

public class Certificate{

    public Guid id { get; set; } = Guid.NewGuid();
    public Guid courseId { get; set; }
    public DateTime emited_at { get; set; }
}
