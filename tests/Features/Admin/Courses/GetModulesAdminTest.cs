using Xunit;
using Xunit.Abstractions;
using MediatR;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Repositories.Queries;
using GenericCourses.Application.Features.Admin.Courses;
using GenericCourses.Application.Features.Admin.Courses.GetModules;
using Microsoft.EntityFrameworkCore;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using NSubstitute;
using Bogus;

namespace tests.Features.Admin;

public class GetModulesAdminTests {

	private readonly ICourseRepository _course_repository;
	private readonly IModulesRepository _modules_repository;

	private readonly ITestOutputHelper _testOutputHelper;

	private readonly Faker<ModulesByCourseQuery> _faker_paginate;

	public GetModulesAdminTests(ITestOutputHelper output) {
		_course_repository = Substitute.For<ICourseRepository>();
		_modules_repository = Substitute.For<IModulesRepository>();
		_testOutputHelper = output;

		_faker_paginate = new Faker<ModulesByCourseQuery>()
			.RuleFor(u => u.title, f => f.Person.FullName)
			.RuleFor(u => u.complete, f => f.Random.Bool());


	}

	[Fact(DisplayName = "It should runs correctly")]
	public async Task should_run_correctly() {

		// arrange
		var request = new GetModulesRequest(0, Guid.Empty);

		_course_repository.single(Arg.Any<Guid>()).Returns(new Course());
		_modules_repository.paginate(Arg.Any<Guid>(), Arg.Any<int>()).Returns(_faker_paginate.Generate(10));

		var handler = new GetModulesHandler(_modules_repository, _course_repository);

		// act
		var response = await handler.Handle(request, CancellationToken.None);

		//  assert
		Assert.NotNull(response);
	}

	[Fact]
	public async Task should_fail_with_course_null() {

		var request = new GetModulesRequest(0, Guid.Empty);

		_course_repository.single(Arg.Any<Guid>()).Returns((Course) null);
		_modules_repository.paginate(Arg.Any<Guid>(), Arg.Any<int>()).Returns(_faker_paginate.Generate(10));

		var handler = new GetModulesHandler(_modules_repository, _course_repository);

		// act
		var response = await Assert.ThrowsAsync<Exception>(
			() => handler.Handle(request, CancellationToken.None)
		);

		// assert
		Assert.IsType<Exception>(response);
	}
}
