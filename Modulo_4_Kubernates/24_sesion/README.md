# Clase 24: 


# Fecha: 
28/07/2025

# Objetivos
    
   - readinessProbe, livenessProbe, startupProbe
   - init
   - Recuperación de errores y salud de nuestra aplicación

# Comandos utilizados
    
    mkdir clase24-caos
    kubectl get pods
    kubectl apply -f probes-demo.yaml
    kubectl logs -f deployment/probes/demo
    kubectl delete deployment probes-demo
    kubectl apply -f database.yaml
    kubectl get pods
    kubectl apply -f init-web.yaml
    kubectl get pods
    kubectl describe init-web.yaml
    kubectl logs web-app-76cfb485f-h2svz
    kubectl get pods -w
    kubectl describe pods
    kubectl logs web-app-76cfb485f-h2svz -c
    kubectl apply -f init-web.yaml 
