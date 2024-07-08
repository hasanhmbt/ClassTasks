




-- Çalışanların yapmış olduğu sipariş adedi (orders)  
SELECT e.employeeid,
       Concat(firstname, '-', lastname) AS [Employee Name],
       Count(O.orderid)                 AS Orders
FROM   employees E
       JOIN orders O
         ON E.employeeid = O.employeeid
GROUP  BY E.employeeid,
          firstname,
          lastname 
  

-- Employees tablosundan; FirstName alanına göre, isimleri ASC olarak sıraladıktan sonra, sonuç kümesinin ilk beş kaydını ülkelerine göre gruplayınız.
SELECT country,
       Count(*) AS [Total Employee Count]
FROM   (SELECT TOP 5 firstname,
                     country
        FROM   employees
        ORDER  BY firstname) AS Employees
GROUP  BY country 


-- Ürün bedeli 35$'dan az olan ürünlerin kategorilerine göre gruplanması
SELECT CategoryID, COUNT(ProductID) Products   from Products 
where UnitPrice<35
group by CategoryID 


-- Baş harfi A-K aralığında olan ve stok miktarı 5 ile 50 arasında olan ürünleri kategorilerine göre gruplayınız.
SELECT P.categoryid,
       categoryname,
       productname,
       unitsinstock
FROM   products P
       JOIN categories C
         ON P.categoryid = C.categoryid
WHERE  productname LIKE '[A-K]%'
       AND unitsinstock BETWEEN 5 AND 50
GROUP  BY P.categoryid,
          productname,
          unitsinstock,
          categoryname
ORDER  BY 2 



-- Her bir siparişteki toplam ürün sayısını bulunuz.
SELECT orderid,
       Sum(quantity) [Total Quantity]
FROM   [order details]
GROUP  BY orderid 


-- Her bir siparişin tutarına göre listelenmesi
SELECT orderid,
       unitprice
FROM   [order details]
ORDER  BY unitprice 


-- Toplam tutarı 2500 ile 3500 arasında olan siparişlerin gruplanması
SELECT orderid,
       Sum(unitprice * quantity) AS [Total Price]
FROM   [order details]
GROUP  BY orderid
HAVING Sum(unitprice * quantity) BETWEEN 2500 AND 3500 


-- Her bir siparişteki toplam ürün sayısı 200'den az olanlar
SELECT orderid,
       Sum(quantity) AS [Total Count]
FROM   [order details]
GROUP  BY orderid
HAVING Sum(quantity) < 200 



