var app = require('express')();
var http = require('http').Server(app);
var io = require('socket.io')(http);
var port = process.env.PORT || 3000;

function Room(name)
{
    //var room = {id: 0, name:"", players:0, private: false, playing: false};
    this.id = ++roomID;
    this.name = name;
    this.players = 0;
    this.private = false;
    this.playing = false;
}
function Game(id)
{
    //var game = {id: 0, currentPlayer: 0, players: null};
    this.id = id;
    this.currentPlayers = 0;
    this.players = [];
}
function Player(name)
{
    //var player = {id: 0, avatar: 0, name: "", money: 0};
    this.id = ++playerID;
    this.avatar = 0;
    this.name = name;
    this.name = "";
    this.money = 0;
}

var rooms = [];
var games = [];

var roomID = 0; // current room index
var playerID = 0;

app.get('/', function(req, res){
  res.sendFile(__dirname + '/index.html');
});

io.on('connection', function(socket){
  socket.on('chat message', function(msg){
    io.emit('chat message', msg);
  });

  socket.on('request rooms', function(){
      socket.emit('current rooms', rooms);
  });

  socket.on('create room', function(name){
      var room = new Room(name);
      rooms.append(room); // add room to list
      socket.emit('created room', roomID);
  });

  // request = {roomID, playerID}
  socket.on('join room', function(request){

  });
});

http.listen(port, function(){
  console.log('listening on *:' + port);
});
