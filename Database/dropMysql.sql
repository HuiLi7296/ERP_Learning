# ---------------------------------------------------------------------- #
# Script generated with: DeZign for Databases V7.3.4                     #
# Target DBMS:           MySQL 5                                         #
# Project file:          Project1.dez                                    #
# Project name:                                                          #
# Author:                                                                #
# Script type:           Database drop script                            #
# Created on:            2018-01-22 22:36                                #
# ---------------------------------------------------------------------- #


# ---------------------------------------------------------------------- #
# Drop foreign key constraints                                           #
# ---------------------------------------------------------------------- #

ALTER TABLE `Employee` DROP FOREIGN KEY `Department_Employee`;

# ---------------------------------------------------------------------- #
# Drop table "Employee"                                                  #
# ---------------------------------------------------------------------- #

# Remove autoinc for PK drop #

ALTER TABLE `Employee` MODIFY `EmployeeID` INTEGER NOT NULL;

# Drop constraints #

ALTER TABLE `Employee` ALTER COLUMN `EntryDate` DROP DEFAULT;

ALTER TABLE `Employee` ALTER COLUMN `ChangeDate` DROP DEFAULT;

ALTER TABLE `Employee` DROP PRIMARY KEY;

# Drop table #

DROP TABLE `Employee`;

# ---------------------------------------------------------------------- #
# Drop table "Department"                                                #
# ---------------------------------------------------------------------- #

# Remove autoinc for PK drop #

ALTER TABLE `Department` MODIFY `DepartmentID` INTEGER NOT NULL;

# Drop constraints #

ALTER TABLE `Department` DROP PRIMARY KEY;

# Drop table #

DROP TABLE `Department`;
