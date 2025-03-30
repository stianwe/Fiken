#!/bin/bash
rm -rf specs
mkdir -p specs
cd specs

wget https://api.fiken.no/api/v2/docs/swagger.yaml

cd ..
openapi-generator generate --generator-name csharp -i specs/swagger.yaml --artifact-id Fiken --package-name Fiken --additional-properties useDateTimeOffset=true --skip-validate-spec

rm -rf
specs