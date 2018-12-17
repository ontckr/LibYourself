BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `book` (
	`name`	TEXT,
	`author`	TEXT,
	`date`	TEXT,
	PRIMARY KEY(`name`)
);
INSERT INTO `book` VALUES ('Cin Ali','Stefen Zweig','1936');
INSERT INTO `book` VALUES ('Tatlı Rüyalar','Alper Canıgüz','2012');
COMMIT;
