select suppliername,description, itemlookupcode, [Time] ,sum(te.Quantity), sum(te.Quantity* te.Price) from [transaction] t
inner join [TransactionEntry] te 
on t.TransactionNumber = te.TransactionNumber 
and t.StoreID = te.StoreID
inner join item i on i.id = te.ItemID
inner join Supplier s on s.id = i.SupplierID 
where (s.Code like 'E%'  or (s.id = 1440 and s.id = 187 and s.id = 11047))
and [time] between '01/01/2020' and '01/01/2021'
group by suppliername,description,[Time], itemlookupcode

select Item.SupplierID from Item where Description = 'NACHITO TomateCherry 0.5 LB'