#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Server/Jellyfin.HardwareVisualizer.Server.csproj", "Server/"]
COPY ["Jellyfin.HardwareVisualizer.Database/Jellyfin.HardwareVisualizer.Database.csproj", "Jellyfin.HardwareVisualizer.Database/"]
COPY ["Shared/Jellyfin.HardwareVisualizer.Shared.csproj", "Shared/"]
COPY ["Client/Jellyfin.HardwareVisualizer.Client.csproj", "Client/"]
RUN dotnet restore "./Server/./Jellyfin.HardwareVisualizer.Server.csproj"
COPY . .
WORKDIR "/src/Server"
RUN dotnet build "./Jellyfin.HardwareVisualizer.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release

RUN apt-get update -y && apt-get install python3-pip python3 -y && pip3 install stix2

RUN dotnet publish "./Jellyfin.HardwareVisualizer.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Jellyfin.HardwareVisualizer.Server.dll"]