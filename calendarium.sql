-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-07-2022 a las 19:38:47
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 7.4.25

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
-- Estructura de tabla para la tabla `dbbasecalendars`
--

CREATE TABLE `dbbasecalendars` (
  `ID` int(255) NOT NULL,
  `baseCalendarNAME` varchar(255) NOT NULL,
  `baseCalendarCATEGORY` int(3) NOT NULL,
  `baseCalendarGROUP` varchar(255) NOT NULL,
  `baseCalendarURL` varchar(255) NOT NULL,
  `baseCalendarORDER` int(3) NOT NULL,
  `baseCalendarFIRST_DAY` tinyint(1) NOT NULL,
  `baseCalendarNEW_YEAR` datetime NOT NULL,
  `baseCalendarICON` varchar(255) NOT NULL,
  `baseCalendarMONTH_AMOUNT` int(2) NOT NULL,
  `baseCalendarDAY_AMOUNT` int(3) NOT NULL,
  `baseCalendarLEAP_DAY_MONTH` int(2) NOT NULL,
  `baseCalendarLEAP_DAY_PLACE` int(2) NOT NULL,
  `baseCalendarLEAP_DAY_STARTbaseCalendarLEAP_DAY_START` int(2) NOT NULL,
  `baseCalendarLEAP_DAY_DISTANCE` int(255) NOT NULL,
  `baseCalendarDAY_NAME1` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME2` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME3` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME4` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME5` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME6` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME7` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME8` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME9` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME10` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME11` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME12` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME13` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME14` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME15` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME16` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME17` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME18` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME19` varchar(255) NOT NULL,
  `baseCalendarDAY_NAME20` varchar(255) NOT NULL,
  `baseCalendarMONTH_DURATION1` int(2) NOT NULL,
  `baseCalendarMONTH_DURATION2` int(2) NOT NULL,
  `baseCalendarMONTH_DURATION3` int(2) NOT NULL,
  `baseCalendarMONTH_DURATION4` int(2) NOT NULL,
  `baseCalendarMONTH_DURATION5` int(2) NOT NULL,
  `baseCalendarMONTH_DURATION6` int(2) NOT NULL,
  `baseCalendarMONTH_DURATION7` int(2) NOT NULL,
  `baseCalendarMONTH_DURATION8` int(2) NOT NULL,
  `baseCalendarMONTH_DURATION9` int(2) NOT NULL,
  `baseCalendarMONTH_DURATION10` int(2) NOT NULL,
  `baseCalendarMONTH_DURATION11` int(2) NOT NULL,
  `baseCalendarMONTH_DURATION12` int(2) NOT NULL,
  `baseCalendarMONTH_DURATION13` int(2) NOT NULL DEFAULT 0,
  `baseCalendarMONTH_DURATION14` int(2) NOT NULL DEFAULT 0,
  `baseCalendarMONTH_DURATION15` int(2) NOT NULL DEFAULT 0,
  `baseCalendarMONTH_DURATION16` int(2) NOT NULL DEFAULT 0,
  `baseCalendarMONTH_DURATION17` int(2) NOT NULL DEFAULT 0,
  `baseCalendarMONTH_DURATION18` int(2) NOT NULL DEFAULT 0,
  `baseCalendarMONTH_DURATION19` int(2) NOT NULL DEFAULT 0,
  `baseCalendarMONTH_DURATION20` int(2) NOT NULL DEFAULT 0
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
-- Estructura de tabla para la tabla `dbpersonalcalendars`
--

CREATE TABLE `dbpersonalcalendars` (
  `ID` int(255) NOT NULL,
  `personalCalendarNAME` varchar(255) NOT NULL,
  `personalCalendarCATEGORY` int(3) NOT NULL,
  `personalCalendarGROUP` varchar(255) NOT NULL,
  `personalCalendarURL` varchar(255) NOT NULL,
  `personalCalendarFIRST_DAY` tinyint(1) NOT NULL,
  `personalCalendarNEW_YEAR` datetime NOT NULL,
  `personalCalendarSTRUCTURE` int(255) NOT NULL,
  `personalCalendarDAY_NAME1` varchar(255) NOT NULL,
  `personalCalendarDAY_NAME2` varchar(255) NOT NULL,
  `personalCalendarDAY_NAME3` varchar(255) NOT NULL,
  `personalCalendarDAY_NAME4` varchar(255) NOT NULL,
  `personalCalendarDAY_NAME5` varchar(255) NOT NULL,
  `personalCalendarDAY_NAME6` varchar(255) NOT NULL,
  `personalCalendarDAY_NAME7` varchar(255) NOT NULL,
  `personalCalendarDAY_NAME8` varchar(255) NOT NULL,
  `personalCalendarDAY_NAME9` varchar(255) NOT NULL,
  `personalCalendarDAY_NAME10` varchar(255) NOT NULL,
  `personalCalendarDAY_NAME11` varchar(255) NOT NULL,
  `personalCalendarDAY_NAME12` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME1` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME2` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME3` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME4` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME5` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME6` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME7` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME8` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME9` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME10` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME11` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME12` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME13` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME14` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME15` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME16` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME17` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME18` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME19` varchar(255) NOT NULL,
  `personalCalendarMONTH_NAME20` varchar(255) NOT NULL
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
-- Indices de la tabla `dbbasecalendars`
--
ALTER TABLE `dbbasecalendars`
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
-- Indices de la tabla `dbpersonalcalendars`
--
ALTER TABLE `dbpersonalcalendars`
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
-- AUTO_INCREMENT de la tabla `dbbasecalendars`
--
ALTER TABLE `dbbasecalendars`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `dbbirthdays`
--
ALTER TABLE `dbbirthdays`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT;

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
-- AUTO_INCREMENT de la tabla `dbpersonalcalendars`
--
ALTER TABLE `dbpersonalcalendars`
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
