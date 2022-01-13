--ASCII
select ASCII(cust_name)as 'first ascii character' from Customer

--Concat
SELECT city + cust_name as 'Concat' from customer

--char
SELECT CHAR(97) AS CodeToCharacter

--charindex
SELECT CHARINDEX('sh','Anusha') AS MatchPosition --starts from 1

--datalength
select DATALENGTH('SQL') as datalength

select cust_name ,DATALENGTH(cust_name) as datalength from Customer

--difference(misc)
select DIFFERENCE('Racecar','car') as difference
SELECT DIFFERENCE('Juice', 'Banana');

--left
select LEFT('sql server',6) as leftstring
select LEFT(cust_name ,5)as leftstring from Customer

--length
SELECT LEN('2017-08') as datelength

--lower
select LOWER(cust_name) as lower from Customer

----upper
select upper(cust_name) as upper from Customer

--ltrim
SELECT LTRIM('     SQL Tutorial') AS LeftTrimmedString;

--rtrim
SELECT RTRIM('SQL Tutorial     ') AS RightTrimmedString;

--nchar
SELECT NCHAR(65) AS NumberCodeToUnicode;
--patindex

SELECT PATINDEX('%.%com%', 'cranushacrp@gmail.com')
--quotename


SELECT QUOTENAME('abcdef')
--replace
select REPLACE('push','p','sh')

--replicate
select REPLICATE(cust_name ,4) from Customer
--reverse

select REVERSE(cust_name) from Customer 

--right
SELECT RIGHT('SQL Tutorial', 3) AS ExtractString;

--soundex
SELECT SOUNDEX('Juice'), SOUNDEX('Jucy');

--space
SELECT SPACE(10)
--str -returns number as a string

SELECT STR(185.47356, 6, 3)

--stuff
--Delete 3 characters from a string, starting in position 1, and then insert "HTML" in position 1:

SELECT STUFF('SQL Tutorial', 1, 3, 'HTML')

--substring -starts from 1
select SUBSTRING('SQL Tutorial', 1, 3) AS Substring

--unicode
--Return an integer value (the Unicode value), for the first character of the input expression:

SELECT UNICODE('Atlanta')