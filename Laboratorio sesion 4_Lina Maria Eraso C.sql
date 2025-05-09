-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 08-05-2025 a las 03:59:12
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
-- Base de datos: `biblioteca`
--

--
-- Volcado de datos para la tabla `autores`
--

INSERT INTO `autores` (`ID_Autor`, `Nombre`, `Nacionalidad`, `Fecha_Nacimiento`) VALUES
(1, 'Gabriel García Márquez', 'Colombiano', '1927-03-06'),
(2, 'J.K. Rowling', 'Británica', '1965-07-31'),
(3, 'George Orwell', 'Británica', '1903-06-25'),
(4, 'Mario Vargas Llosa', 'Peruano', '1936-03-28'),
(5, 'Edgar Allan Poe', 'Estadounidense', '0000-00-00');

--
-- Volcado de datos para la tabla `categoría`
--

INSERT INTO `categoría` (`ID_Categoría`, `Nombre_Categoría`) VALUES
(1, 'Novela'),
(2, 'Ciencia Ficción'),
(3, 'Fantasía'),
(4, 'Ensayo');

--
-- Volcado de datos para la tabla `libros`
--

INSERT INTO `libros` (`ID_Libro`, `Título`, `ID_Autor`, `ID_Categoría`, `Año_Publicación`, `Disponible`) VALUES
(1, 'Cien Años de Soledad', 1, 1, '1967', 1),
(2, 'Harry Potter y la Piedra Filosofal', 2, 3, '1997', 1),
(3, '1984', 3, 2, '1949', 1),
(4, 'El sueño del Celta', 4, 1, '2010', 1);

--
-- Volcado de datos para la tabla `prestamo_usuarios`
--

INSERT INTO `prestamo_usuarios` (`ID_Prestamo`, `ID_Usuario`, `ID_Libro`, `Fecha_Prestamo`, `Fecha_Devolución`) VALUES
(1, 1, 1, '2024-08-01', '2024-08-15'),
(2, 2, 2, '2024-08-02', '2024-08-16'),
(3, 2, 3, '2024-10-13', '2024-10-27'),
(4, 1, 4, '2024-12-01', '2024-12-15');

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`ID_Usuario`, `Nombre`, `Dirección`, `Telefono`) VALUES
(1, 'Carlos Martínez', 'Calle Luna, 123', '123456789'),
(2, 'Lucía Fernández', 'Avenida Sol, 456', '987654321');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
