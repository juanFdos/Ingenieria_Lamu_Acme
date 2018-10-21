/*
SQLyog Community v12.4.2 (64 bit)
MySQL - 5.7.23 : Database - lamu
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`lamu` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `lamu`;

/*Table structure for table `cliente` */

DROP TABLE IF EXISTS `cliente`;

CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `identificacion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `cliente` */

insert  into `cliente`(`idCliente`,`nombre`,`identificacion`) values 
(1,'Puma','123'),
(4,'Adidas','1234');

/*Table structure for table `cliente_listareproduccion` */

DROP TABLE IF EXISTS `cliente_listareproduccion`;

CREATE TABLE `cliente_listareproduccion` (
  `idCliente` int(11) NOT NULL,
  `idListaReproduccion` int(11) NOT NULL,
  PRIMARY KEY (`idCliente`,`idListaReproduccion`),
  KEY `fk_Cliente_has_ListaReproduccion_ListaReproduccion1_idx` (`idListaReproduccion`),
  KEY `fk_Cliente_has_ListaReproduccion_Cliente1_idx` (`idCliente`),
  CONSTRAINT `fk_Cliente_has_ListaReproduccion_Cliente1` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Cliente_has_ListaReproduccion_ListaReproduccion1` FOREIGN KEY (`idListaReproduccion`) REFERENCES `listareproduccion` (`idListaReproduccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `cliente_listareproduccion` */

/*Table structure for table `listareproduccion` */

DROP TABLE IF EXISTS `listareproduccion`;

CREATE TABLE `listareproduccion` (
  `idListaReproduccion` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`idListaReproduccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `listareproduccion` */

/*Table structure for table `listareproduccion_pista` */

DROP TABLE IF EXISTS `listareproduccion_pista`;

CREATE TABLE `listareproduccion_pista` (
  `idListaReproduccion` int(11) NOT NULL,
  `idPista` int(11) NOT NULL,
  PRIMARY KEY (`idListaReproduccion`,`idPista`),
  KEY `fk_ListaReproduccion_has_Pista_Pista1_idx` (`idPista`),
  KEY `fk_ListaReproduccion_has_Pista_ListaReproduccion1_idx` (`idListaReproduccion`),
  CONSTRAINT `fk_ListaReproduccion_has_Pista_ListaReproduccion1` FOREIGN KEY (`idListaReproduccion`) REFERENCES `listareproduccion` (`idListaReproduccion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ListaReproduccion_has_Pista_Pista1` FOREIGN KEY (`idPista`) REFERENCES `pista` (`idPista`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `listareproduccion_pista` */

/*Table structure for table `log` */

DROP TABLE IF EXISTS `log`;

CREATE TABLE `log` (
  `idlog` int(11) NOT NULL AUTO_INCREMENT,
  `accion` varchar(60) NOT NULL,
  `fecha` datetime NOT NULL,
  `usuario` varchar(45) NOT NULL,
  PRIMARY KEY (`idlog`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

/*Data for the table `log` */

insert  into `log`(`idlog`,`accion`,`fecha`,`usuario`) values 
(5,'Intento de autenticación con credenciales incorrectas','2018-10-21 13:17:51','root@localhost'),
(6,'Intento de autenticación con credenciales incorrectas','2018-10-21 13:18:24','root@localhost'),
(7,'Intento de autenticación con credenciales incorrectas','2018-10-21 13:23:25','root@localhost');

/*Table structure for table `pista` */

DROP TABLE IF EXISTS `pista`;

CREATE TABLE `pista` (
  `idPista` int(11) NOT NULL AUTO_INCREMENT,
  `titulo` varchar(45) NOT NULL,
  `subtitulo` varchar(45) NOT NULL,
  `interprete` varchar(45) NOT NULL,
  `genero` varchar(45) NOT NULL,
  PRIMARY KEY (`idPista`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `pista` */

/*Table structure for table `usuario` */

DROP TABLE IF EXISTS `usuario`;

CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `identificacion` varchar(45) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `contrasenia` varchar(45) NOT NULL,
  `idCliente` int(11) NOT NULL,
  PRIMARY KEY (`idUsuario`),
  KEY `fk_Usuario_Cliente_idx` (`idCliente`),
  CONSTRAINT `fk_Usuario_Cliente` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `usuario` */

insert  into `usuario`(`idUsuario`,`identificacion`,`nombre`,`contrasenia`,`idCliente`) values 
(1,'1234','juan','5678',1);

/* Trigger structure for table `cliente` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `Log_insertar_un_cliente` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `Log_insertar_un_cliente` AFTER INSERT ON `cliente` FOR EACH ROW 
    BEGIN
	INSERT INTO `log` (`accion`,`fecha`,`usuario`) 
		VALUES (CONCAT('Creación de un nuevo usuario con identificación = ',NEW.`identificacion`),SYSDATE(),USER() );
    END */$$


DELIMITER ;

/* Trigger structure for table `pista` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `Log_insertar_una_pista` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `Log_insertar_una_pista` AFTER INSERT ON `pista` FOR EACH ROW 
    BEGIN
	INSERT INTO `log` (`accion`,`fecha`,`usuario`) 
		VALUES (CONCAT('Creación de una nueva pista id = ',NEW.`idPista`),SYSDATE(),USER() );
    END */$$


DELIMITER ;

/* Trigger structure for table `usuario` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `Log_insertar_un_usuario` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `Log_insertar_un_usuario` AFTER INSERT ON `usuario` FOR EACH ROW 
    BEGIN
	INSERT INTO `log` (`accion`,`fecha`,`usuario`) 
		VALUES (CONCAT('Creación de un nuevo usuario con identificación = ',NEW.`identificacion`),SYSDATE(),USER() );
    END */$$


DELIMITER ;

/* Procedure structure for procedure `procedure_autenticar_Un_usuario` */

/*!50003 DROP PROCEDURE IF EXISTS  `procedure_autenticar_Un_usuario` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procedure_autenticar_Un_usuario`(in VCIDENTIFICACION VARCHAR(45), VCCONTRASENIA VARCHAR(45) )
BEGIN
	DECLARE CONTADOR INTEGER DEFAULT 0;
	
	SELECT COUNT(*) INTO CONTADOR
	FROM `usuario`
	WHERE `identificacion`=VCIDENTIFICACION AND `contrasenia`=VCCONTRASENIA;
	
	IF(CONTADOR = 0) THEN 
		INSERT INTO `log` (`accion`,`fecha`,`usuario`) 
		VALUES ('Intento de autenticación con credenciales incorrectas',SYSDATE(),USER() );
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Usuario y contraseña no coinciden';
		
	END IF;
	
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procedure_consultar_si_existe_una_pista` */

/*!50003 DROP PROCEDURE IF EXISTS  `procedure_consultar_si_existe_una_pista` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procedure_consultar_si_existe_una_pista`(IN NOMBRE VARCHAR(45), AUTOR VARCHAR(45) )
BEGIN
	DECLARE CONTADOR INTEGER DEFAULT 0;
	
	
	SELECT COUNT(*) INTO CONTADOR
	FROM PISTA 
	WHERE `titulo` = NOMBRE AND `interprete` = AUTOR;
	
	
	 IF(CONTADOR = 1) THEN 
		INSERT INTO `log` (`accion`,`fecha`,`usuario`) 
		VALUES ('Intento inserción pista ya existente',SYSDATE(),USER() );
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Pista ya existe en base de datos';
		
	END IF;

	END */$$
DELIMITER ;

/* Procedure structure for procedure `procedure_consultar_si_existe_un_cliente` */

/*!50003 DROP PROCEDURE IF EXISTS  `procedure_consultar_si_existe_un_cliente` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procedure_consultar_si_existe_un_cliente`(IN NIT VARCHAR(45))
BEGIN
	DECLARE CONTADOR INTEGER DEFAULT 0;
	
	
	SELECT COUNT(*) INTO CONTADOR
	FROM CLIENTE 
	WHERE `identificacion` = NIT;
	
	 IF(CONTADOR = 1) THEN 
		INSERT INTO `log` (`accion`,`fecha`,`usuario`) 
		VALUES ('Intento inserción cliente ya existente',SYSDATE(),USER() );
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Cliente ya existe en base de datos';
		
	END IF;

	END */$$
DELIMITER ;

/* Procedure structure for procedure `procedure_consultar_si_existe_un_usuario` */

/*!50003 DROP PROCEDURE IF EXISTS  `procedure_consultar_si_existe_un_usuario` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procedure_consultar_si_existe_un_usuario`(in NIT varchar(45))
BEGIN
	DECLARE CONTADOR INTEGER DEFAULT 0;
	
	
	SELECT COUNT(*) INTO CONTADOR
	FROM USUARIO 
	WHERE `identificacion` = NIT;
	
	 IF(CONTADOR = 1) THEN 
		INSERT INTO `log` (`accion`,`fecha`,`usuario`) 
		VALUES ('Intento inserción usuario ya existente',SYSDATE(),USER() );
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Usuario ya existe en base de datos';
		
	END IF;

	END */$$
DELIMITER ;

/* Procedure structure for procedure `procedure_crear_un_log` */

/*!50003 DROP PROCEDURE IF EXISTS  `procedure_crear_un_log` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procedure_crear_un_log`(IN VSACCION VARCHAR(60) )
BEGIN
	INSERT INTO `log`(`accion`,`fecha`,`usuario`) 
		VALUES (VSACCION,SYSDATE(),USER() );
	END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
