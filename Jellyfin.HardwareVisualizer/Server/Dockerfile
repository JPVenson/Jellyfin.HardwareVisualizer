#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Server/Jellyfin.HardwareVisualizer.Server.csproj", "Server/"]
COPY ["Jellyfin.HardwareVisualizer.Database.csproj", "Jellyfin.HardwareVisualizer.Database/"]
COPY ["Shared/Jellyfin.HardwareVisualizer.Shared.csproj", "Shared/"]
COPY ["Client/Jellyfin.HardwareVisualizer.Client.csproj", "Client/"]

RUN dotnet workload restore "./Server/./Jellyfin.HardwareVisualizer.Client.csproj"
RUN dotnet workload restore "./Server/./Jellyfin.HardwareVisualizer.Server.csproj"

RUN dotnet restore "./Server/./Jellyfin.HardwareVisualizer.Server.csproj"
COPY . .

RUN dotnet build "./Jellyfin.HardwareVisualizer.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Jellyfin.HardwareVisualizer.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Jellyfin.HardwareVisualizer.Server.dll"]