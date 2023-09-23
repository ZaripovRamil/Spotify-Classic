FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SearchAPI/SearchAPI.csproj", "SearchAPI/"]
COPY ["DatabaseServices/DatabaseServices.csproj", "DatabaseServices/"]
COPY ["Database/Database.csproj", "Database/"]
COPY ["Models/Models.csproj", "Models/"]
RUN dotnet restore "SearchAPI/SearchAPI.csproj"
COPY . .
WORKDIR "/src/SearchAPI"
RUN dotnet build "SearchAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SearchAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SearchAPI.dll"]
