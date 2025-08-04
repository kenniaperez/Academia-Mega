# Clase 19: 


# Fecha: 
21/07/2025

# Objetivos
    
    -   Cron Jobs (Crea uno o varios nodos para realizar una tarea infinita)
    -   -r de donde se sacaran los requirements
    -   Invoke exoression
    
# Comandos utilizados
    minikube start
    docker build -t pod-monitor:v1 . 
    docker image 
    docker get pods 
    kubectl apply -f .\rbac.yml 
    kubectl apply -f .\cronjob.yaml 
    kubectl get jobs –watch 
    kubectl get pods 
    Kubectl get describe  
    Kubectl apply –f .\cronjob.yaml 
    Kubectl get jobs 
    Kubectl get describe pod 
    Kubectl get pod 
    minikube -p minikube docker-env 
    minikube -p minikube docker-env --shell powershell | Invoke-Expression 
    docker build -t pod-monitor:v1 . 
    docker build -t pod-monitor:v1 .  
    kubectl get pod-monitor-job-29218505 
    kubectl get jobs 
    kubectl logs pod-monitor-job-29218505-8lnm4 
        