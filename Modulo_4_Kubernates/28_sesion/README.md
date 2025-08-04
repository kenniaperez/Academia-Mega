# Clase 28: 


# Fecha: 
01/08/2025

# Objetivos
     -    Proyecto (secrets, audits)
     -    Regla de auditoria 
     -    Cifrado en transito y cifrado en reposo

   
# Comandos utilizados
    
     minikube start --cni=calico --driver=docker
     minikube delete
     minikube start --driver=docker --cpus=4 --memory=6g --extra-config=apiserver.audit-policy-file=/cluster-config/audit-policy.yaml --extra-config=apiserver.audit-log-path=/var/log/k8s-audit.log --extra-config=apiserver.encryption-provider-config=/cluster-config/encryption-config.yaml

     minikube start --driver=docker --cpus=4 --memory=6g --extra-config=apiserver.audit-policy-file=/cluster-config/audit-policy.yaml --extra-config=apiserver.audit-log-path=/var/log/k8s-audit.log

     minikube start
     kubectl apply -f .\cluster-config\gvisor-runtimeclass.yaml