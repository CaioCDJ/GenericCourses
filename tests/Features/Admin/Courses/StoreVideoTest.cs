using MediatR;
using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories;
using GenericCourses.Domain.Entities;
using GenericCourses.Application.Features.Admin.Courses;
using GenericCourses.Domain.Entities;
using NSubstitute;
using Bogus;
using Xunit.Abstractions;

namespace tests.Features.Admin;

public class StoreVideoHandlerTests{

	private readonly IModulesRepository modules_repository;
	private readonly IVideosRepository videosRepository;
	private readonly ITestOutputHelper _testOutputHelper;

	public StoreVideoHandlerTests(ITestOutputHelper helper){
		_testOutputHelper=  helper;
		videosRepository = Substitute.For<IVideosRepository>();
		modules_repository = Substitute.For<IModulesRepository>();
	}

	[Fact(DisplayName ="it should runs correctly")]
	public async Task happy_end(){

		// arrange
		var module_id = Guid.NewGuid();

		var request = new StoreVideoRequest(
			title: "Ola",
			order:0,
			video_url:"kdkkd",
			desc:"kdkkdkdkd",
			module_id: module_id
		);

		var new_video = new Video() {
			title = request.title,
			description = request.desc,
			videoUrl = request.video_url,
			order = request.order,
			moduleId = request.module_id
		};

		modules_repository.single(module_id).Returns(new Module());
		videosRepository.store(new_video).Returns(new_video);
		
		var handler = new StoreVideoHandler(videosRepository,modules_repository);

		// act
		var response = await handler.Handle(request, CancellationToken.None);

		// assert
		Assert.NotNull(response.Error);
	}
}
