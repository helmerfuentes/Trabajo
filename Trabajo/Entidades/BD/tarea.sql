DROP TABLE IF EXISTS `estudiantes`;
CREATE TABLE `estudiantes` (
  `idestudiante` int(11) NOT NULL AUTO_INCREMENT,
  `idprogramas` int(11) DEFAULT NULL,
  `identificacion` varchar(12) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idestudiante`),
  KEY `idprogramas` (`idprogramas`),
  CONSTRAINT `estudiantes_ibfk_1` FOREIGN KEY (`idprogramas`) REFERENCES `programas` (`Idprogramas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "estudiantes"
#


#
# Structure for table "programas"
#

DROP TABLE IF EXISTS `programas`;
CREATE TABLE `programas` (
  `Idprogramas` int(11) NOT NULL AUTO_INCREMENT,
  `programa` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Idprogramas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "programas"
#


#
# Structure for table "asignaturas"
#

DROP TABLE IF EXISTS `asignaturas`;
CREATE TABLE `asignaturas` (
  `idasignaturas` int(11) NOT NULL AUTO_INCREMENT,
  `idprogramas` int(11) DEFAULT NULL,
  `codigo` varchar(5) DEFAULT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idasignaturas`),
  KEY `idprogramas` (`idprogramas`),
  CONSTRAINT `asignaturas_ibfk_1` FOREIGN KEY (`idprogramas`) REFERENCES `programas` (`Idprogramas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "asignaturas"
#


#
# Structure for table "grupos"
#

DROP TABLE IF EXISTS `grupos`;
CREATE TABLE `grupos` (
  `idgrupos` int(11) NOT NULL AUTO_INCREMENT,
  `idasignatura` int(11) DEFAULT NULL,
  `codigo` int(2) DEFAULT NULL,
  PRIMARY KEY (`idgrupos`),
  KEY `idasignatura` (`idasignatura`),
  CONSTRAINT `grupos_ibfk_1` FOREIGN KEY (`idasignatura`) REFERENCES `asignaturas` (`idasignaturas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "grupos"
#


#
# Structure for table "matriculas"
#

DROP TABLE IF EXISTS `matriculas`;
CREATE TABLE `matriculas` (
  `idmatriculas` int(11) NOT NULL AUTO_INCREMENT,
  `idestudiante` int(11) DEFAULT NULL,
  `idgrupo` int(11) DEFAULT NULL,
  PRIMARY KEY (`idmatriculas`),
  KEY `idestudiante` (`idestudiante`),
  KEY `idgrupo` (`idgrupo`),
  CONSTRAINT `matriculas_ibfk_1` FOREIGN KEY (`idestudiante`) REFERENCES `estudiantes` (`idestudiante`),
  CONSTRAINT `matriculas_ibfk_2` FOREIGN KEY (`idgrupo`) REFERENCES `grupos` (`idgrupos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "matriculas"
#


#
# Structure for table "hrario"
#

DROP TABLE IF EXISTS `hrario`;
CREATE TABLE `hrario` (
  `idhorarios` int(11) NOT NULL AUTO_INCREMENT,
  `dia` varchar(10) DEFAULT NULL,
  `horainicio` time DEFAULT NULL,
  `horafin` time DEFAULT NULL,
  `idgrupo` int(11) DEFAULT NULL,
  PRIMARY KEY (`idhorarios`),
  KEY `idgrupo` (`idgrupo`),
  CONSTRAINT `hrario_ibfk_1` FOREIGN KEY (`idgrupo`) REFERENCES `grupos` (`idgrupos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "hrario"
#

