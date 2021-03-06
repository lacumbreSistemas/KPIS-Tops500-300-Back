USE [DATOS]
GO
/****** Object:  StoredProcedure [KPI].[CBR_GetTop500Pendientes_SP]    Script Date: 13/5/2021 08:55:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--alter procedure KPI.CBR_GetTop500Pendientes_SP 
--as
/*create procedure KPI.CBR_GetTop500Pendientes_sp
 
SP para obtener los productos TOP 500
Hecho por Ricardo Zelaya
*/
alter procedure [KPI].[CBR_GetTop500Pendientes_SP] 
as
SET DATEFORMAT 'YMD'
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
begin
	set @from = @year  +'-' + @month+ '-' +  @day  + ' 12:00:00'
	set @to = @year  +'-' + @month+ '-' +  @day  + ' 23:00:00'
end

select i.Description, 
	   kpi.ItemId, 
	   i.ItemLookupCode, 
	   f.disponible, 
	   d.[Name], 
	   d.ID,
	   p.PasilloId,
	   ps.Pasillo
 from KPI.Cbr_Items_Top500 kpi
inner join item i (nolock)  on kpi.ItemId = i.Id
inner join Department d (nolock)  on i.DepartmentID = d.ID
left join KPI.CBR_Items_Pasillos (nolock)  p on kpi.ItemId = p.ItemId
left join KPI.Cbr_Item_Top500_Pasillo (nolock)  ps on p.PasilloId = ps.id
left join KPI.Cbr_Faltantes_Top500 f
		on kpi.ItemId = f.ItemId and f.Fecha between @from and @to
where f.ItemId is null and kpi.Top500=1
--END
	

