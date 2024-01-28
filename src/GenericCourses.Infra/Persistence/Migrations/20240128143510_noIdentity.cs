using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GenericCourses.Infra.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class noIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "certificates",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    courseId = table.Column<Guid>(type: "uuid", nullable: true),
                    emited_at = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_certificates", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    thumb = table.Column<string>(type: "text", nullable: true),
                    isFree = table.Column<bool>(type: "boolean", nullable: false),
                    duration = table.Column<string>(type: "text", nullable: true),
                    instrutor = table.Column<string>(type: "text", nullable: true),
                    active = table.Column<bool>(type: "boolean", nullable: false),
                    createdAt = table.Column<DateTime>(type: "Date", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    order = table.Column<int>(type: "integer", nullable: false),
                    complete = table.Column<bool>(type: "boolean", nullable: false),
                    courseId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    text = table.Column<string>(type: "text", nullable: true),
                    userId = table.Column<Guid>(type: "uuid", nullable: true),
                    thumb = table.Column<string>(type: "text", nullable: true),
                    acesses = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "subscriptionplans",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    createdAt = table.Column<DateTime>(type: "Date", nullable: false),
                    months = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscriptionplans", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "videos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    videoUrl = table.Column<string>(type: "text", nullable: true),
                    duration = table.Column<string>(type: "text", nullable: true),
                    order = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "Date", nullable: false),
                    moduleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videos", x => x.id);
                    table.ForeignKey(
                        name: "FK_videos_modules_moduleId",
                        column: x => x.moduleId,
                        principalTable: "modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    Courseid = table.Column<Guid>(type: "uuid", nullable: true),
                    Postid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.id);
                    table.ForeignKey(
                        name: "FK_categories_courses_Courseid",
                        column: x => x.Courseid,
                        principalTable: "courses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_categories_posts_Postid",
                        column: x => x.Postid,
                        principalTable: "posts",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    cpf = table.Column<int>(type: "integer", nullable: false),
                    phoneNumber = table.Column<int>(type: "integer", nullable: true),
                    role = table.Column<int>(type: "integer", nullable: false),
                    socialNetwork = table.Column<string>(type: "text", nullable: true),
                    github = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    createdAt = table.Column<DateTime>(type: "Date", nullable: false),
                    subscriptionplanId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_users_subscriptionplans_subscriptionplanId",
                        column: x => x.subscriptionplanId,
                        principalTable: "subscriptionplans",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "VideoProgresses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    videoId = table.Column<Guid>(type: "uuid", nullable: false),
                    moduleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoProgresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_VideoProgresses_modules_moduleId",
                        column: x => x.moduleId,
                        principalTable: "modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoProgresses_videos_videoId",
                        column: x => x.videoId,
                        principalTable: "videos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseProgresses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    userId = table.Column<Guid>(type: "uuid", nullable: false),
                    courseId = table.Column<Guid>(type: "uuid", nullable: false),
                    done = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseProgresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_CourseProgresses_courses_courseId",
                        column: x => x.courseId,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseProgresses_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "moduleProgresses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    moduleId = table.Column<Guid>(type: "uuid", nullable: false),
                    courseProgressId = table.Column<Guid>(type: "uuid", nullable: false),
                    done = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moduleProgresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_moduleProgresses_CourseProgresses_courseProgressId",
                        column: x => x.courseProgressId,
                        principalTable: "CourseProgresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_moduleProgresses_modules_moduleId",
                        column: x => x.moduleId,
                        principalTable: "modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "id", "acesses", "created_at", "text", "thumb", "title", "userId" },
                values: new object[,]
                {
                    { new Guid("01bfe07e-e17a-4903-879b-cb2d898f7d17"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6272), "deserunt", null, "Atum", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("0378ec22-9db5-465b-a938-898079c4054d"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6501), "qui", null, "Pizza", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("04b641bc-9263-486a-b017-6e2423843566"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(8911), "Quis exercitationem fugiat modi ipsum rerum. Voluptates atque veniam voluptas. Doloremque ullam voluptas nisi est. Maiores ullam aliquam id rerum alias quae.", null, "Carro", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("09186220-6ae8-4bd0-bc33-93a544f45a6a"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(2220), "Facere quo voluptatem et ut eum.", null, "Peixe", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("0ae633ea-9401-4070-9233-3dc64a9faef0"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4985), "Aut rem est voluptates et ratione accusantium quisquam quibusdam.\nId fugiat dolores.\nEaque fuga ratione illum non.\nQuibusdam qui quas eius nihil aliquam consectetur in.\nSit dolorum et vel sed dolorum magnam quis et sed.\nVoluptatem rerum accusamus debitis omnis perferendis distinctio id.", null, "Luvas", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("0f32c95a-32d5-4e6c-91f5-36c44fb94271"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4237), "Incidunt dolorem rerum perferendis cum ducimus.", null, "Pizza", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("107f2303-d20f-42cd-8423-68a406917868"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(7895), "Quia modi velit et deleniti cumque.", null, "Camiseta", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("12ee3597-bd41-47dd-b5fe-38c9aae92565"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(5819), "Libero aut omnis doloremque fugiat facere quaerat vitae sunt qui.", null, "Pizza", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("15331962-ff03-4310-941c-8ed517606f11"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(2422), "Tempore est aliquam sed.\nMolestias officia consequuntur ipsam hic aperiam veritatis quisquam quos.\nRerum vel enim.\nQui aut illum sunt perferendis iusto exercitationem cum.\nEst sed sint laboriosam.\nEt laboriosam sit doloremque consequatur quo veniam sed animi.", null, "Mesa", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("179d194f-0526-49f0-8417-ac4a547672d8"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(9204), "ut", null, "Chapéu", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("19c89f14-02a7-4183-ac74-de9371448f5a"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6523), "Quos deserunt consequatur laudantium voluptatem debitis sit rerum qui.", null, "Teclado", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("1a3f5343-683e-46eb-af3c-e31ecabdeaeb"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(900), "Rerum ipsam qui veritatis corporis impedit sit.\nVeritatis fugiat sequi.", null, "Sapatos", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("1cf90d70-8b9c-47d6-8a84-d0c0c5980c75"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4952), "Assumenda consectetur aliquid sequi.", null, "Salada", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("1edc3e87-7e9b-463f-b6da-802e4ba18ed1"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4364), "Ut veniam placeat expedita impedit expedita minima dolores enim itaque.", null, "Computador", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("1ff8edfa-15c6-4f0f-b527-87cf261e1ef4"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(1828), "Natus voluptates voluptatum repellat a et nihil omnis provident. Labore voluptatum ut. Doloremque sint repellendus tenetur commodi illum voluptatem quae quisquam autem. Id deserunt quia eveniet praesentium quia. Debitis ut et qui.", null, "Salada", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("20bff2d9-1f94-4c10-af5c-42ff3530b327"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(3132), "est", null, "Carro", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("2308a1f8-5516-492a-ae89-8216083f9ab1"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(5655), "Molestiae aut dignissimos ut architecto enim eum odit beatae hic. Sed commodi mollitia id pariatur sunt doloremque. Libero velit ducimus dolorem. Doloremque est est veritatis vel qui quaerat. Excepturi deserunt totam asperiores dolorem id praesentium.", null, "Cadeira", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("29830a2a-a961-4a0a-be03-9736d9171909"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4653), "Nihil perspiciatis est enim deleniti et facilis. Explicabo placeat excepturi. Consequuntur animi magnam ut est voluptas pariatur quia.", null, "Pizza", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("2cdee930-196a-4817-b32d-c18c15fc3f41"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(2653), "Quisquam dicta dolore occaecati explicabo tempora ullam. Qui repellendus et fugiat sunt sit velit iusto dolore. Aperiam quisquam neque dolore voluptatum voluptas excepturi repellat et.", null, "Bacon", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("2f60ed98-2cc6-4d77-a251-d3ee625232d2"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(3728), "Non aut ut nobis quia facere ipsam.\nSint voluptas voluptatum non fugiat vero molestias ex.", null, "Cadeira", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("301fbfc7-4181-4df9-84f2-adae32b7bc43"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(1751), "Aliquam quos ut autem provident impedit alias ratione illum id.", null, "Carro", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("31a18912-31e7-4887-9dbd-f019248f8ad9"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(1312), "ex", null, "Mesa", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("32406b4b-8f06-4aa6-9229-385a9556d13b"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(2260), "et", null, "Bacon", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("32cfcdd7-3f6f-4dc1-a118-a4ae000279af"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(5175), "Architecto est odio modi. Ut soluta et et repellendus beatae ut. Eos reprehenderit numquam quis eius sed mollitia cum magnam. Nesciunt sit est veniam minima enim ex voluptates.", null, "Mesa", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("36891574-be22-45c4-aa8d-a03056dfed8f"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(7727), "Minima impedit et.\nEt est est voluptatibus molestiae expedita perferendis deleniti sint quibusdam.\nBeatae voluptate sit qui saepe eligendi quia.\nSit est ut.", null, "Carro", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("3c726b66-ef36-4bbc-b2fc-fbb8d3e2200e"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(9711), "Mollitia numquam inventore voluptas qui harum est.", null, "Luvas", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("3fa5804b-02e6-4198-b84d-50257a0d3a2c"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(3613), "Occaecati harum molestias ex quibusdam. Expedita quia omnis dolorum voluptatem explicabo velit id earum voluptatibus. Provident nam hic modi velit. Magni similique ducimus qui ipsam. Corrupti eos eum.", null, "Peixe", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("410eabd8-ef18-4da5-b319-d93090769b9c"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6895), "iure", null, "Sabonete", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("41e5b521-7083-4378-98c7-2f7c73d7ff5a"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(1256), "Et dolor asperiores vero qui delectus ex.", null, "Salgadinhos", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("426d835d-2044-4a13-979d-42fef02a6478"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(3970), "Voluptatum provident et dolorem accusamus.\nOfficiis harum quibusdam officiis sunt officia animi.\nEt doloremque dolorem.\nDucimus alias ipsa odit aliquam omnis nobis illum.\nIure facilis libero ipsum possimus accusantium consequatur laudantium sed.", null, "Frango", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("4577e145-1057-4d8a-8380-52c6a74167ad"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(2197), "aut", null, "Bicicleta", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("495cfd3e-de08-41aa-bb59-daddff4641ca"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(1069), "Quod aliquid ipsa deleniti. Qui aut commodi. A voluptate laboriosam qui ut. Non natus sint eos ratione omnis eligendi voluptas. Libero quasi velit iure.", null, "Salsicha", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("5049baa5-c69c-4cf5-adde-289536921447"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4410), "Ratione architecto voluptas soluta qui. Repellendus qui autem excepturi delectus laboriosam. Deleniti ex at illum maxime ut hic et aperiam quam. Libero facilis architecto id voluptatem voluptatem quae. Occaecati non eos et vel non asperiores est. Nemo est sunt.", null, "Bicicleta", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("51b04538-5a8f-4d63-ad8b-0ab68641602e"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6465), "Sed nobis facilis maxime deserunt.", null, "Cadeira", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("54e61827-7575-451c-ba1e-f6cdcbce29aa"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6443), "dolor", null, "Salgadinhos", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("59a09fb0-8130-423b-93d2-b98cf19b9f08"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(2610), "Repudiandae voluptates omnis consequatur praesentium inventore.", null, "Atum", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("5beba8f3-6602-4479-877f-0584f93f4659"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(5621), "Qui veniam magni voluptates.", null, "Mesa", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("5cc9aa91-6d62-44f7-baaa-407c8dde70da"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6105), "Nihil enim eaque exercitationem molestiae corporis.\nDebitis exercitationem voluptatum repudiandae nam quidem.\nVoluptatem nihil rem neque.\nEst enim est.\nIste maiores quaerat ut unde.\nVoluptatum repudiandae officia minus sapiente eos impedit qui.", null, "Sapatos", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("632d215d-3613-4f7a-acf8-0ec876fd1a86"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6769), "quos", null, "Mouse", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("65f00069-c803-4b87-abf7-665da7cccaaa"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(8888), "molestiae", null, "Bacon", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("69a9a69e-aca7-4a4b-b3fb-02f092746a20"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6792), "Modi nisi reiciendis ut.", null, "Luvas", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("71e4061b-80ff-4f76-8796-2330f6247742"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(8402), "Necessitatibus dolorem sit. Unde aut nesciunt sint et. Doloremque repellendus quod nihil. At ex voluptas sit magnam voluptatem qui. Voluptatem sed inventore quis debitis. Aliquam aut autem eligendi in.", null, "Salsicha", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("78598da3-28f6-41a6-98e7-5e1b2aa15226"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4214), "quae", null, "Bacon", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("78ff61c2-ff9b-4eda-8b5a-69af4f349017"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(8730), "Enim unde repellat quis. Et ut fugiat provident officia reprehenderit aut temporibus. Ut eos incidunt excepturi maiores qui. Facilis autem eos cumque numquam eaque. Et hic sed.", null, "Toalhas", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("7c27dcb6-7071-4b37-bc66-adfc00660308"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6861), "Sapiente porro porro dolores.", null, "Bola", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("7eebc791-affb-4aac-a061-cd5c471a02e5"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(7249), "Et voluptatem molestiae temporibus esse quaerat ipsam.", null, "Pizza", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("80638029-32cc-4e71-8d24-3b91de6123b7"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(5974), "Quia molestias ut ut unde.\nEst ducimus cum dicta dolores.\nEarum deleniti nam repudiandae cupiditate illo praesentium nesciunt.\nEnim sit nam rerum.\nSaepe quidem odio tempora praesentium culpa quis quae iste laboriosam.\nArchitecto est temporibus.", null, "Calças", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("814952fb-a755-4077-b2ac-1f53ae891b8d"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(9226), "itaque", null, "Bicicleta", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("850adbb8-ba01-454a-9330-74cd36fa0569"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6296), "Perspiciatis minima est iure non quo saepe praesentium. Voluptatem sint nisi. Molestiae harum perferendis alias nisi rerum sit cupiditate velit laboriosam. Neque inventore alias vero deleniti accusantium eveniet ut officia aut. Non ut quis.", null, "Salada", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("8754fb98-8b84-4e80-b662-c38a00a0a7e8"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(5888), "Id possimus voluptas sed et quasi non ut consequatur dignissimos.", null, "Teclado", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("8af5edf8-46b5-4bd2-95fd-1b751388315b"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(5316), "Quis deserunt qui facilis molestias fuga autem.\nUt quod tenetur saepe.\nCupiditate incidunt rerum rerum totam officia enim quia.\nOmnis molestias eaque rerum aut tempore laboriosam earum.\nRepellendus consequatur deserunt dignissimos.\nOmnis recusandae voluptatem.", null, "Computador", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("8afa6884-2cb1-4768-9c7a-d3a686bd0e81"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(8173), "Alias ex optio occaecati dolor esse corrupti accusantium velit.\nNon quia qui quae quia amet facere ipsum possimus.\nEarum magni sint numquam voluptatem ut cumque sed.", null, "Salsicha", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("8b372ff9-5b79-4510-91b0-29f30f0bfa3c"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(9118), "Ea earum maxime quidem deleniti voluptatem voluptatum quos ut.", null, "Salgadinhos", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("8bf50c30-66b0-459b-b82d-3985528dd095"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(2283), "Iste aliquid voluptatibus magnam rerum pariatur. Repellendus veritatis tempora rerum. Quo reiciendis repudiandae. Ut voluptas exercitationem.", null, "Sapatos", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("8e41262d-a705-48c5-9482-876e9345793b"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4907), "Et nostrum est quia maiores et ut quis dolorem.", null, "Queijo", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("91325f32-fa2c-4f1d-8ccf-f5eb249103af"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4735), "Corporis ratione nostrum recusandae dolor laboriosam voluptate qui velit ex. Eveniet et esse omnis excepturi omnis ipsa. Praesentium dolorem eum velit libero id modi in doloribus eos. Et at temporibus provident magnam distinctio.", null, "Atum", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("951dc57d-f739-414b-aee1-79c3b31d5f34"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(3427), "Error vero dolorem id quos omnis iusto perspiciatis voluptas doloribus.\nEst vitae a eum ipsum est.\nFacere autem soluta.\nVoluptas molestias dolor et accusantium quod animi nihil fugit.\nSed et minima rem accusantium voluptatem voluptas optio.\nSuscipit sint omnis neque maxime omnis.", null, "Toalhas", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("97608d30-4866-4435-90d4-4c1912976935"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(3014), "Est alias autem.\nAtque dignissimos cumque illo doloremque sit.", null, "Teclado", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("9c4af3e4-8995-4192-ac90-90aa383d5e54"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4174), "Eius rerum sed est nam.", null, "Queijo", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("9fee666a-f07f-4d0d-9416-9262816d2018"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(9397), "Dolorum voluptatem praesentium dignissimos voluptatem ipsa est debitis et. Quae voluptas nostrum magnam alias id hic autem ea. Aut temporibus dolore excepturi autem et accusantium voluptatem et. Et explicabo ut blanditiis non. Voluptatibus qui labore non nam ea eligendi ut.", null, "Mouse", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("a29a34a9-b905-4a38-965e-0562630f8aae"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6965), "Sed porro saepe ratione et accusantium dicta id. Quod magni et dolore molestias. Doloremque quia quidem modi non. Ipsa odit vitae ut iusto tempora incidunt sit quis. Perferendis itaque et eum sit.", null, "Pizza", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("a5708d7d-466d-48dd-8251-aff6dedb4284"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(7524), "Unde omnis qui fugiat et aut dolore. Voluptatem numquam eum dolorum quia harum placeat ea ipsa consectetur. Accusantium distinctio molestiae qui libero. Saepe sed quis ut nostrum ut alias officia nulla. Quis nihil voluptas accusantium odit corrupti similique explicabo minus. Vero rerum ut vel repellendus in voluptatem maiores sed temporibus.", null, "Toalhas", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("ac9c6fb4-e01c-43d8-8aae-04f429a9db1c"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(1488), "dignissimos", null, "Bicicleta", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("acd5c05e-9042-4bfc-8903-344ad652a94b"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(7933), "Nemo maiores quidem earum. Aliquid velit error ut amet repellendus autem aut ut dolorem. Ratione ipsum a eaque quis. Praesentium laudantium perspiciatis consequatur. Autem eaque totam reiciendis mollitia reprehenderit.", null, "Peixe", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("ae836eba-0247-4b3b-84cb-172e00e1a5d1"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(7116), "Sit sapiente adipisci vero possimus doloremque ea.\nSunt laborum optio dolore.\nSunt rerum rerum et enim eum nemo eligendi sequi omnis.\nVeritatis nam vel.", null, "Luvas", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("b287564e-559a-4a1b-9c04-31a47af7fa92"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(2758), "Quibusdam explicabo est magni commodi autem.\nNam ipsa ut voluptatem animi et ea quam et.\nFugit earum et.", null, "Luvas", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("b5e9dc2f-dac0-4ad5-a939-37e9d4652ddb"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(8663), "Sit vel vero omnis ullam at dolore quasi.\nQuas rerum at dicta nihil eum facilis.", null, "Bacon", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("babd8e60-dc9f-4371-a2c8-903537868bfb"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 662, DateTimeKind.Local).AddTicks(6663), "Quo incidunt nobis adipisci ut nemo. Eos et eos aut vitae consequuntur delectus et unde. Commodi autem sit voluptatum maiores quas eum ea doloribus. Nulla voluptas voluptatem nam rerum modi. Et id est voluptatem sint.", null, "Sabonete", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("bd39160f-c443-4986-9b81-4fc0b405b34c"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(8268), "Recusandae accusamus optio perferendis assumenda et.", null, "Sapatos", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("bff1de6d-ef65-43e8-b4dd-284842fe4d00"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(5502), "Impedit iste sed in tempora voluptate iste. Sunt amet non repudiandae ea sed. Nulla eum debitis. Dolores quia delectus. Provident ut iste aut expedita quaerat. Quia laborum veritatis beatae.", null, "Peixe", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("c0ac0e98-3f86-455c-8638-d152beaed01d"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(1806), "quia", null, "Bicicleta", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("c3b6dc3f-4e2f-465e-95f2-7926a85be227"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(3821), "Alias ex itaque et in veniam quidem et et.\nVeniam dicta enim recusandae est quos et.\nIure dolorem perspiciatis.\nSit deleniti eum quia.\nSed quia at voluptatum perferendis quo rerum vitae placeat.\nEt tempora sapiente ipsa voluptatem velit doloribus eum nulla.", null, "Sabonete", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("c3d4ac50-3ee8-4ca6-984e-c4465e73963b"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(3404), "suscipit", null, "Salada", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("c42fe0b9-cd07-4870-a158-ded62b9f388b"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4326), "Atque beatae provident optio et.", null, "Calças", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("c5e78728-4629-4d4f-be64-bbecb9d0dd08"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4631), "est", null, "Carro", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("c5f7edff-c108-432a-924e-9138986921fc"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(9248), "Ratione est aspernatur.\nLaborum qui repudiandae similique commodi.\nTemporibus hic numquam maiores est qui laborum nulla voluptas incidunt.\nQuod nam enim consequuntur a reprehenderit.", null, "Computador", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("cb1025f9-ef7a-45ac-bf18-548cd67324eb"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6827), "Repellat in ex velit.", null, "Calças", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("cb10bf83-e820-4d1a-b9ed-3320554f814e"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(1515), "Minus nostrum provident dolorem soluta autem iste possimus molestiae quis. Et dolorum omnis qui omnis. Totam aut illum eum ea quidem nemo vel sint. Illum repudiandae exercitationem quia repellendus alias necessitatibus et neque quas. Officia ut rerum tenetur aut error est. Officia adipisci sint ut ea quia quis excepturi porro reprehenderit.", null, "Frango", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("d0777547-3f24-49a6-88c7-d61f85d6b0c8"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(2065), "quaerat", null, "Sabonete", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("d3449893-bf48-44d1-8125-198a46438738"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(7433), "Qui enim nisi quaerat est. Dicta excepturi et saepe et. Ipsum veritatis accusamus id deleniti. Consequatur sunt facere consequatur eius non.", null, "Cadeira", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("d643fa4b-ee51-4b97-b76c-e60a23d4ac0f"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(2884), "Qui soluta aut est sint ex perferendis nemo est. Accusantium consequuntur rerum laboriosam. Sint quia aliquid error enim eligendi. Vel non maiores voluptatem commodi. Voluptatem dolor facilis corrupti recusandae inventore qui qui vitae.", null, "Salada", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("d6b18881-22b0-4598-aa76-a74ba256f3d4"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(6569), "Deserunt molestias aut quaerat.\nIste ipsa voluptates et velit sequi assumenda non.\nCumque soluta qui iure voluptatibus dolore.\nExplicabo ipsa quod quasi consequatur.", null, "Salada", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("dd466e6a-973f-4746-9c3f-ef62f9bec847"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(3211), "Nihil possimus maxime soluta assumenda tenetur quas sit id sequi. Autem dolores quaerat quibusdam facilis voluptatem est quae. Et veritatis laboriosam veritatis quia nesciunt omnis. Fugiat ut ad ut optio eos est iusto modi. Vel cum consectetur quas. Pariatur expedita sint magnam.", null, "Sapatos", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("deb79d32-a525-4cff-9785-56dd941ed355"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(9786), "Excepturi perferendis quas quae omnis ipsam suscipit fugit est.\nQuod ab doloremque et sint voluptatem sint culpa.\nEligendi unde quae provident ex cupiditate quae id aliquid.", null, "Atum", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("e084f2f5-bd23-4325-888f-aa2c2925d7c1"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(3155), "Quaerat minima quia quis qui inventore delectus animi earum sapiente.", null, "Mouse", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("e240da33-7418-41d7-847d-c28e39bd6491"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(7821), "Nobis vel ut exercitationem nostrum.", null, "Mesa", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("e42fc11b-6242-40cc-bc56-3ae0fbd2c671"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(8641), "voluptatem", null, "Queijo", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("e5e4d2ba-8350-4dac-b703-c89d0507a041"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(9163), "Ipsum non voluptates beatae saepe totam voluptatem.", null, "Mouse", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("e5fb2a23-d171-47a9-a95c-6728734cff40"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(5865), "illo", null, "Cadeira", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("e84ac444-3069-4e65-b41f-8e488d2f8df2"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(7290), "Rem voluptas nobis officiis tempora cum.\nDolor tempora voluptates occaecati sint sed qui qui voluptatibus et.\nOmnis dolores repellat animi.\nAliquid atque ut nobis est voluptatem aut aut numquam nihil.", null, "Peixe", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("eaf6123f-5e1a-499c-bcf4-1db877f42348"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(8327), "Aut vitae in quidem quos voluptatibus accusantium adipisci.\nOptio explicabo ipsa ad quia sunt.\nEt qui nihil.", null, "Carro", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("eafc3a75-af4d-4e28-9db5-9e55baac2465"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(9002), "Sint et fugiat velit modi. Libero voluptas nobis omnis a aliquid omnis. Sint qui et quia sint est voluptatem.", null, "Carro", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("ed267020-6622-4998-a032-2d83eb4ff06e"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(1336), "Voluptates qui est repudiandae.\nDoloribus sint voluptas ut eum.\nItaque corrupti impedit quae voluptas.\nIusto dolores quisquam architecto eum.", null, "Computador", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("f007b8a1-f139-4402-a1f1-5684e74d5d50"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(8045), "Quia perspiciatis provident soluta.\nVoluptatem ullam voluptas vel unde.\nProvident maiores similique.\nIpsum dolorem aliquam alias illum fugiat rerum suscipit nobis expedita.", null, "Toalhas", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("f62c9296-9cff-4a5c-b943-cc5c8a525a13"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(4588), "Deserunt quia ea sit quis qui nobis.", null, "Salada", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("f64500b4-3a62-436d-ae42-5608ec8b69af"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(7084), "Et omnis dolores.", null, "Chapéu", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("f95299cb-24d7-46f5-88f5-91cd80fdfdc0"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(9570), "Eaque nam rerum non porro. Deleniti ad provident excepturi maxime. Quaerat sit architecto occaecati ea. Et labore voluptatum cumque iste aut aut. Quidem aut nisi a nemo fugiat accusamus. Quis accusamus explicabo perferendis ut beatae adipisci ipsam voluptas et.", null, "Calças", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("fc755809-a1c0-4300-860e-b0ae8c45bae7"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(1042), "cupiditate", null, "Peixe", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("fd83252f-ad01-426e-906a-b04a1b11d8f7"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(8615), "officia", null, "Peixe", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") },
                    { new Guid("fe264cf8-3377-445c-aada-54ce79a98e43"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 663, DateTimeKind.Local).AddTicks(2094), "Incidunt corrupti sit ullam illo necessitatibus aut. Delectus voluptatem blanditiis autem incidunt sed ut saepe similique. Maxime possimus dolores voluptas et et fuga maiores.", null, "Carro", new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb") }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "cpf", "createdAt", "email", "github", "is_active", "name", "phoneNumber", "role", "socialNetwork", "subscriptionplanId" },
                values: new object[,]
                {
                    { new Guid("0a279b42-af37-41e6-80b9-d43a1d5942cb"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 662, DateTimeKind.Local).AddTicks(6011), "admin@admin.com", null, true, "admin", null, 2, null, null },
                    { new Guid("b1d2fb65-713b-426c-8e2a-9ece4b36b4fb"), 0, new DateTime(2024, 1, 28, 11, 35, 9, 662, DateTimeKind.Local).AddTicks(6135), "user@email.com", null, true, "user", null, 2, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_categories_Courseid",
                table: "categories",
                column: "Courseid");

            migrationBuilder.CreateIndex(
                name: "IX_categories_Postid",
                table: "categories",
                column: "Postid");

            migrationBuilder.CreateIndex(
                name: "IX_CourseProgresses_courseId",
                table: "CourseProgresses",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseProgresses_userId",
                table: "CourseProgresses",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_moduleProgresses_courseProgressId",
                table: "moduleProgresses",
                column: "courseProgressId");

            migrationBuilder.CreateIndex(
                name: "IX_moduleProgresses_moduleId",
                table: "moduleProgresses",
                column: "moduleId");

            migrationBuilder.CreateIndex(
                name: "IX_users_subscriptionplanId",
                table: "users",
                column: "subscriptionplanId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoProgresses_moduleId",
                table: "VideoProgresses",
                column: "moduleId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoProgresses_videoId",
                table: "VideoProgresses",
                column: "videoId");

            migrationBuilder.CreateIndex(
                name: "IX_videos_moduleId",
                table: "videos",
                column: "moduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "certificates");

            migrationBuilder.DropTable(
                name: "moduleProgresses");

            migrationBuilder.DropTable(
                name: "VideoProgresses");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "CourseProgresses");

            migrationBuilder.DropTable(
                name: "videos");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "modules");

            migrationBuilder.DropTable(
                name: "subscriptionplans");
        }
    }
}
