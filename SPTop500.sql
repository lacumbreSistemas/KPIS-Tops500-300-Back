
--alter procedure KPI.CBR_GetTop500Pendientes_SP 
--as
/*create procedure KPI.CBR_GetTop500Pendientes_sp
 
SP para obtener los productos TOP 500
Hecho por Juan Sanchez
*/
alter procedure KPI.CBR_GetTop500Pendientes_SP 
as
set dateformat dmy
declare @now datetime= GetDate(),
@from Datetime ,
@to Datetime

declare @day varchar(10) = convert(varchar(10), DATEPART(DAY,  @now)) 
declare @month varchar(10) = convert(varchar(10), DATEPART(MONTH,  @now)) 
declare @year varchar(10) = convert(varchar(10), DATEPART(YEAR,  @now)) 

if(DATEPART(HOUR,  @now) <=12 ) 
begin

	set @from = @year  +'-' + @month+ '-' +  @day  + ' 00:00:00'
	set @to = @year  +'-' + @month+ '-' +  @day  + ' 12:00:00'
end
else 
Begin
	set @from = @year  +'-' + @month+ '-' +  @day  + ' 12:00:00'
	set @to = @year  +'-' + @month+ '-' +  @day  + ' 23:00:00'
end

select i.Description, kpi.ItemId, i.ItemLookupCode, f.disponible, d.Name, d.ID 
 from KPI.Cbr_Items_Top500 kpi
inner join item i on kpi.ItemId = i.Id
inner join Department d on i.DepartmentID = d.ID
left join KPI.Cbr_Faltantes_Top500 f
		on kpi.ItemId = f.ItemId and f.Fecha between @from and @to
where f.ItemId is null
--END
	


--select * from Cbr_Faltantes_Top500 where