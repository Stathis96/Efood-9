-- Table `mydb`.`tbl_pay`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tbl_pay` (
  `Cash` DOUBLE NOT NULL,
  `CardExpDate` DATE NULL,
  `CardNum` VARCHAR(15) NULL,
  `CardCvv` VARCHAR(3) NULL,
  `CardName` VARCHAR(45) NULL,
  `Telephone` VARCHAR(10) NOT NULL,
  `Card` VARCHAR(2) BINARY NOT NULL,
  UNIQUE INDEX `CardNum_UNIQUE` (`CardNum` ASC) VISIBLE,
  UNIQUE INDEX `UserID_UNIQUE` (`Telephone` ASC) VISIBLE,
  PRIMARY KEY (`Card`, `Telephone`))
ENGINE = InnoDB;
