namespace Biblioteca.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_LIBRO",
                c => new
                    {
                        ID_LIBRO = c.Int(nullable: false, identity: true),
                        TITULO_LIBRO = c.String(maxLength: 100),
                        NOM_AUTOR = c.String(maxLength: 100),
                        IND_ACTIVO = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_LIBRO);
            
            CreateTable(
                "dbo.TBL_PRESTAMO",
                c => new
                    {
                        ID_PRESTAMO = c.Int(nullable: false, identity: true),
                        ID_RESERVA = c.Int(nullable: false),
                        FEC_PRESTAMO = c.DateTime(nullable: false),
                        ID_LIBRO = c.Int(nullable: false),
                        ID_USUARIO = c.Int(nullable: false),
                        IND_ESTADO = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.ID_PRESTAMO)
                .ForeignKey("dbo.TBL_USUARIO", t => t.ID_USUARIO, cascadeDelete: true)
                .ForeignKey("dbo.TBL_LIBRO", t => t.ID_LIBRO, cascadeDelete: true)
                .Index(t => t.ID_LIBRO)
                .Index(t => t.ID_USUARIO);
            
            CreateTable(
                "dbo.TBL_USUARIO",
                c => new
                    {
                        ID_USUARIO = c.Int(nullable: false, identity: true),
                        COD_USUARIO = c.String(maxLength: 20),
                        NOM_USUARIO = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID_USUARIO);
            
            CreateTable(
                "dbo.TBL_RESERVA",
                c => new
                    {
                        ID_RESERVA = c.Int(nullable: false, identity: true),
                        FEC_RESERVA = c.DateTime(nullable: false),
                        ID_LIBRO = c.Int(nullable: false),
                        ID_USUARIO = c.Int(nullable: false),
                        IND_ESTADO = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.ID_RESERVA)
                .ForeignKey("dbo.TBL_USUARIO", t => t.ID_USUARIO, cascadeDelete: true)
                .ForeignKey("dbo.TBL_LIBRO", t => t.ID_LIBRO, cascadeDelete: true)
                .Index(t => t.ID_LIBRO)
                .Index(t => t.ID_USUARIO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBL_RESERVA", "ID_LIBRO", "dbo.TBL_LIBRO");
            DropForeignKey("dbo.TBL_RESERVA", "ID_USUARIO", "dbo.TBL_USUARIO");
            DropForeignKey("dbo.TBL_PRESTAMO", "ID_LIBRO", "dbo.TBL_LIBRO");
            DropForeignKey("dbo.TBL_PRESTAMO", "ID_USUARIO", "dbo.TBL_USUARIO");
            DropIndex("dbo.TBL_RESERVA", new[] { "ID_USUARIO" });
            DropIndex("dbo.TBL_RESERVA", new[] { "ID_LIBRO" });
            DropIndex("dbo.TBL_PRESTAMO", new[] { "ID_USUARIO" });
            DropIndex("dbo.TBL_PRESTAMO", new[] { "ID_LIBRO" });
            DropTable("dbo.TBL_RESERVA");
            DropTable("dbo.TBL_USUARIO");
            DropTable("dbo.TBL_PRESTAMO");
            DropTable("dbo.TBL_LIBRO");
        }
    }
}
