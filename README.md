# Задание C#

В библиотеке есть основной интерфейс `IShape`, от которого наследуются интерфейсы всех остальных геометрических фигур.  
В рамках задачи созданы интерфейсы `ICircle` и `ITriangle`.  
Для рассчитывания площади создан класс расширений `ShapeExtensions`, реализующий общий метод расчета площади любого `IShape` и отдельные методы расчета площади объектов типа `ICircle` и `ITriangle`.  
Для определения прямоугольности треугольника создан класс расширений `TriangleExtensions`, реализующий метод определения прямоугольности объекта типа `ITriangle`.

Эта архитектура позволяет просто добавлять новые фигуры внутри библиотеки, но не позволяет пользователю использовать её для расчета площади самописных фигур. При попытке рассчитать площадь некоего пользовательского класса, реализующего `IShape`, выдается исключение `NotImplementedException`.

Для добавления новой фигуры достаточно создать новый интерфейс, к примеру `IRectangle`, реализовать в `ShapeExtensions` метод для расчета площади `IRectangle` и добавить в метод расчета площади `IRectangle` новую ветку в switch для случая, когда переданный `IShape shape` есть экземпляр `IRectangle`.

## Юнит-тесты

Сделано несколько юнит-тестов для проверки площади круга, треугольника, а также отдельный юнит-тест для проверки работы метода определния площади с неопределенными `IShape`, в частности с неким пользовательским классом `ISquare`, не предусмотренным по умолчанию в библиотеке (выдается исключение `NotImplementedException`).  
Есть юнит-тесты для проверки прямоугольности треугольников.

# Задание SQL

```SQL
SELECT P.Name as 'Product', C.Name as 'Category' FROM Products P
LEFT JOIN ProductsCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON C.Id = PC.CategoryId
```

<details>
<summary>Полный запрос</summary>

```SQL
/* DDL */
CREATE TABLE Products
(
    Id INT NOT NULL PRIMARY KEY IDENTITY, 
    Name NCHAR(50) NOT NULL
)
CREATE TABLE Categories
(
    Id INT NOT NULL PRIMARY KEY IDENTITY, 
    Name NCHAR(50) NOT NULL
)
CREATE TABLE ProductsCategories
(
    ProductId INT NOT NULL, 
    CategoryId INT NOT NULL
)

/* Filling */
INSERT INTO Products (Name) VALUES ('Apple'), ('Banana'), ('Strawberry'), ('Potato')
INSERT INTO Categories (Name) VALUES ('Sweet'), ('Green'), ('Fruit')

INSERT INTO ProductsCategories VALUES (1, 2), (1, 3)
INSERT INTO ProductsCategories VALUES (2, 1), (2, 3)
INSERT INTO ProductsCategories VALUES (3, 1)

/* Required query answer */
SELECT P.Name as 'Product', C.Name as 'Category' FROM Products P
LEFT JOIN ProductsCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON C.Id = PC.CategoryId
```
</details>