﻿FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

COPY DummyApp.csproj ./DummyApp.csproj

RUN dotnet restore ./DummyApp.csproj

COPY . .

RUN dotnet publish ./DummyApp.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build-env /app/out .


ENTRYPOINT ["dotnet", "DummyApp.dll"]
