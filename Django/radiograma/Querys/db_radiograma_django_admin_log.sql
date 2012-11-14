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
-- Table structure for table `django_admin_log`
--

DROP TABLE IF EXISTS `django_admin_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `django_admin_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `action_time` datetime NOT NULL,
  `user_id` int(11) NOT NULL,
  `content_type_id` int(11) DEFAULT NULL,
  `object_id` longtext,
  `object_repr` varchar(200) NOT NULL,
  `action_flag` smallint(5) unsigned NOT NULL,
  `change_message` longtext NOT NULL,
  PRIMARY KEY (`id`),
  KEY `django_admin_log_403f60f` (`user_id`),
  KEY `django_admin_log_1bb8f392` (`content_type_id`),
  CONSTRAINT `user_id_refs_id_c8665aa` FOREIGN KEY (`user_id`) REFERENCES `auth_user` (`id`),
  CONSTRAINT `content_type_id_refs_id_288599e6` FOREIGN KEY (`content_type_id`) REFERENCES `django_content_type` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `django_admin_log`
--

LOCK TABLES `django_admin_log` WRITE;
/*!40000 ALTER TABLE `django_admin_log` DISABLE KEYS */;
INSERT INTO `django_admin_log` VALUES (1,'2012-10-27 14:10:09',1,11,'1','Tinajones object',1,''),(2,'2012-10-27 14:10:25',1,11,'2','Tinajones object',1,''),(3,'2012-10-27 14:10:39',1,11,'3','Tinajones object',1,''),(4,'2012-10-27 14:31:23',1,11,'6','Tinajones object',3,''),(5,'2012-10-27 14:31:23',1,11,'3','Tinajones object',3,''),(6,'2012-10-27 14:31:23',1,11,'5','Tinajones object',3,''),(7,'2012-10-27 14:31:23',1,11,'2','Tinajones object',3,''),(8,'2012-10-27 14:31:23',1,11,'4','Tinajones object',3,''),(9,'2012-10-27 14:31:23',1,11,'1','Tinajones object',3,''),(10,'2012-10-27 15:15:30',1,8,'1','Chancay',1,''),(11,'2012-10-27 15:18:55',1,8,'1','Chancay',3,''),(12,'2012-10-27 15:24:20',1,9,'1','00001',1,''),(13,'2012-10-27 15:24:59',1,9,'2','00002',1,''),(14,'2012-10-27 15:25:35',1,9,'3','00003',1,''),(15,'2012-10-27 15:25:44',1,9,'3','00003',2,'Changed fecha.'),(16,'2012-10-27 15:25:52',1,9,'2','00002',2,'Changed fecha.'),(17,'2012-10-27 15:26:30',1,9,'4','00004',1,''),(18,'2012-10-27 15:29:09',1,9,'1','00001',2,'Changed fecha.'),(19,'2012-10-27 16:34:53',1,9,'1','00001',2,'Changed reservorio_cota, reservorio_humedad_relativa, reservorio_temperatura_maxima, reservorio_temperatura_minima, reservorio_evaporacion, reservorio_precipitacion and reservorio_hora_precipitacion.'),(20,'2012-10-27 16:36:01',1,9,'1','00001',2,'Changed trasvase_tunel_chotano, chotano_seishoras, chotano_temperatura_maxima, chotano_temperatura_mimino, chotano_humedad_relativa and chotano_precipitacion.'),(21,'2012-10-27 16:37:10',1,9,'1','00001',2,'Changed trasvase_tunel_chonchano, chonchano_seishoras, chotano_estado_tiempo, reservorio_temperatura_05horas, reservorio_temperatura_13horas and reservorio_temperatura_19horas.');
/*!40000 ALTER TABLE `django_admin_log` ENABLE KEYS */;
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
