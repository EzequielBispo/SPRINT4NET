# SPRINT4NET

A API faz requisições de análise de URL ao VirusTotal, possui um classificador de URL's baseado em Machine Learning que classifica a criticidade do site informado.

## Swagger Endpoints

```url
http://localhost:5000/swagger
```

## Configuração

1. **Instalar Dependencias**:
 ```bash
dotnet restore
 ```
2. **Configuração da string de conexão**:
   ```json
   {
   "ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=SPRINT4NET;User Id=SEU_USUARIO;Password=SUA_SENHA;"
   }
   ```
3. **Debug do projeto**:
   ```bash
   dotnet run --project SPRINT4NET.API
   ```
