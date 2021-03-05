# API CalculoJuros

**Calcula Juros**

Responde pelo path relativo "/calculajuros"

Ela faz um cálculo em memória, de juros compostos, conforme abaixo: Valor Final = Valor Inicial * (1 + juros) ^ Tempo

Valor inicial é um decimal recebido como parâmetro.

Valor do Juros deve ser consultado na API TaxaJuros.

Tempo é um inteiro, que representa meses, também recebido como par}âmetro.

^ representa a operação de potência.

Resultado final deve ser truncado (sem arredondamento) em duas casas decimais.

* Exemplo: /calculajuros?valorinicial=100&meses=5 Resultado esperado: 105,10

<br>

**Show me the code**

Este responde pelo path relativo /showmethecode.
Deverá retornar a url de onde encontra-se o fonte no github.

<br>

## Arquitetura

Optei em estruturar o projeto em Camadas, cada qual com sua responsabilidade.
Temos um projeto API, aonde teremos os endpoints que serão disponibilizados para serem consumidos.
Outra camada adicionada foi a Aplicação. Esta seria responsável pelos casos de uso do produto e assim podemos ter várias outras camadas.

Foi adicionado também as camadas de Testes. Cada projeto com seu projeto de testes.
O projeto Aplicacao.Testes tem por objetivo efetuar os Testes de Unidade para os componentes menores.
O projeto Api.Testes aplicará os Testes de Integração garantindo que o método está efetuando a chamada do método correto da aplicação.
E por fim, o projeto de testes Api.TestesIntegracao que tem por objetivo garantir que o EndPoint do API esteja funcionando de forma correta para demais serviços que estarão consumindo a mesma.

### Techs utilizadas
 - [**ASP.NET Core**](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-5.0)
 - [**Swagger**](https://www.nuget.org/packages/Swashbuckle/)
 - [**AutoMoqCore**](https://www.nuget.org/packages/AutoMoqCore/)
 - [**XUnit**](https://www.nuget.org/packages/xunit/)
 - [**TestHost**](https://www.nuget.org/packages/Microsoft.AspNetCore.TestHost)



### Rodando a aplicação

Rodando local

```
> git clone https://github.com/fabiostefani/CalculoJuros.git
> cd CalculoJuros
> dotnet run --project .\ApiCalculoJuros\ApiCalculoJuros.csproj
```

Rodando com [**Docker**](https://www.docker.com/)
```
> git clone git clone https://github.com/fabiostefani/CalculoJuros.git
> cd CalculoJuros
> docker compose up
```
A imagem docker para esta API está publicada [Docker HUB](https://hub.docker.com/r/fabiostefani/apicalculojuros).
Para iniciar essa imagem
```
> docker run -p 8002:80 fabiostefani/apicalculojuros:latest
```

Quando estiver rodando a API de Calculo de Juros, ao acionar o método de /CalculaJuros, ele vai irá buscar o valor da Taxa de Juros na API de Taxa de Juros que está rodando no Azure.

### Link
ApiTaxaJuros [http://localhost:8001/](http://localhost:8001)

ApiCalculoJuros [http://localhost:8002/](http://localhost:8002)

