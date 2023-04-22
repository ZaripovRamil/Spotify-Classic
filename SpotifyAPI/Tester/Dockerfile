FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Tester/Tester.csproj", "Tester/"]
RUN dotnet restore "Tester/Tester.csproj"
COPY . .
WORKDIR "/src/Tester"
RUN dotnet build "Tester.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tester.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tester.dll"]
