CREATE DATABASE  IF NOT EXISTS `db_radiograma` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `db_radiograma`;
-- MySQL dump 10.13  Distrib 5.5.24, for debian-linux-gnu (i686)
--
-- Host: localhost    Database: db_radiograma
-- ------------------------------------------------------
-- Server version	5.5.24-0ubuntu0.12.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `medida`
--

DROP TABLE IF EXISTS `medida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medida` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `parametro_id` int(11) NOT NULL,
  `radiograma_id` int(11) NOT NULL,
  `hora1` double NOT NULL,
  `hora2` double NOT NULL,
  `hora3` double NOT NULL,
  `hora4` double NOT NULL,
  `hora5` double NOT NULL,
  `hora6` double NOT NULL,
  `hora7` double NOT NULL,
  `hora8` double NOT NULL,
  `hora9` double DEFAULT NULL,
  `hora10` double DEFAULT NULL,
  `hora11` double DEFAULT NULL,
  `hora12` double DEFAULT NULL,
  `hora13` double DEFAULT NULL,
  `hora14` double DEFAULT NULL,
  `hora15` double DEFAULT NULL,
  `hora16` double DEFAULT NULL,
  `hora17` double DEFAULT NULL,
  `hora18` double DEFAULT NULL,
  `hora19` double DEFAULT NULL,
  `hora20` double DEFAULT NULL,
  `hora21` double DEFAULT NULL,
  `hora22` double DEFAULT NULL,
  `hora23` double DEFAULT NULL,
  `hora24` double DEFAULT NULL,
  `promedio_del_dia` double DEFAULT NULL,
  `promedio_06_horas` double DEFAULT NULL,
  `promedio_12_horas` double DEFAULT NULL,
  `promedio_18_horas` double DEFAULT NULL,
  `promedio_24_horas` double NOT NULL,
  `masa_diaria` double NOT NULL,
  `maxima_parametros` double DEFAULT NULL,
  `minima_parametros` double DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `ip_address` char(15) NOT NULL,
  `host_name` varchar(50) NOT NULL,
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `radiograma_id` (`radiograma_id`,`parametro_id`),
  KEY `medida_168e3d50` (`parametro_id`),
  KEY `medida_2fb9c949` (`radiograma_id`),
  KEY `medida_403f60f` (`user_id`),
  CONSTRAINT `user_id_refs_id_3736da5c` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`),
  CONSTRAINT `parametro_id_refs_id_5d2c7c0f` FOREIGN KEY (`parametro_id`) REFERENCES `parametro` (`id`),
  CONSTRAINT `radiograma_id_refs_id_5b1abff2` FOREIGN KEY (`radiograma_id`) REFERENCES `radiograma` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medida`
--

LOCK TABLES `medida` WRITE;
/*!40000 ALTER TABLE `medida` DISABLE KEYS */;
/*!40000 ALTER TABLE `medida` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2012-10-27 13:04:12
