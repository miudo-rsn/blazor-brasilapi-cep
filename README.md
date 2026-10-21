# BlazorWasmBrasilApiCep

Consulta de CEP feita com Blazor WebAssembly consumindo a [BrasilAPI](https://brasilapi.com.br/docs#tag/CEP).

## Como executar

```
dotnet run
```

Depois acesse o endereço exibido no terminal (por exemplo http://localhost:5062) e digite um CEP, como 30130000.

## Estrutura

- `Models/Cep.cs` e `Models/Ibge.cs`: classes que representam a resposta da API
- `Program.cs`: registro do HttpClient apontando para a BrasilAPI
- `Pages/Home.razor`: tela de consulta
