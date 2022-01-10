select * from Salesman

select name,comission
from salesman

select ord_date,salesman_id,ord_no,purch_amt
from orders

select name,city
from salesman 
where city='paris'

select customer_id,cust_name,city,grade,salesman_id
from customer
where grade=200

select ord_no,ord_date,purch_amt
from orders
where salesman_id=5001


select AVG(purch_amt)as' Average' from orders
select MAX(purch_amt) as 'Maximum purchase amount' from orders

select COUNT(Distinct salesman_id)as 'Unique salespeople'
from orders
--11.	write a SQL query to find the highest grade of the customers for each of the city. Return city, maximum grade.
select city,MAX(grade)as 'Max grade' from Customer
group by city

--12.	write a SQL query to find the highest purchase amount ordered by each customer. Return customer ID, maximum purchase amount
select customer_id,MAX(purch_amt)as 'Maximum purchase amount' from orders group by customer_id


select COUNT(*) as 'Count of customers' from Customer