
namespace GenericCourses.Infra.Repositories.Queries;

public class GetSubscriptionsQuery {
	public Guid id { get; set; }
	public float price { get; set; }
	public string description { get; set; }
	public DateTime created_at { get; set; }
	public int months { get; set; }
	public int clients { get; set; }
}
