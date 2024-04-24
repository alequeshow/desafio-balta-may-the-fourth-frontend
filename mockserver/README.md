# Mockserver

Para executar o projeto 100% local sem dependencias externas, utilizamos [mockserver](https://github.com/mock-server/mockserver) para simular as requisições externas

## Pre-requisitos

- Docker instalado(versão linux - não foi testado com docker para Windows containers)
- Docker Compose instalado
- Habilidade para correr comandos (basicamente copiar+colar)
- Postman

## Executar mockserver

```
docker-compose up -d
```

## Configurar expectations

Para dar o comportamento desejado ao mockserver, é preciso criar as expectations que fará match com o request esperado pela aplicação:

### Importar Postman collection

A collection `mockserver\DesafioBalta - May The 4th.postman_collection.json` contem os endpoints configurados até o memomento. 

Basta executar a requisição de PUT dela e esperar pelo status code `201 - Created`

Os requests já estão configurados para resolver o problema de CORS (veja o http-header de response).

É possivel também executar o commando via curl. Basta ver os comandos em `Curls.txt`