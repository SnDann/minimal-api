using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (MininalApi.DTos.LoginDTO loginDTO) => {
    // login logic here
    if(loginDTO.EMail == "adm@teste.com" && loginDTO.Senha == "123456")
        return Results.Ok("Login realizado com sucesso");
    else
        return Results.Unauthorized();
});

app.Run();

public class LoginDTO 
{
    public string EMail { get; set; } = default!;

    public string Senha {get; set;} = default!;
}