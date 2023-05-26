insert into Product (Name) values
                               ('ProductA'),
                               ('ProductB'),
                               ('ProductC'),
                               ('ProductD'),
                               ('ProductE'),
                               ('ProductF')
insert into Category(Name) values ('Category1'), ('Category2'), ('Category3')

insert into ProductCategory(ProductId, CategoryId)
select p.Id, c.Id
from Product p
         cross join Category c

insert into ProductCategory(ProductId, CategoryId)
    (select top 3 Id, null from Product)


select p.Name ProductName, c.Name CategoryName
from Product p
         join ProductCategory pc on p.Id = pc.ProductId
         left join Category c on c.Id = pc.CategoryId