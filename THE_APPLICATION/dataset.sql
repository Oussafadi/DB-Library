create table Filiere(
    id int auto_increment primary key,
    code varchar(30) ,
    designation varchar(55), 
    constraint filiere_uni unique (code)
);


create table Module(
    id int auto_increment,
    code varchar(30),
    designation varchar(55),
    niveau varchar(30),
    semestre varchar(30),
    id_filiere int(30),

    constraint  modl_pk primary key(id),
    constraint  modl_uni unique(code),
    constraint  modl_fk foreign key(id_filiere) 
        references Filiere(id) on delete CASCADE
);




create table Matiere(
    id int auto_increment,
    code varchar(30),
    designation varchar(55),
    VH float,
    id_module int,
    
    constraint Mtr_pk primary key(id),
    constraint Mtr_uni unique (code),
    constraint mtr_fk foreign key(id_module) 
        references Module(id) on delete CASCADE
); 



create table Eleve(
    id int auto_increment,
    code varchar(30),
    nom varchar(55),
    prenom varchar(55),
    niveau varchar(30),
    id_fil int,

    constraint Eleve_pk primary key(id),
    constraint Eleve_uni unique (code),
    constraint Elev_fk foreign key(id_fil) 
        references Filiere(id) on delete CASCADE
); 



create table Note(
    id int auto_increment,
    id_eleve int,
    id_mat int,
    note float,

    constraint Notes_pk primary key(id, id_eleve,id_mat),
    constraint N_fk1 foreign key(id_eleve) 
        references Eleve(id) on delete CASCADE,
    constraint N_fk2 foreign key(id_mat) 
        references Matiere(id) on delete CASCADE
); 



create table Moyenne(
    id int auto_increment,
    id_eleve int,
    id_filiere int,
    niveau varchar(30),
    moyenne float,

    constraint Moyennes_pk primary key(id,id_eleve,id_filiere,niveau),
    constraint mdl_fk1 foreign key(id_eleve) 
        references Eleve(id) on delete CASCADE,
    constraint mdl_fk2 foreign key(id_filiere) 
        references Filiere(id) on delete CASCADE
); 

insert into Filiere(code) values("AP");


DELIMITER $$
CREATE  PROCEDURE `EtudiantDelete`(IN id int)
BEGIN
  DELETE FROM etudiant  where  etudiant.id = id;
end$$
DELIMITER ;

DELIMITER $$
CREATE  PROCEDURE `etudiantInsert`(
    IN id int,
    IN code varchar(50),
    IN nom varchar(50),
    IN prenom varchar(50),
    IN niveau varchar(50),
    IN code_fil varchar(50)
  )
BEGIN
  INSERT INTO  etudiant VALUES (id, code, nom, prenom, niveau, code_fil);
end$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `etudiantUpdate`(IN `id` INT, IN `code` VARCHAR(255), IN `nom` VARCHAR(255), IN `prenom` VARCHAR(255), IN `niveau` VARCHAR(255), IN `code_fil` VARCHAR(255))
BEGIN
  UPDATE etudiant  SET  code = code,  nom = nom,   prenom = prenom,   niveau = niveau,   code_fil = code_fil WHERE  etudiant.id = id;
end$$
DELIMITER ;