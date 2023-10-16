FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ADD ../https/aspnetapp.pfx /https/aspnetapp.pfx

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ChatApi/ChatApi.csproj", "ChatApi/"]
COPY ["Models/Models.csproj", "Models/"]
RUN dotnet restore "ChatApi/ChatApi.csproj"
COPY . .
WORKDIR "/src/ChatApi"
RUN dotnet build "ChatApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ChatApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChatApi.dll"]
