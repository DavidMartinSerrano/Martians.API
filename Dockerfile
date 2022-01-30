FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Robot.API/Robot.API.csproj", "Robot.API/"]
COPY ["Robot.Application/Robot.Application.csproj", "Robot.Application/"]
COPY ["Robot.Core/Robot.Core.csproj", "Robot.Core/"]
COPY ["Robot.Infrastructure/Robot.Infrastructure.csproj", "Robot.Infrastructure/"]

RUN dotnet restore "Robot.API/Robot.API.csproj"
COPY . .
WORKDIR "/src/Robot.API"
RUN dotnet build "Robot.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Robot.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Robot.API.dll"]