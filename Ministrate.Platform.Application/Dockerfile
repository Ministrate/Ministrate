FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Ministrate.Platform.Application/Ministrate.Platform.Application.csproj", "Ministrate.Platform.Application/"]
RUN dotnet restore "Ministrate.Platform.Application/Ministrate.Platform.Application.csproj"
COPY . .
WORKDIR "/src/Ministrate.Platform.Application"
RUN dotnet build "Ministrate.Platform.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ministrate.Platform.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ministrate.Platform.Application.dll"]
