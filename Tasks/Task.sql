Use Northwind

-- Çalışanların yapmış olduğu sipariş adedi (orders)  
SELECT EmployeeID,
       COUNT(*) AS [Toplam Satış Adedi]
  FROM Orders
 GROUP BY EmployeeID

-- Employees tablosundan; FirstName alanına göre, isimleri ASC olarak sıraladıktan sonra, 
-- sonuç kümesinin ilk beş kaydını ülkelerine göre gruplayınız.
SELECT Country,
       COUNT(*) AS [Toplam Personel Sayısı]
  FROM (   SELECT TOP 5 FirstName,
                  Country
             FROM Employees
            ORDER BY FirstName) AS Personeller -- derived table
 GROUP BY Country

-- Ürün bedeli 35$'dan az olan ürünlerin kategorilerine göre gruplanması

Select c.CategoryName,
       COUNT(*) as ProductCount
  From Products p
 Inner Join Categories c
    on p.CategoryID = c.CategoryID
 Where p.UnitPrice < 35
 Group by c.CategoryName;

-- Baş harfi A-K aralığında olan ve stok miktarı 5 ile 50 arasında olan ürünleri kategorilerine göre gruplayınız.

Select c.CategoryName,
       COUNT(*) as ProductCount
  from Products p
 Inner Join Categories c
    on p.CategoryID = c.CategoryID
 Where p.UnitsInStock > 5
   And p.UnitsInStock < 50
   And P.ProductName LIKE '[A-K]%'
 Group by c.CategoryName

-- Her bir siparişteki toplam ürün sayısını bulunuz.

Select o.OrderID,
       SUM(od.Quantity) as TotalProductCount
  From Orders o
 Inner JOIN [Order Details] od
    on o.OrderID = od.OrderID
 Group by o.OrderID;

-- Her bir siparişin tutarına göre listelenmesi

Select o.OrderID,
       Sum(p.UnitPrice * od.Quantity) as TotalOrderAmount
  From Orders o
 Inner Join [Order Details] od
    on o.OrderID    = od.OrderID
 Inner Join Products p
    on od.ProductID = p.ProductID
 Group by o.OrderID
 Order by TotalOrderAmount desc;

-- Toplam tutarı 2500 ile 3500 arasında olan siparişlerin gruplanması

Select OrderID,
       Sum(Quantity * UnitPrice) as 'Toplam tutarı'
  From [Order Details]
 Group by OrderID
Having Sum(Quantity * UnitPrice) Between 2500 and 3500

-- Her bir siparişteki toplam ürün sayısı 200'den az olanlar

Select OrderID,
       Sum(Quantity) as 'Toplam ürün sayısı'
  From [Order Details]
 Group by OrderID
Having Sum(Quantity) < 200

