-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 05, 2020 at 08:46 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_cs1`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_task`
--

CREATE TABLE `tbl_task` (
  `id` int(11) NOT NULL,
  `task_name` text NOT NULL,
  `status` smallint(1) DEFAULT NULL,
  `created_date` date DEFAULT NULL,
  `due_date` date DEFAULT NULL,
  `tags` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_task`
--

INSERT INTO `tbl_task` (`id`, `task_name`, `status`, `created_date`, `due_date`, `tags`) VALUES
(36, 'huhu', 0, '2020-03-17', '2020-06-19', 'haha'),
(37, 'ABC', 0, '2020-03-23', '2020-05-07', 'uiooidmabxs'),
(38, 'tuoqwhkjdajda2', 0, '2020-05-17', '2020-06-04', 'kkkkk'),
(39, 'ABC', 1, '2020-06-01', '2020-06-03', 'SOCOLA'),
(40, 'bbb', 0, '2020-04-26', '2020-05-28', 'lllllllll'),
(41, 'tuoqwhkjdajda', 1, '2020-05-10', '2020-06-04', 'aa'),
(42, 'abc', 1, '2020-03-09', '2020-06-01', 'ttt'),
(43, 'dadsa', 1, '2020-06-01', '2020-06-04', 'fsdfasda'),
(44, 'aaa', 1, '2020-02-10', '2020-06-04', 'kkk'),
(45, 'das', 1, '2020-06-01', '2020-06-04', 'ghhjj'),
(46, 'aaa', 0, '2020-06-04', '2020-06-04', 'fasfa'),
(47, 'dsfds', 0, '2020-06-04', '2020-06-04', 'cfds'),
(48, 'aaa', 1, '2020-06-14', '2020-06-04', 'kkkkkkkkkkkk');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_task`
--
ALTER TABLE `tbl_task`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_task`
--
ALTER TABLE `tbl_task`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
