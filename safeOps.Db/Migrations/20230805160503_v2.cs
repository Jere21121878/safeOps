using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace safeOps.Db.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmpleador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_Empleador_IdEmpleador",
                        column: x => x.IdEmpleador,
                        principalTable: "Empleador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Licenciado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCalzado = table.Column<int>(type: "int", nullable: false),
                    TInferior = table.Column<int>(type: "int", nullable: false),
                    TSuperior = table.Column<int>(type: "int", nullable: false),
                    IdEmpleador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenciado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Licenciado_Empleador_IdEmpleador",
                        column: x => x.IdEmpleador,
                        principalTable: "Empleador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emergencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumEmergencia = table.Column<int>(type: "int", nullable: false),
                    Instrucciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emergencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emergencia_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccidentesPropios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccidentesMaquinaria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccidentesQuimicos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccidentesGeneral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historial_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Legal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Legal_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Maquinaria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aplicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mantenimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maquinaria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maquinaria_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Planos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Planos_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quimicos",
                columns: table => new
                {
                    NumeroOnu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mantenimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAS = table.Column<int>(type: "int", nullable: false),
                    Uso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aplicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quimicos", x => x.NumeroOnu);
                    table.ForeignKey(
                        name: "FK_Quimicos_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calendario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<int>(type: "int", nullable: false),
                    Tarea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenciadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendario_Licenciado_LicenciadoId",
                        column: x => x.LicenciadoId,
                        principalTable: "Licenciado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tecnico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCalzado = table.Column<int>(type: "int", nullable: false),
                    TInferior = table.Column<int>(type: "int", nullable: false),
                    TSuperior = table.Column<int>(type: "int", nullable: false),
                    IdEmpleador = table.Column<int>(type: "int", nullable: false),
                    IdLicenciado = table.Column<int>(type: "int", nullable: false),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tecnico_Empleador_IdEmpleador",
                        column: x => x.IdEmpleador,
                        principalTable: "Empleador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tecnico_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tecnico_Licenciado_IdLicenciado",
                        column: x => x.IdLicenciado,
                        principalTable: "Licenciado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "A_T_S",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Responsable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peligros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Herramientas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Proteccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Personal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTecnico = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_T_S", x => x.Id);
                    table.ForeignKey(
                        name: "FK_A_T_S_Tecnico_IdTecnico",
                        column: x => x.IdTecnico,
                        principalTable: "Tecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Multimedia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTecnico = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multimedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Multimedia_Tecnico_IdTecnico",
                        column: x => x.IdTecnico,
                        principalTable: "Tecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_A_T_S_IdTecnico",
                table: "A_T_S",
                column: "IdTecnico");

            migrationBuilder.CreateIndex(
                name: "IX_Calendario_LicenciadoId",
                table: "Calendario",
                column: "LicenciadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emergencia_IdEmpresa",
                table: "Emergencia",
                column: "IdEmpresa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdEmpleador",
                table: "Empresa",
                column: "IdEmpleador");

            migrationBuilder.CreateIndex(
                name: "IX_Historial_IdEmpresa",
                table: "Historial",
                column: "IdEmpresa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Legal_IdEmpresa",
                table: "Legal",
                column: "IdEmpresa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Licenciado_IdEmpleador",
                table: "Licenciado",
                column: "IdEmpleador");

            migrationBuilder.CreateIndex(
                name: "IX_Maquinaria_IdEmpresa",
                table: "Maquinaria",
                column: "IdEmpresa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Multimedia_IdTecnico",
                table: "Multimedia",
                column: "IdTecnico");

            migrationBuilder.CreateIndex(
                name: "IX_Planos_IdEmpresa",
                table: "Planos",
                column: "IdEmpresa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quimicos_IdEmpresa",
                table: "Quimicos",
                column: "IdEmpresa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tecnico_IdEmpleador",
                table: "Tecnico",
                column: "IdEmpleador");

            migrationBuilder.CreateIndex(
                name: "IX_Tecnico_IdEmpresa",
                table: "Tecnico",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Tecnico_IdLicenciado",
                table: "Tecnico",
                column: "IdLicenciado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A_T_S");

            migrationBuilder.DropTable(
                name: "Calendario");

            migrationBuilder.DropTable(
                name: "Emergencia");

            migrationBuilder.DropTable(
                name: "Historial");

            migrationBuilder.DropTable(
                name: "Legal");

            migrationBuilder.DropTable(
                name: "Maquinaria");

            migrationBuilder.DropTable(
                name: "Multimedia");

            migrationBuilder.DropTable(
                name: "Planos");

            migrationBuilder.DropTable(
                name: "Quimicos");

            migrationBuilder.DropTable(
                name: "Tecnico");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Licenciado");

            migrationBuilder.DropTable(
                name: "Empleador");
        }
    }
}
