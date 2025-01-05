# Test command:

# docker container rm --force teste123098; docker buildx build --progress plain -t teste123098 -f Dockerfile ../.. && docker run --name teste123098 --interactive -p 127.1.2.3:80:80 teste123098

########################################
# STAGE 1: BUILD COMPILE IMAGE
########################################

# Download the SDK image from microsoft
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build-image

WORKDIR /app

# Install the C build environment
RUN apk add --no-cache build-base clang tree zlib-dev 

################################
# COMPILATION
# The two step compilation bellow is to optimize average compile time.
# If the project file is not changed, docker will use cached layers and skip the restore phase

# COMPILATION PHASE 1: RESTORE
COPY ./Luc.Lwx.Examples/Luc.Lwx.Example.Api/Luc.Lwx.Example.Api.csproj Luc.Lwx.Examples/Luc.Lwx.Example.Api/Luc.Lwx.Example.Api.csproj
COPY ./Luc.Lwx/Luc.Lwx/Luc.Lwx.csproj Luc.Lwx/Luc.Lwx/Luc.Lwx.csproj
COPY ./Luc.Lwx/Luc.Lwx.Generator/Luc.Lwx.Generator.csproj Luc.Lwx/Luc.Lwx.Generator/Luc.Lwx.Generator.csproj

RUN dotnet restore \
  Luc.Lwx.Examples/Luc.Lwx.Example.Api/Luc.Lwx.Example.Api.csproj \
  --runtime linux-musl-x64

# COMPILATION PHASE 2: COMPILE AND PUBLISH
COPY ./Luc.Lwx/Luc.Lwx/ /app/Luc.Lwx/Luc.Lwx/
COPY ./Luc.Lwx/Luc.Lwx.Generator/ /app/Luc.Lwx/Luc.Lwx.Generator/
COPY ./Luc.Lwx.Examples/Luc.Lwx.Example.Api/ /app/Luc.Lwx.Examples/Luc.Lwx.Example.Api/

RUN \
  tree /app; \
  dotnet publish \
  Luc.Lwx.Examples/Luc.Lwx.Example.Api/Luc.Lwx.Example.Api.csproj \
  --runtime linux-musl-x64 \
  --self-contained \
  --no-restore \
  --configuration Release \  
  -o /app/publish; \
  tree /app/publish

########################################
# STAGE 2: BUILD RUNTIME IMAGE
########################################

# Download the RUNTIME image from microsoft
FROM mcr.microsoft.com/dotnet/runtime-deps:8.0-alpine AS runtime-image

# Configure locale and timezone
RUN \
  apk add --no-cache --update musl musl-locales musl-utils tzdata && \
  echo "America/Sao_Paulo" >  /etc/timezone && \
  ln -sf /usr/share/zoneinfo/America/Sao_Paulo /etc/localtime && \
  export TZ="America/Sao_Paulo" && \
  export LANG="pt_BR.UTF-8" && \
  export LC_ALL="pt_BR.UTF-8" && \
  export LANGUAGE="pt_BR.UTF-8" 

# install the trusted certificates
COPY Luc.Lwx.Examples/Deployment/ca-certificates/*.crt /usr/local/share/ca-certificates/
RUN cat /usr/local/share/ca-certificates/*.crt >> /etc/ssl/certs/ca-certificates.crt

# Set runtime environment
ENV DOTNET_URLS="http://*:80"
ENV DOTNET_SYSTEM_NET_DISABLEIPV6=1
ENV DOTNET_ENVIRONMENT="Production"

# Expose the port
EXPOSE 80

# Copy files
COPY --from=build-image /app/publish .

#USER nobody

ENTRYPOINT ["./Luc.Lwx.Example.Api"]