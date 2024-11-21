-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-11-2024 a las 21:38:20
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `base_delizia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apellido` varchar(20) NOT NULL,
  `Telefono` varchar(15) NOT NULL,
  `Direccion` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`Id`, `Nombre`, `Apellido`, `Telefono`, `Direccion`) VALUES
(16, 'jose', 'Moreira', '0987654321', 'La floresta'),
(17, '', '', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `funcionarios`
--

CREATE TABLE `funcionarios` (
  `Cedula` varchar(10) NOT NULL,
  `Rol` int(11) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apellido` varchar(20) NOT NULL,
  `Correo` varchar(50) NOT NULL,
  `Contrasena` varchar(20) NOT NULL,
  `Direccion` varchar(20) NOT NULL,
  `Activo` enum('Si','No') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `funcionarios`
--

INSERT INTO `funcionarios` (`Cedula`, `Rol`, `Nombre`, `Apellido`, `Correo`, `Contrasena`, `Direccion`, `Activo`) VALUES
('1', 1, 'Test1', ' ', ' ', '1', ' ', 'Si'),
('2', 2, 'Test2', ' ', ' ', '2', ' ', 'Si'),
('3', 3, 'Test3', ' ', ' ', '3', ' ', 'Si'),
('4', 4, 'Test4', ' ', ' ', '4', ' ', 'Si');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `funcionariospedidos`
--

CREATE TABLE `funcionariospedidos` (
  `Funcionario` varchar(10) NOT NULL,
  `Pedido` int(11) NOT NULL,
  `Hora` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `funcionariostelefonos`
--

CREATE TABLE `funcionariostelefonos` (
  `Funcionario` varchar(10) NOT NULL,
  `Telefono` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `funcionariostelefonos`
--

INSERT INTO `funcionariostelefonos` (`Funcionario`, `Telefono`) VALUES
('1', '093456789'),
('2', '092345678'),
('3', '099876543'),
('4', '098765432');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `logs`
--

CREATE TABLE `logs` (
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Funcionario` varchar(10) NOT NULL,
  `Equipo` varchar(20) NOT NULL,
  `Tipo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `logs`
--

INSERT INTO `logs` (`Fecha`, `Hora`, `Funcionario`, `Equipo`, `Tipo`) VALUES
('2024-11-21', '17:33:31', '1', 'CRISTIANR', NULL),
('2024-11-21', '17:33:38', '2', 'CRISTIANR', NULL),
('2024-11-21', '17:33:42', '3', 'CRISTIANR', NULL),
('2024-11-21', '17:33:50', '4', 'CRISTIANR', NULL),
('2024-11-21', '17:35:27', '1', 'CRISTIANR', NULL),
('2024-11-21', '17:35:32', '2', 'CRISTIANR', NULL),
('2024-11-21', '17:35:39', '3', 'CRISTIANR', NULL),
('2024-11-21', '17:35:42', '4', 'CRISTIANR', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidos`
--

CREATE TABLE `pedidos` (
  `Id` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Estado` int(11) NOT NULL,
  `Precio` double NOT NULL,
  `Cliente` int(11) NOT NULL,
  `Repartidor` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidosproductos`
--

CREATE TABLE `pedidosproductos` (
  `Pedido` int(11) NOT NULL,
  `Producto` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Precio` double NOT NULL,
  `Tipo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`Id`, `Nombre`, `Precio`, `Tipo`) VALUES
(1, 'Queso 30cm', 500, 1),
(2, 'Pepperoni 30cm', 500, 1),
(3, '4 Quesos 30cm', 500, 1),
(4, 'Hawaiana 30cm', 500, 1),
(5, 'Coca-Cola 500ml', 70, 2),
(6, 'Sprite 500ml', 70, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tickets`
--

CREATE TABLE `tickets` (
  `Id` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Pedido` int(11) NOT NULL,
  `Pago` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`Cedula`);

--
-- Indices de la tabla `funcionariospedidos`
--
ALTER TABLE `funcionariospedidos`
  ADD PRIMARY KEY (`Funcionario`,`Pedido`),
  ADD KEY `Pedido` (`Pedido`);

--
-- Indices de la tabla `funcionariostelefonos`
--
ALTER TABLE `funcionariostelefonos`
  ADD PRIMARY KEY (`Funcionario`,`Telefono`);

--
-- Indices de la tabla `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`Fecha`,`Hora`,`Funcionario`),
  ADD KEY `Funcionario` (`Funcionario`);

--
-- Indices de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Cliente` (`Cliente`),
  ADD KEY `Repartidor` (`Repartidor`);

--
-- Indices de la tabla `pedidosproductos`
--
ALTER TABLE `pedidosproductos`
  ADD PRIMARY KEY (`Pedido`,`Producto`),
  ADD KEY `Producto` (`Producto`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `tickets`
--
ALTER TABLE `tickets`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Pedido` (`Pedido`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tickets`
--
ALTER TABLE `tickets`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `funcionariospedidos`
--
ALTER TABLE `funcionariospedidos`
  ADD CONSTRAINT `funcionariospedidos_ibfk_1` FOREIGN KEY (`Funcionario`) REFERENCES `funcionarios` (`Cedula`),
  ADD CONSTRAINT `funcionariospedidos_ibfk_2` FOREIGN KEY (`Pedido`) REFERENCES `pedidos` (`Id`);

--
-- Filtros para la tabla `funcionariostelefonos`
--
ALTER TABLE `funcionariostelefonos`
  ADD CONSTRAINT `funcionariostelefonos_ibfk_1` FOREIGN KEY (`Funcionario`) REFERENCES `funcionarios` (`Cedula`);

--
-- Filtros para la tabla `logs`
--
ALTER TABLE `logs`
  ADD CONSTRAINT `logs_ibfk_1` FOREIGN KEY (`Funcionario`) REFERENCES `funcionarios` (`Cedula`);

--
-- Filtros para la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `Repartidor` FOREIGN KEY (`Repartidor`) REFERENCES `funcionarios` (`Cedula`),
  ADD CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`Cliente`) REFERENCES `clientes` (`Id`);

--
-- Filtros para la tabla `pedidosproductos`
--
ALTER TABLE `pedidosproductos`
  ADD CONSTRAINT `pedidosproductos_ibfk_1` FOREIGN KEY (`Pedido`) REFERENCES `pedidos` (`Id`),
  ADD CONSTRAINT `pedidosproductos_ibfk_2` FOREIGN KEY (`Producto`) REFERENCES `productos` (`Id`);

--
-- Filtros para la tabla `tickets`
--
ALTER TABLE `tickets`
  ADD CONSTRAINT `tickets_ibfk_1` FOREIGN KEY (`Pedido`) REFERENCES `pedidos` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
