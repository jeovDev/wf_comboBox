-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 13, 2021 at 05:50 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `comboboxdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `item1_tbl`
--

CREATE TABLE `item1_tbl` (
  `id` int(11) NOT NULL,
  `item1` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `item1_tbl`
--

INSERT INTO `item1_tbl` (`id`, `item1`) VALUES
(1, 'Android '),
(2, 'Apple');

-- --------------------------------------------------------

--
-- Table structure for table `item2_tbl`
--

CREATE TABLE `item2_tbl` (
  `id` int(11) NOT NULL,
  `item1_id` text NOT NULL,
  `item2` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `item2_tbl`
--

INSERT INTO `item2_tbl` (`id`, `item1_id`, `item2`) VALUES
(1, '1', 'Realme'),
(2, '1', 'Samsung'),
(3, '2', 'Ipod');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `item1_tbl`
--
ALTER TABLE `item1_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `item2_tbl`
--
ALTER TABLE `item2_tbl`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `item1_tbl`
--
ALTER TABLE `item1_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `item2_tbl`
--
ALTER TABLE `item2_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
