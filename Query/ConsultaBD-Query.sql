CREATE TABLE user_movements (
    user_id INT NOT NULL,
    movement_type NVARCHAR(50),
    amount DECIMAL(18, 3) NOT NULL,
    date DATE NOT NULL
);

CREATE TABLE user_data (
    user_id INT PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    last_name NVARCHAR(100) NOT NULL
);

INSERT INTO user_data (user_id, name, last_name)
VALUES 
(1024, 'Francisca', 'Gonzales'),
(99410, 'Pedro', 'Valenzuela'),
(23481, 'Jaime', 'López');
(12894, 'Omar', 'Leon'),
(4020, 'Bobby', 'Charlton');
INSERT INTO user_movements (user_id, movement_type, amount, date)
VALUES 
(1024, 'subscription', 100.000, '2021-12-01'),
(99410, 'withdrawal', 580.000, '2021-12-03'),
(23481, 'withdrawal', 120.000, '2021-12-12'),
(1024, 'withdrawal', 190.000, '2021-12-12'),
(12894, 'subscription', 80.000, '2021-11-09'),
(4020, 'withdrawal', 1280.000, '2021-09-01')

--Query para cantidad de veces que se hizo un retiro y un aporrte en diciembre de 2021
SELECT 
    movement_type,
    COUNT(*) AS times
FROM user_movements
WHERE MONTH(date) = 12 AND YEAR(date) = 2021
GROUP BY movement_type;
--Query para ver total de retiro y aporte en diciembre de 2021
SELECT 
    movement_type,
    SUM(amount) AS total_amount
FROM user_movements
WHERE MONTH(date) = 12 AND YEAR(date) = 2021
GROUP BY movement_type;

--Cantidad y Monto promedio de aportes y rescates por fecha.
SELECT 
    date,
    movement_type,
    COUNT(*) AS quantity,
    AVG(amount) AS average_amount
FROM user_movements
GROUP BY date, movement_type
ORDER BY date, movement_type;

--Usuario con Mas aportes
SELECT TOP 1 
    d.name,
    d.last_name,
    SUM(m.amount) AS total_aportes
FROM user_movements AS m
JOIN user_data AS d
ON m.user_id = d.user_id
WHERE m.movement_type = 'subscription'
GROUP BY d.user_id, d.name, d.last_name
ORDER BY total_aportes DESC;