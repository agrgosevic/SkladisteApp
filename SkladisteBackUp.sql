PGDMP     ;    ;                x           TBP_Baza    12.2    12.2 ?    ]           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ^           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            _           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            `           1262    24663    TBP_Baza    DATABASE     �   CREATE DATABASE "TBP_Baza" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Croatian_Croatia.1250' LC_CTYPE = 'Croatian_Croatia.1250';
    DROP DATABASE "TBP_Baza";
                admin    false            �            1255    25016    ažuriranje_ukupne_kolicine()    FUNCTION     �  CREATE FUNCTION public."ažuriranje_ukupne_kolicine"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$BEGIN

UPDATE public."Artikl" SET ukupna_kolicina = (SELECT SUM(trenutna_kolicina) from public."Stanje_na_skladistu" 
											   WHERE "Artikl_id_narudzba_artikla" =new."Artikl_id_narudzba_artikla" 
											 GROUP BY "Artikl_id_narudzba_artikla")
WHERE new."Artikl_id_narudzba_artikla" ="idArtikl";
RETURN NEW;
END;$$;
 6   DROP FUNCTION public."ažuriranje_ukupne_kolicine"();
       public          admin    false            �            1255    25005    dodavanje_na_stanje()    FUNCTION     �  CREATE FUNCTION public.dodavanje_na_stanje() RETURNS trigger
    LANGUAGE plpgsql
    AS $$BEGIN

INSERT INTO public."Stanje_na_skladistu"(trenutna_kolicina, datum, "Artikl_id_narudzba_artikla", "Narudzba_id_Narudzba_artikala")
VALUES(new.kolicina, (SELECT datum FROM public."Narudzba" WHERE "idNarudzba"=new."Narudzba_id_narudzba" limit 1), new."Artikl_id_artikl", new."Narudzba_id_narudzba");
RETURN NEW;
END;$$;
 ,   DROP FUNCTION public.dodavanje_na_stanje();
       public          admin    false            �            1255    25009 K   funkcija_dodavanje_narudzbe(integer, integer, date, text, integer, integer)    FUNCTION     ^  CREATE FUNCTION public.funkcija_dodavanje_narudzbe(zaposlenik_id integer, dobavljac_id integer, datum_narudzbe date, opis_narudzbe text, kolicina_narudzbe integer, artikl_id integer) RETURNS void
    LANGUAGE sql
    AS $$INSERT INTO public."Narudzba"(datum, opis, "Zaposlenik_id_zaposlenik", "Dobavljac_id_dobavljac") 
VALUES (datum_narudzbe, opis_narudzbe, zaposlenik_id, dobavljac_id);

INSERT INTO public."Narudzba_artikla"(kolicina, "Artikl_id_artikl", "Narudzba_id_narudzba") 
VALUES (kolicina_narudzbe, artikl_id, (SELECT "idNarudzba" FROM public."Narudzba" ORDER BY "idNarudzba" DESC LIMIT 1));$$;
 �   DROP FUNCTION public.funkcija_dodavanje_narudzbe(zaposlenik_id integer, dobavljac_id integer, datum_narudzbe date, opis_narudzbe text, kolicina_narudzbe integer, artikl_id integer);
       public          admin    false            �            1255    25021 _   funkcija_oduzimanje_sa_stanja(integer, integer, date, text, integer, integer, integer, integer)    FUNCTION     :  CREATE FUNCTION public.funkcija_oduzimanje_sa_stanja(zaposlenik_id integer, kupac_id integer, datum_radni_nalog date, opis_radni_nalog text, kolicina_radni_nalog integer, artikl_id integer, radni_nalog_id integer, stanje_id integer) RETURNS void
    LANGUAGE sql
    AS $$INSERT INTO public."Radni_nalog"(datum, opis, "Zaposlenik_id_zaposlenik", "Kupac_id_kupac") 
VALUES (datum_radni_nalog, opis_radni_nalog, zaposlenik_id, kupac_id);

INSERT INTO public."Stavka_artikla_na_RN"(kolicina, "Radni_nalog_id_Radni_nalog", "Stavka_Artikl_id_artikl") 
VALUES (kolicina_radni_nalog, (SELECT "idRadni_nalog" FROM public."Radni_nalog" ORDER BY "idRadni_nalog" DESC LIMIT 1), artikl_id);

UPDATE public."Stanje_na_skladistu" SET trenutna_kolicina = trenutna_kolicina - kolicina_radni_nalog
WHERE "idStanjaNaSkladistu" = stanje_id;
$$;
 �   DROP FUNCTION public.funkcija_oduzimanje_sa_stanja(zaposlenik_id integer, kupac_id integer, datum_radni_nalog date, opis_radni_nalog text, kolicina_radni_nalog integer, artikl_id integer, radni_nalog_id integer, stanje_id integer);
       public          admin    false            �            1255    25025    provjera_max_kolicine()    FUNCTION     �  CREATE FUNCTION public.provjera_max_kolicine() RETURNS trigger
    LANGUAGE plpgsql
    AS $$BEGIN

IF new.kolicina <= (SELECT max_kolicina FROM public."Artikl" WHERE new."Artikl_id_artikl" = "idArtikl")-
(SELECT ukupna_kolicina FROM public."Artikl" WHERE new."Artikl_id_artikl" = "idArtikl") THEN
	RETURN NEW;
ELSE
	RAISE EXCEPTION '\%', 'Unesena kolicina mora biti manja od maksimalne kolicine tog artikla!';
END IF;

END;$$;
 .   DROP FUNCTION public.provjera_max_kolicine();
       public          admin    false            �            1255    25023    provjera_min_kolicine()    FUNCTION     \  CREATE FUNCTION public.provjera_min_kolicine() RETURNS trigger
    LANGUAGE plpgsql
    AS $$BEGIN

IF new.kolicina > (SELECT min_kolicina FROM public."Artikl" WHERE new."Artikl_id_artikl" = "idArtikl") THEN
	RETURN NEW;
ELSE
	RAISE EXCEPTION '\%', 'Unesena kolicina mora biti veća od definirane minimalne kolicine tog artikla!';
END IF;

END;$$;
 .   DROP FUNCTION public.provjera_min_kolicine();
       public          admin    false            �            1255    25027    provjera_radni_nalog_min()    FUNCTION     �  CREATE FUNCTION public.provjera_radni_nalog_min() RETURNS trigger
    LANGUAGE plpgsql
    AS $$BEGIN

IF new.kolicina <= ((SELECT ukupna_kolicina FROM public."Artikl" WHERE new."Stavka_Artikl_id_artikl" = "idArtikl")-
(SELECT min_kolicina FROM public."Artikl" WHERE  new."Stavka_Artikl_id_artikl" = "idArtikl"))
THEN
	RETURN NEW;
ELSE
	RAISE EXCEPTION '\%', 'Unesena kolicina ne smije dovesti ukupnu kolicinu artikla ispod minimalne kolicine!';
END IF;
END;
$$;
 1   DROP FUNCTION public.provjera_radni_nalog_min();
       public          admin    false            �            1259    24740    Artikl    TABLE     9  CREATE TABLE public."Artikl" (
    "idArtikl" integer NOT NULL,
    naziv character varying(45) NOT NULL,
    nabavna_cijena double precision NOT NULL,
    min_kolicina integer NOT NULL,
    max_kolicina integer NOT NULL,
    ukupna_kolicina integer NOT NULL,
    jedinica_mjere character varying(45) NOT NULL
);
    DROP TABLE public."Artikl";
       public         heap    admin    false            �            1259    24738    Artikl_idArtikl_seq    SEQUENCE     �   ALTER TABLE public."Artikl" ALTER COLUMN "idArtikl" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Artikl_idArtikl_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 10000
    CACHE 1
    CYCLE
);
            public          admin    false    213            �            1259    24674 	   Dobavljac    TABLE     �   CREATE TABLE public."Dobavljac" (
    "idDobavljac" integer NOT NULL,
    naziv character varying(45) NOT NULL,
    email character varying(45) NOT NULL
);
    DROP TABLE public."Dobavljac";
       public         heap    admin    false            �            1259    24679    Dobavljac_idDobavljac_seq    SEQUENCE     �   ALTER TABLE public."Dobavljac" ALTER COLUMN "idDobavljac" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Dobavljac_idDobavljac_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 1000
    CACHE 1
);
            public          admin    false    204            �            1259    24664    Kupac    TABLE     j   CREATE TABLE public."Kupac" (
    "idKupac" integer NOT NULL,
    naziv character varying(45) NOT NULL
);
    DROP TABLE public."Kupac";
       public         heap    admin    false            �            1259    24681    Kupac_idKupac_seq    SEQUENCE     �   ALTER TABLE public."Kupac" ALTER COLUMN "idKupac" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Kupac_idKupac_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 1000
    CACHE 1
);
            public          admin    false    202            �            1259    24723    Narudzba    TABLE     �   CREATE TABLE public."Narudzba" (
    "idNarudzba" integer NOT NULL,
    datum date NOT NULL,
    opis character varying(100),
    "Zaposlenik_id_zaposlenik" integer NOT NULL,
    "Dobavljac_id_dobavljac" integer NOT NULL
);
    DROP TABLE public."Narudzba";
       public         heap    admin    false            �            1259    24757    Narudzba_artikla    TABLE     �   CREATE TABLE public."Narudzba_artikla" (
    kolicina integer NOT NULL,
    "Artikl_id_artikl" integer,
    "Narudzba_id_narudzba" integer
);
 &   DROP TABLE public."Narudzba_artikla";
       public         heap    admin    false            �            1259    24721    Narudzba_idNarudzba_seq    SEQUENCE     �   ALTER TABLE public."Narudzba" ALTER COLUMN "idNarudzba" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Narudzba_idNarudzba_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 10000
    CACHE 1
);
            public          admin    false    211            �            1259    24704    Radni_nalog    TABLE     �   CREATE TABLE public."Radni_nalog" (
    "idRadni_nalog" integer NOT NULL,
    datum date NOT NULL,
    opis character varying(100) NOT NULL,
    "Zaposlenik_id_zaposlenik" integer NOT NULL,
    "Kupac_id_kupac" integer NOT NULL
);
 !   DROP TABLE public."Radni_nalog";
       public         heap    admin    false            �            1259    24719    Radni_nalog_idRadni_nalog_seq    SEQUENCE     �   ALTER TABLE public."Radni_nalog" ALTER COLUMN "idRadni_nalog" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Radni_nalog_idRadni_nalog_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 10000
    CACHE 1
);
            public          admin    false    208            �            1259    24904    Stanje_na_skladistu    TABLE     �   CREATE TABLE public."Stanje_na_skladistu" (
    "idStanjaNaSkladistu" integer NOT NULL,
    trenutna_kolicina integer NOT NULL,
    datum date NOT NULL,
    "Artikl_id_narudzba_artikla" integer,
    "Narudzba_id_Narudzba_artikala" integer
);
 )   DROP TABLE public."Stanje_na_skladistu";
       public         heap    admin    false            �            1259    24902 +   Stanje_na_skladistu_idStanjaNaSkladistu_seq    SEQUENCE       ALTER TABLE public."Stanje_na_skladistu" ALTER COLUMN "idStanjaNaSkladistu" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Stanje_na_skladistu_idStanjaNaSkladistu_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 10000
    CACHE 1
);
            public          admin    false    217            �            1259    24770    Stavka_artikla_na_RN    TABLE     �   CREATE TABLE public."Stavka_artikla_na_RN" (
    kolicina integer NOT NULL,
    "Radni_nalog_id_Radni_nalog" integer,
    "Stavka_Artikl_id_artikl" integer
);
 *   DROP TABLE public."Stavka_artikla_na_RN";
       public         heap    admin    false            �            1259    24669 
   Zaposlenik    TABLE     �   CREATE TABLE public."Zaposlenik" (
    "idZaposlenik" integer NOT NULL,
    ime character varying(45) NOT NULL,
    prezime character varying(45) NOT NULL,
    kontakt character varying(45) NOT NULL,
    email character varying(45) NOT NULL
);
     DROP TABLE public."Zaposlenik";
       public         heap    admin    false            �            1259    24683    Zaposlenik_idZaposlenik_seq    SEQUENCE     �   ALTER TABLE public."Zaposlenik" ALTER COLUMN "idZaposlenik" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Zaposlenik_idZaposlenik_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 1000
    CACHE 1
);
            public          admin    false    203            V          0    24740    Artikl 
   TABLE DATA           �   COPY public."Artikl" ("idArtikl", naziv, nabavna_cijena, min_kolicina, max_kolicina, ukupna_kolicina, jedinica_mjere) FROM stdin;
    public          admin    false    213   �\       M          0    24674 	   Dobavljac 
   TABLE DATA           B   COPY public."Dobavljac" ("idDobavljac", naziv, email) FROM stdin;
    public          admin    false    204   �]       K          0    24664    Kupac 
   TABLE DATA           3   COPY public."Kupac" ("idKupac", naziv) FROM stdin;
    public          admin    false    202   �]       T          0    24723    Narudzba 
   TABLE DATA           u   COPY public."Narudzba" ("idNarudzba", datum, opis, "Zaposlenik_id_zaposlenik", "Dobavljac_id_dobavljac") FROM stdin;
    public          admin    false    211   ^       W          0    24757    Narudzba_artikla 
   TABLE DATA           b   COPY public."Narudzba_artikla" (kolicina, "Artikl_id_artikl", "Narudzba_id_narudzba") FROM stdin;
    public          admin    false    214   �_       Q          0    24704    Radni_nalog 
   TABLE DATA           s   COPY public."Radni_nalog" ("idRadni_nalog", datum, opis, "Zaposlenik_id_zaposlenik", "Kupac_id_kupac") FROM stdin;
    public          admin    false    208   `       Z          0    24904    Stanje_na_skladistu 
   TABLE DATA           �   COPY public."Stanje_na_skladistu" ("idStanjaNaSkladistu", trenutna_kolicina, datum, "Artikl_id_narudzba_artikla", "Narudzba_id_Narudzba_artikala") FROM stdin;
    public          admin    false    217   �`       X          0    24770    Stavka_artikla_na_RN 
   TABLE DATA           s   COPY public."Stavka_artikla_na_RN" (kolicina, "Radni_nalog_id_Radni_nalog", "Stavka_Artikl_id_artikl") FROM stdin;
    public          admin    false    215   Sa       L          0    24669 
   Zaposlenik 
   TABLE DATA           T   COPY public."Zaposlenik" ("idZaposlenik", ime, prezime, kontakt, email) FROM stdin;
    public          admin    false    203   �a       a           0    0    Artikl_idArtikl_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."Artikl_idArtikl_seq"', 46, true);
          public          admin    false    212            b           0    0    Dobavljac_idDobavljac_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."Dobavljac_idDobavljac_seq"', 4, true);
          public          admin    false    205            c           0    0    Kupac_idKupac_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."Kupac_idKupac_seq"', 3, true);
          public          admin    false    206            d           0    0    Narudzba_idNarudzba_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."Narudzba_idNarudzba_seq"', 70, true);
          public          admin    false    210            e           0    0    Radni_nalog_idRadni_nalog_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public."Radni_nalog_idRadni_nalog_seq"', 73, true);
          public          admin    false    209            f           0    0 +   Stanje_na_skladistu_idStanjaNaSkladistu_seq    SEQUENCE SET     \   SELECT pg_catalog.setval('public."Stanje_na_skladistu_idStanjaNaSkladistu_seq"', 44, true);
          public          admin    false    216            g           0    0    Zaposlenik_idZaposlenik_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public."Zaposlenik_idZaposlenik_seq"', 21, true);
          public          admin    false    207            �
           2606    24744    Artikl Artikl_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public."Artikl"
    ADD CONSTRAINT "Artikl_pkey" PRIMARY KEY ("idArtikl");
 @   ALTER TABLE ONLY public."Artikl" DROP CONSTRAINT "Artikl_pkey";
       public            admin    false    213            �
           2606    24678    Dobavljac Dobavljac_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public."Dobavljac"
    ADD CONSTRAINT "Dobavljac_pkey" PRIMARY KEY ("idDobavljac");
 F   ALTER TABLE ONLY public."Dobavljac" DROP CONSTRAINT "Dobavljac_pkey";
       public            admin    false    204            �
           2606    24668    Kupac Kupac_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public."Kupac"
    ADD CONSTRAINT "Kupac_pkey" PRIMARY KEY ("idKupac");
 >   ALTER TABLE ONLY public."Kupac" DROP CONSTRAINT "Kupac_pkey";
       public            admin    false    202            �
           2606    24727    Narudzba Narudzba_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."Narudzba"
    ADD CONSTRAINT "Narudzba_pkey" PRIMARY KEY ("idNarudzba");
 D   ALTER TABLE ONLY public."Narudzba" DROP CONSTRAINT "Narudzba_pkey";
       public            admin    false    211            �
           2606    24708    Radni_nalog Radni_nalog_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public."Radni_nalog"
    ADD CONSTRAINT "Radni_nalog_pkey" PRIMARY KEY ("idRadni_nalog");
 J   ALTER TABLE ONLY public."Radni_nalog" DROP CONSTRAINT "Radni_nalog_pkey";
       public            admin    false    208            �
           2606    24908 ,   Stanje_na_skladistu Stanje_na_skladistu_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public."Stanje_na_skladistu"
    ADD CONSTRAINT "Stanje_na_skladistu_pkey" PRIMARY KEY ("idStanjaNaSkladistu");
 Z   ALTER TABLE ONLY public."Stanje_na_skladistu" DROP CONSTRAINT "Stanje_na_skladistu_pkey";
       public            admin    false    217            �
           2606    24673    Zaposlenik Zaposlenik_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."Zaposlenik"
    ADD CONSTRAINT "Zaposlenik_pkey" PRIMARY KEY ("idZaposlenik");
 H   ALTER TABLE ONLY public."Zaposlenik" DROP CONSTRAINT "Zaposlenik_pkey";
       public            admin    false    203            �
           2620    25019 7   Stanje_na_skladistu ažuriranje_ukupne_kolicine_artikla    TRIGGER     �   CREATE TRIGGER "ažuriranje_ukupne_kolicine_artikla" AFTER INSERT OR UPDATE OF trenutna_kolicina ON public."Stanje_na_skladistu" FOR EACH ROW EXECUTE FUNCTION public."ažuriranje_ukupne_kolicine"();
 T   DROP TRIGGER "ažuriranje_ukupne_kolicine_artikla" ON public."Stanje_na_skladistu";
       public          admin    false    217    232    217            �
           2620    25011 ,   Narudzba_artikla dodavanje_artikla_na_stanje    TRIGGER     �   CREATE TRIGGER dodavanje_artikla_na_stanje AFTER INSERT ON public."Narudzba_artikla" FOR EACH ROW EXECUTE FUNCTION public.dodavanje_na_stanje();
 G   DROP TRIGGER dodavanje_artikla_na_stanje ON public."Narudzba_artikla";
       public          admin    false    214    218            �
           2620    25026 .   Narudzba_artikla provjera_artikla_max_kolicine    TRIGGER     �   CREATE TRIGGER provjera_artikla_max_kolicine BEFORE INSERT ON public."Narudzba_artikla" FOR EACH ROW EXECUTE FUNCTION public.provjera_max_kolicine();
 I   DROP TRIGGER provjera_artikla_max_kolicine ON public."Narudzba_artikla";
       public          admin    false    214    233            �
           2620    25024 .   Narudzba_artikla provjera_artikla_min_kolicine    TRIGGER     �   CREATE TRIGGER provjera_artikla_min_kolicine BEFORE INSERT ON public."Narudzba_artikla" FOR EACH ROW EXECUTE FUNCTION public.provjera_min_kolicine();
 I   DROP TRIGGER provjera_artikla_min_kolicine ON public."Narudzba_artikla";
       public          admin    false    214    231            �
           2620    25028 6   Stavka_artikla_na_RN provjera_radni_nalog_min_kolicina    TRIGGER     �   CREATE TRIGGER provjera_radni_nalog_min_kolicina BEFORE INSERT ON public."Stavka_artikla_na_RN" FOR EACH ROW EXECUTE FUNCTION public.provjera_radni_nalog_min();
 Q   DROP TRIGGER provjera_radni_nalog_min_kolicina ON public."Stavka_artikla_na_RN";
       public          admin    false    215    234            �
           2606    24934    Narudzba_artikla fk_artikl    FK CONSTRAINT     �   ALTER TABLE ONLY public."Narudzba_artikla"
    ADD CONSTRAINT fk_artikl FOREIGN KEY ("Artikl_id_artikl") REFERENCES public."Artikl"("idArtikl");
 F   ALTER TABLE ONLY public."Narudzba_artikla" DROP CONSTRAINT fk_artikl;
       public          admin    false    213    2749    214            �
           2606    24954    Narudzba fk_dobavljac    FK CONSTRAINT     �   ALTER TABLE ONLY public."Narudzba"
    ADD CONSTRAINT fk_dobavljac FOREIGN KEY ("Dobavljac_id_dobavljac") REFERENCES public."Dobavljac"("idDobavljac");
 A   ALTER TABLE ONLY public."Narudzba" DROP CONSTRAINT fk_dobavljac;
       public          admin    false    2743    204    211            �
           2606    24949    Radni_nalog fk_kupac    FK CONSTRAINT     �   ALTER TABLE ONLY public."Radni_nalog"
    ADD CONSTRAINT fk_kupac FOREIGN KEY ("Kupac_id_kupac") REFERENCES public."Kupac"("idKupac");
 @   ALTER TABLE ONLY public."Radni_nalog" DROP CONSTRAINT fk_kupac;
       public          admin    false    208    202    2739            �
           2606    24939    Narudzba_artikla fk_narudzba    FK CONSTRAINT     �   ALTER TABLE ONLY public."Narudzba_artikla"
    ADD CONSTRAINT fk_narudzba FOREIGN KEY ("Narudzba_id_narudzba") REFERENCES public."Narudzba"("idNarudzba");
 H   ALTER TABLE ONLY public."Narudzba_artikla" DROP CONSTRAINT fk_narudzba;
       public          admin    false    214    2747    211            �
           2606    24999 #   Stavka_artikla_na_RN fk_radni_nalog    FK CONSTRAINT     �   ALTER TABLE ONLY public."Stavka_artikla_na_RN"
    ADD CONSTRAINT fk_radni_nalog FOREIGN KEY ("Radni_nalog_id_Radni_nalog") REFERENCES public."Radni_nalog"("idRadni_nalog");
 O   ALTER TABLE ONLY public."Stavka_artikla_na_RN" DROP CONSTRAINT fk_radni_nalog;
       public          admin    false    2745    215    208            �
           2606    24994 %   Stavka_artikla_na_RN fk_stavka_artikl    FK CONSTRAINT     �   ALTER TABLE ONLY public."Stavka_artikla_na_RN"
    ADD CONSTRAINT fk_stavka_artikl FOREIGN KEY ("Stavka_Artikl_id_artikl") REFERENCES public."Artikl"("idArtikl");
 Q   ALTER TABLE ONLY public."Stavka_artikla_na_RN" DROP CONSTRAINT fk_stavka_artikl;
       public          admin    false    215    2749    213            �
           2606    24944    Radni_nalog fk_zaposlenik    FK CONSTRAINT     �   ALTER TABLE ONLY public."Radni_nalog"
    ADD CONSTRAINT fk_zaposlenik FOREIGN KEY ("Zaposlenik_id_zaposlenik") REFERENCES public."Zaposlenik"("idZaposlenik");
 E   ALTER TABLE ONLY public."Radni_nalog" DROP CONSTRAINT fk_zaposlenik;
       public          admin    false    208    2741    203            �
           2606    24959    Narudzba fk_zaposlenik    FK CONSTRAINT     �   ALTER TABLE ONLY public."Narudzba"
    ADD CONSTRAINT fk_zaposlenik FOREIGN KEY ("Zaposlenik_id_zaposlenik") REFERENCES public."Zaposlenik"("idZaposlenik");
 B   ALTER TABLE ONLY public."Narudzba" DROP CONSTRAINT fk_zaposlenik;
       public          admin    false    211    203    2741            V   �   x�E�;��0D��a�~�J M�m�@���^(�Ͽ$'�*>���ڣ�rD�C�	([���00����h��������� �Q"�;�V^sZ�L��2�'?�7����k��Lú��-=�c��0��Gi{�ˍs(�J���V�%�rL�$M�ő�x!�E��M�����j�x�k��q_ �G&����O�ߟ����Mk      M   6   x�3�t�OJ,��JL6�L�Or�M���2B��D����&qc��1Dy� x�      K   '   x�3���ϫ*��2���L��2���O��K����� �L      T   x  x�m��n�0���S�L���'u�J�&U;��h�:
�O�Lc��=}6�� �J�B�?�׍e�I���\*�vn�i�f��T�i��&I�$�%�Ӿ^����#�8V_� J0�9r�Y�N�%~���f�=1nlk!@�{�Թ�6��*=�p�)�,�q��ᆆĦ(r���6���pr��ƀ��/�D�q���&��9-��
O,4_�`{� �5h���(
�>�r7��4w��"7��u���V�eK/B�B���QNh�~�e�yQO����~<e�o���p�|����l�W(Y���� �J$�����rA���
0�ٗ�ٙ99F��t"^�:~?���8|�H���_/��?^���      W   e   x�%���0��T�q/鿎��o�pCl�C%���o���t�F^��<H�dj����)\�>a926��:+	e��^�W��f��f
u�m|$�6�      Q   �   x�m�A
�@�ur�^���3Q��e-(JK��[�,2L�/����PG�q�7��x{�=���w����o�&=̲��L�������o���U���Q��{!C����k�Wa�6�XЧ�M��tl�yG��RL�      Z   �   x�e�ˍ�0C�d/Y��9�e��c�\V� �?�$%���c�ùo�I+�N���O�&vĦ%f��N�ȇ�t���+1YTn4,i�Ūa�������w�Ě��p��zD��!���32Q����J�t�=����z�'��9/���l���FNFwVi����/N�B�      X   j   x�-���@B�X̟]��%������S�"�`�p�@R��Bo!��k|Gw�w��fO��/�o="�)d@n#�B�Y.&��І
-��QPg��zc:��=?3���w      L   j   x�-��
�0C���7A���2Ɣ��Ã���퐐���8���S�i��!�~�Z^Q3�B�ONt�,�a������JT���.�r�K>㛵~��>iˤ���!�_U.�     