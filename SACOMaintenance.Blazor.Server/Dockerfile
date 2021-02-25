#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SACOMaintenance.Blazor.Server/SACOMaintenance.Blazor.Server.csproj", "SACOMaintenance.Blazor.Server/"]
RUN dotnet restore "SACOMaintenance.Blazor.Server/SACOMaintenance.Blazor.Server.csproj"
COPY . .
WORKDIR "/src/SACOMaintenance.Blazor.Server"
RUN dotnet build "SACOMaintenance.Blazor.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SACOMaintenance.Blazor.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SACOMaintenance.Blazor.Server.dll"]