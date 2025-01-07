FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS production

EXPOSE 8080
EXPOSE 8081


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
# Install NodeJS
RUN apt-get update -yq && apt-get upgrade -yq && apt-get install -yq 
RUN curl -sL https://deb.nodesource.com/setup_16.x | bash - && apt-get install -yq nodejs 

COPY ./ .
WORKDIR "src/GenericCourses.Web"
RUN npm i
RUN dotnet restore
RUN dotnet publish -c Release -o /app

FROM production as final
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "GenericCourses.Web.dll"]
