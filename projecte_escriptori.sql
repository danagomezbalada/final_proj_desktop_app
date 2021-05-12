-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 12-05-2021 a las 21:00:13
-- Versión del servidor: 10.4.6-MariaDB
-- Versión de PHP: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

/* Eliminem la base de dades si ja existeix */
DROP DATABASE IF EXISTS `projecte_escriptori`;

/* Creem la base de dades si no existeix */
CREATE DATABASE IF NOT EXISTS `projecte_escriptori`;

/* Marquem la base de dades com la utilitzada actualment per operar amb ella */
USE `projecte_escriptori`;

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `projecte_escriptori`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `activitat`
--

CREATE TABLE `activitat` (
  `id` int(11) NOT NULL,
  `titol` varchar(255) NOT NULL,
  `data` date NOT NULL DEFAULT current_timestamp(),
  `descripcio` varchar(255) NOT NULL,
  `preu` double NOT NULL DEFAULT 0,
  `places_totals` int(11) NOT NULL DEFAULT 100,
  `places_actuals` int(11) NOT NULL DEFAULT 100,
  `id_esdeveniment` int(11) DEFAULT NULL,
  `data_inici_mostra` date NOT NULL DEFAULT current_timestamp(),
  `data_fi_mostra` date NOT NULL,
  `id_ubicacio` int(11) DEFAULT NULL,
  `id_departament` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `activitat`
--

INSERT INTO `activitat` (`id`, `titol`, `data`, `descripcio`, `preu`, `places_totals`, `places_actuals`, `id_esdeveniment`, `data_inici_mostra`, `data_fi_mostra`, `id_ubicacio`, `id_departament`) VALUES
(1, 'Tast de formatges', '2021-05-17', 'Tast de fotmatges del Pirineu', 10, 50, 35, 1, '2021-05-08', '2021-06-15', 1, 3),
(2, 'Presentació del llibre - La Tempesta', '2021-07-17', 'Presentació del nou llibre La Tempesta', 0, 70, 20, 2, '2021-05-08', '2021-06-15', 2, 1),
(3, 'Partit amistós', '2021-08-05', 'Partit de futbol entre La Seu i l’Organyà', 10, 200, 148, 3, '2021-05-08', '2021-06-15', 3, 2),
(4, 'Mercat Medieval', '2021-05-22', 'Mercat orientat a la edat medieval', 0, 3000, 2500, 1, '2021-05-01', '2021-06-08', 7, 3),
(5, 'Teatre de titelles', '2021-05-11', 'Teatre de titelles per als més petits de casa', 5, 300, 250, 5, '2021-03-11', '2021-05-31', 4, 1),
(6, 'Mostra de Cotxes', '2021-05-22', 'Es pot veure una presentació de les últimes actualitats en automobils', 0, 300, 250, 1, '2021-03-09', '2021-06-10', 5, 9),
(7, 'Taller de titelles', '2021-05-22', 'Taller on els petits de casa poden crear els seus propis titelles', 3, 500, 350, 1, '2021-03-09', '2021-06-10', 6, 1),
(8, 'Visita al museu de l’Espai Ermengol', '2021-05-22', 'Visita guiada per el moseu de l’Espai Ermengol, pots conèixer més a fons la història de la Seu d’Urgell', 3, 400, 350, 1, '2021-03-09', '2021-06-10', 2, 1),
(9, 'Atraccions', '2021-05-08', 'Atraccions per als nens i nenes ', 4, 8000, 7500, 1, '2021-03-09', '2021-06-10', 8, 9),
(10, 'Concert ', '2021-05-08', 'Concert de 16:00 a 20:00 ', 4, 2000, 2900, 1, '2021-03-09', '2021-06-10', 9, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `activitat_categoria`
--

CREATE TABLE `activitat_categoria` (
  `id` int(11) NOT NULL,
  `id_activitat` int(11) DEFAULT NULL,
  `id_categoria` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `activitat_categoria`
--

INSERT INTO `activitat_categoria` (`id`, `id_activitat`, `id_categoria`) VALUES
(1, 1, 3),
(2, 2, 3),
(3, 3, 1),
(4, 5, 10),
(5, 4, 7),
(6, 6, 3),
(7, 7, 10),
(8, 7, 8),
(9, 8, 3),
(10, 8, 7),
(11, 9, 10),
(12, 10, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `activitat_ponent`
--

CREATE TABLE `activitat_ponent` (
  `id` int(11) NOT NULL,
  `id_activitat` int(11) DEFAULT NULL,
  `id_ponent` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `activitat_ponent`
--

INSERT INTO `activitat_ponent` (`id`, `id_activitat`, `id_ponent`) VALUES
(1, 3, 1),
(2, 2, 2),
(3, 2, 3),
(4, 5, 5),
(5, 5, 4),
(6, 8, 3),
(7, 7, 4),
(9, 10, 8);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE `categoria` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`id`, `nom`) VALUES
(1, 'Esports'),
(2, 'Música'),
(3, 'Exposició'),
(7, 'Cultura'),
(8, 'Lleure'),
(9, 'Tallers'),
(10, 'Animació Infantil');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departament`
--

CREATE TABLE `departament` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `departament`
--

INSERT INTO `departament` (`id`, `nom`) VALUES
(1, 'Cultura'),
(2, 'Joventut'),
(3, 'Promoció econòmica'),
(4, 'Educació'),
(5, 'Agricultutra i Ramaderia'),
(6, 'Justícia'),
(7, 'Salut'),
(8, 'Hisenda'),
(9, 'Economia'),
(10, 'Transport');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `esdeveniment`
--

CREATE TABLE `esdeveniment` (
  `id` int(11) NOT NULL,
  `any` int(11) NOT NULL DEFAULT 2000,
  `nom` varchar(255) NOT NULL,
  `descripcio` varchar(255) NOT NULL,
  `actiu` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `esdeveniment`
--

INSERT INTO `esdeveniment` (`id`, `any`, `nom`, `descripcio`, `actiu`) VALUES
(1, 2021, 'Fira del formatge', 'La famosa fira de l’Alt Urgell on es presenten els formatges de la zona', 1),
(2, 2021, 'Fira del Llibre', 'Fira on es presenten i es venen llibres', 1),
(3, 2021, 'Torneig de futbol', 'Torneig on participen tots els equips de la comarca', 1),
(4, 2021, 'Caminada popular', 'caminada popular des de la Seu d’Urgell fins a l’aeroport', 1),
(5, 2021, 'Dinar popular', 'Dinar popular entre tots els participants', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ponent`
--

CREATE TABLE `ponent` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `cognoms` varchar(255) NOT NULL,
  `telefon` int(11) NOT NULL,
  `email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ponent`
--

INSERT INTO `ponent` (`id`, `nom`, `cognoms`, `telefon`, `email`) VALUES
(1, 'Sergi', 'Tor Jimenez', 999067584, 'sergi@gmail.com'),
(2, 'Pep', 'Serra Costa', 444546587, 'pep@gmail.com'),
(3, 'Xavi', 'Serra Puig', 333647856, 'xavi@gmail.com'),
(4, 'Anna', 'Mari Ramos', 609346327, 'anna@gmail.com'),
(5, 'Toni', 'González Gómez', 607459216, 'toni@gmail.com'),
(6, 'Lucia', 'Sharon Buey', 608321574, 'lucia@gmail.com'),
(8, 'Txarango', 'Txarango', 608742854, 'txarango@gmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reserva`
--

CREATE TABLE `reserva` (
  `id` int(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  `id_activitat` int(11) DEFAULT NULL,
  `data` date NOT NULL DEFAULT current_timestamp(),
  `codi_transaccio` varchar(255) NOT NULL DEFAULT '0',
  `estat` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `reserva`
--

INSERT INTO `reserva` (`id`, `email`, `id_activitat`, `data`, `codi_transaccio`, `estat`) VALUES
(0, 'sergi@gmail.com', 3, '2021-05-18', '05TYUI456', 1),
(1, 'maria@gmail.com', 1, '2021-05-12', '04ADFE675', 2),
(2, 'judit@gmail.com', 3, '2021-07-27', '04FGTE678', 1),
(3, 'marc@gmail.com', 2, '2021-07-10', '04GHTE874', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ubicacio`
--

CREATE TABLE `ubicacio` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ubicacio`
--

INSERT INTO `ubicacio` (`id`, `nom`) VALUES
(1, 'Catedral de Santa Maria d’Urgell'),
(2, 'Sala Sant Domenech'),
(3, 'Poliesportiu Municipal'),
(4, 'Plaça de Catalunya'),
(5, 'Plaça del Deganat'),
(6, 'Plaça Europa'),
(7, 'Plaça Patalín'),
(8, 'Plaça de les Monges'),
(9, 'Plaça dels Oms'),
(10, 'Plaça Barcelona'),
(11, 'Plaça del Call'),
(12, 'Plaça Espanya');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `activitat`
--
ALTER TABLE `activitat`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_esdeveniment` (`id_esdeveniment`),
  ADD KEY `id_departament` (`id_departament`),
  ADD KEY `id_ubicacio` (`id_ubicacio`);

--
-- Indices de la tabla `activitat_categoria`
--
ALTER TABLE `activitat_categoria`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_categoria` (`id_categoria`),
  ADD KEY `id_activitat` (`id_activitat`);

--
-- Indices de la tabla `activitat_ponent`
--
ALTER TABLE `activitat_ponent`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_ponent` (`id_ponent`),
  ADD KEY `id_activitat` (`id_activitat`);

--
-- Indices de la tabla `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `departament`
--
ALTER TABLE `departament`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `esdeveniment`
--
ALTER TABLE `esdeveniment`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `ponent`
--
ALTER TABLE `ponent`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `reserva`
--
ALTER TABLE `reserva`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_activitat` (`id_activitat`);

--
-- Indices de la tabla `ubicacio`
--
ALTER TABLE `ubicacio`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `activitat`
--
ALTER TABLE `activitat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `activitat_categoria`
--
ALTER TABLE `activitat_categoria`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `activitat_ponent`
--
ALTER TABLE `activitat_ponent`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `categoria`
--
ALTER TABLE `categoria`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `departament`
--
ALTER TABLE `departament`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `esdeveniment`
--
ALTER TABLE `esdeveniment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `ponent`
--
ALTER TABLE `ponent`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `ubicacio`
--
ALTER TABLE `ubicacio`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `activitat`
--
ALTER TABLE `activitat`
  ADD CONSTRAINT `activitat_ibfk_1` FOREIGN KEY (`id_esdeveniment`) REFERENCES `esdeveniment` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `activitat_ibfk_2` FOREIGN KEY (`id_departament`) REFERENCES `departament` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `activitat_ibfk_3` FOREIGN KEY (`id_ubicacio`) REFERENCES `ubicacio` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Filtros para la tabla `activitat_categoria`
--
ALTER TABLE `activitat_categoria`
  ADD CONSTRAINT `activitat_categoria_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `categoria` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `activitat_categoria_ibfk_2` FOREIGN KEY (`id_activitat`) REFERENCES `activitat` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `activitat_ponent`
--
ALTER TABLE `activitat_ponent`
  ADD CONSTRAINT `activitat_ponent_ibfk_1` FOREIGN KEY (`id_ponent`) REFERENCES `ponent` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `activitat_ponent_ibfk_2` FOREIGN KEY (`id_activitat`) REFERENCES `activitat` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `reserva`
--
ALTER TABLE `reserva`
  ADD CONSTRAINT `reserva_ibfk_1` FOREIGN KEY (`id_activitat`) REFERENCES `activitat` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
