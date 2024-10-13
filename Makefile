update-db:
	dotnet ef database drop -s src/GenericCourses.Web -p src/GenericCourses.Infra
	dotnet ef database update -s src/GenericCourses.Web -p src/GenericCourses.Infra

run:
	dotnet watch run --project src/GenericCourses.Web
