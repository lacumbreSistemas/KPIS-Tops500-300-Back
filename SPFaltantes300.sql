select i.Description,  
	   i.ItemLookupCode,
	   kpi.ItemId, 
	   d.ID,
	   f.Fecha,
	   d.Name, 
	   p.Pasillo, 
	   ps.PasilloId, 
	   f.disponible
	   from kpi.Cbr_Items_Top500 kpi
inner join Item i on kpi.ItemId = i.ID
inner join Department d on i.DepartmentID = d.ID
left join kpi.Cbr_Items_Pasillos ps on kpi.ItemId = ps.ItemId and ps.Tienda=1
left join kpi.Cbr_Item_Top500_Pasillo p on ps.PasilloId = p.id
left join kpi.Cbr_Faltantes_Top500 f on kpi.ItemId = f.ItemId
							 and f.Top300=1 
where kpi.Top300 = 1 and kpi.StoreId =1 and kpi.Top500=0
order by i.Description

select * from kpi.Cbr_Item_Top500_Pasillo
select * from kpi.Cbr_Items_Pasillos