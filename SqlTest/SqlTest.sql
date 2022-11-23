select p."name", c."name"
from Products p
left join ProductCategories productCat
	on p.Id = productCat.prodId
left join Categories c
	on productCat.catId = c.Id;