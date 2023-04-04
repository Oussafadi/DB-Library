-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 05 avr. 2023 à 01:29
-- Version du serveur : 10.4.27-MariaDB
-- Version de PHP : 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestion_eleve`
--

DELIMITER $$
--
-- Procédures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `EtudiantDelete` (IN `id` INT)   BEGIN
  DELETE FROM etudiant  where  etudiant.id = id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `etudiantInsert` (IN `id` INT, IN `code` VARCHAR(50), IN `nom` VARCHAR(50), IN `prenom` VARCHAR(50), IN `niveau` VARCHAR(50), IN `code_fil` VARCHAR(50))   BEGIN
  INSERT INTO  etudiant VALUES (id, code, nom, prenom, niveau, code_fil);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `etudiantUpdate` (IN `id` INT, IN `code` VARCHAR(255), IN `nom` VARCHAR(255), IN `prenom` VARCHAR(255), IN `niveau` VARCHAR(255), IN `code_fil` VARCHAR(255))   BEGIN
  UPDATE etudiant  SET  code = code,  nom = nom,   prenom = prenom,   niveau = niveau,   code_fil = code_fil WHERE  etudiant.id = id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `NoteDelete` (IN `id` INT(10))   begin 
delete from note WHERE note.id=id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `NoteInsert` (IN `note` FLOAT(10), IN `code_matiere` VARCHAR(10), IN `code_eleve` VARCHAR(10))   BEGIN
INSERT INTO note(note.note,note.code_matiere,note.code_eleve) VALUES(note,code_matiere,code_eleve);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `NoteUpdate` (IN `note` FLOAT(10), IN `code_matiere` VARCHAR(10), IN `code_eleve` VARCHAR(10))   BEGIN
UPDATE note SET note.note=note WHERE(note.code_eleve=code_eleve and note.code_matiere=code_matiere);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `eleve`
--

CREATE TABLE `eleve` (
  `id` int(11) NOT NULL,
  `code` varchar(32) NOT NULL,
  `nom` varchar(64) DEFAULT NULL,
  `prenom` varchar(64) DEFAULT NULL,
  `niveau` varchar(32) DEFAULT NULL,
  `code_filiere` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `eleve`
--

INSERT INTO `eleve` (`id`, `code`, `nom`, `prenom`, `niveau`, `code_filiere`) VALUES
(1, 'elv1', 'jellouli', 'yassine', '3', 'GINFO'),
(3, 'elv2', 'abd', 'abd', '2', 'GINFO'),
(4, 'elv3', 'hado', 'badi', '2', 'GINFO');

-- --------------------------------------------------------

--
-- Structure de la table `filiere`
--

CREATE TABLE `filiere` (
  `id` int(11) NOT NULL,
  `code` varchar(32) NOT NULL,
  `designation` varchar(64) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `filiere`
--

INSERT INTO `filiere` (`id`, `code`, `designation`) VALUES
(1, 'GINFO', 'BADIR\r\n');

-- --------------------------------------------------------

--
-- Structure de la table `matiere`
--

CREATE TABLE `matiere` (
  `id` int(11) NOT NULL,
  `code` varchar(32) NOT NULL,
  `designation` varchar(54) DEFAULT NULL,
  `VH` float DEFAULT NULL,
  `code_module` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `matiere`
--

INSERT INTO `matiere` (`id`, `code`, `designation`, `VH`, `code_module`) VALUES
(1, 'echnique_algoritimque_avancer', 'gouy', 12, 'ALGORITHMIQUE'),
(2, 'm', 'aa', 20, 'ALGORITHMIQUE');

-- --------------------------------------------------------

--
-- Structure de la table `module`
--

CREATE TABLE `module` (
  `id` int(11) NOT NULL,
  `code` varchar(32) NOT NULL,
  `designation` varchar(64) DEFAULT NULL,
  `niveau` varchar(32) DEFAULT NULL,
  `semestre` varchar(32) DEFAULT NULL,
  `code_filiere` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `module`
--

INSERT INTO `module` (`id`, `code`, `designation`, `niveau`, `semestre`, `code_filiere`) VALUES
(1, 'ALGORITHMIQUE', 'GOUY', '2', '2', 'GINFO');

-- --------------------------------------------------------

--
-- Structure de la table `moyenne`
--

CREATE TABLE `moyenne` (
  `id` int(11) NOT NULL,
  `code_eleve` varchar(32) NOT NULL,
  `code_filiere` varchar(32) NOT NULL,
  `niveau` varchar(32) NOT NULL,
  `moyenne` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `moyenne`
--

INSERT INTO `moyenne` (`id`, `code_eleve`, `code_filiere`, `niveau`, `moyenne`) VALUES
(1, 'elv1', 'GINFO', '2', 13);

--
-- Déclencheurs `moyenne`
--
DELIMITER $$
CREATE TRIGGER `Niveau` AFTER INSERT ON `moyenne` FOR EACH ROW begin
     IF (NEW.moyenne > 11) THEN
               UPDATE eleve set eleve.niveau=eleve.niveau+1 WHERE (eleve.code=NEW.code_eleve);
               END IF;
               END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `note`
--

CREATE TABLE `note` (
  `id` int(11) NOT NULL,
  `code_eleve` varchar(32) NOT NULL,
  `code_matiere` varchar(32) NOT NULL,
  `note` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `note`
--

INSERT INTO `note` (`id`, `code_eleve`, `code_matiere`, `note`) VALUES
(33, 'elv2', 'm', 19),
(35, 'elv3', 'm', 16),
(37, 'elv1', 'm', 100);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `eleve`
--
ALTER TABLE `eleve`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `Eleve_uni` (`code`),
  ADD KEY `Elev_fk` (`code_filiere`);

--
-- Index pour la table `filiere`
--
ALTER TABLE `filiere`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `filiere_uni` (`code`);

--
-- Index pour la table `matiere`
--
ALTER TABLE `matiere`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `Mtr_uni` (`code`),
  ADD KEY `mtr_fk` (`code_module`);

--
-- Index pour la table `module`
--
ALTER TABLE `module`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `modl_uni` (`code`),
  ADD KEY `modl_fk` (`code_filiere`);

--
-- Index pour la table `moyenne`
--
ALTER TABLE `moyenne`
  ADD PRIMARY KEY (`id`,`code_eleve`,`code_filiere`,`niveau`),
  ADD KEY `mdl_fk1` (`code_eleve`),
  ADD KEY `mdl_fk2` (`code_filiere`);

--
-- Index pour la table `note`
--
ALTER TABLE `note`
  ADD PRIMARY KEY (`id`,`code_eleve`,`code_matiere`),
  ADD KEY `N_fk1` (`code_eleve`),
  ADD KEY `N_fk2` (`code_matiere`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `eleve`
--
ALTER TABLE `eleve`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `filiere`
--
ALTER TABLE `filiere`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `matiere`
--
ALTER TABLE `matiere`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `module`
--
ALTER TABLE `module`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `moyenne`
--
ALTER TABLE `moyenne`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `note`
--
ALTER TABLE `note`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `eleve`
--
ALTER TABLE `eleve`
  ADD CONSTRAINT `Elev_fk` FOREIGN KEY (`code_filiere`) REFERENCES `filiere` (`code`) ON DELETE CASCADE;

--
-- Contraintes pour la table `matiere`
--
ALTER TABLE `matiere`
  ADD CONSTRAINT `mtr_fk` FOREIGN KEY (`code_module`) REFERENCES `module` (`code`) ON DELETE CASCADE;

--
-- Contraintes pour la table `module`
--
ALTER TABLE `module`
  ADD CONSTRAINT `modl_fk` FOREIGN KEY (`code_filiere`) REFERENCES `filiere` (`code`) ON DELETE CASCADE;

--
-- Contraintes pour la table `moyenne`
--
ALTER TABLE `moyenne`
  ADD CONSTRAINT `mdl_fk1` FOREIGN KEY (`code_eleve`) REFERENCES `eleve` (`code`) ON DELETE CASCADE,
  ADD CONSTRAINT `mdl_fk2` FOREIGN KEY (`code_filiere`) REFERENCES `filiere` (`code`) ON DELETE CASCADE;

--
-- Contraintes pour la table `note`
--
ALTER TABLE `note`
  ADD CONSTRAINT `N_fk1` FOREIGN KEY (`code_eleve`) REFERENCES `eleve` (`code`) ON DELETE CASCADE,
  ADD CONSTRAINT `N_fk2` FOREIGN KEY (`code_matiere`) REFERENCES `matiere` (`code`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
