##Construcción del proyecto


#stage Sirve para indicar que  hacer primero y que hacer despues  (como dependencias)
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /src
#Destino
COPY DemoApp/DemoApp.csproj  /src/DemoApp
#Extraera todos los package y los volvera a construir
RUN dotnet restore
#Todo
COPY  . .
#Correr en entorno developer
RUN dotnet publish DemoApp/DemoApp.csproj -c Release - /DemoApp





##
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app 
COPY --from=build /app .
EXPOSE 80 
ENV ASNETCORE_URLS=http://+80
ENTRYPOINT ["dotnet", "DemoApp.dll"]
