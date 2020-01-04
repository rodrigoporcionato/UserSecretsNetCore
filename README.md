This project use net core user secrets enviroment.

for more information see https://docs.microsoft.com/pt-br/aspnet/core/security/app-secrets?view=aspnetcore-3.0&tabs=windows#environment-variables


# Main commands

Caminho do sistema de arquivos:
%APPDATA%\Microsoft\UserSecrets\<user_secrets_id>\secrets.json

A ferramenta Gerenciador de segredo inclui um comando init no SDK do .NET Core 3.0.100 ou posterior. Para usar os segredos do usuário, execute o seguinte comando no diretório do projeto:

dotnet user-secrets init


Definir um segredo
Defina um segredo de aplicativo que consiste em uma chave e seu valor. O segredo é associado ao valor de UserSecretsId do projeto. Por exemplo, execute o seguinte comando do diretório no qual o arquivo . csproj existe:

dotnet user-secrets set "Movies:ServiceApiKey" "12345"


list 
dotnet user-secrets list
