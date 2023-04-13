# Clonando e iniciando a PokeAPI.

### Após clonar este repositório, em seu diretório, altere o metódo **app.UseCors** em seu **Program.cs** para aceitar o consumo de seu front-end.

```
app.UseCors(builder =>
                builder.WithOrigins("http://localhost:3000")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials()
                );
```

Agora basta rodar o Clone-PokeAPI e a Pokedex para consumir :)
