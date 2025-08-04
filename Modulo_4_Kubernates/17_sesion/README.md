# Clase 17: 


# Fecha: 
15/07/2025

# Objetivos
    
    -   Redis server
    -   Configuraciones estaticas
    -   Replicas
    
# Comandos utilizados

    minikube start 
    kubectl apply -f .\states-examples.yaml 
    kubectl apply -f .\redis-statefulset.yaml 
    kubectl get pods 
    kubectl delete pod redis-0 
    kubectl logs redis set 
    kubectl exec -ti redis -0 --redis-cli SET mykey "Hola" 
    kubectl exec redis-1 – getent 
    kubectl get svc redis -o wide 
    kubectl exec redis-0 - redis-cli INFO replication 
    kubectl exec -h redis-0 - redis-cli REPLICAOF NO ONE 
    kubectl exec -ti redis -0 --redis-cli SET mykey "Hola" 
    kubectl exec -ti redis -1 --redis-cli SET mykey "Hola" 
    kubectl exec -h redis-0 - redis-cli REPLICAOF NO ONE redis-0.redis.default.svc.cluster.local 6379 