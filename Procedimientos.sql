--Procedimiento para ingresar empresa
create or replace procedure prcIngresarEmpresa(v_nit tblempresa.empnit%type,v_nomEmp tblempresa.empnombre%type,v_fecha tblempresa.empfechacreacion%type)
Is
Begin
    Insert into tblEmpresa(empNit,empNombre,empFechaCreacion) values(v_nit,v_nomEmp,v_fecha);
End prcIngresarEmpresa;
--Procedimiento para ingresar portatil  
create or replace procedure prcIngresarPortatil(v_serial tblportatil.portnumserial%type,v_marca tblportatil.portmarca%type,v_capaDisco tblportatil.portcapacidaddiscd%type,v_tipoDisc tblportatil.porttipodisduro%type,v_capRam tblportatil.portcapacidadram%type, v_fecha tblportatil.portfechaensamblaje%type,v_nit tblportatil.empnit%type)
Is
Begin
    insert into tblPortatil(portNumSerial,portMarca,portCapacidadDiscD,portTipoDisDuro,PORTCAPACIDADRAM,portFechaEnsamblaje,EMPNIT) values(v_serial,v_marca,v_capaDisco, v_tipoDisc,v_capRam,v_fecha,v_nit);
End prcIngresarPortatil;
--Consultas 

create or replace procedure prcConsultarPortatil(v_nit tblempresa.empnit%type,cr_CantidadPortatiles out SYS_REFCURSOR)
Is
Begin
    open cr_CantidadPortatiles for
      select portNumSerial as Serial, portCapacidadDiscD as Capacidad_Disco, portCapacidadRam as Capacidad_Ram, portMarca as Marca
      from tblPortatil
      where empNit=v_nit;
End;

create or replace procedure prcConsultarEmpresas(cr_CantidadEmpresas out SYS_REFCURSOR)
Is
Begin
    open cr_CantidadEmpresas for
      select empNit as Nit, empNombre as nombre,EMPFECHACREACION as fecha
      from tblEmpresa;
End;

create or replace procedure prcConsultarPort(cr_CantidadPortatiles out SYS_REFCURSOR)
Is
Begin
    open cr_CantidadPortatiles for
      select portNumSerial as Serial, portCapacidadDiscD as Capacidad_Disco,PORTTIPODISDURO as tipo_Disco ,portCapacidadRam as Capacidad_Ram, portMarca as Marca,PORTFECHAENSAMBLAJE as fecha,EMPNIT as nit_empresa
      from tblPortatil;
End;