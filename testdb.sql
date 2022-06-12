-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Май 27 2022 г., 15:42
-- Версия сервера: 5.7.24
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `testdb`
--

-- --------------------------------------------------------

--
-- Структура таблицы `car`
--

CREATE TABLE `car` (
  `id` int(11) UNSIGNED NOT NULL,
  `name` varchar(30) NOT NULL,
  `year` int(4) NOT NULL,
  `number` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `car`
--

INSERT INTO `car` (`id`, `name`, `year`, `number`) VALUES
(1, 'Mazda RX-7', 2003, 'А100АА'),
(2, 'toyota camry', 1988, 'Е542ВГ'),
(3, 'lada granta', 1995, 'Л110Х'),
(4, 'Nissan almera', 2000, 'С876МК'),
(5, 'Nissan Skyline', 2008, 'В333ОС'),
(11, 'BMW X5', 1995, 'К122ОЛ');

-- --------------------------------------------------------

--
-- Структура таблицы `driver`
--

CREATE TABLE `driver` (
  `id` int(11) UNSIGNED NOT NULL,
  `name` varchar(30) NOT NULL,
  `surname` varchar(30) NOT NULL,
  `login` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `city` varchar(30) NOT NULL,
  `number` bigint(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `driver`
--

INSERT INTO `driver` (`id`, `name`, `surname`, `login`, `password`, `city`, `number`) VALUES
(1, 'Владислав', 'Грибабасов', 'GribVlad', 'SadTrendy', 'Saint-Peterburg', 89506813233),
(2, 'михаил', 'зубенко', 'ZubenkoMich', 'qwertyPas', 'perm', 89026754123),
(3, 'Николай', 'Молоков', 'MilkNiko', 'zxc_ghoul', 'moscow', 8999300128),
(4, 'Анатолий', 'Садилов', 'SadAntoha', 'bubbleQWE', 'perm', 89991237890),
(5, 'Милана', 'Малютина', 'MiloMalo', 'angryGirl', 'moscow', 89227654312),
(8, 'Сёмен', 'Петров', 'Mazzilla2002', '816squads', 'Детройт', 89523148611),
(10, 'Игорь', 'Садилов', 'outpath', 'qwertygg', 'Лысьва', 89504256189),
(11, 'Алексей', 'Жуков', 'juk202', 'vbbvbvbv', 'Москва', 89504678422);

-- --------------------------------------------------------

--
-- Структура таблицы `ordertaxi`
--

CREATE TABLE `ordertaxi` (
  `id_order` int(11) UNSIGNED NOT NULL,
  `id_client` int(11) UNSIGNED NOT NULL,
  `id_driver` int(11) UNSIGNED NOT NULL,
  `datetime` date DEFAULT NULL,
  `rate` int(1) DEFAULT '3'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `ordertaxi`
--

INSERT INTO `ordertaxi` (`id_order`, `id_client`, `id_driver`, `datetime`, `rate`) VALUES
(1, 1, 2, '2022-05-03', 3),
(2, 2, 3, '2022-05-26', 5),
(3, 3, 4, '2022-05-29', 4),
(4, 4, 1, '2022-05-29', 5),
(5, 5, 5, '2022-05-01', 2);

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) UNSIGNED NOT NULL,
  `name` varchar(30) NOT NULL,
  `surname` varchar(30) NOT NULL,
  `login` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `city` varchar(30) NOT NULL,
  `number` bigint(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `name`, `surname`, `login`, `password`, `city`, `number`) VALUES
(1, 'Настя', 'Мирная', 'Nastyshka', 'DoubleFunny', 'perm', 89501283902),
(2, 'Виктор', 'Шах', 'SkipePunk', 'qwerty123', 'moscow', 89992483621),
(3, 'Никита', 'Тихий', 'Nikson', 'kniggaBoy', 'perm', 89504613322),
(4, 'Анна', 'Риддимова', 'Based', 'RiddimAndBased', 'gornozavodsk', 89023457821),
(5, 'Игорь', 'Садилов', 'Pinpe', 'TwitchMan', 'Perm', 89922169575),
(14, 'Вася', 'Шишкин', 'PolkaBosss', 'outhpath', 'Екатеринбург', 89991337229),
(15, 'Никита', 'Пономарев', 'NikPon11', 'zxcghoul200', 'Брянск', 89023004001),
(16, 'Никита', 'Абрамов', 'NikAb', 'abramov2001', 'Пермь', 89224321100),
(17, 'Рахмед', 'Махмутов', 'gelirss', 'qwerty102', 'Пенза', 89504443378);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `car`
--
ALTER TABLE `car`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `driver`
--
ALTER TABLE `driver`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `ordertaxi`
--
ALTER TABLE `ordertaxi`
  ADD PRIMARY KEY (`id_order`),
  ADD UNIQUE KEY `userforeign` (`id_client`),
  ADD UNIQUE KEY `driverforeign` (`id_driver`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `car`
--
ALTER TABLE `car`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблицы `driver`
--
ALTER TABLE `driver`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблицы `ordertaxi`
--
ALTER TABLE `ordertaxi`
  MODIFY `id_order` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `car`
--
ALTER TABLE `car`
  ADD CONSTRAINT `car_ibfk_1` FOREIGN KEY (`id`) REFERENCES `driver` (`id`);

--
-- Ограничения внешнего ключа таблицы `ordertaxi`
--
ALTER TABLE `ordertaxi`
  ADD CONSTRAINT `ordertaxi_ibfk_1` FOREIGN KEY (`id_driver`) REFERENCES `driver` (`id`),
  ADD CONSTRAINT `ordertaxi_ibfk_2` FOREIGN KEY (`id_client`) REFERENCES `users` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
