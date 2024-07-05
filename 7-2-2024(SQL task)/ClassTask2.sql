


select * from Employees 
where  LEFT(HomePhone,4) = '(206' and City='Seattle'
order by BirthDate desc



select * from Customers 
where Country='germany' and CustomerID like 'B%' and ContactTitle='Sales Representative'
order by 1



select CompanyName,ContactTitle,Phone from Customers 
where City like '[C-M]%' and   left(phone,3) !='(1)' --Phone not like '(1)%'


select  TOP 25 percent * from Customers 
where CustomerID like '[AW]%'
