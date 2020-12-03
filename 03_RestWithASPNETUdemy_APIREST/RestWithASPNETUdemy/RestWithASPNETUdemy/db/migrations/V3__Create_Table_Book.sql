CREATE TABLE IF NOT EXISTS `book` (
	`id` bigint not null AUTO_INCREMENT,
	`author` longtext not null,
	`launch_date` datetime not null,
	`price` decimal(10,2) not null,
	`title` longtext not null,
	PRIMARY KEY(`id`)
)