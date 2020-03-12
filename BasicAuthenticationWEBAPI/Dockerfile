FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 
WORKDIR /app

EXPOSE 8081 

# copy csproj and restore as distinct layers
COPY . .
RUN msbuild /p:Configuration=Release

FROM mcr.microsoft.com/dotnet/framework/runtime:4.8 AS runtime
WORKDIR /app
COPY . .
ENTRYPOINT BasicAuthenticationWEBAPI.exe