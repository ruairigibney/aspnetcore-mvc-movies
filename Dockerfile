FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY aspnetcore-mvc-movies.csproj ./
RUN dotnet restore /aspnetcore-mvc-movies.csproj
COPY . .
WORKDIR /src/
RUN dotnet build aspnetcore-mvc-movies.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish aspnetcore-mvc-movies.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "aspnetcore-mvc-movies.dll"]
