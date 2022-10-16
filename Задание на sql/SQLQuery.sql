select product.name, category.name from product 
left join product_category_junction on product_category_junction.product_id = product.product_id
left join category on product_category_junction.category_id = category.category_id
