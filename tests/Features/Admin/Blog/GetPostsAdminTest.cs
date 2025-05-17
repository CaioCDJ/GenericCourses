using Xunit;
using Xunit.Abstractions;
using MediatR;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Repositories.Queries;
using GenericCourses.Application.Features.Admin.Blog;
using Microsoft.EntityFrameworkCore;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using NSubstitute;
using Bogus;

namespace tests.Features.Admin.Blog;

public class GetPostAdminTests {

	private readonly IPostRepository _post_repository;

	public GetPostAdminTests() {
		_post_repository = Substitute.For<IPostRepository>();
	}
/*
	[Fact]
	public async Task should_run_correctly() {

		// arrange
		var request = new GetPostsAdminRequest(Guid.NewGuid(), 0);

		_post_repository.paginateAdmin(
				Arg.Any<Guid>(), Arg.Any<int>())
			.Returns(new List<GetPostAdminQuery>());

		_post_repository.QtByUsers(Arg.Any<Guid>())
			.Returns(1);

		var handler = new GetPostsAdminHandler(_post_repository);

		// act
		var response = await handler.Handle(request, CancellationToken.None);

		// assert
		Assert.NotNull(response);
	}
	*/
}
