# Clase 8: 
Health Check

# Fecha: 
02/07/2025

# Objetivos
    
    -   Creación de Health Check (Revisar la salud de nuestro contenedor)
    
    
# Comandos utilizados

    git clone https://github.com/dockersamples/example-voting-app.git 
    docker compose -f docker-compose.images.yml up -d 
    docker compose up --build –d 
    docker compose up –d 
    docker inspect example-voting-app-vote-1 --format='{{.State.Health}}' 
    docker inspect example-voting-app-vote 
    docker inspect example-voting-app-vote --format='{{.Metadata.LastTagTime}}' 