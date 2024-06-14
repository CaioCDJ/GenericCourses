using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GenericCourses.Infra.Persistence.Migrations;
/// <inheritdoc />
public partial class seeding : Migration {
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder) {
		migrationBuilder.DropForeignKey(
			name: "fk_course_ategories_categories_category_id",
			table: "course_ategories");

		migrationBuilder.DropForeignKey(
			name: "fk_course_ategories_courses_course_id",
			table: "course_ategories");

		migrationBuilder.DropForeignKey(
			name: "fk_modules_courses_courseid",
			table: "modules");

		migrationBuilder.DropPrimaryKey(
			name: "pk_course_ategories",
			table: "course_ategories");

		migrationBuilder.DeleteData(
			table: "admins",
			keyColumn: "id",
			keyValue: new Guid("9062972e-5c16-4ce6-a79a-5d6428e9d95f"));

		migrationBuilder.DeleteData(
			table: "instructors",
			keyColumn: "id",
			keyValue: new Guid("b8ccf4dc-da9a-4e03-a79a-3b304456e192"));

		migrationBuilder.DeleteData(
			table: "subscription_plans",
			keyColumn: "id",
			keyValue: new Guid("13c526f8-1340-41eb-a42e-b8c46eb432a6"));

		migrationBuilder.DeleteData(
			table: "subscription_plans",
			keyColumn: "id",
			keyValue: new Guid("330dc11c-fb7f-496d-9288-b41d40a897b3"));

		migrationBuilder.DeleteData(
			table: "subscription_plans",
			keyColumn: "id",
			keyValue: new Guid("7d0658a0-290e-4de0-8213-845c026f6e52"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("023f489c-82e4-42cb-bba4-d522a1f9a890"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("0529c9cf-7fff-4fc5-afcd-298cc0358ad8"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("085c8b7b-6bc3-49c5-8b6d-160e30008eae"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("0e2858df-3931-4c99-ad72-3b90c4184629"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("107375ad-0a39-4304-8781-d048f4770b17"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("111f0150-db58-44e9-9cec-938aba838877"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("11819b43-15b9-4b10-b98b-699fb95882d7"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("13d7ec9f-7e75-4fc5-afb5-2ae8dee29417"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("19ba5eda-5d83-4954-a980-f3a3eb749721"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("23760e3e-13ad-421d-9071-7abebb03130f"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("264a9577-e7d7-4324-9d21-cfab5dbf1489"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("2776b456-c766-48eb-95e2-d64dcf52eac3"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("2961b926-355a-48c5-a0a3-1d06c0a1a912"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("34e4e05d-805b-4700-b433-8d7d2d8b7f56"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("34ffc11c-3b18-41f9-9e6f-9788567b7d8e"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("39352718-d523-4ca9-b4b2-b75a7936be9a"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("39a7d6d5-7b69-495a-9367-2e27663a9733"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("3a798bb8-d883-4fb0-a84d-0064edb34ce5"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("448a581c-e346-44d5-aa15-9b8a333aee6c"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("44bd8a10-4c59-4eb0-bb0e-fe990b353b0a"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("44d797be-5406-4456-a294-b0c1339f0c7e"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("489eebd1-b65f-4131-a5cc-5738f25ed6d6"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("4cd935a4-f0df-4f3a-9a62-fe06f1d4b064"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("51f48c2d-e8c6-4cd6-8bd7-09c3b95b9ba7"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("53a5c92b-643c-4cbe-8420-df2ed90549b3"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("604509c3-147f-4b65-9043-69b18b1813f0"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("65a4d6fc-b737-46a2-bbd1-16c949768825"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("6faf95e0-dd4a-48b1-b33a-1ffc34d21441"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("799b0e7c-55c3-4e71-a25e-eab6d04f2858"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("7e1bef5a-6213-4763-baaa-041ba1fbc1d7"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("808b31ce-41a3-4c24-b221-aca9f44016b3"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("828039a1-d150-4cb7-9886-330713e8cde2"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("893fcd6a-5920-4fd6-b782-bd5be77f5610"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("918a1288-aee4-48fb-b919-550be6beee98"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("9ac15346-2262-4983-b1c0-2520895b8e38"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("a0cd559f-efe5-4ea0-b116-d312a1c53d7a"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("a268a632-c679-4a9e-b1cd-ed6127255230"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("a5289d71-1d84-46f1-82d2-3e9ef6113bf7"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("ac63d553-a3ab-4a61-9b9b-5b74bf8631af"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("ad07470b-9465-4654-bb56-dfda4d87c3cb"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("afcdd85c-10ad-45d7-a268-679d741bad66"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("d534865e-d1d8-4780-ab90-44dbf5e4399e"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("df2d345b-959f-42c5-b573-c940e10d5abc"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("e157b04a-2642-4723-b7fb-4a14877c3591"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("e57af8a1-9a1f-4760-9e06-9629fb0f8844"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("ea26f5c3-a054-4caa-9ef8-fb3883e1e4ce"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("ec3d2502-255a-426b-b417-3923c8977554"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("ed36995e-a468-4e50-ad74-b6664d747994"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("f479f204-c514-4274-84dc-75cd111ed519"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("fb841448-84a7-4a54-bd09-b1b79166f9fe"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("cf74d782-c506-4fd7-b57a-309dd43753e4"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("f9e2e7db-4b4b-47c5-83f4-876adb1cac0f"));

		migrationBuilder.RenameTable(
			name: "course_ategories",
			newName: "course_categories");

		migrationBuilder.RenameColumn(
			name: "courseid",
			table: "modules",
			newName: "course_id");

		migrationBuilder.RenameIndex(
			name: "ix_modules_courseid",
			table: "modules",
			newName: "ix_modules_course_id");

		migrationBuilder.RenameIndex(
			name: "ix_course_ategories_course_id",
			table: "course_categories",
			newName: "ix_course_categories_course_id");

		migrationBuilder.RenameIndex(
			name: "ix_course_ategories_category_id",
			table: "course_categories",
			newName: "ix_course_categories_category_id");

		migrationBuilder.AlterColumn<Guid>(
			name: "course_id",
			table: "modules",
			type: "uuid",
			nullable: false,
			defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
			oldClrType: typeof(Guid),
			oldType: "uuid",
			oldNullable: true);

		migrationBuilder.AddPrimaryKey(
			name: "pk_course_categories",
			table: "course_categories",
			column: "id");

		migrationBuilder.InsertData(
			table: "categories",
			columns: new[] { "id", "name" },
			values: new object[,]
			{
				{ new Guid("2ac1c225-d7a5-4e65-89bf-a835b72d5835"), "c#" },
				{ new Guid("2acee235-6bdd-4348-8189-8cc23cffd039"), "F#" },
				{ new Guid("8eff7d85-be86-4f15-8c0d-f426e8f3e49c"), "Java" },
				{ new Guid("9ab64816-950e-4446-89b9-aa97f82c7425"), "SQL" },
				{ new Guid("a6243f4f-bd62-4c4a-9095-119496138e3e"), "MySql" },
				{ new Guid("ba091a47-32d7-4cba-bcf9-5364eae19a59"), "c" },
				{ new Guid("beab246b-fd6f-4618-ae9d-6d94e84b5f00"), "Rust" },
				{ new Guid("c25b5900-2f98-4bdf-b6d4-d13163dea89d"), "Js" },
				{ new Guid("c65b7cba-47f3-4cd3-96a2-125f3e125b67"), "PHP" },
				{ new Guid("da761541-f3e1-491d-bc6d-5dab37f44a1c"), "Typescript" }
			});

		migrationBuilder.InsertData(
			table: "subscription_plans",
			columns: new[] { "id", "created_at", "description", "months", "price" },
			values: new object[,]
			{
				{ new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new DateTime(2024, 6, 1, 18, 10, 10, 658, DateTimeKind.Local).AddTicks(3380), "Free", 0, 0f },
				{ new Guid("568a8b60-bd4c-47c7-b473-03ec68515613"), new DateTime(2024, 6, 1, 18, 10, 10, 658, DateTimeKind.Local).AddTicks(3438), "Anual", 1, 399.99f },
				{ new Guid("f7238adb-2dd6-4856-a734-4049247587ba"), new DateTime(2024, 6, 1, 18, 10, 10, 658, DateTimeKind.Local).AddTicks(3430), "Mensal", 1, 35f }
			});

		migrationBuilder.InsertData(
			table: "users",
			columns: new[] { "id", "cpf", "created_at", "email", "is_active", "name", "password", "phone" },
			values: new object[,]
			{
				{ new Guid("0127afce-2c95-4eca-b1c0-80dea165df7c"), 88974998998.0, new DateTime(2024, 6, 1, 18, 10, 8, 436, DateTimeKind.Local).AddTicks(7422), "Larissa.Xavier92@bol.com.br", true, "Yuri Albuquerque", "$2a$11$qHso9tp9IM9lokfCPpEBIO86q9UyV0wOSyFxnZqRrxSxi.0b2C6n2", 550437188808.0 },
				{ new Guid("02349a0e-acde-4689-903b-72105337fb63"), 83210771103.0, new DateTime(2024, 6, 1, 18, 10, 9, 723, DateTimeKind.Local).AddTicks(8490), "Yago.Albuquerque@yahoo.com", true, "Lorraine Moraes", "$2a$11$yzbUU0HifLKJDUTQLt7uZ.TY2Ml1f8LAazhm0XJqAcH6R6qJgmtQe", 552880221665.0 },
				{ new Guid("11a32425-1c2d-4580-873a-beb703519ce6"), 30106197312.0, new DateTime(2024, 6, 1, 18, 10, 9, 957, DateTimeKind.Local).AddTicks(6281), "Livia77@live.com", true, "Ana Laura Nogueira", "$2a$11$Wuv/4bfYFiQYeP.w84aLxuL5P/OfDE.KQbxfRhPY5hBB3.M/4fHsu", 8101894197.0 },
				{ new Guid("1bf8fe55-2344-4602-a4c0-d65f9fa74504"), 32396826212.0, new DateTime(2024, 6, 1, 18, 10, 7, 148, DateTimeKind.Local).AddTicks(7175), "Cecilia.Pereira90@yahoo.com", true, "Bryan Moreira", "$2a$11$s7tYQgJ0yUtMYvOiY8VfWuZ9cRP/rwhvqhQM3OCpJug4gv1s8Mlw.", 63751075480.0 },
				{ new Guid("1cfdd7f3-f58e-4a0c-ac9d-beeb7adb2346"), 52961777623.0, new DateTime(2024, 6, 1, 18, 10, 9, 840, DateTimeKind.Local).AddTicks(6715), "Sara.Batista35@bol.com.br", true, "Sílvia Macedo", "$2a$11$6pK.TyiEkayG0jpY95yqTeKG/a5OyFn/5HEEwY7OAjJHTSnMmclc6", 4438597247.0 },
				{ new Guid("22a5cbf3-99d8-4072-993c-0f1614d4d473"), 32698042109.0, new DateTime(2024, 6, 1, 18, 10, 5, 627, DateTimeKind.Local).AddTicks(5635), "Fabio_Batista@hotmail.com", true, "Pablo Saraiva", "$2a$11$KOo9oQtRMpknyYSbOfrZ..dtVgBuDgTbJ7qwd7vqrHlnUK/1uI2IK", 557364905085.0 },
				{ new Guid("27209611-c5bc-4cf5-b00c-a9b1b6ea390b"), 74485345645.0, new DateTime(2024, 6, 1, 18, 10, 8, 789, DateTimeKind.Local).AddTicks(716), "Felix66@hotmail.com", true, "Daniel Saraiva", "$2a$11$Y27eNWrKRdRMEFSV4ofjA.vVejg3nhI6q8ga/smU9qq4wLaGaMeDW", 5791462736.0 },
				{ new Guid("296e128d-9289-4231-a4b7-a558ac7ffee4"), 64342282526.0, new DateTime(2024, 6, 1, 18, 10, 10, 74, DateTimeKind.Local).AddTicks(2994), "Lorenzo_Moraes6@bol.com.br", true, "Caio Moraes", "$2a$11$dIKwnrRfwxvtZQtvb55u/uSTe3Zu3FrkJ8ZLAp3vBtu7/QWNtpj4G", 95308351243.0 },
				{ new Guid("304a72d4-6531-4a0f-8e0b-c32564b2c01a"), 76775198817.0, new DateTime(2024, 6, 1, 18, 10, 6, 914, DateTimeKind.Local).AddTicks(7061), "Julio_Reis@live.com", true, "Marcelo Franco", "$2a$11$HLascgp4Y.STTkQO8qWkpuEImqpbYi3nGqcFieeQ3HWDltiUkANS6", 557387905980.0 },
				{ new Guid("3098c154-ba48-47b1-a9c7-1a024e93510c"), 96926878722.0, new DateTime(2024, 6, 1, 18, 10, 7, 967, DateTimeKind.Local).AddTicks(6142), "Pedro.Carvalho@gmail.com", true, "Pedro Saraiva", "$2a$11$VclxtdJxJJKFkZiJ0deGsucTWSJw.WI0EF0hwk.3NZvJ60Y5ug.9C", 1007616855.0 },
				{ new Guid("32fdb4a9-3257-40e5-a141-911857818ff8"), 24249094316.0, new DateTime(2024, 6, 1, 18, 10, 9, 373, DateTimeKind.Local).AddTicks(5705), "Julio.Braga@live.com", true, "Meire Xavier", "$2a$11$n6SrWQ2Eshu8yk9kPcQStO6c6kiYzDoaOA3w6.0JAC/IyPeEfAsOK", 891956300.0 },
				{ new Guid("35a3ca8b-10a8-4f9c-a674-10df7596196a"), 55629844741.0, new DateTime(2024, 6, 1, 18, 10, 4, 806, DateTimeKind.Local).AddTicks(3132), "Sirineu19@bol.com.br", true, "Marcela Macedo", "$2a$11$V8lnuCJuFgNlFtoBbryE7euOWumgUP/IBmHVHAugzrJaCf.9dBKfG", 6882149655.0 },
				{ new Guid("3f30ea71-fa99-447e-a4bf-bfaeac8c023e"), 45265447520.0, new DateTime(2024, 6, 1, 18, 10, 9, 23, DateTimeKind.Local).AddTicks(4059), "Sara_Carvalho81@yahoo.com", true, "Alessandro Souza", "$2a$11$NNd5KtDCMgju1YF148..Xeh6Z3CZanHhPVJgcxGDYlsNQ3zeZf.F.", 309366590.0 },
				{ new Guid("400cac5e-17f7-495f-9fc7-fea89fb55436"), 95471781210.0, new DateTime(2024, 6, 1, 18, 10, 8, 671, DateTimeKind.Local).AddTicks(8729), "Fabricio16@hotmail.com", true, "Marcos Macedo", "$2a$11$7GVbwZKlb7Hzs82TAk91qugfNRLd7hmpOE13ATUpTZ/C2c.81M8mK", 29796002936.0 },
				{ new Guid("46d12cf4-447c-45c6-9152-09c805a130dc"), 13765899747.0, new DateTime(2024, 6, 1, 18, 10, 8, 906, DateTimeKind.Local).AddTicks(3295), "Karla.Xavier44@live.com", true, "Vitor Melo", "$2a$11$qcORNtVS3GexGEOcVrTM6.dXeIMBtbAfLSQGzNTrKKKkH6yOiUTQ6", 551155543595.0 },
				{ new Guid("4c21793a-8ed3-4423-a250-5b275f1da57a"), 46879109713.0, new DateTime(2024, 6, 1, 18, 10, 7, 499, DateTimeKind.Local).AddTicks(8042), "Caua71@gmail.com", true, "Vitória Carvalho", "$2a$11$pYJTwh5uvSuXMxqb.jLCp.Y3FLih4h3q78MAqqhpBVYI4Y3Gdkck2", 5728021735.0 },
				{ new Guid("5141c064-341d-4000-a4dd-b1b118f018a3"), 84357156807.0, new DateTime(2024, 6, 1, 18, 10, 9, 607, DateTimeKind.Local).AddTicks(1678), "Liz94@bol.com.br", true, "Ana Clara Martins", "$2a$11$WShc3/XD6Hu1AMOdcV36neWqGhfrW6PrzQkzjMhqsDRComtkQIVEi", 8543847835.0 },
				{ new Guid("52e0dede-f358-426f-9e92-d1bf53bc1533"), 4603125372.0, new DateTime(2024, 6, 1, 18, 10, 7, 265, DateTimeKind.Local).AddTicks(4728), "Calebe47@bol.com.br", true, "Nataniel Melo", "$2a$11$4K/XrWqFdnePkLF7Le0DzOD6K7OaauH4rBFCeV2YCcTsoVjcf7zBm", 11404300240.0 },
				{ new Guid("5c8a5d81-433f-4dbc-96cb-2d6ac6441fd0"), 5450105606.0, new DateTime(2024, 6, 1, 18, 10, 8, 554, DateTimeKind.Local).AddTicks(1305), "MariaJulia_Reis@gmail.com", true, "Salvador Costa", "$2a$11$2tBpgIVi1MD3HApX/2lQTu1C3jkhAEvC6vK2jF3SrvsxNOV4tSY42", 7036555120.0 },
				{ new Guid("5e0cee56-7817-4b3f-9082-cae4c1cc8ab8"), 261520458.0, new DateTime(2024, 6, 1, 18, 10, 8, 85, DateTimeKind.Local).AddTicks(3427), "Isabela_Silva@live.com", true, "Felícia Carvalho", "$2a$11$dOu9MbAua0ZjWcQIAd6Rcux8fmZlTVsLsdYJASo9NwyE5IQ1njOOG", 5038628193.0 },
				{ new Guid("6058c372-d3fd-42c3-a36c-0e02390b10ec"), 70487958594.0, new DateTime(2024, 6, 1, 18, 10, 9, 490, DateTimeKind.Local).AddTicks(3701), "Gabriel_Moreira@gmail.com", true, "Kléber Pereira", "$2a$11$ceDn6YZAJZ1n5nRSfHoUyOttu7eJUDdcjMUX4oGtS/QPgpBpPts1O", 556594876467.0 },
				{ new Guid("64b934ad-b7c1-41df-b31a-a41f77345ae0"), 7697832950.0, new DateTime(2024, 6, 1, 18, 10, 5, 861, DateTimeKind.Local).AddTicks(9313), "Igor.Nogueira@live.com", true, "Isabella Carvalho", "$2a$11$IK2JYixhhPWMXsRrUXaBOefsFLI4hPyXxrCPoVWFXIX1vhv88pQaO", 55967004355.0 },
				{ new Guid("6521a6fd-2bc1-4506-bd08-0dcf622f08f6"), 65881397800.0, new DateTime(2024, 6, 1, 18, 10, 6, 797, DateTimeKind.Local).AddTicks(6408), "Gustavo31@hotmail.com", true, "Carla Reis", "$2a$11$jHALLHH2TvivfxYVqfyKROMjEfqza/WUfxO/3h2DDnryWwHdrMZOm", 72876221503.0 },
				{ new Guid("65436792-a82b-4866-bf00-a58377ea34c3"), 60034399712.0, new DateTime(2024, 6, 1, 18, 10, 6, 95, DateTimeKind.Local).AddTicks(7826), "Roberto_Barros@gmail.com", true, "Aline Moreira", "$2a$11$IzO1.PwgPtagxAUE0RdCEeQAtf5PTY6YWY3NP2Sn1VcMm/9t.kr72", 551062537790.0 },
				{ new Guid("6ce9fa7b-c945-4849-8488-ead59c927d89"), 5591428380.0, new DateTime(2024, 6, 1, 18, 10, 10, 191, DateTimeKind.Local).AddTicks(1835), "Vitor_Nogueira6@live.com", true, "Eduardo Batista", "$2a$11$NQMzyfQYfI0M8uCLnm9aT.72zyWpWHOufmejwyzUKELW.jgSBWS0S", 555339395210.0 },
				{ new Guid("7a0a8fe3-4275-470d-804d-f118a5cc645f"), 56843477380.0, new DateTime(2024, 6, 1, 18, 10, 6, 563, DateTimeKind.Local).AddTicks(5454), "Rebeca_Costa50@hotmail.com", true, "Cecília Souza", "$2a$11$k2ptYdaJOolfYhHChgmTe.C1/x9boSO/2.8WmaS4wjpUfH2w94B4O", 7714148236.0 },
				{ new Guid("819fceff-052b-424e-8e30-15a8b8f03312"), 5588891074.0, new DateTime(2024, 6, 1, 18, 10, 10, 308, DateTimeKind.Local).AddTicks(1058), "Murilo31@hotmail.com", true, "Anthony Macedo", "$2a$11$SZrsVhtcevzD2pGHkOyEJeqWd2PsLp498HFPwq8F17Wh3zrrqd3OG", 554485517003.0 },
				{ new Guid("84812609-1487-4a5d-a91c-1694db1f92f8"), 36165202748.0, new DateTime(2024, 6, 1, 18, 10, 6, 680, DateTimeKind.Local).AddTicks(5352), "Bryan.Carvalho@hotmail.com", true, "Ana Luiza Silva", "$2a$11$gazCrSH3uJB3v5L/CulOKuv87ju1bqb8y2uCTpkI35C20yhDh3AZK", 11599424087.0 },
				{ new Guid("8b55f685-15b4-41c3-927b-7caddd2dd7d3"), 33679997418.0, new DateTime(2024, 6, 1, 18, 10, 7, 382, DateTimeKind.Local).AddTicks(6270), "Lara_Costa@live.com", true, "Maria Helena Saraiva", "$2a$11$pluNY0SdR6dmvMv8seKgPe94s6EwsjhezFKZEEjOf/ohVheAoyJle", 551446051086.0 },
				{ new Guid("8de581ab-0209-4bfd-bee0-32fa4c12e6b3"), 123456789.0, new DateTime(2024, 6, 1, 18, 10, 10, 658, DateTimeKind.Local).AddTicks(2068), "professor@preofessor.com", true, "instrutor 1", "$2a$11$JqqsECT7ynGDaOF7taYwiufNHabY6vSGt4nQXJCEJSh5t.RjHDvci", 123456789.0 },
				{ new Guid("8e3771c3-eac3-415b-be7c-5c8054067bd0"), 24635536505.0, new DateTime(2024, 6, 1, 18, 10, 6, 446, DateTimeKind.Local).AddTicks(6968), "Rebeca_Reis52@bol.com.br", true, "Gustavo Carvalho", "$2a$11$/4nLiRIyTpMYBYc8HpE1LOKJyP9bzVs3sTkP7a9ywnFijfJq9uug2", 32810312917.0 },
				{ new Guid("902899fe-ff72-4a36-85f7-7f3b41d43d8d"), 76500495900.0, new DateTime(2024, 6, 1, 18, 10, 5, 274, DateTimeKind.Local).AddTicks(1097), "Danilo.Barros@yahoo.com", true, "Sílvia Barros", "$2a$11$oo9QGwXV68HPuIE/u7a8SuiB1NZ.y34tGiZ5btpcQchs.3dQMFlEK", 66828350228.0 },
				{ new Guid("93bcfba5-1acd-4fd1-a3e5-36bfdb766dd3"), 24647919382.0, new DateTime(2024, 6, 1, 18, 10, 8, 202, DateTimeKind.Local).AddTicks(6511), "Gubio.Souza@live.com", true, "Marcelo Moreira", "$2a$11$zD6gtHoAFMdMopyCJzozeuqy3S/LMSykxPlyZtY1w/7O6ZXO674vu", 4030920622.0 },
				{ new Guid("9aeabb91-48ea-4f35-9974-b19defba6875"), 37757820014.0, new DateTime(2024, 6, 1, 18, 10, 9, 256, DateTimeKind.Local).AddTicks(9694), "Silas_Souza35@gmail.com", true, "Lucas Carvalho", "$2a$11$c.amCmScokchlcUyBj8vl.cyNFsJEWpSy7UhosT0j97WsG62O5Tx2", 1056408901.0 },
				{ new Guid("a229abd1-1f9c-47c0-ba99-fa5d445e211f"), 36020159809.0, new DateTime(2024, 6, 1, 18, 10, 6, 212, DateTimeKind.Local).AddTicks(7480), "Melissa_Carvalho82@live.com", true, "Daniel Albuquerque", "$2a$11$YGq92YJM9kAn0UpuZFP.DuW3jbRFOLSIt9.99STiKOhE7GwqeBpNm", 2527898023.0 },
				{ new Guid("a28f98d9-da50-4b39-b4ce-99368cacbf8e"), 4246852643.0, new DateTime(2024, 6, 1, 18, 10, 7, 850, DateTimeKind.Local).AddTicks(5089), "Igor_Braga29@yahoo.com", true, "Marcos Moraes", "$2a$11$U1lj7rvof9RvyRCQmkbrUeJfdvQN5246oyejzwacZTlUpF9gjaPcS", 6505424484.0 },
				{ new Guid("a299d777-8892-4ef3-8940-d6baab92e52a"), 43125200709.0, new DateTime(2024, 6, 1, 18, 10, 10, 424, DateTimeKind.Local).AddTicks(8960), "Isabela.Santos85@gmail.com", true, "Antônio Xavier", "$2a$11$sbCCwpYoasYm/wRvONMPZOGB6bes5HcbjntbrNPF/SU/BRydOAzYu", 2800770498.0 },
				{ new Guid("ac1b6e0c-9d0e-483e-a770-de9daf07839f"), 50101723644.0, new DateTime(2024, 6, 1, 18, 10, 6, 329, DateTimeKind.Local).AddTicks(7150), "PedroHenrique.Souza@bol.com.br", true, "Norberto Pereira", "$2a$11$fMEcQIojYovJ5HIQk6z9o.Z210FgxckQIv/AGjjgjpaSp9dFu2T8u", 6521927580.0 },
				{ new Guid("b75c4d58-d75c-4fb9-9c57-703111632fec"), 55562163632.0, new DateTime(2024, 6, 1, 18, 10, 5, 40, DateTimeKind.Local).AddTicks(1953), "AnaJulia29@hotmail.com", true, "Núbia Carvalho", "$2a$11$1X6sV7pBpeUqYTnD4AGpIuqFW5LnD66pK5Gk/qwwNAUuhnWOY0JjK", 553620799334.0 },
				{ new Guid("bc18f482-1a4f-48a4-ae75-0d1a27429ea5"), 16843625126.0, new DateTime(2024, 6, 1, 18, 10, 8, 319, DateTimeKind.Local).AddTicks(7499), "Fabiano.Barros90@hotmail.com", true, "Benjamin Martins", "$2a$11$DBE0S/y0Rsr5hpCHJi2Nn.kxUCwXK.hbpyGviX4Ok7CjWe5mQilIC", 757524939.0 },
				{ new Guid("bf7dc00c-05cc-4bfa-ae36-925adc457e42"), 64628655634.0, new DateTime(2024, 6, 1, 18, 10, 5, 392, DateTimeKind.Local).AddTicks(2773), "Roberto.Costa24@bol.com.br", true, "Bruna Macedo", "$2a$11$sxX98LIUSXiCJzPFg90vCeb9vcHq8cljJQsQCKEywB16t0Z6.19pK", 32275190368.0 },
				{ new Guid("c959f267-3790-4b14-8b81-82c91c2f6dc2"), 42149950073.0, new DateTime(2024, 6, 1, 18, 10, 7, 31, DateTimeKind.Local).AddTicks(7219), "Isis18@hotmail.com", true, "Pietro Macedo", "$2a$11$MkpElG/F5OTIdH/d6/78MOqzvRppnDPeu3FfiDZTue/itzeLswT7W", 8232803374.0 },
				{ new Guid("d47e29b6-602e-40eb-8003-35ba92cd18a9"), 83230451783.0, new DateTime(2024, 6, 1, 18, 10, 5, 978, DateTimeKind.Local).AddTicks(9360), "Fabricio59@yahoo.com", true, "Isabella Souza", "$2a$11$SZsurrcexuzdZMb.cvyE7uFZSxZxuHF9t1fW5kJ0jBf8f6lPDN/.C", 98266291074.0 },
				{ new Guid("d6e6dbfa-e980-4ec5-8d85-58f738f92085"), 79589766668.0, new DateTime(2024, 6, 1, 18, 10, 9, 140, DateTimeKind.Local).AddTicks(2144), "Anthony82@hotmail.com", true, "Isaac Costa", "$2a$11$mmHXMK.Wg7oQHFW6zC0NteGS14b1VMUBl8m2eaQ1RF5bcGwREzJoK", 6406843795.0 },
				{ new Guid("dab90c01-5204-49fc-8e06-bf149dc685e4"), 123456789.0, new DateTime(2024, 6, 1, 18, 10, 10, 541, DateTimeKind.Local).AddTicks(5740), "admin@admin", true, "Admin", "$2a$11$ihjTsu0FMSoCuzqRHPdQ8O6p7Jo6lbYf1rnxFekxzQcw/38KNfKvm", 123456789.0 },
				{ new Guid("e79f7e7f-b437-4baf-b5e5-4f001c63a591"), 7772131500.0, new DateTime(2024, 6, 1, 18, 10, 5, 744, DateTimeKind.Local).AddTicks(7591), "Danilo_Moraes@gmail.com", true, "Giovanna Martins", "$2a$11$BFlLuBNcWMU.AUE/DNB8d.1YUgmfelp/1D4RuVHFlY1verTMBvBra", 12948815795.0 },
				{ new Guid("e939f82c-48f6-483d-a492-11224fbe0c64"), 7187681593.0, new DateTime(2024, 6, 1, 18, 10, 4, 923, DateTimeKind.Local).AddTicks(2234), "Manuela.Carvalho@hotmail.com", true, "Samuel Oliveira", "$2a$11$nObnwqte9Y98ORB4KLZMauO4hPT8tUQc0/vttT0ibsGNgSWEm2dCm", 3944863956.0 },
				{ new Guid("ee0cd406-b6e4-4f3f-8855-ed258a81bb1f"), 33999452137.0, new DateTime(2024, 6, 1, 18, 10, 7, 616, DateTimeKind.Local).AddTicks(7010), "Beatriz.Xavier@gmail.com", true, "Suélen Nogueira", "$2a$11$QZyCbnZ.Fmc5NsRal36vL.whOmnt5hXsLwnt9vGIORypjRNZu0o2a", 550742325592.0 },
				{ new Guid("f4badeb4-b9b7-41bb-ab4a-82fa806aa0e7"), 72772319377.0, new DateTime(2024, 6, 1, 18, 10, 5, 510, DateTimeKind.Local).AddTicks(2353), "Sirineu82@gmail.com", true, "Isis Carvalho", "$2a$11$mzKjLKRJ..kNxiw099HNje9s4xE3rIBhnt4VyujC1Anjh5AR0lyl.", 41796327423.0 },
				{ new Guid("f957e860-cacb-43c6-a86f-59452808a38c"), 49786526007.0, new DateTime(2024, 6, 1, 18, 10, 7, 733, DateTimeKind.Local).AddTicks(6953), "Sara_Martins87@live.com", true, "Feliciano Melo", "$2a$11$Ci/bEDG5rhnRlWtCrnR1teViHg01Hw4Flqey1VHPiOhfVNsAHg5Pm", 559275926331.0 },
				{ new Guid("f95a46b5-c00c-433b-a2d8-589e60de2491"), 81242121129.0, new DateTime(2024, 6, 1, 18, 10, 5, 157, DateTimeKind.Local).AddTicks(3462), "Frederico_Moraes0@gmail.com", true, "Bruna Souza", "$2a$11$wFL4b7Y8Ocvv6oCK1Gm92uh48A.Giniw3IUsQBwYAGBLWmH5gA5fG", 556182381452.0 },
				{ new Guid("ffe12852-f463-4c2e-8435-5778be1ab62b"), 20519914643.0, new DateTime(2024, 6, 1, 18, 10, 4, 685, DateTimeKind.Local).AddTicks(8778), "Isis13@live.com", true, "Elísio Nogueira", "$2a$11$7c/i8eTkpECWbbA5hzFrZOvwtBFv2ocGCt7303zxLHCzqk9u3EWVi", 553679576197.0 }
			});

		migrationBuilder.InsertData(
			table: "admins",
			columns: new[] { "id", "user_id" },
			values: new object[] { new Guid("cf9824a3-0ce9-4e24-9417-7fdd72da7c2a"), new Guid("dab90c01-5204-49fc-8e06-bf149dc685e4") });

		migrationBuilder.InsertData(
			table: "clients",
			columns: new[] { "id", "subscriptionplan_id", "user_id" },
			values: new object[,]
			{
				{ new Guid("09b9e3fa-f3e1-4eea-8660-acf78629ea86"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("9aeabb91-48ea-4f35-9974-b19defba6875") },
				{ new Guid("14cc43fd-5773-42a4-99cc-187127131b5e"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("304a72d4-6531-4a0f-8e0b-c32564b2c01a") },
				{ new Guid("150de1b6-4890-4589-9ede-47de539118c9"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("3f30ea71-fa99-447e-a4bf-bfaeac8c023e") },
				{ new Guid("1518325d-a870-47ec-bff2-c877e66c7d1c"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("46d12cf4-447c-45c6-9152-09c805a130dc") },
				{ new Guid("155c1f58-6272-47e1-a57f-4a565c522b20"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("f4badeb4-b9b7-41bb-ab4a-82fa806aa0e7") },
				{ new Guid("1f7d75a8-31b2-4330-bf02-c8d988fd4d76"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("4c21793a-8ed3-4423-a250-5b275f1da57a") },
				{ new Guid("274c3632-26be-46b4-985f-181055217d3e"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("6058c372-d3fd-42c3-a36c-0e02390b10ec") },
				{ new Guid("28fa34ca-a04f-479c-ad69-dd2c158f026c"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("a299d777-8892-4ef3-8940-d6baab92e52a") },
				{ new Guid("295422f1-3807-430e-8a81-ae4a02366660"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("d6e6dbfa-e980-4ec5-8d85-58f738f92085") },
				{ new Guid("3128ef13-a8fb-46b2-8caf-f8dbd19eb97a"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("3098c154-ba48-47b1-a9c7-1a024e93510c") },
				{ new Guid("3423e0ad-77f8-46da-bba2-686654057480"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("e79f7e7f-b437-4baf-b5e5-4f001c63a591") },
				{ new Guid("361c972a-0606-4e1f-a2b0-be3d45d889ba"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("ac1b6e0c-9d0e-483e-a770-de9daf07839f") },
				{ new Guid("3a6918de-7a97-407a-bce7-fd61958a5e10"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("32fdb4a9-3257-40e5-a141-911857818ff8") },
				{ new Guid("3c27859f-5342-4fd1-9509-fc8341eb50c1"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("93bcfba5-1acd-4fd1-a3e5-36bfdb766dd3") },
				{ new Guid("44f26da0-ad6f-4fa8-ade8-fa7ce5a9a361"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("819fceff-052b-424e-8e30-15a8b8f03312") },
				{ new Guid("452b6d49-52fd-493c-9c71-52077d593d0a"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("64b934ad-b7c1-41df-b31a-a41f77345ae0") },
				{ new Guid("470ba5ef-e967-4d89-814b-1d2fe3b484d2"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("902899fe-ff72-4a36-85f7-7f3b41d43d8d") },
				{ new Guid("48921f57-52b0-4e53-8fb5-88339914bf6b"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("0127afce-2c95-4eca-b1c0-80dea165df7c") },
				{ new Guid("4cbe4c43-05ce-4fd2-a4a9-ea000725d3be"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("22a5cbf3-99d8-4072-993c-0f1614d4d473") },
				{ new Guid("4e323f74-dc9e-4c7f-99b3-7fcd6f58170f"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("11a32425-1c2d-4580-873a-beb703519ce6") },
				{ new Guid("57c99da4-a74e-425d-9246-99e6bb5d2cb1"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("52e0dede-f358-426f-9e92-d1bf53bc1533") },
				{ new Guid("598a65cf-d806-4ef5-8e5e-71addc26b7ac"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("7a0a8fe3-4275-470d-804d-f118a5cc645f") },
				{ new Guid("5afd2a51-dfb2-43ca-a237-b4d0d0d74c59"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("b75c4d58-d75c-4fb9-9c57-703111632fec") },
				{ new Guid("5ed013ad-5c61-4779-9ca1-e36daff0269b"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("02349a0e-acde-4689-903b-72105337fb63") },
				{ new Guid("6779aa5d-32cc-4761-8f8f-2f38ef105dfa"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("27209611-c5bc-4cf5-b00c-a9b1b6ea390b") },
				{ new Guid("68876188-50ea-48a8-98f1-66463a296d55"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("d47e29b6-602e-40eb-8003-35ba92cd18a9") },
				{ new Guid("767bc60a-0e73-42d9-bc29-2f1c6a1b8762"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("5c8a5d81-433f-4dbc-96cb-2d6ac6441fd0") },
				{ new Guid("79d543f3-b7e5-4b82-b70b-4b3b1cbc471f"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("ee0cd406-b6e4-4f3f-8855-ed258a81bb1f") },
				{ new Guid("7c57e399-9cb8-4a22-b8e4-8a9da2228995"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("400cac5e-17f7-495f-9fc7-fea89fb55436") },
				{ new Guid("80bdfbc7-699e-4e2e-a2a7-63e9b081c18b"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("6521a6fd-2bc1-4506-bd08-0dcf622f08f6") },
				{ new Guid("85b425ab-7926-4bc7-8ec1-9ac71bbd74dc"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("8e3771c3-eac3-415b-be7c-5c8054067bd0") },
				{ new Guid("8713c582-f6be-4a70-911a-6ce78e737042"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("5141c064-341d-4000-a4dd-b1b118f018a3") },
				{ new Guid("9271f8a2-f774-4997-8a21-2f404041c1ef"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("e939f82c-48f6-483d-a492-11224fbe0c64") },
				{ new Guid("9661e0c5-92f6-4be2-9f0d-e8bfce7fc385"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("5e0cee56-7817-4b3f-9082-cae4c1cc8ab8") },
				{ new Guid("a5ec4c61-e8f6-43b3-9c54-1094f815f1ec"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("a28f98d9-da50-4b39-b4ce-99368cacbf8e") },
				{ new Guid("a60821e6-4317-4422-9a0d-74b66077246a"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("1bf8fe55-2344-4602-a4c0-d65f9fa74504") },
				{ new Guid("a6af3eae-e8e1-45c3-a4c5-dfd8c0df10fc"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("6ce9fa7b-c945-4849-8488-ead59c927d89") },
				{ new Guid("a6c0ae70-40d1-4bba-aa76-4fb3a85638ef"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("f957e860-cacb-43c6-a86f-59452808a38c") },
				{ new Guid("b43a1876-38d6-4e5e-977b-b44d913bf396"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("35a3ca8b-10a8-4f9c-a674-10df7596196a") },
				{ new Guid("b8f917b7-7fe1-453b-afc9-091017a51970"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("65436792-a82b-4866-bf00-a58377ea34c3") },
				{ new Guid("b901b38a-71f4-49df-be4a-8cc97192d9f0"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("bc18f482-1a4f-48a4-ae75-0d1a27429ea5") },
				{ new Guid("bada62ee-4789-45cd-a7ed-d60d04b4a653"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("ffe12852-f463-4c2e-8435-5778be1ab62b") },
				{ new Guid("ca5387c8-1045-4e7f-97a2-c703265f843c"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("1cfdd7f3-f58e-4a0c-ac9d-beeb7adb2346") },
				{ new Guid("cd6db410-6889-417b-b3d8-cffa8b6a86eb"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("f95a46b5-c00c-433b-a2d8-589e60de2491") },
				{ new Guid("d8d18281-a116-4007-b745-723bec445fea"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("c959f267-3790-4b14-8b81-82c91c2f6dc2") },
				{ new Guid("da1bb27c-121a-482b-9f15-7b1a6b46bef3"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("bf7dc00c-05cc-4bfa-ae36-925adc457e42") },
				{ new Guid("e66096eb-1172-438b-8f22-b791093d0a34"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("84812609-1487-4a5d-a91c-1694db1f92f8") },
				{ new Guid("f2b6d6aa-da68-4da8-9acd-ffb006924ff7"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("a229abd1-1f9c-47c0-ba99-fa5d445e211f") },
				{ new Guid("f42fb051-76bc-4eee-906c-05996b9512b7"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("8b55f685-15b4-41c3-927b-7caddd2dd7d3") },
				{ new Guid("fbcd94ee-9658-46a0-9beb-57481664356c"), new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"), new Guid("296e128d-9289-4231-a4b7-a558ac7ffee4") }
			});

		migrationBuilder.InsertData(
			table: "instructors",
			columns: new[] { "id", "github", "social_network", "user_id" },
			values: new object[] { new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), null, null, new Guid("8de581ab-0209-4bfd-bee0-32fa4c12e6b3") });

		migrationBuilder.InsertData(
			table: "blog_posts",
			columns: new[] { "id", "acesses", "created_at", "instructor_id", "text", "thumb", "title" },
			values: new object[,]
			{
				{ new Guid("0293452a-ee3e-2e07-4083-3ae8fe1b2a55"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 661, DateTimeKind.Local).AddTicks(437), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Accusamus ipsam et ut omnis possimus. Voluptatem rem tenetur delectus. Perferendis et eligendi nisi delectus cumque nihil quae est. Et magni accusantium expedita at. Est quia et quos asperiores veritatis facere. Possimus adipisci et rerum.\n\nVoluptatum sed cum. Reiciendis ipsa a aut ea. Sapiente adipisci voluptatum nulla voluptatem ex non et.\n\nAliquid aliquam cum qui non velit nisi sunt qui. Qui est et. Eaque aliquam commodi.", null, "Directives" },
				{ new Guid("0b396c4e-8960-149a-b122-85c015949f2f"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(8053), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Dolor non voluptatem libero asperiores fugiat consequatur dolor. Aut officiis eum qui maxime qui dolor et. Sapiente dignissimos corporis.\n\nConsectetur eaque possimus ut corporis aspernatur blanditiis. Omnis dolorem et sit doloribus fugit repellendus est saepe. Asperiores mollitia voluptas dignissimos ratione dolore.\n\nEa praesentium provident. Molestiae at quibusdam autem nemo eius dolorum quisquam omnis quo. Eaque qui voluptatem voluptatibus consequatur sed. Ipsa in sed illum.", null, "Group" },
				{ new Guid("103632de-855a-9f45-6223-34135db8218c"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 661, DateTimeKind.Local).AddTicks(2446), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Ducimus minus molestiae ipsam ea fugit. Qui dolorum cupiditate eos doloribus aut praesentium. Sed et odio qui optio quae ut consequatur fugiat.\n\nTotam id officia reiciendis nesciunt beatae eos. Et omnis inventore dignissimos non id. Iure fugiat provident sunt voluptatem. Labore labore est vitae. Et molestiae qui quaerat. Placeat cumque qui quod sit minima nihil voluptatem voluptatem nostrum.\n\nDolores id atque cum eligendi voluptatem. Nobis cupiditate nobis ab animi accusamus adipisci laboriosam culpa. Dignissimos deserunt iusto autem. Quae voluptatem quia ut magnam ullam odio. Architecto similique qui et ex voluptas excepturi sint.", null, "Accountability" },
				{ new Guid("1adf7b5e-16f0-88aa-4fd1-aac7c0fe656b"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 661, DateTimeKind.Local).AddTicks(2208), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Harum corrupti dolorem fuga dolore. Autem rem consectetur laboriosam placeat aliquid et. Pariatur consequuntur mollitia omnis necessitatibus. Sit reprehenderit culpa aliquam aut blanditiis rerum. Quia harum aut blanditiis corrupti earum aut amet in a. Sunt aut harum sit exercitationem velit voluptas sunt laboriosam.\n\nDicta sapiente est. Sit dolorum nulla aperiam quo. Consequatur enim itaque sequi recusandae et rerum labore corporis.\n\nNecessitatibus quam corrupti dolor quae illum. Sit et velit voluptates est sint. Modi dolores odio autem. Dolor saepe quod. Asperiores laborum et assumenda dolor quod nostrum aut. Sint necessitatibus nulla ut saepe unde.", null, "Branding" },
				{ new Guid("302346bf-f2d2-17f5-7c71-fda495abf5cf"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(9730), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Aut aut enim est dolore facilis rerum voluptatem voluptatum modi. Sed molestiae esse cum. Consequatur ut possimus quisquam delectus non maiores voluptas. Quia aut ratione cupiditate. Occaecati sed qui nemo omnis et.\n\nQuo porro dignissimos doloribus eius nihil omnis. Provident et vel sapiente inventore aspernatur. Beatae dolore quia quia dolores aut omnis vel nihil distinctio.\n\nNecessitatibus distinctio velit assumenda dolores. Cum vero sed earum ea officiis asperiores sit. Voluptatem reiciendis iusto ea et consectetur. Numquam repellat recusandae dolor tempore et sed quia consequatur. Neque explicabo reiciendis et quis illo quibusdam.", null, "Paradigm" },
				{ new Guid("3d5efa58-33d5-6bda-6933-5ab853dfacc3"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 661, DateTimeKind.Local).AddTicks(1054), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Inventore dolorem vitae distinctio voluptates veniam sint repellendus commodi. Ea labore error quidem quia itaque omnis nesciunt et qui. Consectetur porro hic culpa.\n\nSed consequatur occaecati aut dolore pariatur qui est quia. Consequatur voluptatem ut. Doloribus atque nihil rerum et adipisci est vero dolorem cumque. Ipsa architecto unde rerum. At vitae omnis. Laboriosam iusto voluptates incidunt architecto et sit ut aliquid.\n\nTempore animi veritatis possimus perspiciatis aperiam autem perspiciatis. Est perferendis ipsum tempore cumque quis exercitationem maxime id. Blanditiis ut dolorum accusantium consequatur voluptatem repudiandae. Molestias necessitatibus rem sequi nobis sint.", null, "Functionality" },
				{ new Guid("3dfe1f54-cdc2-bce0-f76d-b29d4f5f81b8"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(6229), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Expedita est velit eos molestiae. Eaque ipsam nihil sunt nam. Quo rerum facilis facilis praesentium aperiam inventore sapiente ipsum pariatur. Voluptatibus doloremque et nam nam. Doloribus necessitatibus vel assumenda ut voluptatibus repellat repudiandae aliquid odio. Vel repellendus sed.\n\nVoluptatem est voluptatem recusandae. Aut sunt eligendi sit sit. Suscipit beatae tempora dolorum ut id.\n\nCum doloremque dolore impedit fugiat omnis voluptatum et doloremque. Enim porro nostrum. Laborum iure maxime est dolore nobis enim nihil quia. Dolorem illo ipsam ut inventore nulla suscipit incidunt corrupti alias. Aut in est repellat impedit necessitatibus debitis ab. Velit aut consequuntur illum ut fugit.", null, "Directives" },
				{ new Guid("4a627625-aae8-2d62-ee4d-8e2a07860a1e"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(8852), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Aut sed quod velit sint ab animi voluptas. Odio mollitia dolorem magni. Dicta sunt odio. Nemo id amet inventore aut qui dolorum nihil. Numquam accusamus laborum. Quam autem autem.\n\nNumquam odit ea aut doloremque consectetur. Sit temporibus eos officia provident perferendis dolorum eum minima. Ipsam et quas expedita ea reprehenderit sapiente modi accusamus nesciunt.\n\nRatione qui occaecati laboriosam. Optio voluptatum et dicta sint et. Sit autem eius quasi velit omnis quia iure eum voluptas.", null, "Group" },
				{ new Guid("58ef4c4b-92c6-b8cc-e8e2-f5b91d396ad7"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(8422), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Neque temporibus dignissimos dolores voluptatum consequatur voluptatem. Accusantium qui sed sed omnis odit ducimus. Hic sint ipsum. Quos aspernatur vel deserunt corporis dolores soluta. Enim voluptatum veniam quia deleniti praesentium officia blanditiis porro at.\n\nDolorem animi doloribus voluptatum vitae et nihil. Qui quia omnis illum consectetur culpa. Accusantium omnis veniam accusantium consequatur et sed maxime. Molestias doloremque voluptas.\n\nVoluptatem molestiae sunt laboriosam eum inventore. Cum ipsum eum fugit. Quam iure dolores explicabo ea sed. Quia odit sunt quasi minus libero.", null, "Metrics" },
				{ new Guid("5d76e60b-c49a-33b5-25f6-e4cae41440c5"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 661, DateTimeKind.Local).AddTicks(1449), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Tempore iure enim enim placeat porro. Natus ea ea. Autem ex voluptas assumenda enim dolore. Fuga sint dolorum quo. Error ipsam ex facilis cupiditate et quidem provident. Aut nulla quos provident reiciendis numquam ducimus iste eos.\n\nNon quidem minus earum vel expedita eum expedita assumenda fugit. Modi assumenda sunt a itaque. Alias molestiae rem soluta enim. Atque cupiditate in adipisci. Exercitationem et et voluptas in. Ducimus et placeat quo error rerum tempora perspiciatis.\n\nVitae est harum iste sunt consequuntur est enim alias earum. Eum expedita eveniet sapiente eaque enim sed. Vel quo ullam culpa incidunt praesentium doloribus. Quos quia est. Neque voluptatem totam consectetur natus quos dolorem. Optio deserunt omnis dignissimos consequatur asperiores a.", null, "Optimization" },
				{ new Guid("5ea9a0ef-b426-bf76-9870-a223511655a8"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 661, DateTimeKind.Local).AddTicks(202), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Deserunt cum in qui quo repudiandae magnam. Ea itaque voluptas est doloribus sit et. Voluptatem quia incidunt non nemo. Dolorum blanditiis est quisquam. Quia eligendi corporis vero. Aut quia laboriosam.\n\nQuo quasi illo fuga id velit sequi. Ut dolores quod dignissimos dolor velit. Et consectetur nobis ut magni sint iure inventore facilis quis. Animi qui minima aliquam et labore eligendi pariatur dignissimos. Est amet odit saepe. Dolorum repellat illo.\n\nPossimus eum deserunt voluptatum qui. Sunt aspernatur voluptatem impedit occaecati ipsum maxime vel. Voluptates recusandae esse asperiores. Facere aut ipsa dolore. Distinctio id sint.", null, "Functionality" },
				{ new Guid("5edd4301-9283-0f57-3403-a0a00c054f06"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(7399), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Sed dolores consectetur. Dolorem explicabo deleniti consequuntur dolor consectetur ea tenetur. Unde recusandae veritatis voluptates modi sed impedit ab. Omnis minima dignissimos.\n\nQui nesciunt aspernatur hic est occaecati quia suscipit possimus itaque. Rerum commodi nesciunt fugiat voluptates cumque. Enim et aut cupiditate et. Dolore ad aut impedit dolore.\n\nImpedit rem ea rerum voluptatem aperiam voluptas a accusantium ab. Et error aut voluptatem. Quibusdam adipisci voluptatibus dolore. Labore quam voluptatum maiores doloribus doloribus iusto fugiat ut harum.", null, "Directives" },
				{ new Guid("5fcc18ab-58cd-8a77-c371-adf7ebccfd15"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(9313), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Nesciunt rem quidem eos et libero et error consequatur. Provident cum occaecati quaerat consequatur est facere et qui quis. Temporibus nam quam. Nemo fugit qui. Molestias quam omnis et possimus exercitationem. Voluptatum aut quo aut perferendis ratione temporibus.\n\nVoluptatem voluptatem assumenda et quo qui id. Sed rerum modi eveniet rerum et aut. Facere libero vel.\n\nMolestias quas est sunt omnis earum nihil. Ut voluptas vel. Ea eos accusamus. Excepturi tempore laudantium ullam neque. Soluta ut velit quos enim non.", null, "Data" },
				{ new Guid("674b9e33-d161-4607-dd2c-cc173bd01559"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(7016), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Sit est qui et culpa facilis cupiditate nesciunt blanditiis dolor. Ipsam qui qui ducimus quae aliquid. Eius cupiditate velit dicta quae voluptatem quam asperiores eligendi.\n\nVoluptatem ex explicabo amet. Labore perferendis molestias suscipit itaque voluptatem. Placeat est accusantium in ut eius qui dolore. Impedit velit quasi in voluptatem ut rem ut et ut. Pariatur placeat libero quia corrupti molestiae dolorem ipsa consequatur.\n\nDoloremque aut dolor aliquid veritatis. Voluptatibus enim dolor quaerat est dolor odio in sed. Assumenda nesciunt natus eaque neque. Maxime in aut quia ea dolor.", null, "Directives" },
				{ new Guid("75e0567c-6b18-4531-0b8d-b3624c8579a7"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(9515), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Animi dolorem fugiat. Architecto dignissimos est at maiores occaecati consectetur. Dignissimos dicta aut in quam. Laborum officiis voluptatem et sunt. Dolorem ipsum repellat officia natus animi inventore totam.\n\nNeque rerum tempora. Necessitatibus eligendi eveniet voluptate sed vitae reiciendis. Fugiat dignissimos qui vel et porro. Natus magnam laborum recusandae quis dolore. Autem sed et dolor ipsam facilis modi maxime. Atque ipsa vero veritatis cumque.\n\nNumquam sit rerum libero. Non in eum expedita. Laboriosam nulla quaerat ut sit laudantium magnam aut exercitationem. Beatae est nisi.", null, "Solutions" },
				{ new Guid("798e327a-e921-cec1-d76d-0b9ca63ba448"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(8639), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Debitis repellat libero laudantium quibusdam vitae natus. Consequatur aliquam facere aut perferendis qui. Neque quisquam magnam voluptas. Autem illum est quam est dolor consequatur cupiditate vero provident. Accusamus deserunt ad et ex at quis repellendus et numquam. Velit consequuntur enim asperiores repellat.\n\nReprehenderit quasi perspiciatis ad. Doloremque sit commodi ratione cum veniam. Incidunt doloremque rerum veritatis explicabo similique voluptates consequatur nemo ducimus.\n\nNeque ea rem dicta dolorem odio ea molestiae similique corrupti. Ut deleniti cumque error aut. Occaecati sed odio quia est ab assumenda facere ipsa perferendis.", null, "Web" },
				{ new Guid("8e3f9601-817a-e4dc-29e6-85e7314b665c"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 661, DateTimeKind.Local).AddTicks(1270), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Labore non qui amet dolor molestiae ab ut corrupti. Omnis magnam voluptatem. Molestias autem ipsa aut eaque porro voluptate consequatur quia temporibus.\n\nCupiditate quia odit provident et. Doloribus repellendus corrupti ipsa et dolorem enim. Consectetur itaque modi ex aliquam sequi delectus quos harum. Dolores quo et.\n\nQui libero quam laudantium dolor eum voluptatem in perferendis. Temporibus ab totam. Officiis tenetur amet. Reiciendis autem et eaque officiis recusandae numquam nemo non.", null, "Functionality" },
				{ new Guid("9aeffcf1-01ca-1184-18a2-0607fc360859"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(6569), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Eos numquam occaecati voluptatibus consectetur quas. Dolore eos facere qui eos minima vero quo voluptate. Hic aperiam fuga. Autem dignissimos ut fuga doloremque sit dicta et. Veritatis et adipisci delectus dolorem eos sit molestiae voluptatem rem. Cum qui harum occaecati pariatur omnis quidem sed magni.\n\nSed sit maiores autem ducimus omnis. Delectus eos et similique ut. Mollitia quod omnis iure accusamus.\n\nDoloremque est et sit quia ratione nam et in. Aliquid quae doloribus nobis natus. Debitis amet quia.", null, "Group" },
				{ new Guid("9fd74ad1-813a-0493-0bd0-cb179d9ecbea"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(8233), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Laudantium distinctio molestias. Ab cumque qui consectetur sit sit rerum est voluptas. Debitis rerum id rerum rem. Quibusdam dolores et corporis et.\n\nOfficia debitis consequatur non enim vero perferendis consequuntur et ipsum. Iure sed eos sed. Non maxime in fugiat quibusdam atque hic vel ea nam.\n\nFacere quasi culpa sint ducimus dolor officia voluptatum. Deleniti fuga omnis veritatis enim error nobis. Expedita eos dolor. Veniam numquam fugiat et. Consequatur sapiente reprehenderit et. Sit laboriosam ratione.", null, "Intranet" },
				{ new Guid("b13f8f1d-9b0e-dc55-1797-bc22b52e7b71"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 661, DateTimeKind.Local).AddTicks(611), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Aut reiciendis dolor voluptatem nobis veritatis et qui consequatur. Accusamus eveniet vel est officia reiciendis similique est. Autem dolor illum inventore est dolores dolorem sint possimus. Ipsa culpa quis aut.\n\nConsectetur voluptas vel molestiae. Quam nihil corporis quasi consequatur omnis. Tempora voluptatem eum dolorum. Dolores placeat aut excepturi et sint quia ut possimus.\n\nCum facere sint asperiores at fugit tempora illo doloribus repellat. Accusantium iste et nobis aut voluptas soluta. Sed aut eaque deleniti et voluptates temporibus sapiente.", null, "Accounts" },
				{ new Guid("b54b9910-4b3e-ae28-a525-f6850e6beac6"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 661, DateTimeKind.Local).AddTicks(1728), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Aliquid est quisquam cumque accusamus porro qui molestias vel quia. Veniam commodi ratione quo. Rem modi aut porro natus temporibus laborum ab tempora. Molestias qui consequatur facilis numquam est libero rerum optio sit. Nulla voluptas nihil sed consequatur qui dolorem. Consectetur in et eligendi aut.\n\nCulpa error fuga sequi impedit dolores modi. Reprehenderit quis unde vel maiores. Rerum beatae ut. Ullam non et libero.\n\nReiciendis mollitia dolores est eveniet delectus sint quod explicabo. Quia est quae et numquam. Sequi aut iusto aut architecto facere recusandae fugiat omnis.", null, "Mobility" },
				{ new Guid("bea4e215-7ee1-5629-4365-863a0b25c68d"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(6768), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Similique non aut quisquam corporis. Veniam quasi soluta at vero odit. Modi est modi similique illo. Sed qui incidunt sed vitae quisquam quam modi ducimus. Rerum temporibus dolore enim possimus vero voluptas modi et.\n\nAut non et deserunt assumenda natus nobis sed. Iste aut eum sed odit excepturi dignissimos voluptate. Aut placeat dolorem magni asperiores laudantium dignissimos dolores optio. Ut ut delectus quod voluptatum earum. Rerum dolorem aut nemo. Laborum libero quaerat velit.\n\nConsequuntur ratione vel atque magnam. Omnis voluptate asperiores asperiores nisi possimus sit molestiae enim. Explicabo repudiandae aut consequatur iusto. Repudiandae aut omnis alias assumenda enim error molestiae.", null, "Metrics" },
				{ new Guid("c06799b8-a675-5023-8820-2292fd5c5ba2"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(9951), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Laboriosam molestias recusandae laborum nisi magnam quia ea alias. Consequuntur qui iste eaque dignissimos dolores eveniet numquam consequuntur. Aut dolor ipsa adipisci debitis eius qui itaque molestiae fuga. Non repudiandae et expedita maxime doloribus animi. Voluptatum consectetur quae.\n\nDoloremque ut odio pariatur quasi natus numquam mollitia. Quia qui autem excepturi dolorem aut molestias debitis autem quidem. Eveniet et consequatur rerum commodi ratione. Non et omnis eaque eveniet quod. Est exercitationem consectetur sed quaerat animi consequatur vel et cupiditate.\n\nVero aut sit. Fugit ratione sit consectetur dolore sit eum voluptatem quae. Deleniti eligendi illo. Consectetur quae exercitationem et asperiores sit reiciendis officiis est et. Amet ratione ratione harum molestiae.", null, "Response" },
				{ new Guid("c3a175b9-fd5c-e7cd-017f-22d1f3e35ea3"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(5221), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Eos dolore laborum voluptatem. Beatae voluptatum non ipsum. Velit dolore recusandae et debitis. Incidunt fuga est ut rem in.\n\nReiciendis nihil dolorem dolore vel. Eius et quidem eaque numquam eum. Quas nisi consectetur unde quibusdam vel non ut. Qui porro dignissimos debitis ut qui quos culpa sequi. Qui nostrum voluptas optio expedita odio non non. Voluptatem ipsa similique voluptatum expedita placeat aspernatur.\n\nUt quis minus aut vero perspiciatis molestiae non. Molestias quia dolor vero. Dolor voluptas pariatur officiis accusamus et labore alias molestias alias. Voluptatem occaecati itaque excepturi consequuntur possimus velit saepe. Molestias ut quod pariatur animi vitae. Fugit pariatur et et eos laborum.", null, "Markets" },
				{ new Guid("c5caa2b6-9a84-4ef1-ac8d-f36aa9dcda46"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(7850), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Id non qui iste vitae id ea quis. Aut quaerat non et minus est ratione ut quibusdam. Vel sunt maiores nemo. Odio natus praesentium.\n\nVelit maxime eos est ut libero omnis sint assumenda ullam. Ea illo nostrum perferendis aut accusamus necessitatibus. Fuga maxime ducimus provident quidem culpa molestiae quo mollitia. Odit impedit deserunt placeat aut ab non aspernatur facilis aliquid.\n\nPorro eius ullam similique reiciendis asperiores magnam. Et accusamus quisquam eum aperiam asperiores nobis et eum adipisci. Aut delectus fuga dolores deserunt quia ut nam.", null, "Infrastructure" },
				{ new Guid("cf64f710-1318-09c9-b1a0-3438c5eedd10"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 661, DateTimeKind.Local).AddTicks(800), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Eveniet nihil quibusdam quos omnis laboriosam temporibus in. Quis iusto aut ut omnis sed qui et. Sint at neque atque suscipit voluptates aut dolorum amet. Explicabo ex deserunt amet dolorem. Ab officia sit quae esse.\n\nQuia voluptas rerum architecto qui. Facere omnis omnis officiis et aut. Quasi quia quidem sed sunt. Perspiciatis dolorem molestiae dolorum cum. Ratione alias cumque eos. Est rerum sit nam.\n\nEt earum animi dolores unde occaecati magnam sit ut quis. Ab aut quo similique voluptatem. Ullam quo adipisci. Nihil dolores dolorem. Rerum laborum odit sit qui ab rerum nemo. Consequatur blanditiis quia suscipit molestias eveniet necessitatibus ut.", null, "Configuration" },
				{ new Guid("d7c42ed9-3b5f-c843-3670-7503f746e55c"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(7599), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Aut id maiores enim perspiciatis a officiis laudantium. Aperiam reprehenderit quod. Libero blanditiis eos mollitia. Amet ea possimus minima quidem. Ut minima fugit ut consequuntur eius et possimus et.\n\nLaborum quaerat eos commodi suscipit provident unde voluptate. Quam labore nobis veritatis sit corporis. Nisi nihil natus in optio voluptatem omnis. Reprehenderit reiciendis dolorem consequuntur a labore rerum sed. Sit est expedita ab suscipit culpa. Quia veritatis doloribus exercitationem et.\n\nModi dolorem ducimus in rerum quod ullam sunt quidem. Sunt est voluptas id odio explicabo placeat et id delectus. Placeat id incidunt temporibus et ad modi ut. Corrupti maxime necessitatibus molestiae et velit qui esse.", null, "Paradigm" },
				{ new Guid("e9a18ff9-6d88-d81a-a834-1f4e430e826e"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(7222), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Qui vel ducimus et rerum fuga aut. Ad dolore consequatur quia dicta at iusto est ad mollitia. Necessitatibus et error et laboriosam eligendi ut qui ipsum.\n\nPorro porro distinctio unde culpa aperiam ratione possimus nihil. Suscipit culpa atque tempora tenetur. Nam in omnis sed eos aut velit omnis.\n\nDolorem natus vero architecto qui labore tempora. Et ut qui assumenda dolores quis harum ea. Et nisi voluptatem animi nobis fugiat consequatur natus adipisci.", null, "Factors" },
				{ new Guid("ecf5d93a-1f7c-269b-1d0d-b3a656c1408d"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 660, DateTimeKind.Local).AddTicks(9034), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Assumenda molestiae veniam iusto recusandae. Vel molestiae est fuga inventore. Est nostrum est blanditiis provident qui. Sit amet accusamus. Corporis quibusdam temporibus et architecto amet et eum illum voluptates. Illum minus voluptatum accusantium consequatur reprehenderit vel nemo rem quidem.\n\nQui placeat asperiores doloribus ut sed nobis quia. Vero quasi voluptas dolores cum. Eaque odio tenetur incidunt qui cumque repudiandae quasi cum quisquam. Velit ipsum exercitationem atque. Incidunt quis voluptate voluptatem nulla commodi et. Tenetur perferendis dolor vel repellendus quae alias.\n\nExercitationem iste sit rerum vel corrupti non eos reiciendis consequatur. Distinctio nam consequatur sed vel ut quisquam alias velit. Optio modi debitis cupiditate dolorum. Et qui et tempora expedita maiores dolores cumque. Et laborum sint cupiditate.", null, "Operations" },
				{ new Guid("fc792fc3-b913-5d26-24d8-0138201ef1ae"), 0, new DateTime(2024, 6, 1, 18, 10, 10, 661, DateTimeKind.Local).AddTicks(1948), new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), "Est culpa officiis totam atque et provident voluptas. Nihil velit maiores. Quo nisi excepturi exercitationem dolor sint deserunt impedit illo cupiditate. At unde adipisci. At temporibus tempore laudantium quos voluptate. Quasi possimus distinctio nostrum facilis.\n\nQui quia corrupti sequi cumque. Necessitatibus nisi vel praesentium doloremque a. Voluptatem facilis quae maxime rerum rerum voluptas et excepturi ipsum. Dolor et nihil rem quos. Voluptatem illum aut repellendus eaque totam itaque numquam eligendi.\n\nOdio sit saepe accusantium quod dicta iste sit quis. Quo quas ut sunt sunt amet qui et. Voluptatem cupiditate eos eius. Illum aut deserunt officia velit eius ut. Sed consequatur earum adipisci itaque voluptatibus. Consectetur ut fugiat.", null, "Operations" }
			});

		migrationBuilder.InsertData(
			table: "courses",
			columns: new[] { "id", "active", "created_at", "description", "duration", "instructor_id", "is_free", "lastupdate", "thumb", "title" },
			values: new object[,]
			{
				{ new Guid("108950da-4a56-4947-b0fe-855c5f363ede"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(1867), "Minima ad autem deserunt amet sunt totam. Quis id voluptatem quia quo et ut odio quibusdam modi. Ea ab et minima.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(1869), null, "Atum" },
				{ new Guid("153c4398-d17c-404b-b1d4-0f82f774d338"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2316), "Saepe praesentium aut occaecati. Est exercitationem ea et nisi quo neque illum praesentium. Nisi qui et et sapiente doloremque quas. Autem non ea labore ut suscipit dignissimos et. Aut sint dolor corporis soluta fugiat et molestiae rerum quo. Quidem eligendi est optio veniam.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2317), null, "Salada" },
				{ new Guid("15dbf863-ff56-428f-af97-a2bb3d92aa63"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2096), "Deleniti et molestias laboriosam sunt amet nemo iste minima. Quia illum ullam officia vero. Aut qui laboriosam et modi magni corrupti. Sit voluptas vel asperiores quia officia quia ipsum.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2097), null, "Computador" },
				{ new Guid("3fe774df-370a-4657-b015-015e230bcabb"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2430), "Tenetur deserunt quia et. Modi sit impedit natus distinctio. Eveniet quos cupiditate velit adipisci adipisci dolorem cumque non eaque. Quidem et harum.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2431), null, "Luvas" },
				{ new Guid("40d9933b-c46d-4fe0-8731-d9421d158e47"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2748), "Perferendis voluptas numquam magnam. Tempora est nihil hic ex a dolor est repudiandae. Accusantium neque commodi quia ipsa nemo.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2749), null, "Camiseta" },
				{ new Guid("410d35e5-7ba7-42b3-afb5-d462cbd1244b"), true, new DateTime(2024, 6, 1, 18, 10, 10, 662, DateTimeKind.Local).AddTicks(9289), "Tempore ad tempore consectetur illo ea dolores magni voluptatem. Possimus quos consequuntur ut molestias. Itaque quae at sequi pariatur corporis quae quos tempora consequatur. Consectetur nobis officiis iusto ut quo quia. Et amet voluptatum est ad qui eum consequatur.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 662, DateTimeKind.Local).AddTicks(9294), null, "Camiseta" },
				{ new Guid("4362d65e-5fde-40e6-af8a-10a7c0004f12"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2976), null, null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2977), null, "Curso de baixa qualidade" },
				{ new Guid("4d2900c9-eef6-4186-920b-21163e9d297a"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2574), "Quo repellat praesentium officiis nesciunt et praesentium voluptates autem reiciendis. Voluptates ut veniam reprehenderit iusto quod eaque. Velit esse dolores et et vitae error consequatur modi. Rerum est velit dolores et et repellendus ea accusantium dolorum. Quibusdam rerum cum qui qui ea.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2575), null, "Teclado" },
				{ new Guid("9457b320-4336-4d39-a715-0b77f4ec12ca"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2888), "Neque labore modi dolorem nisi ut ipsa ut sunt. Id eaque odit sunt ut aut eum rem inventore optio. Distinctio aperiam aut fugit perspiciatis repudiandae. Voluptatem commodi harum veritatis voluptatem veritatis iusto.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2889), null, "Atum" },
				{ new Guid("99b687e8-2457-4645-a5ff-4e2d57fc8503"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2243), "Rem aperiam aut debitis. Omnis quo impedit ut ab incidunt quae exercitationem cum voluptatum. Doloremque recusandae quidem aliquid ab qui blanditiis. Veniam laudantium et fugit beatae.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2244), null, "Salgadinhos" },
				{ new Guid("a6adeb40-0215-4c17-bd1a-43f7669c3a38"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2507), "Consequatur modi consequatur quos et. Explicabo repellat eius molestiae natus neque ea nihil quia. Enim accusantium ipsum nostrum earum officiis. Ut deleniti vel repellendus.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2508), null, "Bola" },
				{ new Guid("a828764e-a384-4261-ad3c-6dc22c1faf74"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(1985), "Et et in dignissimos sit iusto aut in repudiandae. Repellendus quos dolorem. Quis qui voluptas doloremque sit doloribus reiciendis ea eveniet. Aspernatur eius aut incidunt dolorem illum. Atque quos ex culpa.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(1986), null, "Salada" },
				{ new Guid("b07a033c-47f6-4488-bc56-de8c9170983f"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2678), "Non est unde dolorem esse. Cupiditate neque voluptatem repudiandae quam eligendi fugit sunt sequi quia. Eos molestias harum dolor. Rerum eveniet in eum quis veritatis numquam.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2678), null, "Carro" },
				{ new Guid("b89d6d3e-780b-4c55-8271-f2ae012c4e1d"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2809), "Ex expedita modi. Sit autem nesciunt veniam iste sed quaerat laborum. Aut possimus rerum laudantium laboriosam. Dignissimos tenetur sit suscipit ut architecto. Incidunt ut reprehenderit numquam soluta velit nisi soluta praesentium.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2810), null, "Teclado" },
				{ new Guid("df32dd75-08e9-4338-bbb8-3804d7933394"), true, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2174), "Dolores voluptas tempora neque sit blanditiis. Facilis facere dolorem est et similique ut est neque. Aliquam velit aspernatur voluptatem accusamus qui fugiat atque.", null, new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"), false, new DateTime(2024, 6, 1, 18, 10, 10, 663, DateTimeKind.Local).AddTicks(2175), null, "Frango" }
			});

		migrationBuilder.InsertData(
			table: "modules",
			columns: new[] { "id", "complete", "course_id", "description", "order", "title" },
			values: new object[,]
			{
				{ new Guid("ae4686de-ba77-4b82-9fbf-06a11a2512e5"), false, new Guid("4362d65e-5fde-40e6-af8a-10a7c0004f12"), null, 0, "introducao" },
				{ new Guid("c716ccea-b1a1-42f8-be81-4dbe392f2a33"), false, new Guid("4362d65e-5fde-40e6-af8a-10a7c0004f12"), null, 2, "Modulo 3" },
				{ new Guid("f627df77-88a8-4109-aaec-816b203d9d05"), false, new Guid("4362d65e-5fde-40e6-af8a-10a7c0004f12"), null, 1, "Modulo 2" }
			});

		migrationBuilder.InsertData(
			table: "post_categories",
			columns: new[] { "id", "blog_post_id", "category_id" },
			values: new object[,]
			{
				{ new Guid("1253ed3f-434d-41ac-b8b7-b4f5259b3a05"), new Guid("d7c42ed9-3b5f-c843-3670-7503f746e55c"), new Guid("da761541-f3e1-491d-bc6d-5dab37f44a1c") },
				{ new Guid("1b84f62d-5a9e-474b-bf9b-fce166e70493"), new Guid("674b9e33-d161-4607-dd2c-cc173bd01559"), new Guid("a6243f4f-bd62-4c4a-9095-119496138e3e") },
				{ new Guid("43daf7c4-f7c0-4006-9770-8c65d1026926"), new Guid("ecf5d93a-1f7c-269b-1d0d-b3a656c1408d"), new Guid("da761541-f3e1-491d-bc6d-5dab37f44a1c") },
				{ new Guid("48bffd36-92ac-48dd-ab1e-5e6b28477a08"), new Guid("3d5efa58-33d5-6bda-6933-5ab853dfacc3"), new Guid("2acee235-6bdd-4348-8189-8cc23cffd039") },
				{ new Guid("4d72f406-11e9-427a-b13f-d6bf70b053a7"), new Guid("fc792fc3-b913-5d26-24d8-0138201ef1ae"), new Guid("da761541-f3e1-491d-bc6d-5dab37f44a1c") },
				{ new Guid("5f1c0098-4914-40f5-bb94-20c8a0826ae4"), new Guid("9aeffcf1-01ca-1184-18a2-0607fc360859"), new Guid("c25b5900-2f98-4bdf-b6d4-d13163dea89d") },
				{ new Guid("777a50cb-df79-4929-84f8-7761997b6cbc"), new Guid("0293452a-ee3e-2e07-4083-3ae8fe1b2a55"), new Guid("c25b5900-2f98-4bdf-b6d4-d13163dea89d") },
				{ new Guid("77fcf6b4-07f2-499e-94fa-3f69e58675b9"), new Guid("103632de-855a-9f45-6223-34135db8218c"), new Guid("9ab64816-950e-4446-89b9-aa97f82c7425") },
				{ new Guid("833cb3e9-dcfa-43ee-9d68-c849f093e1c5"), new Guid("bea4e215-7ee1-5629-4365-863a0b25c68d"), new Guid("2acee235-6bdd-4348-8189-8cc23cffd039") },
				{ new Guid("88337bea-5ba4-44de-b40f-58a0f5b02274"), new Guid("c3a175b9-fd5c-e7cd-017f-22d1f3e35ea3"), new Guid("ba091a47-32d7-4cba-bcf9-5364eae19a59") },
				{ new Guid("9453eed1-0a7d-434d-89e3-d00dd7a48e5c"), new Guid("75e0567c-6b18-4531-0b8d-b3624c8579a7"), new Guid("da761541-f3e1-491d-bc6d-5dab37f44a1c") },
				{ new Guid("99bbb07c-a280-4bfd-80f0-0bc251a6aaa8"), new Guid("e9a18ff9-6d88-d81a-a834-1f4e430e826e"), new Guid("2ac1c225-d7a5-4e65-89bf-a835b72d5835") },
				{ new Guid("9a64f01f-f942-4d93-a669-d5df4b2736b6"), new Guid("9fd74ad1-813a-0493-0bd0-cb179d9ecbea"), new Guid("c25b5900-2f98-4bdf-b6d4-d13163dea89d") },
				{ new Guid("ae8ec9f1-0c6c-4481-9e3f-a4dc94c5873b"), new Guid("8e3f9601-817a-e4dc-29e6-85e7314b665c"), new Guid("ba091a47-32d7-4cba-bcf9-5364eae19a59") },
				{ new Guid("bbb12705-54e3-4c7c-91de-0b53f3636837"), new Guid("b54b9910-4b3e-ae28-a525-f6850e6beac6"), new Guid("9ab64816-950e-4446-89b9-aa97f82c7425") },
				{ new Guid("c045641c-ffc5-4ec5-a74f-5f4cd6a5d1df"), new Guid("cf64f710-1318-09c9-b1a0-3438c5eedd10"), new Guid("8eff7d85-be86-4f15-8c0d-f426e8f3e49c") },
				{ new Guid("c2f4f657-b5d5-49fb-aa9a-934b8fad2189"), new Guid("0b396c4e-8960-149a-b122-85c015949f2f"), new Guid("da761541-f3e1-491d-bc6d-5dab37f44a1c") },
				{ new Guid("c7b37103-d769-4123-a7c7-4b33f78ec32d"), new Guid("798e327a-e921-cec1-d76d-0b9ca63ba448"), new Guid("c25b5900-2f98-4bdf-b6d4-d13163dea89d") },
				{ new Guid("cddb79a1-c7c4-415f-aa20-6bcb093c5c8a"), new Guid("1adf7b5e-16f0-88aa-4fd1-aac7c0fe656b"), new Guid("c65b7cba-47f3-4cd3-96a2-125f3e125b67") },
				{ new Guid("ce8f810b-c580-4465-8894-ebfdbf162d62"), new Guid("4a627625-aae8-2d62-ee4d-8e2a07860a1e"), new Guid("8eff7d85-be86-4f15-8c0d-f426e8f3e49c") },
				{ new Guid("cec0b24d-e9c1-4c93-b50c-a06c2df5088b"), new Guid("b13f8f1d-9b0e-dc55-1797-bc22b52e7b71"), new Guid("2ac1c225-d7a5-4e65-89bf-a835b72d5835") },
				{ new Guid("d2005eba-bf31-4247-add3-b36673c0e669"), new Guid("c06799b8-a675-5023-8820-2292fd5c5ba2"), new Guid("beab246b-fd6f-4618-ae9d-6d94e84b5f00") },
				{ new Guid("d39095e5-6eb1-44b1-9ae9-def53da5ab38"), new Guid("c5caa2b6-9a84-4ef1-ac8d-f36aa9dcda46"), new Guid("9ab64816-950e-4446-89b9-aa97f82c7425") },
				{ new Guid("d91af6d3-e899-48ae-9ab7-0a65b6842391"), new Guid("3dfe1f54-cdc2-bce0-f76d-b29d4f5f81b8"), new Guid("ba091a47-32d7-4cba-bcf9-5364eae19a59") },
				{ new Guid("d99a77e3-6ba3-4be5-a383-479168c5d511"), new Guid("5ea9a0ef-b426-bf76-9870-a223511655a8"), new Guid("c25b5900-2f98-4bdf-b6d4-d13163dea89d") },
				{ new Guid("dd36b3f8-9ffd-4b19-b862-d6a82aab1198"), new Guid("302346bf-f2d2-17f5-7c71-fda495abf5cf"), new Guid("c25b5900-2f98-4bdf-b6d4-d13163dea89d") },
				{ new Guid("e0bffd54-0045-4afc-ae3f-64580dbbf618"), new Guid("5edd4301-9283-0f57-3403-a0a00c054f06"), new Guid("2acee235-6bdd-4348-8189-8cc23cffd039") },
				{ new Guid("e7d24a93-650b-44ee-a338-f29659d96e39"), new Guid("5d76e60b-c49a-33b5-25f6-e4cae41440c5"), new Guid("a6243f4f-bd62-4c4a-9095-119496138e3e") },
				{ new Guid("e90ed132-d950-463f-81ac-a423b958b881"), new Guid("5fcc18ab-58cd-8a77-c371-adf7ebccfd15"), new Guid("da761541-f3e1-491d-bc6d-5dab37f44a1c") },
				{ new Guid("ef80029c-e255-4b90-ad8e-48b484ed9233"), new Guid("58ef4c4b-92c6-b8cc-e8e2-f5b91d396ad7"), new Guid("2ac1c225-d7a5-4e65-89bf-a835b72d5835") }
			});

		migrationBuilder.AddForeignKey(
			name: "fk_course_categories_categories_category_id",
			table: "course_categories",
			column: "category_id",
			principalTable: "categories",
			principalColumn: "id",
			onDelete: ReferentialAction.Cascade);

		migrationBuilder.AddForeignKey(
			name: "fk_course_categories_courses_course_id",
			table: "course_categories",
			column: "course_id",
			principalTable: "courses",
			principalColumn: "id",
			onDelete: ReferentialAction.Cascade);

		migrationBuilder.AddForeignKey(
			name: "fk_modules_courses_course_id",
			table: "modules",
			column: "course_id",
			principalTable: "courses",
			principalColumn: "id",
			onDelete: ReferentialAction.Cascade);
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder) {
		migrationBuilder.DropForeignKey(
			name: "fk_course_categories_categories_category_id",
			table: "course_categories");

		migrationBuilder.DropForeignKey(
			name: "fk_course_categories_courses_course_id",
			table: "course_categories");

		migrationBuilder.DropForeignKey(
			name: "fk_modules_courses_course_id",
			table: "modules");

		migrationBuilder.DropPrimaryKey(
			name: "pk_course_categories",
			table: "course_categories");

		migrationBuilder.DeleteData(
			table: "admins",
			keyColumn: "id",
			keyValue: new Guid("cf9824a3-0ce9-4e24-9417-7fdd72da7c2a"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("09b9e3fa-f3e1-4eea-8660-acf78629ea86"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("14cc43fd-5773-42a4-99cc-187127131b5e"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("150de1b6-4890-4589-9ede-47de539118c9"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("1518325d-a870-47ec-bff2-c877e66c7d1c"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("155c1f58-6272-47e1-a57f-4a565c522b20"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("1f7d75a8-31b2-4330-bf02-c8d988fd4d76"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("274c3632-26be-46b4-985f-181055217d3e"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("28fa34ca-a04f-479c-ad69-dd2c158f026c"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("295422f1-3807-430e-8a81-ae4a02366660"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("3128ef13-a8fb-46b2-8caf-f8dbd19eb97a"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("3423e0ad-77f8-46da-bba2-686654057480"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("361c972a-0606-4e1f-a2b0-be3d45d889ba"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("3a6918de-7a97-407a-bce7-fd61958a5e10"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("3c27859f-5342-4fd1-9509-fc8341eb50c1"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("44f26da0-ad6f-4fa8-ade8-fa7ce5a9a361"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("452b6d49-52fd-493c-9c71-52077d593d0a"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("470ba5ef-e967-4d89-814b-1d2fe3b484d2"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("48921f57-52b0-4e53-8fb5-88339914bf6b"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("4cbe4c43-05ce-4fd2-a4a9-ea000725d3be"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("4e323f74-dc9e-4c7f-99b3-7fcd6f58170f"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("57c99da4-a74e-425d-9246-99e6bb5d2cb1"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("598a65cf-d806-4ef5-8e5e-71addc26b7ac"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("5afd2a51-dfb2-43ca-a237-b4d0d0d74c59"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("5ed013ad-5c61-4779-9ca1-e36daff0269b"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("6779aa5d-32cc-4761-8f8f-2f38ef105dfa"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("68876188-50ea-48a8-98f1-66463a296d55"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("767bc60a-0e73-42d9-bc29-2f1c6a1b8762"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("79d543f3-b7e5-4b82-b70b-4b3b1cbc471f"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("7c57e399-9cb8-4a22-b8e4-8a9da2228995"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("80bdfbc7-699e-4e2e-a2a7-63e9b081c18b"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("85b425ab-7926-4bc7-8ec1-9ac71bbd74dc"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("8713c582-f6be-4a70-911a-6ce78e737042"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("9271f8a2-f774-4997-8a21-2f404041c1ef"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("9661e0c5-92f6-4be2-9f0d-e8bfce7fc385"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("a5ec4c61-e8f6-43b3-9c54-1094f815f1ec"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("a60821e6-4317-4422-9a0d-74b66077246a"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("a6af3eae-e8e1-45c3-a4c5-dfd8c0df10fc"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("a6c0ae70-40d1-4bba-aa76-4fb3a85638ef"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("b43a1876-38d6-4e5e-977b-b44d913bf396"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("b8f917b7-7fe1-453b-afc9-091017a51970"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("b901b38a-71f4-49df-be4a-8cc97192d9f0"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("bada62ee-4789-45cd-a7ed-d60d04b4a653"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("ca5387c8-1045-4e7f-97a2-c703265f843c"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("cd6db410-6889-417b-b3d8-cffa8b6a86eb"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("d8d18281-a116-4007-b745-723bec445fea"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("da1bb27c-121a-482b-9f15-7b1a6b46bef3"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("e66096eb-1172-438b-8f22-b791093d0a34"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("f2b6d6aa-da68-4da8-9acd-ffb006924ff7"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("f42fb051-76bc-4eee-906c-05996b9512b7"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("fbcd94ee-9658-46a0-9beb-57481664356c"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("108950da-4a56-4947-b0fe-855c5f363ede"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("153c4398-d17c-404b-b1d4-0f82f774d338"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("15dbf863-ff56-428f-af97-a2bb3d92aa63"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("3fe774df-370a-4657-b015-015e230bcabb"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("40d9933b-c46d-4fe0-8731-d9421d158e47"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("410d35e5-7ba7-42b3-afb5-d462cbd1244b"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("4d2900c9-eef6-4186-920b-21163e9d297a"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("9457b320-4336-4d39-a715-0b77f4ec12ca"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("99b687e8-2457-4645-a5ff-4e2d57fc8503"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("a6adeb40-0215-4c17-bd1a-43f7669c3a38"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("a828764e-a384-4261-ad3c-6dc22c1faf74"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("b07a033c-47f6-4488-bc56-de8c9170983f"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("b89d6d3e-780b-4c55-8271-f2ae012c4e1d"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("df32dd75-08e9-4338-bbb8-3804d7933394"));

		migrationBuilder.DeleteData(
			table: "modules",
			keyColumn: "id",
			keyValue: new Guid("ae4686de-ba77-4b82-9fbf-06a11a2512e5"));

		migrationBuilder.DeleteData(
			table: "modules",
			keyColumn: "id",
			keyValue: new Guid("c716ccea-b1a1-42f8-be81-4dbe392f2a33"));

		migrationBuilder.DeleteData(
			table: "modules",
			keyColumn: "id",
			keyValue: new Guid("f627df77-88a8-4109-aaec-816b203d9d05"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("1253ed3f-434d-41ac-b8b7-b4f5259b3a05"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("1b84f62d-5a9e-474b-bf9b-fce166e70493"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("43daf7c4-f7c0-4006-9770-8c65d1026926"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("48bffd36-92ac-48dd-ab1e-5e6b28477a08"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("4d72f406-11e9-427a-b13f-d6bf70b053a7"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("5f1c0098-4914-40f5-bb94-20c8a0826ae4"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("777a50cb-df79-4929-84f8-7761997b6cbc"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("77fcf6b4-07f2-499e-94fa-3f69e58675b9"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("833cb3e9-dcfa-43ee-9d68-c849f093e1c5"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("88337bea-5ba4-44de-b40f-58a0f5b02274"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("9453eed1-0a7d-434d-89e3-d00dd7a48e5c"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("99bbb07c-a280-4bfd-80f0-0bc251a6aaa8"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("9a64f01f-f942-4d93-a669-d5df4b2736b6"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("ae8ec9f1-0c6c-4481-9e3f-a4dc94c5873b"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("bbb12705-54e3-4c7c-91de-0b53f3636837"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("c045641c-ffc5-4ec5-a74f-5f4cd6a5d1df"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("c2f4f657-b5d5-49fb-aa9a-934b8fad2189"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("c7b37103-d769-4123-a7c7-4b33f78ec32d"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("cddb79a1-c7c4-415f-aa20-6bcb093c5c8a"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("ce8f810b-c580-4465-8894-ebfdbf162d62"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("cec0b24d-e9c1-4c93-b50c-a06c2df5088b"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("d2005eba-bf31-4247-add3-b36673c0e669"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("d39095e5-6eb1-44b1-9ae9-def53da5ab38"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("d91af6d3-e899-48ae-9ab7-0a65b6842391"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("d99a77e3-6ba3-4be5-a383-479168c5d511"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("dd36b3f8-9ffd-4b19-b862-d6a82aab1198"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("e0bffd54-0045-4afc-ae3f-64580dbbf618"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("e7d24a93-650b-44ee-a338-f29659d96e39"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("e90ed132-d950-463f-81ac-a423b958b881"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("ef80029c-e255-4b90-ad8e-48b484ed9233"));

		migrationBuilder.DeleteData(
			table: "subscription_plans",
			keyColumn: "id",
			keyValue: new Guid("568a8b60-bd4c-47c7-b473-03ec68515613"));

		migrationBuilder.DeleteData(
			table: "subscription_plans",
			keyColumn: "id",
			keyValue: new Guid("f7238adb-2dd6-4856-a734-4049247587ba"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("0293452a-ee3e-2e07-4083-3ae8fe1b2a55"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("0b396c4e-8960-149a-b122-85c015949f2f"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("103632de-855a-9f45-6223-34135db8218c"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("1adf7b5e-16f0-88aa-4fd1-aac7c0fe656b"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("302346bf-f2d2-17f5-7c71-fda495abf5cf"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("3d5efa58-33d5-6bda-6933-5ab853dfacc3"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("3dfe1f54-cdc2-bce0-f76d-b29d4f5f81b8"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("4a627625-aae8-2d62-ee4d-8e2a07860a1e"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("58ef4c4b-92c6-b8cc-e8e2-f5b91d396ad7"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("5d76e60b-c49a-33b5-25f6-e4cae41440c5"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("5ea9a0ef-b426-bf76-9870-a223511655a8"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("5edd4301-9283-0f57-3403-a0a00c054f06"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("5fcc18ab-58cd-8a77-c371-adf7ebccfd15"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("674b9e33-d161-4607-dd2c-cc173bd01559"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("75e0567c-6b18-4531-0b8d-b3624c8579a7"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("798e327a-e921-cec1-d76d-0b9ca63ba448"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("8e3f9601-817a-e4dc-29e6-85e7314b665c"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("9aeffcf1-01ca-1184-18a2-0607fc360859"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("9fd74ad1-813a-0493-0bd0-cb179d9ecbea"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("b13f8f1d-9b0e-dc55-1797-bc22b52e7b71"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("b54b9910-4b3e-ae28-a525-f6850e6beac6"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("bea4e215-7ee1-5629-4365-863a0b25c68d"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("c06799b8-a675-5023-8820-2292fd5c5ba2"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("c3a175b9-fd5c-e7cd-017f-22d1f3e35ea3"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("c5caa2b6-9a84-4ef1-ac8d-f36aa9dcda46"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("cf64f710-1318-09c9-b1a0-3438c5eedd10"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("d7c42ed9-3b5f-c843-3670-7503f746e55c"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("e9a18ff9-6d88-d81a-a834-1f4e430e826e"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("ecf5d93a-1f7c-269b-1d0d-b3a656c1408d"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("fc792fc3-b913-5d26-24d8-0138201ef1ae"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("2ac1c225-d7a5-4e65-89bf-a835b72d5835"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("2acee235-6bdd-4348-8189-8cc23cffd039"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("8eff7d85-be86-4f15-8c0d-f426e8f3e49c"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("9ab64816-950e-4446-89b9-aa97f82c7425"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("a6243f4f-bd62-4c4a-9095-119496138e3e"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("ba091a47-32d7-4cba-bcf9-5364eae19a59"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("beab246b-fd6f-4618-ae9d-6d94e84b5f00"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("c25b5900-2f98-4bdf-b6d4-d13163dea89d"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("c65b7cba-47f3-4cd3-96a2-125f3e125b67"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("da761541-f3e1-491d-bc6d-5dab37f44a1c"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("4362d65e-5fde-40e6-af8a-10a7c0004f12"));

		migrationBuilder.DeleteData(
			table: "subscription_plans",
			keyColumn: "id",
			keyValue: new Guid("2429552a-b8a9-4982-8e46-559d9ac77c44"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("0127afce-2c95-4eca-b1c0-80dea165df7c"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("02349a0e-acde-4689-903b-72105337fb63"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("11a32425-1c2d-4580-873a-beb703519ce6"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("1bf8fe55-2344-4602-a4c0-d65f9fa74504"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("1cfdd7f3-f58e-4a0c-ac9d-beeb7adb2346"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("22a5cbf3-99d8-4072-993c-0f1614d4d473"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("27209611-c5bc-4cf5-b00c-a9b1b6ea390b"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("296e128d-9289-4231-a4b7-a558ac7ffee4"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("304a72d4-6531-4a0f-8e0b-c32564b2c01a"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("3098c154-ba48-47b1-a9c7-1a024e93510c"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("32fdb4a9-3257-40e5-a141-911857818ff8"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("35a3ca8b-10a8-4f9c-a674-10df7596196a"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("3f30ea71-fa99-447e-a4bf-bfaeac8c023e"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("400cac5e-17f7-495f-9fc7-fea89fb55436"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("46d12cf4-447c-45c6-9152-09c805a130dc"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("4c21793a-8ed3-4423-a250-5b275f1da57a"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("5141c064-341d-4000-a4dd-b1b118f018a3"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("52e0dede-f358-426f-9e92-d1bf53bc1533"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("5c8a5d81-433f-4dbc-96cb-2d6ac6441fd0"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("5e0cee56-7817-4b3f-9082-cae4c1cc8ab8"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("6058c372-d3fd-42c3-a36c-0e02390b10ec"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("64b934ad-b7c1-41df-b31a-a41f77345ae0"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("6521a6fd-2bc1-4506-bd08-0dcf622f08f6"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("65436792-a82b-4866-bf00-a58377ea34c3"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("6ce9fa7b-c945-4849-8488-ead59c927d89"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("7a0a8fe3-4275-470d-804d-f118a5cc645f"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("819fceff-052b-424e-8e30-15a8b8f03312"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("84812609-1487-4a5d-a91c-1694db1f92f8"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("8b55f685-15b4-41c3-927b-7caddd2dd7d3"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("8e3771c3-eac3-415b-be7c-5c8054067bd0"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("902899fe-ff72-4a36-85f7-7f3b41d43d8d"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("93bcfba5-1acd-4fd1-a3e5-36bfdb766dd3"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("9aeabb91-48ea-4f35-9974-b19defba6875"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("a229abd1-1f9c-47c0-ba99-fa5d445e211f"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("a28f98d9-da50-4b39-b4ce-99368cacbf8e"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("a299d777-8892-4ef3-8940-d6baab92e52a"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("ac1b6e0c-9d0e-483e-a770-de9daf07839f"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("b75c4d58-d75c-4fb9-9c57-703111632fec"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("bc18f482-1a4f-48a4-ae75-0d1a27429ea5"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("bf7dc00c-05cc-4bfa-ae36-925adc457e42"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("c959f267-3790-4b14-8b81-82c91c2f6dc2"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("d47e29b6-602e-40eb-8003-35ba92cd18a9"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("d6e6dbfa-e980-4ec5-8d85-58f738f92085"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("dab90c01-5204-49fc-8e06-bf149dc685e4"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("e79f7e7f-b437-4baf-b5e5-4f001c63a591"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("e939f82c-48f6-483d-a492-11224fbe0c64"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("ee0cd406-b6e4-4f3f-8855-ed258a81bb1f"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("f4badeb4-b9b7-41bb-ab4a-82fa806aa0e7"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("f957e860-cacb-43c6-a86f-59452808a38c"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("f95a46b5-c00c-433b-a2d8-589e60de2491"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("ffe12852-f463-4c2e-8435-5778be1ab62b"));

		migrationBuilder.DeleteData(
			table: "instructors",
			keyColumn: "id",
			keyValue: new Guid("e2043c4b-d5b8-4ec1-adb3-a5e75474b715"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("8de581ab-0209-4bfd-bee0-32fa4c12e6b3"));

		migrationBuilder.RenameTable(
			name: "course_categories",
			newName: "course_ategories");

		migrationBuilder.RenameColumn(
			name: "course_id",
			table: "modules",
			newName: "courseid");

		migrationBuilder.RenameIndex(
			name: "ix_modules_course_id",
			table: "modules",
			newName: "ix_modules_courseid");

		migrationBuilder.RenameIndex(
			name: "ix_course_categories_course_id",
			table: "course_ategories",
			newName: "ix_course_ategories_course_id");

		migrationBuilder.RenameIndex(
			name: "ix_course_categories_category_id",
			table: "course_ategories",
			newName: "ix_course_ategories_category_id");

		migrationBuilder.AlterColumn<Guid>(
			name: "courseid",
			table: "modules",
			type: "uuid",
			nullable: true,
			oldClrType: typeof(Guid),
			oldType: "uuid");

		migrationBuilder.AddPrimaryKey(
			name: "pk_course_ategories",
			table: "course_ategories",
			column: "id");

		migrationBuilder.InsertData(
			table: "subscription_plans",
			columns: new[] { "id", "created_at", "description", "months", "price" },
			values: new object[,]
			{
				{ new Guid("13c526f8-1340-41eb-a42e-b8c46eb432a6"), new DateTime(2024, 6, 1, 10, 49, 14, 479, DateTimeKind.Local).AddTicks(2238), "Free", 0, 0f },
				{ new Guid("330dc11c-fb7f-496d-9288-b41d40a897b3"), new DateTime(2024, 6, 1, 10, 49, 14, 479, DateTimeKind.Local).AddTicks(2246), "Mensal", 1, 35f },
				{ new Guid("7d0658a0-290e-4de0-8213-845c026f6e52"), new DateTime(2024, 6, 1, 10, 49, 14, 479, DateTimeKind.Local).AddTicks(2254), "Anual", 1, 399.99f }
			});

		migrationBuilder.InsertData(
			table: "users",
			columns: new[] { "id", "cpf", "created_at", "email", "is_active", "name", "password", "phone" },
			values: new object[,]
			{
				{ new Guid("023f489c-82e4-42cb-bba4-d522a1f9a890"), 91841563501.0, new DateTime(2024, 6, 1, 10, 49, 13, 895, DateTimeKind.Local).AddTicks(4389), "Maite_Reis@yahoo.com", true, "Roberto Santos", "$2a$11$NYr2Nm6yLVlErYVj8z053uTCvUsR.fPhD0IkhVV01EyqpfdgXNEpK", 31320878897.0 },
				{ new Guid("0529c9cf-7fff-4fc5-afcd-298cc0358ad8"), 18879326155.0, new DateTime(2024, 6, 1, 10, 49, 10, 273, DateTimeKind.Local).AddTicks(7067), "Felipe.Martins@gmail.com", true, "Rebeca Macedo", "$2a$11$eMq5wyne2y5a/d3rITJ5DuYWKap1sZOgeA0o1PgmBv2maM.A..nEW", 78789884965.0 },
				{ new Guid("085c8b7b-6bc3-49c5-8b6d-160e30008eae"), 64533712002.0, new DateTime(2024, 6, 1, 10, 49, 10, 40, DateTimeKind.Local).AddTicks(3934), "Isabella.Santos@gmail.com", true, "Emanuel Melo", "$2a$11$0vetKFKwEytMJhDHbKhUsOOEKO12Jt9tXr.eE.mz11PVuxDy5FFR.", 552915101422.0 },
				{ new Guid("0e2858df-3931-4c99-ad72-3b90c4184629"), 64412016668.0, new DateTime(2024, 6, 1, 10, 49, 9, 223, DateTimeKind.Local).AddTicks(1864), "Nubia_Batista19@gmail.com", true, "Helena Oliveira", "$2a$11$DIwmIYPOhUwVAg4eEhNQS.HrC4mdoaJ8UAMJHgBJdQZqhxXz7JBZK", 553944617502.0 },
				{ new Guid("107375ad-0a39-4304-8781-d048f4770b17"), 3285198397.0, new DateTime(2024, 6, 1, 10, 49, 11, 675, DateTimeKind.Local).AddTicks(8257), "JoaoPedro39@yahoo.com", true, "Rafaela Xavier", "$2a$11$iR/t6XED4SssyOvswRDRCOD1LV.yKLsAfdqLQyHmBnDJRbkHscn2a", 95573215187.0 },
				{ new Guid("111f0150-db58-44e9-9cec-938aba838877"), 15893123506.0, new DateTime(2024, 6, 1, 10, 49, 8, 637, DateTimeKind.Local).AddTicks(8926), "Gubio.Silva@gmail.com", true, "Feliciano Albuquerque", "$2a$11$dt7uvhPKvHBgs/XuFK2G6OpcV/XhAlatZDBHTm63jnZjaBRxezLle", 1847596099.0 },
				{ new Guid("11819b43-15b9-4b10-b98b-699fb95882d7"), 35022243156.0, new DateTime(2024, 6, 1, 10, 49, 14, 129, DateTimeKind.Local).AddTicks(97), "Celia97@bol.com.br", true, "Marcela Saraiva", "$2a$11$a/ITA.ADoiIj2rFDg4w2Y.gfjNev29.XYNRGsspkWGBURXdPOTWQa", 553231223803.0 },
				{ new Guid("13d7ec9f-7e75-4fc5-afb5-2ae8dee29417"), 27194312816.0, new DateTime(2024, 6, 1, 10, 49, 13, 311, DateTimeKind.Local).AddTicks(7722), "Lorena34@yahoo.com", true, "Miguel Albuquerque", "$2a$11$VGsucjFnMEvJUh0HZ6N/4.AMs6UIMl1/VdEdQdICrC.7LDGuCXhgu", 1799511777.0 },
				{ new Guid("19ba5eda-5d83-4954-a980-f3a3eb749721"), 32200733526.0, new DateTime(2024, 6, 1, 10, 49, 14, 245, DateTimeKind.Local).AddTicks(7629), "Julio57@bol.com.br", true, "Warley Martins", "$2a$11$58MWXSd1j0B/f9TEMjZJ/eYHdvW2ckE.BiGGY0OjoIGHCbpI5FBjW", 551369873242.0 },
				{ new Guid("23760e3e-13ad-421d-9071-7abebb03130f"), 8979903901.0, new DateTime(2024, 6, 1, 10, 49, 11, 442, DateTimeKind.Local).AddTicks(1951), "Carla76@gmail.com", true, "Carla Saraiva", "$2a$11$NaNn5Loqw.q9au.0mH6mOugjjOlbLtyyS2Zf1o18Lrl/uN7rqaLum", 6365847289.0 },
				{ new Guid("264a9577-e7d7-4324-9d21-cfab5dbf1489"), 76473744860.0, new DateTime(2024, 6, 1, 10, 49, 13, 544, DateTimeKind.Local).AddTicks(9368), "Ofelia.Moreira16@gmail.com", true, "Lavínia Moraes", "$2a$11$SBaWW2RycXoD5HO0CvW6.uD7JGZVwXYYL/8hf955zc5xPlqnU9Vku", 5402849288.0 },
				{ new Guid("2776b456-c766-48eb-95e2-d64dcf52eac3"), 52597925480.0, new DateTime(2024, 6, 1, 10, 49, 9, 923, DateTimeKind.Local).AddTicks(5747), "Antonella75@yahoo.com", true, "Lorena Braga", "$2a$11$0EZQy1f4GWwYtRCQCbB3x.JCbZ0mJH5Yvj8eOsIH24EleVLNu3eV6", 8615903247.0 },
				{ new Guid("2961b926-355a-48c5-a0a3-1d06c0a1a912"), 49364543890.0, new DateTime(2024, 6, 1, 10, 49, 9, 456, DateTimeKind.Local).AddTicks(4458), "Bernardo_Carvalho@gmail.com", true, "Natália Moreira", "$2a$11$nvZG.2x3evAbAsUFCmSMXuh02UBXVze4jJmy5VsjetXmCCLjAZuxW", 554123350742.0 },
				{ new Guid("34e4e05d-805b-4700-b433-8d7d2d8b7f56"), 68807365723.0, new DateTime(2024, 6, 1, 10, 49, 10, 157, DateTimeKind.Local).AddTicks(1459), "Enzo98@yahoo.com", true, "Maria Nogueira", "$2a$11$S2oUorXV9UzgVnNcQ4OUfefp8Ld/KCQPZ/5u0QNqdwTGgEJEVWoY2", 552814895823.0 },
				{ new Guid("34ffc11c-3b18-41f9-9e6f-9788567b7d8e"), 71981610650.0, new DateTime(2024, 6, 1, 10, 49, 13, 78, DateTimeKind.Local).AddTicks(3393), "Marcos_Xavier@gmail.com", true, "Caio Moreira", "$2a$11$86AXQtubtxgOxVXyYFZlwO45vBAytUVYuaHE6YoI8/whMCrQ7qgZm", 93609655442.0 },
				{ new Guid("39352718-d523-4ca9-b4b2-b75a7936be9a"), 52572968371.0, new DateTime(2024, 6, 1, 10, 49, 10, 507, DateTimeKind.Local).AddTicks(1732), "Ladislau57@hotmail.com", true, "Enzo Reis", "$2a$11$yAD2xuYJ.jMwbO9dcElWluRDm6Asc5PJIi6OtlQGHYdLx8PDRGz1u", 7131570833.0 },
				{ new Guid("39a7d6d5-7b69-495a-9367-2e27663a9733"), 99583298832.0, new DateTime(2024, 6, 1, 10, 49, 12, 611, DateTimeKind.Local).AddTicks(5055), "Pablo.Xavier26@live.com", true, "Liz Reis", "$2a$11$ngSGNHAZojOh6HAOc9VvZOl0cf2jPi.SNLKIYSLEYWU1T/NFJAxAq", 46842241881.0 },
				{ new Guid("3a798bb8-d883-4fb0-a84d-0064edb34ce5"), 53537158459.0, new DateTime(2024, 6, 1, 10, 49, 11, 909, DateTimeKind.Local).AddTicks(4024), "MariaJulia.Melo51@yahoo.com", true, "Valentina Melo", "$2a$11$H5t/E72P.VhcuyT3M6HwO.iqXOfurveGX2m/IfZh0fqcxeWkNqike", 8075529992.0 },
				{ new Guid("448a581c-e346-44d5-aa15-9b8a333aee6c"), 44504509571.0, new DateTime(2024, 6, 1, 10, 49, 9, 105, DateTimeKind.Local).AddTicks(9546), "Caio.Santos@yahoo.com", true, "Guilherme Carvalho", "$2a$11$4Yp4DF71hpIS33jWiaMIeuVTL5ZxsuRie9fMYs3ECLDnCu5oeQoIi", 97922354513.0 },
				{ new Guid("44bd8a10-4c59-4eb0-bb0e-fe990b353b0a"), 70634847104.0, new DateTime(2024, 6, 1, 10, 49, 11, 325, DateTimeKind.Local).AddTicks(5650), "Roberta_Melo63@yahoo.com", true, "Isis Nogueira", "$2a$11$gWrjup/mLXpvNPsgCoe/BOk1wLXUCQeZfB9QE/ZJEdtVk2XWEjUKW", 555180035400.0 },
				{ new Guid("44d797be-5406-4456-a294-b0c1339f0c7e"), 95710413356.0, new DateTime(2024, 6, 1, 10, 49, 10, 624, DateTimeKind.Local).AddTicks(1077), "Elisio.Pereira@yahoo.com", true, "Alícia Melo", "$2a$11$iqR2L2Dp/1ez5K6vvs7iouad8tEO9vBYtaJWy.UWGfYli1mZTplZW", 554583208435.0 },
				{ new Guid("489eebd1-b65f-4131-a5cc-5738f25ed6d6"), 1652733566.0, new DateTime(2024, 6, 1, 10, 49, 12, 961, DateTimeKind.Local).AddTicks(6744), "MariaClara69@live.com", true, "Lorena Macedo", "$2a$11$7.Ryogf8krUXeEknUJ4KQ.aB1.Pz6N/FyGuc0fxb1zBz9J2u/ozOG", 60028949260.0 },
				{ new Guid("4cd935a4-f0df-4f3a-9a62-fe06f1d4b064"), 3868807438.0, new DateTime(2024, 6, 1, 10, 49, 10, 390, DateTimeKind.Local).AddTicks(3963), "Vicente_Santos67@bol.com.br", true, "Ana Clara Barros", "$2a$11$DxcogLt/Lk4tBRPCastYfOdtZ9Q6C9mDw/Jv1Yf/vA9a/0UjSIjbK", 6486870016.0 },
				{ new Guid("51f48c2d-e8c6-4cd6-8bd7-09c3b95b9ba7"), 18416455678.0, new DateTime(2024, 6, 1, 10, 49, 12, 143, DateTimeKind.Local).AddTicks(3944), "Ricardo70@gmail.com", true, "Felícia Xavier", "$2a$11$vxkNk1194N.NXOahaPytvOYlwdTB1HiKcLpevrpLCKNrTqsB2dipe", 556821742974.0 },
				{ new Guid("53a5c92b-643c-4cbe-8420-df2ed90549b3"), 7146101606.0, new DateTime(2024, 6, 1, 10, 49, 9, 573, DateTimeKind.Local).AddTicks(793), "Ricardo.Santos@gmail.com", true, "Emanuelly Macedo", "$2a$11$9nC2XslkSRakcGvQSysBKuKHVb8HJSp2uZV9cLdJUs4OK1hAQYGXa", 4592812946.0 },
				{ new Guid("604509c3-147f-4b65-9043-69b18b1813f0"), 7478169139.0, new DateTime(2024, 6, 1, 10, 49, 13, 778, DateTimeKind.Local).AddTicks(3068), "Isabelly_Martins@bol.com.br", true, "Márcia Silva", "$2a$11$yMIWEGWOufHZjmi7iDQ1Q.drBuSNG/zl/xbq74PBfT5HCVDt.i/Vy", 551054306958.0 },
				{ new Guid("65a4d6fc-b737-46a2-bbd1-16c949768825"), 36858829539.0, new DateTime(2024, 6, 1, 10, 49, 11, 208, DateTimeKind.Local).AddTicks(8734), "Meire52@live.com", true, "Alessandra Costa", "$2a$11$8WYCLqN0BMJx28X.o8kT7uLf7p8OmzAS2/FR5j.c/rI5WG4iGp9hW", 62952333903.0 },
				{ new Guid("6faf95e0-dd4a-48b1-b33a-1ffc34d21441"), 90912366478.0, new DateTime(2024, 6, 1, 10, 49, 12, 26, DateTimeKind.Local).AddTicks(4337), "Silas7@hotmail.com", true, "Rafaela Pereira", "$2a$11$9cmNISpNDes8TxN8TQ9zPeKzNkmXuHFnn8fnipo.7W.DNjygnKtDq", 1880819735.0 },
				{ new Guid("799b0e7c-55c3-4e71-a25e-eab6d04f2858"), 49518280223.0, new DateTime(2024, 6, 1, 10, 49, 8, 988, DateTimeKind.Local).AddTicks(8608), "AnaLaura_Xavier@bol.com.br", true, "Maria Alice Souza", "$2a$11$9aJ603O3hWFWg.j7BnAVFObGtKTY4mVSgBVMAovuekPqcnaaSL8qu", 90057802197.0 },
				{ new Guid("7e1bef5a-6213-4763-baaa-041ba1fbc1d7"), 38068549471.0, new DateTime(2024, 6, 1, 10, 49, 10, 857, DateTimeKind.Local).AddTicks(4348), "Roberta84@live.com", true, "Bryan Oliveira", "$2a$11$q4On46GPC/HHtP3WeckjAeDoE/8RL.kdsE5xKLnMcXvN6FXhvZBom", 556341028930.0 },
				{ new Guid("808b31ce-41a3-4c24-b221-aca9f44016b3"), 3240115476.0, new DateTime(2024, 6, 1, 10, 49, 11, 559, DateTimeKind.Local).AddTicks(87), "Leonardo67@yahoo.com", true, "Antonella Reis", "$2a$11$doiBSP87EdYoEiZLE8yb0uFNP7WFXXjO9aaqojXjCybl4XtD9U2cq", 19187602867.0 },
				{ new Guid("828039a1-d150-4cb7-9886-330713e8cde2"), 91487108656.0, new DateTime(2024, 6, 1, 10, 49, 11, 92, DateTimeKind.Local).AddTicks(1312), "Bernardo47@hotmail.com", true, "João Lucas Melo", "$2a$11$0iEetbjvHJud7zhdhEzdc.DiMnvvbtwnvNr4OCyYRKyi0RYAPJw0y", 46070270638.0 },
				{ new Guid("893fcd6a-5920-4fd6-b782-bd5be77f5610"), 88387103926.0, new DateTime(2024, 6, 1, 10, 49, 12, 494, DateTimeKind.Local).AddTicks(8780), "MariaHelena_Carvalho@yahoo.com", true, "Ana Clara Moreira", "$2a$11$zDE1lEK2G0UPgoBvHNUAje9Nm06ZkWAT4u3C9db3z6rM9ronQmN4a", 36302679445.0 },
				{ new Guid("918a1288-aee4-48fb-b919-550be6beee98"), 27370027023.0, new DateTime(2024, 6, 1, 10, 49, 9, 806, DateTimeKind.Local).AddTicks(7830), "Natalia_Silva@bol.com.br", true, "Maria Carvalho", "$2a$11$I/lf43E4mCW9jsVrQbDbX.8yUzS4ZJZE6RdDq/O2BRi1wmqzfhfNO", 554263380152.0 },
				{ new Guid("9ac15346-2262-4983-b1c0-2520895b8e38"), 60194064905.0, new DateTime(2024, 6, 1, 10, 49, 9, 689, DateTimeKind.Local).AddTicks(9356), "Henrique.Moraes56@live.com", true, "Pietro Saraiva", "$2a$11$0oWWveAgBMWrWUYN/nFp0eCbuiIZV0214rPyxMkG4L5eqQFzb9nMK", 82991166922.0 },
				{ new Guid("a0cd559f-efe5-4ea0-b116-d312a1c53d7a"), 89889023946.0, new DateTime(2024, 6, 1, 10, 49, 9, 339, DateTimeKind.Local).AddTicks(9191), "Pedro_Batista82@bol.com.br", true, "Fabrício Silva", "$2a$11$6LMmNcD0K3eoaftXTsWHWe/R4Rum6Z8BYZ.HgtEpGjk9.HrBTBxX6", 4923730802.0 },
				{ new Guid("a268a632-c679-4a9e-b1cd-ed6127255230"), 88137564888.0, new DateTime(2024, 6, 1, 10, 49, 8, 754, DateTimeKind.Local).AddTicks(8258), "Isadora.Saraiva@yahoo.com", true, "Maria Helena Albuquerque", "$2a$11$eZLXLndn1e9Yjy2rUIfCcue.T/bAtw/sxNaHVS7lhHv5CogcLcSSO", 6127437075.0 },
				{ new Guid("a5289d71-1d84-46f1-82d2-3e9ef6113bf7"), 25805010372.0, new DateTime(2024, 6, 1, 10, 49, 10, 975, DateTimeKind.Local).AddTicks(1906), "Marcos.Martins30@bol.com.br", true, "Nicolas Xavier", "$2a$11$D4cFM4OW60ve67ZUUQbCIOt9qvYSfm28q.mJrNH3lKU2P6QBAisk6", 3539223007.0 },
				{ new Guid("ac63d553-a3ab-4a61-9b9b-5b74bf8631af"), 34646687976.0, new DateTime(2024, 6, 1, 10, 49, 8, 871, DateTimeKind.Local).AddTicks(9997), "Raul.Macedo84@bol.com.br", true, "Janaína Nogueira", "$2a$11$yXgD1DJiivDZcdWmexIbnuSiX51gaPoDWgZ.F4R4AC8xFW0/p7bo2", 9297037096.0 },
				{ new Guid("ad07470b-9465-4654-bb56-dfda4d87c3cb"), 22993138936.0, new DateTime(2024, 6, 1, 10, 49, 12, 378, DateTimeKind.Local).AddTicks(2799), "Marcelo30@hotmail.com", true, "Felícia Batista", "$2a$11$gbAE1RHmDk8yssB3nxyJpOR7y2UwhI8wvSh1Cv8M2aoJVHnWmv5ae", 6886531208.0 },
				{ new Guid("afcdd85c-10ad-45d7-a268-679d741bad66"), 76289735748.0, new DateTime(2024, 6, 1, 10, 49, 14, 12, DateTimeKind.Local).AddTicks(2976), "Pablo3@hotmail.com", true, "Alice Barros", "$2a$11$BSEyBuVQ/jf5fTgVuEM76Ovyc6wjKpGGBGneu51sUUYDtHt9yZS0y", 8828529928.0 },
				{ new Guid("cf74d782-c506-4fd7-b57a-309dd43753e4"), 123456789.0, new DateTime(2024, 6, 1, 10, 49, 14, 479, DateTimeKind.Local).AddTicks(905), "professor@preofessor.com", true, "instrutor 1", "$2a$11$z.dzTZlNWPyvKwVK8IQDVOZpFXQ.6bbejGP3PEDMFMNlCz7N9es2O", 123456789.0 },
				{ new Guid("d534865e-d1d8-4780-ab90-44dbf5e4399e"), 78886224109.0, new DateTime(2024, 6, 1, 10, 49, 12, 845, DateTimeKind.Local).AddTicks(359), "Fabricia.Barros44@yahoo.com", true, "Maria Cecília Xavier", "$2a$11$uCmUEyKYnHGNkzYhvtmdVug.UVOfUGKvfMX0unz5pji9DC15qINoC", 557848364297.0 },
				{ new Guid("df2d345b-959f-42c5-b573-c940e10d5abc"), 81250174961.0, new DateTime(2024, 6, 1, 10, 49, 13, 428, DateTimeKind.Local).AddTicks(3669), "Gustavo2@live.com", true, "Murilo Reis", "$2a$11$/qnyaMYv7rjc6ryltk9GeeHdNze2THMxIdkalREIW4zp4fslmUP9C", 680157182.0 },
				{ new Guid("e157b04a-2642-4723-b7fb-4a14877c3591"), 20604856652.0, new DateTime(2024, 6, 1, 10, 49, 13, 661, DateTimeKind.Local).AddTicks(5663), "Vitoria58@live.com", true, "Sara Barros", "$2a$11$NgBBTR5u6L5db/rUpHnrQ.jbI4lRDo31nNnmM1jZUgN34dGIlsVPq", 37581921680.0 },
				{ new Guid("e57af8a1-9a1f-4760-9e06-9629fb0f8844"), 70453696465.0, new DateTime(2024, 6, 1, 10, 49, 12, 728, DateTimeKind.Local).AddTicks(3253), "Melissa8@live.com", true, "Gúbio Pereira", "$2a$11$21L4450RFTFjC3jFLRUb1uOkQnqmq8uyXA3JnNa3DW.8A9iu9yqYC", 554200548954.0 },
				{ new Guid("ea26f5c3-a054-4caa-9ef8-fb3883e1e4ce"), 87118269328.0, new DateTime(2024, 6, 1, 10, 49, 10, 740, DateTimeKind.Local).AddTicks(7923), "Heloisa.Reis@bol.com.br", true, "Daniel Melo", "$2a$11$AYBY0hX6zImt6JcHKpY5puJTysdTD9h2jHCysBiml2lCJBG2lhDFq", 556413975747.0 },
				{ new Guid("ec3d2502-255a-426b-b417-3923c8977554"), 35391153158.0, new DateTime(2024, 6, 1, 10, 49, 12, 260, DateTimeKind.Local).AddTicks(7243), "Joaquim99@bol.com.br", true, "Alice Carvalho", "$2a$11$IoUsmCWI2Ha3T84ZkgSRYOdb5/fWpflan1YgCTjDg6rj4Nj6nPcZG", 20566982224.0 },
				{ new Guid("ed36995e-a468-4e50-ad74-b6664d747994"), 57384090270.0, new DateTime(2024, 6, 1, 10, 49, 8, 520, DateTimeKind.Local).AddTicks(4393), "Esther.Braga@yahoo.com", true, "Enzo Gabriel Pereira", "$2a$11$PM/BXokowvi3Iak7gcqIFOy17CgfFqFQoP1o8Ujh2taJ0uh2gHySq", 8967714982.0 },
				{ new Guid("f479f204-c514-4274-84dc-75cd111ed519"), 77988078615.0, new DateTime(2024, 6, 1, 10, 49, 11, 792, DateTimeKind.Local).AddTicks(6224), "MariaJulia70@hotmail.com", true, "Meire Melo", "$2a$11$Femd/nnm.XElZxIToVMSwe9rpfUnUPzN9BlmMN4tLhSjd1lqJRcB6", 550941499494.0 },
				{ new Guid("f9e2e7db-4b4b-47c5-83f4-876adb1cac0f"), 123456789.0, new DateTime(2024, 6, 1, 10, 49, 14, 362, DateTimeKind.Local).AddTicks(5078), "admin@admin", true, "Admin", "$2a$11$RxjWWlJEEJ2eYOuTls70BuSJrPHYkiS/scNLaDILceB/dasgzQt0i", 123456789.0 },
				{ new Guid("fb841448-84a7-4a54-bd09-b1b79166f9fe"), 60863356990.0, new DateTime(2024, 6, 1, 10, 49, 13, 195, DateTimeKind.Local).AddTicks(1253), "Nataniel_Santos@yahoo.com", true, "Gúbio Martins", "$2a$11$1lWJ2w71Scxkmz6UnOofaOgCAAovRUuLldJbRDpzgCelv43TMnR3C", 555362650512.0 }
			});

		migrationBuilder.InsertData(
			table: "admins",
			columns: new[] { "id", "user_id" },
			values: new object[] { new Guid("9062972e-5c16-4ce6-a79a-5d6428e9d95f"), new Guid("f9e2e7db-4b4b-47c5-83f4-876adb1cac0f") });

		migrationBuilder.InsertData(
			table: "instructors",
			columns: new[] { "id", "github", "social_network", "user_id" },
			values: new object[] { new Guid("b8ccf4dc-da9a-4e03-a79a-3b304456e192"), null, null, new Guid("cf74d782-c506-4fd7-b57a-309dd43753e4") });

		migrationBuilder.AddForeignKey(
			name: "fk_course_ategories_categories_category_id",
			table: "course_ategories",
			column: "category_id",
			principalTable: "categories",
			principalColumn: "id",
			onDelete: ReferentialAction.Cascade);

		migrationBuilder.AddForeignKey(
			name: "fk_course_ategories_courses_course_id",
			table: "course_ategories",
			column: "course_id",
			principalTable: "courses",
			principalColumn: "id",
			onDelete: ReferentialAction.Cascade);

		migrationBuilder.AddForeignKey(
			name: "fk_modules_courses_courseid",
			table: "modules",
			column: "courseid",
			principalTable: "courses",
			principalColumn: "id");
	}
}
