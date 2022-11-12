using DevIO.UI.Site.Data;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;

// Builder principal é dele de onde tudo deriva
var builder = WebApplication.CreateBuilder(args);

// *** Configurando serviços no container ***

// Adicionando suporte a mudança de convenção da rota das areas.
builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.AreaViewLocationFormats.Clear();
    options.AreaViewLocationFormats.Add("/Modulos/{2}/Views/{1}/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Modulos/{2}/Views/Shared/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
});
//var x = builder.Configuration.GetConnectionString("NovoDbContext");

builder.Services.AddDbContext<MeuDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MeuDbContext")));

// Adicionando suporte ao MVC
builder.Services.AddControllersWithViews();



var app = builder.Build();

// *** Configurando o resquest dos serviços no pipeline ***

if (app.Environment.IsDevelopment())
{
    
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Adicionando suporte a rota
app.UseRouting();

// Rota padrão
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

// Rota de área genérica (não necessário no caso da demo)
//app.MapControllerRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}");

// Rota de áreas especializadas
app.MapAreaControllerRoute("AreaProdutos", "Produtos", "Produtos/{controller=Cadastro}/{action=Index}/{id?}");
app.MapAreaControllerRoute("AreaVendas", "Vendas", "Vendas/{controller=Pedidos}/{action=Index}/{id?}");

app.Run();