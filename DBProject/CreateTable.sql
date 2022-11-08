create database if not exists AirlineReservationSystem;
use AirlineReservationSystem;
CREATE TABLE IF NOT EXISTS PassengerLogin (
    PLLoginID INT AUTO_INCREMENT PRIMARY KEY,
    PLUsername VARCHAR(30) NOT NULL UNIQUE,
    PLPassword VARCHAR(30) NOT NULL,
    CHECK (CHAR_LENGTH(PLPassword) >= 8)
);
CREATE TABLE IF NOT EXISTS Passenger (
    PID INT AUTO_INCREMENT PRIMARY KEY,
    PName VARCHAR(30),
    PPhone VARCHAR(10) NOT NULL,
    PCnic VARCHAR(13) NOT NULL,
    PStreet VARCHAR(30),
    PCity VARCHAR(30),
    PCountry VARCHAR(30),
    PLoginID INT NOT NULL,
    FOREIGN KEY (PLoginID)
        REFERENCES PassengerLogin (PLLoginID)
);
CREATE TABLE IF NOT EXISTS AirlineOperatorLogin (
    AOLoginID INT AUTO_INCREMENT PRIMARY KEY,
    AOUsername VARCHAR(30) NOT NULL UNIQUE,
    AOPassword VARCHAR(30) NOT NULL,
    CHECK (CHAR_LENGTH(AOPassword) >= 8)
);
CREATE TABLE IF NOT EXISTS AirlineOperator (
    AOMC INT PRIMARY KEY,
    AOLegalName VARCHAR(30) NOT NULL,
    AODBAName VARCHAR(30),
    AOPhone VARCHAR(10) NOT NULL,
    AOStreet VARCHAR(30) NOT NULL,
    AOCity VARCHAR(30) NOT NULL,
    AOCountry VARCHAR(30) NOT NULL,
    AOLoginID INT,
    FOREIGN KEY (AOLoginID)
        REFERENCES AirlineOperatorLogin (AOLoginID)
);
CREATE TABLE IF NOT EXISTS Airport (
    AID INT PRIMARY KEY,
    AName VARCHAR(30) NOT NULL,
    ANoofFlights INT
);
CREATE TABLE IF NOT EXISTS Flight (
    FID INT PRIMARY KEY,
    FName VARCHAR(30) NOT NULL UNIQUE,
    FNoofSeats INT NOT NULL,
    FSCity VARCHAR(30) NOT NULL,
    FSCountry VARCHAR(30) NOT NULL,
    FDCity VARCHAR(30) NOT NULL,
    FDCountry VARCHAR(30) NOT NULL,
    AOMC INT NOT NULL,
    FOREIGN KEY (AOMC) REFERENCES AirlineOperator(AOMC),
    CHECK (FNoofSeats > 1)
);
CREATE TABLE IF NOT EXISTS Route (
    RID INT AUTO_INCREMENT PRIMARY KEY,
    RCity VARCHAR(30)
);
CREATE TABLE IF NOT EXISTS FlightRoute (
    FlightID INT,
    RouteID INT,
    FOREIGN KEY (FlightID)
        REFERENCES Flight (FID),
    FOREIGN KEY (RouteID)
        REFERENCES Route (RID)
);
CREATE TABLE IF NOT EXISTS Timetable (
    TID INT AUTO_INCREMENT PRIMARY KEY,
    TArrivalTime DATETIME,
    TDepartTime DATETIME
);
CREATE TABLE IF NOT EXISTS AirportTimetable (
    TimetableID INT,
    AirportID INT,
    FOREIGN KEY (TimetableID)
        REFERENCES Timetable (TID),
    FOREIGN KEY (AirportID)
        REFERENCES Airport (AID)
);
CREATE TABLE IF NOT EXISTS FlightAirport (
    FlightID INT,
    AirportID INT,
    FOREIGN KEY (FlightID)
        REFERENCES Flight (FID),
    FOREIGN KEY (AirportID)
        REFERENCES Airport (AID)
);
CREATE TABLE IF NOT EXISTS Payment (
    Barcode INT AUTO_INCREMENT PRIMARY KEY,
    OTP INT NOT NULL
);
CREATE TABLE IF NOT EXISTS Ticket (
    TTicketNo INT AUTO_INCREMENT PRIMARY KEY,
    TPrice INT,
    TSeatNo INT,
    TPID INT,
    TFID INT,
    TBarcode INT,
    FOREIGN KEY (TPID)
        REFERENCES Passenger (PID),
    FOREIGN KEY (TFID)
        REFERENCES Flight (FID),
    FOREIGN KEY (TBarcode)
        REFERENCES Payment (Barcode)
);
CREATE TABLE IF NOT EXISTS CancelTicket (
    CTID INT AUTO_INCREMENT PRIMARY KEY,
    CTRefund INT,
    CTDeduct INT,
    CTCharges DECIMAL(3 , 2 ),
    CTTicketNo INT,
    FOREIGN KEY (CTTicketNo)
        REFERENCES Ticket (TTicketNo)
);
