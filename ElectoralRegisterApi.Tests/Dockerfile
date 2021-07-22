FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ENV DynamoDb_LocalMode='true'

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./ElectoralRegisterApi.sln ./
COPY ./ElectoralRegisterApi/ElectoralRegisterApi.csproj ./ElectoralRegisterApi/
COPY ./ElectoralRegisterApi.Tests/ElectoralRegisterApi.Tests.csproj ./ElectoralRegisterApi.Tests/

RUN dotnet restore ./ElectoralRegisterApi/ElectoralRegisterApi.csproj
RUN dotnet restore ./ElectoralRegisterApi.Tests/ElectoralRegisterApi.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out ElectoralRegisterApi.Tests/ElectoralRegisterApi.Tests.csproj

CMD dotnet test
