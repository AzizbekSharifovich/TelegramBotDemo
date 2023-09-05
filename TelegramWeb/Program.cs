using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using Telegram.Bot.Polling;
using TelegramBot.Application.Services.Handlers;
using TelegramBot.Core.Data;

var builder = WebApplication.CreateBuilder(args);

var token = builder.Configuration.GetValue("BotKey", "");

builder.Services.AddSingleton(new TelegramBotClient(token!));
builder.Services.AddHostedService<BackgroundService>();
builder.Services.AddSingleton<IUpdateHandler, BotUpdateHandler>();

var connectionString = builder.Configuration.GetConnectionString("TelegramDb");

builder.Services.AddDbContext<TelegramDbContext>(option =>
{
    option.UseNpgsql(connectionString);
});

var app = builder.Build();

app.Run();