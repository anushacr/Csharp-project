select ord_date,salesman_id,count(*)
from orders
group by ord_date,salesman_id

select count(*) 'salespeople'
from customer
group by city

select count(*) 'no.of.orders'
from orders
where ord_date='2012-08-17'

select salesman_id,Max(purch_amt) 'max purchase'
from orders
where salesman_id between 5003 and 5008
group by salesman_id