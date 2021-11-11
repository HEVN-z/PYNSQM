//discord bot
const Discord = require('discord.js');
const client = new Discord.Client();
const config = require('./config.json');
const fs = require('fs');
const prefix = config.prefix;
const token = config.token;
const db = require('quick.db');
const ms = require('parse-ms');
const moment = require('moment');
const ms = require('parse-ms');
const { MessageEmbed } = require('discord.js');
const { Client, Util } = require('discord.js');
const YouTube = require('simple-youtube-api');
const ytdl = require('ytdl-core');
const client = new Discord.Client();
const youtube = new YouTube(process.env.YT_API);
const queue = new Map();

const prefix = "!";

client.on('ready', () => {
  console.log(`Logged in as ${client.user.tag}!`);
});

client.on('message', msg => {
  if (msg.content === 'ping') {
    msg.reply('pong');
  }
});
