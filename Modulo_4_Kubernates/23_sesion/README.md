# Clase 23: 


# Fecha: 
25/07/2025

# Objetivos
    
   
# Comandos utilizados
    
    kubectl –n kube-system get deploy metrics-server 
    minikube 
    kubectl top pods 
    mkdir clase23-escalado 
    kubectl apply -f .\deployment-demo.yaml 
    kubectl top pods 
    kubectl get pods 
    kubectl autoscale 
    kubectl autoscale deployment cpu-demo --cpu-percent=50 --min=1 – max=10 
    kubectl get pods 
    kubectl get hpa 
    kubectl edit cpu-demo 
    kubectl autoscale deployment cpu-demo --cpu-percent=50 --min=1 – max=10 
    kubectl hpa cpu-demo 
    kubectl patch hpa cpu-demo --patch   
    kubectl describe cpu-demo 
    kubectl whatch –n default kubectl get hpa cpu-demo 
    kubectl get hpa cpu-demo -w 
    kubectl delete hpa cpu-demo 


    helm repo update 
    kubectl create namespace monitoring 
    helm install monitoring prometheus-community/kube-prometheus-stack -n monitoring 
    kubectl get pods 
    

    Acceder a grafana  

    kubectl port-forward 
    kubectl get service 
    kubectl port-forward –n monitoring svc/monitoring-grafana 300:80 
    kubectl port-forward -n monitoring svc/monitoring-grafana 3000:80 
    kubectl get secret –n monitoring monitrin 
    https://www.base64decode.org/ 
    kubectl get secret -n monitoring monitoring-grafana -o jsonpath="{.data.admin-password}