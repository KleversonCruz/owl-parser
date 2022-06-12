#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OwlParser.Api/OwlParser.Api.csproj", "OwlParser.Api/"]
RUN dotnet restore "OwlParser.Api/OwlParser.Api.csproj"
COPY . .
WORKDIR "/src/OwlParser.Api"
RUN dotnet build "OwlParser.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OwlParser.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OwlParser.Api.dll"]