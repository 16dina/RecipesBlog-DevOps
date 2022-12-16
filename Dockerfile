# Get base SDK Image from MS
FROM mcr.microsoft.com/dotnet/sdk:3.1.426-alpine3.16 AS CS-build
WORKDIR /app

# Copy the CSPROJ file which is caseStudy.csproj and restore any dependecies (via NUGET package manager)
COPY *.csproj ./

# Copy all our project's files and build our release
COPY . ./
RUN dotnet publish -c Release -o out

# Generate the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:3.1.32-alpine3.16
WORKDIR /app
EXPOSE 80
COPY --from=CS-build /app/out .
ENTRYPOINT ["dotnet", "caseStudy.dll"]