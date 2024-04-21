FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ADD ../https/aspnetapp.pfx /https/aspnetapp.pfx

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PaymentAPI/PaymentAPI.csproj", "PaymentAPI/"]
COPY ["Utils/Utils.csproj", "Utils/"]
COPY ["DatabaseServices/DatabaseServices.csproj", "DatabaseServices/"]
COPY ["Database/Database.csproj", "Database/"]
COPY ["Models/Models.csproj", "Models/"]
RUN dotnet restore "PaymentAPI/PaymentAPI.csproj"
COPY . .
WORKDIR "/src/PaymentAPI"
RUN dotnet build "PaymentAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PaymentAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PaymentAPI.dll"]
