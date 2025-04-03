-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 03, 2025 at 05:16 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studentinfodb`
--

-- --------------------------------------------------------

--
-- Table structure for table `coursetb`
--

CREATE TABLE `coursetb` (
  `courseId` int(11) NOT NULL,
  `courseName` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `coursetb`
--

INSERT INTO `coursetb` (`courseId`, `courseName`) VALUES
(1, 'IT'),
(2, 'BSBA'),
(3, 'ABEL'),
(4, 'BPA');

-- --------------------------------------------------------

--
-- Table structure for table `studentrecordtb`
--

CREATE TABLE `studentrecordtb` (
  `studentId` int(11) NOT NULL,
  `firstName` varchar(250) NOT NULL,
  `lastName` varchar(250) NOT NULL,
  `middleName` varchar(250) DEFAULT NULL,
  `houseNo` varchar(10) DEFAULT NULL,
  `brgyName` varchar(250) DEFAULT NULL,
  `municipality` varchar(250) DEFAULT NULL,
  `province` varchar(250) DEFAULT NULL,
  `region` varchar(250) DEFAULT NULL,
  `country` varchar(250) DEFAULT 'Philippines',
  `birthdate` date NOT NULL,
  `age` int(11) DEFAULT NULL CHECK (`age` >= 0),
  `studContactNo` varchar(15) DEFAULT NULL,
  `emailAddress` varchar(250) DEFAULT NULL,
  `guardianFirstName` varchar(250) DEFAULT NULL,
  `guardianLastName` varchar(250) DEFAULT NULL,
  `hobbies` text DEFAULT NULL,
  `nickname` varchar(100) DEFAULT NULL,
  `courseId` int(11) DEFAULT NULL,
  `yearId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `studentrecordtb`
--

INSERT INTO `studentrecordtb` (`studentId`, `firstName`, `lastName`, `middleName`, `houseNo`, `brgyName`, `municipality`, `province`, `region`, `country`, `birthdate`, `age`, `studContactNo`, `emailAddress`, `guardianFirstName`, `guardianLastName`, `hobbies`, `nickname`, `courseId`, `yearId`) VALUES
(1, 'Roger', 'Macaraeg', 'Travina', '0000', 'Magsaysay', 'Bayambang', 'Pangasinan', 'Region 1', 'Philippines', '2001-06-28', 22, '09876543219', 'roger@gmail.com', 'Tony ', 'Stark', 'Science Project', 'Rawger', 1, 3),
(2, 'Pauline', 'Areola', 'Nepacina', '1111', 'Cabalaoangan', 'Rosales', 'Pangasinan', 'Region 1', 'Philippines', '2004-11-30', 20, '09876543210', 'pauline@gmail.com', 'Laufey', 'Jónsdóttir', 'Sleeping', 'Gandits', 1, 3),
(3, 'Gwan Sik', 'Yang', 'NULL', '3333', 'Jeju-si', 'Jeju City', 'Jeju Province', 'Jeju', 'South Korea', '1950-06-20', 74, '098765432101', 'yang.gwansik@gmail.com', 'Kwon', 'Gye-ok', 'Fishing', 'Gwan-sik', 2, 2),
(4, 'Jhin', 'Khada', 'Virtuoso', '4444', 'Kwatro', 'Apat', 'Four', 'Region 4', 'Philippines', '4444-04-04', 44, '09444444444', 'KhadaJhin@gmail.com', 'Riot', 'Games', 'Death painter', 'Whisper', 3, 4),
(5, 'Ae-sun', 'Oh', 'NULL', '7777', 'Seogwipo', 'Jeju City', 'Jeju Province', 'Jeju', 'South Korea', '1950-04-15', 75, '09325476432', 'oh.aesun@gmail.com', 'Jeon', 'Gwan-rye', 'Poetry', 'Ae-sun', 3, 3);

-- --------------------------------------------------------

--
-- Table structure for table `yeartb`
--

CREATE TABLE `yeartb` (
  `yearId` int(11) NOT NULL,
  `yearLvl` int(11) NOT NULL CHECK (`yearLvl` between 1 and 4)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `yeartb`
--

INSERT INTO `yeartb` (`yearId`, `yearLvl`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `coursetb`
--
ALTER TABLE `coursetb`
  ADD PRIMARY KEY (`courseId`);

--
-- Indexes for table `studentrecordtb`
--
ALTER TABLE `studentrecordtb`
  ADD PRIMARY KEY (`studentId`),
  ADD UNIQUE KEY `studContactNo` (`studContactNo`),
  ADD UNIQUE KEY `emailAddress` (`emailAddress`),
  ADD KEY `courseId` (`courseId`),
  ADD KEY `yearId` (`yearId`);

--
-- Indexes for table `yeartb`
--
ALTER TABLE `yeartb`
  ADD PRIMARY KEY (`yearId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `coursetb`
--
ALTER TABLE `coursetb`
  MODIFY `courseId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `studentrecordtb`
--
ALTER TABLE `studentrecordtb`
  MODIFY `studentId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `yeartb`
--
ALTER TABLE `yeartb`
  MODIFY `yearId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `studentrecordtb`
--
ALTER TABLE `studentrecordtb`
  ADD CONSTRAINT `studentrecordtb_ibfk_1` FOREIGN KEY (`courseId`) REFERENCES `coursetb` (`courseId`) ON DELETE SET NULL,
  ADD CONSTRAINT `studentrecordtb_ibfk_2` FOREIGN KEY (`yearId`) REFERENCES `yeartb` (`yearId`) ON DELETE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
