
add-migration:
	dotnet ef migrations add ${name} -s src/GenericCourses.Web -p src/GenericCourses.Infra -o Persistence/Migrations

update-db:
	dotnet ef database drop -s src/GenericCourses.Web -p src/GenericCourses.Infra
	dotnet ef database update --verbose -s src/GenericCourses.Web -p src/GenericCourses.Infra

run:
	dotnet watch run --project src/GenericCourses.Web

test:
	cd tests && clear && dotnet test && cd ..
