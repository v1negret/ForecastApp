## Решение задач SQL

Вывести менеджеров у которых имеется номер телефона:
SELECT * FROM Managers WHERE Phone IS NOT NULL

Вывести кол-во продаж за 20 июня 2021:
SELECT SUM(Count) FROM Sells WHERE Date = "2021-06-21"

Вывести среднюю сумму продажи с товаром 'Фанера': 
SELECT 
	AVG(Sum)
FROM 
	Sells as s
INNER JOIN 
	Products as p
ON 
	s.ID_Prod = p.ID
WHERE 
	p.Name = "Фанера"

Вывести фамилии менеджеров и общую сумму продаж для каждого с товаром 'ОСБ': 
SELECT
	m.Fio,
	SUM(s.Sum)
FROM
	Sells as s
INNER JOIN
	Managers as m
On
	s.ID_Manag = m.ID
INNER JOIN
	Products as p
On
	s.ID_Prod = p.ID
WHERE
	p.Name = "ОСБ"
GROUP BY
	m.Fio

Вывести менеджера и товар, который продали 22 августа 2021: 
SELECT
	m.Fio,
	p.Name
FROM 
	Sells as s
INNER JOIN
	Managers as m
ON 
	s.ID_Manag = m.ID
INNER JOIN
	Products as p
ON
	s.ID_Prod = p.ID
WHERE
	s.Date = "2021-08-22"
	
Вывести все товары, у которых в названии имеется 'Фанера' и цена не ниже 1750: 
SELECT
	*
FROM
	Products
WHERE
	Name LIKE "%Фанера%" AND Cost >= 1750

Вывести историю продаж товаров, группируя по месяцу продажи и наименованию товара: 
SELECT
	p.Name,
	s.Count,
	s.Sum,
	MONTH(s.Date) as [Month]
FROM
	Sells as s
JOIN LEFT
	Products as p
ORDER BY
	Month,
	p.Name

Вывести количество повторяющихся значений и сами значения из таблицы 'Товары', где количество повторений больше 1.: 
SELECT
	ID,
	Name,
	Cost,
	Volume,
	Count(*)
FROM
	Products
GROUP BY
	Name
HAVING
	Count(*) > 1
	
	