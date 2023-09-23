FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["StaticAPI/StaticAPI.csproj", "StaticAPI/"]
COPY ["Models/Models.csproj", "Models/"]
RUN dotnet restore "StaticAPI/StaticAPI.csproj"
COPY . .
WORKDIR "/src/StaticAPI"
RUN dotnet build "StaticAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StaticAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StaticAPI.dll"]
