CREATE TABLE public. (
    id_zaznam integer NOT NULL,
    zkr_zaznam NVARCHAR NOT NULL,
    id_obor integer NOT NULL,
    PRIMARY KEY (id_zaznam)
);

CREATE INDEX ON public.
    (id_obor);


CREATE TABLE public. (
    id_ps integer NOT NULL,
    sem_ps integer NOT NULL,
    id_zaznam integer NOT NULL,
    PRIMARY KEY (id_ps)
);

CREATE INDEX ON public.
    (id_zaznam);


CREATE TABLE public. (
    id_vyber integer NOT NULL,
    id_predmet integer NOT NULL,
    id_ps integer NOT NULL,
    PRIMARY KEY (id_vyber)
);

CREATE INDEX ON public.
    (id_predmet);
CREATE INDEX ON public.
    (id_ps);


CREATE TABLE public. (
    id_predmet integer NOT NULL,
    name_predmet NVARCHAR NOT NULL,
    zkr_predmet NVARCHAR NOT NULL,
    kredit_predmet integer NOT NULL,
    id_obor integer NOT NULL,
    PRIMARY KEY (id_predmet)
);

CREATE INDEX ON public.
    (id_obor);


CREATE TABLE public. (
    id_v integer NOT NULL,
    jmeno_v NVARCHAR NOT NULL,
    email_v NVARCHAR NOT NULL,
    ntel_v varchar(50),
    nkonz_v NVARCHAR,
    id_k integer NOT NULL,
    PRIMARY KEY (id_v)
);

CREATE INDEX ON public.
    (id_k);


CREATE TABLE public.popis (
    id_popis integer NOT NULL,
    nazev_popis varchar(10) NOT NULL,
    text_popis varchar(1000) NOT NULL,
    id_predmet integer NOT NULL,
    PRIMARY KEY (id_popis)
);

CREATE INDEX ON public.popis
    (id_predmet);


CREATE TABLE public.obor (
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


CREATE TABLE public. (
    id_vyuc integer NOT NULL,
    garant_vyuc boolean NOT NULL,
    id_predmet integer NOT NULL,
    id_v integer NOT NULL,
    PRIMARY KEY (id_vyuc)
);

CREATE INDEX ON public.
    (id_predmet);
CREATE INDEX ON public.
    (id_v);


CREATE TABLE public.katedra (
    id_k integer NOT NULL,
    zkr_k NVARCHAR NOT NULL,
    naz_k NVARCHAR NOT NULL,
    PRIMARY KEY (id_k)
);


ALTER TABLE public. ADD CONSTRAINT FK___id_obor FOREIGN KEY (id_obor) REFERENCES public.obor(id_obor);
ALTER TABLE public. ADD CONSTRAINT FK___id_zaznam FOREIGN KEY (id_zaznam) REFERENCES public.(id_zaznam);
ALTER TABLE public. ADD CONSTRAINT FK___id_predmet FOREIGN KEY (id_predmet) REFERENCES public.(id_predmet);
ALTER TABLE public. ADD CONSTRAINT FK___id_ps FOREIGN KEY (id_ps) REFERENCES public.(id_ps);
ALTER TABLE public. ADD CONSTRAINT FK___id_obor FOREIGN KEY (id_obor) REFERENCES public.obor(id_obor);
ALTER TABLE public. ADD CONSTRAINT FK___id_k FOREIGN KEY (id_k) REFERENCES public.katedra(id_k);
ALTER TABLE public.popis ADD CONSTRAINT FK_popis__id_predmet FOREIGN KEY (id_predmet) REFERENCES public.(id_predmet);
ALTER TABLE public. ADD CONSTRAINT FK___id_predmet FOREIGN KEY (id_predmet) REFERENCES public.(id_predmet);
ALTER TABLE public. ADD CONSTRAINT FK___id_v FOREIGN KEY (id_v) REFERENCES public.(id_v);