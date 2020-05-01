FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build
WORKDIR /app

EXPOSE 8081

# copy csproj and restore as distinct layers
COPY *.sln .
COPY BasicAuthenticationWEBAPI/*.csproj ./BasicAuthenticationWEBAPI/
COPY BasicAuthenticationWEBAPI/*.config ./BasicAuthenticationWEBAPI/
RUN nuget restore

# copy everything else and build app
COPY BasicAuthenticationWEBAPI/. ./BasicAuthenticationWEBAPI/
WORKDIR /app/BasicAuthenticationWEBAPI
RUN msbuild /p:Configuration=Release


FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8 AS runtime
WORKDIR /app
COPY --from=build /app/BasicAuthenticationWEBAPI/. ./
ENTRYPOINT ["BasicAuthenticationWEBAPI.exe"]

