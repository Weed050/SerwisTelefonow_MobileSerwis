START TRANSACTION;

INSERT INTO klient (id, imie, nazwisko, telefon)
VALUES (1, 'Adrian', 'Kowalczyk', '123123123');
INSERT INTO klient (id, imie, nazwisko, telefon)
VALUES (2, 'Kondrat', 'Kwaśniak', '415617154');
INSERT INTO klient (id, imie, nazwisko, telefon)
VALUES (3, 'Karol', 'Marek', '918472948');

INSERT INTO model_kod (kod_modelu, marka, pelna_nazwa)
VALUES ('MI12PRO', 'Xiaomi', 'Xiaomi 12 Pro');
INSERT INTO model_kod (kod_modelu, marka, pelna_nazwa)
VALUES ('PIXEL7P', 'Google', 'Google Pixel 7 Pro');
INSERT INTO model_kod (kod_modelu, marka, pelna_nazwa)
VALUES ('REDMIN10', 'Xiaomi', 'Redmi Note 10');
INSERT INTO model_kod (kod_modelu, marka, pelna_nazwa)
VALUES ('SM-A525F', 'Samsung', 'Samsung Galaxy A52');

INSERT INTO wpis_serwisowy (id, cena_koncowa, cena_wstepna, imei, klient_id, kod_modelu, opis)
VALUES (1, NULL, 50.0, '123456789012345', 1, 'PIXEL7P', 'Telefon się nie włącza, możliwe zalanie cieczą.');
INSERT INTO wpis_serwisowy (id, cena_koncowa, cena_wstepna, imei, klient_id, kod_modelu, opis)
VALUES (2, 600.0, 550.0, '123456789012345', 1, 'MI12PRO', 'Rozbity ekran');
INSERT INTO wpis_serwisowy (id, cena_koncowa, cena_wstepna, imei, klient_id, kod_modelu, opis)
VALUES (3, NULL, 35.0, '123461719012345', 2, 'REDMIN10', 'Telefon się nie włącza, oraz nie reaguje na podpięcie do ładowarki.');

SELECT setval(
    pg_get_serial_sequence('klient', 'id'),
    GREATEST(
        (SELECT MAX(id) FROM klient) + 1,
        nextval(pg_get_serial_sequence('klient', 'id'))),
    false);

SELECT setval(
    pg_get_serial_sequence('wpis_serwisowy', 'id'),
    GREATEST(
        (SELECT MAX(id) FROM wpis_serwisowy) + 1,
        nextval(pg_get_serial_sequence('wpis_serwisowy', 'id'))),
    false);

COMMIT;
