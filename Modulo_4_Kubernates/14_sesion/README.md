# Clase 14: 


# Fecha: 
10/07/2025

# Objetivos
    
    -   Volumenes por persistencia 
    -   Volumen vació : compartir archivos entre contenedores
    -   Volumen persistente 
    -   Almacenamiento que lo provee el cluster 
 
# Comandos utilizados
    kubectl apply -f .\pod-dos-contenedores.yaml 
    kubectl get pods 
    kubectl logs demo-volumen1 -c reader 
    kubectl logs demo-volumen1 -c reader 
    kubectl logs demo-volumen1 -c  
    kubectl exec demo-volumen1 -c reader -- ls data  
    kubectl exec demo-volumen1 -c writer -- ls data   
    kubectl exec –ti demo-volumen1 -c writer sh 
    minikube version 
    kubectl exec -ti demo-volumen1 -c reader -- sh 
    Kubectl apply -f .\mysql-deployment.yaml 
    Kubectl get pods 
    Kubectl exec –ti -l app=mysql-db – mysql –uroot –p'5f6g7h8j9k01.' Demo 
    kubectl exec -it mysql-db-89dbb9748-d5mkq -- mysql -uroot -p'5f6g7h8j9k0l.' demo 
    create table prueba (id INT PRIMARY KEY,  nombre VARCHAR(50)); 
    INSERT INTO prueba VLAUES(1,'kubernetes') 
    /q
    Kubectl delete pod mysql-db-89dbb99748-d5mk 
    SELECT* FROM prueba  
    Kubctl delete deployment mysql-db 
    Kubectl delete pcv dmeo-pvc
    
    https://kubernetes.io/es/docs/concepts/storage/persistent-volumes/ 