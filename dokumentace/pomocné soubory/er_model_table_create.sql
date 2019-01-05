CREATE TABLE katedra (
    id_k integer NOT NULL,
    zkr_k NVARCHAR NOT NULL,
    naz_k NVARCHAR NOT NULL,
    PRIMARY KEY (id_k)
);

CREATE TABLE obor (
    id_obor integer NOT NULL,
    zkr_obor NVARCHAR NOT NULL,
    name_obor NVARCHAR NOT NULL,
    rok_obor nvarchar(50) NOT NULL,
    p_obor integer NOT NULL,
    pv_obor integer NOT NULL,
    v_obor integer NOT NULL,
    vs_obor integer NOT NULL,
    PRIMARY KEY (id_obor)
);

CREATE TABLE  vyucujici(
    id_v integer NOT NULL,
    jmeno_v NVARCHAR NOT NULL,
    email_v NVARCHAR NOT NULL,
    ntel_v varchar(50),
    nkonz_v NVARCHAR,
    id_k integer NOT NULL,
    PRIMARY KEY (id_v),
    CONSTRAINT FK_vyuc_katedra FOREIGN KEY (id_k) REFERENCES katedra(id_k);
);

CREATE TABLE vyucuje (
    id_vyuc integer NOT NULL,
    garant_vyuc boolean NOT NULL,
    id_predmet integer NOT NULL,
    id_v integer NOT NULL,
    PRIMARY KEY (id_vyuc),
    CONSTRAINT FK_vyucuje_predmet FOREIGN KEY (id_predmet) REFERENCES predmet(id_predmet);
	CONSTRAINT FK_vyucuje_vyuc FOREIGN KEY (id_v) REFERENCES vyucujici(id_v);
);

CREATE TABLE  predmet(
    id_predmet integer NOT NULL,
    name_predmet NVARCHAR NOT NULL,
    zkr_predmet NVARCHAR NOT NULL,
    kredit_predmet integer NOT NULL,
    id_obor integer NOT NULL,
    PRIMARY KEY (id_predmet),
    CONSTRAINT FK_predmet_obor FOREIGN KEY (id_obor) REFERENCES obor(id_obor)
);

CREATE TABLE popis (
    id_popis integer NOT NULL,
    nazev_popis varchar(10) NOT NULL,
    text_popis varchar(1000) NOT NULL,
    id_predmet integer NOT NULL,
    PRIMARY KEY (id_popis),
    CONSTRAINT FK_popis_predmet FOREIGN KEY (id_predmet) REFERENCES predmet(id_predmet);
);

CREATE TABLE  zaznam(
    id_zaznam integer NOT NULL,
    zkr_zaznam NVARCHAR NOT NULL,
    id_obor integer NOT NULL,
    PRIMARY KEY (id_zaznam),
    CONSTRAINT FK_zaznam_obor FOREIGN KEY (id_obor) REFERENCES obor(id_obor)
);

CREATE TABLE plansemestr (
    id_ps integer NOT NULL,
    sem_ps integer NOT NULL,
    id_zaznam integer NOT NULL,
    PRIMARY KEY (id_ps),
    CONSTRAINT FK_ps_zaznam FOREIGN KEY (id_zaznam) REFERENCES zaznam(id_zaznam);
);

CREATE TABLE vyber (
    id_vyber integer NOT NULL,
    id_predmet integer NOT NULL,
    id_ps integer NOT NULL,
    PRIMARY KEY (id_vyber),
    CONSTRAINT FK_vyber_predmet FOREIGN KEY (id_predmet) REFERENCES predmet(id_predmet);
	CONSTRAINT FK_vyber_ps FOREIGN KEY (id_ps) REFERENCES plansemestr(id_ps);
);