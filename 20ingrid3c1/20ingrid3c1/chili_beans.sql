create database chili_beans;
USE chili_beans;

CREATE TABLE oculos (
  id int NOT NULL AUTO_INCREMENT,
  nome varchar(50) NOT NULL,
  cor varchar(70) NOT NULL,
  preco decimal(7,2) NOT NULL,
  PRIMARY KEY (id)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS login (
  id int NOT NULL AUTO_INCREMENT,
  email varchar(60) NOT NULL,
  senha int NOT NULL,
  PRIMARY KEY (id)
) ENGINE=InnoDB;

INSERT INTO login VALUE(NULL,"usuario@email.com","12345");