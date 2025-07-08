# Clase 9: 
Health Check

# Fecha: 
03/07/2025

# Objetivos
    
    -   Balanceadores de carga
    -   Docker Logs
    
# Comandos utilizados
    dotnet run 
    $ dotnet new webapi -n DotnetMinimalAPIDemo 
    docker-compose up --scale api=3 –d 
    dotnet run 
    docker ps 
    docker logs dotnetminimalapidemo-api-1 
    docker stop dotnetminimalapidemo-api-1 
    docker system prune 
    