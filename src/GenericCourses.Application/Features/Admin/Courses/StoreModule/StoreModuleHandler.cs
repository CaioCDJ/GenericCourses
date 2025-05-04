using MediatR;
using GenericCourses.Infra.Repositories;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Admin.Courses;

public class StoreModuleHandler : IRequestHandler<StoreModuleRequest, Module> {

	private readonly IModulesRepository _modulesRepository;
	private readonly ICourseRepository _courseRepository;

	public StoreModuleHandler(IModulesRepository modulesRepository, ICourseRepository courseRepository) {
		_modulesRepository = modulesRepository;
		_courseRepository = courseRepository;
	}

	public async Task<Module> Handle(StoreModuleRequest request, CancellationToken ct) {

		var course = await _courseRepository.single(request.course_id);

		if (course is null) { }

		var module = await _modulesRepository.store(new Module() {
			title = request.title,
			courseId = request.course_id,
			description = request.description
		});

		if (module is null) { }

		return module;
	}
}
