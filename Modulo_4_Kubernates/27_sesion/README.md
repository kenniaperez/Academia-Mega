# Clase 27: 


# Fecha: 
31/07/2025

# Objetivos
     -    Bloqueos de comunicaciones de red
     -    Apartados de seguridad a nivel de pods(endurecimiento)
     -    capabilities (linux)
     -    privileget
     -    Baseline  Politicas o seguridad estandar
     -    Restricted Requiere y habilita
     -    Fijar versión de alpine
   
# Comandos utilizados
    
     minikube start --cni=calico --driver=docker
     kubectl apply -f .\secure-app.yaml
     kubectl get pod
     kubectl log secure-app-575c878747-s8szl
     kubectl describe pod secure-app-575c878747-s8szl

     kubectl create namespace secureapp
     kubectl label ns secureapp pod-security-kubernetes.io/enforce=retricted
     kubectl label ns secureapp pod-security-kubernetes.io/enforce=baseline --overrride
     kubectl label ns secureapp pod-security-kubernetes.io/enforce=baseline --overwrite

     kubectl get pods -n secureapp
     kubectl delete pod pod-criminal -n secureapp
     kubectl label ns secureapp pod-security-kubernetes.io/enforce=restricted --overwrite

     kubectl label ns secureapp pod-security.kubernetes.io/enforce=baseline --overwrite
     kubectl delete pod pod-criminal -n secureapp
     kubectl apply -f .\pod-criminal.yaml
     kubectl delete pod pod-criminal -n secureapp
     kubectl label ns secureapp pod-security.kubernetes
     kubectl apply -f .\pod-criminal.yaml
     kubectl get pods -n kube-system
     kubectl apply -f .\pod-criminal.yaml
     kubectl delete pod pod-criminal -n secureapp
     kubectl get pods -n secureapp
     kubectl apply -f .\pod-criminal.yaml 
     kubectl get pods -n secureapp