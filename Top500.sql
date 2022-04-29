
create table Cbr_Items_Top500 (

ItemId primary key int  not null,

)

create table Cbr_Item_Top500_Pasillo (
id int IDENTITY(1,1) primary key not null,
ItemId int,
Pasilo varchar(50)

)
select * from kpi.Cbr_Item_Top500_Pasillo
	select 
	KP.id,
	i.Description,
	i.ItemLookupCode,
	kpi.ItemId, 
	KP.Pasillo, 
	KP.Guardado 
	from KPI.Cbr_Items_Top500 kpi
	inner join item i on kpi.ItemId = i.Id
	inner join kpi.Cbr_Item_Top500_Pasillo KP on kpi.ItemId = KP.ItemId


   select 
	KP.id,
	i.Description,
	i.ItemLookupCode,
	kpi.ItemId, KP.Pasillo, 
	KP.Guardado 
	from KPI.Cbr_Items_Top500 kpi
	inner join item i on kpi.ItemId = i.Id
	inner join kpi.Cbr_Item_Top500_Pasillo KP on kpi.ItemId = KP.ItemId

	

create table Cbr_Faltantes_Top500 (
id int IDENTITY(1,1) primary key not null,
ItemId int  not null,
disponible bit ,
Fecha datetime,
userID int,


)

create table Cbr_UsersKPI(
userID int IDENTITY(1,1) primary key not null,
NombreCompleto varchar(50),
Password varchar(50),
Usuario varchar(50),
Rol int,
StoreId int
)

create table Cbr_Items_Pasillos(
ItemId int primary key not null,
PasilloId int

)

alter schema KPI transfer Cbr_UsersKPI

select i.Description, ItemId from KPI.Cbr_Items_Top500 kpi
inner join item i on kpi.ItemId = i.Id

select * from KPI.Cbr_Items_Top500

select * from KPI.Cbr_Items_Top500

alter table KPI.Cbr_Items_Top500  drop column  PasilloID

select * from KPI.Cbr_Faltantes_Top500
delete from KPI.Cbr_Items_Top500
delete from KPI.Cbr_Faltantes_Top500

DBCC CHECKIDENT ([KPI.Cbr_Faltantes_Top500], RESEED,0)

drop table KPI.Cbr_Faltantes_Top500
select * from [KPI].[Cbr_Items_Pasillos]

select i.Description, 
d.Name, c.Name, 
i.ItemLookupCode,
kf.Fecha, 
kf.Disponible Disponibilidad,
kpP.Pasillo
from KPI.Cbr_Faltantes_Top500 kf
inner join item i on kf.ItemID = i.ID
inner join Department d on i.DepartmentID = d.ID
inner join Category c on i.CategoryID = c.ID
inner join KPI.Cbr_Items_Pasillos kpip on kf.ItemId = kpip.ItemId
inner join KPI.Cbr_Item_Top500_Pasillo kpP on kpip.PasilloId = kpP.id
order by Description

select * from KPI.Cbr_Item_Top500_Pasillo


select * from KPI.Cbr_UsersKPI

select * from Item
select * from Department
select * from Category

select i.Description, kpi.ItemId, kp.Guardado, kp.Pasillo from KPI.Cbr_Items_Top500 kpi
inner join item i on kpi.ItemId = i.Id
inner join KPI.Cbr_Item_Top500_Pasillo kp on kpi.ItemId = kpi.ItemId
group by i.Description, kpi.ItemId, kp.Guardado, kp.Pasillo 



alter proc KPI.Crb_GetTop500Pendientes_sp
(
 declare @now Datetime = getdate(),
@from Datetime ,
@to Datetime 

)
as 
begin

if(DATEPART(HOUR,  @now) <=12 ) 

	set @from = DATEPART(DAY,  @now) + '/' +DATEPART(MONTH,  @now) + '/' +DATEPART(YEAR,  @now) + '00:00:00'
	set @to = DATEPART(DAY,  @now) + '/' +DATEPART(MONTH,  @now) + '/' +DATEPART(YEAR,  @now) + '12:00:00'
end
else 
Begin
	set @from = DATEPART(DAY,  @now) + '/' +DATEPART(MONTH,  @now) + '/' +DATEPART(YEAR,  @now) + '12:00:00'
	set @to = DATEPART(DAY,  @now) + '/' +DATEPART(MONTH,  @now) + '/' +DATEPART(YEAR,  @now) + '23:00:00'

select i.Description, kpi.ItemId, d.Name 
 from KPI.Cbr_Items_Top500 kpi
inner join item i on kpi.ItemId = i.Id
inner join Department d on i.DepartmentID = d.ID
left join KPI.Cbr_Faltantes_Top500 f
		on kpi.ItemId = f.ItemId and f.Fecha between @from and @to
where f.ItemId is null

END

select * from Item where ItemLookupCode= '5000267024011'




select kpi.ItemId, i.Description, p.PasilloId, i.ItemLookupCode from KPI.Cbr_Items_Top500 kpi
inner join Item i on kpi.ItemId = i.ID
inner join KPI.Cbr_Items_Pasillos p on kpi.ItemId = p.ItemId

select * from KPI.Cbr_Items_Top500

select * from KPI.Cbr_Item_Top500_Pasillo
select * from KPI.CBR_Items_Pasillos

select i.Description, p.Pasillo from KPI.CBR_Items_Pasillos kp
inner join Item i on kp.ItemId = i.ID
inner join KPI.Cbr_Item_Top500_Pasillo p on kp.PasilloId = p.id

select * from KPI.Cbr_Items_Top500