-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 02, 2023 at 01:51 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_bakery`
--

-- --------------------------------------------------------

--
-- Table structure for table `detail_pembelian`
--

CREATE TABLE `detail_pembelian` (
  `id_transaksi` varchar(50) NOT NULL,
  `id_roti` int(11) NOT NULL,
  `jumlah_beli` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detail_pembelian`
--

INSERT INTO `detail_pembelian` (`id_transaksi`, `id_roti`, `jumlah_beli`) VALUES
('T01-16122022-00000001', 5, 5),
('T01-16122022-00000002', 7, 5),
('T01-16122022-00000003', 3, 2),
('T01-16122022-00000004', 7, 1),
('T01-16122022-00000005', 8, 1),
('T01-16122022-00000006', 2, 1),
('T01-16122022-00000007', 1, 1),
('T01-16122022-00000008', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `pembelian`
--

CREATE TABLE `pembelian` (
  `id_transaksi` varchar(50) NOT NULL,
  `nama_pembeli` varchar(100) NOT NULL,
  `tanggal` datetime NOT NULL,
  `total` decimal(20,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pembelian`
--

INSERT INTO `pembelian` (`id_transaksi`, `nama_pembeli`, `tanggal`, `total`) VALUES
('T01-16122022-00000001', 'icul', '2022-12-16 08:14:47', '50000'),
('T01-16122022-00000002', 'Rian', '2022-12-16 08:34:52', '10000'),
('T01-16122022-00000003', 'hadir', '2022-12-16 08:42:19', '4000'),
('T01-16122022-00000004', 'reza', '2022-12-16 08:46:22', '2000'),
('T01-16122022-00000005', 'rasid', '2022-12-16 08:50:25', '3500'),
('T01-16122022-00000006', 'ipin', '2022-12-16 23:19:20', '40000'),
('T01-16122022-00000007', 'ipin', '2022-12-16 23:23:11', '10000'),
('T01-16122022-00000008', 'ipin', '2022-12-16 23:31:37', '10000');

-- --------------------------------------------------------

--
-- Table structure for table `petugas`
--

CREATE TABLE `petugas` (
  `NIK` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `nama_petugas` varchar(100) NOT NULL,
  `Status` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `petugas`
--

INSERT INTO `petugas` (`NIK`, `username`, `password`, `nama_petugas`, `Status`) VALUES
(15040910, 'admin', 'admin', 'Ahmad Rahmadi Subli Ibrahim', 'X'),
(1234567890, 'arifin', 'admin', 'Arifin', 'X');

-- --------------------------------------------------------

--
-- Table structure for table `resep`
--

CREATE TABLE `resep` (
  `id_resep` varchar(50) NOT NULL,
  `nama_resep` varchar(100) NOT NULL,
  `id_roti` int(11) NOT NULL,
  `keterangan` text NOT NULL,
  `tanggal_update` datetime NOT NULL,
  `Status` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `resep`
--

INSERT INTO `resep` (`id_resep`, `nama_resep`, `id_roti`, `keterangan`, `tanggal_update`, `Status`) VALUES
('WPQDD290418', 'TEst', 1, '', '2018-04-29 14:40:17', '');

-- --------------------------------------------------------

--
-- Table structure for table `resep_detail`
--

CREATE TABLE `resep_detail` (
  `id_resep` varchar(50) NOT NULL,
  `nama_bahan` text NOT NULL,
  `takaran` int(11) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `resep_detail`
--

INSERT INTO `resep_detail` (`id_resep`, `nama_bahan`, `takaran`, `keterangan`) VALUES
('WPQDD290418', 'asd', 2, '');

-- --------------------------------------------------------

--
-- Table structure for table `roti`
--

CREATE TABLE `roti` (
  `id_roti` int(11) NOT NULL,
  `nama_roti` varchar(100) NOT NULL,
  `rasa` varchar(50) NOT NULL,
  `harga` decimal(50,0) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `roti`
--

INSERT INTO `roti` (`id_roti`, `nama_roti`, `rasa`, `harga`, `keterangan`) VALUES
(1, 'Sari Roti', 'Tawar', '10000', 'Pinggiran Dilapisi Emas 24,2 Karat'),
(2, 'Roti Padang', 'Rendang', '40000', 'Pedas '),
(3, 'Strawbery Choco', 'Nanas', '2000', 'Roti Rasa Nanas Dilapisi Anggur Merah'),
(4, 'Bread Bread', 'Ayam', '100000', 'Roti Rasa Daging Ayam Kampus'),
(5, 'Roti Jordan', 'Durian', '10000', 'Roti rasa durian dilapis salak'),
(7, 'Roti Susu', 'Pisang Coklat', '2000', 'Berlapis Coklat Dan Susu'),
(8, 'Roti Coklat', 'Keju Susu', '3500', 'Gurih Enak');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `detail_pembelian`
--
ALTER TABLE `detail_pembelian`
  ADD KEY `id_transaksi` (`id_transaksi`),
  ADD KEY `id_roti` (`id_roti`),
  ADD KEY `jumlah_beli` (`jumlah_beli`);

--
-- Indexes for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- Indexes for table `petugas`
--
ALTER TABLE `petugas`
  ADD PRIMARY KEY (`NIK`);

--
-- Indexes for table `resep`
--
ALTER TABLE `resep`
  ADD PRIMARY KEY (`id_resep`,`id_roti`),
  ADD KEY `id_roti` (`id_roti`),
  ADD KEY `id_roti_2` (`id_roti`);

--
-- Indexes for table `resep_detail`
--
ALTER TABLE `resep_detail`
  ADD UNIQUE KEY `id_resep` (`id_resep`),
  ADD KEY `id_transaksi` (`id_resep`),
  ADD KEY `jumlah_beli` (`takaran`),
  ADD KEY `id_resep_2` (`id_resep`),
  ADD KEY `id_resep_3` (`id_resep`);

--
-- Indexes for table `roti`
--
ALTER TABLE `roti`
  ADD PRIMARY KEY (`id_roti`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `petugas`
--
ALTER TABLE `petugas`
  MODIFY `NIK` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1234567891;

--
-- AUTO_INCREMENT for table `roti`
--
ALTER TABLE `roti`
  MODIFY `id_roti` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `detail_pembelian`
--
ALTER TABLE `detail_pembelian`
  ADD CONSTRAINT `detail_pembelian_ibfk_4` FOREIGN KEY (`id_transaksi`) REFERENCES `pembelian` (`id_transaksi`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detail_pembelian_ibfk_5` FOREIGN KEY (`id_roti`) REFERENCES `roti` (`id_roti`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `resep`
--
ALTER TABLE `resep`
  ADD CONSTRAINT `resep_ibfk_2` FOREIGN KEY (`id_roti`) REFERENCES `roti` (`id_roti`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `resep_detail`
--
ALTER TABLE `resep_detail`
  ADD CONSTRAINT `resep_detail_ibfk_1` FOREIGN KEY (`id_resep`) REFERENCES `resep` (`id_resep`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
