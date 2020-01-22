namespace GlobalSoporte.NET.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GlobalSoporte.NET.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<GlobalSoporte.NET.DataAccess.SoporteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GlobalSoporte.NET.DataAccess.SoporteContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var users = new List<Users>
            {
            new Users{UserId="1",Nombre="Nelson Pino",Cargo="Jefe de Sistemas",Departamento="Soporte y Programacion",MapId="001",Role="Administrator"},
            new Users{UserId="2",Nombre="Juan Carlos Rojas",Cargo="Tecnico de Soporte",Departamento="Soporte y Programacion",MapId="002",Role="User"},
            new Users{UserId="3",Nombre="Janet Peña",Cargo="Gerente de Operaciones",Departamento="Operaciones",MapId="003",Role="User"},
            new Users{UserId="4",Nombre="Ashley Villaroel",Cargo="Asistente operaciones",Departamento="Recepcion",MapId="004",Role="User"},
            new Users{UserId="5",Nombre="Carmen sanchez",Cargo="Jefe de Finanzas",Departamento="Contabilidad",MapId="005",Role="User"},
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}
