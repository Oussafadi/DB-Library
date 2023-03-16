create table Filiere(
    id int auto_increment primary key,
    code varchar(32) not null,
    designation varchar(64), 
    constraint filiere_uni unique (code)
);

create table Module(
    id int auto_increment,
    code varchar(32) not null,
    designation varchar(64),
    niveau varchar(32),
    semestre varchar(32),
    code_filiere varchar(32),

    constraint  modl_pk primary key(id),
    constraint  modl_uni unique(code),
    constraint  modl_fk foreign key(code_filiere) 
        references Filiere(code) on delete CASCADE
);

create table Matiere(
    id int auto_increment,
    code varchar(32) not null,
    designation varchar(54),
    VH float,
    code_module varchar(32),
    
    constraint Mtr_pk primary key(id),
    constraint Mtr_uni unique (code),
    constraint mtr_fk foreign key(code_module) 
        references Module(code) on delete CASCADE
); 



create table Eleve(
    id int auto_increment,
    code varchar(32) not null,
    nom varchar(64),
    prenom varchar(64),
    niveau varchar(32),
    code_filiere varchar(32),

    constraint Eleve_pk primary key(id),
    constraint Eleve_uni unique (code),
    constraint Elev_fk foreign key(code_filiere) 
        references Filiere(code) on delete CASCADE
);


create table Note(
    id int auto_increment,
    code_eleve varchar(32),
    code_matiere varchar(32),
    note float,

    constraint Notes_pk primary key(id, code_eleve, code_matiere),
    constraint N_fk1 foreign key(code_eleve) 
        references Eleve(code) on delete CASCADE,
    constraint N_fk2 foreign key(code_matiere) 
        references Matiere(code) on delete CASCADE
); 



create table Moyenne(
    id int auto_increment,
    code_eleve varchar(32),
    code_filiere varchar(32),
    niveau varchar(32),
    moyenne float,

    constraint Moyennes_pk primary key(id, code_eleve, code_filiere, niveau),
    constraint mdl_fk1 foreign key(code_eleve) 
        references Eleve(code) on delete CASCADE,
    constraint mdl_fk2 foreign key(code_filiere) 
        references Filiere(code) on delete CASCADE
); 


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
