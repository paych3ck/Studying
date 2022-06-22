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
Выведите анализы с нечетным ID, у которых себестоимость больше 100.

Результат должен содержать столбцы:
ID анализа
Название анализа
Себестоимость
*/

SELECT an_id, an_name, an_cost
FROM Analysis
WHERE an_id % 2 = 1 AND an_cost > 100