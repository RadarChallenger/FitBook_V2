FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["FitBook/FitBook.csproj", "FitBook/"]
RUN dotnet restore "FitBook/FitBook.csproj"
COPY . .
WORKDIR "/src/FitBook"
RUN dotnet build "FitBook.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FitBook.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FitBook.dll"]
