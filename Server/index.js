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
    // room pointer
    this.room = io.of(this.name + this.id);
    setupRoom(this);
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
    this.nickname = this.name + this.id;
    this.money = 0;
    this.properties = [];
}

var rooms = [];
var games = [];
var players = [];

var roomID = 0; // current room index
var playerID = 0;

app.get('/', function(req, res){
    res.sendFile(__dirname + '/index.html');
});

io.on('connection', function(socket){
    socket.on('register user', function(name)
    {
        var np = new Player(name);
        socket.name = np.name;
        socket.nickname = np.nickname;
        players[np.nickname] = np; // add player to list, with nickname as index
    })
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
    // room = string (room name + room id)
    socket.on('join room', function(room){
        socket.join(room); // join socket.io room
        socket.broadcast.to(room).emit('new player', players[socket.nickname])

    });


});

http.listen(port, function(){
    console.log('listening on *:' + port);
});


function setupRoom(room)
{
    room.room.on('connection', function(socket)
    {
        // MESSAGES
        socket.on('group message', function(fromPlayer, msg)
        {
            socket.broadcast.to(room.id).emit('group message', msg);
        });
        socket.on('private message', function(fromPlayer, toPlayer, msg)
        {
            socket.broadcast.to(toPlayer).emit('private message', fromPlayer, msg); //
        });

        // GENERIC UPDATES
        socket.on('user update', function(userData)
        {
            socket.broadcast.to(room.id).emit('user update', userData);
        });

        // TRADING
        socket.on('trade query', function(fromPlayer, toPlayer, data)
        {
            // data = {msg, offeredCardsID[], offeredPropertyID[]}
            socket.broadcast.to(toPlayer).emit('trade query', fromPlayer, data); //
        });
        socket.on('trade dialog', function(fromPlayer, toPlayer, data)
        {
            // data = {msg, offeredCardsID[], offeredPropertyID[]}
            socket.broadcast.to(toPlayer).emit('trade dialog', fromPlayer, data); //
        });
        socket.on('trade confirm', function(fromPlayer, toPlayer, data)
        {
            // data = {msg, offeredCardsID[], offeredPropertyID[]}
            socket.broadcast.to(room.id).emit('trade confirm', fromPlayer, data); //
        });
        socket.on('buying property', function(player, data)
        {
            // data = {amount, propertyID}
            socket.broadcast.to(room.id).emit('buying property', player, data); //
        });

        // MOVEMENT
        socket.on('dice roll', function(player, roll)
        {
            socket.broadcast.to(room.id).emit('dice roll', player, roll); //
        });
        socket.on('player move', function(player, propertyID)
        {
            socket.broadcast.to(room.id).emit('player move', player, propertyID); //
        });

        // CARDS
        socket.on('player receive card', function(player, cardID)
        {
            socket.broadcast.to(room.id).emit('player receive card', player, cardID); //
        });
        socket.on('player owns card', function(player, cardID)
        {
            socket.broadcast.to(room.id).emit('player owns card', player, cardID); //
        });
        socket.on('player uses card', function(player, cardID)
        {
            socket.broadcast.to(room.id).emit('player uses card', player, cardID); //
        });

        // PAYMENT
        socket.on('pay me', function(fromPlayer, toPlayer, data)
        {
            // data = {amount, propertyID}
            socket.broadcast.to(toPlayer).emit('pay me', fromPlayer, data); //
        });

    });
}
