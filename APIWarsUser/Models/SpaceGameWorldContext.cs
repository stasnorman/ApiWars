using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIWarsUser.Models
{
    public partial class SpaceGameWorldContext : DbContext
    {
        public SpaceGameWorldContext()
        {
        }

        public SpaceGameWorldContext(DbContextOptions<SpaceGameWorldContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<ActionUser> ActionUsers { get; set; } = null!;
        public virtual DbSet<DeveloperInTeam> DeveloperInTeams { get; set; } = null!;
        public virtual DbSet<DisasterWorld> DisasterWorlds { get; set; } = null!;
        public virtual DbSet<Drone> Drones { get; set; } = null!;
        public virtual DbSet<DroneRole> DroneRoles { get; set; } = null!;
        public virtual DbSet<DroneSkillsSet> DroneSkillsSets { get; set; } = null!;
        public virtual DbSet<EfficiencyAction> EfficiencyActions { get; set; } = null!;
        public virtual DbSet<EventNew> EventNews { get; set; } = null!;
        public virtual DbSet<GameObject> GameObjects { get; set; } = null!;
        public virtual DbSet<InformationDrone> InformationDrones { get; set; } = null!;
        public virtual DbSet<NetScan> NetScans { get; set; } = null!;
        public virtual DbSet<ObjectAvailable> ObjectAvailables { get; set; } = null!;
        public virtual DbSet<Planet> Planets { get; set; } = null!;
        public virtual DbSet<RateLimit> RateLimits { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleInTeam> RoleInTeams { get; set; } = null!;
        public virtual DbSet<StateGameObject> StateGameObjects { get; set; } = null!;
        public virtual DbSet<Statistic> Statistics { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;
        public virtual DbSet<TypeGameObject> TypeGameObjects { get; set; } = null!;
        public virtual DbSet<UnicEfficiency> UnicEfficiencies { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=81.177.6.104, 1433;Database=SpaceGameWorld; User ID=sa; Password = WsrWsrWsr2021$; Trusted_Connection=False; Integrated Security=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Login)
                    .HasName("PK_Account_1");

                entity.ToTable("Account");

                entity.HasIndex(e => e.RoleName, "IX_Account_RoleName");

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.ApiKey).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MaxRl).HasColumnName("MaxRL");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(300);

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.HasOne(d => d.RoleNameNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Role");
            });


            modelBuilder.Entity<ActionUser>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("ActionUser");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DeveloperInTeam>(entity =>
            {
                entity.HasKey(e => new { e.LoginUser, e.TeamName });

                entity.ToTable("DeveloperInTeam");

                entity.HasIndex(e => e.Role, "IX_DeveloperInTeam_Role");

                entity.HasIndex(e => e.TeamName, "IX_DeveloperInTeam_TeamName");

                entity.Property(e => e.LoginUser).HasMaxLength(50);

                entity.Property(e => e.TeamName).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.HasOne(d => d.LoginUserNavigation)
                    .WithMany(p => p.DeveloperInTeams)
                    .HasForeignKey(d => d.LoginUser)
                    .HasConstraintName("FK_DeveloperInTeam_Account");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.DeveloperInTeams)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeveloperInTeam_RoleInTeam");

                entity.HasOne(d => d.TeamNameNavigation)
                    .WithMany(p => p.DeveloperInTeams)
                    .HasForeignKey(d => d.TeamName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeveloperInTeam_Team");
            });

            modelBuilder.Entity<DisasterWorld>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK_Disaster");

                entity.ToTable("DisasterWorld");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Body).HasMaxLength(450);
            });

            modelBuilder.Entity<Drone>(entity =>
            {
                entity.HasKey(e => e.ShortName)
                    .HasName("PK_Drone_1");

                entity.ToTable("Drone");

                entity.HasIndex(e => e.MoveAction, "IX_Drone_TypeDrone");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.DroneRoleName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.DroneRoleNameNavigation)
                    .WithMany(p => p.Drones)
                    .HasForeignKey(d => d.DroneRoleName)
                    .HasConstraintName("FK_Drone_DroneRole");
            });

            modelBuilder.Entity<DroneRole>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("DroneRole");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(300);
            });

            modelBuilder.Entity<DroneSkillsSet>(entity =>
            {
                entity.HasKey(e => new { e.ShortNameDrone, e.EfficiencyActionName });

                entity.ToTable("DroneSkillsSet");

                entity.Property(e => e.ShortNameDrone)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.EfficiencyActionName).HasMaxLength(50);

                entity.HasOne(d => d.EfficiencyActionNameNavigation)
                    .WithMany(p => p.DroneSkillsSets)
                    .HasForeignKey(d => d.EfficiencyActionName)
                    .HasConstraintName("FK_DroneSkillsSet_EfficiencyAction");

                entity.HasOne(d => d.ShortNameDroneNavigation)
                    .WithMany(p => p.DroneSkillsSets)
                    .HasForeignKey(d => d.ShortNameDrone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DroneSkillsSet_Drone");
            });

            modelBuilder.Entity<EfficiencyAction>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK_DroneFeature_1");

                entity.ToTable("EfficiencyAction");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ValueAction).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<EventNew>(entity =>
            {
                entity.HasKey(e => e.CodeNumber)
                    .HasName("PK_Event");

                entity.ToTable("EventNew");

                entity.HasIndex(e => e.DisasterWorldName, "IX_EventNew_DisasterWorldName");

                entity.Property(e => e.CodeNumber).HasMaxLength(50);

                entity.Property(e => e.Body).HasMaxLength(50);

                entity.Property(e => e.DisasterWorldName).HasMaxLength(50);

                entity.HasOne(d => d.DisasterWorldNameNavigation)
                    .WithMany(p => p.EventNews)
                    .HasForeignKey(d => d.DisasterWorldName)
                    .HasConstraintName("FK_Event_Disaster");
            });

            modelBuilder.Entity<GameObject>(entity =>
            {
                entity.ToTable("GameObject");

                entity.HasIndex(e => e.StateObject, "IX_GameObject_StateObject");

                entity.HasIndex(e => e.TypeObject, "IX_GameObject_TypeObject");

                entity.Property(e => e.Ipv6)
                    .HasMaxLength(50)
                    .HasColumnName("IPv6");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.StateObject).HasMaxLength(50);

                entity.Property(e => e.TypeObject).HasMaxLength(50);

                entity.HasOne(d => d.StateObjectNavigation)
                    .WithMany(p => p.GameObjects)
                    .HasForeignKey(d => d.StateObject)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameObject_StateGameObject");

                entity.HasOne(d => d.TypeObjectNavigation)
                    .WithMany(p => p.GameObjects)
                    .HasForeignKey(d => d.TypeObject)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameObject_TypeGameObject1");
            });

            modelBuilder.Entity<InformationDrone>(entity =>
            {
                entity.ToTable("InformationDrone");

                entity.HasIndex(e => e.DroneShortName, "IX_InformationDrone_DroneShortName");

                entity.HasIndex(e => e.LoginUser, "IX_InformationDrone_LoginUser");

                entity.Property(e => e.DroneNameUser).HasMaxLength(50);

                entity.Property(e => e.DroneShortName)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.HeatPoint).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ipv6)
                    .HasMaxLength(50)
                    .HasColumnName("IPv6");

                entity.Property(e => e.LoginUser).HasMaxLength(50);

                entity.HasOne(d => d.DroneShortNameNavigation)
                    .WithMany(p => p.InformationDrones)
                    .HasForeignKey(d => d.DroneShortName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InformationDrone_Drone1");

                entity.HasOne(d => d.LoginUserNavigation)
                    .WithMany(p => p.InformationDrones)
                    .HasForeignKey(d => d.LoginUser)
                    .HasConstraintName("FK_InformationDrone_Account");
            });

            modelBuilder.Entity<NetScan>(entity =>
            {
                entity.ToTable("NetScan");

                entity.HasIndex(e => e.EventNewCodeNumber, "IX_NetScan_EventNewCodeNumber");

                entity.HasIndex(e => e.GameObjectId, "IX_NetScan_GameObjectId");

                entity.HasIndex(e => e.PlanetName, "IX_NetScan_PlanetName");

                entity.Property(e => e.EventNewCodeNumber).HasMaxLength(50);

                entity.Property(e => e.PlanetName).HasMaxLength(50);

                entity.HasOne(d => d.EventNewCodeNumberNavigation)
                    .WithMany(p => p.NetScans)
                    .HasForeignKey(d => d.EventNewCodeNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NetScan_Event");

                entity.HasOne(d => d.GameObject)
                    .WithMany(p => p.NetScans)
                    .HasForeignKey(d => d.GameObjectId)
                    .HasConstraintName("FK_NetScan_GameObject");

                entity.HasOne(d => d.PlanetNameNavigation)
                    .WithMany(p => p.NetScans)
                    .HasForeignKey(d => d.PlanetName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NetScan_Planet");
            });

            modelBuilder.Entity<ObjectAvailable>(entity =>
            {
                entity.HasKey(e => new { e.ServerId, e.LoginUser });

                entity.ToTable("ObjectAvailable");

                entity.HasIndex(e => e.LoginUser, "IX_ObjectAvailable_LoginUser");

                entity.HasIndex(e => e.ServerId, "IX_ObjectAvailable_ServerId");

                entity.Property(e => e.LoginUser).HasMaxLength(50);

                entity.HasOne(d => d.LoginUserNavigation)
                    .WithMany(p => p.ObjectAvailables)
                    .HasForeignKey(d => d.LoginUser)
                    .HasConstraintName("FK_ObjectAvailable_Account");

                entity.HasOne(d => d.Server)
                    .WithMany(p => p.ObjectAvailables)
                    .HasForeignKey(d => d.ServerId)
                    .HasConstraintName("FK_ObjectAvailable_GameObject");
            });

            modelBuilder.Entity<Planet>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Planet");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.Square).HasMaxLength(300);
            });

            modelBuilder.Entity<RateLimit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RateLimit");

                entity.Property(e => e.ActionUserName).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.HasOne(d => d.ActionUserNameNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ActionUserName)
                    .HasConstraintName("FK_RateLimit_ActionUser");

                entity.HasOne(d => d.LoginNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Login)
                    .HasConstraintName("FK_RateLimit_Account");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Role");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Symbol)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RoleInTeam>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("RoleInTeam");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<StateGameObject>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK_StateServer");

                entity.ToTable("StateGameObject");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SymbolState)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Statistic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Statistic");

                entity.HasIndex(e => e.LoginUser, "IX_Statistic_LoginUser");

                entity.Property(e => e.Cec).HasColumnName("CEC");

                entity.Property(e => e.Cem).HasColumnName("CEM");

                entity.Property(e => e.Idle).HasColumnName("IDLE");

                entity.Property(e => e.LoginUser).HasMaxLength(50);

                entity.Property(e => e.Sac).HasColumnName("SAC");

                entity.Property(e => e.Slm).HasColumnName("SLM");

                entity.HasOne(d => d.LoginUserNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.LoginUser)
                    .HasConstraintName("FK_Statistic_Account");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Team");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(300);
            });

            modelBuilder.Entity<TypeGameObject>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("TypeGameObject");

                entity.HasIndex(e => e.UnicEfficensyId, "IX_TypeGameObject_UnicEfficensyId");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.UnicEfficensyId).HasMaxLength(50);

                entity.HasOne(d => d.UnicEfficensy)
                    .WithMany(p => p.TypeGameObjects)
                    .HasForeignKey(d => d.UnicEfficensyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeGameObject_UnicEfficensy");
            });

            modelBuilder.Entity<UnicEfficiency>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK_UnicEfficensy");

                entity.ToTable("UnicEfficiency");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}