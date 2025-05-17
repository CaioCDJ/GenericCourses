using Xunit.Abstractions;
using GenericCourses.Infra.Repositories;
using GenericCourses.Application.Features.Admin.Courses;
using GenericCourses.Domain.Entities;
using NSubstitute;
using Bogus;


public class DisableCourseTests {

	private ICourseRepository _courseRepository;

	private readonly Course fake_course;
	private readonly ITestOutputHelper _testOutputHelper;

	public DisableCourseTests(ITestOutputHelper output) {

		_testOutputHelper = output;
		_courseRepository = Substitute.For<ICourseRepository>();

		fake_course = new Faker<Course>("pt_BR")
			.RuleFor(u => u.id, f => f.Random.Guid())
			.RuleFor(u => u.title, f => f.Name.Locale)
			.RuleFor(u => u.description, f => f.Lorem.Text())
			.RuleFor(u => u.thumb, f => f.Person.Avatar)
			.RuleFor(u => u.is_free, f => f.Random.Bool())
			.RuleFor(u => u.duration, f => f.Random.String())
			.RuleFor(u => u.active, f => f.Random.Bool()).Generate();
	}

	[Fact]
	public async Task clean_path() {

		// arrange
		var request = new DisableCourseRequest(fake_course.id);
		
		var updated_course_result = fake_course;
		updated_course_result.active = false;

		_courseRepository.single(request.id).Returns(fake_course);
		_courseRepository.update(fake_course).Returns(updated_course_result);

		var handler = new DisableCourseHandler(_courseRepository);

		// act
		var respons = await handler.Handle(request, CancellationToken.None);

		// assert
		Assert.Same(respons, updated_course_result);
	}
}
