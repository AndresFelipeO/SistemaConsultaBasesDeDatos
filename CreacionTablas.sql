create table tblEmpresa(
    empNit number(10,0) not null,
    empNombre varchar2(20) not null,
    empFechaCreacion date not null,
    constraint PK_Empresa primary key(empNit),
    constraint CKC_empNit check (empNit>0)
);
create table tblPortatil(
    portNumSerial number(6,0) not null,
    portMarca varchar2(20) not null,
    portCapacidadDiscD number(10,2) not null,
    portTipoDisDuro varchar2(10) not null,
    portCapacidadRam number(10,2) not null,
    portFechaEnsamblaje date not null,
    empNit number(10,0) not null,
    constraint PK_Portatiles primary key (portNumSerial),
    constraint CKC_portNumSerial check(portNumSerial>0),
    constraint CKC_portMarca check(portMarca in ('Lenovo','Dell','Asus')),
    constraint FK_empNit foreign key (empNit)references tblEmpresa(empNit)
);