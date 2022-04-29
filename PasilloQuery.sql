select * from KPI.Cbr_UsersKPI

select * from KPI.Cbr_Faltantes_Top500

select * from KPI.Cbr_Items_Pasillos



select * from Item where Item.ID = '2082'

select * from KPI.Cbr_Items_Pasillos
update Kpi.Cbr_Faltantes_Top500
set StoreId = 1
--4317 Col 3
--3414 Col 1

select i.Description, kpi.StoreId, kpi.id, kpi.ItemId from kpi.Cbr_Items_Top500 kpi 
inner join Item i on kpi.ItemId = i.ID
where i.Description='RES Tajo Molido X Libra'


select kpi.ItemId ItemId, 
i.Description , 
i.ItemLookupCode, 
kpi.StoreId IdConteo, 
p.PasilloId  PasilloId
from KPI.Cbr_Items_Top500 kpi
inner join Item i on kpi.ItemId = i.ID
left join  KPI.Cbr_Items_Pasillos p on kpi.ItemId=p.ItemId and kpi.StoreId = p.Tienda
where  kpi.StoreId =3 and kpi.Top500=1


select kpi.ItemId ItemId, 
i.Description , 
i.ItemLookupCode, 
kpi.StoreId IdConteo, 
p.PasilloId  PasilloId
from KPI.Cbr_Items_Top500 kpi
inner join Item i on kpi.ItemId = i.ID
inner join  KPI.Cbr_Items_Pasillos p on kpi.ItemId=p.ItemId and kpi.StoreId = p.Tienda
where  kpi.StoreId =1 and kpi.Top500=1

select * from KPI.Cbr_Items_Pasillos kps
where kps.ItemId = 105705

select * from KPI.Cbr_Item_Top500_Pasillo

select ID from Item where Item.Description = 'ACTII PromoPalomitas6Un+BVP'




select * from KPI.Cbr_UsersKPI

select * from Department

select * from kpi.Cbr_Items_Top500 kpi
inner join Item i on kpi.ItemId = i.ID
where i.ItemLookupCode = '7401004550141'

delete from KPI.Cbr_Items_Top500  where id=4317 

select * from KPI.Cbr_Faltantes_Top500

delete from KPI.Cbr_Faltantes_Top500  where id=24776 


select * from KPI.Cbr_Items_Top500 kpi 
where kpi.StoreId=1 and kpi.Top500=1 
order by kpi.id 
 
 select * from KPI.Cbr_Item_Top500_Pasillo

 select * from KPI.Cbr_Items_Pasillos

 select * from KPI.Cbr_Items_Pasillos kpi
 order by kpi.ItemId
 p where p.ItemId=13045

 select i.Description from Item i where i.ID=13039

select kpi.ItemId, i.Description, i.ItemLookupCode, p.PasilloId, kpi.id from KPI.Cbr_Items_Top500 kpi
inner join Item i on kpi.ItemId = i.ID
inner join KPI.Cbr_Items_Pasillos p on kpi.ItemId=p.ItemId
where  kpi.StoreId=1 and kpi.Top500=1 and p.PasilloId=1

select * from KPI.Cbr_Faltantes_Top500

select * from kpi.CBR_Items_Pasillos