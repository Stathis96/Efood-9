-- Table `mydb`.`tbl_support`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tbl_support` (
  `Telephone` VARCHAR(10) NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  `Epon` VARCHAR(45) NOT NULL,
  `Msg` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Telephone`),
  UNIQUE INDEX `Email_UNIQUE` (`Email` ASC) VISIBLE)
ENGINE = InnoDB;