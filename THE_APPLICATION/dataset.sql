create table Filiere(
    id int auto_increment primary key,
    code varchar(30) ,
    designantion varchar(55), 
    constraint filiere_uni unique (code)
);


create table Module(
    id int auto_increment,
    code varchar(30),
    designantion varchar(55),
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
    designantion varchar(55),
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
    id_fil int,
    niveau varchar(30),
    moyenne float,

    constraint Moyennes_pk primary key(id,id_eleve,id_fil,niveau),
    constraint mdl_fk1 foreign key(id_eleve) 
        references Eleve(id) on delete CASCADE,
    constraint mdl_fk2 foreign key(id_fil) 
        references Filiere(id) on delete CASCADE
); 

