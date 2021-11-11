FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Maui.ConsoleFrontend/Maui.ConsoleFrontend.csproj", "Maui.ConsoleFrontend/"]
RUN dotnet restore "Maui.ConsoleFrontend/Maui.ConsoleFrontend.csproj"
COPY . .
WORKDIR "/src/Maui.ConsoleFrontend"
RUN dotnet build "Maui.ConsoleFrontend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Maui.ConsoleFrontend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Maui.ConsoleFrontend.dll"]
