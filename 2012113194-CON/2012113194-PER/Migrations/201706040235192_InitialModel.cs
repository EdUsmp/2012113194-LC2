namespace _2012113194_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asientoes",
                c => new
                    {
                        AsientoId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Cinturon_CinturonId = c.Int(),
                        Carro_CarroId = c.Int(),
                    })
                .PrimaryKey(t => t.AsientoId)
                .ForeignKey("dbo.Cinturons", t => t.Cinturon_CinturonId)
                .ForeignKey("dbo.Carroes", t => t.Carro_CarroId)
                .Index(t => t.Cinturon_CinturonId)
                .Index(t => t.Carro_CarroId);
            
            CreateTable(
                "dbo.Cinturons",
                c => new
                    {
                        CinturonId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Metraje = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CinturonId);
            
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        CarroId = c.Int(nullable: false, identity: true),
                        TipoCarro = c.Int(nullable: false),
                        NumSerieChasis = c.String(),
                        AutomovilId = c.Int(),
                        TipoAuto = c.Int(),
                        BusId = c.Int(),
                        TipoBus = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Parabrisas_ParabrisasId = c.Int(),
                        Propietario_PropietarioId = c.Int(),
                        Volante_VolanteId = c.Int(),
                        Ensambladora_EnsambladoraId = c.Int(),
                    })
                .PrimaryKey(t => t.CarroId)
                .ForeignKey("dbo.Parabrisas", t => t.Parabrisas_ParabrisasId)
                .ForeignKey("dbo.Propietarios", t => t.Propietario_PropietarioId)
                .ForeignKey("dbo.Volantes", t => t.Volante_VolanteId)
                .ForeignKey("dbo.Ensambladoras", t => t.Ensambladora_EnsambladoraId)
                .Index(t => t.Parabrisas_ParabrisasId)
                .Index(t => t.Propietario_PropietarioId)
                .Index(t => t.Volante_VolanteId)
                .Index(t => t.Ensambladora_EnsambladoraId);
            
            CreateTable(
                "dbo.Llantas",
                c => new
                    {
                        LlantaId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Carro_CarroId = c.Int(),
                    })
                .PrimaryKey(t => t.LlantaId)
                .ForeignKey("dbo.Carroes", t => t.Carro_CarroId)
                .Index(t => t.Carro_CarroId);
            
            CreateTable(
                "dbo.Parabrisas",
                c => new
                    {
                        ParabrisasId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                    })
                .PrimaryKey(t => t.ParabrisasId);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        PropietarioId = c.Int(nullable: false, identity: true),
                        DNI = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        LicenciaConducir = c.String(),
                    })
                .PrimaryKey(t => t.PropietarioId);
            
            CreateTable(
                "dbo.Volantes",
                c => new
                    {
                        VolanteId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                    })
                .PrimaryKey(t => t.VolanteId);
            
            CreateTable(
                "dbo.Ensambladoras",
                c => new
                    {
                        EnsambladoraId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EnsambladoraId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carroes", "Ensambladora_EnsambladoraId", "dbo.Ensambladoras");
            DropForeignKey("dbo.Carroes", "Volante_VolanteId", "dbo.Volantes");
            DropForeignKey("dbo.Carroes", "Propietario_PropietarioId", "dbo.Propietarios");
            DropForeignKey("dbo.Carroes", "Parabrisas_ParabrisasId", "dbo.Parabrisas");
            DropForeignKey("dbo.Llantas", "Carro_CarroId", "dbo.Carroes");
            DropForeignKey("dbo.Asientoes", "Carro_CarroId", "dbo.Carroes");
            DropForeignKey("dbo.Asientoes", "Cinturon_CinturonId", "dbo.Cinturons");
            DropIndex("dbo.Llantas", new[] { "Carro_CarroId" });
            DropIndex("dbo.Carroes", new[] { "Ensambladora_EnsambladoraId" });
            DropIndex("dbo.Carroes", new[] { "Volante_VolanteId" });
            DropIndex("dbo.Carroes", new[] { "Propietario_PropietarioId" });
            DropIndex("dbo.Carroes", new[] { "Parabrisas_ParabrisasId" });
            DropIndex("dbo.Asientoes", new[] { "Carro_CarroId" });
            DropIndex("dbo.Asientoes", new[] { "Cinturon_CinturonId" });
            DropTable("dbo.Ensambladoras");
            DropTable("dbo.Volantes");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Parabrisas");
            DropTable("dbo.Llantas");
            DropTable("dbo.Carroes");
            DropTable("dbo.Cinturons");
            DropTable("dbo.Asientoes");
        }
    }
}
