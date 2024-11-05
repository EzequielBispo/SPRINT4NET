# SPRINT4NET

A API faz requisições de análise de URL ao VirusTotal, possui um classificador de URL's baseado em Machine Learning que classifica a criticidade do site informado.

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
  },
  "VirusTotal": {
    "ApiKey": "SUA_CHAVE_VIRUSTOTAL"
  }
}
   ```
