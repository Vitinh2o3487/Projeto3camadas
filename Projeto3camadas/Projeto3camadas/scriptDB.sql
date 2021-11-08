CREATE DATABASE db3camadas;
USE db3camadas;

create table tbl_Medicamento 
(
id int not null auto_increment primary key,
medicamento varchar(40) not null,
composicao varchar(200) not null
);

create table tbl_receita 
(
codigo int not null auto_increment primary key,
nomePaciente varchar(30),
idMedicamento int not null,
foreign key(idMedicamento) references tbl_Medicamento(id)
);