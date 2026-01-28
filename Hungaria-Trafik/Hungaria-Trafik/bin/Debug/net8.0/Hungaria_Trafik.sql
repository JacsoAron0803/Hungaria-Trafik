-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2026. Jan 26. 13:16
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `hungaria-trafik`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `products`
--

CREATE TABLE `products` (
  `Id` int(200) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Category` varchar(30) NOT NULL,
  `Price` int(255) NOT NULL,
  `Stock` int(255) NOT NULL,
  `age_limit` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `products`
--

INSERT INTO `products` (`Id`, `Name`, `Category`, `Price`, `Stock`, `age_limit`) VALUES
(1, 'Marlboro Red', 'Cigaretta', 2390, 25, 18),
(2, 'Marlboro Gold', 'Cigaretta', 2390, 18, 18),
(3, 'Camel Blue', 'Cigaretta', 2290, 0, 18),
(4, 'Camel Yellow', 'Cigaretta', 2290, 14, 18),
(5, 'Winston Classic', 'Cigaretta', 2190, 12, 18),
(6, 'Lucky Strike', 'Cigaretta', 2290, 6, 18),
(7, 'Pall Mall Blue', 'Cigaretta', 2090, 20, 18),
(8, 'Pall Mall Red', 'Cigaretta', 2090, 0, 18),
(9, 'Davidoff Gold', 'Cigaretta', 2490, 9, 18),
(10, 'Chesterfield Blue', 'Cigaretta', 1990, 11, 18),
(11, 'Heets Amber', 'Hevített dohány', 1990, 30, 18),
(12, 'Heets Yellow', 'Hevített dohány', 1990, 2, 18),
(13, 'Heets Turquoise', 'Hevített dohány', 1990, 0, 18),
(14, 'Heets Sienna', 'Hevített dohány', 1990, 8, 18),
(15, 'Terea Regular', 'Hevített dohány', 2090, 16, 18),
(16, 'Terea Black', 'Hevített dohány', 2090, 5, 18),
(17, 'Terea Menthol', 'Hevített dohány', 2090, 0, 18),
(18, 'Fiit Regular', 'Hevített dohány', 1890, 22, 18),
(19, 'Fiit Dark Roast', 'Hevített dohány', 1890, 3, 18),
(20, 'Fiit Menthol', 'Hevített dohány', 1890, 0, 18),
(21, 'Iqos Iluma', 'Készülék', 34990, 4, 18),
(22, 'Iqos Iluma One', 'Készülék', 29990, 2, 18),
(23, 'Iqos Iluma Prime', 'Készülék', 39990, 1, 18),
(24, 'Glo Hyper', 'Készülék', 29990, 1, 18),
(25, 'Glo Pro Slim', 'Készülék', 27990, 0, 18),
(26, 'Vuse Go', 'E-cigaretta', 3490, 15, 18),
(27, 'Elf Bar 600', 'E-cigaretta', 3990, 0, 18),
(28, 'Lost Mary BM600', 'E-cigaretta', 4290, 7, 18),
(29, 'Vaporesso Xros', 'E-cigaretta', 18990, 3, 18),
(30, 'Smok Nord', 'E-cigaretta', 15990, 2, 18),
(31, 'Zippo fekete', 'Kiegészítő', 8990, 7, 0),
(32, 'Zippo króm', 'Kiegészítő', 9990, 4, 0),
(33, 'Clipper piros', 'Kiegészítő', 990, 15, 0),
(34, 'Clipper kék', 'Kiegészítő', 990, 0, 0),
(35, 'Clipper zöld', 'Kiegészítő', 990, 9, 0),
(36, 'Cigarettatárca fém', 'Kiegészítő', 3490, 5, 0),
(37, 'Cigarettatárca bőr', 'Kiegészítő', 5490, 2, 0),
(38, 'Hamuzó üveg', 'Kiegészítő', 2490, 6, 0),
(39, 'Hamuzó fém', 'Kiegészítő', 1990, 0, 0),
(40, 'OCB Slim papír', 'Kiegészítő', 690, 18, 0),
(41, 'OCB Premium', 'Kiegészítő', 890, 10, 0),
(42, 'Rizla Blue', 'Kiegészítő', 750, 9, 0),
(43, 'Rizla Green', 'Kiegészítő', 750, 0, 0),
(44, 'Mascotte Slim', 'Kiegészítő', 790, 4, 0),
(45, 'Filter Slim 6mm', 'Kiegészítő', 590, 20, 0),
(46, 'Filter Regular 8mm', 'Kiegészítő', 590, 0, 0),
(47, 'Dohány Cherry', 'Dohány', 1890, 12, 18),
(48, 'Dohány Vanilla', 'Dohány', 1890, 6, 18),
(49, 'Dohány Original', 'Dohány', 1790, 0, 18),
(50, 'Pipadohány Classic', 'Dohány', 2990, 3, 18),
(51, 'Pipadohány Cherry', 'Dohány', 2990, 0, 18),
(52, 'Szivar Montecristo No4', 'Szivar', 4990, 8, 18),
(53, 'Szivar Romeo y Julieta', 'Szivar', 5290, 5, 18),
(54, 'Szivar Cohiba Club', 'Szivar', 6990, 2, 18),
(55, 'Szivar Vegueros', 'Szivar', 4590, 0, 18),
(56, 'Szivar Punch', 'Szivar', 4890, 4, 18),
(57, 'Gyufa hosszú', 'Kiegészítő', 390, 25, 0),
(58, 'Gyufa rövid', 'Kiegészítő', 290, 0, 0),
(59, 'Öngyújtó gáz', 'Kiegészítő', 1490, 6, 0),
(60, 'Pipa fa', 'Kiegészítő', 8990, 1, 0),
(61, 'Pipaszűrő', 'Kiegészítő', 990, 12, 0),
(62, 'Pipatisztító', 'Kiegészítő', 790, 0, 0),
(63, 'Nikotinmentes folyadék', 'E-cigaretta', 2990, 10, 18),
(64, 'Mentolos folyadék', 'E-cigaretta', 3290, 0, 18),
(65, 'Classic Tobacco folyadék', 'E-cigaretta', 3290, 7, 18),
(66, 'Akkumulátor 18650', 'Készülék', 4990, 3, 18),
(67, 'USB töltő kábel', 'Kiegészítő', 1990, 9, 0),
(68, 'Szivargyújtó', 'Kiegészítő', 12990, 2, 0),
(69, 'Szivarvágó', 'Kiegészítő', 3490, 0, 0),
(70, 'Szivartok bőr', 'Kiegészítő', 8990, 1, 0),
(71, 'Mentolos filter', 'Kiegészítő', 690, 14, 0),
(72, 'Aroma mentol', 'Kiegészítő', 590, 0, 0),
(73, 'Aroma vanília', 'Kiegészítő', 590, 6, 0),
(74, 'Dohánytartó tasak', 'Kiegészítő', 2490, 3, 0),
(75, 'Dohánytömő gép', 'Kiegészítő', 3990, 0, 0),
(76, 'Hüvely standard', 'Kiegészítő', 490, 20, 0),
(77, 'Hüvely slim', 'Kiegészítő', 590, 11, 0),
(78, 'Hüvely mentolos', 'Kiegészítő', 690, 0, 0),
(79, 'Elektromos töltőgép', 'Készülék', 12990, 2, 0),
(80, 'Kézi töltőgép', 'Készülék', 4990, 4, 0),
(81, 'Szűrős hüvely', 'Kiegészítő', 790, 0, 0),
(82, 'Dohány mérleg', 'Készülék', 2990, 5, 0),
(83, 'Szivar hamutál', 'Kiegészítő', 5990, 1, 0),
(84, 'Szivar párásító', 'Készülék', 7990, 0, 0),
(85, 'Szivar doboz', 'Kiegészítő', 12990, 2, 0),
(86, 'Készpénztálca', 'Kiegészítő', 3490, 6, 0),
(87, 'Aprópénz tálca', 'Kiegészítő', 2490, 0, 0),
(88, 'Ártábla állvány', 'Kiegészítő', 1990, 3, 0),
(89, 'Reklám matrica', 'Kiegészítő', 990, 12, 0),
(90, 'Papírtáska kicsi', 'Kiegészítő', 190, 50, 0),
(91, 'Papírtáska nagy', 'Kiegészítő', 290, 40, 0),
(92, 'Számlatömb', 'Kiegészítő', 990, 8, 0),
(93, 'Nyugtatömb', 'Kiegészítő', 790, 0, 0),
(94, 'Kézfertőtlenítő', 'Kiegészítő', 1290, 15, 0),
(95, 'Maszk', 'Kiegészítő', 490, 0, 0),
(96, 'Polctisztító spray', 'Kiegészítő', 1590, 4, 0),
(97, 'Raktári címke', 'Kiegészítő', 390, 30, 0),
(98, 'Vonalkód matrica', 'Kiegészítő', 490, 0, 0),
(99, 'Készletnapló', 'Kiegészítő', 1990, 5, 0),
(100, 'Hungária Trafik ajándékutalván', 'Egyéb', 5000, 20, 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
