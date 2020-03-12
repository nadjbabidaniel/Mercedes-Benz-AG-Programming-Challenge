FROM mcr.microsoft.com/dotnet/framework/sdk:4.7.2 AS build
WORKDIR /app
EXPOSE 8080 

# copy csproj and restore as distinct layers
COPY *.sln .
COPY BasicAuthenticationWEBAPI/*.csproj ./BasicAuthenticationWEBAPI/
COPY BasicAuthenticationWEBAPI/*.config ./BasicAuthenticationWEBAPI/


# copy everything else and build app
COPY BasicAuthenticationWEBAPI/. ./BasicAuthenticationWEBAPI/
WORKDIR /app/BasicAuthenticationWEBAPI

RUN msbuild /p:Configuration=Release

