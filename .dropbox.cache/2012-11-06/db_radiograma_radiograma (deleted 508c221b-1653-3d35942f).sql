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
-- Table structure for table `radiograma`
--

DROP TABLE IF EXISTS `radiograma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `radiograma` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `numero` int(11) DEFAULT NULL,
  `reservorio_volumen` double DEFAULT NULL,
  `reservorio_cota` double DEFAULT NULL,
  `reservorio_humedad_relativa` double DEFAULT NULL,
  `reservorio_temperatura_maxima` double DEFAULT NULL,
  `reservorio_temperatura_minima` double DEFAULT NULL,
  `reservorio_evaporacion` double DEFAULT NULL,
  `reservorio_precipitacion` double DEFAULT NULL,
  `reservorio_hora_precipitacion` varchar(765) NOT NULL,
  `trasvase_tunel_chonchano` double DEFAULT NULL,
  `trasvase_tunel_chotano` double DEFAULT NULL,
  `chonchano_seishoras` double DEFAULT NULL,
  `chotano_seishoras` double DEFAULT NULL,
  `chotano_temperatura_maxima` double DEFAULT NULL,
  `chotano_humedad_relativa` double DEFAULT NULL,
  `chotano_estado_tiempo` varchar(765) NOT NULL,
  `chotano_temperatura_mimino` double DEFAULT NULL,
  `chotano_precipitacion` double DEFAULT NULL,
  `chotano_precipitacion_hora` varchar(765) NOT NULL,
  `reservorio_temperatura_13horas` double DEFAULT NULL,
  `reservorio_temperatura_19horas` double DEFAULT NULL,
  `reservorio_temperatura_05horas` double DEFAULT NULL,
  `volumen_reservorio` double DEFAULT NULL,
  `perdidas` double DEFAULT NULL,
  `balance_alimentador` double DEFAULT NULL,
  `balance_descarga` double DEFAULT NULL,
  `balance_majin` double DEFAULT NULL,
  `balance_filtro` double DEFAULT NULL,
  `balance_volumen` double DEFAULT NULL,
  `balance_volumen_metros` double DEFAULT NULL,
  `balance_valor_teorico` double DEFAULT NULL,
  `balance_variacion_mes` double DEFAULT NULL,
  `balance_reservorio_proyectado_mensual` double DEFAULT NULL,
  `balance_diferencia_volumenes` double DEFAULT NULL,
  `balance_diferencia_volumenes_metros` double DEFAULT NULL,
  `balance_variacion_nivel` double DEFAULT NULL,
  `observacion` longtext NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `publicado` tinyint(1) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `ip_address` char(15) NOT NULL,
  `host_name` varchar(50) NOT NULL,
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `fecha` (`fecha`),
  UNIQUE KEY `numero` (`numero`),
  KEY `radiograma_403f60f` (`user_id`),
  CONSTRAINT `user_id_refs_id_405eafd9` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `radiograma`
--

LOCK TABLES `radiograma` WRITE;
/*!40000 ALTER TABLE `radiograma` DISABLE KEYS */;
INSERT INTO `radiograma` VALUES (1,'2011-04-01',91,NULL,192.572,65.3,34,18.3,7,0.1,'LL: 2-2:40',9.68,27.149,9.464,29.95,22,92,'CN TF S/Ll',10.5,15.6,'',28.6,25.4,25.2,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'En la Tabulación del Canal Alimentador se incluyen: 600lt/s C. Magín y 100lt/s para uso poblacional.',1,0,'2012-10-27 15:24:20','2012-10-27 16:37:10','127.0.0.1','',1),(2,'2011-04-02',92,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'En la Tabulación del Canal Alimentador se incluyen: 600lt/s C. Magín y 100lt/s para uso poblacional.',1,0,'2012-10-27 15:24:59','2012-10-27 15:25:52','127.0.0.1','',1),(3,'2011-04-03',93,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'En la Tabulación del Canal Alimentador se incluyen: 600lt/s C. Magín y 100lt/s para uso poblacional.',1,0,'2012-10-27 15:25:35','2012-10-27 15:25:44','127.0.0.1','',1),(4,'2011-04-04',94,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'En la Tabulación del Canal Alimentador se incluyen: 600lt/s C. Magín y 100lt/s para uso poblacional.',1,0,'2012-10-27 15:26:30','2012-10-27 15:26:30','127.0.0.1','',1);
/*!40000 ALTER TABLE `radiograma` ENABLE KEYS */;
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
