# Clase 15: 


# Fecha: 
11/07/2025

# Objetivos
    
    -   Volumenes por persistencia 
    -   Volumen vació : compartir archivos entre contenedores
    -   Volumen persistente 
    -   Almacenamiento que lo provee el cluster 
    
# Comandos utilizados
    Kubectl create configmap app-config –from-literal=APP_COLOR=blue  
    --from-literal==WELCOME_MSG="Hola hola hola" 
    minikube start 
    Kubectl decribe configmap app-config 
    kubectl create configmap nginx-index --from-file=index.html 
    Kubectl apply –f .\deployment-nginx-index.yaml 
    Kubectl get pods 
    Imperativo  
    Kubctl expose deployment nginx-custom –port=80 –type=NodePort  
    --name nginx-custom-svc 
    kubectl expose deployment nginx-custom --port=80 --type=NodePort --name nginx-custom-svc 
    Kubectl get svc nginx-custom-svc 
    Minikube service nginx-custom-svc 
    Kubectl exec –ti –l app=nginx app= nginx-custom 
    Kubectl get pods 
    Kubectl exec ti nginx-custom-********* --printenv grep APP_COLOR 
    Imperativo  
    Kubectl create secret generic db-secret  --from-literal=MYSQL_ROOT_PASSWORD=5f6g7h8j9k0l. --from-literal=MYSQL_USER=usuario1 –from-literal=MYSQL_PASSWORD=5f6g7h8j9k0l. --from-literal=MYSQL_USER=usuario2 
    Kubctl get secret  
    minikube service nginx-custom-svc 
    Kubectl apply –f .\mysql-deployment.yamlkubctl get pods 
    SRE 