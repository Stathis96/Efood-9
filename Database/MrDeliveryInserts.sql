

-- -----------------------------------------------------
-- Data for table `mydb`.`tbl_support`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`tbl_support` (`Telephone`, `Name`, `Epon`, `Msg`, `Email`) VALUES ('6924451580', 'Antonis ', 'Nikopolidis', 'Nice Service', 'anikop71@gmail.com');
INSERT INTO `mydb`.`tbl_support` (`Telephone`, `Name`, `Epon`, `Msg`, `Email`) VALUES ('6912237613', 'Thanasis', 'Papazoglou', 'Order Delay :(', 'tpapazoglou45@gmail.com');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`tbl_pay`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`tbl_pay` (`Cash`, `CardExpDate`, `CardNum`, `CardCvv`, `CardName`, `Telephone`, `Card`) VALUES (21.3, '11/21', '4761990376190138', '321', 'ANTONIS S NIKOPOLIDIS', '6924451580', '1');
INSERT INTO `mydb`.`tbl_pay` (`Cash`, `CardExpDate`, `CardNum`, `CardCvv`, `CardName`, `Telephone`, `Card`) VALUES (19.0, '2/21', '8990524167892615', '788', 'KOSTAS K NEMPEGLERAS', '9677366152', '1');
INSERT INTO `mydb`.`tbl_pay` (`Cash`, `CardExpDate`, `CardNum`, `CardCvv`, `CardName`, `Telephone`, `Card`) VALUES (13.8, '8/20', NULL, NULL, NULL, '6978716279', '0');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`tbl_user`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`tbl_user` (`UserID`, `Username`, `Password`, `Email`, `FirstName`, `LastName`, `Address`, `Floor`, `Bell`, `Telephone`) VALUES (1, 'Anikopol', '45fhaw2', 'anikop71@gmail.com', 'Antonis', 'Nikopolidis', 'P.Syndika 4', '3', 'Nikopolidis', '6924451580');
INSERT INTO `mydb`.`tbl_user` (`UserID`, `Username`, `Password`, `Email`, `FirstName`, `LastName`, `Address`, `Floor`, `Bell`, `Telephone`) VALUES (2, 'Kostasmitroglou', '87871kkl', 'kmitrogou11@gmail.com', 'Kostas', 'Mitroglou', 'A.Panagouli  33', '1', 'Mitroglou', '6972156003');
INSERT INTO `mydb`.`tbl_user` (`UserID`, `Username`, `Password`, `Email`, `FirstName`, `LastName`, `Address`, `Floor`, `Bell`, `Telephone`) VALUES (3, 'Knempe', 'uijy7886', 'kostas_nempegleras@gmail.com', 'Kostas', 'Nempegleras', 'Pontou 21', '2', 'Nempegleras', '6977366152');
INSERT INTO `mydb`.`tbl_user` (`UserID`, `Username`, `Password`, `Email`, `FirstName`, `LastName`, `Address`, `Floor`, `Bell`, `Telephone`) VALUES (4, 'Ampsn', 'a832711', 'angbasinas@gmail.com', 'Angelos', 'Mpasinas', 'Nikomidias 3', '1', 'Mpasinas', '6786151267');
INSERT INTO `mydb`.`tbl_user` (`UserID`, `Username`, `Password`, `Email`, `FirstName`, `LastName`, `Address`, `Floor`, `Bell`, `Telephone`) VALUES (5, 'Nickntampizas', '283hhjka', 'nntampizas@gmail.com', 'Nikos', 'Ntampizas', 'Thrakis 9', '5', 'Ntampizas', '6990012290');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`tbl_guest`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`tbl_guest` (`Telephone`, `Email`, `FirstName`, `LastName`, `Floor`, `Bell`, `Address`) VALUES ('6912237613', 'tpapazoglou45@gmail.com', 'Thanasis', 'Papazoglou', '2', 'Papazoglou', 'N.Votsi 24');
INSERT INTO `mydb`.`tbl_guest` (`Telephone`, `Email`, `FirstName`, `LastName`, `Floor`, `Bell`, `Address`) VALUES ('6978716279', 'katsour21@gmail.com', 'Kostas', 'Katsouranis', '4', 'Katsouranis', 'Delfon 8');
INSERT INTO `mydb`.`tbl_guest` (`Telephone`, `Email`, `FirstName`, `LastName`, `Floor`, `Bell`, `Address`) VALUES ('6984467162', 'Nnikolaidis@gmai.com', 'Ntemis', 'Nikolaidis', '1', 'Nikolaidis', 'Prousis 51');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`tbl_shop`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`tbl_shop` (`ShopID`, `Name`, `Address`, `Phone`, `Rating`) VALUES (1, 'Savvikos', 'Tsimiski 16 54523', '2310123456', 4.1);
INSERT INTO `mydb`.`tbl_shop` (`ShopID`, `Name`, `Address`, `Phone`, `Rating`) VALUES (2, 'Massato', 'Delfon 133 54248', '2310234567', 2.8);
INSERT INTO `mydb`.`tbl_shop` (`ShopID`, `Name`, `Address`, `Phone`, `Rating`) VALUES (3, 'Domino\'s', 'A.Papandreou 66 56728', '2310345678', 3.0);
INSERT INTO `mydb`.`tbl_shop` (`ShopID`, `Name`, `Address`, `Phone`, `Rating`) VALUES (4, 'BrothersInLaw', 'Pontou 71 55133', '2310456789', 3.8);

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`tbl_order`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`tbl_order` (`OrderID`, `UserID`, `ShopID`, `TotalPrice`, `Telephone`) VALUES (1, 1, 2, 22, '6924451580');
INSERT INTO `mydb`.`tbl_order` (`OrderID`, `UserID`, `ShopID`, `TotalPrice`, `Telephone`) VALUES (2, 3, 1, 12.9, '9677366152');
INSERT INTO `mydb`.`tbl_order` (`OrderID`, `UserID`, `ShopID`, `TotalPrice`, `Telephone`) VALUES (3, NULL, 4, 7.43, '6978716279');
INSERT INTO `mydb`.`tbl_order` (`OrderID`, `UserID`, `ShopID`, `TotalPrice`, `Telephone`) VALUES (4, 2, 1, 17.3, '6972156003');
INSERT INTO `mydb`.`tbl_order` (`OrderID`, `UserID`, `ShopID`, `TotalPrice`, `Telephone`) VALUES (5, 5, 3, 15.76, '6990012290');
INSERT INTO `mydb`.`tbl_order` (`OrderID`, `UserID`, `ShopID`, `TotalPrice`, `Telephone`) VALUES (6, NULL, 3, 20.1, '6984467162');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`tbl_fooditem`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (1, 1, 'Patates', 1, 1);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (2, 2, 'Salata', 1, 1);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (3, 3, 'Burger', 1, 1);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (4, 4, 'Sandwich', 1, 1);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (5, 5, 'Pizza', 1, 1);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (6, 6, 'Souvlakia', 1, 1);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (7, 7, 'Gyros', 1, 1);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (8, 8, 'Club', 1, 1);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (9, 9, 'Soufle', 1, 2);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (10, 10, 'Revani', 1, 2);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (11, 11, 'Pouting', 1, 2);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (12, 12, 'Profiterol', 1, 2);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (13, 13, 'Cola', 1, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (14, 14, 'OrangeJuice', 1, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (15, 15, 'LemonJuice', 1, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (16, 16, 'Sprite', 1, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (17, 17, 'IceTea', 1, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (18, 18, 'Water1.5', 1, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (19, 18, 'Water0.5', 1, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (20, 20, 'NaturalJuice', 1, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (21, 21, 'Chocolate', 2, 4);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (22, 22, 'Bueno', 2, 4);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (23, 22, '3Bit', 2, 4);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (24, 24, 'Cookies', 2, 4);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (25, 25, 'WhiteChoco', 2, 4);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (26, 26, 'Oreo', 2, 4);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (27, 27, 'Cheesecake', 2, 4);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (28, 28, 'BitterChoco', 2, 4);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (29, 29, 'HamCheese', 2, 5);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (30, 30, 'Cheese', 2, 5);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (31, 31, 'ChickenNuggets', 2, 5);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (32, 32, 'Vegan', 2, 5);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (33, 13, 'Cola', 2, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (34, 14, 'OrangeJuice', 2, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (35, 15, 'LemonJuice', 2, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (36, 16, 'Sprite', 2, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (37, 17, 'IceTea', 2, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (38, 18, 'Water1.5', 2, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (39, 18, 'Water0.5', 2, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (40, 20, 'NaturalJuice', 2, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (41, 41, 'Special', 3, 6);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (42, 42, 'Margarita', 3, 6);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (43, 43, 'Allantikon', 3, 6);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (44, 44, '4Cheese', 3, 6);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (45, 45, 'Xoriatiki', 3, 6);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (46, 46, 'AlPolo', 3, 6);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (47, 47, 'BBQ', 3, 6);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (48, 48, 'Mexicana', 3, 6);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (49, 49, 'Ceasar\'s', 3, 7);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (50, 50, 'Chef', 3, 7);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (51, 51, 'Xoriatiki', 3, 7);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (52, 52, 'Season\'s', 3, 7);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (53, 13, 'Cola', 3, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (54, 14, 'OrangeJuice', 3, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (55, 15, 'LemonJuice', 3, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (56, 16, 'Sprite', 3, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (57, 17, 'IceTea', 3, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (58, 18, 'Water1.5', 3, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (59, 18, 'Water0.5', 3, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (60, 20, 'NaturalJuice', 3, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (61, 61, 'Hamburger', 4, 8);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (62, 62, 'Cheeseburger', 4, 8);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (63, 63, 'BBQ', 4, 8);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (64, 64, 'JackDaniels', 4, 8);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (65, 65, 'BlackAngus', 4, 8);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (66, 66, 'Philly', 4, 8);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (67, 67, 'Chicken', 4, 8);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (68, 68, 'Veggie', 4, 8);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (69, 49, 'Ceasar\'s', 4, 7);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (70, 50, 'Chef', 4, 7);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (71, 51, 'Xoriatiki', 4, 7);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (72, 52, 'Season\'s', 4, 7);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (73, 13, 'Cola', 4, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (74, 14, 'OrangeJuice', 4, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (75, 15, 'LemonJuice', 4, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (76, 16, 'Sprite', 4, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (77, 17, 'IceTea', 4, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (78, 18, 'Water1.5', 4, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (79, 18, 'Water0.5', 4, 3);
INSERT INTO `mydb`.`tbl_fooditem` (`ItemID`, `IngrID`, `IngrName`, `ShopID`, `CategoryID`) VALUES (80, 20, 'NaturalJuice', 4, 3);


COMMIT;

