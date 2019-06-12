rmdir -r ./publish

dotnet publish -o ./publish

docker build -t oyesil/http-utility .
docker push oyesil/http-utility
