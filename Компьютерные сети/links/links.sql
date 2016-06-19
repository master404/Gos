-- phpMyAdmin SQL Dump
-- version 4.0.10.6
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1:3306
-- Время создания: Июн 18 2016 г., 20:43
-- Версия сервера: 5.5.41-log
-- Версия PHP: 5.5.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `links`
--

-- --------------------------------------------------------

--
-- Структура таблицы `main`
--

CREATE TABLE IF NOT EXISTS `main` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `old_link` varchar(200) NOT NULL,
  `new_link` varchar(200) NOT NULL,
  `postfix` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

--
-- Дамп данных таблицы `main`
--

INSERT INTO `main` (`id`, `old_link`, `new_link`, `postfix`) VALUES
(1, 'https://vk.com/roman_palesika', 'http://links/mueas', 'mueas'),
(2, 'https://mail.yandex.ru/?win=72&clid=1969041&uid=291650508&login=palesika-roman#inbox', 'http://links/nfovt', 'nfovt'),
(5, 'https://mail.google.com/mail/u/0/#inbox', 'http://links/iugsm', 'iugsm'),
(6, 'https://mail.google.com/mail/u/0/#inbox', 'http://links/zlgyh', 'zlgyh'),
(7, 'https://vk.com/roman_palesika', 'http://links/pfxps', 'pfxps'),
(8, 'https://vk.com/roman_palesika', 'http://links/cbgec', 'cbgec'),
(9, 'https://vk.com/roman_palesika', 'http://links/tcauo', 'tcauo'),
(11, 'https://www.weblancer.net/', 'http://links/uhtzb', 'uhtzb');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
