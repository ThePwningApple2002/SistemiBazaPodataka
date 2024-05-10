INSERT ALL
INTO Cudoviste (IdCudovista, NazivCud, PodTipCud, VekPomCud) VALUES (1, 'Vampir', 'Natprirodno bice', 200)
INTO Cudoviste (IdCudovista, NazivCud, PodTipCud, VekPomCud) VALUES (2, 'Grifon', 'Mitsko bice', 150)
INTO Cudoviste (IdCudovista, NazivCud, PodTipCud, VekPomCud) VALUES (3, 'Sirena', 'Mitsko bice', 500)
INTO Cudoviste (IdCudovista, NazivCud, PodTipCud, VekPomCud) VALUES (4, 'Banshee', 'Duša iz vatre', 50)
INTO Cudoviste (IdCudovista, NazivCud, PodTipCud, VekPomCud) VALUES (5, 'Golem', 'Veštaćko bice', 100)
SELECT * FROM dual;

INSERT ALL
INTO MagCudoviste (IdCudovista, Postojanje) VALUES (1, 'Da')
INTO MagCudoviste (IdCudovista, Postojanje) VALUES (2, 'Da')
INTO MagCudoviste (IdCudovista, Postojanje) VALUES (3, 'Da')
SELECT * FROM dual;

INSERT ALL
INTO NeMagCudoviste (IdCudovista, Visina, Duzina, Kandze, BrojGlava, ZiviUVodi, Leti, Otrovno, Tezina) VALUES (1, 180, 200, 'Oštre', 1, 'Da', 'Ne', 'Da', 70)
INTO NeMagCudoviste (IdCudovista, Visina, Duzina, Kandze, BrojGlava, ZiviUVodi, Leti, Otrovno, Tezina) VALUES (5, 120, 150, 'Oštre', 0, 'Da', 'Ne', 'Ne', 80)
SELECT * FROM dual;

INSERT ALL
INTO SpecSposobnost (IdSpecSpos, NazivSpecSpos) VALUES (1, 'Teleportacija', 1)
INTO SpecSposobnost (IdSpecSpos, NazivSpecSpos) VALUES (5, 'Infravisio', 5)
SELECT * FROM dual;

INSERT ALL
INTO MagSposobnost (IdMagSpos, NazivMagSpos, OpisMagSpos, Ofanzivna, Defanzivna) VALUES (2, 'Led', 'Magija leda', 'Da', 'Da')
INTO MagSposobnost (IdMagSpos, NazivMagSpos, OpisMagSpos, Ofanzivna, Defanzivna) VALUES (3, 'Elektricitet', 'Magija elektriciteta', 'Da', 'Ne')
INTO MagSposobnost (IdMagSpos, NazivMagSpos, OpisMagSpos, Ofanzivna, Defanzivna) VALUES (4, 'Zemlja', 'Magija zemlje', 'Ne', 'Da')
SELECT * FROM dual;

INSERT ALL
INTO Bajalica (IdBajalice, NazivBajalice, Zastita, Prednost) VALUES (2, 'Ogledalo istine', 'Reflektuje magijske napade', 'Otkriva laži')
INTO Bajalica (IdBajalice, NazivBajalice, Zastita, Prednost) VALUES (3, 'Elixir zdravlja', 'Povećava regeneraciju', 'Brže ozdravljenje')
INTO Bajalica (IdBajalice, NazivBajalice, Zastita, Prednost) VALUES (4, 'Amajlija za disanje pod vodom', 'Omogućava disanje pod vodom', 'Omogućava boravak pod vodom')
SELECT * FROM dual;

INSERT ALL
INTO LovacTragaPoznatimPred (IdLovacTragaPP, ImePP, IdLov) VALUES (1, 'Drakula', 1)
INTO LovacTragaPoznatimPred (IdLovacTragaPP, ImePP, IdLov) VALUES (2, 'Griffin Reinhart', 2)
INTO LovacTragaPoznatimPred (IdLovacTragaPP, ImePP, IdLov) VALUES (3, 'Ariel', 3)
INTO LovacTragaPoznatimPred (IdLovacTragaPP, ImePP, IdLov) VALUES (4, 'Sladja', 4)
INTO LovacTragaPoznatimPred (IdLovacTragaPP, ImePP, IdLov) VALUES (5, 'iron Golem', 5)
SELECT * FROM dual;


INSERT ALL
INTO Legenda (IdLegende, PrvoPominjanje, TekstLegende, ZemljaPorekla, ImePoznatogPred) VALUES (1, '1000 BC', 'Legenda o vampiru', 'Rumunia', 'Drakula')
INTO Legenda (IdLegende, PrvoPominjanje, TekstLegende, ZemljaPorekla, ImePoznatogPred) VALUES (2, '500 BC', 'Legenda o grifonu', 'America', 'Griffin Reinhart')
INTO Legenda (IdLegende, PrvoPominjanje, TekstLegende, ZemljaPorekla, ImePoznatogPred) VALUES (3, '200 AD', 'Legenda o sireni', 'Okean', 'Ariel')
INTO Legenda (IdLegende, PrvoPominjanje, TekstLegende, ZemljaPorekla, ImePoznatogPred) VALUES (4, '700 AD', 'Legenda o banshee', 'Irska', 'Sladja')
INTO Legenda (IdLegende, PrvoPominjanje, TekstLegende, ZemljaPorekla, ImePoznatogPred) VALUES (5, '1500 AD', 'Legenda o golemu', 'Engleska', 'iron Golem')
SELECT * FROM dual;


INSERT ALL
INTO PoznatiPredstavnik (JedinstvenoIme, Starost, IdCud) VALUES ('Drakula', 532, 3)
INTO PoznatiPredstavnik (JedinstvenoIme, Starost, IdCud) VALUES ('Griffin Reinhart', 210, 2)
INTO PoznatiPredstavnik (JedinstvenoIme, Starost, IdCud) VALUES ('Ariel', 300, 4)
INTO PoznatiPredstavnik (JedinstvenoIme, Starost, IdCud) VALUES ('Sladja', 150, 5)
INTO PoznatiPredstavnik (JedinstvenoIme, Starost, IdCud) VALUES ('iron Golem', 200, 1)
SELECT * FROM dual;

INSERT ALL
INTO Lokacija (IdLokacije, TipLok, NazivLok, ZemljaLok, Blago, IdLeg) VALUES (1, 'Šuma', 'Transilvanija', 'Rumunija', 'Dragoceni metali', 1)
INTO Lokacija (IdLokacije, TipLok, NazivLok, ZemljaLok, Blago, IdLeg) VALUES (2, 'Planina', 'Himalaji', 'Indija', 'Retki kristali', 2)
INTO Lokacija (IdLokacije, TipLok, NazivLok, ZemljaLok, Blago, IdLeg) VALUES (3, 'More', 'Egejsko more', 'Grcka', 'Skupocene perle', 3)
INTO Lokacija (IdLokacije, TipLok, NazivLok, ZemljaLok, Blago, IdLeg) VALUES (4, 'Pećina', 'Black Forest', 'Nemačka', 'Stari artefakti', 4)
INTO Lokacija (IdLokacije, TipLok, NazivLok, ZemljaLok, Blago, IdLeg) VALUES (5, 'Močvara', 'Loch Ness', 'Škotska', 'Zlatnik iz doba Vikinzi', 5)
SELECT * FROM dual;

INSERT ALL
INTO Zastita (IdZastite, TipZastite, NazivZastite, IdLok) VALUES (1, 'Fizička', 'Štit', 1)
INTO Zastita (IdZastite, TipZastite, NazivZastite, IdLok) VALUES (2, 'Magijska', 'Ogledalo', 2)
INTO Zastita (IdZastite, TipZastite, NazivZastite, IdLok) VALUES (3, 'Zdravstvena', 'Elixir', 3)
INTO Zastita (IdZastite, TipZastite, NazivZastite, IdLok) VALUES (4, 'Magijska', 'Amajlija', 4)
INTO Zastita (IdZastite, TipZastite, NazivZastite, IdLok) VALUES (5, 'Fizička', 'Odelo', 5)
SELECT * FROM dual;


INSERT ALL
INTO Lovac (IdLovca, ImeLovca) VALUES (1, 'Van Helsing')
INTO Lovac (IdLovca, ImeLovca) VALUES (2, 'Persej')
INTO Lovac (IdLovca, ImeLovca) VALUES (3, 'Sam Winchester')
INTO Lovac (IdLovca, ImeLovca) VALUES (4, 'Hercules')
INTO Lovac (IdLovca, ImeLovca) VALUES (5, 'Geralt of Rivia')
SELECT * FROM dual;

INSERT ALL
INTO Protivmere (IdProtivmere, NazivProtivmere, OpisProtivmere) VALUES (1, 'Sveta voda', 'Efikasna protiv vampira')
INTO Protivmere (IdProtivmere, NazivProtivmere, OpisProtivmere) VALUES (2, 'Srebrni metak', 'Uobičajeno oružje protiv vukodlaka')
INTO Protivmere (IdProtivmere, NazivProtivmere, OpisProtivmere) VALUES (3, 'Šiljci od češnjaka', 'Odbija vampire')
INTO Protivmere (IdProtivmere, NazivProtivmere, OpisProtivmere) VALUES (4, 'Svetlo', 'Oštetljivo za mračna bića')
INTO Protivmere (IdProtivmere, NazivProtivmere, OpisProtivmere) VALUES (5, 'Čarobni pepeo', 'Neutrališe čini')
SELECT * FROM dual;

INSERT ALL
INTO Predmet (IdPredmeta, TipPredmeta, NazivPredmeta, MaterijalPredmeta) VALUES (1, 'Oružje', 'Mač', 'Čelik')
INTO Predmet (IdPredmeta, TipPredmeta, NazivPredmeta, MaterijalPredmeta) VALUES (2, 'Oružje', 'Sekira', 'Bronza')
INTO Predmet (IdPredmeta, TipPredmeta, NazivPredmeta, MaterijalPredmeta) VALUES (3, 'Amajlija', 'Krst', 'Drvo')
INTO Predmet (IdPredmeta, TipPredmeta, NazivPredmeta, MaterijalPredmeta) VALUES (4, 'Svetiljka', 'Laterna', 'Bakar')
INTO Predmet (IdPredmeta, TipPredmeta, NazivPredmeta, MaterijalPredmeta) VALUES (5, 'Magični prah', 'Eliksir', 'Mirisna sol')
SELECT * FROM dual;

INSERT ALL
INTO UsloviZaPrimenu (IdUslova, Uslov, IdProtivM) VALUES (1, 'Naneti na neprijatelja', 1)
INTO UsloviZaPrimenu (IdUslova, Uslov, IdProtivM) VALUES (2, 'Pogoditi vukodlaka', 2)
INTO UsloviZaPrimenu (IdUslova, Uslov, IdProtivM) VALUES (3, 'Približiti se vampiru', 3)
INTO UsloviZaPrimenu (IdUslova, Uslov, IdProtivM) VALUES (4, 'Upaliti svetiljku', 4)
INTO UsloviZaPrimenu (IdUslova, Uslov, IdProtivM) VALUES (5, 'Raspršiti magični prah', 5)
SELECT * FROM dual;

INSERT ALL
INTO ProtivmeraPosedujePredmet (IdPPP, IdPred, IdPM) VALUES (1, 1, 1)
INTO ProtivmeraPosedujePredmet (IdPPP, IdPred, IdPM) VALUES (2, 2, 2)
INTO ProtivmeraPosedujePredmet (IdPPP, IdPred, IdPM) VALUES (3, 3, 3)
INTO ProtivmeraPosedujePredmet (IdPPP, IdPred, IdPM) VALUES (4, 4, 4)
INTO ProtivmeraPosedujePredmet (IdPPP, IdPred, IdPM) VALUES (5, 5, 5)
SELECT * FROM dual;

INSERT ALL
INTO BajalicaProtivMagCud (IdBaj, IdCud, IdBajalicaPMagCud) VALUES (2, 2, 2)
INTO BajalicaProtivMagCud (IdBaj, IdCud, IdBajalicaPMagCud) VALUES (3, 3, 3)
INTO BajalicaProtivMagCud (IdBaj, IdCud, IdBajalicaPMagCud) VALUES (4, 4, 4)
SELECT * FROM dual;

INSERT ALL

INTO CudImaMagSpos (IdCud, IdMagicnaSpos, IdCudMagSpos) VALUES (2, 2, 2)
INTO CudImaMagSpos (IdCud, IdMagicnaSpos, IdCudMagSpos) VALUES (3, 3, 3)
INTO CudImaMagSpos (IdCud, IdMagicnaSpos, IdCudMagSpos) VALUES (4, 4, 4)

SELECT * FROM dual;

INSERT ALL
INTO CudImaSpecSpos (IdCud, IdSpecijalnaSpos, IdCudSpecSpos) VALUES (1, 1, 1)
INTO CudImaSpecSpos (IdCud, IdSpecijalnaSpos, IdCudSpecSpos) VALUES (5, 5, 5)
SELECT * FROM dual;

INSERT ALL
INTO PostojiLegenda (IdCud, IdLeg, idpostojilegenda) VALUES (1, 1,1)
INTO PostojiLegenda (IdCud, IdLeg, idpostojilegenda) VALUES (2, 2,2)
INTO PostojiLegenda (IdCud, IdLeg, idpostojilegenda) VALUES (3, 3,3)
INTO PostojiLegenda (IdCud, IdLeg, idpostojilegenda) VALUES (4, 4,4)
INTO PostojiLegenda (IdCud, IdLeg, idpostojilegenda) VALUES (5, 5,5)
SELECT * FROM dual;

INSERT ALL
INTO ProtivCud (IdProtivCud, IdCud, IdPM) VALUES (1, 1, 1)
INTO ProtivCud (IdProtivCud, IdCud, IdPM) VALUES (2, 2, 2)
INTO ProtivCud (IdProtivCud, IdCud, IdPM) VALUES (3, 3, 3)
INTO ProtivCud (IdProtivCud, IdCud, IdPM) VALUES (4, 4, 4)
INTO ProtivCud (IdProtivCud, IdCud, IdPM) VALUES (5, 5, 5)
SELECT * FROM dual;

INSERT ALL
INTO Susret (IdSusret, IdLov, ImePP, IdLok, Vreme, Ishod) VALUES (1, 1, 'Drakula', 1, '2023-05-15', 'Pobeda lovca')
INTO Susret (IdSusret, IdLov, ImePP, IdLok, Vreme, Ishod) VALUES (2, 2, 'Griffin Reinhart', 2, '2022-09-20', 'Poraz lovca')
INTO Susret (IdSusret, IdLov, ImePP, IdLok, Vreme, Ishod) VALUES (3, 3, 'Ariel', 3, '2024-01-10', 'Sukob izbegnut')
INTO Susret (IdSusret, IdLov, ImePP, IdLok, Vreme, Ishod) VALUES (4, 4, 'Sladja', 4, '2023-11-05', 'Neodlučan ishod')
INTO Susret (IdSusret, IdLov, ImePP, IdLok, Vreme, Ishod) VALUES (5, 5, 'iron Golem', 5, '2022-12-30', 'Pobeda predstavnika')
SELECT * FROM dual;

