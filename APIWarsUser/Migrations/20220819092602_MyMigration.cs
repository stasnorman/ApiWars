using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIWarsUser.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DisasterWorld",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disaster", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "EfficiencyAction",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueAction = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DroneFeature_1", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Planet",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Square = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Latitude = table.Column<int>(type: "int", nullable: false),
                    Longitude = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planet", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "RoleInTeam",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleInTeam", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "StateGameObject",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SymbolState = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateServer", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "UnicEfficensy",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValueAction = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnicEfficensy", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "EventNew",
                columns: table => new
                {
                    ConeNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisasterWorldName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.ConeNumber);
                    table.ForeignKey(
                        name: "FK_Event_Disaster",
                        column: x => x.DisasterWorldName,
                        principalTable: "DisasterWorld",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "TypeDrone",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EfficiencyDrone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoveAction = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HeatPoint = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDrone", x => x.Name);
                    table.ForeignKey(
                        name: "FK_TypeDrone_DroneFeature1",
                        column: x => x.EfficiencyDrone,
                        principalTable: "EfficiencyAction",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApiKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account_1", x => x.Login);
                    table.ForeignKey(
                        name: "FK_Account_Role",
                        column: x => x.RoleName,
                        principalTable: "Role",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "TypeGameObject",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    UnicEfficensyId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeGameObject", x => x.Name);
                    table.ForeignKey(
                        name: "FK_TypeGameObject_UnicEfficensy",
                        column: x => x.UnicEfficensyId,
                        principalTable: "UnicEfficensy",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "Drone",
                columns: table => new
                {
                    ShortName = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypeDrone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drone", x => x.ShortName);
                    table.ForeignKey(
                        name: "FK_Drone_TypeDrone1",
                        column: x => x.TypeDrone,
                        principalTable: "TypeDrone",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "DeveloperInTeam",
                columns: table => new
                {
                    LoginUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TokenTeam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeSpanTokenEnd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeveloperInTeam", x => new { x.LoginUser, x.TeamName });
                    table.ForeignKey(
                        name: "FK_DeveloperInTeam_Account",
                        column: x => x.LoginUser,
                        principalTable: "Account",
                        principalColumn: "Login",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeveloperInTeam_RoleInTeam",
                        column: x => x.Role,
                        principalTable: "RoleInTeam",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_DeveloperInTeam_Team",
                        column: x => x.TeamName,
                        principalTable: "Team",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "Statistic",
                columns: table => new
                {
                    LoginUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SAC = table.Column<int>(type: "int", nullable: false),
                    SLM = table.Column<int>(type: "int", nullable: false),
                    CEM = table.Column<int>(type: "int", nullable: false),
                    CEC = table.Column<int>(type: "int", nullable: false),
                    IDLE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Statistic_Account",
                        column: x => x.LoginUser,
                        principalTable: "Account",
                        principalColumn: "Login",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameObject",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypeObject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IPv6 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StateObject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HeatPoint = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameObject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameObject_StateGameObject",
                        column: x => x.StateObject,
                        principalTable: "StateGameObject",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_GameObject_TypeGameObject1",
                        column: x => x.TypeObject,
                        principalTable: "TypeGameObject",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "InformationDrone",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<long>(type: "bigint", nullable: false),
                    Y = table.Column<long>(type: "bigint", nullable: false),
                    IPv6 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DroneShortName = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    LoginUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DroneNameUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationDrone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InformationDrone_Account",
                        column: x => x.LoginUser,
                        principalTable: "Account",
                        principalColumn: "Login",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InformationDrone_Drone",
                        column: x => x.DroneShortName,
                        principalTable: "Drone",
                        principalColumn: "ShortName");
                });

            migrationBuilder.CreateTable(
                name: "NetScan",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<long>(type: "bigint", nullable: false),
                    Y = table.Column<long>(type: "bigint", nullable: false),
                    GameObjectId = table.Column<long>(type: "bigint", nullable: false),
                    EventNewCodeNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PlanetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetScan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NetScan_Event",
                        column: x => x.EventNewCodeNumber,
                        principalTable: "EventNew",
                        principalColumn: "ConeNumber");
                    table.ForeignKey(
                        name: "FK_NetScan_GameObject",
                        column: x => x.GameObjectId,
                        principalTable: "GameObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NetScan_Planet",
                        column: x => x.PlanetName,
                        principalTable: "Planet",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "ObjectAvailable",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "bigint", nullable: false),
                    LoginUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ServerLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ObjectAvailable_Account",
                        column: x => x.LoginUser,
                        principalTable: "Account",
                        principalColumn: "Login",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectAvailable_GameObject",
                        column: x => x.ServerId,
                        principalTable: "GameObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_RoleName",
                table: "Account",
                column: "RoleName");

            migrationBuilder.CreateIndex(
                name: "IX_DeveloperInTeam_Role",
                table: "DeveloperInTeam",
                column: "Role");

            migrationBuilder.CreateIndex(
                name: "IX_DeveloperInTeam_TeamName",
                table: "DeveloperInTeam",
                column: "TeamName");

            migrationBuilder.CreateIndex(
                name: "IX_Drone_TypeDrone",
                table: "Drone",
                column: "TypeDrone");

            migrationBuilder.CreateIndex(
                name: "IX_EventNew_DisasterWorldName",
                table: "EventNew",
                column: "DisasterWorldName");

            migrationBuilder.CreateIndex(
                name: "IX_GameObject_StateObject",
                table: "GameObject",
                column: "StateObject");

            migrationBuilder.CreateIndex(
                name: "IX_GameObject_TypeObject",
                table: "GameObject",
                column: "TypeObject");

            migrationBuilder.CreateIndex(
                name: "IX_InformationDrone_DroneShortName",
                table: "InformationDrone",
                column: "DroneShortName");

            migrationBuilder.CreateIndex(
                name: "IX_InformationDrone_LoginUser",
                table: "InformationDrone",
                column: "LoginUser");

            migrationBuilder.CreateIndex(
                name: "IX_NetScan_EventNewCodeNumber",
                table: "NetScan",
                column: "EventNewCodeNumber");

            migrationBuilder.CreateIndex(
                name: "IX_NetScan_GameObjectId",
                table: "NetScan",
                column: "GameObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_NetScan_PlanetName",
                table: "NetScan",
                column: "PlanetName");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectAvailable_LoginUser",
                table: "ObjectAvailable",
                column: "LoginUser");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectAvailable_ServerId",
                table: "ObjectAvailable",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistic_LoginUser",
                table: "Statistic",
                column: "LoginUser");

            migrationBuilder.CreateIndex(
                name: "IX_TypeDrone_EfficiencyDrone",
                table: "TypeDrone",
                column: "EfficiencyDrone");

            migrationBuilder.CreateIndex(
                name: "IX_TypeGameObject_UnicEfficensyId",
                table: "TypeGameObject",
                column: "UnicEfficensyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeveloperInTeam");

            migrationBuilder.DropTable(
                name: "InformationDrone");

            migrationBuilder.DropTable(
                name: "NetScan");

            migrationBuilder.DropTable(
                name: "ObjectAvailable");

            migrationBuilder.DropTable(
                name: "Statistic");

            migrationBuilder.DropTable(
                name: "RoleInTeam");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Drone");

            migrationBuilder.DropTable(
                name: "EventNew");

            migrationBuilder.DropTable(
                name: "Planet");

            migrationBuilder.DropTable(
                name: "GameObject");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "TypeDrone");

            migrationBuilder.DropTable(
                name: "DisasterWorld");

            migrationBuilder.DropTable(
                name: "StateGameObject");

            migrationBuilder.DropTable(
                name: "TypeGameObject");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "EfficiencyAction");

            migrationBuilder.DropTable(
                name: "UnicEfficensy");
        }
    }
}
