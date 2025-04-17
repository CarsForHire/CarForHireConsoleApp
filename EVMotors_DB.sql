--README
-- Create the database with the name EVMotors_DB
-- Execute the SQL Query below to set up the table
-- You will have EVMotors table once successfully

--USE EVMotors_DB;

CREATE DATABASE EVMotors_DB;
GO

USE EVMotors_DB;
GO

CREATE TABLE EVMotors 
(VehicleRegNo VARCHAR(10) PRIMARY KEY, 
VehicleMake VARCHAR(50) NOT NULL, 
VehicleEngineSize VARCHAR(10) NOT NULL, 
DateRegistered DATE DEFAULT GETDATE(),
RentPerDay DECIMAL(10,2) CHECK (RentPerDay > 0),
Available VARCHAR(3) NOT NULL);



INSERT INTO EVMotors(VehicleRegNo,VehicleMake,VehicleEngineSize,DateRegistered,RentPerDay,Available)
VALUES ('171D12345', 'Toyota', '1.6L', '2023-10-01', 49.99, 'Yes');