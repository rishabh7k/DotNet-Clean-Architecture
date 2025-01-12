/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
-- Insert into tblCompanies
INSERT INTO tblCompanies (Id, Name, Address, Country)
VALUES 
('IWgBRFxMUOeYOfi2bZgwg', 'IT_Solutions Ltd', '583 Wall Dr. Gwynn Oak, MD 21207', 'USA'),
('fLa1TShxXzFVvFkLqFvSA', 'Admin_Solutions Ltd', '312 Forest Avenue, BF 923', 'USA'),
('-6c75G6nU6Gr5IybZpTg', 'Software Development Limited', 'New Delhi', 'India');

-- Insert into tblEmployees
INSERT INTO tblEmployees (Id, Name, Age, Position, CompanyId, Salary)
VALUES
('urZAjxGZUC3YNZBxtOH1w', 'Sam Raiden', 26, 'Software developer', 'IWgBRFxMUOeYOfi2bZgwg', 10000.00),
('lTkzuZpUBeAXu3bOBH4B1g', 'Kane Miller', 35, 'Administrator', 'fLa1TShxXzFVvFkLqFvSA', 5000.00),
('-zB1Yh_rVrUGAiJgj1jZwX', 'Jana McLeaf', 30, 'Software developer', 'IWgBRFxMUOeYOfi2bZgwg', 22000.00);
