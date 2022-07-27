-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 27-07-2022 a las 23:56:17
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `calendarium`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dbanniversaries`
--

CREATE TABLE `dbanniversaries` (
  `ID` int(255) NOT NULL,
  `anniversaryNAME` varchar(255) NOT NULL,
  `anniversaryDATE` datetime NOT NULL,
  `anniversarySTARTYEAR` int(4) NOT NULL,
  `anniversaryTYPE` int(3) NOT NULL,
  `anniversaryHOLIDAY` tinyint(1) NOT NULL,
  `anniversaryIMPORTANCE` int(3) NOT NULL,
  `anniversaryICON` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dbbirthdays`
--

CREATE TABLE `dbbirthdays` (
  `ID` int(255) NOT NULL,
  `birthdayNAME` varchar(255) NOT NULL,
  `birthdayBIRTHDATE` datetime NOT NULL DEFAULT current_timestamp(),
  `birthdayBIRTHYEAR` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `dbbirthdays`
--

INSERT INTO `dbbirthdays` (`ID`, `birthdayNAME`, `birthdayBIRTHDATE`, `birthdayBIRTHYEAR`) VALUES
(1, 'Pedro', '2022-07-29 00:00:00', 1997);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dbcustomevents`
--

CREATE TABLE `dbcustomevents` (
  `ID` int(255) NOT NULL,
  `customEventNAME` varchar(255) NOT NULL,
  `customEventDATE` datetime NOT NULL,
  `customEventTYPE` int(3) NOT NULL,
  `customEventCATEGORY` int(3) NOT NULL,
  `customEventHOLIDAY` tinyint(1) NOT NULL,
  `customEventIMPORTANCE` int(3) NOT NULL,
  `customEventICON` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dbevents`
--

CREATE TABLE `dbevents` (
  `ID` int(255) NOT NULL,
  `eventNAME` varchar(255) NOT NULL,
  `eventDATE` datetime NOT NULL,
  `eventTYPE` int(3) NOT NULL,
  `eventCATEGORY` int(3) NOT NULL,
  `eventHOLIDAY` tinyint(1) NOT NULL,
  `eventIMPORTANCE` int(3) NOT NULL,
  `eventICON` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dbusers`
--

CREATE TABLE `dbusers` (
  `ID` int(255) NOT NULL,
  `userEMAIL` varchar(55) NOT NULL,
  `userNAME` varchar(33) NOT NULL,
  `userPASSWORD` varchar(44) NOT NULL,
  `userLANGUAGE` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `dbusers`
--

INSERT INTO `dbusers` (`ID`, `userEMAIL`, `userNAME`, `userPASSWORD`, `userLANGUAGE`) VALUES
(1, 'correisimo@correo.us', 'Shiva', 'Abc-123', 'EN');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `dbanniversaries`
--
ALTER TABLE `dbanniversaries`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `dbbirthdays`
--
ALTER TABLE `dbbirthdays`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `dbcustomevents`
--
ALTER TABLE `dbcustomevents`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `dbevents`
--
ALTER TABLE `dbevents`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `dbusers`
--
ALTER TABLE `dbusers`
  ADD PRIMARY KEY (`ID`) USING BTREE;

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `dbanniversaries`
--
ALTER TABLE `dbanniversaries`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `dbbirthdays`
--
ALTER TABLE `dbbirthdays`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `dbcustomevents`
--
ALTER TABLE `dbcustomevents`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `dbevents`
--
ALTER TABLE `dbevents`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `dbusers`
--
ALTER TABLE `dbusers`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
