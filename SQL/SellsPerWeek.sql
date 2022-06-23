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
Для всех анализов, которые продавались 5 февраля 2020 и всю следующую неделю, вывести:
an_name
an_cost
ord_datetime

Результат отсортируйте по возрастанию столбцов:
ord_datetime
an_cost
*/

SELECT an_name, an_cost, ord_datetime
FROM Analysis
JOIN Orders
ON ord_an = an_id
WHERE DATE(ord_datetime) BETWEEN '2020-02-05' AND '2020-02-12'
ORDER BY ord_datetime, an_cost