FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS buildstage
WORKDIR /aspnet
COPY ["TextBox.MVCClient/TextBox.MVCClient.csproj", "TextBox.MVCClient/"]
RUN dotnet restore TextBox.MVCClient/TextBox.MVCClient.csproj
COPY . .
WORKDIR /aspnet/TextBox.MVCClient
RUN dotnet build TextBox.MVCClient.csproj

FROM buildstage AS publishstage
RUN dotnet publish TextBox.MVCClient.csproj --no-restore -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /deploy
COPY --from=publishstage /app .
CMD ["dotnet", "TextBox.MVCClient.dll"]