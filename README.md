# TelegramComputerAlerter
An application to control your PC from new logins, sending info about all to your personal Telegram account, info like actual date, a webcam photo, etc...


![alt text](https://i.gyazo.com/ccc692f377cf50e977545393d09c1eca.png)

## Using

You will need a Telegram bot, consult any @BotFather guide to get an API code.

In order to enter your Telegram User ID you should talk to your bot and then visit this url with your api code:

https://api.telegram.org/botAPIKEY/getUpdates

Example URL: https://api.telegram.org/botXXXXXXXXXXXXXXXX/getUpdates

You will see something like this: "message":{"message_id":X,"from":{"id":YOURID"} ... That's your Telegram ID.

# Project requeriments

Nugget Packages. 
EMGU.CV.4.1.1.3497
Telegram.Bot.15.0.0
