-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: airlinereservationsystem
-- ------------------------------------------------------
-- Server version	8.0.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `airlineoperator`
--

DROP TABLE IF EXISTS `airlineoperator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `airlineoperator` (
  `AOMC` int NOT NULL,
  `AOLegalName` varchar(30) NOT NULL,
  `AODBAName` varchar(30) DEFAULT NULL,
  `AOPhone` varchar(10) NOT NULL,
  `AOStreet` varchar(30) NOT NULL,
  `AOCity` varchar(30) NOT NULL,
  `AOCountry` varchar(30) NOT NULL,
  `AOLoginID` int DEFAULT NULL,
  PRIMARY KEY (`AOMC`),
  KEY `AOLoginID` (`AOLoginID`),
  CONSTRAINT `airlineoperator_ibfk_1` FOREIGN KEY (`AOLoginID`) REFERENCES `airlineoperatorlogin` (`AOLoginID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `airlineoperator`
--

LOCK TABLES `airlineoperator` WRITE;
/*!40000 ALTER TABLE `airlineoperator` DISABLE KEYS */;
INSERT INTO `airlineoperator` VALUES (12390672,'Muneeb LLC','Keep Flying High','3214190500','149 M1 Lake City ','Raiwind Road, Lahore  55150','Pakistan',1);
/*!40000 ALTER TABLE `airlineoperator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `airlineoperatorlogin`
--

DROP TABLE IF EXISTS `airlineoperatorlogin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `airlineoperatorlogin` (
  `AOLoginID` int NOT NULL AUTO_INCREMENT,
  `AOUsername` varchar(30) NOT NULL,
  `AOPassword` varchar(30) NOT NULL,
  PRIMARY KEY (`AOLoginID`),
  UNIQUE KEY `AOUsername` (`AOUsername`),
  CONSTRAINT `airlineoperatorlogin_chk_1` CHECK ((char_length(`AOPassword`) >= 8))
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `airlineoperatorlogin`
--

LOCK TABLES `airlineoperatorlogin` WRITE;
/*!40000 ALTER TABLE `airlineoperatorlogin` DISABLE KEYS */;
INSERT INTO `airlineoperatorlogin` VALUES (1,'moneeb','moneeb123');
/*!40000 ALTER TABLE `airlineoperatorlogin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `airport`
--

DROP TABLE IF EXISTS `airport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `airport` (
  `AID` int NOT NULL,
  `AName` varchar(30) NOT NULL,
  `ANoofFlights` int DEFAULT NULL,
  PRIMARY KEY (`AID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `airport`
--

LOCK TABLES `airport` WRITE;
/*!40000 ALTER TABLE `airport` DISABLE KEYS */;
INSERT INTO `airport` VALUES (1,'Allama-Iqbal Lahore Airport',200),(2,'Quaid-e-Azam Karachi Airport',300),(3,'Skardu International Airport',100);
/*!40000 ALTER TABLE `airport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `airporttimetable`
--

DROP TABLE IF EXISTS `airporttimetable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `airporttimetable` (
  `TimetableID` int DEFAULT NULL,
  `AirportID` int DEFAULT NULL,
  KEY `TimetableID` (`TimetableID`),
  KEY `AirportID` (`AirportID`),
  CONSTRAINT `airporttimetable_ibfk_1` FOREIGN KEY (`TimetableID`) REFERENCES `timetable` (`TID`),
  CONSTRAINT `airporttimetable_ibfk_2` FOREIGN KEY (`AirportID`) REFERENCES `airport` (`AID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `airporttimetable`
--

LOCK TABLES `airporttimetable` WRITE;
/*!40000 ALTER TABLE `airporttimetable` DISABLE KEYS */;
INSERT INTO `airporttimetable` VALUES (1,1),(2,2),(3,3),(4,1),(5,2);
/*!40000 ALTER TABLE `airporttimetable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cancelticket`
--

DROP TABLE IF EXISTS `cancelticket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cancelticket` (
  `CTID` int NOT NULL AUTO_INCREMENT,
  `CTRefund` int DEFAULT NULL,
  `CTDeduct` int DEFAULT NULL,
  `CTCharges` decimal(3,2) DEFAULT NULL,
  `CTTicketNo` int DEFAULT NULL,
  PRIMARY KEY (`CTID`),
  KEY `CTTicketNo` (`CTTicketNo`),
  CONSTRAINT `cancelticket_ibfk_1` FOREIGN KEY (`CTTicketNo`) REFERENCES `ticket` (`TTicketNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cancelticket`
--

LOCK TABLES `cancelticket` WRITE;
/*!40000 ALTER TABLE `cancelticket` DISABLE KEYS */;
/*!40000 ALTER TABLE `cancelticket` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `flight`
--

DROP TABLE IF EXISTS `flight`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `flight` (
  `FID` int NOT NULL,
  `FName` varchar(30) NOT NULL,
  `FNoofSeats` int NOT NULL,
  `FSCity` varchar(30) NOT NULL,
  `FSCountry` varchar(30) NOT NULL,
  `FDCity` varchar(30) NOT NULL,
  `FDCountry` varchar(30) NOT NULL,
  `AOMC` int NOT NULL,
  PRIMARY KEY (`FID`),
  UNIQUE KEY `FName` (`FName`),
  KEY `AOMC` (`AOMC`),
  CONSTRAINT `flight_ibfk_1` FOREIGN KEY (`AOMC`) REFERENCES `airlineoperator` (`AOMC`),
  CONSTRAINT `flight_chk_1` CHECK ((`FNoofSeats` > 1))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flight`
--

LOCK TABLES `flight` WRITE;
/*!40000 ALTER TABLE `flight` DISABLE KEYS */;
INSERT INTO `flight` VALUES (1,'LHR to KRC',200,'Lahore','Pakistan','Karachi','Pakistan',12390672),(2,'KRC to SKD',200,'Karachi','Pakistan','Skardo','Pakistan',12390672),(3,'SKR to KRC',149,'Skardo','Pakistan','Karachi','Pakistan',12390672),(4,'LHR to SKR',198,'Lahore','Pakistan','Karachi','Pakistan',12390672),(5,'KRC to LHR',199,'Karachi','Pakistan','Lahore','Pakistan',12390672);
/*!40000 ALTER TABLE `flight` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `flightairport`
--

DROP TABLE IF EXISTS `flightairport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `flightairport` (
  `FlightID` int DEFAULT NULL,
  `AirportID` int DEFAULT NULL,
  KEY `FlightID` (`FlightID`),
  KEY `AirportID` (`AirportID`),
  CONSTRAINT `flightairport_ibfk_1` FOREIGN KEY (`FlightID`) REFERENCES `flight` (`FID`),
  CONSTRAINT `flightairport_ibfk_2` FOREIGN KEY (`AirportID`) REFERENCES `airport` (`AID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flightairport`
--

LOCK TABLES `flightairport` WRITE;
/*!40000 ALTER TABLE `flightairport` DISABLE KEYS */;
INSERT INTO `flightairport` VALUES (1,1),(2,2),(3,3),(4,1),(5,2);
/*!40000 ALTER TABLE `flightairport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `flightroute`
--

DROP TABLE IF EXISTS `flightroute`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `flightroute` (
  `FlightID` int DEFAULT NULL,
  `RouteID` int DEFAULT NULL,
  KEY `FlightID` (`FlightID`),
  KEY `RouteID` (`RouteID`),
  CONSTRAINT `flightroute_ibfk_1` FOREIGN KEY (`FlightID`) REFERENCES `flight` (`FID`),
  CONSTRAINT `flightroute_ibfk_2` FOREIGN KEY (`RouteID`) REFERENCES `route` (`RID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flightroute`
--

LOCK TABLES `flightroute` WRITE;
/*!40000 ALTER TABLE `flightroute` DISABLE KEYS */;
/*!40000 ALTER TABLE `flightroute` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `passenger`
--

DROP TABLE IF EXISTS `passenger`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `passenger` (
  `PID` int NOT NULL AUTO_INCREMENT,
  `PName` varchar(30) DEFAULT NULL,
  `PPhone` varchar(10) NOT NULL,
  `PCnic` varchar(13) NOT NULL,
  `PStreet` varchar(30) DEFAULT NULL,
  `PCity` varchar(30) DEFAULT NULL,
  `PCountry` varchar(30) DEFAULT NULL,
  `PLoginID` int NOT NULL,
  PRIMARY KEY (`PID`),
  KEY `PLoginID` (`PLoginID`),
  CONSTRAINT `passenger_ibfk_1` FOREIGN KEY (`PLoginID`) REFERENCES `passengerlogin` (`PLLoginID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `passenger`
--

LOCK TABLES `passenger` WRITE;
/*!40000 ALTER TABLE `passenger` DISABLE KEYS */;
/*!40000 ALTER TABLE `passenger` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `passengerlogin`
--

DROP TABLE IF EXISTS `passengerlogin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `passengerlogin` (
  `PLLoginID` int NOT NULL AUTO_INCREMENT,
  `PLUsername` varchar(30) NOT NULL,
  `PLPassword` varchar(30) NOT NULL,
  PRIMARY KEY (`PLLoginID`),
  UNIQUE KEY `PLUsername` (`PLUsername`),
  CONSTRAINT `passengerlogin_chk_1` CHECK ((char_length(`PLPassword`) >= 8))
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `passengerlogin`
--

LOCK TABLES `passengerlogin` WRITE;
/*!40000 ALTER TABLE `passengerlogin` DISABLE KEYS */;
/*!40000 ALTER TABLE `passengerlogin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment` (
  `Barcode` int NOT NULL,
  `OTP` int NOT NULL,
  PRIMARY KEY (`Barcode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` VALUES (1,5942),(2,3538),(3,1322),(4,9295),(5,9485),(6,8338),(7,6172);
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `route`
--

DROP TABLE IF EXISTS `route`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `route` (
  `RID` int NOT NULL AUTO_INCREMENT,
  `RCity` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`RID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `route`
--

LOCK TABLES `route` WRITE;
/*!40000 ALTER TABLE `route` DISABLE KEYS */;
/*!40000 ALTER TABLE `route` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ticket`
--

DROP TABLE IF EXISTS `ticket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ticket` (
  `TTicketNo` int NOT NULL AUTO_INCREMENT,
  `TPrice` int DEFAULT NULL,
  `TSeatNo` int DEFAULT NULL,
  `TPID` int DEFAULT NULL,
  `TFID` int DEFAULT NULL,
  `TBarcode` int DEFAULT NULL,
  PRIMARY KEY (`TTicketNo`),
  KEY `TPID` (`TPID`),
  KEY `TFID` (`TFID`),
  KEY `TBarcode` (`TBarcode`),
  CONSTRAINT `ticket_ibfk_1` FOREIGN KEY (`TPID`) REFERENCES `passenger` (`PID`),
  CONSTRAINT `ticket_ibfk_2` FOREIGN KEY (`TFID`) REFERENCES `flight` (`FID`),
  CONSTRAINT `ticket_ibfk_3` FOREIGN KEY (`TBarcode`) REFERENCES `payment` (`Barcode`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticket`
--

LOCK TABLES `ticket` WRITE;
/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;
/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `timetable`
--

DROP TABLE IF EXISTS `timetable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `timetable` (
  `TID` int NOT NULL AUTO_INCREMENT,
  `TArrivalTime` datetime DEFAULT NULL,
  `TDepartTime` datetime DEFAULT NULL,
  PRIMARY KEY (`TID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `timetable`
--

LOCK TABLES `timetable` WRITE;
/*!40000 ALTER TABLE `timetable` DISABLE KEYS */;
INSERT INTO `timetable` VALUES (1,'2022-07-05 00:00:00','2022-07-05 00:00:00'),(2,'2022-07-05 00:00:00','2022-07-05 00:00:00'),(3,'2022-07-08 00:00:00','2022-07-05 00:00:00'),(4,'2022-07-05 12:00:59','2022-07-05 08:00:59'),(5,'2022-08-05 22:22:13','2022-07-05 09:22:13');
/*!40000 ALTER TABLE `timetable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'airlinereservationsystem'
--
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete_adminAirport` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete_adminAirport`(
in id int
)
BEGIN
delete from Airport where AID=id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete_airlineOperator` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete_airlineOperator`(
IN mcNo int
)
BEGIN
    declare loginID int;
        
    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
    BEGIN
          ROLLBACK;
    END;

    START TRANSACTION;
        select AOLoginID into loginID from AirlineOperator where AOMC=mcNo;
        delete from AirlineOperator where AOMC=mcNo;
		delete from AirlineOperatorLogin where AOLoginID=loginID;

    COMMIT;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete_flight` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete_flight`(
IN lusername varchar(30),
IN fID int
)
BEGIN
    declare tid int;
	declare aid int;
    declare rid int;
    
    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
    BEGIN
          ROLLBACK;
    END;

    START TRANSACTION;
        select AirportID into aid from FlightAirport where FlightAirport.FlightID=fID;
		select TimetableID into tid from AirportTimetable where AirportTimetable.AirportID=aid;
        select RouteID into rid where FlightRoute.FlightID=fID;
        delete from FlightRoute where FlightID=fID;
        delete from Route where Route.RID=rid; 
		delete from Timetable where TID=tid;
		delete from AirportTimetable where TimetableID=tid and AirportID=aid;
		delete from FlightAirport where FlightID=fID and AirportID=aid;
		delete from Flight where Flight.FID=fID;
    COMMIT;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete_passenger` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete_passenger`(
IN cnic varchar(13)
)
BEGIN
    declare loginid int;

    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
    BEGIN
          ROLLBACK;
    END;

    START TRANSACTION;

		select PLoginID into loginid from Passenger where PCnic=cnic;
		delete from Passenger where PCnic=cnic;
		delete from PassengerLogin where PLLoginID=loginid;

    COMMIT;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete_passengerTicket` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete_passengerTicket`(
in tid int
)
BEGIN
    declare barcodeid int;
	declare flightid int;
    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
    BEGIN
          ROLLBACK;
    END;

    START TRANSACTION;
		select TFID into flightid from Ticket where TTicketNo=tid;
		SELECT TBarcode INTO barcodeid FROM Ticket WHERE TTicketNo = tid;
		DELETE FROM Payment WHERE Barcode = barcodeid;
		DELETE FROM Ticket WHERE TTicketNo = tid;
		update Flight set FNoofSeats = FNoofSeats + 1 where FID=flightid;
    COMMIT;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_display_adminAirline` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_display_adminAirline`()
BEGIN
select * from AirlineOperator INNER JOIN AirlineOperatorLogin on AirlineOperator.AOLoginID=AirlineOperatorLogin.AOLoginID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_display_adminPassenger` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_display_adminPassenger`()
BEGIN
select * from Passenger Inner Join PassengerLogin on PassengerLogin.PLLoginID=Passenger.PLoginID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_display_admin_airport` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_display_admin_airport`()
BEGIN
select * from Airport;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_display_airlineOperator_flight` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_display_airlineOperator_flight`(
IN lusername varchar(30)
)
BEGIN
select FID, FName, FNoofSeats,FSCity, FSCountry, FDCity, FDCountry, TDepartTime, TArrivalTime from Flight 
INNER JOIN FlightAirport ON Flight.FID=FlightAirport.FlightID 
INNER JOIN AirportTimetable ON FlightAirport.AirportID=AirportTimetable.AirportID 
INNER JOIN Timetable ON AirportTimetable.TimetableID=Timetable.TID
INNER JOIN AirlineOperator ON AirlineOperator.AOMC=Flight.AOMC
INNER JOIN AirlineOperatorLogin ON AirlineOperatorLogin.AOLoginID=AirlineOperator.AOLoginID
where AirlineOperatorLogin.AOUsername=lusername;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_display_cancelPassengerAvailableFlights` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_display_cancelPassengerAvailableFlights`(
IN pusername varchar(30)
)
BEGIN
declare num int;
declare id int;
SELECT 
    PLLoginID
INTO num FROM
    PassengerLogin
WHERE
    PLUsername = pusername;
SELECT 
    PID
INTO id FROM
    Passenger
WHERE
    PLoginID = num;
SELECT 
    Ticket.TTicketNo,
    Flight.FID,
    Flight.FName,
    Flight.FSCity,
    Flight.FSCountry,
    Flight.FDCity,
    Flight.FDCountry,
    Timetable.TDepartTime
FROM
    Flight
        INNER JOIN
    FlightAirport ON Flight.FID = FlightAirport.FlightID
        INNER JOIN
    AirportTimetable ON FlightAirport.AirportID = AirportTimetable.AirportID
        INNER JOIN
    Timetable ON AirportTimetable.TimetableID = Timetable.TID
        INNER JOIN
    Ticket ON Ticket.TFID = Flight.FID
WHERE
    Ticket.TPID = id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_display_passengerAvailableFlights` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_display_passengerAvailableFlights`(
)
BEGIN
select Flight.FID, Flight.FName, Flight.FSCity, Flight.FSCountry, 
Flight.FDCity, Flight.FDCountry, Timetable.TDepartTime, Flight.FNoofSeats
from Flight 
INNER JOIN FlightAirport ON Flight.FID=FlightAirport.FlightID 
INNER JOIN AirportTimetable ON FlightAirport.AirportID=AirportTimetable.AirportID 
INNER JOIN Timetable ON AirportTimetable.TimetableID=Timetable.TID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_display_passengerBookedTicket` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_display_passengerBookedTicket`(
in cnic varchar(30)
)
BEGIN
declare passID int;
select PID into passID from Passenger where PCnic=cnic;
select Flight.FID, Flight.FName, Flight.FSCity, Flight.FSCountry, 
Flight.FDCity, Flight.FDCountry, Timetable.TDepartTime
from Flight 
INNER JOIN FlightAirport ON Flight.FID=FlightAirport.FlightID 
INNER JOIN AirportTimetable ON FlightAirport.AirportID=AirportTimetable.AirportID 
INNER JOIN Timetable ON AirportTimetable.TimetableID=Timetable.TID
INNER JOIN Ticket ON Ticket.TFID=Flight.FID
where Ticket.TPID=passID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_display_passengerTicket` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_display_passengerTicket`(
in pusername varchar(30)
)
BEGIN
select Flight.FID, Flight.FName, Flight.FSCity, Flight.FSCountry, 
Flight.FDCity, Flight.FDCountry, Timetable.TDepartTime
from Flight INNER JOIN FlightAirport ON Flight.FID=FlightAirport.FlightID INNER JOIN 
AirportTimetable ON FlightAirport.AirportID=AirportTimetable.AirportID INNER JOIN Timetable ON
AirportTimetable.TimetableID=Timetable.TID INNER JOIN Ticket ON Ticket.TFID=Flight.FID INNER JOIN
Passenger ON Passenger.PID=Ticket.TTicketNo INNER JOIN PassengerLogin ON 
PassengerLogin.PLLoginID=Passenger.PLoginID where PassengerLogin.PLUsername=pusername;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_get_airlineOperator_flight` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_get_airlineOperator_flight`(
IN lusername varchar(30)
)
BEGIN
declare loginid int;
declare mc int;
select AOLoginID into loginid from AirlineOperatorLogin where AOUsername=lusername;
select AOMC into mc from AirlineOperator where AOLoginID=loginid;
select * from Flight where AOMC=mc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_get_airlineOperator_info` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_get_airlineOperator_info`(
OUT MC int, 
OUT LegalName varchar(30) ,
OUT DBAName varchar(30),
OUT Phone varchar(10),
OUT Street varchar(30),
OUT City varchar(30),
OUT Country varchar(30),
IN lusername varchar(30),
OUT lpassword varchar(30)
)
BEGIN
select AirlineOperator.AOMC, AirlineOperator.AOLegalName, AirlineOperator.AODBAName, AirlineOperator.AOPhone,
AirlineOperator.AOStreet, AirlineOperator.AOCity, AirlineOperator.AOCountry, AirlineOperatorLogin.AOPassword 
into MC, LegalName, DBAName, Phone, Street, City, Country, lpassword 
from AirlineOperator left join AirlineOperatorLogin on AirlineOperator.AOLoginID=AirlineOperatorLogin.AOLoginID
where AirlineOperatorLogin.AOUsername=lusername;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_get_airportID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_get_airportID`()
BEGIN
select AID from Airport;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_get_passenger_info` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_get_passenger_info`(
OUT psname varchar(30),
OUT phone varchar(10),
OUT cnic varchar(13),
OUT street varchar(30),
OUT city varchar(30),
OUT country varchar(30), 
IN lusername varchar(30),
OUT lpassword varchar(30)
)
BEGIN
select Passenger.PName, Passenger.PPhone, Passenger.PCnic,
Passenger.PStreet, Passenger.PCity, Passenger.PCountry, PassengerLogin.PLPassword 
into psname, phone, cnic, street, city, country, lpassword
from Passenger left join PassengerLogin on PassengerLogin.PLLoginID=Passenger.PLoginID
where PassengerLogin.PLUsername=lusername;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insert_adminAirport` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_adminAirport`(
in id int,
in name varchar(30),
in noofflight int
)
BEGIN
insert into Airport values (id, name, noofflight);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insert_airlineOperator` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_airlineOperator`(
IN mcNo int,
IN legalName varchar(30),
IN dbaName varchar(30),
IN phone varchar(10),
IN street varchar(30),
IN city varchar(30),
IN country varchar(30),
IN lusername varchar(30),
IN lpassword varchar(30)
)
BEGIN
    declare num int default 0;
    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
    BEGIN
          ROLLBACK;
    END;

    START TRANSACTION;

	select count(AirlineOperatorLogin.AOLoginID) + 1 into num from AirlineOperatorLogin;
	insert into AirlineOperatorLogin values (num, lusername, lpassword);
	insert into AirlineOperator values (mcNo, legalName, dbaName, phone, street, city, country, num);

    COMMIT;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insert_flight` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_flight`(
IN lusername varchar(30),
IN fID int,
IN fName varchar(30),
IN NoofSeats int,
IN SCity varchar(30),
IN SCountry varchar(30), 
IN DCity varchar(30),
IN DCountry varchar(30),
IN DDate datetime,
IN ADate datetime,
IN aaid int
)
BEGIN
    declare num int default 0;
    declare loginid int;
    declare mc int;
    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
    BEGIN
          ROLLBACK;
    END;

    START TRANSACTION;

	select AOLoginID into loginid from AirlineOperatorLogin where AOUsername=lusername;
	select AOMC into mc from AirlineOperator where AOLoginID=loginid;
	select count(TID) + 1 into num from Timetable;
    
	insert into Flight (FID, FName, FNoofSeats,FSCity, FSCountry, FDCity, FDCountry, AOMC) values (fid, fname, NoofSeats, SCity, SCountry, DCity, DCountry, mc);
	insert into FlightAirport (FlightID, AirportID) values (fid, aaid);
    insert into AirportTimetable values (aaid, num);
    insert into Timetable values (num, ADate, DDate);
    
    COMMIT;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insert_passenger` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_passenger`(
IN pname varchar(30),
IN pphone varchar(10), 
IN pcnic varchar(13), 
IN pstreet varchar(30),
IN pcity varchar(30), 
IN pcountry varchar(30), 
IN lusername varchar(30),
IN lpassword varchar(30))
BEGIN

    declare num int default 0;
    declare num2 int default 0;

    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
    BEGIN
          ROLLBACK;
    END;

    START TRANSACTION;

	select count(PID) + 1 into num2 from Passenger;
	select count(PLLoginID) + 1 into num from PassengerLogin;
	insert into PassengerLogin values (num, lusername, lpassword);
	insert into Passenger values (num2, pname, pphone, pcnic, pstreet, pcity, pcountry, num);

    COMMIT;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insert_passengerTicket` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_passengerTicket`(
tprice INT,
tseatno INT,
pusername varchar(30),
tfid INT,
otp INT
)
BEGIN
    declare ticketNo int default 0;
    declare tbarcode int default 0;
    declare passID int;

    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
    BEGIN
          ROLLBACK;
    END;

    START TRANSACTION;

		SELECT COUNT(Barcode) + 1 INTO tbarcode FROM Payment;
		insert into Payment values (tbarcode, otp);
		update Flight set FNoofSeats = FNoofSeats - 1 where FID=tfid;
		SELECT Passenger.PID INTO passID FROM Passenger INNER JOIN PassengerLogin ON PassengerLogin.PLLoginID = Passenger.PLoginID WHERE PassengerLogin.PLUsername = pusername;
		SELECT COUNT(TTicketNo) + 1 INTO ticketNo FROM Ticket;
		insert into Ticket values (ticketNo, tprice, tseatno, passID, tfid, tbarcode);

    COMMIT;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_search_airlineOperator` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_search_airlineOperator`(
IN lusername varchar(30),
IN lpassword varchar(30),
OUT access int
)
BEGIN
select COUNT(*) into access from AirlineOperatorLogin 
where lusername=AOUsername AND lpassword=AOPassword;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_search_passenger` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_search_passenger`(
IN lusername varchar(30),
IN lpassword varchar(30),
OUT access int
)
BEGIN
select COUNT(*) into access from PassengerLogin 
where lusername=PLUsername AND lpassword=PLPassword;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_search_passengerAvailableFlights` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_search_passengerAvailableFlights`(
in scity varchar(30),
in scountry varchar(30), 
in dcity varchar(30),
in dcountry varchar(30),
in ddate datetime 
)
BEGIN
select Flight.FID, Flight.FName, Flight.FSCity, Flight.FSCountry, 
Flight.FDCity, Flight.FDCountry, Timetable.TDepartTime
from Flight 
INNER JOIN FlightAirport ON Flight.FID=FlightAirport.FlightID 
INNER JOIN AirportTimetable ON FlightAirport.AirportID=AirportTimetable.AirportID INNER JOIN Timetable ON AirportTimetable.TimetableID=Timetable.TID 
where (Flight.FSCity=scity and Flight.FSCountry=scountry and Flight.FDCity=dcity and Flight.FDCountry=dcountry and Timetable.TDepartTime=ddate);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_update_adminAirport` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_adminAirport`(
in id int,
in name varchar(30),
in noofflight int
)
BEGIN
update Airport set AName=name, ANoofFlights=noofflight where AID=id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_update_airlineOperator` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_airlineOperator`(
IN mcNo int, 
IN legalName varchar(30),
IN dbaName varchar(30),
IN phone varchar(10),
IN street varchar(30),
IN city varchar(30),
IN country varchar(30),
IN lusername varchar(30),
IN lpassword varchar(30)
)
BEGIN
    declare num int;

    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
    BEGIN
          ROLLBACK;
    END;

    START TRANSACTION;

	select AOLoginID into num from AirlineOperator where AOMC=mcNo;
	update AirlineOperator set AOLegalName=legalName,AODBAName=dbaName,AOPhone=phone,AOStreet=street,AOCity=city,AOCountry=country where AOMC=mcNo;
	update AirlineOperatorLogin set AOUsername=lusername, AOPassword=lpassword where AirlineOperatorLogin.AOLoginID=num;

    COMMIT;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_update_flight` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_flight`(
IN lusername varchar(30),
IN fID int,
IN fName varchar(30),
IN NoofSeats int,
IN SCity varchar(30),
IN SCountry varchar(30), 
IN DCity varchar(30),
IN DCountry varchar(30),
IN DDate datetime,
IN ADate datetime,
IN aaid int
)
BEGIN
    declare num int default 0;
    declare loginid int;
    declare mc int;

    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
    BEGIN
          ROLLBACK;
    END;

    START TRANSACTION;

	select TimetableID into num from AirportTimetable where AirportID=aaid;
    
	update Flight set FName=fname, FNoofSeats=NoofSeats,FSCity=SCity, FSCountry=SCountry, FDCity=DCity, FDCountry=DCountry where FID=fid;
	update FlightAirport set AirportID=aaid where FlightID=fid;
    update AirportTimetable set AirportID=aaid where TimetableID=num;
    update Timetable set TArrivalTime=ADate,TDepartTime=DDate where TID=num;

    COMMIT;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_update_passenger` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_passenger`(
IN pname varchar(30),
IN pphone varchar(10), 
IN pcnic varchar(13), 
IN pstreet varchar(30),
IN pcity varchar(30), 
IN pcountry varchar(30), 
IN lusername varchar(30),
IN lpassword varchar(30)
)
BEGIN
    declare loginid int;

    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
    BEGIN
          ROLLBACK;
    END;

    START TRANSACTION;

	select PLLoginID into loginid from PassengerLogin where PLUsername=lusername;
	update PassengerLogin set PLPassword=lpassword where PLUsername=lusername;
	update Passenger set PName=pname,PPhone=pphone,PCnic=pcnic, PStreet=pstreet,PCity=pcity,PCountry=pcountry where PLoginID=loginid;

    COMMIT;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-07-11 20:02:41
