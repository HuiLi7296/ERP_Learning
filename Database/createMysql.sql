# ---------------------------------------------------------------------- #
# Script generated with: DeZign for Databases V7.3.4                     #
# Target DBMS:           MySQL 5                                         #
# Project file:          Project1.dez                                    #
# Project name:                                                          #
# Author:                                                                #
# Script type:           Database creation script                        #
# Created on:            2018-01-22 22:36                                #
# ---------------------------------------------------------------------- #


# ---------------------------------------------------------------------- #
# Tables                                                                 #
# ---------------------------------------------------------------------- #

# ---------------------------------------------------------------------- #
# Add table "Department"                                                 #
# ---------------------------------------------------------------------- #

CREATE TABLE `Department` (
    `DepartmentID` INTEGER NOT NULL AUTO_INCREMENT,
    `DepartmentName` VARCHAR(40) COLLATE Chinese_PRC_CI_AS NOT NULL,
    CONSTRAINT `PK_Department` PRIMARY KEY (`DepartmentID`)
);

# ---------------------------------------------------------------------- #
# Add table "Employee"                                                   #
# ---------------------------------------------------------------------- #

CREATE TABLE `Employee` (
    `EmployeeID` INTEGER NOT NULL AUTO_INCREMENT,
    `EmployeeName` VARCHAR(40) COLLATE Chinese_PRC_CI_AS NOT NULL,
    `IsActive` BIT NOT NULL,
    `IDNumber` VARCHAR(40) COLLATE Chinese_PRC_CI_AS COMMENT 'Identity Card Number ',
    `Gender` BIT NOT NULL COMMENT '0 is Woman, 1 is Man',
    `Email` VARCHAR(100) COLLATE Chinese_PRC_CI_AS,
    `Phone` VARCHAR(40) COLLATE Chinese_PRC_CI_AS,
    `Address` VARCHAR(200) COLLATE Chinese_PRC_CI_AS,
    `EntryDate` DATE NOT NULL DEFAULT getdate(),
    `ChangeDate` DATETIME DEFAULT getdate(),
    `DepartmentID` INTEGER NOT NULL,
    `BirthDay` DATE NOT NULL,
    `Position` VARCHAR(40) COLLATE Chinese_PRC_CI_AS,
    CONSTRAINT `PK_Employee` PRIMARY KEY (`EmployeeID`)
);

CREATE INDEX `IDX_Employee_1` ON `Employee` (`EmployeeName`);

CREATE UNIQUE INDEX `IDX_Employee_2` ON `Employee` (`IDNumber`);

# ---------------------------------------------------------------------- #
# Foreign key constraints                                                #
# ---------------------------------------------------------------------- #

ALTER TABLE `Employee` ADD CONSTRAINT `Department_Employee` 
    FOREIGN KEY (`DepartmentID`) REFERENCES `Department` (`DepartmentID`);
