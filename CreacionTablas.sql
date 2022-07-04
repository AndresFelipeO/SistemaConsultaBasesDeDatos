create table Empresa(
    empNit number(6,0) not null,
    empNombre varchar2(20) not null,
    empFechaCreacion date not null,
    constraint PK_Empresa primary key(empNit),
    constraint CKC_empNit check (empNit>0)
);
create table Portatil(
    portNumSerial number(6,0) not null,
    portMarca varchar2(20) not null,
    portCapacidadDiscD integer not null,
    portTipoDisDuro varchar2(10) not null,
    portFechaEnsamblaje date not null,
    constraint PK_Portatiles primary key (portNumSerial),
    constraint CKC_portNumSerial check(portNumSerial>0),
    constraint CKC_portMarca check(portMarca in ('Lenovo','Dell','Asus'))
);
create table Vende(
    empNit number(6,0) not null,
    portNumSerial number(6,0) not null,
    constraint PK_empNitportNumSerial primary key(empNit,portNumSerial),
    constraint FK_empNit foreign key (empNit)references Empresa(empNit),
    constraint FK_portNumSerial foreign key(portNumSerial) references Portatil(portNumSerial)
);