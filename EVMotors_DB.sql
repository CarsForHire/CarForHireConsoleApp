--README
-- Create the database with the name EVMotors_DB
-- Execute the SQL Query below to set up the table
-- You will have EVMotors table once successfully

USE EVMotors_DB;

CREATE TABLE EVMotors 
(VehicleRegNo VARCHAR(10) PRIMARY KEY, 
VehicleMake VARCHAR(50) NOT NULL, 
VehicleEngineSize VARCHAR(10) NOT NULL, 
DateRegistered DATE DEFAULT GETDATE(),
RentPerDay DECIMAL(10,2) CHECK (RentPerDay > 0),
Available VARCHAR(3) NOT NULL)
