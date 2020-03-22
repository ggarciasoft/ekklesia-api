using Ekklesia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.Data
{
    public static class ModelBuilderExtensions
    {
        private static readonly DateTime _now = DateTime.Now;
        private static ModelBuilder SeedTenants(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tenant>().HasData(
                new Tenant
                {
                    Id = 1,
                    Name = "El Buen Pastor",
                    Description = "Iglesia El Buen Pastor"
                }
            );
            return modelBuilder;
        }

        private static ModelBuilder SeedRoles(this ModelBuilder modelBuilder)
        {
            var id = 1;

            modelBuilder.Entity<Role>().HasData(
                 new Role
                 {
                     Id = id++,
                     Name = "Admin",
                     Alias = "ADMIN",
                     Description = "Administrador",
                     IsActive = true,
                     InsertDate = _now,
                     InsertUserId = 0
                 },
                 new Role
                 {
                     Id = id++,
                     Name = "Operador/a",
                     Alias = "OPERATOR",
                     IsActive = true,
                     InsertDate = _now,
                     InsertUserId = 0
                 }
             );
            return modelBuilder;
        }

        private static ModelBuilder SeedActivityTypes(this ModelBuilder modelBuilder)
        {
            var names = new[] { "Culto", "Campaña", "Vigilia", "Culto de Oración", "Culto de Damas", "Culto de Caballeros", "Culto de Niños", "Otro" };
            var aliases = new[] { "CULT", "CAMPAIGN", "VIGIL", "PRAY_CULT", "LADY_CULT", "GENTLEMAN_CULT", "CHILDREN_CULT", "OTHER" };
            var lst = new List<ActivityType>();
            for (int i = 0; i < names.Length; i++)
                lst.Add(new ActivityType
                {
                    Id = i+1,
                    Name = names[i],
                    Alias = aliases[i],
                    IsActive = true,
                    InsertDate = _now,
                    InsertUserId = 0
                });

            modelBuilder.Entity<ActivityType>().HasData(lst);
            return modelBuilder;
        }

        private static ModelBuilder SeedMinistries(this ModelBuilder modelBuilder)
        {
            var names = new[] { 
                "Ministerio de Oración", 
                "Ministerio de Damas", 
                "Ministerio de Caballeros",
                "Ministerio de Jóvenes", 
                "Ministerio de Adolecentes", 
                "Ministerio de Niños",
                "Ministerio de Evangelismo y Misiones", 
                "Ministerio de Finanzas",
                "Ministerio de Diaconía",
                "Ministerio de Casados",
                "Ministerio de Adoración",
                "Otro" };
            var aliases = new[] { 
                "PRAY_MINISTRY", 
                "LADY_MINISTRY", 
                "GENTLEMAN_MINISTRY", 
                "YOUNG_MINISTRY", 
                "YOUNG_MINISTRY", 
                "TEEN_MINISTRY", 
                "CHILDREN_MINISTRY", 
                "EVANGELISM_MISSION_MINISTRY", 
                "FINANCIAL_MINISTRY",
                "DIAKONIA_MINISTRY",
                "MARRIED_MINISTRY",
                "WORSHIP_MINISTRY",
                "OTHER" };
            var lst = new List<Ministry>();
            for (int i = 0; i < names.Length; i++)
                lst.Add(new Ministry
                {
                    Id = i + 1,
                    Name = names[i],
                    Alias = aliases[i],
                    IsActive = true,
                    InsertDate = _now,
                    InsertUserId = 0
                });

            modelBuilder.Entity<Ministry>().HasData(lst);
            return modelBuilder;
        }

        private static ModelBuilder SeedAssets(this ModelBuilder modelBuilder)
        {
            var names = new[] { "Silla", "Mesa", "Micrófono", "Bocina", "Poyector", "Piano", "Tambora", "Platillo", "Otro" };
            var aliases = new[] { "CHAIR", "TABLE", "MICROPHONE", "SPEAKER", "PROJECTOR", "PIANO", "DRUM", "SAUCER", "OTHER" };
            var lst = new List<Asset>();
            for (int i = 0; i < names.Length; i++)
                lst.Add(new Asset
                {
                    Id = i + 1,
                    Name = names[i],
                    Alias = aliases[i],
                    IsActive = true,
                    InsertDate = _now,
                    InsertUserId = 0
                });
            modelBuilder.Entity<Asset>().HasData(lst);
            return modelBuilder;
        }

        private static ModelBuilder SeedEntityTypes(this ModelBuilder modelBuilder)
        {
            var names = new[] { "Persona", "Iglesia", "Ministerio", "Otro" };
            var aliases = new[] { "PERSON", "CHURCH", "MINISTRY", "OTHER" };
            var lst = new List<EntityType>();
            for (int i = 0; i < names.Length; i++)
                lst.Add(new EntityType
                {
                    Id = i + 1,
                    Name = names[i],
                    Alias = aliases[i],
                    IsActive = true,
                    InsertDate = _now,
                    InsertUserId = 0
                });
            modelBuilder.Entity<EntityType>().HasData(lst);
            return modelBuilder;
        }

        private static ModelBuilder SeedMovementTypes(this ModelBuilder modelBuilder)
        {
            var names = new[] { "Ingreso", "Egreso" };
            var aliases = new[] { "ENTRY", "EGRESS" };
            var lst = new List<MovementType>();
            for (int i = 0; i < names.Length; i++)
                lst.Add(new MovementType
                {
                    Id = i + 1,
                    Name = names[i],
                    Alias = aliases[i],
                    IsActive = true,
                    InsertDate = _now,
                    InsertUserId = 0
                });
            modelBuilder.Entity<MovementType>().HasData(lst);
            return modelBuilder;
        }

        private static ModelBuilder SeedPositions(this ModelBuilder modelBuilder)
        {
            var names = new[] { "Pastor/a", "Director/a", "Sub-Director/a", "Secretario/a", "Otro" };
            var aliases = new[] { "SHEPHERD", "DIRECTOR", "SUBDIRECTOR", "SECRETARY", "OTHER" };
            var lst = new List<Position>();
            for (int i = 0; i < names.Length; i++)
                lst.Add(new Position
                {
                    Id = i + 1,
                    Name = names[i],
                    Alias = aliases[i],
                    IsActive = true,
                    InsertDate = _now,
                    InsertUserId = 0
                });
            modelBuilder.Entity<Position>().HasData(lst);
            return modelBuilder;
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder
                .SeedTenants()
                .SeedRoles()
                .SeedActivityTypes()
                .SeedAssets()
                .SeedEntityTypes()
                .SeedMovementTypes()
                .SeedMinistries()
                .SeedPositions();
        }
    }
}
