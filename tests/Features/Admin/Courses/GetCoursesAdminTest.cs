using Xunit;
using Xunit.Abstractions;
using MediatR;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Repositories.Queries;
using GenericCourses.Application.Features.Admin.Courses;
using Microsoft.EntityFrameworkCore;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using NSubstitute;
using Bogus;

namespace tests;

public class GetCoursesAdminTest {

	private readonly ICourseRepository _course_repository;
	private readonly IModulesRepository _modules_repository;

	private Faker<GetCourseAdminQuery> _faker_paginate;

	private readonly ITestOutputHelper _testOutputHelper;

	public GetCoursesAdminTest(ITestOutputHelper output) {
		_course_repository = Substitute.For<ICourseRepository>();
		_modules_repository = Substitute.For<IModulesRepository>();
		_testOutputHelper = output;

		_faker_paginate = new Faker<GetCourseAdminQuery>("pt_BR")
			.RuleFor(u => u.id, f => f.Random.Guid())
			.RuleFor(u => u.title, f => f.Name.Locale)
			.RuleFor(u => u.is_free, f => f.Random.Bool())
			.RuleFor(u => u.active, f => f.Random.Bool())
			.RuleFor(u => u.created_at, f => DateTime.Now)
			.RuleFor(u => u.lastupdate, f => DateTime.Now)
			.RuleFor(u => u.name, f => f.Person.FirstName);
	}

	[Fact]
	public async Task first_pape() {

		// arrange
		var request = new GetCoursesAdminRequest(0);

		var results = _faker_paginate.Generate(10).ToList();
		var qt_results = new List<QtModulesByCourseQuery>();

		var rand = new Random();

		foreach (var item in results) {
			qt_results.Add(new QtModulesByCourseQuery() {
				id = item.id,
				count = rand.Next(0, 200)
			});
		}
		var ids = results.Select(item => item.id).ToArray();

		_course_repository.paginateAdmin(request.pageSize, request.pageIndex).Returns(results);

		_modules_repository.countByCourse(Arg.Any<Guid[]>()).Returns(qt_results ?? new List<QtModulesByCourseQuery>());

		_course_repository.count().Returns(90);

		var handler = new GetCoursesAdminHandler(_course_repository, _modules_repository);

		// act
		var response = await handler.Handle(request, CancellationToken.None);

		// assert
		Assert.NotNull(response);
	}
}
