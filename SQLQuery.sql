select name_product, name_category as category_product
from product inner join category
on product.id_category = category.id_category
