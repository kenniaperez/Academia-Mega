##Construcción del proyecto

#stage Sirve para indicar que  hacer primero y que hacer despues  (como dependencias)
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
#Destino
WORKDIR /src                
COPY DemoApp.csproj .
 #Extraera todos los package y los volvera a construir
RUN dotnet restore DemoApp.csproj
#Todo
COPY . .
#Correr en entorno developer
RUN dotnet publish DemoApp.csproj -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app .
EXPOSE 80
ENV ASPNETCORE_URLS=http://+:80
ENTRYPOINT [ "dotnet", "DemoApp.dll" ]