FROM mcr.microsoft.com/dotnet/core/sdk:3.1.101 AS build
WORKDIR /app
EXPOSE 5001
EXPOSE 5000

WORKDIR /app/EstateApp.Data
COPY EstateApp.Data/*.csproj .

COPY EstateApp.Data/ .

WORKDIR /app/EstateApp.Web
COPY EstateApp.Web/*.csproj .
RUN dotnet restore

COPY EstateApp.Web/ .

RUN dotnet publish -c Release -o out


# Build runtime image
FROM mcr.microsoft.com/dotnet/core/sdk:3.1.101
WORKDIR /app
COPY --from=build /app/EstateApp.Web/out .
ENTRYPOINT ["dotnet", "EstateApp.Web.dll"]
