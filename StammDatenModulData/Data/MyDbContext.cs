using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StammDatenModulData.Models;

namespace StammDatenModulData.Data;

public partial class MyDbContext : DbContext
{
    
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ABSCHREIBUNG> ABSCHREIBUNGs { get; set; }

    public virtual DbSet<ALLOCATION_GROUP> ALLOCATION_GROUPs { get; set; }

    public virtual DbSet<ARTIKEL> ARTIKELs { get; set; }

    public virtual DbSet<ARTIKEL_ANGEBOT> ARTIKEL_ANGEBOTs { get; set; }

    public virtual DbSet<ARTIKEL_EINKAUF> ARTIKEL_EINKAUFs { get; set; }

    public virtual DbSet<ARTIKEL_ETIKET> ARTIKEL_ETIKETs { get; set; }

    public virtual DbSet<ARTIKEL_LIEFERANTEN> ARTIKEL_LIEFERANTENs { get; set; }

    public virtual DbSet<ARTIKEL_MHD_DATUM> ARTIKEL_MHD_DATa { get; set; }

    public virtual DbSet<ARTIKEL_PREI> ARTIKEL_PREIs { get; set; }

    public virtual DbSet<ARTIKEL_TMP> ARTIKEL_TMPs { get; set; }

    public virtual DbSet<BARCODE_GEN> BARCODE_GENs { get; set; }

    public virtual DbSet<BARGELD> BARGELDs { get; set; }

    public virtual DbSet<BERECHTIGUNGEN> BERECHTIGUNGENs { get; set; }

    public virtual DbSet<BON_REFERENCE> BON_REFERENCEs { get; set; }

    public virtual DbSet<BUSINESSCASE> BUSINESSCASEs { get; set; }

    public virtual DbSet<CASHPOINTCLOSING> CASHPOINTCLOSINGs { get; set; }

    public virtual DbSet<CASHREGISTER> CASHREGISTERs { get; set; }

    public virtual DbSet<CASH_PER_CURRENCY> CASH_PER_CURRENCies { get; set; }

    public virtual DbSet<DATAPAYMENT> DATAPAYMENTs { get; set; }

    public virtual DbSet<DATENSCHUTZ> DATENSCHUTZs { get; set; }

    public virtual DbSet<DATEV_BUCHUNGSART> DATEV_BUCHUNGSARTs { get; set; }

    public virtual DbSet<DIGI_BON> DIGI_BONs { get; set; }

    public virtual DbSet<DIGI_BON_ARTIKEL> DIGI_BON_ARTIKELs { get; set; }

    public virtual DbSet<DSFINVK_TSE> DSFINVK_TSEs { get; set; }

    public virtual DbSet<FIRMEN_DATEN> FIRMEN_DATENs { get; set; }

    public virtual DbSet<GESTRO_DATUM> GESTRO_DATa { get; set; }

    public virtual DbSet<GESTRO_LOG> GESTRO_LOGs { get; set; }

    public virtual DbSet<GUTSCHEIN> GUTSCHEINs { get; set; }

    public virtual DbSet<INVENTUR> INVENTURs { get; set; }

    public virtual DbSet<ITEMAMOUNT> ITEMAMOUNTs { get; set; }

    public virtual DbSet<KASSEN> KASSENs { get; set; }

    public virtual DbSet<KASSENBUCH_DETAIL> KASSENBUCH_DETAILs { get; set; }

    public virtual DbSet<KASSENBUCH_MASTER> KASSENBUCH_MASTERs { get; set; }

    public virtual DbSet<KASSIERER_SITZUNG> KASSIERER_SITZUNGs { get; set; }

    public virtual DbSet<KUNDEN> KUNDENs { get; set; }

    public virtual DbSet<LAYOUT> LAYOUTs { get; set; }

    public virtual DbSet<LIEFERANTEN> LIEFERANTENs { get; set; }

    public virtual DbSet<LIEFERANT_ARTIKEL> LIEFERANT_ARTIKELs { get; set; }

    public virtual DbSet<LINE> LINEs { get; set; }

    public virtual DbSet<LINES_VAT> LINES_VATs { get; set; }

    public virtual DbSet<LOCATION> LOCATIONs { get; set; }

    public virtual DbSet<MITARBEITER> MITARBEITERs { get; set; }

    public virtual DbSet<MT_WAAGE_ABTEILUNG> MT_WAAGE_ABTEILUNGs { get; set; }

    public virtual DbSet<MT_WAAGE_ARTIKEL> MT_WAAGE_ARTIKELs { get; set; }

    public virtual DbSet<MT_WAAGE_MITARBEITER> MT_WAAGE_MITARBEITERs { get; set; }

    public virtual DbSet<MT_WAAGE_WARENGRUPPE> MT_WAAGE_WARENGRUPPEs { get; set; }

    public virtual DbSet<MWST_SATZ> MWST_SATZs { get; set; }

    public virtual DbSet<PA> PAs { get; set; }

    public virtual DbSet<PAYMENT> PAYMENTs { get; set; }

    public virtual DbSet<PROTOKOLL> PROTOKOLLs { get; set; }

    public virtual DbSet<QUITTUNGSNUMMER> QUITTUNGSNUMMERs { get; set; }

    public virtual DbSet<SCHUBLADE_INFO> SCHUBLADE_INFOs { get; set; }

    public virtual DbSet<SLAfe> SLAVEs { get; set; }

    public virtual DbSet<SONDER_BARCODE> SONDER_BARCODEs { get; set; }

    public virtual DbSet<STAMM_KASSEN> STAMM_KASSENs { get; set; }

    public virtual DbSet<STAMM_TERMINAL> STAMM_TERMINALs { get; set; }

    public virtual DbSet<STAMM_TSE> STAMM_TSEs { get; set; }

    public virtual DbSet<SUBITEM> SUBITEMs { get; set; }

    public virtual DbSet<TRANSACTION> TRANSACTIONs { get; set; }

    public virtual DbSet<TRANSACTIONS_TSE> TRANSACTIONS_TSEs { get; set; }

    public virtual DbSet<TRANSACTIONS_VAT> TRANSACTIONS_VATs { get; set; }

    public virtual DbSet<TSE> TSEs { get; set; }

    public virtual DbSet<VAT> VATs { get; set; }

    public virtual DbSet<VERKAUF_DETAIL> VERKAUF_DETAILs { get; set; }

    public virtual DbSet<VERKAUF_MASTER> VERKAUF_MASTERs { get; set; }

    public virtual DbSet<VERKAUF_MWST> VERKAUF_MWSTs { get; set; }

    public virtual DbSet<VERKAUF_ZVT> VERKAUF_ZVTs { get; set; }

    public virtual DbSet<VIEW_ARTIKEL_GEWINN> VIEW_ARTIKEL_GEWINNs { get; set; }

    public virtual DbSet<VIEW_ARTIKEL_VERKAUF_HISTORY> VIEW_ARTIKEL_VERKAUF_HISTORies { get; set; }

    public virtual DbSet<VIEW_VERKAUFTE_ARTIKEL> VIEW_VERKAUFTE_ARTIKELs { get; set; }

    public virtual DbSet<WAAGE_ABTEILUNG> WAAGE_ABTEILUNGs { get; set; }

    public virtual DbSet<WAAGE_ABTEILUNG_TMP> WAAGE_ABTEILUNG_TMPs { get; set; }

    public virtual DbSet<WAAGE_ARTIKEL> WAAGE_ARTIKELs { get; set; }

    public virtual DbSet<WAAGE_ARTIKEL_HISTORY> WAAGE_ARTIKEL_HISTORies { get; set; }

    public virtual DbSet<WAAGE_ARTIKEL_TMP> WAAGE_ARTIKEL_TMPs { get; set; }

    public virtual DbSet<WAAGE_BILDER> WAAGE_BILDERs { get; set; }

    public virtual DbSet<WAAGE_MITARBEITER> WAAGE_MITARBEITERs { get; set; }

    public virtual DbSet<WAAGE_UMSATZ> WAAGE_UMSATZs { get; set; }

    public virtual DbSet<WAAGE_WARENGRUPPEN> WAAGE_WARENGRUPPENs { get; set; }

    public virtual DbSet<WAAGE_WARENGRUPPEN_TMP> WAAGE_WARENGRUPPEN_TMPs { get; set; }

    public virtual DbSet<WARENGRUPPEN> WARENGRUPPENs { get; set; }

    public virtual DbSet<ZAHL_PROTOKOL> ZAHL_PROTOKOLs { get; set; }

    public virtual DbSet<ZVT_KASSENSCHNITT> ZVT_KASSENSCHNITTs { get; set; }

    public virtual DbSet<Z_BERICHT> Z_BERICHTs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseFirebird("User=SYSDBA;Password=masterkey;Database=C:\\Users\\User\\source\\repos\\StammDatenModul\\StammDatenModul\\GESTRO25.FDB2.FDB;DataSource=localhost;Port=3050;Dialect=3;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ABSCHREIBUNG>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.ABSCHREIBUNG_NR, e.DATUM, e.POS });

            entity.ToTable("ABSCHREIBUNG");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.ABSCHREIBUNG_NR, e.DATUM, e.POS }, "PK_ABSCHREIBUNG").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.ABTEILUNG).HasMaxLength(30);
            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(20);
            entity.Property(e => e.BENUTZER_NR).HasMaxLength(5);
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(50);
            entity.Property(e => e.EINHEIT).HasMaxLength(10);
        });

        modelBuilder.Entity<ALLOCATION_GROUP>(entity =>
        {
            entity.HasKey(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID });

            entity.ToTable("ALLOCATION_GROUPS");

            entity.HasIndex(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID }, "PK_ALLOCATION_GROUPS").IsUnique();

            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(50);
            entity.Property(e => e.BON_ID).HasMaxLength(50);
            entity.Property(e => e.ABRECHNUNGSKREIS).HasMaxLength(50);
        });

        modelBuilder.Entity<ARTIKEL>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ARTIKEL_NR });

            entity.ToTable("ARTIKEL");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ARTIKEL_NR }, "IDX_ARTIKEL");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ARTIKEL_NR }, "PK_ARTIKEL").IsUnique();

            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(20);
            entity.Property(e => e.ANGEBOT).HasMaxLength(5);
            entity.Property(e => e.ANGEBOT_DATUM_BIS)
                .HasDefaultValueSql("null")
                .HasColumnType("DATE");
            entity.Property(e => e.ANGEBOT_DATUM_VON)
                .HasDefaultValueSql("null")
                .HasColumnType("DATE");
            entity.Property(e => e.ANGEBOT_PREIS).HasDefaultValueSql("null");
            entity.Property(e => e.ARTIKEL_GEWICHT_EINHEIT).HasMaxLength(5);
            entity.Property(e => e.ARTIKEL_NR_FUER_GUTSCHEIN).HasMaxLength(20);
            entity.Property(e => e.AUSLAUF).HasMaxLength(5);
            entity.Property(e => e.BARCODE_ART).HasMaxLength(30);
            entity.Property(e => e.BESTAND_REDUZIEREN).HasMaxLength(5);
            entity.Property(e => e.BESTELL_NUMMER).HasMaxLength(20);
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(2000);
            entity.Property(e => e.BILD).HasDefaultValueSql("null");
            entity.Property(e => e.EINHEIT).HasMaxLength(10);
            entity.Property(e => e.E_LABEL_NR).HasMaxLength(20);
            entity.Property(e => e.GEWICHTSARTIKEL).HasMaxLength(5);
            entity.Property(e => e.GRUND_GEWICHT_EINHEIT).HasMaxLength(5);
            entity.Property(e => e.HERSTELLER)
                .HasMaxLength(50)
                .HasDefaultValueSql("null");
            entity.Property(e => e.JUGEND_SCHUTZ)
                .HasMaxLength(5)
                .HasDefaultValueSql("null");
            entity.Property(e => e.LIEFERANTEN)
                .HasMaxLength(50)
                .HasDefaultValueSql("null");
            entity.Property(e => e.LIEFERANTEN_ARTIKEL_NR).HasMaxLength(20);
            entity.Property(e => e.MANUELLE_TARAWERT)
                .HasMaxLength(5)
                .HasDefaultValueSql("NULL");
            entity.Property(e => e.MHD_DATUM).HasColumnType("DATE");
            entity.Property(e => e.NAME).HasMaxLength(100);
            entity.Property(e => e.PACKUNG_EAN).HasMaxLength(50);
            entity.Property(e => e.PFAND).HasDefaultValueSql("null");
            entity.Property(e => e.PRODUKT_ART).HasMaxLength(15);
            entity.Property(e => e.RABATT_FAHIG)
                .HasMaxLength(5)
                .HasDefaultValueSql("null");
            entity.Property(e => e.SENDEN).HasMaxLength(100);
            entity.Property(e => e.UPDATED)
                .HasDefaultValueSql("null")
                .HasColumnType("DATE");
            entity.Property(e => e.WARENGRUPPE).HasMaxLength(30);
            entity.Property(e => e.WG_ID).HasMaxLength(5);
        });

        modelBuilder.Entity<ARTIKEL_ANGEBOT>(entity =>
        {
            entity.HasKey(e => new { e.DATUM, e.ZEIT, e.FILIALLE_NR });

            entity.ToTable("ARTIKEL_ANGEBOT");

            entity.HasIndex(e => new { e.DATUM, e.ZEIT, e.FILIALLE_NR }, "PK_ARTIKEL_ANGEBOT").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.FILIALLE_NR).HasMaxLength(5);
            entity.Property(e => e.ANGEBOT_DATUM_BIS).HasColumnType("DATE");
            entity.Property(e => e.ANGEBOT_DATUM_VON).HasColumnType("DATE");
            entity.Property(e => e.ARTIKEL_NAME).HasMaxLength(100);
            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(100);
            entity.Property(e => e.EK_PREIS).HasDefaultValueSql("null");
            entity.Property(e => e.HERSTELLER)
                .HasMaxLength(50)
                .HasDefaultValueSql("null");
            entity.Property(e => e.MWST).HasMaxLength(10);
        });

        modelBuilder.Entity<ARTIKEL_EINKAUF>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.LIEFERANTEN_NAME, e.DATUM, e.ZEIT, e.ARTIKEL_NR });

            entity.ToTable("ARTIKEL_EINKAUF");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.LIEFERANTEN_NAME, e.DATUM, e.ZEIT, e.ARTIKEL_NR }, "PK_ARTIKEL_EINKAUF").IsUnique();

            entity.Property(e => e.FILIALLE_NR).HasMaxLength(5);
            entity.Property(e => e.LIEFERANTEN_NAME).HasMaxLength(100);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(50);
            entity.Property(e => e.ARTIKEL_LIEF_NR).HasMaxLength(50);
            entity.Property(e => e.ARTIKEL_NAME).HasMaxLength(50);
            entity.Property(e => e.ARTIKEL_SN_NUMMER).HasMaxLength(100);
            entity.Property(e => e.BELEG_NR).HasMaxLength(50);
            entity.Property(e => e.BENUTZER_NR).HasMaxLength(5);
            entity.Property(e => e.EINHEIT).HasMaxLength(30);
            entity.Property(e => e.WARENGRUPPE).HasMaxLength(50);
            entity.Property(e => e.WE_DATUM).HasMaxLength(30);
        });

        modelBuilder.Entity<ARTIKEL_ETIKET>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ARTIKEL_NR });

            entity.ToTable("ARTIKEL_ETIKET");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ARTIKEL_NR }, "PK_ARTIKEL_ETIKET").IsUnique();

            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(20);
            entity.Property(e => e.ANGEBOT).HasMaxLength(5);
            entity.Property(e => e.ARTIKEL_NAME).HasMaxLength(50);
            entity.Property(e => e.AUSLAUF).HasMaxLength(5);
            entity.Property(e => e.BENUTZER_NR)
                .HasMaxLength(10)
                .HasDefaultValueSql("null");
            entity.Property(e => e.DATUM)
                .HasDefaultValueSql("null")
                .HasColumnType("DATE");
            entity.Property(e => e.GEWICHT).HasMaxLength(50);
            entity.Property(e => e.GRUND_PREIS).HasMaxLength(20);
            entity.Property(e => e.HERSTELLER).HasMaxLength(50);
            entity.Property(e => e.LIEFERANTEN).HasMaxLength(50);
            entity.Property(e => e.PFAND).HasMaxLength(50);
            entity.Property(e => e.VK_PREIS).HasMaxLength(10);
            entity.Property(e => e.WARENGRUPPE).HasMaxLength(30);
            entity.Property(e => e.ZEIT).HasDefaultValueSql("null");
            entity.Property(e => e.ZWEITE_BEZEICHNUNG).HasMaxLength(100);
        });

        modelBuilder.Entity<ARTIKEL_LIEFERANTEN>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ARTIKEL_EAN_NR, e.ARTIKEL_NR, e.LIEFERANTEN_NAME });

            entity.ToTable("ARTIKEL_LIEFERANTEN");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ARTIKEL_EAN_NR, e.ARTIKEL_NR, e.LIEFERANTEN_NAME }, "PK_ARTIKEL_LIEFERANTEN").IsUnique();

            entity.Property(e => e.FILIALLE_NR).HasMaxLength(5);
            entity.Property(e => e.ARTIKEL_EAN_NR).HasMaxLength(30);
            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(50);
            entity.Property(e => e.LIEFERANTEN_NAME).HasMaxLength(60);
            entity.Property(e => e.ARTIKEL_NAME).HasMaxLength(60);
            entity.Property(e => e.EK_PREIS).HasDefaultValueSql("null");
        });

        modelBuilder.Entity<ARTIKEL_MHD_DATUM>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ARTIKEL_NR, e.DATUM, e.ZEIT });

            entity.ToTable("ARTIKEL_MHD_DATUM");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ARTIKEL_NR, e.DATUM, e.ZEIT }, "PK_ARTIKEL_MHD_DATUM").IsUnique();

            entity.Property(e => e.FILIALLE_NR).HasMaxLength(5);
            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(50);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.ARTIKEL_LIEF_NR).HasMaxLength(50);
            entity.Property(e => e.LIEFERANTEN_NAME).HasMaxLength(100);
            entity.Property(e => e.MHD_DATUM).HasColumnType("DATE");
        });

        modelBuilder.Entity<ARTIKEL_PREI>(entity =>
        {
            entity.HasKey(e => new { e.DATUM, e.ZEIT, e.FILIALLE_NR });

            entity.ToTable("ARTIKEL_PREIS");

            entity.HasIndex(e => new { e.DATUM, e.ZEIT, e.FILIALLE_NR }, "PK_ARTIKEL_PREIS").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.FILIALLE_NR).HasMaxLength(5);
            entity.Property(e => e.ARTIKEL_NAME).HasMaxLength(100);
            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(100);
            entity.Property(e => e.BENUTZER_NR)
                .HasMaxLength(10)
                .HasDefaultValueSql("null");
            entity.Property(e => e.EK_PREIS).HasDefaultValueSql("null");
            entity.Property(e => e.HERSTELLER)
                .HasMaxLength(50)
                .HasDefaultValueSql("null");
            entity.Property(e => e.LIEFERANTEN)
                .HasMaxLength(30)
                .HasDefaultValueSql("null");
            entity.Property(e => e.MWST).HasMaxLength(10);
            entity.Property(e => e.PACKUNGSINHALT).HasMaxLength(10);
            entity.Property(e => e.WARENGRUPPE)
                .HasMaxLength(30)
                .HasDefaultValueSql("null");
        });

        modelBuilder.Entity<ARTIKEL_TMP>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ARTIKEL_NR });

            entity.ToTable("ARTIKEL_TMP");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ARTIKEL_NR }, "PK_ARTIKEL_TMP").IsUnique();

            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(20);
            entity.Property(e => e.ANGEBOT).HasMaxLength(5);
            entity.Property(e => e.ANGEBOT_DATUM_BIS)
                .HasDefaultValueSql("null")
                .HasColumnType("DATE");
            entity.Property(e => e.ANGEBOT_DATUM_VON)
                .HasDefaultValueSql("null")
                .HasColumnType("DATE");
            entity.Property(e => e.ANGEBOT_PREIS).HasDefaultValueSql("null");
            entity.Property(e => e.ARTIKEL_GEWICHT_EINHEIT).HasMaxLength(5);
            entity.Property(e => e.ARTIKEL_NR_FUER_GUTSCHEIN).HasMaxLength(20);
            entity.Property(e => e.AUSLAUF).HasMaxLength(5);
            entity.Property(e => e.BARCODE_ART).HasMaxLength(30);
            entity.Property(e => e.BESTAND_REDUZIEREN).HasMaxLength(5);
            entity.Property(e => e.BESTELL_NUMMER).HasMaxLength(20);
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(255);
            entity.Property(e => e.BILD).HasDefaultValueSql("null");
            entity.Property(e => e.EINHEIT).HasMaxLength(10);
            entity.Property(e => e.E_LABEL_NR).HasMaxLength(20);
            entity.Property(e => e.GEWICHTSARTIKEL).HasMaxLength(5);
            entity.Property(e => e.GRUND_GEWICHT_EINHEIT).HasMaxLength(5);
            entity.Property(e => e.HERSTELLER)
                .HasMaxLength(50)
                .HasDefaultValueSql("null");
            entity.Property(e => e.JUGEND_SCHUTZ)
                .HasMaxLength(5)
                .HasDefaultValueSql("null");
            entity.Property(e => e.LIEFERANTEN)
                .HasMaxLength(50)
                .HasDefaultValueSql("null");
            entity.Property(e => e.LIEFERANTEN_ARTIKEL_NR).HasMaxLength(20);
            entity.Property(e => e.MANUELLE_TARAWERT)
                .HasMaxLength(5)
                .HasDefaultValueSql("NULL");
            entity.Property(e => e.MHD_DATUM).HasColumnType("DATE");
            entity.Property(e => e.NAME).HasMaxLength(100);
            entity.Property(e => e.PACKUNG_EAN).HasMaxLength(50);
            entity.Property(e => e.PFAND).HasDefaultValueSql("null");
            entity.Property(e => e.PRODUKT_ART).HasMaxLength(15);
            entity.Property(e => e.RABATT_FAHIG)
                .HasMaxLength(5)
                .HasDefaultValueSql("null");
            entity.Property(e => e.SENDEN).HasMaxLength(100);
            entity.Property(e => e.UPDATED)
                .HasDefaultValueSql("null")
                .HasColumnType("DATE");
            entity.Property(e => e.WARENGRUPPE).HasMaxLength(30);
            entity.Property(e => e.WG_ID).HasMaxLength(5);
        });

        modelBuilder.Entity<BARCODE_GEN>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ARTIKEL_NR, e.BARCODE_NR }).HasName("PK_BBARCODE_GEN");

            entity.ToTable("BARCODE_GEN");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ARTIKEL_NR, e.BARCODE_NR }, "PK_BBARCODE_GEN").IsUnique();

            entity.Property(e => e.BARCODE_NR).HasMaxLength(50);
            entity.Property(e => e.ARTIKEL_BEZEICHNUNG).HasMaxLength(250);
        });

        modelBuilder.Entity<BARGELD>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.KASSE_ID, e.DATUM, e.POS });

            entity.ToTable("BARGELD");

            entity.HasIndex(e => e.DATUM, "IDX_BARGELD_DATUM");

            entity.HasIndex(e => e.FILIALLE_NR, "IDX_BARGELD_FN");

            entity.HasIndex(e => e.Z_BERICHT_NR, "IDX_BARGELD_ZBNR");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.KASSE_ID, e.DATUM, e.POS }, "PK_BARGELD").IsUnique();

            entity.Property(e => e.KASSE_ID).HasMaxLength(50);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(50);
            entity.Property(e => e.GESCHAFTSVORFALL).HasMaxLength(50);
        });

        modelBuilder.Entity<BERECHTIGUNGEN>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.MITARBEITER_NR, e.BEZEICHNUNG });

            entity.ToTable("BERECHTIGUNGEN");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.MITARBEITER_NR, e.BEZEICHNUNG }, "PK_BERECHTIGUNGEN").IsUnique();

            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(50);
            entity.Property(e => e.STATUS)
                .HasMaxLength(1)
                .HasDefaultValueSql("null");
        });

        modelBuilder.Entity<BON_REFERENCE>(entity =>
        {
            entity.HasKey(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.BON_ID, e.POS_ZEILE, e.REF_TYP });

            entity.ToTable("BON_REFERENCES");

            entity.HasIndex(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.BON_ID, e.POS_ZEILE, e.REF_TYP }, "PK_BON_REFERENCES").IsUnique();

            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.BON_ID).HasMaxLength(40);
            entity.Property(e => e.POS_ZEILE).HasMaxLength(50);
            entity.Property(e => e.REF_TYP).HasMaxLength(20);
            entity.Property(e => e.REF_BON_ID).HasMaxLength(40);
            entity.Property(e => e.REF_DATUM).HasMaxLength(30);
            entity.Property(e => e.REF_NAME).HasMaxLength(40);
            entity.Property(e => e.REF_Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.REF_Z_NR).HasMaxLength(10);
            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
            entity.Property(e => e.Z_NR).HasMaxLength(20);
        });

        modelBuilder.Entity<BUSINESSCASE>(entity =>
        {
            entity.HasKey(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.GV_NAME, e.UST_SCHLUESSEL });

            entity.ToTable("BUSINESSCASES");

            entity.HasIndex(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.GV_NAME, e.UST_SCHLUESSEL }, "PK_BUSINESSCASES").IsUnique();

            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.GV_NAME).HasMaxLength(35);
            entity.Property(e => e.UST_SCHLUESSEL).HasMaxLength(5);
            entity.Property(e => e.AGENTUR_ID).HasMaxLength(5);
            entity.Property(e => e.GV_TYP).HasMaxLength(30);
            entity.Property(e => e.Z_UMS_BRUTTO).HasMaxLength(20);
            entity.Property(e => e.Z_UMS_NETTO).HasMaxLength(20);
            entity.Property(e => e.Z_UST).HasMaxLength(20);
        });

        modelBuilder.Entity<CASHPOINTCLOSING>(entity =>
        {
            entity.HasKey(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR });

            entity.ToTable("CASHPOINTCLOSING");

            entity.HasIndex(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR }, "PK_CASHPOINTCLOSING").IsUnique();

            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.LAND).HasMaxLength(3);
            entity.Property(e => e.NAME).HasMaxLength(60);
            entity.Property(e => e.ORT).HasMaxLength(62);
            entity.Property(e => e.PLZ).HasMaxLength(10);
            entity.Property(e => e.STNR).HasMaxLength(20);
            entity.Property(e => e.STRASSE).HasMaxLength(60);
            entity.Property(e => e.TAXONOMIE_VERSION).HasMaxLength(10);
            entity.Property(e => e.USTID).HasMaxLength(15);
            entity.Property(e => e.Z_BUCHUNGSTAG).HasMaxLength(50);
            entity.Property(e => e.Z_ENDE_ID).HasMaxLength(20);
            entity.Property(e => e.Z_SE_BARZAHLUNGEN).HasMaxLength(30);
            entity.Property(e => e.Z_SE_ZAHLUNGEN).HasMaxLength(30);
            entity.Property(e => e.Z_START_ID).HasMaxLength(20);
        });

        modelBuilder.Entity<CASHREGISTER>(entity =>
        {
            entity.HasKey(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.KASSE_MODELL });

            entity.ToTable("CASHREGISTER");

            entity.HasIndex(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.KASSE_MODELL }, "PK_CASHREGISTER").IsUnique();

            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.KASSE_MODELL).HasMaxLength(50);
            entity.Property(e => e.KASSE_BASISWAEH_CODE).HasMaxLength(3);
            entity.Property(e => e.KASSE_BRAND).HasMaxLength(50);
            entity.Property(e => e.KASSE_SERIENNR).HasMaxLength(70);
            entity.Property(e => e.KASSE_SW_BRAND).HasMaxLength(50);
            entity.Property(e => e.KASSE_SW_VERSION).HasMaxLength(50);
            entity.Property(e => e.KEINE_UST_ZUORDNUNG).HasMaxLength(1);
        });

        modelBuilder.Entity<CASH_PER_CURRENCY>(entity =>
        {
            entity.HasKey(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.ZAHLART_WAEH });

            entity.ToTable("CASH_PER_CURRENCY");

            entity.HasIndex(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.ZAHLART_WAEH }, "PK_CASH_PER_CURRENCY").IsUnique();

            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.ZAHLART_WAEH).HasMaxLength(3);
            entity.Property(e => e.ZAHLART_BETRAG_WAEH).HasMaxLength(20);
            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
        });

        modelBuilder.Entity<DATAPAYMENT>(entity =>
        {
            entity.HasKey(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.ZAHLART_NAME });

            entity.ToTable("DATAPAYMENT");

            entity.HasIndex(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.ZAHLART_NAME }, "PK_DATAPAYMENT").IsUnique();

            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.BON_ID).HasMaxLength(30);
            entity.Property(e => e.ZAHLART_NAME).HasMaxLength(40);
            entity.Property(e => e.BASISWAEH_BETRAG).HasMaxLength(10);
            entity.Property(e => e.ZAHLART_TYP).HasMaxLength(25);
            entity.Property(e => e.ZAHLWAEH_BETRAG).HasMaxLength(10);
            entity.Property(e => e.ZAHLWAEH_CODE).HasMaxLength(3);
            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
        });

        modelBuilder.Entity<DATENSCHUTZ>(entity =>
        {
            entity.HasKey(e => new { e.KASSE_NR, e.FILIALLE_NR });

            entity.ToTable("DATENSCHUTZ");

            entity.HasIndex(e => new { e.KASSE_NR, e.FILIALLE_NR }, "PK_DATENSCHUTZ").IsUnique();

            entity.Property(e => e.DATENSCHUTZ_AKZEPTIEREN).HasMaxLength(5);
            entity.Property(e => e.DATENSCHUTZ_TEXT).HasMaxLength(5000);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.FIRMEN_EMAIL).HasMaxLength(50);
            entity.Property(e => e.FIRMEN_NAME).HasMaxLength(50);
            entity.Property(e => e.FIRMEN_ORT).HasMaxLength(50);
            entity.Property(e => e.FIRMEN_PLZ).HasMaxLength(50);
            entity.Property(e => e.FIRMEN_STRASSE).HasMaxLength(50);
            entity.Property(e => e.FIRMEN_TEL).HasMaxLength(50);
            entity.Property(e => e.GESTRO_ID).HasMaxLength(250);
            entity.Property(e => e.GESTRO_LIZENZ).HasMaxLength(500);
        });

        modelBuilder.Entity<DATEV_BUCHUNGSART>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KONTO, e.GEGEN_KONTO, e.BERATERNUMMER, e.MANDANTENNUMMER });

            entity.ToTable("DATEV_BUCHUNGSART");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KONTO, e.GEGEN_KONTO, e.BERATERNUMMER, e.MANDANTENNUMMER }, "PK_DATEV_BUCHUNGSART").IsUnique();

            entity.Property(e => e.KONTO).HasMaxLength(30);
            entity.Property(e => e.GEGEN_KONTO).HasMaxLength(30);
            entity.Property(e => e.BERATERNUMMER).HasMaxLength(30);
            entity.Property(e => e.MANDANTENNUMMER).HasMaxLength(30);
            entity.Property(e => e.BEARBEITE_KURZEL).HasMaxLength(10);
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(100);
            entity.Property(e => e.SACHKONTENRAHMEN).HasMaxLength(10);
            entity.Property(e => e.WJ_BEGINN).HasMaxLength(10);
        });

        modelBuilder.Entity<DIGI_BON>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.WAAGE_NR, e.TRANSACTION_NR, e.DATUM, e.ZEIT });

            entity.ToTable("DIGI_BON");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.WAAGE_NR, e.TRANSACTION_NR, e.DATUM, e.ZEIT }, "PK_DIGI_BON").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.BEDIENER).HasMaxLength(30);
            entity.Property(e => e.BONTYPE).HasMaxLength(10);
            entity.Property(e => e.SENDEN).HasMaxLength(100);
        });

        modelBuilder.Entity<DIGI_BON_ARTIKEL>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.WAAGE_NR, e.TRANSACTION_NR, e.DATUM, e.ZEIT, e.BARCODE, e.POS });

            entity.ToTable("DIGI_BON_ARTIKEL");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.WAAGE_NR, e.TRANSACTION_NR, e.DATUM, e.ZEIT, e.BARCODE, e.POS }, "IDX_DIGI_BON_ARTIKEL");

            entity.HasIndex(e => e.POS, "IDX_DIGI_BON_ARTIKEL_BARCODE");

            entity.HasIndex(e => e.DATUM, "IDX_DIGI_BON_ARTIKEL_DATUM");

            entity.HasIndex(e => e.FILIALLE_NR, "IDX_DIGI_BON_ARTIKEL_FN");

            entity.HasIndex(e => e.KASSE_NR, "IDX_DIGI_BON_ARTIKEL_KASSE_NR");

            entity.HasIndex(e => e.WAAGE_NR, "IDX_DIGI_BON_ARTIKEL_WAAGE_NR");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.WAAGE_NR, e.TRANSACTION_NR, e.DATUM, e.ZEIT, e.BARCODE, e.POS }, "PK_DIGI_BON_ARTIKEL").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.BARCODE).HasMaxLength(30);
            entity.Property(e => e.BEDIENER).HasMaxLength(30);
            entity.Property(e => e.BONTYPE).HasMaxLength(10);
            entity.Property(e => e.EINHEIT).HasMaxLength(5);
            entity.Property(e => e.PLU_NAME).HasMaxLength(50);
            entity.Property(e => e.PLU_NR).HasMaxLength(50);
            entity.Property(e => e.PLU_WG).HasMaxLength(50);
            entity.Property(e => e.SENDEN).HasMaxLength(100);
            entity.Property(e => e.STORNIERT).HasMaxLength(5);
        });

        modelBuilder.Entity<DSFINVK_TSE>(entity =>
        {
            entity.HasKey(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.TSE_ID });

            entity.ToTable("DSFINVK_TSE");

            entity.HasIndex(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.TSE_ID }, "PK_DSFINVK_TSE").IsUnique();

            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.TSE_ID).HasMaxLength(4);
            entity.Property(e => e.TSE_PD_ENCODING).HasMaxLength(5);
            entity.Property(e => e.TSE_PUBLIC_KEY).HasMaxLength(512);
            entity.Property(e => e.TSE_SERIAL).HasMaxLength(68);
            entity.Property(e => e.TSE_SIG_ALGO).HasMaxLength(21);
            entity.Property(e => e.TSE_ZEITFORMAT).HasMaxLength(31);
            entity.Property(e => e.TSE_ZERTIFIKAT_I).HasMaxLength(1000);
            entity.Property(e => e.TSE_ZERTIFIKAT_II).HasMaxLength(1000);
            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
        });

        modelBuilder.Entity<FIRMEN_DATEN>(entity =>
        {
            entity.HasKey(e => e.FILIALLE_NR);

            entity.ToTable("FIRMEN_DATEN");

            entity.HasIndex(e => e.FILIALLE_NR, "PK_FIRMEN_DATEN").IsUnique();

            entity.Property(e => e.BANK).HasMaxLength(100);
            entity.Property(e => e.BIC).HasMaxLength(50);
            entity.Property(e => e.EMAIL).HasMaxLength(50);
            entity.Property(e => e.E_LABEL_STOREID)
                .HasMaxLength(20)
                .HasDefaultValueSql("null");
            entity.Property(e => e.FAX).HasMaxLength(20);
            entity.Property(e => e.FIRMA_NAME).HasMaxLength(50);
            entity.Property(e => e.GLAUBIGER_ID).HasMaxLength(100);
            entity.Property(e => e.HRB).HasMaxLength(50);
            entity.Property(e => e.IBAN).HasMaxLength(50);
            entity.Property(e => e.INHABER).HasMaxLength(30);
            entity.Property(e => e.LAND).HasMaxLength(3);
            entity.Property(e => e.ORT).HasMaxLength(50);
            entity.Property(e => e.PLZ).HasMaxLength(5);
            entity.Property(e => e.STEUER_NR).HasMaxLength(30);
            entity.Property(e => e.STRASSE).HasMaxLength(30);
            entity.Property(e => e.TEL).HasMaxLength(20);
            entity.Property(e => e.URL).HasMaxLength(50);
            entity.Property(e => e.USTID).HasMaxLength(30);
        });

        modelBuilder.Entity<GESTRO_DATUM>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR }).HasName("PK_DATUM");

            entity.ToTable("GESTRO_DATUM");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR }, "PK_DATUM").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
        });

        modelBuilder.Entity<GESTRO_LOG>(entity =>
        {
            entity.HasKey(e => new { e.LOG_NR, e.TERMINAL_ID });

            entity.ToTable("GESTRO_LOG");

            entity.HasIndex(e => new { e.LOG_NR, e.TERMINAL_ID }, "PK_GESTRO_LOG").IsUnique();

            entity.Property(e => e.TERMINAL_ID).HasMaxLength(30);
            entity.Property(e => e.BEDIENER).HasMaxLength(30);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.FIRMEN_NAME).HasMaxLength(100);
            entity.Property(e => e.LOG_BEZEICHNUNG).HasMaxLength(1000);
            entity.Property(e => e.ORT).HasMaxLength(50);
            entity.Property(e => e.STRASSE).HasMaxLength(50);
        });

        modelBuilder.Entity<GUTSCHEIN>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.ARTIKEL_NR, e.GUTSCHEIN_NR });

            entity.ToTable("GUTSCHEIN");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.ARTIKEL_NR, e.GUTSCHEIN_NR }, "PK_GUTSCHEIN").IsUnique();

            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(30);
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(50);
            entity.Property(e => e.DATUM_BIS).HasColumnType("DATE");
            entity.Property(e => e.DATUM_VON).HasColumnType("DATE");
            entity.Property(e => e.GUTSCHEIN_ART).HasMaxLength(10);
            entity.Property(e => e.GUTSCHEIN_BARCODE).HasMaxLength(20);
            entity.Property(e => e.SENDEN).HasMaxLength(50);
            entity.Property(e => e.TEIL_LOSUNG).HasMaxLength(5);
            entity.Property(e => e.ZWECK).HasMaxLength(30);
            entity.Property(e => e.ZWECK_ARTIKEL_NAME).HasMaxLength(50);
            entity.Property(e => e.ZWECK_ARTIKEL_NR).HasMaxLength(20);
        });

        modelBuilder.Entity<INVENTUR>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.INVENTUR_NR, e.DATUM, e.ARTIKEL_NR });

            entity.ToTable("INVENTUR");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.INVENTUR_NR, e.DATUM, e.ARTIKEL_NR }, "PK_INVENTUR").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(20);
            entity.Property(e => e.ARTIKEL_NAME).HasMaxLength(100);
            entity.Property(e => e.EINHEIT).HasMaxLength(10);
            entity.Property(e => e.LIEFERANTEN).HasMaxLength(50);
            entity.Property(e => e.WARENGRUPPE).HasMaxLength(50);
        });

        modelBuilder.Entity<ITEMAMOUNT>(entity =>
        {
            entity.HasKey(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.POS_ZEILE, e.TYP });

            entity.ToTable("ITEMAMOUNTS");

            entity.HasIndex(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.POS_ZEILE, e.TYP }, "PK_ITEMAMOUNTS").IsUnique();

            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.BON_ID).HasMaxLength(40);
            entity.Property(e => e.POS_ZEILE).HasMaxLength(50);
            entity.Property(e => e.TYP).HasMaxLength(15);
            entity.Property(e => e.PF_BRUTTO).HasMaxLength(10);
            entity.Property(e => e.PF_NETTO).HasMaxLength(10);
            entity.Property(e => e.PF_UST).HasMaxLength(10);
            entity.Property(e => e.UST_SCHLUESSEL).HasMaxLength(5);
            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
        });

        modelBuilder.Entity<KASSEN>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR });

            entity.ToTable("KASSEN");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR }, "PK_KASSEN").IsUnique();

            entity.Property(e => e.KASSE_DATENBANK).HasMaxLength(100);
            entity.Property(e => e.KASSE_IP).HasMaxLength(50);
            entity.Property(e => e.KASSE_NAME).HasMaxLength(30);
            entity.Property(e => e.PORT_NUMMER).HasMaxLength(10);
        });

        modelBuilder.Entity<KASSENBUCH_DETAIL>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.DATUM, e.BUCHUNG_ART, e.POS });

            entity.ToTable("KASSENBUCH_DETAIL");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.DATUM, e.BUCHUNG_ART, e.POS }, "PK_KASSENBUCH_DETAIL").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.BUCHUNG_ART).HasMaxLength(10);
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(100);
            entity.Property(e => e.GEGEN_KONTO).HasMaxLength(30);
            entity.Property(e => e.KONTO).HasMaxLength(30);
            entity.Property(e => e.SOLL_HABEN)
                .HasMaxLength(1)
                .HasDefaultValueSql("null");
        });

        modelBuilder.Entity<KASSENBUCH_MASTER>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.DATUM, e.BUCHUNG_ART });

            entity.ToTable("KASSENBUCH_MASTER");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.DATUM, e.BUCHUNG_ART }, "PK_KASSENBUCH_MASTER").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.BUCHUNG_ART).HasMaxLength(10);
            entity.Property(e => e.FIRMA_NAME).HasMaxLength(200);
        });

        modelBuilder.Entity<KASSIERER_SITZUNG>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.KASSIERER_NR, e.SITZSUNG_NR });

            entity.ToTable("KASSIERER_SITZUNG");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.KASSIERER_NR, e.SITZSUNG_NR }, "PK_KASSIERER_SITZUNG").IsUnique();

            entity.Property(e => e.BENUTZER_NAME)
                .HasMaxLength(20)
                .HasDefaultValueSql("null");
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.SENDEN).HasDefaultValueSql("null");
        });

        modelBuilder.Entity<KUNDEN>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KUNDEN_NR });

            entity.ToTable("KUNDEN");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KUNDEN_NR }, "PK_KUNDEN").IsUnique();

            entity.Property(e => e.BANK_NAME).HasMaxLength(50);
            entity.Property(e => e.BIC).HasMaxLength(15);
            entity.Property(e => e.EMAIL).HasMaxLength(50);
            entity.Property(e => e.FAX).HasMaxLength(20);
            entity.Property(e => e.IBAN).HasMaxLength(50);
            entity.Property(e => e.INHABER).HasMaxLength(50);
            entity.Property(e => e.KUNDEN_ART).HasMaxLength(10);
            entity.Property(e => e.KUNDEN_NAME).HasMaxLength(50);
            entity.Property(e => e.LAND).HasMaxLength(50);
            entity.Property(e => e.ORT).HasMaxLength(50);
            entity.Property(e => e.PLZ).HasMaxLength(5);
            entity.Property(e => e.STRASSE).HasMaxLength(50);
            entity.Property(e => e.TEL).HasMaxLength(20);
            entity.Property(e => e.USTID).HasMaxLength(50);
            entity.Property(e => e.WEB).HasMaxLength(100);
        });

        modelBuilder.Entity<LAYOUT>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.LAYOUT1, e.FORM, e.CONTROL_TYPE, e.CONTROL_NAME });

            entity.ToTable("LAYOUT");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.LAYOUT1, e.FORM, e.CONTROL_TYPE, e.CONTROL_NAME }, "PK_LAYOUT").IsUnique();

            entity.Property(e => e.LAYOUT1)
                .HasMaxLength(20)
                .HasColumnName("LAYOUT");
            entity.Property(e => e.FORM).HasMaxLength(30);
            entity.Property(e => e.CONTROL_TYPE).HasMaxLength(30);
            entity.Property(e => e.CONTROL_NAME).HasMaxLength(50);
            entity.Property(e => e.BACKGROUND_COLOR).HasMaxLength(20);
            entity.Property(e => e.CONTROL_TEXT).HasMaxLength(50);
            entity.Property(e => e.FLAG).HasDefaultValueSql("null");
            entity.Property(e => e.FONT_STYLE).HasMaxLength(20);
            entity.Property(e => e.FORE_COLOR).HasMaxLength(20);
            entity.Property(e => e.FUNKTION).HasMaxLength(50);
            entity.Property(e => e.IMAGE).HasMaxLength(100);
        });

        modelBuilder.Entity<LIEFERANTEN>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.LIEFERANTEN_NR });

            entity.ToTable("LIEFERANTEN");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.LIEFERANTEN_NR }, "PK_LIEFERANTEN").IsUnique();

            entity.Property(e => e.BANK_NAME).HasMaxLength(50);
            entity.Property(e => e.BIC).HasMaxLength(15);
            entity.Property(e => e.FAX).HasMaxLength(20);
            entity.Property(e => e.IBAN).HasMaxLength(50);
            entity.Property(e => e.INHABER).HasMaxLength(50);
            entity.Property(e => e.LIEFERANTEN_NAME).HasMaxLength(50);
            entity.Property(e => e.ORT).HasMaxLength(50);
            entity.Property(e => e.PLZ).HasMaxLength(50);
            entity.Property(e => e.STRASSE).HasMaxLength(50);
            entity.Property(e => e.TEL).HasMaxLength(20);
        });

        modelBuilder.Entity<LIEFERANT_ARTIKEL>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.LIEFERANTEN_NR, e.LIEFERANT_ARTIKEL_NR }).HasName("PK_LIF_ARTIKEL");

            entity.ToTable("LIEFERANT_ARTIKEL");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.LIEFERANTEN_NR, e.LIEFERANT_ARTIKEL_NR }, "PK_LIF_ARTIKEL").IsUnique();

            entity.Property(e => e.LIEFERANTEN_NR).HasMaxLength(5);
            entity.Property(e => e.LIEFERANT_ARTIKEL_NR).HasMaxLength(20);
            entity.Property(e => e.ARTIKEL_NAME).HasMaxLength(34);
            entity.Property(e => e.BARCODE_NR).HasMaxLength(20);
            entity.Property(e => e.EINHEIT).HasMaxLength(10);
            entity.Property(e => e.WARENGRUPPE).HasMaxLength(50);
        });

        modelBuilder.Entity<LINE>(entity =>
        {
            entity.HasKey(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.POS_ZEILE });

            entity.ToTable("LINES");

            entity.HasIndex(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.POS_ZEILE }, "PK_LINES").IsUnique();

            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.BON_ID).HasMaxLength(40);
            entity.Property(e => e.POS_ZEILE).HasMaxLength(50);
            entity.Property(e => e.AGENTUR_ID).HasMaxLength(30);
            entity.Property(e => e.ARTIKELTEXT).HasMaxLength(255);
            entity.Property(e => e.ART_NR).HasMaxLength(50);
            entity.Property(e => e.EINHEIT).HasMaxLength(50);
            entity.Property(e => e.FAKTOR).HasMaxLength(20);
            entity.Property(e => e.GTIN).HasMaxLength(50);
            entity.Property(e => e.GUTSCHEIN_NR).HasMaxLength(50);
            entity.Property(e => e.GV_NAME).HasMaxLength(30);
            entity.Property(e => e.GV_TYP).HasMaxLength(30);
            entity.Property(e => e.INHAUS).HasMaxLength(1);
            entity.Property(e => e.MENGE).HasMaxLength(20);
            entity.Property(e => e.POS_TERMINAL_ID).HasMaxLength(50);
            entity.Property(e => e.P_STORNO).HasMaxLength(1);
            entity.Property(e => e.STK_BR).HasMaxLength(30);
            entity.Property(e => e.WARENGR).HasMaxLength(50);
            entity.Property(e => e.WARENGR_ID).HasMaxLength(40);
            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
        });

        modelBuilder.Entity<LINES_VAT>(entity =>
        {
            entity.HasKey(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.POS_ZEILE, e.UST_SCHLUESSEL });

            entity.ToTable("LINES_VAT");

            entity.HasIndex(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.POS_ZEILE, e.UST_SCHLUESSEL }, "PK_LINES_VAT").IsUnique();

            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.BON_ID).HasMaxLength(40);
            entity.Property(e => e.POS_ZEILE).HasMaxLength(50);
            entity.Property(e => e.UST_SCHLUESSEL).HasMaxLength(5);
            entity.Property(e => e.POS_BRUTTO).HasMaxLength(10);
            entity.Property(e => e.POS_NETTO).HasMaxLength(10);
            entity.Property(e => e.POS_UST).HasMaxLength(10);
            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
        });

        modelBuilder.Entity<LOCATION>(entity =>
        {
            entity.HasKey(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.LOC_STRASSE, e.LOC_PLZ });

            entity.ToTable("LOCATION");

            entity.HasIndex(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.LOC_STRASSE, e.LOC_PLZ }, "PK_LOCATION").IsUnique();

            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.LOC_STRASSE).HasMaxLength(60);
            entity.Property(e => e.LOC_PLZ).HasMaxLength(10);
            entity.Property(e => e.LOC_LAND).HasMaxLength(3);
            entity.Property(e => e.LOC_NAME).HasMaxLength(60);
            entity.Property(e => e.LOC_ORT).HasMaxLength(62);
            entity.Property(e => e.LOC_USTID).HasMaxLength(15);
            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
        });

        modelBuilder.Entity<MITARBEITER>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.MITARBEITER_NR });

            entity.ToTable("MITARBEITER");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.MITARBEITER_NR }, "PK_MITARBEITER").IsUnique();

            entity.Property(e => e.KENNWORT).HasMaxLength(10);
            entity.Property(e => e.NAME).HasMaxLength(20);
            entity.Property(e => e.STATUS)
                .HasMaxLength(2)
                .HasDefaultValueSql("null");
            entity.Property(e => e.VORNAME).HasMaxLength(20);
        });

        modelBuilder.Entity<MT_WAAGE_ABTEILUNG>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR });

            entity.ToTable("MT_WAAGE_ABTEILUNG");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR }, "PK_MT_WAAGE_ABTEILUNG").IsUnique();

            entity.Property(e => e.ABTEILUNG_NAME).HasMaxLength(255);
            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(10);
        });

        modelBuilder.Entity<MT_WAAGE_ARTIKEL>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR, e.ARTIKEL_NR });

            entity.ToTable("MT_WAAGE_ARTIKEL");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR, e.ARTIKEL_NR }, "PK_MT_WAAGE_ARTIKEL").IsUnique();

            entity.Property(e => e.ARTIKEL_NAME).HasMaxLength(255);
            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(10);
            entity.Property(e => e.WIEGE_ARTIKEL).HasMaxLength(6);
        });

        modelBuilder.Entity<MT_WAAGE_MITARBEITER>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.MITARBEITERNUMMER });

            entity.ToTable("MT_WAAGE_MITARBEITER");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.MITARBEITERNUMMER }, "PK_MT_WAAGE_MITARBEITER").IsUnique();

            entity.Property(e => e.NAME).HasMaxLength(255);
            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(10);
        });

        modelBuilder.Entity<MT_WAAGE_WARENGRUPPE>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR });

            entity.ToTable("MT_WAAGE_WARENGRUPPE");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR }, "PK_MT_WAAGE_WARENGRUPPE").IsUnique();

            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(10);
            entity.Property(e => e.WG_NAME).HasMaxLength(255);
        });

        modelBuilder.Entity<MWST_SATZ>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.MWST_ID });

            entity.ToTable("MWST_SATZ");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.MWST_ID }, "PK_MWST_SATZ").IsUnique();

            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(2);
            entity.Property(e => e.BEZEICHNUNG2).HasMaxLength(55);
            entity.Property(e => e.GULTIG_BIS).HasColumnType("DATE");
            entity.Property(e => e.GULTIG_VON).HasColumnType("DATE");
        });

        modelBuilder.Entity<PA>(entity =>
        {
            entity.HasKey(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.AGENTUR_ID });

            entity.ToTable("PA");

            entity.HasIndex(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.AGENTUR_ID }, "PK_PA").IsUnique();

            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.AGENTUR_ID).HasMaxLength(5);
            entity.Property(e => e.AGENTUR_LAND).HasMaxLength(3);
            entity.Property(e => e.AGENTUR_NAME).HasMaxLength(60);
            entity.Property(e => e.AGENTUR_ORT).HasMaxLength(62);
            entity.Property(e => e.AGENTUR_PLZ).HasMaxLength(10);
            entity.Property(e => e.AGENTUR_STNR).HasMaxLength(20);
            entity.Property(e => e.AGENTUR_STRASSE).HasMaxLength(60);
            entity.Property(e => e.AGENTUR_USTID).HasMaxLength(15);
            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
        });

        modelBuilder.Entity<PAYMENT>(entity =>
        {
            entity.HasKey(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.ZAHLART_NAME });

            entity.ToTable("PAYMENT");

            entity.HasIndex(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.ZAHLART_NAME }, "PK_PAYMENT").IsUnique();

            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.ZAHLART_NAME).HasMaxLength(60);
            entity.Property(e => e.ZAHLART_TYP).HasMaxLength(25);
            entity.Property(e => e.Z_ZAHLART_BETRAG).HasMaxLength(20);
        });

        modelBuilder.Entity<PROTOKOLL>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.PROTOKOLL_NR });

            entity.ToTable("PROTOKOLL");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.PROTOKOLL_NR }, "PK_PROTOKOLL").IsUnique();

            entity.Property(e => e.BENUTZER).HasMaxLength(50);
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(500);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.FORM_NAME).HasMaxLength(50);
            entity.Property(e => e.PROTOKOLL_ART).HasMaxLength(20);
        });

        modelBuilder.Entity<QUITTUNGSNUMMER>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.JAHR });

            entity.ToTable("QUITTUNGSNUMMER");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.JAHR }, "PK_QUITTUNGSNUMMER").IsUnique();

            entity.Property(e => e.JAHR).HasMaxLength(5);
        });

        modelBuilder.Entity<SCHUBLADE_INFO>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.DATUM, e.ZEIT_OFFNEN });

            entity.ToTable("SCHUBLADE_INFO");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.DATUM, e.ZEIT_OFFNEN }, "PK_SCHUBLADE_INFO").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(50);
            entity.Property(e => e.QUITTUNGSNUMMER).HasMaxLength(50);
            entity.Property(e => e.SENDEN).HasMaxLength(100);
            entity.Property(e => e.TSE_TRANSACTION_NR).HasMaxLength(50);
        });

        modelBuilder.Entity<SLAfe>(entity =>
        {
            entity.HasKey(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.TERMINAL_SERIENNR });

            entity.ToTable("SLAVES");

            entity.HasIndex(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.TERMINAL_SERIENNR }, "PK_SLAVES").IsUnique();

            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.TERMINAL_SERIENNR).HasMaxLength(70);
            entity.Property(e => e.TERMINAL_BRAND).HasMaxLength(50);
            entity.Property(e => e.TERMINAL_ID).HasMaxLength(50);
            entity.Property(e => e.TERMINAL_MODELL).HasMaxLength(50);
            entity.Property(e => e.TERMINAL_SW_BRAND).HasMaxLength(50);
            entity.Property(e => e.TERMINAL_SW_VERSION).HasMaxLength(50);
        });

        modelBuilder.Entity<SONDER_BARCODE>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.SZSCANFLAG });

            entity.ToTable("SONDER_BARCODE");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.SZSCANFLAG }, "PK_SONDER_BARCODE").IsUnique();

            entity.Property(e => e.SZSCANFLAG).HasMaxLength(3);
            entity.Property(e => e.DECIVARDIVISORPRICE).HasColumnType("DECIMAL(15,2)");
            entity.Property(e => e.DECIVARDIVISORWEIGHT).HasColumnType("DECIMAL(15,2)");
            entity.Property(e => e.SZPRNFLAG).HasMaxLength(10);
        });

        modelBuilder.Entity<STAMM_KASSEN>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_ID, e.GULTIG_VON });

            entity.ToTable("STAMM_KASSEN");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_ID, e.GULTIG_VON }, "PK_STAMM_KASSEN").IsUnique();

            entity.Property(e => e.KASSE_ID).HasMaxLength(50);
            entity.Property(e => e.GULTIG_VON).HasColumnType("DATE");
            entity.Property(e => e.GULTIG_BIS).HasColumnType("DATE");
            entity.Property(e => e.KASSE_BASISWAEH_CODE).HasMaxLength(3);
            entity.Property(e => e.KASSE_BRAND).HasMaxLength(50);
            entity.Property(e => e.KASSE_MODELL).HasMaxLength(70);
            entity.Property(e => e.KASSE_SERIENNR).HasMaxLength(50);
            entity.Property(e => e.KASSE_SW_BRAND).HasMaxLength(50);
            entity.Property(e => e.KASSE_SW_VERSION).HasMaxLength(50);
            entity.Property(e => e.KEINE_UST_ZUORDNUNG).HasMaxLength(1);
        });

        modelBuilder.Entity<STAMM_TERMINAL>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.TERMINAL_ID });

            entity.ToTable("STAMM_TERMINALS");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.TERMINAL_ID }, "PK_STAMM_TERMINALS").IsUnique();

            entity.Property(e => e.TERMINAL_ID).HasMaxLength(50);
            entity.Property(e => e.GULTIG_BIS).HasColumnType("DATE");
            entity.Property(e => e.GULTIG_VON).HasColumnType("DATE");
            entity.Property(e => e.KASSE_ID).HasMaxLength(50);
            entity.Property(e => e.TERMINAL_BRAND).HasMaxLength(50);
            entity.Property(e => e.TERMINAL_MODELL).HasMaxLength(50);
            entity.Property(e => e.TERMINAL_SERIENNR).HasMaxLength(70);
            entity.Property(e => e.TERMINAL_SW_BRAND).HasMaxLength(50);
            entity.Property(e => e.TERMINAL_SW_VERSION).HasMaxLength(50);
            entity.Property(e => e.TSE_AKTIV).HasMaxLength(4);
        });

        modelBuilder.Entity<STAMM_TSE>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.TSE_SERIAL_NR, e.TSE_ID });

            entity.ToTable("STAMM_TSE");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.TSE_SERIAL_NR, e.TSE_ID }, "PK_STAMM_TSE").IsUnique();

            entity.Property(e => e.TSE_SERIAL_NR).HasMaxLength(68);
            entity.Property(e => e.GULTIG_BIS).HasColumnType("DATE");
            entity.Property(e => e.GULTIG_VON).HasColumnType("DATE");
            entity.Property(e => e.KASSE_ID).HasMaxLength(50);
            entity.Property(e => e.TSE_AKTIV).HasMaxLength(4);
            entity.Property(e => e.TSE_PD_ENCODING).HasMaxLength(5);
            entity.Property(e => e.TSE_PUBLIC_KEY).HasMaxLength(512);
            entity.Property(e => e.TSE_SIG_ALGO).HasMaxLength(21);
            entity.Property(e => e.TSE_ZEITFORMAT).HasMaxLength(31);
            entity.Property(e => e.TSE_ZERTIFIKAT_I).HasMaxLength(1000);
            entity.Property(e => e.TSE_ZERTIFIKAT_II).HasMaxLength(1000);
        });

        modelBuilder.Entity<SUBITEM>(entity =>
        {
            entity.HasKey(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.POS_ZEILE, e.ZI_ART_NR });

            entity.ToTable("SUBITEMS");

            entity.HasIndex(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.POS_ZEILE, e.ZI_ART_NR }, "PK_SUBITEMS").IsUnique();

            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.BON_ID).HasMaxLength(40);
            entity.Property(e => e.POS_ZEILE).HasMaxLength(50);
            entity.Property(e => e.ZI_ART_NR).HasMaxLength(15);
            entity.Property(e => e.ZI_BASISPREIS_BRUTTO).HasMaxLength(10);
            entity.Property(e => e.ZI_BASISPREIS_NETTO).HasMaxLength(10);
            entity.Property(e => e.ZI_BASISPREIS_UST).HasMaxLength(10);
            entity.Property(e => e.ZI_EINHEIT).HasMaxLength(50);
            entity.Property(e => e.ZI_FAKTOR).HasMaxLength(10);
            entity.Property(e => e.ZI_GTIN).HasMaxLength(50);
            entity.Property(e => e.ZI_MENGE).HasMaxLength(10);
            entity.Property(e => e.ZI_NAME).HasMaxLength(60);
            entity.Property(e => e.ZI_UST_SCHLUESSEL).HasMaxLength(5);
            entity.Property(e => e.ZI_WARENGR).HasMaxLength(50);
            entity.Property(e => e.ZI_WARENGR_ID).HasMaxLength(40);
            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
        });

        modelBuilder.Entity<TRANSACTION>(entity =>
        {
            entity.HasKey(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID });

            entity.ToTable("TRANSACTIONS");

            entity.HasIndex(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID }, "PK_TRANSACTIONS").IsUnique();

            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.BON_ID).HasMaxLength(40);
            entity.Property(e => e.BEDIENER_ID).HasMaxLength(50);
            entity.Property(e => e.BEDIENER_NAME).HasMaxLength(50);
            entity.Property(e => e.BON_ENDE).HasMaxLength(30);
            entity.Property(e => e.BON_NAME).HasMaxLength(60);
            entity.Property(e => e.BON_NOTIZ).HasMaxLength(255);
            entity.Property(e => e.BON_NR).HasMaxLength(40);
            entity.Property(e => e.BON_START).HasMaxLength(30);
            entity.Property(e => e.BON_STORNO).HasMaxLength(1);
            entity.Property(e => e.BON_TYP).HasMaxLength(30);
            entity.Property(e => e.KUNDE_ID).HasMaxLength(50);
            entity.Property(e => e.KUNDE_LAND).HasMaxLength(3);
            entity.Property(e => e.KUNDE_NAME).HasMaxLength(50);
            entity.Property(e => e.KUNDE_ORT).HasMaxLength(62);
            entity.Property(e => e.KUNDE_PLZ).HasMaxLength(10);
            entity.Property(e => e.KUNDE_STRASSE).HasMaxLength(60);
            entity.Property(e => e.KUNDE_TYP).HasMaxLength(50);
            entity.Property(e => e.KUNDE_USTID).HasMaxLength(15);
            entity.Property(e => e.TERMINAL_ID).HasMaxLength(50);
            entity.Property(e => e.UMS_BRUTTO).HasMaxLength(30);
        });

        modelBuilder.Entity<TRANSACTIONS_TSE>(entity =>
        {
            entity.HasKey(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.TSE_ID });

            entity.ToTable("TRANSACTIONS_TSE");

            entity.HasIndex(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.TSE_ID }, "PK_TRANSACTIONS_TSE").IsUnique();

            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.BON_ID).HasMaxLength(40);
            entity.Property(e => e.TSE_ID).HasMaxLength(3);
            entity.Property(e => e.TSE_TANR).HasMaxLength(20);
            entity.Property(e => e.TSE_TA_ENDE).HasMaxLength(30);
            entity.Property(e => e.TSE_TA_FEHLER).HasMaxLength(200);
            entity.Property(e => e.TSE_TA_SIG).HasMaxLength(512);
            entity.Property(e => e.TSE_TA_SIGZ).HasMaxLength(10);
            entity.Property(e => e.TSE_TA_START).HasMaxLength(30);
            entity.Property(e => e.TSE_TA_VORGANGSART).HasMaxLength(30);
            entity.Property(e => e.TSE_VORGANGSDATEN).HasMaxLength(80);
        });

        modelBuilder.Entity<TRANSACTIONS_VAT>(entity =>
        {
            entity.HasKey(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.UST_SCHLUESSEL });

            entity.ToTable("TRANSACTIONS_VAT");

            entity.HasIndex(e => new { e.Z_BERICHT_DATUM, e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.BON_ID, e.UST_SCHLUESSEL }, "PK_TRANSACTIONS_VAT").IsUnique();

            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.BON_ID).HasMaxLength(40);
            entity.Property(e => e.UST_SCHLUESSEL).HasMaxLength(3);
            entity.Property(e => e.BON_BRUTTO).HasMaxLength(10);
            entity.Property(e => e.BON_NETTO).HasMaxLength(10);
            entity.Property(e => e.BON_UST).HasMaxLength(10);
        });

        modelBuilder.Entity<TSE>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_ID, e.KASSE_NR, e.Z_BERICHT_NR, e.TRANSACTION_NR, e.DATUM, e.ZEIT, e.QUITTUNGSNUMMER });

            entity.ToTable("TSE");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_ID, e.KASSE_NR, e.Z_BERICHT_NR, e.TRANSACTION_NR, e.DATUM, e.ZEIT, e.QUITTUNGSNUMMER }, "IDX_TSE");

            entity.HasIndex(e => e.BON_ID, "IDX_TSE_BON_ID");

            entity.HasIndex(e => e.DATUM, "IDX_TSE_DATUM");

            entity.HasIndex(e => e.FILIALLE_NR, "IDX_TSE_FILIALLE_NR");

            entity.HasIndex(e => e.KASSE_ID, "IDX_TSE_KASSE_ID");

            entity.HasIndex(e => e.KASSE_NR, "IDX_TSE_KASSE_NR");

            entity.HasIndex(e => e.QUITTUNGSNUMMER, "IDX_TSE_QUITTUNGSNUMMER");

            entity.HasIndex(e => e.TRANSACTION_NR, "IDX_TSE_TRANSACTION_NR");

            entity.HasIndex(e => e.Z_BERICHT_NR, "IDX_TSE_Z_BERICHT_NR");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_ID, e.KASSE_NR, e.Z_BERICHT_NR, e.TRANSACTION_NR, e.DATUM, e.ZEIT, e.QUITTUNGSNUMMER }, "PK_TSE").IsUnique();

            entity.Property(e => e.KASSE_ID).HasMaxLength(50);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(20);
            entity.Property(e => e.SIGNATURE_COUNTER).HasMaxLength(255);
            entity.Property(e => e.TRANSACTION_FINISH_TIME).HasMaxLength(50);
            entity.Property(e => e.TRANSACTION_START_TIME).HasMaxLength(50);
            entity.Property(e => e.TSE_BONN_DATEN).HasMaxLength(500);
            entity.Property(e => e.TSE_DATEN).HasMaxLength(1000);
            entity.Property(e => e.TSE_ID).HasMaxLength(5);
            entity.Property(e => e.TSE_PUBLICKEY).HasMaxLength(500);
            entity.Property(e => e.TSE_SERIAL_NUMMER).HasMaxLength(255);
            entity.Property(e => e.TSE_SIGNATURE_DATEN).HasMaxLength(255);
            entity.Property(e => e.TSE_SIGNATUR_ALG).HasMaxLength(100);
            entity.Property(e => e.TSE_TA_FEHLER).HasMaxLength(100);
            entity.Property(e => e.TSE_ZEIT_FORMAT).HasMaxLength(50);
        });

        modelBuilder.Entity<VAT>(entity =>
        {
            entity.HasKey(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.UST_SCHLUESSEL });

            entity.ToTable("VAT");

            entity.HasIndex(e => new { e.Z_KASSE_ID, e.Z_ERSTELLUNG, e.Z_NR, e.UST_SCHLUESSEL }, "PK_VAT").IsUnique();

            entity.Property(e => e.Z_KASSE_ID).HasMaxLength(25);
            entity.Property(e => e.Z_ERSTELLUNG).HasMaxLength(50);
            entity.Property(e => e.Z_NR).HasMaxLength(20);
            entity.Property(e => e.UST_SCHLUESSEL).HasMaxLength(3);
            entity.Property(e => e.UST_BESCHR).HasMaxLength(55);
            entity.Property(e => e.UST_SATZ).HasMaxLength(4);
            entity.Property(e => e.Z_BERICHT_DATUM).HasColumnType("DATE");
        });

        modelBuilder.Entity<VERKAUF_DETAIL>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.QUITTUNGSNUMMER, e.POS, e.DATUM }).HasName("PK_VERKAUF_DETAIL2");

            entity.ToTable("VERKAUF_DETAIL");

            entity.HasIndex(e => e.BEZEICHNUNG, "IDX_VD_BEZEICHNUNG");

            entity.HasIndex(e => e.BON_ID, "IDX_VD_BON_ID");

            entity.HasIndex(e => e.DATUM, "IDX_VD_DATUM");

            entity.HasIndex(e => e.FILIALLE_NR, "IDX_VD_FILIALLE_NR");

            entity.HasIndex(e => e.KASSE_NR, "IDX_VD_KASSE_NR");

            entity.HasIndex(e => e.POS, "IDX_VD_POS");

            entity.HasIndex(e => e.QUITTUNGSNUMMER, "IDX_VD_QUITTUNGSNUMMER");

            entity.HasIndex(e => e.Z_BERICHT_NR, "IDX_VD_Z_BERICHT_NR");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.DATUM, e.QUITTUNGSNUMMER }, "IDX_VERKAUF_DETAIL");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.QUITTUNGSNUMMER, e.POS, e.DATUM }, "PK_VERKAUF_DETAIL2").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(20);
            entity.Property(e => e.ARTIKEL_NR_FUER_GUTSCHEIN).HasMaxLength(20);
            entity.Property(e => e.BENUTZER_NR).HasMaxLength(20);
            entity.Property(e => e.BESTAND_REDUZIEREN).HasMaxLength(5);
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(50);
            entity.Property(e => e.BONN_STATUS).HasMaxLength(20);
            entity.Property(e => e.EINHEIT).HasMaxLength(5);
            entity.Property(e => e.GTIN).HasMaxLength(1);
            entity.Property(e => e.GUTSCHEIN_NR).HasMaxLength(100);
            entity.Property(e => e.GVF)
                .HasMaxLength(30)
                .HasDefaultValueSql("null");
            entity.Property(e => e.KASSE_ID)
                .HasMaxLength(50)
                .HasDefaultValueSql("null");
            entity.Property(e => e.KUNDEN_NR).HasMaxLength(15);
            entity.Property(e => e.LIEFERANTEN)
                .HasMaxLength(50)
                .HasDefaultValueSql("null");
            entity.Property(e => e.MWST_BEZEICHNUNG).HasMaxLength(5);
            entity.Property(e => e.POS_STORNO).HasMaxLength(3);
            entity.Property(e => e.RABATT_FAHIG).HasMaxLength(5);
            entity.Property(e => e.REF_BON_ID).HasMaxLength(30);
            entity.Property(e => e.REF_DATUM).HasColumnType("DATE");
            entity.Property(e => e.REF_KASSE_ID).HasMaxLength(50);
            entity.Property(e => e.REF_RABATT_POS).HasMaxLength(5);
            entity.Property(e => e.REF_Z_ID).HasMaxLength(10);
            entity.Property(e => e.STORNO_ART).HasMaxLength(15);
            entity.Property(e => e.TSE_ID).HasMaxLength(5);
            entity.Property(e => e.TSE_TRANSACTION_NR).HasDefaultValueSql("null");
            entity.Property(e => e.VERKAUF_ART).HasMaxLength(30);
            entity.Property(e => e.WARENGRUPPE).HasMaxLength(50);
            entity.Property(e => e.WARENGR_ID).HasMaxLength(20);
        });

        modelBuilder.Entity<VERKAUF_MASTER>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.QUITTUNGSNUMMER });

            entity.ToTable("VERKAUF_MASTER");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.DATUM, e.QUITTUNGSNUMMER }, "IDX_VERKAUF_MASTER");

            entity.HasIndex(e => e.BON_ID, "IDX_VM_BON_ID");

            entity.HasIndex(e => e.DATUM, "IDX_VM_DATUM");

            entity.HasIndex(e => e.FILIALLE_NR, "IDX_VM_FILIALLE_NR");

            entity.HasIndex(e => e.KASSE_ID, "IDX_VM_KASSE_ID");

            entity.HasIndex(e => e.KASSE_NR, "IDX_VM_KASSE_NR");

            entity.HasIndex(e => e.QUITTUNGSNUMMER, "IDX_VM_QUITTUNGSNUMMER");

            entity.HasIndex(e => e.Z_BERICHT_NR, "IDX_VM_Z_BERICHT_NR");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.QUITTUNGSNUMMER }, "PK_VERKAUF_MASTER").IsUnique();

            entity.Property(e => e.BENUTZER_NAME).HasMaxLength(30);
            entity.Property(e => e.BENUTZER_NR).HasMaxLength(10);
            entity.Property(e => e.BONN_STATUS).HasMaxLength(20);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.KASSE_ID)
                .HasMaxLength(50)
                .HasDefaultValueSql("null");
            entity.Property(e => e.KUNDEN_NR).HasColumnType("CHAR(15)");
            entity.Property(e => e.KUNDE_LAND)
                .HasMaxLength(5)
                .HasDefaultValueSql("null");
            entity.Property(e => e.KUNDE_NAME)
                .HasMaxLength(50)
                .HasDefaultValueSql("null");
            entity.Property(e => e.KUNDE_ORT)
                .HasMaxLength(50)
                .HasDefaultValueSql("null");
            entity.Property(e => e.KUNDE_PLZ)
                .HasMaxLength(10)
                .HasDefaultValueSql("null");
            entity.Property(e => e.KUNDE_STRASSE)
                .HasMaxLength(30)
                .HasDefaultValueSql("null");
            entity.Property(e => e.KUNDE_TYP)
                .HasMaxLength(20)
                .HasDefaultValueSql("null");
            entity.Property(e => e.KUNDE_USTID)
                .HasMaxLength(20)
                .HasDefaultValueSql("null");
            entity.Property(e => e.TSE_ID).HasMaxLength(5);
            entity.Property(e => e.TSE_TRANSACTION_NR).HasDefaultValueSql("null");
            entity.Property(e => e.VERKAUF_ART).HasMaxLength(30);
        });

        modelBuilder.Entity<VERKAUF_MWST>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.SITZUNG_NR, e.QUITTUNGSNUMMER, e.MWST });

            entity.ToTable("VERKAUF_MWST");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.SITZUNG_NR, e.QUITTUNGSNUMMER, e.MWST }, "IDX_VERKAUF_MWST");

            entity.HasIndex(e => e.BON_ID, "IDX_VMWST_BON_ID");

            entity.HasIndex(e => e.DATUM, "IDX_VMWST_DATUM");

            entity.HasIndex(e => e.FILIALLE_NR, "IDX_VMWST_FILIALLE_NR");

            entity.HasIndex(e => e.KASSE_NR, "IDX_VMWST_KASSE_NR");

            entity.HasIndex(e => e.MWST, "IDX_VMWST_MWST");

            entity.HasIndex(e => e.QUITTUNGSNUMMER, "IDX_VMWST_QUITTUNGSNUMMER");

            entity.HasIndex(e => e.Z_BERICHT_NR, "IDX_VMWST_Z_BERICHT_NR");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.SITZUNG_NR, e.QUITTUNGSNUMMER, e.MWST }, "PK_VERKAUF_MWST").IsUnique();

            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(20);
            entity.Property(e => e.DATUM)
                .HasDefaultValueSql("null")
                .HasColumnType("DATE");
            entity.Property(e => e.KASSE_ID)
                .HasMaxLength(50)
                .HasDefaultValueSql("null");
            entity.Property(e => e.TSE_ID).HasMaxLength(5);
            entity.Property(e => e.TSE_TRANSACTION_NR).HasDefaultValueSql("null");
        });

        modelBuilder.Entity<VERKAUF_ZVT>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.SITZUNG_NR, e.QUITTUNGSNUMMER, e.TSE_TRANSACTION_NR, e.KASSE_ID, e.DATUM, e.ZEIT });

            entity.ToTable("VERKAUF_ZVT");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.SITZUNG_NR, e.QUITTUNGSNUMMER, e.TSE_TRANSACTION_NR, e.KASSE_ID, e.DATUM, e.ZEIT }, "PK_VERKAUF_ZVT").IsUnique();

            entity.Property(e => e.KASSE_ID).HasMaxLength(50);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.HANDLERBELEG).HasMaxLength(5000);
            entity.Property(e => e.KARTEN_TYPE).HasMaxLength(30);
            entity.Property(e => e.KUNDENBELEG).HasMaxLength(5000);
        });

        modelBuilder.Entity<VIEW_ARTIKEL_GEWINN>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ARTIKEL_GEWINN");

            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(20);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.VERKAUF_ART).HasMaxLength(30);
        });

        modelBuilder.Entity<VIEW_ARTIKEL_VERKAUF_HISTORY>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ARTIKEL_VERKAUF_HISTORY");

            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(20);
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(50);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.EINHEIT).HasMaxLength(5);
            entity.Property(e => e.WARENGRUPPE).HasMaxLength(50);
        });

        modelBuilder.Entity<VIEW_VERKAUFTE_ARTIKEL>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_VERKAUFTE_ARTIKEL");

            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(20);
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(50);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.EINHEIT).HasMaxLength(5);
            entity.Property(e => e.WARENGRUPPE).HasMaxLength(50);
        });

        modelBuilder.Entity<WAAGE_ABTEILUNG>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ABT_NR });

            entity.ToTable("WAAGE_ABTEILUNG");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ABT_NR }, "PK_WAAGE_ABTEILUNG").IsUnique();

            entity.Property(e => e.ABTEILUNG_NAME).HasMaxLength(50);
            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(50);
        });

        modelBuilder.Entity<WAAGE_ABTEILUNG_TMP>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ABT_NR });

            entity.ToTable("WAAGE_ABTEILUNG_TMP");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ABT_NR }, "PK_WAAGE_ABTEILUNG_TMP").IsUnique();

            entity.Property(e => e.ABTEILUNG_NAME).HasMaxLength(50);
            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(50);
        });

        modelBuilder.Entity<WAAGE_ARTIKEL>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR, e.ARTIKEL_NR });

            entity.ToTable("WAAGE_ARTIKEL");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR, e.ARTIKEL_NR }, "IDX_WAAGE_ARTIKEL");

            entity.HasIndex(e => e.ABTEILUNG_NR, "IDX_WAAGE_ARTIKEL_ABTEILUNG_NR");

            entity.HasIndex(e => e.ARTIKEL_NR, "IDX_WAAGE_ARTIKEL_ARTIKEL_NR");

            entity.HasIndex(e => e.FILIALLE_NR, "IDX_WAAGE_ARTIKEL_FILIALLE_NR");

            entity.HasIndex(e => e.WG_NR, "IDX_WAAGE_ARTIKEL_WG_NR");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR, e.ARTIKEL_NR }, "PK_WAAGE_ARTIKEL").IsUnique();

            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(30);
            entity.Property(e => e.ARTIKEL_NAME).HasMaxLength(50);
            entity.Property(e => e.BARCODE_NR).HasMaxLength(20);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.ETIKET_DRUCKEN).HasMaxLength(2);
            entity.Property(e => e.SENDEN).HasMaxLength(50);
            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(20);
            entity.Property(e => e.WIEGE_ARTIKEL).HasMaxLength(6);
        });

        modelBuilder.Entity<WAAGE_ARTIKEL_HISTORY>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR, e.ARTIKEL_NR, e.DATUM, e.ZEIT });

            entity.ToTable("WAAGE_ARTIKEL_HISTORY");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR, e.ARTIKEL_NR, e.DATUM, e.ZEIT }, "PK_WAAGE_ARTIKEL_HISTORY").IsUnique();

            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(30);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.ARTIKEL_NAME).HasMaxLength(50);
            entity.Property(e => e.BARCODE_NR).HasMaxLength(20);
            entity.Property(e => e.ETIKET_DRUCKEN).HasMaxLength(2);
            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(20);
            entity.Property(e => e.WIEGE_ARTIKEL).HasMaxLength(6);
        });

        modelBuilder.Entity<WAAGE_ARTIKEL_TMP>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR, e.ARTIKEL_NR });

            entity.ToTable("WAAGE_ARTIKEL_TMP");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR, e.ARTIKEL_NR }, "IDX_WAAGE_ARTIKEL_TMP");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR, e.ARTIKEL_NR }, "PK_WAAGE_ARTIKEL_TMP").IsUnique();

            entity.Property(e => e.ARTIKEL_NR).HasMaxLength(30);
            entity.Property(e => e.ARTIKEL_NAME).HasMaxLength(50);
            entity.Property(e => e.BARCODE_NR).HasMaxLength(20);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.ETIKET_DRUCKEN).HasMaxLength(2);
            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(20);
            entity.Property(e => e.WIEGE_ARTIKEL).HasMaxLength(6);
        });

        modelBuilder.Entity<WAAGE_BILDER>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.BILD_POS });

            entity.ToTable("WAAGE_BILDER");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.BILD_POS }, "PK_WAAGE_BILDER").IsUnique();

            entity.Property(e => e.BILD_NAME).HasMaxLength(50);
            entity.Property(e => e.SENDEN).HasMaxLength(100);
        });

        modelBuilder.Entity<WAAGE_MITARBEITER>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.MITARBEITER_NR });

            entity.ToTable("WAAGE_MITARBEITER");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.MITARBEITER_NR }, "PK_WAAGE_MITARBEITER").IsUnique();

            entity.Property(e => e.MITARBEITER_NAME).HasMaxLength(50);
            entity.Property(e => e.PASSWORT).HasMaxLength(50);
            entity.Property(e => e.PROFIL).HasMaxLength(50);
            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(20);
        });

        modelBuilder.Entity<WAAGE_UMSATZ>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.WAAGE_TRANSAKTION_NR, e.DATUM });

            entity.ToTable("WAAGE_UMSATZ");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.WAAGE_TRANSAKTION_NR, e.DATUM }, "PK_WAAGE_UMSATZ").IsUnique();

            entity.Property(e => e.WAAGE_TRANSAKTION_NR).HasMaxLength(50);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(50);
        });

        modelBuilder.Entity<WAAGE_WARENGRUPPEN>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR });

            entity.ToTable("WAAGE_WARENGRUPPEN");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR }, "PK_WAAGE_WARENGRUPPEN").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.SENDEN).HasMaxLength(50);
            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(50);
            entity.Property(e => e.WG_NAME).HasMaxLength(50);
        });

        modelBuilder.Entity<WAAGE_WARENGRUPPEN_TMP>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR });

            entity.ToTable("WAAGE_WARENGRUPPEN_TMP");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.ABTEILUNG_NR, e.WG_NR }, "PK_WAAGE_WARENGRUPPEN_TMP").IsUnique();

            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.WAAGE_HERSTELLER).HasMaxLength(50);
            entity.Property(e => e.WG_NAME).HasMaxLength(50);
        });

        modelBuilder.Entity<WARENGRUPPEN>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.WG_NUMMER });

            entity.ToTable("WARENGRUPPEN");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.WG_NUMMER }, "PK_WARENGRUPPEN").IsUnique();

            entity.Property(e => e.RABATT_FAHIG)
                .HasMaxLength(5)
                .HasDefaultValueSql("null");
            entity.Property(e => e.SENDEN).HasMaxLength(50);
            entity.Property(e => e.VK_PREIS).HasDefaultValueSql("null");
            entity.Property(e => e.WG_ART).HasMaxLength(20);
            entity.Property(e => e.WG_NAME).HasMaxLength(30);
            entity.Property(e => e.WG_WERT).HasMaxLength(1);
        });

        modelBuilder.Entity<ZAHL_PROTOKOL>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.KASSE_ID, e.DATUM, e.POS });

            entity.ToTable("ZAHL_PROTOKOL");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.KASSE_ID, e.DATUM, e.POS }, "PK_ZAHL_PROTOKOL").IsUnique();

            entity.Property(e => e.KASSE_ID).HasMaxLength(50);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.BEZEICHNUNG).HasMaxLength(30);
        });

        modelBuilder.Entity<ZVT_KASSENSCHNITT>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.KASSE_ID, e.DATUM, e.ZEIT });

            entity.ToTable("ZVT_KASSENSCHNITT");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR, e.KASSE_ID, e.DATUM, e.ZEIT }, "PK_ZVT_KASSENSCHNITT").IsUnique();

            entity.Property(e => e.KASSE_ID).HasMaxLength(50);
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.KASSENSCHNITT).HasMaxLength(5000);
        });

        modelBuilder.Entity<Z_BERICHT>(entity =>
        {
            entity.HasKey(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR });

            entity.ToTable("Z_BERICHT");

            entity.HasIndex(e => e.DATUM, "IDX_ZB_DATUM");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.Z_BERICHT_NR, e.DATUM }, "IDX_ZB_FILIALLE_NR");

            entity.HasIndex(e => e.Z_BERICHT_NR, "IDX_ZB_Z_BERICHT_NR");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.Z_BERICHT_NR, e.DATUM }, "IDX_Z_BERICHT");

            entity.HasIndex(e => new { e.FILIALLE_NR, e.KASSE_NR, e.Z_BERICHT_NR }, "PK_Z_BERICHT").IsUnique();

            entity.Property(e => e.BAR_REST_BETRAG).HasDefaultValueSql("NULL");
            entity.Property(e => e.DATUM).HasColumnType("DATE");
            entity.Property(e => e.DATUM_ENDE).HasColumnType("DATE");
            entity.Property(e => e.DSFINVK_STATUS).HasDefaultValueSql("NULL");
            entity.Property(e => e.FIRM_NAME).HasMaxLength(50);
            entity.Property(e => e.INHABER).HasMaxLength(20);
            entity.Property(e => e.KASSE_ID).HasMaxLength(50);
            entity.Property(e => e.LAND).HasMaxLength(3);
            entity.Property(e => e.ORT).HasMaxLength(50);
            entity.Property(e => e.PLZ).HasMaxLength(10);
            entity.Property(e => e.STNR).HasMaxLength(20);
            entity.Property(e => e.STRASSE).HasMaxLength(50);
            entity.Property(e => e.USTID).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    public override int SaveChanges()
    {
        foreach (var entry in ChangeTracker.Entries().Where(e => e.State == EntityState.Added))
        {
            EntityChangeHandler.HandleEntityChange(entry, this);
        }
       

        return base.SaveChanges();
    }

}
