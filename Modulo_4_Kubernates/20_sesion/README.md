# Clase 20: 


# Fecha: 
22/07/2025

# Objetivos
    
    -   Names pace (carpeta logica en la que se agregaran todos los pods dentro de un mismo cluster)
    -   Visualización de namespace de un determinado pod
    -   Un contenedor usa mas de una CPU
    
# Comandos utilizados
    
    kubectl get namespaces 
    kubectl create namespace dev 
    kubectl create namespace prod 
    kubectl get namespaces 
    Kubectl run test-pod --image=busybox -it --rm --restart=Never --namespace dev –sh 
    Kubectl get pods 
    Kubectl get poids -n pods 
    kubectl apply -f .\quota-dev.yaml 
    kubectl rescribe resourcequota dev-quota -n dev 
    kubectl rescribe resourcequota dev-quota -n dev 
    kubectl apply -f .\deployment-cpuhog.yaml  
    Kubectl describe quota dev-quota -n dev 
    Kubectl get pods –n dev 
    Kubectl describe quota dev-quota –n dev 
    Kubectl get pods –n dev 
    kubectl apply -f .\limitrange-dev.yaml 
    Kubectl describe limitrange dev-limitrange -n dev 
    kubectl run test --image=busybox -n -- sleep 1000 
    kubectl describe quota dev-quota 
    Kubectl get pod test –n dev –o yaml 
    Kubectl get pods –n dev 
    Kubectl get pod test –n dev –o yaml | Select-String –Pattern "resources:" -Context 0, 4 