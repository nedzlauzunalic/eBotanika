#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["eBotanika.API/eBotanika.API.csproj", "eBotanika.API/"]
RUN dotnet restore "eBotanika.API/eBotanika.API.csproj"
COPY . .
WORKDIR "/src/eBotanika.API"
RUN dotnet build "eBotanika.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eBotanika.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eBotanika.API.dll"]