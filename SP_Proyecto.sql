--SP para Guardar ventas
alter procedure SP_InsertarVenta
@id_producto int,
@FechaVenta datetime,
@FechaInserta datetime,
@cliente varchar(50),
@cantidad int,
@vendedor varchar(50)
as
begin
	insert into Ventas(id_producto,Fecha_venta,fecha_inserta,Usuario_venta,Cantidad,usuario_inserta)
	values (@id_producto,GETDATE(), GETDATE(),@cliente,@cantidad,@vendedor)
	end
go
delete from Productos where id_categoria=1

--Vista para ver detalles de ventas 
alter view V_ventas
as 
	select
	id_venta,
	p.Nombre_producto,
	Fecha_venta,
	v.usuario_inserta
	from Ventas v
	inner join Productos p on v.id_producto=p.id_producto

--SP para crear usuario
create procedure SP_InsertarUsuario
@usuario varchar(50),
@contraseña varchar (20),
@usuarioinserta varchar (50),
@FechaInserta datetime,
@Nombre_user varchar(50)
as
begin
	insert into Usuarios (Usuario, Contraseña, usuario_inserta, fecha_inserta, Nombre_usuario)
	values(@usuario,@contraseña,@usuarioinserta,GETDATE(),@Nombre_user)
	end
go

--SP para editar usuario
alter procedure SP_EditarUsuario
@idusuario int,
@usuario varchar(50),
@contraseña varchar (20),
@usuarioinserta varchar (50),
@Nombre_user varchar(50),
@usuario_act varchar (50)
as 
begin
	begin try
		begin tran
			update Usuarios
				set Usuario=@usuario,
				Contraseña=@contraseña,
				usuario_inserta=@usuarioinserta,
				Nombre_usuario=@Nombre_user,
				usuario_actualiza=@Nombre_user,
				fecha_actualiza=GETDATE()
			where id_usuario=@idusuario
		commit
		end try

		begin catch
			if @@TRANCOUNT>0
				rollback

			select ERROR_MESSAGE() Error

		end catch
end 
go

--SP para eliminar usuario
create procedure SP_EliminarUser
@id_usuario int
as
	begin
		delete from Usuarios where id_usuario=@id_usuario
	end
go