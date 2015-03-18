------------------------ CREATION DES TABLES --------------------------------------------------------
CREATE TABLE Categorie
(
CodeCat CHAR (3) NOT NULL,
NomCat VARCHAR2 (30) NOT NULL,
CouleurCat VARCHAR2 (30) NOT NULL
);
ALTER TABLE Categorie ADD CONSTRAINT Categorie_PK PRIMARY KEY ( CodeCat );

CREATE TABLE Question
(
CodeQuestions NUMBER NOT NULL,
CodeCat CHAR (3) NOT NULL,
Question VARCHAR2 (150) NOT NULL
);
ALTER TABLE Question ADD CONSTRAINT Question_PK PRIMARY KEY ( CodeQuestions );

CREATE TABLE Reponse
(
CodeQuestions NUMBER NOT NULL,
ReponseMauvaise1 VARCHAR2 (100) NOT NULL,
ReponseMauvaise2 VARCHAR2 (100) NOT NULL,
ReponseMauvaise3 VARCHAR2 (100) NOT NULL,
ReponseBonne VARCHAR2 (100) NOT NULL
);
ALTER TABLE Reponse ADD CONSTRAINT Reponse_PK PRIMARY KEY ( CodeQuestions );

ALTER TABLE Question ADD CONSTRAINT Question_Reponse_FK FOREIGN KEY ( CodeQuestions ) REFERENCES Reponse ( CodeQuestions );

ALTER TABLE Question ADD CONSTRAINT TABLE_2_Categorie_FK FOREIGN KEY ( CodeCat ) REFERENCES Categorie ( CodeCat );
------------------------ PACKAGE --------------------------------------------------------------------
create or replace PACKAGE GESTIONJEU AS

FUNCTION SELECTQUESTIONSCATEGORY (f_CATEGORIE IN QUESTION.CODECAT%TYPE) RETURN SYS_REFCURSOR;
FUNCTION SELECTBONNEREPONSE (NUMERODEQUESTION IN NUMBER) RETURN SYS_REFCURSOR;
FUNCTION SELECTQUESTIONNUMERO (NUMERO IN NUMBER) RETURN SYS_REFCURSOR;
FUNCTION SELECTSCOREFROMJOUEUR (SCORE IN NUMBER, IN_PSEUDO IN VARCHAR2 ) RETURN SYS_REFCURSOR;

PROCEDURE DELETEQUESTION
(
  IN_CODEQUES IN QUESTION.CODEQUESTIONS%TYPE,
  IN_QUESTION IN QUESTION.QUESTION%TYPE,
  IN_REPONSE1 IN REPONSE.REPONSEMAUVAISE1%TYPE,
  IN_REPONSE2 IN REPONSE.REPONSEMAUVAISE2%TYPE,
  IN_REPONSE3 IN REPONSE.REPONSEMAUVAISE3%TYPE,
  IN_REPONSE4 IN REPONSE.REPONSEBONNE%TYPE
);
PROCEDURE INSERTQUESTION
(
  IN_CATEGORY IN QUESTION.CODECAT%TYPE,
  IN_QUESTION IN QUESTION.QUESTION%TYPE,
  IN_REPONSE1 IN REPONSE.REPONSEMAUVAISE1%TYPE,
  IN_REPONSE2 IN REPONSE.REPONSEMAUVAISE2%TYPE,
  IN_REPONSE3 IN REPONSE.REPONSEMAUVAISE3%TYPE,
  IN_REPONSE4 IN REPONSE.REPONSEBONNE%TYPE
);
PROCEDURE UPDATEQUESTION
(
  IN_CODEQUES IN QUESTION.CODEQUESTIONS%TYPE,
  IN_QUESTION IN QUESTION.QUESTION%TYPE,
  IN_REPONSE1 IN REPONSE.REPONSEMAUVAISE1%TYPE,
  IN_REPONSE2 IN REPONSE.REPONSEMAUVAISE2%TYPE,
  IN_REPONSE3 IN REPONSE.REPONSEMAUVAISE3%TYPE,
  IN_REPONSE4 IN REPONSE.REPONSEBONNE%TYPE
);

-- Augmente le score de 1 à partir du score qu'il y avait déjà (incrémenteur de score)
PROCEDURE MONTERSCOREJOUEUR
(
  IN_PSEUDO IN SCORE.PSEUDO%TYPE,
  IN_SCORE IN SCORE.SCORE%TYPE
);

-- Met le score à 0 quand une nouvelle partie commence et qu'on reprend pas une partie
PROCEDURE RESETSCORETOZERO
(
  IN_PSEUDO IN SCORE.PSEUDO%TYPE,
  IN_SCORE IN SCORE.SCORE%TYPE
);
END;
------------------------ PACKAGE BODY --------------------------------------------------------------------
create or replace PACKAGE BODY GESTIONJEU AS

FUNCTION SELECTQUESTIONSCATEGORY
(
  f_CATEGORIE IN QUESTION.CODECAT%TYPE
) RETURN SYS_REFCURSOR AS
RESULTAT SYS_REFCURSOR;
BEGIN
  OPEN RESULTAT FOR SELECT Q.QUESTION FROM QUESTION Q WHERE Q.CODECAT=f_CATEGORIE;
  RETURN RESULTAT;
END;
FUNCTION SELECTBONNEREPONSE
(
  NUMERODEQUESTION IN NUMBER
) RETURN SYS_REFCURSOR AS
RESULTAT SYS_REFCURSOR;
BEGIN
  OPEN RESULTAT FOR SELECT REPONSEBONNE FROM REPONSE WHERE CODEQUESTIONS=NUMERODEQUESTION;
  RETURN RESULTAT;
END;
FUNCTION SELECTSCOREFROMJOUEUR (SCORE IN NUMBER, IN_PSEUDO IN VARCHAR2 ) RETURN SYS_REFCURSOR AS
RESULTAT SYS_REFCURSOR;
BEGIN
  OPEN RESULTAT FOR SELECT SCORE FROM SCORE WHERE PSEUDO=IN_PSEUDO;
  RETURN RESULTAT;
END SELECTSCOREFROMJOUEUR;
FUNCTION SELECTQUESTIONNUMERO
(
  NUMERO IN NUMBER
) RETURN SYS_REFCURSOR AS
RESULTAT SYS_REFCURSOR;
BEGIN
  OPEN RESULTAT FOR SELECT Q.QUESTION, R.REPONSEMAUVAISE1, R.REPONSEMAUVAISE2, R.REPONSEMAUVAISE3, R.REPONSEBONNE FROM QUESTION Q INNER JOIN REPONSE R ON Q.CODEQUESTIONS=R.CODEQUESTIONS WHERE Q.CODEQUESTIONS=NUMERO;
  RETURN RESULTAT;
END;

PROCEDURE DELETEQUESTION
(
  IN_CODEQUES IN QUESTION.CODEQUESTIONS%TYPE,
  IN_QUESTION IN QUESTION.QUESTION%TYPE,
  IN_REPONSE1 IN REPONSE.REPONSEMAUVAISE1%TYPE,
  IN_REPONSE2 IN REPONSE.REPONSEMAUVAISE2%TYPE,
  IN_REPONSE3 IN REPONSE.REPONSEMAUVAISE3%TYPE,
  IN_REPONSE4 IN REPONSE.REPONSEBONNE%TYPE
) AS
BEGIN
  DELETE FROM QUESTION WHERE CODEQUESTIONS=IN_CODEQUES;
  DELETE FROM REPONSE WHERE CODEQUESTIONS=IN_CODEQUES;
  COMMIT;
END;
PROCEDURE INSERTQUESTION
(
  IN_CATEGORY IN QUESTION.CODECAT%TYPE,
  IN_QUESTION IN QUESTION.QUESTION%TYPE,
  IN_REPONSE1 IN REPONSE.REPONSEMAUVAISE1%TYPE,
  IN_REPONSE2 IN REPONSE.REPONSEMAUVAISE2%TYPE,
  IN_REPONSE3 IN REPONSE.REPONSEMAUVAISE3%TYPE,
  IN_REPONSE4 IN REPONSE.REPONSEBONNE%TYPE
) AS
BEGIN
  INSERT INTO QUESTION VALUES(QUESTIONS_SEQ.NEXTVAL, IN_CATEGORY, IN_QUESTION);
  INSERT INTO REPONSE VALUES(QUESTIONS_SEQ.CURRVAL, IN_REPONSE1, IN_REPONSE2, IN_REPONSE3, IN_REPONSE4);
  COMMIT;
END;
PROCEDURE UPDATEQUESTION
(
  IN_CODEQUES IN QUESTION.CODEQUESTIONS%TYPE,
  IN_QUESTION IN QUESTION.QUESTION%TYPE,
  IN_REPONSE1 IN REPONSE.REPONSEMAUVAISE1%TYPE,
  IN_REPONSE2 IN REPONSE.REPONSEMAUVAISE2%TYPE,
  IN_REPONSE3 IN REPONSE.REPONSEMAUVAISE3%TYPE,
  IN_REPONSE4 IN REPONSE.REPONSEBONNE%TYPE
) AS
BEGIN
  UPDATE QUESTION SET QUESTION=IN_QUESTION WHERE CODEQUESTIONS=IN_CODEQUES;
  UPDATE REPONSE SET REPONSEMAUVAISE1=IN_REPONSE1, REPONSEMAUVAISE2=IN_REPONSE2, REPONSEMAUVAISE3=IN_REPONSE3, REPONSEBONNE=IN_REPONSE4 WHERE CODEQUESTIONS=IN_CODEQUES;
  COMMIT;
END;

PROCEDURE MONTERSCOREJOUEUR 
(
  IN_PSEUDO IN SCORE.PSEUDO%TYPE,
  IN_SCORE IN SCORE.SCORE%TYPE
) AS 
BEGIN
  UPDATE SCORE SET SCORE.SCORE = (SELECT SCORE FROM SCORE WHERE PSEUDO=IN_PSEUDO)+1 WHERE PSEUDO=IN_PSEUDO;
END MONTERSCOREJOUEUR;

PROCEDURE RESETSCORETOZERO 
(
  IN_PSEUDO IN SCORE.PSEUDO%TYPE,
  IN_SCORE IN SCORE.SCORE%TYPE
) AS 
BEGIN
  UPDATE SCORE SET SCORE.SCORE = 0 WHERE PSEUDO=IN_PSEUDO;
END RESETSCORETOZERO;

END;
------------------------ CATEGORY -------------------------------------------------------------------
INSERT INTO CATEGORIE VALUES ('SPR','sport','blue'); 
INSERT INTO CATEGORIE VALUES ('HIS','histoire','yellow'); 
INSERT INTO CATEGORIE VALUES ('GEO','geographie','green');
INSERT INTO CATEGORIE VALUES ('ART','art-culture','red'); 
------------------------ QUESTION -------------------------------------------------------------------
INSERT INTO QUESTION VALUES (001, 'SPR',  'Qui est l''équipe de hockey qui joue pour Montréal?');
INSERT INTO QUESTION VALUES (002, 'SPR',  'Où s''est passé la dernière coupe du monde de la FIFA?');
INSERT INTO QUESTION VALUES (003, 'SPR',  'Quand est-ce que le baseball a été joué pour la première fois aux olympiques?');
INSERT INTO QUESTION VALUES (004, 'SPR',  'Qu''est-ce qui est le plus excitant au volleyball?');
INSERT INTO QUESTION VALUES (005, 'SPR',  'Quel est le nom du restaurant sportif qui a pas l''ambiance annoncée à la télé?');
INSERT INTO QUESTION VALUES (006, 'SPR',  'Quel est la couleur des ballons de backetball?');
INSERT INTO QUESTION VALUES (007, 'SPR',  'Quel est le sport le plus dangereux dans les sports suivants:');
INSERT INTO QUESTION VALUES (008, 'SPR',  'Lequel des sports suivants utilise les jambes exclusivement?');
INSERT INTO QUESTION VALUES (009, 'SPR',  'Quelle est la boisson préférée des douche-bags pour la musculation?');
INSERT INTO QUESTION VALUES (010, 'SPR',  'Nommez une maladie due au sucre lorsque les gens ne font pas assez de sport');
INSERT INTO QUESTION VALUES (011, 'SPR',  'Quelle drogue nocive est utilisée pour booster ses muscles?');
INSERT INTO QUESTION VALUES (012, 'SPR',  'Quelle est la vitesse record d''un humain à la nage?');
INSERT INTO QUESTION VALUES (013, 'SPR',  'Quelles sont les couleurs d''un ballon de soccer?');
INSERT INTO QUESTION VALUES (014, 'SPR',  'Quel est le sport le plus joué au monde?');
INSERT INTO QUESTION VALUES (015, 'SPR',  'Qui a gagné la dernière coupe de soccer modiale?');
INSERT INTO QUESTION VALUES (016, 'SPR',  'Qui gagne tout le temps au ping-pong?');
INSERT INTO QUESTION VALUES (017, 'SPR',  'Lequel de ces jeux est un sport électronique?');
INSERT INTO QUESTION VALUES (018, 'SPR',  'Lequel des jeux suivants n''est pas joué aux Olympqiues Informatique du CLG?');
INSERT INTO QUESTION VALUES (019, 'SPR',  'Lequel des sports suivant peut faire perdre plus de 10 livres en une séance?');
INSERT INTO QUESTION VALUES (020, 'SPR',  'Lequel des sports suivants est fake?');

INSERT INTO QUESTION VALUES (021, 'HIS',  'En quelle année le Canada a-t-il été découvert par Jacques Cartier?');
INSERT INTO QUESTION VALUES (022, 'HIS',  'Quand est-ce que la ville de Québec fut fondée?');
INSERT INTO QUESTION VALUES (023, 'HIS',  'En quelle année on découvrit et nomma Montréal?');
INSERT INTO QUESTION VALUES (024, 'HIS',  'Quel est le nom du premier jeu 3D pour PC ayant marqué l''histoire?');
INSERT INTO QUESTION VALUES (025, 'HIS',  'Quel est la date d''élection du premier président américain de race noire?');
INSERT INTO QUESTION VALUES (026, 'HIS',  'En quel année la révolution française a-t-elle débuté?');
INSERT INTO QUESTION VALUES (027, 'HIS',  'Quel est le premier état américain à légaliser la marijuana?');
INSERT INTO QUESTION VALUES (028, 'HIS',  'Quel pays d''Europe a marqué l''histoire en légalisant plein de drogues?');
INSERT INTO QUESTION VALUES (029, 'HIS',  'En quelle année Google a été créée dans un garage?');
INSERT INTO QUESTION VALUES (030, 'HIS',  'En quel année le téléphone Nokia 3310 à grand succès est-il apparu?');
INSERT INTO QUESTION VALUES (031, 'HIS',  'La rébellion des Patriotes s''est passé en quelle année?');
INSERT INTO QUESTION VALUES (032, 'HIS',  'Où est mort Louis-Joseph Papineau?');
INSERT INTO QUESTION VALUES (033, 'HIS',  'En 2015, qui est le nom de famille due président bad-ass de Russie?');
INSERT INTO QUESTION VALUES (034, 'HIS',  'Quand est-ce que l''humain moderne est apparu?');
INSERT INTO QUESTION VALUES (035, 'HIS',  'À quand remonte la naissance de Pythagore?');
INSERT INTO QUESTION VALUES (036, 'HIS',  'Quel item parmis les suivants n''est pas un monument historique de France?');
INSERT INTO QUESTION VALUES (037, 'HIS',  'Dans la liste suivante, qu''est-ce qui valait plus que de l''or au 15e sciècle?');
INSERT INTO QUESTION VALUES (038, 'HIS',  'En quelle année les États-Unis on décidé de bannir l''alcool?');
INSERT INTO QUESTION VALUES (039, 'HIS',  'Quand est-ce que la dernière constitution de Chine a été adoptée?');
INSERT INTO QUESTION VALUES (040, 'HIS',  'En quelle année et par qui Youtube a-t-il été créé?');

INSERT INTO QUESTION VALUES (041, 'GEO',  'Sur quelle île de France retrouve-t-on les plus belles femmes?');
INSERT INTO QUESTION VALUES (042, 'GEO',  'Quels désastres naturels ont sensibilisé la France à l''environement?');
INSERT INTO QUESTION VALUES (043, 'GEO',  'Quel pays se situe au sud-est de l''Afghanistan?');
INSERT INTO QUESTION VALUES (044, 'GEO',  'Dans quel pays retrouve-t-on des champs de thé dans les montagnes?');
INSERT INTO QUESTION VALUES (045, 'GEO',  'Lequel de ces pays est le plus grand conssommateur de vin?');
INSERT INTO QUESTION VALUES (046, 'GEO',  'De quel pays vient le dernier pape élu?');
INSERT INTO QUESTION VALUES (047, 'GEO',  'Quel est la couleur de sable la plus retrouvée en Australie?');
INSERT INTO QUESTION VALUES (048, 'GEO',  'Dans quel pays trouve-t-on le Machu Picchu?');
INSERT INTO QUESTION VALUES (049, 'GEO',  'En février 2014, à quel vitesse les glacier du Groenland fondaient-ils?');
INSERT INTO QUESTION VALUES (050, 'GEO',  'Combien de barils de pétrol y a-t-il d''estimé sous l''Île d''Anticosti?');
INSERT INTO QUESTION VALUES (051, 'GEO',  'Quel type de sol se forme lorsqu''on mélange la terre et l''eau?');
INSERT INTO QUESTION VALUES (052, 'GEO',  'Quelle est la plus grande fortification militaire au monde?');
INSERT INTO QUESTION VALUES (053, 'GEO',  'De quel côté du CEGEP Lionel-Groulx se trouve la statue de Lionel?');
INSERT INTO QUESTION VALUES (054, 'GEO',  'Où se trouve la plus grande tombe au monde?');
INSERT INTO QUESTION VALUES (055, 'GEO',  'Où se situe le fort Saint-Jean?');
INSERT INTO QUESTION VALUES (056, 'GEO',  'Dans quel pays retrouve-t-on le plus de lacs?');
INSERT INTO QUESTION VALUES (057, 'GEO',  'Quel pays a planté un drapeau au pôle-nord géographique?');
INSERT INTO QUESTION VALUES (058, 'GEO',  'Lequel des pays suivant fait partie du Royaume du Danemark?');
INSERT INTO QUESTION VALUES (059, 'GEO',  'Quel ville de Turquie est sa capitale culturelle?');
INSERT INTO QUESTION VALUES (060, 'GEO',  'Quelle est la capitale du Japon?');

INSERT INTO QUESTION VALUES (061, 'ART',  'Qui est le peintre postimpressionniste s''ayant arraché l''oreille?');
INSERT INTO QUESTION VALUES (062, 'ART',  'Quel peintre a peinturé Le Jugement Dernier dans la chappelle Sixtine?');
INSERT INTO QUESTION VALUES (063, 'ART',  'Le film Kareteci Kiz est connu pour?');
INSERT INTO QUESTION VALUES (064, 'ART',  'Quel est le nom de la sculpture réalisée par Michel-Ange entre 1501 et 1504?');
INSERT INTO QUESTION VALUES (065, 'ART',  'Nommez un important édifice religieux catholique, reconnu pour son architecture?');
INSERT INTO QUESTION VALUES (066, 'ART',  'Quel est le tableau le plus reconnu de Léonard de Vinci?');
INSERT INTO QUESTION VALUES (067, 'ART',  'Quel peintre, dessinateur et sculpteur espagnol est né le 25 octobre 1881?');
INSERT INTO QUESTION VALUES (068, 'ART',  'Qui a volé la Joconde en 1911?');
INSERT INTO QUESTION VALUES (069, 'ART',  'Où est né Michelangelo di Lodovico Buonarroti Simoni (Michel-Ange)?');
INSERT INTO QUESTION VALUES (070, 'ART',  'Quel écrivain à parodié la Monna Lisa dans une comédie (1850-1851)?');
INSERT INTO QUESTION VALUES (071, 'ART',  'Quel artiste porte le nom de famille de Thiry d''Holbach?');
INSERT INTO QUESTION VALUES (072, 'ART',  'Quel succès d''un écrivain québecois est considéré comme de la foutaise?');
INSERT INTO QUESTION VALUES (073, 'ART',  'Quel entreprise américaine croit qu''elles a inventé les meilleurs designes du monde?');
INSERT INTO QUESTION VALUES (074, 'ART',  'Nommez le film de Sergio Leone sorti en 1971?');
INSERT INTO QUESTION VALUES (075, 'ART',  'Quel film fait pas partit de la trilogie de l''homme sans nom?');
INSERT INTO QUESTION VALUES (076, 'ART',  'Quel film a lancé la carrière de Robert De Niro malgré les mauvaises critiques?');
INSERT INTO QUESTION VALUES (077, 'ART',  'Quand on dessine une vache, une personne normale dessine combien de pattes?');
INSERT INTO QUESTION VALUES (078, 'ART',  'Dans la Monna Lisa, la femme dessinée a la peau de quelle couleur?');
INSERT INTO QUESTION VALUES (079, 'ART',  'Lequel des personnages suivants était très doué pour dessiner des paysages?');
INSERT INTO QUESTION VALUES (080, 'ART',  'Qui a peinturé "Le Cri"?');
------------------------ REPONSE --------------------------------------------------------------------
INSERT INTO REPONSE VALUES (001, 'Les Ontariens','Les Québecois','Les Montréaleurs', 'Les Canadiens');
INSERT INTO REPONSE VALUES (002, 'Vancouvert','Sotchi','Argentine', 'Brésil');
INSERT INTO REPONSE VALUES (003, '1838','1936','1952', '1912');
INSERT INTO REPONSE VALUES (004, 'L''action','Le monde qui court partout','La plage', 'Les bikinis');
INSERT INTO REPONSE VALUES (005, 'Boston Pizza','Pizza Hut','Sport resort', 'La cage au sport');
INSERT INTO REPONSE VALUES (006, 'Jaune','Rouge','Brun', 'Orange');
INSERT INTO REPONSE VALUES (007, 'Pêche au saumon','Chasse aux grenouilles','Rugby', 'Chasse aux ours');
INSERT INTO REPONSE VALUES (008, 'Tennis','Baseball','Corde à danser', 'Course');
INSERT INTO REPONSE VALUES (009, 'Un vert de lait','Jus de prunes','De la bière', 'Six Oeufs et du café tout en un');
INSERT INTO REPONSE VALUES (010, 'Paresse','Crise de coeur','Dystrophy musculaire', 'Diabete');
INSERT INTO REPONSE VALUES (011, 'Jus de popaye','Narcotiques','Nootropiques', 'Steroides');
INSERT INTO REPONSE VALUES (012, '5,4 km/s','3,6 km/s','8,0 km/s', '6,4 km/s');
INSERT INTO REPONSE VALUES (013, 'Gris et gris','Noir et gris','Blanc et gris', 'Blanc et noir');
INSERT INTO REPONSE VALUES (014, 'Badminton','Football','Cricket', 'Soccer');
INSERT INTO REPONSE VALUES (015, 'États-unis','Argentine','Brézil', 'Allemagne');
INSERT INTO REPONSE VALUES (016, 'Le Canadas','Les États-Unis','Les Européens', 'Les Asiatiques');
INSERT INTO REPONSE VALUES (017, 'StarCraft','Leaugue of Légends','Quake 3', 'Toutes ces réponses');
INSERT INTO REPONSE VALUES (018, 'Lancé de la souris','Transport de la baguette de RAM','Tapper un programme à l''envers', 'Glissage du disque-dur');
INSERT INTO REPONSE VALUES (019, 'Levé d''alterres','Football','Crouse cross-country', 'Course automobile');
INSERT INTO REPONSE VALUES (020, 'Boxe','Boxe birmane','Art matial', 'Lutte');

INSERT INTO REPONSE VALUES (021, '1496','1608','1526', '1536');
INSERT INTO REPONSE VALUES (022, '1536','1526','1701', '1608');
INSERT INTO REPONSE VALUES (023, '1536','1534','1556', '1535');
INSERT INTO REPONSE VALUES (024, 'Doom','Quake','Quake II', 'Wolfenstein 3D');
INSERT INTO REPONSE VALUES (025, '2006','2012','2009', '2008');
INSERT INTO REPONSE VALUES (026, '1769','1779','1799', '1789');
INSERT INTO REPONSE VALUES (027, 'Californie','Colorado','Washington', 'Massachusetts');
INSERT INTO REPONSE VALUES (028, 'Royaume-Uni','France','Russie', 'Portugal');
INSERT INTO REPONSE VALUES (029, '1995','1996','1999', '1998');
INSERT INTO REPONSE VALUES (030, '2003','2002','2001', '2000');
INSERT INTO REPONSE VALUES (031, '1834','1835','1836', '1837');
INSERT INTO REPONSE VALUES (032, 'En Australie','Dans le Haut-Canada (Ontario)','Aux États-Unis', 'Dans le village de Montebello');
INSERT INTO REPONSE VALUES (033, 'Poutine','Poutin','Vladimir', 'Putin');
INSERT INTO REPONSE VALUES (034, 'Il y a 400000 ans','Il y a 300000 ans','Il y a 100000 ans', 'Il y a 200000 ans');
INSERT INTO REPONSE VALUES (035, '-600 av J.C.','-550 av J.C.','-495 av J.C.', '-580 av J.C.');
INSERT INTO REPONSE VALUES (036, 'Cathédrale Notre-Drame','Arche de triomphe','Sacré-Coeur de Montmartre', 'Musée d''Orsay');
INSERT INTO REPONSE VALUES (037, 'Sel','Épice de maïs','Du Platinum', 'Poivre');
INSERT INTO REPONSE VALUES (038, '1933','1855','1851', '1920');
INSERT INTO REPONSE VALUES (039, '1975','1954','1988', '1982');
INSERT INTO REPONSE VALUES (040, 'En 2006 par Sergey Brin','En 2006 par Google','En 2004 par Amazon', 'En 2005 par des employés de PayPal');

INSERT INTO REPONSE VALUES (041, 'Sicile','Sardaigne','Chypre', 'Corse');
INSERT INTO REPONSE VALUES (042, 'De la pluie verre-glaçante','Des tombés de gros grèlons','De la pluie et des tornades', 'Des déluges et des glissement de terrains');
INSERT INTO REPONSE VALUES (043, 'Irak','Iran','Chine', 'Pakistan');
INSERT INTO REPONSE VALUES (044, 'Vietnam','Italie','Inde', 'Chine');
INSERT INTO REPONSE VALUES (045, 'France','Italie','Andore', 'Vatican');
INSERT INTO REPONSE VALUES (046, 'Rome','Vatican','Italie', 'Argentine');
INSERT INTO REPONSE VALUES (047, 'Marron','Gris-Mauve','Brun', 'Rougeâtre');
INSERT INTO REPONSE VALUES (048, 'Colombie','Brézil','Argentine', 'Pérou');
INSERT INTO REPONSE VALUES (049, 'Environ 10 kilomètres par an','244 mètres par jour','3 mètres par jour', '46 mètres par jour');
INSERT INTO REPONSE VALUES (050, '28,9 milliards','19,8 milliards','48,2 milliards', '30,9 milliards');
INSERT INTO REPONSE VALUES (051, 'Sols de steppe','Straté','Argileux', 'Boiteux');
INSERT INTO REPONSE VALUES (052, 'La Citadelle de Lille','Le Fort de la Bastille','L''Oppidum de Bibracte', 'Grande muraille de Chine');
INSERT INTO REPONSE VALUES (053, 'Ouest','Est','Nord', 'Sud');
INSERT INTO REPONSE VALUES (054, 'Aux Pays-Bas','Aux États-Unis','Au Japon', 'En Chine');
INSERT INTO REPONSE VALUES (055, 'Au lac Champlain','Sur le Mont Saint-Hilaire','En Gaspésie', 'Sur le bord de la rivière Richelieu');
INSERT INTO REPONSE VALUES (056, 'Afrique','Belgique','Russie', 'Canada');
INSERT INTO REPONSE VALUES (057, 'Groenland','États-Unis','Canada', 'Russie');
INSERT INTO REPONSE VALUES (058, 'Féroé','Suède','Icelande', 'Groenland');
INSERT INTO REPONSE VALUES (059, 'Serbe','Turkia','Ankara', 'Istanbul');
INSERT INTO REPONSE VALUES (060, 'Kyoto','Tokohama','Hiroshima', 'Tokyo');

INSERT INTO REPONSE VALUES (061, 'Ferdinand-Victor-Eugène Delacroix','Rembrandt','Jean-François Millet', 'Vincent Willem van Gogh');
INSERT INTO REPONSE VALUES (062, 'Raphaël','Leonardo da Vinci','Laurent de Médicis', 'Michel-Ange');
INSERT INTO REPONSE VALUES (063, 'Avoir été mis aux archive nationales','L''actrice célèbre Filiz Akin','La Golden Karate Girl', 'The worst death scene ever');
INSERT INTO REPONSE VALUES (064, 'La Vierge','Zeus','Alexandre', 'David');
INSERT INTO REPONSE VALUES (065, 'La basilique Saint-Ferjeux de Besançon','La basilique Saint-Remi de Reims','Basilique Saint-Paul-hors-les-Murs de Rome', 'La basilique Saint-Pierre du Vatican');
INSERT INTO REPONSE VALUES (066, 'La Scène','L''Annonciation','Le Baptême du Christ', 'La Joconde');
INSERT INTO REPONSE VALUES (067, 'Raphaël','Laurent de Médicis','Michel-Ange', 'Pablo Picasso');
INSERT INTO REPONSE VALUES (068, 'Michelangelo di Lodovico','Loggia Rucellai','Willi Forst', 'Vincenzo Peruggia');
INSERT INTO REPONSE VALUES (069, 'Aux Crete Senesi','À Livourne','À Florence', 'À Toscane');
INSERT INTO REPONSE VALUES (070, 'Guy de Maupassant','Howard Stern','Ron Howard', 'Jules Verne');
INSERT INTO REPONSE VALUES (071, 'Jacques Delille','Nicolas Edme Restif','François-Joseph', 'Paul Henri');
INSERT INTO REPONSE VALUES (072, 'Jean-Pierre April','François Avard','Nelly Arcan', 'Émile Nelligan');
INSERT INTO REPONSE VALUES (073, 'Renault Eleve','IBM','Microsoft', 'Apple');
INSERT INTO REPONSE VALUES (074, 'Giù la testa','Duck, You Sucker!','Il était une fois la révolution', 'Toutes ces réponses');
INSERT INTO REPONSE VALUES (075, 'Pour une poignée de dollars','Et pour quelques dollars de plus','Le Bon, la Brute et le Truand', 'Aucun');
INSERT INTO REPONSE VALUES (076, 'Le Bon, la Brute et le Truand','Il était une fois dans l''Ouest','La Revue du cinéma', 'Il était une fois en Amérique');
INSERT INTO REPONSE VALUES (077, '6','2','3', '4');
INSERT INTO REPONSE VALUES (078, 'Brunatre (Tenné)','Pêche','Rouge', 'Jaune');
INSERT INTO REPONSE VALUES (079, 'Gengis Khan','Vlad Putin','Stalin', 'Hitler');
INSERT INTO REPONSE VALUES (080, 'Pascale Aurignac','Léonard daVinci','Van Gogh', 'Edward Munch');