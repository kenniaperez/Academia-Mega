# Clase 30: 


# Fecha: 
05/08/2025

# Objetivos
     -    Balanceo de carga (Redistribución de trafico)
     

   
# Comandos utilizados
    
     minikube start --driver=docker --cpus=4 --memory=6g
     minikube addons enable metallb
     kubectl -n metallb-system get pods
     kubectl apply -f .\app-deploy.yaml 
     kubectl rollout status deploy/myapp
     kubectl get pods
     kubectl apply -f .\myapp-svc.yaml
     kubectl get svc myapp-svc
     kubectl apply -f .\trafict-job.yaml
     kubectl wait --for=condition=complete job/trafict-generator
     kubectl logs job/trafict-generator
     kubectl get svc myapp-svc
     kubectl -n metallbsystem get configmap -o yaml
     minikube ip
     kubctl apply -f .\metallb-config.yaml
     kubectl get svc myapp-svc
     kubectl logs job/traffic-generator
     kubectl delete job traffic-generator
     kubectl apply -f .\applymetallb-config
     kubectl logs job/traffic-generator
     kubectl get svc myapp-svc
     kubeclt wait --for-condition=complete job/traffinc-generator
     kubectl logs job/traffic-generator
     kubectl apply -f .\trafict-job.yaml
     kubectl logs job/traffic-generator
     kubectl get svc myapp-svc
     kubectl annotate sv myapp-svc metallb.universe.tf/allow-shared.ip=
     kubectl delete job traffic-generator
     kubectl logs job/traffic-generator
     kubectl run curl --rm -it --image:busybox --restart=Never -- wget -qO- http://echo-svc
     kubectl run curl --rm -it --image:busybox --restart=Never -- wget -qO- http://echo-svc
     kubectl run curl --rm -it --image:busybox --restart=Never -- wget -qO- http://10.98.233.4
     kubectl run curl --rm -it --image:busybox --restart=Never -- wget -qO- http://192.168.49.240
     minikube tunnel
     minikube delete
     minikube addons enablke metallb
     kubectl apply -f .\metallb-config.yaml
     kubectl -f .\myapp-svc.yaml
     kubectl get svc myapp-svc 
     kubectl get pods
     kubectl apply -f .\traffic-generator