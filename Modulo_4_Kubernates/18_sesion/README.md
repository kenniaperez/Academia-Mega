# Clase 18: 


# Fecha: 
18/07/2025

# Objetivos
    
    -   Cron Jobs (Crea uno o varios nodos para realizar una tarea infinita)
    -   Demonset (Un solo pod por nodo)
    -   completions (limite de cuantas ejecusiones exitosas se requieren para que el job se detenga)
    
# Comandos utilizados
    Kubectl describes jobs (crea 5 pods) 
    kubectl apply -f .\cron-job-demo.yaml 
    kubectl get cronjob 
    kubectl get pods 
    Kubectl logs date-printer-29124213-m85p8 
    Kubectl get jobs 
    Kubectl get pods 
    Kubectl get jobs 
    Kubectl dfelete cronjob date-printer 
    