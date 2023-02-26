FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Ministrate.Platform.BlazorServer/Ministrate.Platform.BlazorServer.csproj", "Ministrate.Platform.BlazorServer/"]
RUN dotnet restore "Ministrate.Platform.BlazorServer/Ministrate.Platform.BlazorServer.csproj"
COPY . .
WORKDIR "/src/Ministrate.Platform.BlazorServer"
RUN dotnet build "Ministrate.Platform.BlazorServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ministrate.Platform.BlazorServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ministrate.Platform.BlazorServer.dll"]
