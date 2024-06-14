using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GenericCourses.Infra.Persistence.Migrations;
/// <inheritdoc />
public partial class betterCategories : Migration {
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder) {
		migrationBuilder.DropForeignKey(
			name: "fk_categories_blog_posts_blog_post_id",
			table: "categories");

		migrationBuilder.DropForeignKey(
			name: "fk_categories_courses_course_id",
			table: "categories");

		migrationBuilder.DropIndex(
			name: "ix_categories_blog_post_id",
			table: "categories");

		migrationBuilder.DropIndex(
			name: "ix_categories_course_id",
			table: "categories");

		migrationBuilder.DropColumn(
			name: "blog_post_id",
			table: "categories");

		migrationBuilder.DropColumn(
			name: "course_id",
			table: "categories");

		migrationBuilder.AlterColumn<double>(
			name: "phone",
			table: "users",
			type: "double precision",
			nullable: true,
			oldClrType: typeof(int),
			oldType: "integer",
			oldNullable: true);

		migrationBuilder.AlterColumn<double>(
			name: "cpf",
			table: "users",
			type: "double precision",
			nullable: false,
			oldClrType: typeof(int),
			oldType: "integer");

		migrationBuilder.CreateTable(
			name: "course_ategories",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				course_id = table.Column<Guid>(type: "uuid", nullable: false),
				category_id = table.Column<Guid>(type: "uuid", nullable: false)
			},
			constraints: table => {
				table.PrimaryKey("pk_course_ategories", x => x.id);
				table.ForeignKey(
					name: "fk_course_ategories_categories_category_id",
					column: x => x.category_id,
					principalTable: "categories",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
				table.ForeignKey(
					name: "fk_course_ategories_courses_course_id",
					column: x => x.course_id,
					principalTable: "courses",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateTable(
			name: "post_categories",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				blog_post_id = table.Column<Guid>(type: "uuid", nullable: false),
				category_id = table.Column<Guid>(type: "uuid", nullable: false)
			},
			constraints: table => {
				table.PrimaryKey("pk_post_categories", x => x.id);
				table.ForeignKey(
					name: "fk_post_categories_blog_posts_blog_post_id",
					column: x => x.blog_post_id,
					principalTable: "blog_posts",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
				table.ForeignKey(
					name: "fk_post_categories_categories_category_id",
					column: x => x.category_id,
					principalTable: "categories",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
			});

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

		migrationBuilder.CreateIndex(
			name: "ix_course_ategories_category_id",
			table: "course_ategories",
			column: "category_id");

		migrationBuilder.CreateIndex(
			name: "ix_course_ategories_course_id",
			table: "course_ategories",
			column: "course_id");

		migrationBuilder.CreateIndex(
			name: "ix_post_categories_blog_post_id",
			table: "post_categories",
			column: "blog_post_id");

		migrationBuilder.CreateIndex(
			name: "ix_post_categories_category_id",
			table: "post_categories",
			column: "category_id");
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder) {
		migrationBuilder.DropTable(
			name: "course_ategories");

		migrationBuilder.DropTable(
			name: "post_categories");

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

		migrationBuilder.AlterColumn<int>(
			name: "phone",
			table: "users",
			type: "integer",
			nullable: true,
			oldClrType: typeof(double),
			oldType: "double precision",
			oldNullable: true);

		migrationBuilder.AlterColumn<int>(
			name: "cpf",
			table: "users",
			type: "integer",
			nullable: false,
			oldClrType: typeof(double),
			oldType: "double precision");

		migrationBuilder.AddColumn<Guid>(
			name: "blog_post_id",
			table: "categories",
			type: "uuid",
			nullable: true);

		migrationBuilder.AddColumn<Guid>(
			name: "course_id",
			table: "categories",
			type: "uuid",
			nullable: true);

		migrationBuilder.CreateIndex(
			name: "ix_categories_blog_post_id",
			table: "categories",
			column: "blog_post_id");

		migrationBuilder.CreateIndex(
			name: "ix_categories_course_id",
			table: "categories",
			column: "course_id");

		migrationBuilder.AddForeignKey(
			name: "fk_categories_blog_posts_blog_post_id",
			table: "categories",
			column: "blog_post_id",
			principalTable: "blog_posts",
			principalColumn: "id");

		migrationBuilder.AddForeignKey(
			name: "fk_categories_courses_course_id",
			table: "categories",
			column: "course_id",
			principalTable: "courses",
			principalColumn: "id");
	}
}
