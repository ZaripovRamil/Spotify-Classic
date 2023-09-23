FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DatabaseAPI/DatabaseAPI.csproj", "DatabaseAPI/"]
COPY ["DatabaseServices/DatabaseServices.csproj", "DatabaseServices/"]
COPY ["Database/Database.csproj", "Database/"]
COPY ["Models/Models.csproj", "Models/"]
RUN dotnet restore "DatabaseAPI/DatabaseAPI.csproj"
COPY . .
WORKDIR "/src/DatabaseAPI"
RUN dotnet build "DatabaseAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DatabaseAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DatabaseAPI.dll"]
