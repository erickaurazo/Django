CREATE DATABASE  IF NOT EXISTS `db_inventario` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_general_cs */;
USE `db_inventario`;
-- MySQL dump 10.13  Distrib 5.5.24, for debian-linux-gnu (i686)
--
-- Host: localhost    Database: db_inventario
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
-- Table structure for table `infraestructura_detalle`
--

DROP TABLE IF EXISTS `infraestructura_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `infraestructura_detalle` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `dispositivo_id` int(11) NOT NULL,
  `tipo_id` int(11) NOT NULL,
  `fechaCompra` datetime NOT NULL,
  `marca` varchar(25) COLLATE latin1_general_cs NOT NULL,
  `modelo` varchar(20) COLLATE latin1_general_cs NOT NULL,
  `serie` varchar(20) COLLATE latin1_general_cs NOT NULL,
  `capacidad` varchar(10) COLLATE latin1_general_cs NOT NULL,
  `version` int(11) NOT NULL COMMENT '	',
  `numeroLicencias` double NOT NULL,
  `garantia` tinyint(4) NOT NULL,
  `activo` tinyint(1) DEFAULT '1',
  `descripcion` varchar(200) COLLATE latin1_general_cs NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `ip_address` char(15) COLLATE latin1_general_cs NOT NULL,
  `host_name` varchar(50) COLLATE latin1_general_cs NOT NULL,
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `infraestructura_detalle_45e9b950` (`dispositivo_id`),
  KEY `infraestructura_detalle_27e4f492` (`tipo_id`),
  KEY `infraestructura_detalle_403f60f` (`user_id`),
  CONSTRAINT `dispositivo_id_refs_id_5a3633fd` FOREIGN KEY (`dispositivo_id`) REFERENCES `infraestructura_dispositivo` (`id`),
  CONSTRAINT `tipo_id_refs_id_47876d35` FOREIGN KEY (`tipo_id`) REFERENCES `infraestructura_tipo` (`id`),
  CONSTRAINT `user_id_refs_id_1fe04f07` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `infraestructura_detalle`
--

LOCK TABLES `infraestructura_detalle` WRITE;
/*!40000 ALTER TABLE `infraestructura_detalle` DISABLE KEYS */;
INSERT INTO `infraestructura_detalle` VALUES (1,6,19,'0000-00-00 00:00:00','INTERMEC','','','',0,0,1,1,'Movil para planta','2012-10-31 21:28:25','2012-10-31 21:28:25','127.0.0.1','',1),(2,7,27,'0000-00-00 00:00:00','Backberry','','','',0,0,0,1,'Backberry para uso personal','2012-10-31 21:31:00','2012-10-31 21:31:00','127.0.0.1','',1),(3,8,28,'2012-11-02 00:00:00','Microsoft','','','',6,1,1,1,'Microsoft','2012-11-02 14:53:39','2012-11-02 15:28:07','127.0.0.1','',1);
/*!40000 ALTER TABLE `infraestructura_detalle` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2012-11-02 10:45:44
