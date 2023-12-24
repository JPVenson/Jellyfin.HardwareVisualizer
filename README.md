# Jellyfin.HardwareVisualizer
Repository to host the Hardware Survey visualizer Server

Contains the Blazor application to Display all hardware survey data in a Barchart form.

Example use docker-compose.yaml:

```yaml
version: '3'
services:
  jellyfin-hardware-survey-web:
    image: ghcr.io/jpvenson/jellyfin.hardwarevisualizer:main
    hostname: jellyfin-hardware-survey-web
    environment:
      - PG_User=jellyfin
      - PG_Password=jellyfin
      - PG_Host=jellyfin-hardware-survey-database
      - PG_Port=5432
      - PG_Database=Jellyfin.HardwareVisualizer
    restart: always
    ports:
      - 80:8080
    depends_on:
      - jellyfin-hardware-survey-database
    networks:
      - compose_jellyfin_hardware_survey_network
  jellyfin-hardware-survey-database:
    image: postgres:16-alpine
    hostname: jellyfin-hardware-survey-database
    environment:
      - POSTGRES_USER=jellyfin
      - POSTGRES_PASSWORD=jellyfin
      - POSTGRES_HOST=jellyfin-hardware-survey-database
      - POSTGRES_PORT=5432
      - POSTGRES_DATABASE=Jellyfin.HardwareVisualizer
    volumes:
      - postgres-data:/var/lib/postgresql/data
    restart: always
    networks:
      - compose_jellyfin_hardware_survey_network
volumes:
  postgres-data: {}

networks:
  compose_jellyfin_hardware_survey_network:    
    name: "compose_jellyfin-hardware-survey_network"

```
