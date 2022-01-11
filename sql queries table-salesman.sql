create table salesman(salesman_id numeric(5) primary key,name varchar(30),city varchar(15),comission decimal(5,2))

insert into salesman values(5001 ,'james hoog','new york',0.15)
insert into salesman values(5002 ,'Nail Knite','Paris',0.13)
insert into salesman values(5005 ,'Pit Alex','London',0.11)
insert into salesman values(5006 ,'Mc Lyon','Paris',0.14)
insert into salesman values(5007 ,'Paul Adam','Rome',0.13)
insert into salesman values(5003 ,'Lauson Hen','San Jose',0.12)
select * from salesman

create table customer(customer_id numeric(5) primary key,cust_name varchar(30),city varchar(15),grade numeric(3),salesman_id numeric(5)) 

insert into customer values(3002 ,'nick rimando','new york',100,5001)
insert into customer values(3007 ,'Brad davis','new york',200,5001)
insert into customer values(3005 ,'graham zusi','california',200,5002)
insert into customer values(3008 ,'julian green','london',300,5002)
insert into customer values(3004 ,'fabian johnson ','paris',300,5002)
insert into customer values(3009 ,'geoff cameron','berlin',100,5006)
insert into customer values(3003 ,'jozy altidor','moscow',200,5007)
--insert into customer values(3001 ,'brad guzan','london', ,5005)

select * from customer

create table orders
(
ord_no numeric(5) primary key,purch_amt decimal(12,5),ord_date date,customer_id numeric(5) FOREIGN KEY REFERENCES customer(customer_id),salesman_id numeric(5) FOREIGN KEY REFERENCES salesman(salesman_id))
--drop table orders
insert into orders values(70001,150.5,'2012-10-05',3005,5002)
insert into orders values(70009,270.65,'2012-09-10',3001,5005)
insert into orders values(70002,65.26,'2012-10-05',3002,5001)
insert into orders values(70004,110.5,'2012-08-17',3009,5003)
insert into orders values(70007,948.5,'2012-09-10',3005,5002)
insert into orders values(70005,2400.6,'2012-07-27',3007,5001)
insert into orders values(70008,5760,'2012-09-10',3002,5001)
insert into orders values(70010,1983.43,'2012-10-10',3004,5006)
insert into orders values(70003,2480.4,'2012-10-10',3009,5003)
insert into orders values(70012,250.45,'2012-06-27',3008,5002)
insert into orders values(70011,75.29,'2012-08-17',3003,5007)
insert into orders values(70013,3045.6,'2012-04-25',3002,5001)
select * from orders