/*
Есть таблица анализов Analysis:

+-------+---------+---------+----------+----------+
| an_id | an_name | an_cost | an_price | an_group |
+-------+---------+---------+----------+----------+
an_id - ID анализа
an_name - Название анализа
an_cost - Себестоимость анализа
an_price - Розничная цена анализа
an_group - Группа анализов
Есть таблица групп анализов Groups:

+-------+---------+---------+
| gr_id | gr_name | gr_temp |
+-------+---------+---------+
gr_id - ID группы
gr_name - Название группы
gr_temp - Температурный режим хранения
Есть таблица заказов Orders:

+--------+--------------+---------+
| ord_id | ord_datetime | ord_an  |
+--------+--------------+---------+
ord_id - ID заказа
ord_datetime - Дата и время заказа
ord_an - ID анализа

Задание
Вывести все номера заказов, которые были совершены в апреле 2020 года. Ответ должен содержать:
ID заказа
дату-время заказа
Результат отсортируйте по возрастанию даты и времени.
*/

SELECT ord_id, ord_datetime
FROM Orders
WHERE DATE(ord_datetime) BETWEEN '2020-04-01' AND '2020-04-30'
ORDER BY DATE(ord_datetime)