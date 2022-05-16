create database recetary;
use recetary;

------tablas  receta --------
create table receta(
cod_receta int primary key,
fuente_receta varchar(60),
ubicacion_receta varchar(100),
lista_ingredientes varchar(100),
utensilios varchar(100),
tiempo_ejecucion time,
comentario_receta varchar(100),
)

--------agregar informacion tabla receta ------
create proc agregar_receta
@cod_receta int,
@fuente_receta varchar(60),
@ubicacion_receta varchar(100),
@lista_ingredientes varchar(100),
@utensilios varchar(100),
@tiempo_ejecucion time,
@comentario_receta varchar(100)

as
insert into receta (cod_receta,fuente_receta,ubicacion_receta,lista_ingredientes,utensilios,tiempo_ejecucion,comentario_receta)values(@cod_receta,@fuente_receta,@ubicacion_receta,@lista_ingredientes,@utensilios,@tiempo_ejecucion,@comentario_receta)

-------modificar informacion  tabla receta -----

create proc modificar_receta
@cod_receta int,
@fuente_receta varchar(60),
@ubicacion_receta varchar(100),
@lista_ingredientes varchar(100),
@utensilios varchar(100),
@tiempo_ejecucion time,
@comentario_receta varchar(100)
as 
update receta set fuente_receta=@fuente_receta,ubicacion_receta=@ubicacion_receta,lista_ingredientes=@lista_ingredientes,utensilios=@utensilios,tiempo_ejecucion=@tiempo_ejecucion,comentario_receta=@comentario_receta where cod_receta=@cod_receta

select * from receta 

-------para eliminar registro tabla receta-------------------

create proc eliminar_receta
@cod_receta int
as 
delete from receta where cod_receta=@cod_receta

-----consultar tabla receta------------------

create proc consulta_receta
@cod_receta int
as
select * from receta where cod_receta=@cod_receta



------tablas  plato  --------

create table plato(
cod_plato int primary key,
cod_receta int,
tipo_plato varchar(50),
nombre_plato varchar(100),
ingrediente_principal varchar(100),
calorias_plato decimal,
cantidad_ing_plato decimal,
unidad_medida_plato varchar(50),
precio_plato decimal,
comentario_adicional_plato varchar(100),
constraint fk_plato foreign key(cod_receta)references receta (cod_receta))

--------agregar informacion tabla plato------

create proc agregar_plato
@cod_plato int,
@cod_receta int,
@tipo_plato varchar(50),
@nombre_plato varchar(100),
@ingrediente_principal varchar(100),
@calorias_plato decimal,
@cantidad_ing_plato decimal,
@unidad_medida_plato varchar(50),
@precio_plato decimal,
@comentario_adicional_plato varchar(100)
 as
 insert into plato (cod_plato,cod_receta,tipo_plato,nombre_plato,ingrediente_principal,calorias_plato,cantidad_ing_plato,unidad_medida_plato,precio_plato,comentario_adicional_plato)values (@cod_plato,@cod_receta,@tipo_plato,@nombre_plato,@ingrediente_principal,@calorias_plato,@cantidad_ing_plato,@unidad_medida_plato,@precio_plato,@comentario_adicional_plato)


 ------modificar informacion tabla plato----
 create proc modificar_plato
 @cod_plato int,
@cod_receta int,
@tipo_plato varchar(50),
@nombre_plato varchar(100),
@ingrediente_principal varchar(100),
@calorias_plato decimal,
@cantidad_ing_plato decimal,
@unidad_medida_plato varchar(50),
@precio_plato decimal,
@comentario_adicional_plato varchar(100)
as
update plato set  cod_receta=@cod_receta,tipo_plato=@tipo_plato,nombre_plato=@nombre_plato,ingrediente_principal=@ingrediente_principal,calorias_plato=@calorias_plato,cantidad_ing_plato=@cantidad_ing_plato,unidad_medida_plato=@unidad_medida_plato,precio_plato=@precio_plato,comentario_adicional_plato=@comentario_adicional_plato where cod_plato=@cod_plato


------eliminar resgistro tabla plata--------------

create proc eliminar_plato 
 @cod_plato int
 as
 delete from plato  where cod_plato=@cod_plato


-------consultar tabla plato ------

 create proc consultar_plato
 @cod_plato int
 as
 select *from plato where cod_plato= @cod_plato


 ------tabla menu --------

create table menu(
cod_menu int  primary key,
cod_receta int,
identificador_plato varchar(50),
precio_menu decimal,
comentario_menu varchar(100),
constraint fk_menu foreign key(cod_receta) references receta(cod_receta))


--------agregar informacion tabla menu ------

create proc agregar_menu
@cod_menu int,
@cod_receta int,
@identificador_plato varchar(50),
@precio_menu decimal,
@comentario_menu varchar(100)
as 
insert into menu (cod_menu,cod_receta,identificador_plato,precio_menu,comentario_menu)values(@cod_menu,@cod_receta,@identificador_plato,@precio_menu,@comentario_menu)


-------modificar tabla menu-------

create proc modificar_menu
@cod_menu int,
@cod_receta int,
@identificador_plato varchar(50),
@precio_menu decimal,
@comentario_menu varchar(100)

as
update menu set cod_receta=@cod_receta,identificador_plato=@identificador_plato,precio_menu=@precio_menu,comentario_menu=@comentario_menu where cod_menu=@cod_menu

----------eliminar registro de la tabla menu-----

create proc eliminar_menu
@cod_menu nvarchar(10)
as
delete from menu  where cod_menu=@cod_menu

-------------consultar tabla menu ----------

create proc consultar_menu
@cod_menu int 
 as 
 select from menu where cod_menu=@cod_menu


