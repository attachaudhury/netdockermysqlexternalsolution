FROM mcr.microsoft.com/dotnet/sdk:latest as build-image
WORKDIR /home/app
COPY ./*.sln ./
COPY ./*/*.csproj ./
RUN for file in $(ls *.csproj); do mkdir -p ./${file%.*}/ && mv $file ./${file%.*}/; done
RUN dotnet restore
COPY . .
RUN dotnet publish ./netdockermysqlexternalproject/netdockermysqlexternalproject.csproj -o /publish/
FROM mcr.microsoft.com/dotnet/aspnet:latest
WORKDIR /publish
COPY --from=build-image /publish .
ENV ASPNETCORE_URLS="http://0.0.0.0:5000"
ENTRYPOINT ["dotnet", "netdockermysqlexternalproject.dll"]