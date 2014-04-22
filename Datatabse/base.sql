
create database chatsignalr;

use chatsignalr;

create table tbMensagem(
	idMensagem int(11) primary key auto_increment,
	remetente varchar(50) not null,
	mensagem varchar(500) not null,
	dtHora datetime not null
);


delimiter $$
create procedure spInserirMensagem(
	_remetente varchar(50),
	_mensagem varchar(500),
	_dtHora datetime
)
begin

	insert into tbMensagem (remetente, mensagem, dtHora) values (_remetente, _mensagem, _dtHora);

end;
