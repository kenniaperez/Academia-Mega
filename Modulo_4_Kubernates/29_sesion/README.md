# Clase 29: 


# Fecha: 
04/08/2025

# Objetivos
     -    Proyecto (secrets, audits)
     -    Regla de auditoria 
     -    Cifrado en transito y cifrado en reposo

   
# Comandos utilizados
    
     minikube start --cni=calico --driver=docker
     minikube delete
    
     kubectl apply -f .\k8s\01-networkpolicies.yaml
     kubectl apply -f .\k8s\02-rbac.yaml
     kubectl apply -f .\k8s\03-postgres.yaml
     kubectl apply -f .\k8s\04-backend.yaml
     kubectl apply -f .\k8s\05-frontend.yaml
     kubectl describe pod ""
     kubectl 
     minikube addons enable gvisor-runtimesdlass
     kubectl get pods -n 
     kubectl apply -f .\k8s\05-frontend.yaml