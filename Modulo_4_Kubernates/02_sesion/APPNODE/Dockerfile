#Esta es mi base o el runtime donde mi app se va a ejecutar
FROM node:22
#Establecer el directorio de trabajo dentro de la imagen (esto es para docker pero puede cambiar con algún otro lenguaje)
WORKDIR /usr/src/app
#Crear la carpeta de trabajo donde vivira la imagen, la aplicación
#Copiar en el archivo de definición de dependencias
COPY package*.json ./
# Instalar las dependencias
RUN npm install
# Copiar la solución 
COPY . .
# Exponer un puerto 
#ENV PORT=${PORT}
EXPOSE 3000
# Comando que inicie la aplicación
CMD ["node","app.js"]

