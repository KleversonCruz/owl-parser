FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

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

CMD ASPNETCORE_URLS=http://*:$PORT dotnet OwlParser.Api.dll