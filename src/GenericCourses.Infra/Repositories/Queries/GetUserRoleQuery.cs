namespace GenericCourses.Infra.Repositories.Queries;

public class GetUserRoleQuery {
	public Guid? admin_id { get; init; }
	public Guid? instructor_id { get; init; }
	public Guid? client_id { get; init; }
}
