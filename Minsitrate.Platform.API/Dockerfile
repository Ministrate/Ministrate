FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Minsitrate.Platform.API/Minsitrate.Platform.API.csproj", "Minsitrate.Platform.API/"]
RUN dotnet restore "Minsitrate.Platform.API/Minsitrate.Platform.API.csproj"
COPY . .
WORKDIR "/src/Minsitrate.Platform.API"
RUN dotnet build "Minsitrate.Platform.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Minsitrate.Platform.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Minsitrate.Platform.API.dll"]
