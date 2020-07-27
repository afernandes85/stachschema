FROM mcr.microsoft.com/dotnet/core/sdk:2.2

LABEL maintainer="analytics.api.support@factset.com"

RUN apt-get update && \
    apt-get -y install unzip

ARG PROTOC_ZIP=protoc-3.12.3-linux-x86_64.zip
RUN curl -OL https://github.com/protocolbuffers/protobuf/releases/download/v3.12.3/$PROTOC_ZIP
RUN unzip -o $PROTOC_ZIP -d /usr/local bin/protoc
RUN unzip -o $PROTOC_ZIP -d /usr/local 'include/*'
RUN rm -f $PROTOC_ZIP

COPY dotnet/CI/entrypoint.sh /

ENTRYPOINT ["bash", "/entrypoint.sh"]
