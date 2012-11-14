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
-- Table structure for table `parametro`
--

DROP TABLE IF EXISTS `parametro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `parametro` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `ip_address` char(15) NOT NULL,
  `host_name` varchar(50) NOT NULL,
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`),
  KEY `parametro_403f60f` (`user_id`),
  CONSTRAINT `user_id_refs_id_5233d7a0` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parametro`
--

LOCK TABLES `parametro` WRITE;
/*!40000 ALTER TABLE `parametro` DISABLE KEYS */;
INSERT INTO `parametro` VALUES (1,'Chancay',1,'2012-10-27 15:15:30','2012-10-27 15:15:30','127.0.0.1','',1),(2,'Compuerta del Rio',1,'2012-10-27 15:15:30','2012-10-27 15:15:30','127.0.0.1','',1),(3,'Canal Alimentador',1,'2012-10-27 15:15:30','2012-10-27 15:15:30','127.0.0.1','',1),(4,'Aporte Quebradas',1,'2012-10-27 15:15:30','2012-10-27 15:15:30','127.0.0.1','',1),(5,'Descarga',1,'2012-10-27 15:15:30','2012-10-27 15:15:30','127.0.0.1','',1),(6,'Magin',1,'2012-10-27 15:15:30','2012-10-27 15:15:30','127.0.0.1','',1),(7,'Upch',1,'2012-10-27 15:15:30','2012-10-27 15:15:30','127.0.0.1','',1),(8,'Cir. Asig',1,'2012-10-27 15:15:30','2012-10-27 15:15:30','127.0.0.1','',1),(9,'Puntilla Reque',1,'2012-10-27 15:15:30','2012-10-27 15:15:30','127.0.0.1','',1),(10,'Exc. Monsefu',1,'2012-10-27 15:15:30','2012-10-27 15:15:30','127.0.0.1','',1),(11,'Nieto',1,'2012-10-27 15:15:30','2012-10-27 15:15:30','127.0.0.1','',1),(12,'HM',1,'2012-10-27 15:15:30','2012-10-27 15:15:30','127.0.0.1','',1);
/*!40000 ALTER TABLE `parametro` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2012-10-27 13:04:11
