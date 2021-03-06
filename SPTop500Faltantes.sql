

--alter procedure KPI.CBR_GetTop500Pendientes_SP 
--as
/*create procedure KPI.CBR_GetTop500Pendientes_sp
 
SP para obtener los productos TOP 500 Faltantes
Hecho por Juan Sanchez
*/

create procedure [KPI].[CBR_GetTop500Faltante_SP] 
as

set dateformat ymd
declare @now datetime= GetDate(),
@from Datetime ,
@to Datetime

declare @day varchar(10) = convert(varchar(10), DATEPART(DAY,  @now)) 
declare @month varchar(10) = convert(varchar(10), DATEPART(MONTH,  @now)) 
declare @year varchar(10) = convert(varchar(10), DATEPART(YEAR,  @now)) 

if(DATEPART(HOUR,  @now) <= 12 ) 
begin

	set @from = @year  +'-' + @month+ '-' +  @day  + ' 00:00:00'
	set @to = @year  +'-' + @month+ '-' +  @day  + ' 12:00:00'
end
else 
begin
	set @from = @year  +'-' + @month+ '-' +  @day  + ' 12:00:00'
	set @to = @year  +'-' + @month+ '-' +  @day  + ' 23:00:00'
end



select kpiF.id, 
	   i.Description, 
	   i.ItemLookupCode, 
	   kpiF.ItemId, 
	   kpiF.disponible, 
	   i.DepartmentID,
	   p.PasilloId,
	   ps.Pasillo,
	   kpiF.Fecha
from KPI.Cbr_Faltantes_Top500 kpiF
inner join item i on kpiF.ItemId = i.ID
inner join Department d on i.DepartmentID = d.ID
left join KPI.CBR_Items_Pasillos p on kpiF.ItemId = p.ItemId
left join KPI.Cbr_Item_Top500_Pasillo ps on p.PasilloId = ps.id
where kpiF.Fecha between @from and @to

--END
	


--select * from kpi.Cbr_Faltantes_Top500 where