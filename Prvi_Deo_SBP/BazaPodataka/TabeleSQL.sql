-- Tabela Cudoviste
CREATE TABLE Cudoviste (
    IdCudovista NUMBER PRIMARY KEY,
    NazivCud VARCHAR2(50),
    PodTipCud VARCHAR2(50),
    VekPomCud NUMBER
);

-- Tabela MagCudoviste
CREATE TABLE MagCudoviste (
    IdCudovista NUMBER PRIMARY KEY REFERENCES Cudoviste(IdCudovista),
    Postojanje CHAR2(2) CHECK (Postojanje IN("da", "ne"))
);

-- Tabela NeMagCudoviste
CREATE TABLE NeMagCudoviste (
    IdCudovista NUMBER PRIMARY KEY REFERENCES Cudoviste(IdCudovista),
    Visina NUMBER,
    Duzina NUMBER,
    Kandze CHAR(2) CHECK (Kandze IN("da", "ne")),
    BrojGlava NUMBER,
    ZiviUVodi CHAR(2) CHECK (ZiviUVodi IN("da", "ne")),
    Leti CHAR(2) CHECK (Leti IN("da", "ne")),
    Otrovno CHAR(2) CHECK (Otrovno IN("da", "ne")),
    Tezina NUMBER
);

-- Tabela SpecSposobnost
CREATE TABLE SpecSposobnost (
    IdSpecSpos NUMBER PRIMARY KEY,
    NazivSpecSpos VARCHAR2(50)
);

-- Tabela MagSposobnost
CREATE TABLE MagSposobnost (
    IdMagSpos NUMBER PRIMARY KEY,
    NazivMagSpos VARCHAR2(50),
    OpisMagSpos VARCHAR2(200),
    Ofanzivna CHAR(2) CHECK (Ofanzivna IN("da", "ne")),
    Defanzivna CHAR(2) CHECK (Defanzivna IN("da", "ne"))
);

-- Tabela Bajalica
CREATE TABLE Bajalica (
    IdBajalice NUMBER PRIMARY KEY,
    NazivBajalice VARCHAR2(255),
    Zastita VARCHAR2(255),
    Prednost VARCHAR2(255)
);

-- Tabela Legenda
CREATE TABLE Legenda (
    IdLegende NUMBER PRIMARY KEY,
    PrvoPominjanje DATE,
    TekstLegende VARCHAR2(500),
    ZemljaPorekla VARCHAR2(50),
    ImePoznatogPred VARCHAR2(50) REFERENCES PoznatiPredstavnik(JedinstvenoIme)
);

-- Tabela PoznatiPredstavnik
CREATE TABLE PoznatiPredstavnik (
    JedinstvenoIme VARCHAR2(50) PRIMARY KEY,
    Starost NUMBER,
    IdCud NUMBER REFERENCES Cudoviste(IdCudovista)
);

-- Tabela Lovac
CREATE TABLE Lovac (
    IdLovca NUMBER PRIMARY KEY,
    ImeLovca VARCHAR2(50)
);

-- Tabela Lokacija
CREATE TABLE Lokacija (
    IdLokacije NUMBER PRIMARY KEY,
    TipLok VARCHAR2(255),
    NazivLok VARCHAR2(255),
    ZemljaLok VARCHAR2(255),
    Blago VARCHAR2(255),
    IdLeg NUMBER REFERENCES Legenda(IdLegende)
);

-- Tabela Zastita
CREATE TABLE Zastita (
    IdZastite NUMBER PRIMARY KEY,
    TipZastite VARCHAR2(50),
    NazivZastite VARCHAR2(50),
    IdLok NUMBER REFERENCES Lokacija(IdLokacije)
);

-- Tabela Protivmere
CREATE TABLE Protivmere (
    IdProtivmere NUMBER PRIMARY KEY,
    NazivProtivmere VARCHAR2(50),
    OpisProtivmere VARCHAR2(200)
);

-- Tabela Predmet
CREATE TABLE Predmet (
    IdPredmeta NUMBER PRIMARY KEY,
    TipPredmeta VARCHAR2(50),
    NazivPredmeta VARCHAR2(50),
    MaterijalPredmeta VARCHAR2(50)
);

-- Tabela UsloviZaPrimenu
CREATE TABLE UsloviZaPrimenu (
    IdUslova NUMBER PRIMARY KEY,
    Uslov VARCHAR2(200),
    IdProtivM NUMBER REFERENCES Protivmere(IdProtivmere)
);

-- Tabela ProtivmeraPosedujePredmet
CREATE TABLE ProtivmeraPosedujePredmet (
    IdPPP NUMBER PRIMARY KEY,
    IdPred NUMBER REFERENCES Predmet(IdPredmeta),
    IdPM NUMBER REFERENCES Protivmere(IdProtivmere)
);

-- Tabela BajalicaProtivMagCud
CREATE TABLE BajalicaProtivMagCud (
    IdBajalicaPMagCud NUMBER PRIMARY KEY,
    IdCud NUMBER REFERENCES MagCudoviste(IdCudovista),
    IdBaj NUMBER REFERENCES Bajalica(IdBajalice)
);

-- Tabela ProtivCud
CREATE TABLE ProtivCud (
    IdProtivCud NUMBER PRIMARY KEY,
    IdCud NUMBER REFERENCES Cudoviste(IdCudovista),
    IdPM NUMBER REFERENCES Protivmere(IdProtivmere)
);

-- Tabela CudImaMagSpos
CREATE TABLE CudImaMagSpos (
    IdCudMagSpos NUMBER PRIMARY KEY,
    IdMagicnaSpos NUMBER REFERENCES MagSposobnost(IdMagSpos),
    IdCud NUMBER REFERENCES MagCudoviste(IdCudovista)
);

-- Tabela CudImaSpecSpos
CREATE TABLE CudImaSpecSpos (
    IdCudSpecSpos NUMBER PRIMARY KEY,
    IdSpecijalnaSpos NUMBER REFERENCES SpecSposobnost(IdSpecSpos),
    IdCud NUMBER REFERENCES NeMagCudoviste(IdCudovista)
);

-- Tabela PostojiLegenda
CREATE TABLE PostojiLegenda (
    IdPostojiLegenda NUMBER PRIMARY KEY,
    IdCud NUMBER REFERENCES Cudoviste(IdCudovista),
    IdLeg NUMBER REFERENCES Legenda(IdLegende)
);

-- Tabela LovacTragaPoznatimPred
CREATE TABLE LovacTragaPoznatimPred (
    IdLovacTragaPP NUMBER PRIMARY KEY,
    ImePP VARCHAR2(50) REFERENCES PoznatiPredstavnik(JedinstvenoIme),
    IdLov NUMBER REFERENCES Lovac(IdLovca)
);

-- Tabela Susret
CREATE TABLE Susret (
    IdSusret NUMBER PRIMARY KEY,
    IdLov NUMBER REFERENCES Lovac(IdLovca),
    ImePP VARCHAR2(50) REFERENCES PoznatiPredstavnik(JedinstvenoIme),
    IdLok NUMBER REFERENCES Lokacija(IdLokacije),
    Vreme DATE,
    Ishod VARCHAR2(255)
);