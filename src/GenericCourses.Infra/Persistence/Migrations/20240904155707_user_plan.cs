using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GenericCourses.Infra.Persistence.Migrations; 
/// <inheritdoc />
public partial class user_plan : Migration {
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder) {
		migrationBuilder.DropForeignKey(
			name: "fk_clients_subscription_plans_subscriptionplan_id",
			table: "clients");

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

		migrationBuilder.RenameColumn(
			name: "subscriptionplan_id",
			table: "clients",
			newName: "subscriptionplanid");

		migrationBuilder.RenameIndex(
			name: "ix_clients_subscriptionplan_id",
			table: "clients",
			newName: "ix_clients_subscriptionplanid");

		migrationBuilder.AddColumn<Guid>(
			name: "admin_id",
			table: "subscription_plans",
			type: "uuid",
			nullable: false,
			defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

		migrationBuilder.AddColumn<Guid>(
			name: "user_id",
			table: "categories",
			type: "uuid",
			nullable: false,
			defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

		migrationBuilder.CreateTable(
			name: "user_plan",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				client_id = table.Column<Guid>(type: "uuid", nullable: false),
				subscriptionplan_id = table.Column<Guid>(type: "uuid", nullable: false),
				created_at = table.Column<DateTime>(type: "Date", nullable: false),
				is_active = table.Column<bool>(type: "boolean", nullable: false)
			},
			constraints: table => {
				table.PrimaryKey("pk_user_plan", x => x.id);
				table.ForeignKey(
					name: "fk_user_plan_clients_client_id",
					column: x => x.client_id,
					principalTable: "clients",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
				table.ForeignKey(
					name: "fk_user_plan_subscription_plans_subscriptionplan_id",
					column: x => x.subscriptionplan_id,
					principalTable: "subscription_plans",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.InsertData(
			table: "users",
			columns: new[] { "id", "cpf", "created_at", "email", "is_active", "name", "password", "phone" },
			values: new object[,]
			{
				{ new Guid("008dc7ec-0856-4ec5-8172-156693391ac5"), 98578941004.0, new DateTime(2024, 9, 4, 12, 56, 59, 355, DateTimeKind.Local).AddTicks(8548), "Joao26@yahoo.com", true, "Melissa Santos", "$2a$11$w2FiHFe5TMy3qbuPZvLkEe9kG0lIkzW59irlER8TVP7ukvHPSRVsG", 554737070728.0 },
				{ new Guid("011c4d40-a69b-42d3-9909-fad2863e9244"), 32330832540.0, new DateTime(2024, 9, 4, 12, 57, 5, 625, DateTimeKind.Local).AddTicks(3465), "Paulo_Franco42@live.com", true, "Gael Santos", "$2a$11$kdVzTx4tcy1FzW20xHOxeOluknfoPOGaz3gz1Hvv.cmOga.sHKM4.", 69227858658.0 },
				{ new Guid("018fe328-ec3f-4f3b-acbb-68fc263d8293"), 3809790206.0, new DateTime(2024, 9, 4, 12, 56, 59, 180, DateTimeKind.Local).AddTicks(704), "MariaCecilia_Costa5@live.com", true, "Antonella Moraes", "$2a$11$V53WcXGyhT67kv13YhfW8OIs9ZQ2zWYfcYmWyS8/bsk9e2c5PNTg.", 510580837.0 },
				{ new Guid("019542c4-3cc6-42b3-9845-fd6912b84a12"), 4335126441.0, new DateTime(2024, 9, 4, 12, 56, 59, 682, DateTimeKind.Local).AddTicks(7608), "Julia.Batista@hotmail.com", true, "Lorraine Franco", "$2a$11$4e93AJwhZY22Ybb.v0F0F.DoVum.f16zJaGdKo1a6/BhTEZFW6Kvi", 558424379012.0 },
				{ new Guid("048114ab-e8cf-4a9c-80ba-5573ef005e39"), 98293342102.0, new DateTime(2024, 9, 4, 12, 57, 3, 277, DateTimeKind.Local).AddTicks(2531), "Gubio47@hotmail.com", true, "Washington Xavier", "$2a$11$apEPs8aWyVwl8YgFFeSHquXHzYgimXjWzeBweIOG90XL8emRXGfKq", 6501753631.0 },
				{ new Guid("04c12160-bad6-45ce-903a-67d1afeffe72"), 123456789.0, new DateTime(2024, 9, 4, 12, 57, 6, 713, DateTimeKind.Local).AddTicks(7117), "admin@admin", true, "Admin", "$2a$11$94C93v89bPF6GaHgOeNoWO1ktRQoaSU4kU0HHUlWg0RhXOWhNozVq", 123456789.0 },
				{ new Guid("08d25560-04ea-4b27-9c1e-000d1258ef52"), 73441230701.0, new DateTime(2024, 9, 4, 12, 57, 2, 505, DateTimeKind.Local).AddTicks(7056), "Isadora.Franco@hotmail.com", true, "Frederico Martins", "$2a$11$Su8709JbkLxDNIW2jiaTDOpuncXDuPfEJTl5aR0RzYC0EC4fGj0aW", 6460588703.0 },
				{ new Guid("0d9553dc-8712-4935-8f64-089039406388"), 63584172071.0, new DateTime(2024, 9, 4, 12, 57, 2, 42, DateTimeKind.Local).AddTicks(2761), "Heitor17@live.com", true, "Cauã Santos", "$2a$11$qy2tSqdXks.UivRiJNnNHecd3eRquTlrxMmQNAvpjXrAXI.qnd8We", 22257632304.0 },
				{ new Guid("10a0f2ad-9c7a-4af6-b5b1-c2a842ff8cce"), 57934523629.0, new DateTime(2024, 9, 4, 12, 57, 0, 634, DateTimeKind.Local).AddTicks(6306), "Lavinia_Moraes@gmail.com", true, "Cecília Martins", "$2a$11$uxrN6/KSJdYypHo4EBX1n.X3iBCr3/y6hDsYdhA8dsXRmIn2GYpX6", 554607143152.0 },
				{ new Guid("17813b34-21b2-4f1a-b6bc-bb4e2eb4b734"), 123456789.0, new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(4945), "professor@preofessor.com", true, "instrutor 1", "$2a$11$5UW8o5Z/NSHO9TOtCmN6Xucq2C7ts2EJnSPDuVudnDNhbwnP2tm7.", 123456789.0 },
				{ new Guid("178d1951-cdc1-45c3-a0c6-b65faad8fdf8"), 92744318213.0, new DateTime(2024, 9, 4, 12, 57, 5, 937, DateTimeKind.Local).AddTicks(1075), "Marli73@gmail.com", true, "Carla Saraiva", "$2a$11$fSicM8f6.Kq.FVxGiycqIOK04crfNlYEQPeWx2nDAjZwTUP1cAmJC", 7209343697.0 },
				{ new Guid("3600cb46-645a-4137-b510-046d732760d5"), 56384558254.0, new DateTime(2024, 9, 4, 12, 57, 4, 215, DateTimeKind.Local).AddTicks(2362), "Rebeca.Nogueira@live.com", true, "Yago Moreira", "$2a$11$1tBwPP5ZqGfOxpQT0fQRIe6qv9iiPcLjQRs/EhkdtB1uZAXmqaECi", 9803914779.0 },
				{ new Guid("3ed06120-2d6e-4545-9886-4a1b8845cc25"), 7061324597.0, new DateTime(2024, 9, 4, 12, 57, 1, 887, DateTimeKind.Local).AddTicks(7208), "Emanuel57@live.com", true, "Beatriz Nogueira", "$2a$11$rNCg65RhhI1NPibnhRKsseMoPR3SaNJgxpvJm7na04IdtbLZfGC0m", 556921754173.0 },
				{ new Guid("423f14af-de51-4112-b18e-54803c5d6792"), 4642163468.0, new DateTime(2024, 9, 4, 12, 57, 2, 968, DateTimeKind.Local).AddTicks(7288), "Janaina_Braga93@hotmail.com", true, "Luiza Franco", "$2a$11$he/sfkIiOp34OyrPOve1S.8DGqPEW4s0GsvaBPn20YbRx/3TOshRy", 75207483748.0 },
				{ new Guid("48a4658c-3a9e-4e54-ac58-8139db3a2f1c"), 58981246599.0, new DateTime(2024, 9, 4, 12, 57, 0, 314, DateTimeKind.Local).AddTicks(9410), "Morgana_Martins41@bol.com.br", true, "Cecília Macedo", "$2a$11$LLyvJ7ElcNfRbN28PQIsDeb6L47uIWVSXOmj5SGuCpkSQ2ku1Lj0G", 71947979542.0 },
				{ new Guid("4cebea30-5096-49c2-8cf0-f92f38185d96"), 58720555105.0, new DateTime(2024, 9, 4, 12, 57, 0, 793, DateTimeKind.Local).AddTicks(447), "Davi.Carvalho@live.com", true, "Enzo Oliveira", "$2a$11$OCRppzjMxVOlXoChnnUu..M1LjrEWRV0.Prvq4qvUvpO3KZlM9kZy", 7303033267.0 },
				{ new Guid("4f56575a-ac02-4702-a6d1-78e44039b62c"), 37261374245.0, new DateTime(2024, 9, 4, 12, 57, 3, 747, DateTimeKind.Local).AddTicks(1275), "Eloa.Souza43@live.com", true, "Maria Clara Moreira", "$2a$11$k10uceLPbNfcDhB68eXau.KKG79Mz8CRs.B6q89BExLrgoSdGgyBC", 553984100533.0 },
				{ new Guid("51b6adaa-504d-4be1-af50-63daf9f82922"), 94178070800.0, new DateTime(2024, 9, 4, 12, 57, 2, 659, DateTimeKind.Local).AddTicks(3537), "Caio34@gmail.com", true, "Sara Moraes", "$2a$11$cos8bKZNaX0UfFfZmQcKB.qE7wL1/OCQ11qCj1VI1sKAvb5YEzaIG", 551006970340.0 },
				{ new Guid("58538d27-2f94-44a6-b2fe-8a2c3993f7f5"), 31182344828.0, new DateTime(2024, 9, 4, 12, 57, 2, 195, DateTimeKind.Local).AddTicks(7553), "Maite59@gmail.com", true, "Paulo Moraes", "$2a$11$lwyPBCYqr59eSXbDmzSz9e9zR2nDN/McTWNpYx/TNw7JLcoablkpq", 554192284421.0 },
				{ new Guid("5bf4aa72-5fde-4328-8bcd-625391341d95"), 48489393214.0, new DateTime(2024, 9, 4, 12, 57, 5, 1, DateTimeKind.Local).AddTicks(5117), "Joaquim_Moreira97@hotmail.com", true, "Joana Carvalho", "$2a$11$EQpqIFoYqFvlcHpwmml5nOReIGx8/WmgreQ9hwhxRdnXv3jl47eRC", 7861502126.0 },
				{ new Guid("64590e25-be72-40d6-a3b2-bc8930b24a33"), 73098437464.0, new DateTime(2024, 9, 4, 12, 57, 5, 315, DateTimeKind.Local).AddTicks(794), "MariaAlice_Souza@bol.com.br", true, "Marina Reis", "$2a$11$/YgYwfIeE6GGoi0xFiioE.rSmHLIXneq1tUcDF1gLIMTVZZ5ZsQcG", 558954410676.0 },
				{ new Guid("66f11611-f3c4-499f-b8e0-bfa155ceadf9"), 1673733743.0, new DateTime(2024, 9, 4, 12, 57, 0, 475, DateTimeKind.Local).AddTicks(7915), "Deneval_Costa@gmail.com", true, "Lorenzo Silva", "$2a$11$80TecJzOJFOdheOw7xCLlOujGWQZYvJPwj8XsS1iJ5q2ZgHyZV8wy", 559479756525.0 },
				{ new Guid("694d0942-a7a0-4c6c-9173-cd066772960d"), 92745574264.0, new DateTime(2024, 9, 4, 12, 57, 3, 122, DateTimeKind.Local).AddTicks(8338), "AnaLaura.Batista@hotmail.com", true, "Ladislau Albuquerque", "$2a$11$rp7GEt/doEKulz5o7I9pV.peH8EegUk90/TFcQJ1eNEzVBqHTa41u", 78833226101.0 },
				{ new Guid("6d11af22-c913-4552-8d6c-9ccaac41604d"), 37198737307.0, new DateTime(2024, 9, 4, 12, 57, 3, 430, DateTimeKind.Local).AddTicks(9061), "Victor_Saraiva@hotmail.com", true, "Elisa Costa", "$2a$11$lzr7DuAKGdM3KmxkM9prne/OXB5H7ivQddpnCQ3l2fSVD5ffNMUne", 3975113901.0 },
				{ new Guid("6e512973-4ce3-462a-bb1f-bdb92ab857e8"), 26089267899.0, new DateTime(2024, 9, 4, 12, 57, 4, 58, DateTimeKind.Local).AddTicks(6842), "MariaAlice_Oliveira@live.com", true, "Célia Silva", "$2a$11$WklY5ayCZV1B9lGZ4n3rtuslYL55zaledCOTZECbOJ7IXyvF73K6K", 809894374.0 },
				{ new Guid("7027a7c8-1d09-4f34-ae95-034a50213416"), 68647847970.0, new DateTime(2024, 9, 4, 12, 57, 4, 689, DateTimeKind.Local).AddTicks(3866), "Isabelly_Oliveira14@hotmail.com", true, "Danilo Silva", "$2a$11$sro7dusrwHklypFp8ngjhey88Jv3QLwI7BdhTMiJcTfNop0ljzQai", 4979849354.0 },
				{ new Guid("780e5534-0f0a-4c28-927e-715cae07229c"), 77712911711.0, new DateTime(2024, 9, 4, 12, 57, 3, 589, DateTimeKind.Local).AddTicks(430), "Leonardo25@live.com", true, "Noah Batista", "$2a$11$nmK6FnGYVi2UWvljI1gz/uS236Dnui35rQqSmLlQTwG4itzmY3Pe.", 76508130518.0 },
				{ new Guid("7aa01519-89dd-4dbb-8d79-46bfa872154e"), 2872053808.0, new DateTime(2024, 9, 4, 12, 57, 4, 373, DateTimeKind.Local).AddTicks(3947), "Laura52@yahoo.com", true, "Théo Macedo", "$2a$11$20uXUpj2PK7TVbFXk6SpfeAEe7fIKQX6gf6rwaxAQO/PnVMUXzLTS", 58223701755.0 },
				{ new Guid("80cdb149-fd1b-4ab4-b116-f895e573f2fc"), 321309294.0, new DateTime(2024, 9, 4, 12, 57, 6, 402, DateTimeKind.Local).AddTicks(5330), "Isadora60@bol.com.br", true, "Félix Moraes", "$2a$11$lz3c1PqrXSgMB9eaDu11O.vcHVIpbhjGucr1oG4wTHLvrqJdESB6K", 644929893.0 },
				{ new Guid("83a567a1-2884-4f65-b7ff-99beeebd1c41"), 29485739478.0, new DateTime(2024, 9, 4, 12, 57, 5, 780, DateTimeKind.Local).AddTicks(2173), "JoaoMiguel_Macedo@yahoo.com", true, "Liz Martins", "$2a$11$1N3yi/dj3DBFTkVlASYN.uPwdfRu6yfstsvm5SHhM..2CMxuG8lhG", 553684699190.0 },
				{ new Guid("8aa1a1f0-924e-47f7-9299-da1c908d0193"), 50100561438.0, new DateTime(2024, 9, 4, 12, 57, 2, 350, DateTimeKind.Local).AddTicks(2519), "Manuela_Martins@hotmail.com", true, "Elisa Martins", "$2a$11$niywoHWxLU1DU3NcAojSBOow5.I3IMHne2.RH3EzdcAScr8vrF9.y", 7369741736.0 },
				{ new Guid("92826420-9e14-4152-b8cb-38a0e41a4263"), 63250964956.0, new DateTime(2024, 9, 4, 12, 57, 2, 814, DateTimeKind.Local).AddTicks(9308), "Tertuliano_Moreira96@yahoo.com", true, "Elísio Macedo", "$2a$11$JsAR5FxC.z0ops/UA4mRE.9ww0RgYlqjU3C2jIVaRPdf8hqGj9kFy", 57176560133.0 },
				{ new Guid("978361cc-86c6-405e-b901-331ce9ce7ff3"), 74081140847.0, new DateTime(2024, 9, 4, 12, 57, 4, 532, DateTimeKind.Local).AddTicks(4763), "Kleber.Batista3@bol.com.br", true, "Isaac Reis", "$2a$11$s4wdg/5n1MBEACneedWsX.XyXGVv4T7Uc5YzAq6GfG2BV5Uq3CVCC", 550249747876.0 },
				{ new Guid("a3486547-b63c-45a0-a375-36742bd1c9a9"), 26417613860.0, new DateTime(2024, 9, 4, 12, 57, 1, 571, DateTimeKind.Local).AddTicks(8780), "Julio.Moraes@yahoo.com", true, "Enzo Gabriel Oliveira", "$2a$11$GNmwCyd69mNz9t0RcAk8G.4S.DQICUCz.9cjtlxs79PoSI.dBWObO", 31163264743.0 },
				{ new Guid("a5123659-865b-44fd-b75a-be1df15b1581"), 95344330553.0, new DateTime(2024, 9, 4, 12, 56, 59, 9, DateTimeKind.Local).AddTicks(132), "Laura36@yahoo.com", true, "Alice Reis", "$2a$11$Fb5ELFn4nO7QiMgd2I1douKgvW5SmDDM/aClEW/GGRxegmH0EjAlG", 76189084150.0 },
				{ new Guid("ad1b1cf4-a57e-4dda-bacf-7fbf590dd3de"), 34598626534.0, new DateTime(2024, 9, 4, 12, 57, 5, 157, DateTimeKind.Local).AddTicks(2339), "Marina66@hotmail.com", true, "Anthony Albuquerque", "$2a$11$RmiI7P4NSYihZmLlxecCxusB/7VTXOPLKTorqyO9WQWS93Z0Zi9n2", 69098706593.0 },
				{ new Guid("ad2eb12c-792b-4b71-913b-0cecd0d7d441"), 42521242802.0, new DateTime(2024, 9, 4, 12, 57, 6, 247, DateTimeKind.Local).AddTicks(2435), "Felicia65@bol.com.br", true, "Yuri Costa", "$2a$11$dTQ8INKj64HUlnsU9bsUwuQwhP9SqAn76r.gW10tmuAPYai/9usMO", 5908188639.0 },
				{ new Guid("b72a5e23-e8b9-4341-b278-b9df4c87b6ab"), 59557427000.0, new DateTime(2024, 9, 4, 12, 57, 6, 94, DateTimeKind.Local).AddTicks(1244), "Meire_Franco37@live.com", true, "Gael Pereira", "$2a$11$M3Z4RZapQPEW/Gl5zHDQxeICHV2npDEYsPm2aIAe9Mdz1S50FjPPa", 7007071518.0 },
				{ new Guid("be8a4fe2-ca2b-4144-a13e-6840515593e5"), 97074919810.0, new DateTime(2024, 9, 4, 12, 57, 1, 416, DateTimeKind.Local).AddTicks(2938), "Tertuliano45@live.com", true, "Júlio Carvalho", "$2a$11$mhUNhu9nVJp7oy0fV//SGe9P2GQ31GeQz/4dE.ih3CPBqgi0otmk.", 8405111917.0 },
				{ new Guid("c8a697d5-469a-4972-b4fc-7ba8e8a6a474"), 95617343548.0, new DateTime(2024, 9, 4, 12, 56, 58, 846, DateTimeKind.Local).AddTicks(9181), "Calebe.Martins41@bol.com.br", true, "Célia Carvalho", "$2a$11$fkEbrO0V0UNs3kTvzvSwN.j6A75dfxcd5Id1uCgUph6nxLjGhl/fO", 92026257887.0 },
				{ new Guid("c9969727-99b7-45b9-ba55-74dd467c0feb"), 16638695371.0, new DateTime(2024, 9, 4, 12, 57, 0, 156, DateTimeKind.Local).AddTicks(2581), "Isabelly83@live.com", true, "Benício Costa", "$2a$11$5l9rA6RWBe55UozSbze.ael4LB9XR16odJDphdk.W6eXNA6NBG9iq", 11753316694.0 },
				{ new Guid("cf803453-8606-46ad-958d-1eeb855a4cf3"), 679070168.0, new DateTime(2024, 9, 4, 12, 57, 6, 557, DateTimeKind.Local).AddTicks(5227), "Silas.Costa@hotmail.com", true, "Norberto Martins", "$2a$11$/Nxagnb93CAgdKktBRGNN.WFj8jCuX7AZuzt84MQkUFTfU8gAaPY.", 553996514363.0 },
				{ new Guid("d4e7e8ba-2fbc-4a53-870d-72227675423d"), 56660851232.0, new DateTime(2024, 9, 4, 12, 57, 1, 261, DateTimeKind.Local).AddTicks(5756), "Morgana87@gmail.com", true, "Júlio César Xavier", "$2a$11$ORm5npfbpEkoo.qnnQZZ9.dzFuz9isbQLd2dscEF1N0Ee1EHLBRJ2", 11392219454.0 },
				{ new Guid("d515e32e-75ee-4a9f-ae3e-26c6192d0006"), 41016987161.0, new DateTime(2024, 9, 4, 12, 57, 1, 106, DateTimeKind.Local).AddTicks(7824), "Frederico.Souza92@gmail.com", true, "Isabel Carvalho", "$2a$11$S1OXWz7EalLJxrzclPe7iesNi1CNOVPnbYKZcaxavIVEiHkPE.VrS", 551314865315.0 },
				{ new Guid("d82fdf03-b026-4690-9661-1f0314f8bc39"), 27139860874.0, new DateTime(2024, 9, 4, 12, 56, 59, 997, DateTimeKind.Local).AddTicks(2971), "Gael_Carvalho78@bol.com.br", true, "Maria Eduarda Santos", "$2a$11$f7DdX3keU3h6bcEmwzTsiu6ZeaAb9nEdlaI441bmH5Vi6DEVkNDpK", 9350269449.0 },
				{ new Guid("dc9d2469-9696-42ec-a26e-9189a3a9374b"), 63971644970.0, new DateTime(2024, 9, 4, 12, 57, 4, 845, DateTimeKind.Local).AddTicks(6552), "Cecilia.Costa@live.com", true, "Alexandre Saraiva", "$2a$11$1AMDzGQDgAQVXSeEo0o9eexwrAd.mEJKHFouByFwk8.wFsGnAdEsy", 49321034960.0 },
				{ new Guid("e74d2547-ef4f-494a-8d5a-27878c1c24ed"), 33686655705.0, new DateTime(2024, 9, 4, 12, 56, 59, 522, DateTimeKind.Local).AddTicks(6086), "Sirineu_Barros@live.com", true, "Natália Moraes", "$2a$11$L3VBDwv3PeuKSacyj.0XheMlGSS0.yVCKDq6G39DLfFNT7myLuAza", 1479015859.0 },
				{ new Guid("edad418d-dc2f-4c14-b4d4-8208e432085b"), 64286672662.0, new DateTime(2024, 9, 4, 12, 56, 59, 841, DateTimeKind.Local).AddTicks(81), "Ofelia.Silva50@hotmail.com", true, "Isabel Braga", "$2a$11$9oBvBkrdFlhG8MA2zFCyPePU8cVZBH2sa.hLxszqzaGOg5cJdoHay", 9383500464.0 },
				{ new Guid("ee6ecd2f-720f-480f-9cfa-8969c212eff3"), 52225335907.0, new DateTime(2024, 9, 4, 12, 57, 3, 904, DateTimeKind.Local).AddTicks(7489), "Guilherme67@bol.com.br", true, "Júlio Moreira", "$2a$11$bRL1k1VGg7ereleCCAFvBOYLeEQw4NKo9KE.EQsxWZ9q8d3xt2uEK", 9170740077.0 },
				{ new Guid("f412c4a5-2b43-4d92-b119-5201521feddf"), 60644611790.0, new DateTime(2024, 9, 4, 12, 57, 0, 948, DateTimeKind.Local).AddTicks(84), "Marli.Costa83@live.com", true, "Rebeca Santos", "$2a$11$56zNieYc4VWwJbmaqXVYdefWLhmdSRAmzcTZ1pGSWaAUBq7yvUKYS", 553301095066.0 },
				{ new Guid("f723968a-85ba-4c10-adad-8e0377f6d6b8"), 28139722316.0, new DateTime(2024, 9, 4, 12, 57, 1, 729, DateTimeKind.Local).AddTicks(7807), "Yango_Albuquerque@live.com", true, "Karla Braga", "$2a$11$q2r839R5mM6U6fBcfdDaPukYPdVXo4WM.X6BgGcmwNjzNLHvLdD72", 11259338139.0 },
				{ new Guid("ff11bfff-4a52-405d-88ce-2a04ae271149"), 14422113267.0, new DateTime(2024, 9, 4, 12, 57, 5, 469, DateTimeKind.Local).AddTicks(3301), "EnzoGabriel61@bol.com.br", true, "Janaína Braga", "$2a$11$x0xKuAbsj6.kFwo1iNuMHeqGsp35H2MAJd.yX/1xw6GPzSdWvdAhe", 554175912314.0 }
			});

		migrationBuilder.InsertData(
			table: "admins",
			columns: new[] { "id", "user_id" },
			values: new object[] { new Guid("f8318560-d792-4a23-acf7-a81aa5a6dfbd"), new Guid("04c12160-bad6-45ce-903a-67d1afeffe72") });

		migrationBuilder.InsertData(
			table: "categories",
			columns: new[] { "id", "name", "user_id" },
			values: new object[,]
			{
				{ new Guid("12d037c1-8ad4-4347-9796-8b34b1f5c4f3"), "SQL", new Guid("04c12160-bad6-45ce-903a-67d1afeffe72") },
				{ new Guid("3f23e47f-2c4c-4eb7-9dc2-2030fa63be58"), "c#", new Guid("04c12160-bad6-45ce-903a-67d1afeffe72") },
				{ new Guid("78466364-b7fd-4402-8dae-472777e86195"), "Js", new Guid("04c12160-bad6-45ce-903a-67d1afeffe72") },
				{ new Guid("7f64b9bb-c6ff-44f8-b370-16e5bdb200a9"), "F#", new Guid("04c12160-bad6-45ce-903a-67d1afeffe72") },
				{ new Guid("94de5fdb-c05f-46e1-ad79-753d8ca03327"), "Typescript", new Guid("04c12160-bad6-45ce-903a-67d1afeffe72") },
				{ new Guid("98d1bf91-8360-4806-af8c-16144c8f0276"), "PHP", new Guid("04c12160-bad6-45ce-903a-67d1afeffe72") },
				{ new Guid("cacca94a-b0f2-428d-a5d8-d5fba54dc09e"), "c", new Guid("04c12160-bad6-45ce-903a-67d1afeffe72") },
				{ new Guid("cf34a0b0-4b9b-4fb5-a80d-fcff570e7444"), "Rust", new Guid("04c12160-bad6-45ce-903a-67d1afeffe72") },
				{ new Guid("d6b23e05-bfff-4f9c-a30c-d36410adce1f"), "Java", new Guid("04c12160-bad6-45ce-903a-67d1afeffe72") },
				{ new Guid("fda313e0-9081-452a-a669-9342181a315d"), "MySql", new Guid("04c12160-bad6-45ce-903a-67d1afeffe72") }
			});

		migrationBuilder.InsertData(
			table: "clients",
			columns: new[] { "id", "subscriptionplanid", "user_id" },
			values: new object[,]
			{
				{ new Guid("00911f0f-6bc8-4c26-a206-acebd6430a95"), null, new Guid("011c4d40-a69b-42d3-9909-fad2863e9244") },
				{ new Guid("021268c0-83d4-4f9f-a9f0-71e2235d885f"), null, new Guid("08d25560-04ea-4b27-9c1e-000d1258ef52") },
				{ new Guid("06dab68d-f78a-4d32-9adb-e70d1635db37"), null, new Guid("a5123659-865b-44fd-b75a-be1df15b1581") },
				{ new Guid("12691ae7-3280-4e8e-b2a1-9aa701b1f531"), null, new Guid("6d11af22-c913-4552-8d6c-9ccaac41604d") },
				{ new Guid("1490584f-0fab-447e-83eb-89314094ab21"), null, new Guid("66f11611-f3c4-499f-b8e0-bfa155ceadf9") },
				{ new Guid("1f3bb6ef-0e4d-472b-8ce5-056a4e07ba8b"), null, new Guid("c9969727-99b7-45b9-ba55-74dd467c0feb") },
				{ new Guid("210210a8-a789-411d-94b0-d4e35f0a0931"), null, new Guid("ff11bfff-4a52-405d-88ce-2a04ae271149") },
				{ new Guid("27dff1f7-831e-4845-9b04-0de21399cf05"), null, new Guid("ad2eb12c-792b-4b71-913b-0cecd0d7d441") },
				{ new Guid("30a2c535-36d5-489c-a87c-f3978fbc667b"), null, new Guid("978361cc-86c6-405e-b901-331ce9ce7ff3") },
				{ new Guid("31480649-94fe-4886-afc9-4b94e37c0dc5"), null, new Guid("80cdb149-fd1b-4ab4-b116-f895e573f2fc") },
				{ new Guid("33cdaa80-55b6-4ca9-ab73-4f50c987bb5d"), null, new Guid("f723968a-85ba-4c10-adad-8e0377f6d6b8") },
				{ new Guid("3501a2fa-2cd5-44eb-a974-58fcc2fbcc9d"), null, new Guid("7027a7c8-1d09-4f34-ae95-034a50213416") },
				{ new Guid("35842473-4354-41b7-9b2e-d5f31654d234"), null, new Guid("cf803453-8606-46ad-958d-1eeb855a4cf3") },
				{ new Guid("38394761-5998-46c5-96d6-a5e976f224fa"), null, new Guid("5bf4aa72-5fde-4328-8bcd-625391341d95") },
				{ new Guid("3a98c066-64ad-4c35-b29b-8604d3416eab"), null, new Guid("51b6adaa-504d-4be1-af50-63daf9f82922") },
				{ new Guid("3d9e9689-e9de-436c-bcd5-efacc3d70c9d"), null, new Guid("f412c4a5-2b43-4d92-b119-5201521feddf") },
				{ new Guid("3dd6df18-b6a4-492d-9dac-00ca3697c470"), null, new Guid("3600cb46-645a-4137-b510-046d732760d5") },
				{ new Guid("54ac2069-a5ef-48c3-bce9-232990261c8d"), null, new Guid("3ed06120-2d6e-4545-9886-4a1b8845cc25") },
				{ new Guid("5b00b9c0-7230-43f6-bc2e-49a5426bf460"), null, new Guid("10a0f2ad-9c7a-4af6-b5b1-c2a842ff8cce") },
				{ new Guid("5f1af3b5-5603-4836-a8f4-48cc5e4c5502"), null, new Guid("423f14af-de51-4112-b18e-54803c5d6792") },
				{ new Guid("603d97a6-d7c7-4603-b1ea-e089cd598e55"), null, new Guid("e74d2547-ef4f-494a-8d5a-27878c1c24ed") },
				{ new Guid("60e57af1-b754-40be-aa00-916fdba13b07"), null, new Guid("d515e32e-75ee-4a9f-ae3e-26c6192d0006") },
				{ new Guid("61138fb4-8f75-4660-ac87-4bb9d5d700eb"), null, new Guid("019542c4-3cc6-42b3-9845-fd6912b84a12") },
				{ new Guid("64a129cb-46fd-4310-b2ec-d9ef2242bb9b"), null, new Guid("58538d27-2f94-44a6-b2fe-8a2c3993f7f5") },
				{ new Guid("6c7c7298-3aa7-4704-9b3e-8824251b700b"), null, new Guid("a3486547-b63c-45a0-a375-36742bd1c9a9") },
				{ new Guid("745d07c7-ac23-4d7e-b1cf-50f3f83559ff"), null, new Guid("008dc7ec-0856-4ec5-8172-156693391ac5") },
				{ new Guid("76fa18d5-76d4-48ef-855a-f95ef6b0e16f"), null, new Guid("018fe328-ec3f-4f3b-acbb-68fc263d8293") },
				{ new Guid("7d20cf2d-b2c8-4f41-b594-d7d00d4791eb"), null, new Guid("ad1b1cf4-a57e-4dda-bacf-7fbf590dd3de") },
				{ new Guid("7d2367bc-624b-4422-9033-2f7aeaf62957"), null, new Guid("edad418d-dc2f-4c14-b4d4-8208e432085b") },
				{ new Guid("8176d792-a593-421a-ba2e-61844a68d105"), null, new Guid("780e5534-0f0a-4c28-927e-715cae07229c") },
				{ new Guid("936bf493-fd2c-4856-a592-b08ab9ff02b7"), null, new Guid("4f56575a-ac02-4702-a6d1-78e44039b62c") },
				{ new Guid("97db8e0f-a9ad-4a75-a683-268aaa21bd52"), null, new Guid("178d1951-cdc1-45c3-a0c6-b65faad8fdf8") },
				{ new Guid("a37496f8-ea2b-467d-bf43-fe9964ad2201"), null, new Guid("ee6ecd2f-720f-480f-9cfa-8969c212eff3") },
				{ new Guid("a69261dd-e038-42bc-92e2-61914a5d7747"), null, new Guid("92826420-9e14-4152-b8cb-38a0e41a4263") },
				{ new Guid("a9fcf073-661d-4ba3-8533-266a7c394497"), null, new Guid("6e512973-4ce3-462a-bb1f-bdb92ab857e8") },
				{ new Guid("b3ff21b3-802a-47fb-8fd3-16704d7d0b08"), null, new Guid("4cebea30-5096-49c2-8cf0-f92f38185d96") },
				{ new Guid("b544dcdd-644c-4820-81cb-6ab91f257ea8"), null, new Guid("be8a4fe2-ca2b-4144-a13e-6840515593e5") },
				{ new Guid("b6468a7d-f7a8-49ae-af12-0e82dfd2e7d1"), null, new Guid("48a4658c-3a9e-4e54-ac58-8139db3a2f1c") },
				{ new Guid("bee7210e-b8e9-47ab-a639-a287c9951965"), null, new Guid("8aa1a1f0-924e-47f7-9299-da1c908d0193") },
				{ new Guid("c2826cc4-83bb-4044-861e-d514e0d9cb12"), null, new Guid("c8a697d5-469a-4972-b4fc-7ba8e8a6a474") },
				{ new Guid("c337f99a-dde4-40d3-92bb-a2751c2f739e"), null, new Guid("83a567a1-2884-4f65-b7ff-99beeebd1c41") },
				{ new Guid("d36f6966-a25b-42c0-967e-ab93b3618934"), null, new Guid("048114ab-e8cf-4a9c-80ba-5573ef005e39") },
				{ new Guid("dd359ef5-e93d-4b0f-bf2b-26e870330290"), null, new Guid("b72a5e23-e8b9-4341-b278-b9df4c87b6ab") },
				{ new Guid("df9a1039-997d-43cb-a478-ab546be639e0"), null, new Guid("dc9d2469-9696-42ec-a26e-9189a3a9374b") },
				{ new Guid("e078d2bc-3094-450b-b487-d19c860cdb07"), null, new Guid("d82fdf03-b026-4690-9661-1f0314f8bc39") },
				{ new Guid("e42da487-2462-4cd9-b9c8-12eb1fe7d7c4"), null, new Guid("694d0942-a7a0-4c6c-9173-cd066772960d") },
				{ new Guid("e4c5516e-08ba-4d8a-a38c-143e97d40bc2"), null, new Guid("0d9553dc-8712-4935-8f64-089039406388") },
				{ new Guid("f4348943-5382-4e3b-a6dc-f19e886ab3d5"), null, new Guid("d4e7e8ba-2fbc-4a53-870d-72227675423d") },
				{ new Guid("f64e0269-98f0-4585-9c36-a2a1a83bbec6"), null, new Guid("7aa01519-89dd-4dbb-8d79-46bfa872154e") },
				{ new Guid("f8fb8452-25fd-4d71-8d4f-9238ebd2e2f5"), null, new Guid("64590e25-be72-40d6-a3b2-bc8930b24a33") }
			});

		migrationBuilder.InsertData(
			table: "instructors",
			columns: new[] { "id", "github", "social_network", "user_id" },
			values: new object[] { new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), null, null, new Guid("17813b34-21b2-4f1a-b6bc-bb4e2eb4b734") });

		migrationBuilder.InsertData(
			table: "blog_posts",
			columns: new[] { "id", "acesses", "created_at", "instructor_id", "text", "thumb", "title" },
			values: new object[,]
			{
				{ new Guid("07c50a6a-c7d1-1d89-84fa-1d57e9b23460"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(1372), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Impedit culpa non ea aperiam laborum. Debitis voluptas beatae ratione. Voluptas nihil aliquid officiis sunt quae repellendus maiores molestiae. Laudantium facere voluptatem est quibusdam veritatis. Repudiandae quibusdam qui aliquam eos officia officiis corrupti nesciunt. Dolore sed deserunt officia quae.\n\nAsperiores facilis ea modi dignissimos odit esse consequatur ut suscipit. Quod ex alias reiciendis officia sunt ratione earum quaerat quisquam. Voluptatem quia rem dolorem reiciendis. Ea dolores molestiae.\n\nLibero esse fuga impedit est alias dolores et aut fuga. Doloribus minus voluptas autem optio molestiae autem ut. Laudantium ea voluptatem ea cum in. Voluptatem veniam eligendi nostrum aut qui voluptas explicabo libero. Ipsum quia quisquam.", null, "Optimization" },
				{ new Guid("13e3cee9-406f-115d-52a7-3faed6bd63f2"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(1622), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Nobis qui repellat commodi voluptatem dolor aliquam rerum quae. Vitae rem animi ea eos consequatur quam. Sed reprehenderit quod recusandae officia laboriosam voluptatum. Omnis expedita placeat quae.\n\nQuod molestias eius est natus neque dignissimos earum. Ut eum aut adipisci qui vitae natus sed iure. Qui dolor exercitationem iusto ducimus. Ducimus labore quod dolorem iste exercitationem iure pariatur. Voluptatum veniam harum omnis amet dolorem possimus amet neque qui.\n\nReiciendis deserunt et ab delectus rerum magnam. Reiciendis maxime dolores natus magni soluta. Cupiditate et et aut. Nulla animi aliquam et mollitia est corporis.", null, "Intranet" },
				{ new Guid("155443f7-b948-755e-ed1a-abeb63d9d795"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(2091), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Eum est asperiores fugiat vero omnis vel numquam. Et sunt quis dolor officiis non nulla exercitationem et quae. Enim totam et distinctio. Molestiae dolore assumenda minima. Assumenda culpa perspiciatis distinctio aspernatur quia. Et quos repellat temporibus sit fugit.\n\nEsse sed perspiciatis. Ullam excepturi eum quibusdam. Eligendi cumque voluptas culpa facilis tempora dolorum. Blanditiis earum facilis eveniet voluptas rerum. Qui cum ullam ipsum corrupti inventore totam expedita officiis esse. Aut et minima eum accusamus qui pariatur laboriosam debitis ab.\n\nLibero et officiis ex soluta distinctio. Nemo repellat aspernatur et quis quo iusto labore aut soluta. Blanditiis non nihil natus enim aut ipsam quia sit. Enim eos esse optio quasi in ut.", null, "Optimization" },
				{ new Guid("2154882c-5111-031a-675c-d597652a731f"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(3411), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Facilis aut eligendi minima esse. Incidunt fugiat asperiores sit illo veniam magni accusamus sed labore. Aut quibusdam ex soluta sunt occaecati id dolores. Vero nihil magni provident dolorum illum architecto ipsam odit. Nam modi dolor minus. Voluptatum ratione est delectus est.\n\nDoloremque eos voluptas consequatur aut. Fuga non est. Nihil molestiae qui quis velit molestiae. Nam error quaerat assumenda excepturi iure labore et. Qui corporis modi et consequatur quas consequatur eos.\n\nSapiente recusandae fugit amet hic iste tempore eum. Quis deleniti quod id officia possimus tenetur. Quam magnam dignissimos repudiandae temporibus at.", null, "Identity" },
				{ new Guid("2a09684a-6253-bb5b-b5eb-8b55b1815b07"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(5473), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Omnis et reprehenderit magni commodi magnam. Labore quam est. Voluptas qui et vitae consequatur vitae voluptas in. Est deleniti voluptatem quaerat id cumque saepe.\n\nSed minima quibusdam voluptas pariatur quo. Deserunt quia rerum adipisci. Ducimus qui aspernatur. Consequuntur iste omnis fugiat et nostrum quos vero. Qui enim facilis adipisci sequi voluptas consequatur commodi beatae occaecati.\n\nRepellat ab perspiciatis quo eum ut aut eum. Eligendi assumenda odit error ad non voluptates animi. Veritatis quae error numquam nostrum voluptatem et eos inventore. Sit atque quia nesciunt sunt voluptas tempore reprehenderit ut modi. Voluptas cumque sit temporibus incidunt dolorem. Aperiam rerum dicta similique dolor beatae est autem.", null, "Directives" },
				{ new Guid("2d370a44-9e74-0d63-a7e0-21c15dc54aa4"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(5951), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Voluptas aut quas aspernatur sunt. Quae labore rerum ad dolore at eaque repudiandae. Vero eveniet voluptas temporibus tenetur. Ipsum ratione aperiam impedit non qui sunt nulla. Incidunt voluptatibus rerum totam vitae. Ut et aliquam dicta est labore aut quia.\n\nIn eos aut incidunt repudiandae. Quas aut non laborum atque exercitationem. Qui tempora perferendis nulla rerum sit dignissimos nihil reiciendis asperiores. Recusandae eum corporis eaque aut et non dolore dicta eos. Provident molestiae atque aperiam consequatur necessitatibus sunt saepe maxime optio.\n\nIpsa ab et. Voluptas et nisi. Ut dolor quibusdam vero quam id. Voluptas aut sed suscipit nostrum necessitatibus repudiandae iure esse. Vero temporibus quam.", null, "Implementation" },
				{ new Guid("35404dee-e62f-e435-c800-a1f69e267925"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(5740), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Dolorum dolor modi cum placeat animi aliquam omnis consequuntur repellendus. Et fugiat perferendis inventore dignissimos. Aut recusandae alias error et praesentium consequatur nisi qui explicabo. Voluptates sit ut earum consequuntur qui nihil eum qui aperiam. Earum nam quia est itaque saepe alias placeat. Et voluptas id rerum porro qui.\n\nAdipisci tenetur minima eos dicta est praesentium omnis. Est distinctio sit autem. Qui rem nemo non est corporis dolor quod. Ipsa debitis adipisci maiores molestiae hic rem.\n\nAut nostrum enim vitae. Voluptatum iure maxime perspiciatis nihil sunt explicabo autem et. Earum est nostrum a eaque.", null, "Configuration" },
				{ new Guid("4af8876b-1046-1c65-7bca-f2e67ece11ea"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(3622), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Provident et nobis molestiae quisquam temporibus consequatur et expedita sapiente. Quibusdam praesentium placeat veritatis sit iusto autem. Ipsa et magni ad repellat dolor hic quo totam et. Iste quaerat est est aut dignissimos. Enim sit facilis ab aut magni velit.\n\nEaque excepturi qui totam explicabo odit ut est. Atque vel maiores libero quia nulla. Ut aut animi omnis aut aut voluptatem alias sunt occaecati. Ipsum odio non.\n\nConsequatur rerum non occaecati et. Voluptatum voluptatem qui ut deleniti ipsam. Corporis deleniti enim id consequatur similique assumenda possimus voluptatibus earum. Magnam autem eum quas.", null, "Operations" },
				{ new Guid("4e593e5a-49f0-7f1f-f5ae-c0f34d50cd1d"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(6612), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Laboriosam tempore provident voluptatibus molestiae praesentium animi perspiciatis ex ea. Aliquam expedita aperiam cupiditate saepe magnam reprehenderit. Enim eligendi cumque. Asperiores sed quisquam quaerat recusandae modi. Iure est iste facilis.\n\nEa voluptas reiciendis provident. Doloremque beatae harum quo laborum et quia quae. Voluptate dolorem similique tempore quibusdam eligendi molestiae et aut dicta.\n\nLaborum dolores vel labore dignissimos cupiditate. Similique neque aut facere nam doloribus. Eveniet laudantium ut laudantium nostrum quia fuga qui laboriosam odit. Reiciendis beatae impedit ad dignissimos modi omnis non praesentium. Hic consequatur dolores non quae sapiente.", null, "Configuration" },
				{ new Guid("5045c22a-a594-e4c0-b0d9-a76b25535ee8"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(3051), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Repudiandae sunt sunt eius aut iusto perspiciatis voluptas et a. Est molestias corporis voluptatum ut saepe. Reprehenderit laboriosam cupiditate et.\n\nEst harum aliquid. Excepturi dolor officia. Totam quia facilis quis in provident. Voluptas veniam minima sunt aut deserunt consequatur distinctio error delectus.\n\nUt dolorum quia. Voluptatem illo ducimus quo est molestias nihil. Porro porro nesciunt iste et laboriosam id voluptatem itaque aut. Ab occaecati doloribus est.", null, "Identity" },
				{ new Guid("563afaad-c07d-4003-3c62-981332004fdd"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(1821), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Cumque odio quia cum. Aut rerum facere voluptatum voluptate quae autem. Nesciunt est occaecati aut et est dicta.\n\nHic quaerat qui necessitatibus vitae. Ipsa qui vel delectus fugiat veniam maxime vel consequatur doloribus. Qui ullam sed minus adipisci ut consequuntur ut. Repellat aperiam sunt enim vel qui molestias libero asperiores. Temporibus in facere aliquam ea a accusamus. Quisquam odio quia in veritatis fugiat autem maxime consequatur rerum.\n\nMinus quibusdam accusantium. Corporis non et sunt quasi ipsum perspiciatis incidunt voluptatem nihil. Enim sed qui ipsum quibusdam id voluptatem aut adipisci. Quis excepturi veritatis omnis. Quo voluptatibus est. Blanditiis vero delectus veniam voluptatem aut voluptas nulla eius et.", null, "Tactics" },
				{ new Guid("568b5702-916f-1f83-f56f-64c9990e7e73"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(2343), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Veritatis saepe explicabo. Doloribus ipsa voluptas placeat non. Nihil itaque dolore et numquam. Voluptatum nihil quo fugit est ipsum.\n\nIure natus saepe deleniti nam doloribus quod fugiat incidunt quam. Accusantium optio eaque voluptates fuga deserunt tempora quas omnis. Perspiciatis laudantium nostrum dolor quo autem. Velit tempore et similique accusantium. Ut aut sint deserunt harum voluptates.\n\nUt voluptatem nesciunt. Beatae quas quae laboriosam. Adipisci autem aut natus cumque sed animi fugit sed. Aut laborum ullam.", null, "Mobility" },
				{ new Guid("6320d256-b114-5975-5f1f-b0f2a6962142"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(2867), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Nostrum dolorum hic consequuntur voluptas. Rerum explicabo eos vel labore sit. Optio commodi nihil.\n\nVelit quibusdam ducimus impedit ipsa. Est molestiae quia qui nam unde dolorum odit ut qui. Distinctio doloribus cumque quis facere quae aut et.\n\nEligendi eos et rerum labore esse. Saepe aut delectus eum voluptas. Aut explicabo qui. Sint nihil necessitatibus rerum architecto et. Praesentium necessitatibus similique dolorem nihil voluptatum similique ea. Alias nulla mollitia excepturi et ex alias ratione.", null, "Paradigm" },
				{ new Guid("746622bc-296e-8110-3d67-0b0ff9510a88"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(4718), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Corporis iusto reiciendis nihil. Consequatur et excepturi aut. Libero provident eum asperiores.\n\nAliquam illum quae eos rerum porro libero odit quae. Assumenda dignissimos quia et distinctio. Quam quia voluptatibus sed. Culpa totam eos quos consequatur eveniet ratione rem deserunt. Esse tempore ut vitae beatae minima.\n\nOccaecati aut id qui repellendus vitae. Esse rerum voluptatem tenetur. Tempore aut eligendi repudiandae nulla repellendus eos. Ea pariatur voluptatem ipsum magnam sit ea libero quia.", null, "Factors" },
				{ new Guid("7864d72e-a048-e1e4-8481-2f8f44f8d5fd"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(4064), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Recusandae placeat esse. Aperiam labore sit et est. Ut debitis nisi ab veniam hic vero. Et hic dicta. Nisi sunt sunt a delectus eos.\n\nEa quis ea vel velit nostrum sit veniam aliquid iste. Deserunt et ut ullam amet. Et minima assumenda nesciunt voluptas consectetur aut exercitationem iure qui. Voluptatem et et ut adipisci modi amet repudiandae maiores.\n\nEum non molestias id qui repellat. Rerum quos ut incidunt tenetur dolor quia voluptatibus excepturi. Nostrum consequatur maxime necessitatibus sit et eos rem et dolor. Corrupti non quos sit eum est inventore reprehenderit fuga ipsa. Nisi reiciendis molestias quia voluptas ipsum in ex atque.", null, "Web" },
				{ new Guid("81283f7c-c169-77e4-8855-79896be2327c"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(5048), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Voluptatem earum officia voluptatem ea nisi est impedit cumque. Nam quo ut et perspiciatis id illo. Voluptates doloremque in qui et tempora rem. Alias iste ut qui aut qui aut.\n\nEveniet ad esse fuga qui. Quae est sint voluptatum aliquam odit nisi voluptatibus. Repellat dolor voluptatibus ea eaque commodi. Rerum voluptas aperiam dolorem nihil excepturi reiciendis.\n\nSed quis tempore voluptatem et eum qui possimus pariatur praesentium. Facilis sapiente id aut at fuga sit et distinctio repudiandae. Nulla modi iure. Laudantium consequatur non aspernatur repellendus in aliquam. Eius error perferendis numquam eum voluptatem eos incidunt sint beatae.", null, "Operations" },
				{ new Guid("837a24e5-3685-b819-d179-1910241c89db"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(860), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Et possimus porro ipsum ea dolor. Expedita odio earum ducimus blanditiis molestiae. Omnis enim in repudiandae dolorem quibusdam autem laudantium. Rerum odio adipisci. Enim est id aut itaque. Consectetur eum consequatur quae quo consequatur.\n\nEos laborum ab odit et voluptatem et exercitationem optio ut. Molestiae quam iure. Voluptas officiis veniam maiores aut dolor voluptatum et. Praesentium tenetur quia ratione veniam totam quasi dolorem dolor quasi. Optio eveniet cum qui nihil sit sed velit.\n\nVoluptatem laborum quia quia magnam laudantium assumenda. Recusandae molestias a fugit maxime velit laudantium maxime molestias. Et occaecati est. Aspernatur nesciunt nesciunt et dolor consectetur earum vel. Consequatur quos quas velit.", null, "Creative" },
				{ new Guid("86ab8359-5841-92e7-8751-479e09610190"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(3204), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Optio mollitia est commodi. Quod ut quae suscipit ut dolor odio. Sint rerum eos enim ipsum. Et vero quisquam a laboriosam dolor odio. Fugiat quibusdam veritatis in dolorem deserunt delectus quia eum.\n\nExercitationem delectus minus reprehenderit tempora et velit. Deserunt distinctio voluptas culpa non perferendis molestiae repudiandae voluptates amet. Deserunt sint incidunt harum assumenda qui ipsam minima. Voluptatum dolores sunt minus numquam tenetur voluptatum velit expedita voluptatem.\n\nModi ad earum non qui delectus. Et necessitatibus quibusdam nihil eveniet dolores reprehenderit. Quia consectetur minima quidem ipsa omnis quod. Possimus quia reiciendis tempore.", null, "Infrastructure" },
				{ new Guid("8a674c50-d80a-535a-4d99-e131834901af"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(2696), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Aut dolores corporis ipsa quis. Cupiditate atque officia nihil voluptatem. Dolorum ipsum vel deleniti quam maiores sed sed.\n\nAd ut eum qui enim esse eaque. Tempore quo sed qui incidunt et reprehenderit quos sunt sit. Quidem ut sit laboriosam est voluptatem ducimus.\n\nDoloremque excepturi alias. Est et alias reiciendis aliquam necessitatibus rerum sint sed ut. Minus voluptate animi a sapiente dolorem laborum et occaecati. Consequatur aut minima sequi. Quis at deleniti suscipit tenetur dolores error aut.", null, "Creative" },
				{ new Guid("8af0c46f-6f4d-8af3-3823-d88cbd1a60a5"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(2532), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Quasi autem ducimus molestiae aspernatur aut sunt temporibus. Voluptate sint voluptas. Quasi totam nihil recusandae et quos est minima a. Eos adipisci quisquam. Rem quisquam saepe illo omnis.\n\nIpsam fuga quia sunt suscipit. Voluptatem doloremque qui ut amet alias dolor. Minima eius optio eligendi vel.\n\nMolestiae ipsum ut. Eligendi laudantium neque. Porro ea fugit. Odit et quia et harum incidunt nisi rerum ut.", null, "Program" },
				{ new Guid("a2f854ac-c94a-7583-0c51-f3166da59571"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 871, DateTimeKind.Local).AddTicks(9765), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Nihil dolores esse accusamus est repellendus maxime asperiores. Accusamus minima minima. Repudiandae porro sed quia tempore nobis ullam. Ut nihil nesciunt provident voluptas quam aliquam. Officiis rerum excepturi tenetur qui eum.\n\nDolorum qui numquam aut quia aut eveniet esse. Dolorem commodi quam velit qui unde quae. At enim odit odit rerum dolorem saepe eligendi dolore quibusdam.\n\nVoluptatum quae maiores dignissimos natus iusto iste ducimus et necessitatibus. Quos ipsum quos sed earum. Est in modi sit repellat at natus officia nihil accusantium. Unde dignissimos iusto officiis quasi vel et. Harum dolor error illo sit voluptatibus. Accusamus placeat qui cumque consequuntur porro adipisci.", null, "Implementation" },
				{ new Guid("ac6fa1f1-dccf-e3b4-62c8-842fbad7ed86"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(1146), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Quis iusto voluptas qui rerum non. Totam consequuntur incidunt architecto. Ea totam ipsam molestiae. Sunt similique provident aliquid aut. Magni non vitae qui consequatur nostrum.\n\nBeatae dolores est itaque consequatur saepe aperiam dolores est. Et doloribus quasi mollitia eaque. Voluptates et corporis dolorem vitae fuga voluptatibus. At velit incidunt voluptas. Minima et accusamus repellat. Facere ea rerum est nisi quae rerum sit.\n\nVel delectus repellendus. Animi architecto temporibus. Libero et quia. Hic hic esse voluptatibus. Sapiente itaque consectetur est aperiam repellat laborum assumenda neque. Dolore quam incidunt est quo dolor rerum.", null, "Branding" },
				{ new Guid("bc0adbf6-a7be-b936-5f9c-b170709d5dce"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(3834), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Quo saepe voluptatum laboriosam aut in ut sit voluptatem sint. Voluptates maiores aliquid maiores quae reiciendis molestiae. Sapiente sed dignissimos aut. Modi accusantium accusamus veniam corporis asperiores ut. Cumque est aspernatur quo.\n\nVelit tempore enim voluptas distinctio et voluptatem voluptas dolorem. Cumque eum omnis dignissimos molestias. Est illo dolorem est aut quae velit fugiat. Dolorum doloribus facere consequuntur qui repellendus. Voluptas eum magnam veniam provident autem distinctio voluptas. Et dolore porro enim mollitia hic enim eos velit.\n\nSit iure quia vitae. Accusamus maxime sint quas mollitia odio. Dolorem asperiores rem non temporibus consequatur culpa rerum voluptatem nobis. Sint quia et.", null, "Response" },
				{ new Guid("bed06075-0813-4292-61f2-fa076d74d5b4"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(5263), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Ut sint adipisci exercitationem dolor. Perferendis suscipit ut corrupti eos qui sit minima nostrum quam. Earum explicabo magni aut. Delectus recusandae et ad reprehenderit alias sint. Officia et nisi rerum qui tenetur tempore. Corrupti natus velit occaecati eum rerum quia earum.\n\nDolores blanditiis unde. Consequuntur in et. Maiores vero aut error consectetur ut expedita totam dignissimos.\n\nExcepturi accusamus iste. Aut ratione quia animi et recusandae voluptate tempora. Voluptate qui quia quam harum vel quo. Dolores eum consectetur quia qui expedita. Eveniet non ducimus excepturi ad qui hic numquam qui ullam.", null, "Program" },
				{ new Guid("c0d3c6de-39d8-2f4d-3fa4-9e3bf768d268"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(4291), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Officiis nobis sed. Et commodi accusamus natus ullam ut. Rerum nihil aut asperiores est quo voluptatem.\n\nExplicabo tenetur consequatur aspernatur iste sed et consequatur. Cumque repellat repudiandae debitis. Magnam nobis asperiores rerum distinctio.\n\nNatus exercitationem nihil eum quia id. Expedita saepe a nemo. Nam porro praesentium non saepe cumque optio voluptatem asperiores. Qui et perspiciatis. Ut ut consequatur accusantium saepe necessitatibus culpa a minus neque. Enim repudiandae veniam eaque a cumque sit vel.", null, "Tactics" },
				{ new Guid("c2e17491-2b4c-7550-dc45-c6b3131eb74b"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(6184), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Et quia praesentium voluptas et vero suscipit quod recusandae nemo. Explicabo officia quis repellat rerum temporibus delectus. Enim ad est dolorem repudiandae maxime perspiciatis et consequatur. Soluta sed eligendi quod rerum aut nihil voluptate. Ut corrupti in in assumenda consequatur molestiae. Dolores dolores ut repudiandae eaque praesentium sed.\n\nAut aliquam quod consequuntur. Illum amet quisquam labore nesciunt deserunt rem ut. Omnis numquam qui et sint officiis explicabo et quia. Error deserunt qui.\n\nEst et delectus esse. Neque qui reiciendis. Vel debitis ullam quo ad et officiis deleniti et sit. Quia quas sequi sunt voluptas ipsa repellendus. Dignissimos sed omnis aut assumenda. Minus repudiandae iusto dignissimos nemo qui.", null, "Group" },
				{ new Guid("d17de2de-8cf7-d12c-0c70-6fb874408fb1"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(4465), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Sint in unde voluptas voluptas vel sapiente. Est vel qui molestias odit. Dignissimos eaque quaerat laboriosam quia pariatur ab autem. Ipsa omnis ea vero ea. Eum non asperiores sed consectetur mollitia provident. Quam error minus cumque quae magni non explicabo architecto quibusdam.\n\nVeritatis laborum qui soluta. Architecto odio magnam minus quis ipsa aut. Alias repudiandae molestiae molestias nisi iusto maxime iusto. Repellat saepe est est sed sunt. Porro delectus maiores quam aut.\n\nEt rerum culpa minus sunt soluta ipsum quisquam. Aperiam fugiat voluptates at facere dolores modi dolore unde numquam. Veniam culpa fuga quos accusamus impedit iusto dolores. Eum inventore omnis dolorum soluta vel. Soluta hic eligendi. Quis aut nihil est dolor maxime autem est quis iste.", null, "Accounts" },
				{ new Guid("db42a994-00e9-f1d4-8336-137d579b991a"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(4888), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Ea sint suscipit qui impedit ut ratione architecto ratione. Quos debitis libero deleniti reprehenderit itaque eligendi omnis. In aut totam dolor dolor dolorem.\n\nEum dolorum vero rerum sed. Quidem molestias cupiditate quod. Quia vel sed molestiae dolore sint et. Voluptatem ut sed est et aperiam et iusto itaque. Et consequuntur sed ut error.\n\nConsectetur voluptatem sit ut necessitatibus. Aperiam numquam quae. Qui optio quod accusamus at dolorum doloremque ratione adipisci ut.", null, "Intranet" },
				{ new Guid("ea836b66-d80b-bc44-fb29-64f18390995c"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(610), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Nemo blanditiis commodi corporis illum quia itaque dolorem quia architecto. A aut repellat perspiciatis quasi quo. Quod minus minus temporibus ut asperiores sapiente voluptatum veniam.\n\nQui dicta amet occaecati repellat incidunt distinctio optio libero aliquam. Quidem voluptates in illum officia distinctio repudiandae cumque non. Velit necessitatibus iste ut necessitatibus dolores quia fugiat. Eos eius fugit deleniti pariatur nihil dolor tenetur. Architecto minus qui consectetur et et deleniti rem. Qui est quas.\n\nDebitis nulla reprehenderit laborum iure soluta. Nemo ducimus quae cumque officia. Adipisci in vitae dolor excepturi dicta quis sed.", null, "Accounts" },
				{ new Guid("fe80351e-be10-76c4-6029-f5df12e802a4"), 0, new DateTime(2024, 9, 4, 12, 57, 6, 872, DateTimeKind.Local).AddTicks(6416), new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), "Aspernatur sit aut alias quo quia quas. Fuga alias odio culpa nihil quod quia a consectetur reprehenderit. Numquam possimus placeat. Accusamus commodi minima hic. Et ab perferendis sunt voluptatem corporis aut. Natus nihil quo expedita et eum.\n\nId corporis sapiente est. Hic omnis et voluptates dolores est unde. Ex ab eius iure veniam magnam at quasi.\n\nEt dolorem est est atque eum. Deserunt minima dolorem molestiae ut quis. Dolorem odio consequatur. Praesentium quasi architecto est aut consequuntur iste. Quis non voluptas et amet amet quisquam.", null, "Factors" }
			});

		migrationBuilder.InsertData(
			table: "courses",
			columns: new[] { "id", "active", "created_at", "description", "duration", "instructor_id", "is_free", "lastupdate", "thumb", "title" },
			values: new object[,]
			{
				{ new Guid("02daf37c-ec22-4494-9198-7ec6b305b9b0"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7013), "Beatae aut modi excepturi quo. Nostrum alias ab voluptas suscipit. Illum blanditiis animi consequatur velit ut aperiam. Distinctio excepturi pariatur in sint quis suscipit perspiciatis.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7014), null, "Camiseta" },
				{ new Guid("1a84a7c7-fdd5-4024-bf7d-b7bbc221e108"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(6566), "Odio ipsum fugiat aspernatur voluptatem aliquam enim. Dolorem magnam inventore minima autem ea atque. Molestiae aut vitae magni. Velit assumenda iusto dolores iure corporis. Et voluptatem repudiandae ut rem nesciunt nobis.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(6567), null, "Sabonete" },
				{ new Guid("1eb9d3e9-5941-4d7c-a3fe-c8f26648cb2b"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7284), "Nisi a doloribus voluptate quas sint perspiciatis. Molestias aut alias placeat et illum enim quo. Ut alias vero sint explicabo. Sed ratione et consectetur consequatur laboriosam voluptate ut vel nemo.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7284), null, "Sapatos" },
				{ new Guid("422b2668-b2e2-44ee-803e-a67b927b4259"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(6962), "Non minima odio voluptas et. Et ratione autem id quae id qui sed tempora sit. Qui a et quas quas.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(6963), null, "Bacon" },
				{ new Guid("4452d91e-571e-4123-9071-cf93d96a19e1"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(6834), "Sed veritatis odio molestiae accusamus. Ut voluptatem quia veniam eum nesciunt molestias quam. Dicta dolor quia molestias ipsam eos dolor. Nisi et architecto soluta laborum harum dolorem deleniti ut.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(6834), null, "Carro" },
				{ new Guid("53bd7a6f-3499-433e-a269-25d86703a421"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7081), "Possimus ut odit nihil non quia similique ipsam eos et. Sequi et a sunt nostrum animi animi. Dicta quibusdam tempore qui deleniti sed unde. Temporibus debitis ad dolor dolores molestias quo veniam. Et consequatur nam sapiente minima soluta nulla ad cupiditate. Tenetur itaque fuga voluptatem eos sed dolorum.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7081), null, "Computador" },
				{ new Guid("6973d6f3-2fa8-4fa1-8608-117b7346d419"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7358), "Cum iure deleniti aut velit qui qui. Laborum quia aliquam et qui. Molestiae ipsum similique totam. Nihil et magni eligendi rem nisi blanditiis et sequi.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7359), null, "Sabonete" },
				{ new Guid("7417c3f3-4047-402c-87fc-afd8c45c5e67"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7418), "Accusantium itaque vitae. Rerum ut expedita doloribus enim enim impedit animi dignissimos. Id voluptas molestias.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7418), null, "Sabonete" },
				{ new Guid("7ea3c454-db2e-4edc-91c6-da1839a0a432"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7465), "Ab suscipit fugiat molestiae accusantium. Ducimus nostrum adipisci est deserunt ipsum atque accusantium ut delectus. Expedita harum vel est quia doloremque minima soluta.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7466), null, "Salada" },
				{ new Guid("87c600cd-fbea-49c5-a7a9-5fa5f95011bf"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7516), "Et reiciendis delectus deserunt expedita ipsum quos. Fugiat veritatis veritatis unde nobis velit neque fuga consequuntur impedit. Eius nisi eveniet sit aliquam sed natus voluptas sequi veniam. Ratione id voluptatem voluptatem eos dolor sed ex temporibus earum. Aliquam blanditiis dolorem debitis eaque.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7517), null, "Carro" },
				{ new Guid("ac1e8261-c167-4be9-b7d5-80214402e428"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(6908), "Sit officia quia quia sit quibusdam. Suscipit eos numquam sed eos quam esse non ab iusto. Doloremque cum quaerat quis qui.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(6909), null, "Camiseta" },
				{ new Guid("adda0879-b995-4c48-80ca-43198fa27c45"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7613), null, null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7614), null, "Curso de baixa qualidade" },
				{ new Guid("c3565153-e77f-46a3-a89e-a840311d209a"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7191), "Fuga ipsum repellat. Voluptatem molestiae voluptatibus perferendis eum nulla quia adipisci. Reprehenderit aut accusantium. Labore eos nisi aut ad excepturi neque corporis. Natus id illum vel nisi est qui perferendis quidem. Ea animi cum culpa vel voluptatem nesciunt molestias odio voluptatum.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(7191), null, "Cadeira" },
				{ new Guid("e563ce3f-df14-4f34-a215-5e8e30f53864"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(3645), "Nisi sunt aut ea a enim. Molestias odio voluptatum quo cumque ad beatae recusandae cum repellendus. Aperiam vero et soluta non est dolore doloribus. Non illo aut totam id facilis veritatis. Explicabo aut magnam voluptatem qui sapiente ut omnis. Rerum odit consequatur qui incidunt molestias delectus.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(3647), null, "Salsicha" },
				{ new Guid("e8e6a672-b211-4f47-b8b3-cc2174b79873"), true, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(6736), "Consequuntur quis vel consequatur voluptates aut quia fuga dolorum voluptatem. Omnis temporibus sunt. Aspernatur maiores quibusdam aut praesentium maxime. Illo autem quod adipisci. Velit quam qui. Enim et iure.", null, new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"), false, new DateTime(2024, 9, 4, 12, 57, 6, 874, DateTimeKind.Local).AddTicks(6737), null, "Cadeira" }
			});

		migrationBuilder.InsertData(
			table: "subscription_plans",
			columns: new[] { "id", "admin_id", "created_at", "description", "months", "price" },
			values: new object[,]
			{
				{ new Guid("0f1679de-7c9a-46a5-b19e-8707fb922bb0"), new Guid("f8318560-d792-4a23-acf7-a81aa5a6dfbd"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(6649), "Anual", 1, 399.99f },
				{ new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165"), new Guid("f8318560-d792-4a23-acf7-a81aa5a6dfbd"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(6641), "Free", 0, 0f },
				{ new Guid("719d7b27-b20e-4260-90d9-0f8797fd9fb8"), new Guid("f8318560-d792-4a23-acf7-a81aa5a6dfbd"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(6646), "Mensal", 1, 35f }
			});

		migrationBuilder.InsertData(
			table: "modules",
			columns: new[] { "id", "complete", "course_id", "description", "order", "title" },
			values: new object[,]
			{
				{ new Guid("19248b65-5669-463e-84d4-737ceaa1ec68"), false, new Guid("adda0879-b995-4c48-80ca-43198fa27c45"), null, 0, "introducao" },
				{ new Guid("56268b89-d29c-4061-a218-fac5714be968"), false, new Guid("adda0879-b995-4c48-80ca-43198fa27c45"), null, 1, "Modulo 2" },
				{ new Guid("b70750b5-7a72-4dd2-9c5e-51854760210f"), false, new Guid("adda0879-b995-4c48-80ca-43198fa27c45"), null, 2, "Modulo 3" }
			});

		migrationBuilder.InsertData(
			table: "post_categories",
			columns: new[] { "id", "blog_post_id", "category_id" },
			values: new object[,]
			{
				{ new Guid("03b53456-235a-40fe-84c2-6216537214b6"), new Guid("568b5702-916f-1f83-f56f-64c9990e7e73"), new Guid("94de5fdb-c05f-46e1-ad79-753d8ca03327") },
				{ new Guid("078a71c9-c27f-40d8-81ae-341278f35214"), new Guid("c0d3c6de-39d8-2f4d-3fa4-9e3bf768d268"), new Guid("fda313e0-9081-452a-a669-9342181a315d") },
				{ new Guid("0b9df756-2d4a-48ca-b78b-f55976ecd3aa"), new Guid("7864d72e-a048-e1e4-8481-2f8f44f8d5fd"), new Guid("7f64b9bb-c6ff-44f8-b370-16e5bdb200a9") },
				{ new Guid("0e8d60bc-23a7-448a-b12c-2c1800190729"), new Guid("8af0c46f-6f4d-8af3-3823-d88cbd1a60a5"), new Guid("98d1bf91-8360-4806-af8c-16144c8f0276") },
				{ new Guid("13220bbc-ade9-4ca7-95e5-a1d62721467b"), new Guid("13e3cee9-406f-115d-52a7-3faed6bd63f2"), new Guid("cf34a0b0-4b9b-4fb5-a80d-fcff570e7444") },
				{ new Guid("27e73166-3bc0-452c-a40e-3a85d4db0610"), new Guid("8a674c50-d80a-535a-4d99-e131834901af"), new Guid("7f64b9bb-c6ff-44f8-b370-16e5bdb200a9") },
				{ new Guid("3a1154ed-6d43-4af3-9019-4e3c219f44c1"), new Guid("86ab8359-5841-92e7-8751-479e09610190"), new Guid("fda313e0-9081-452a-a669-9342181a315d") },
				{ new Guid("4d2fec8b-64c4-419f-a5fd-0d9984ea9397"), new Guid("2d370a44-9e74-0d63-a7e0-21c15dc54aa4"), new Guid("12d037c1-8ad4-4347-9796-8b34b1f5c4f3") },
				{ new Guid("61e315b5-921d-4ad7-8664-56e6515498ad"), new Guid("81283f7c-c169-77e4-8855-79896be2327c"), new Guid("94de5fdb-c05f-46e1-ad79-753d8ca03327") },
				{ new Guid("6f76cf97-1b91-423f-8b93-c54cfed6d13f"), new Guid("837a24e5-3685-b819-d179-1910241c89db"), new Guid("98d1bf91-8360-4806-af8c-16144c8f0276") },
				{ new Guid("7f4a4075-3e62-4fcd-9b3a-25d73628baed"), new Guid("a2f854ac-c94a-7583-0c51-f3166da59571"), new Guid("12d037c1-8ad4-4347-9796-8b34b1f5c4f3") },
				{ new Guid("8a0ae792-8795-41f5-a80c-e7d932fc3496"), new Guid("563afaad-c07d-4003-3c62-981332004fdd"), new Guid("78466364-b7fd-4402-8dae-472777e86195") },
				{ new Guid("8a0c0a7f-b925-47e8-9a48-913467cf82b0"), new Guid("c2e17491-2b4c-7550-dc45-c6b3131eb74b"), new Guid("d6b23e05-bfff-4f9c-a30c-d36410adce1f") },
				{ new Guid("8b21b6b0-37bb-4665-bb00-e495cdfbb76e"), new Guid("ea836b66-d80b-bc44-fb29-64f18390995c"), new Guid("fda313e0-9081-452a-a669-9342181a315d") },
				{ new Guid("8db2bf43-b3e1-42f6-94e9-456377df059e"), new Guid("4e593e5a-49f0-7f1f-f5ae-c0f34d50cd1d"), new Guid("94de5fdb-c05f-46e1-ad79-753d8ca03327") },
				{ new Guid("ab08d7ee-dd44-4aad-a563-9f6c08f497d0"), new Guid("bc0adbf6-a7be-b936-5f9c-b170709d5dce"), new Guid("12d037c1-8ad4-4347-9796-8b34b1f5c4f3") },
				{ new Guid("b2e574b0-a3d3-46e6-a2ee-83f1b0e2d0ec"), new Guid("fe80351e-be10-76c4-6029-f5df12e802a4"), new Guid("7f64b9bb-c6ff-44f8-b370-16e5bdb200a9") },
				{ new Guid("b4bc027c-a8c4-4749-b85d-5221d7c2c3b3"), new Guid("bed06075-0813-4292-61f2-fa076d74d5b4"), new Guid("cf34a0b0-4b9b-4fb5-a80d-fcff570e7444") },
				{ new Guid("b5e32e69-8bb9-45e1-8972-f13cfef18a34"), new Guid("35404dee-e62f-e435-c800-a1f69e267925"), new Guid("7f64b9bb-c6ff-44f8-b370-16e5bdb200a9") },
				{ new Guid("b69e3919-245d-42c5-baad-d50adf20b6a4"), new Guid("db42a994-00e9-f1d4-8336-137d579b991a"), new Guid("78466364-b7fd-4402-8dae-472777e86195") },
				{ new Guid("bc46867f-c5ae-4322-8d95-c1bffdd5877c"), new Guid("155443f7-b948-755e-ed1a-abeb63d9d795"), new Guid("3f23e47f-2c4c-4eb7-9dc2-2030fa63be58") },
				{ new Guid("c53d73bb-70d4-4b51-bce6-bf46850321c1"), new Guid("2a09684a-6253-bb5b-b5eb-8b55b1815b07"), new Guid("fda313e0-9081-452a-a669-9342181a315d") },
				{ new Guid("c562e47c-d28f-4023-8ee6-b72beabc955c"), new Guid("ac6fa1f1-dccf-e3b4-62c8-842fbad7ed86"), new Guid("3f23e47f-2c4c-4eb7-9dc2-2030fa63be58") },
				{ new Guid("d206b389-6339-42e2-bafd-6cc484ccc0ec"), new Guid("746622bc-296e-8110-3d67-0b0ff9510a88"), new Guid("fda313e0-9081-452a-a669-9342181a315d") },
				{ new Guid("df205189-c0be-4db8-8ce9-f1c843adc283"), new Guid("6320d256-b114-5975-5f1f-b0f2a6962142"), new Guid("cf34a0b0-4b9b-4fb5-a80d-fcff570e7444") },
				{ new Guid("e48330c9-b81d-40be-8a7a-8043bf05aee7"), new Guid("d17de2de-8cf7-d12c-0c70-6fb874408fb1"), new Guid("12d037c1-8ad4-4347-9796-8b34b1f5c4f3") },
				{ new Guid("f4ca7154-7606-48be-b7ef-b3b48752b991"), new Guid("4af8876b-1046-1c65-7bca-f2e67ece11ea"), new Guid("3f23e47f-2c4c-4eb7-9dc2-2030fa63be58") },
				{ new Guid("f88c9cd2-a231-4987-9bad-153ee4da4cad"), new Guid("5045c22a-a594-e4c0-b0d9-a76b25535ee8"), new Guid("98d1bf91-8360-4806-af8c-16144c8f0276") },
				{ new Guid("fcc25278-21a4-43bd-8a9a-a230f7e428e1"), new Guid("07c50a6a-c7d1-1d89-84fa-1d57e9b23460"), new Guid("cf34a0b0-4b9b-4fb5-a80d-fcff570e7444") },
				{ new Guid("fe46730f-3157-4886-8930-543e68e25360"), new Guid("2154882c-5111-031a-675c-d597652a731f"), new Guid("cacca94a-b0f2-428d-a5d8-d5fba54dc09e") }
			});

		migrationBuilder.InsertData(
			table: "user_plan",
			columns: new[] { "id", "client_id", "created_at", "is_active", "subscriptionplan_id" },
			values: new object[,]
			{
				{ new Guid("03b23270-4dbd-43fc-830b-dfcb7037c8cc"), new Guid("1f3bb6ef-0e4d-472b-8ce5-056a4e07ba8b"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8678), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("0490cab0-8087-45ff-a5a2-6db6cce14372"), new Guid("33cdaa80-55b6-4ca9-ab73-4f50c987bb5d"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8695), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("11a258a2-9b38-4268-8302-ce80cf12584b"), new Guid("b6468a7d-f7a8-49ae-af12-0e82dfd2e7d1"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8680), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("12624343-ed02-463e-9c5e-c4167b9e94bb"), new Guid("60e57af1-b754-40be-aa00-916fdba13b07"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8689), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("1c894587-5877-4663-9aa3-d2740b27b14a"), new Guid("603d97a6-d7c7-4603-b1ea-e089cd598e55"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8672), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("1d6f5521-351e-4d36-b057-43821856f61f"), new Guid("e42da487-2462-4cd9-b9c8-12eb1fe7d7c4"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8709), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("259ce02a-9c5f-4ed9-89cf-7c6268fa8aba"), new Guid("64a129cb-46fd-4310-b2ec-d9ef2242bb9b"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8700), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("25f46a3a-b989-4a10-a7ff-839acc770fd1"), new Guid("27dff1f7-831e-4845-9b04-0de21399cf05"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8754), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("2b685eec-1f7f-4f0f-b546-2df07fce4eec"), new Guid("dd359ef5-e93d-4b0f-bf2b-26e870330290"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8753), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("2c31f90d-1fe7-46e1-b679-911b8247d6fc"), new Guid("76fa18d5-76d4-48ef-855a-f95ef6b0e16f"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8663), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("2f18e911-723a-448e-b5a4-c722d42f0f6e"), new Guid("54ac2069-a5ef-48c3-bce9-232990261c8d"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8698), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("34083c48-621f-4341-a96c-165bd1844f85"), new Guid("31480649-94fe-4886-afc9-4b94e37c0dc5"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8755), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("344868a4-d786-4c01-b84f-37d0919f33e9"), new Guid("b3ff21b3-802a-47fb-8fd3-16704d7d0b08"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8687), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("385be3ef-abfa-4597-8d1c-b8efe237a779"), new Guid("38394761-5998-46c5-96d6-a5e976f224fa"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8742), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("38929834-cbb6-4ee0-be99-c56ddfed8ec6"), new Guid("c2826cc4-83bb-4044-861e-d514e0d9cb12"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8651), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("39d7857c-4e35-41d2-8cf9-cb5ed3d4fad0"), new Guid("bee7210e-b8e9-47ab-a639-a287c9951965"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8701), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("3d158940-96d1-48d8-bab1-97a3bc18db0a"), new Guid("936bf493-fd2c-4856-a592-b08ab9ff02b7"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8714), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("40b67821-97aa-4748-a570-ac851807c0f7"), new Guid("e4c5516e-08ba-4d8a-a38c-143e97d40bc2"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8699), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("43fc3968-5ac7-478f-9eaa-c5abcc4d55c8"), new Guid("12691ae7-3280-4e8e-b2a1-9aa701b1f531"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8711), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("45b0964d-76d4-4d23-a815-ebb4e0df54ac"), new Guid("5f1af3b5-5603-4836-a8f4-48cc5e4c5502"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8706), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("4bf45356-ec8b-47db-afae-90dc9be3b9da"), new Guid("a37496f8-ea2b-467d-bf43-fe9964ad2201"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8715), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("539a7c41-41b7-4cca-a44c-5f8dccc1a4e9"), new Guid("745d07c7-ac23-4d7e-b1cf-50f3f83559ff"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8671), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("57c5d90c-5a97-463c-bec6-c73d2b6bb19a"), new Guid("3dd6df18-b6a4-492d-9dac-00ca3697c470"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8733), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("5f80dca0-80bf-4d1e-9474-d60730eaa2da"), new Guid("7d2367bc-624b-4422-9033-2f7aeaf62957"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8676), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("65d4ea8b-7f9a-47d8-96ac-1ed1c1529b23"), new Guid("df9a1039-997d-43cb-a478-ab546be639e0"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8741), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("716b40ef-f273-404e-8d6c-c56927f31003"), new Guid("00911f0f-6bc8-4c26-a206-acebd6430a95"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8749), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("72151e6c-a854-4560-b880-1485ce0fe0f7"), new Guid("30a2c535-36d5-489c-a87c-f3978fbc667b"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8738), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("75e06734-9240-4b6d-adc4-18805aca16b4"), new Guid("61138fb4-8f75-4660-ac87-4bb9d5d700eb"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8675), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("78a14c71-20c0-48f0-8f9c-154b2425b5cd"), new Guid("a69261dd-e038-42bc-92e2-61914a5d7747"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8705), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("82b379b4-c005-4872-9353-160ecc501aad"), new Guid("f8fb8452-25fd-4d71-8d4f-9238ebd2e2f5"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8745), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("842f05d8-7854-417b-824d-d5367b060b84"), new Guid("f4348943-5382-4e3b-a6dc-f19e886ab3d5"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8691), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("84cc1a3c-ca56-4f71-b51b-6f4682336130"), new Guid("b544dcdd-644c-4820-81cb-6ab91f257ea8"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8692), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("88a711dd-e409-4f5c-82b9-c38d07e26b34"), new Guid("3501a2fa-2cd5-44eb-a974-58fcc2fbcc9d"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8740), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("8c367272-b400-4a63-a439-fd8ff2664cdf"), new Guid("06dab68d-f78a-4d32-9adb-e70d1635db37"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8661), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("9182e740-4cb1-44db-b34b-0ec9461838cc"), new Guid("a9fcf073-661d-4ba3-8533-266a7c394497"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8717), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("975c9d97-545c-44ba-b443-b034664b4ff2"), new Guid("f64e0269-98f0-4585-9c36-a2a1a83bbec6"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8737), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("9b95ce20-2dba-452e-a704-c8a7f27ec036"), new Guid("97db8e0f-a9ad-4a75-a683-268aaa21bd52"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8751), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("a519e04f-f30b-4718-82ff-765ae1492578"), new Guid("d36f6966-a25b-42c0-967e-ab93b3618934"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8710), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("a5aaa7da-9763-4bab-9024-52df3e76ce4a"), new Guid("8176d792-a593-421a-ba2e-61844a68d105"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8712), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("aa352818-5ff6-4e47-99d6-f767efc196af"), new Guid("3d9e9689-e9de-436c-bcd5-efacc3d70c9d"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8688), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("b78ed46f-12aa-4513-839b-912412b61ed2"), new Guid("e078d2bc-3094-450b-b487-d19c860cdb07"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8677), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("b852527a-e075-4b35-bbbd-d27e4bf642ee"), new Guid("210210a8-a789-411d-94b0-d4e35f0a0931"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8746), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("b8d23285-9cfa-4b2a-a8ac-634336e59c83"), new Guid("6c7c7298-3aa7-4704-9b3e-8824251b700b"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8694), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("beb26b96-2761-485a-a34d-a03580d69e3c"), new Guid("1490584f-0fab-447e-83eb-89314094ab21"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8682), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("becc457e-339e-489e-b3f2-101b01772ccd"), new Guid("021268c0-83d4-4f9f-a9f0-71e2235d885f"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8702), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("d8be2296-a27a-4820-b98a-9066e9f1d8d2"), new Guid("3a98c066-64ad-4c35-b29b-8604d3416eab"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8704), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("dacfd6a7-d67a-48c0-b94c-861ae22ffa11"), new Guid("c337f99a-dde4-40d3-92bb-a2751c2f739e"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8750), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("e72f925c-e710-4ecb-a8ce-932d151610ea"), new Guid("5b00b9c0-7230-43f6-bc2e-49a5426bf460"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8685), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("e99a3e6f-6d25-4d8a-a22b-cb3d1f9ef214"), new Guid("7d20cf2d-b2c8-4f41-b594-d7d00d4791eb"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8744), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") },
				{ new Guid("ecc65dd4-cdc8-4539-b671-36d670b5cb2c"), new Guid("35842473-4354-41b7-9b2e-d5f31654d234"), new DateTime(2024, 9, 4, 12, 57, 6, 869, DateTimeKind.Local).AddTicks(8756), true, new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165") }
			});

		migrationBuilder.CreateIndex(
			name: "ix_subscription_plans_admin_id",
			table: "subscription_plans",
			column: "admin_id");

		migrationBuilder.CreateIndex(
			name: "ix_categories_user_id",
			table: "categories",
			column: "user_id");

		migrationBuilder.CreateIndex(
			name: "ix_user_plan_client_id",
			table: "user_plan",
			column: "client_id");

		migrationBuilder.CreateIndex(
			name: "ix_user_plan_subscriptionplan_id",
			table: "user_plan",
			column: "subscriptionplan_id");

		migrationBuilder.AddForeignKey(
			name: "fk_categories_users_user_id",
			table: "categories",
			column: "user_id",
			principalTable: "users",
			principalColumn: "id",
			onDelete: ReferentialAction.Cascade);

		migrationBuilder.AddForeignKey(
			name: "fk_clients_subscription_plans_subscriptionplanid",
			table: "clients",
			column: "subscriptionplanid",
			principalTable: "subscription_plans",
			principalColumn: "id");

		migrationBuilder.AddForeignKey(
			name: "fk_subscription_plans_admins_admin_id",
			table: "subscription_plans",
			column: "admin_id",
			principalTable: "admins",
			principalColumn: "id",
			onDelete: ReferentialAction.Cascade);
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder) {
		migrationBuilder.DropForeignKey(
			name: "fk_categories_users_user_id",
			table: "categories");

		migrationBuilder.DropForeignKey(
			name: "fk_clients_subscription_plans_subscriptionplanid",
			table: "clients");

		migrationBuilder.DropForeignKey(
			name: "fk_subscription_plans_admins_admin_id",
			table: "subscription_plans");

		migrationBuilder.DropTable(
			name: "user_plan");

		migrationBuilder.DropIndex(
			name: "ix_subscription_plans_admin_id",
			table: "subscription_plans");

		migrationBuilder.DropIndex(
			name: "ix_categories_user_id",
			table: "categories");

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("00911f0f-6bc8-4c26-a206-acebd6430a95"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("021268c0-83d4-4f9f-a9f0-71e2235d885f"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("06dab68d-f78a-4d32-9adb-e70d1635db37"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("12691ae7-3280-4e8e-b2a1-9aa701b1f531"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("1490584f-0fab-447e-83eb-89314094ab21"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("1f3bb6ef-0e4d-472b-8ce5-056a4e07ba8b"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("210210a8-a789-411d-94b0-d4e35f0a0931"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("27dff1f7-831e-4845-9b04-0de21399cf05"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("30a2c535-36d5-489c-a87c-f3978fbc667b"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("31480649-94fe-4886-afc9-4b94e37c0dc5"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("33cdaa80-55b6-4ca9-ab73-4f50c987bb5d"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("3501a2fa-2cd5-44eb-a974-58fcc2fbcc9d"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("35842473-4354-41b7-9b2e-d5f31654d234"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("38394761-5998-46c5-96d6-a5e976f224fa"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("3a98c066-64ad-4c35-b29b-8604d3416eab"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("3d9e9689-e9de-436c-bcd5-efacc3d70c9d"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("3dd6df18-b6a4-492d-9dac-00ca3697c470"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("54ac2069-a5ef-48c3-bce9-232990261c8d"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("5b00b9c0-7230-43f6-bc2e-49a5426bf460"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("5f1af3b5-5603-4836-a8f4-48cc5e4c5502"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("603d97a6-d7c7-4603-b1ea-e089cd598e55"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("60e57af1-b754-40be-aa00-916fdba13b07"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("61138fb4-8f75-4660-ac87-4bb9d5d700eb"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("64a129cb-46fd-4310-b2ec-d9ef2242bb9b"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("6c7c7298-3aa7-4704-9b3e-8824251b700b"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("745d07c7-ac23-4d7e-b1cf-50f3f83559ff"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("76fa18d5-76d4-48ef-855a-f95ef6b0e16f"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("7d20cf2d-b2c8-4f41-b594-d7d00d4791eb"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("7d2367bc-624b-4422-9033-2f7aeaf62957"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("8176d792-a593-421a-ba2e-61844a68d105"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("936bf493-fd2c-4856-a592-b08ab9ff02b7"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("97db8e0f-a9ad-4a75-a683-268aaa21bd52"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("a37496f8-ea2b-467d-bf43-fe9964ad2201"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("a69261dd-e038-42bc-92e2-61914a5d7747"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("a9fcf073-661d-4ba3-8533-266a7c394497"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("b3ff21b3-802a-47fb-8fd3-16704d7d0b08"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("b544dcdd-644c-4820-81cb-6ab91f257ea8"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("b6468a7d-f7a8-49ae-af12-0e82dfd2e7d1"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("bee7210e-b8e9-47ab-a639-a287c9951965"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("c2826cc4-83bb-4044-861e-d514e0d9cb12"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("c337f99a-dde4-40d3-92bb-a2751c2f739e"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("d36f6966-a25b-42c0-967e-ab93b3618934"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("dd359ef5-e93d-4b0f-bf2b-26e870330290"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("df9a1039-997d-43cb-a478-ab546be639e0"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("e078d2bc-3094-450b-b487-d19c860cdb07"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("e42da487-2462-4cd9-b9c8-12eb1fe7d7c4"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("e4c5516e-08ba-4d8a-a38c-143e97d40bc2"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("f4348943-5382-4e3b-a6dc-f19e886ab3d5"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("f64e0269-98f0-4585-9c36-a2a1a83bbec6"));

		migrationBuilder.DeleteData(
			table: "clients",
			keyColumn: "id",
			keyValue: new Guid("f8fb8452-25fd-4d71-8d4f-9238ebd2e2f5"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("02daf37c-ec22-4494-9198-7ec6b305b9b0"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("1a84a7c7-fdd5-4024-bf7d-b7bbc221e108"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("1eb9d3e9-5941-4d7c-a3fe-c8f26648cb2b"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("422b2668-b2e2-44ee-803e-a67b927b4259"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("4452d91e-571e-4123-9071-cf93d96a19e1"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("53bd7a6f-3499-433e-a269-25d86703a421"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("6973d6f3-2fa8-4fa1-8608-117b7346d419"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("7417c3f3-4047-402c-87fc-afd8c45c5e67"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("7ea3c454-db2e-4edc-91c6-da1839a0a432"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("87c600cd-fbea-49c5-a7a9-5fa5f95011bf"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("ac1e8261-c167-4be9-b7d5-80214402e428"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("c3565153-e77f-46a3-a89e-a840311d209a"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("e563ce3f-df14-4f34-a215-5e8e30f53864"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("e8e6a672-b211-4f47-b8b3-cc2174b79873"));

		migrationBuilder.DeleteData(
			table: "modules",
			keyColumn: "id",
			keyValue: new Guid("19248b65-5669-463e-84d4-737ceaa1ec68"));

		migrationBuilder.DeleteData(
			table: "modules",
			keyColumn: "id",
			keyValue: new Guid("56268b89-d29c-4061-a218-fac5714be968"));

		migrationBuilder.DeleteData(
			table: "modules",
			keyColumn: "id",
			keyValue: new Guid("b70750b5-7a72-4dd2-9c5e-51854760210f"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("03b53456-235a-40fe-84c2-6216537214b6"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("078a71c9-c27f-40d8-81ae-341278f35214"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("0b9df756-2d4a-48ca-b78b-f55976ecd3aa"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("0e8d60bc-23a7-448a-b12c-2c1800190729"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("13220bbc-ade9-4ca7-95e5-a1d62721467b"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("27e73166-3bc0-452c-a40e-3a85d4db0610"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("3a1154ed-6d43-4af3-9019-4e3c219f44c1"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("4d2fec8b-64c4-419f-a5fd-0d9984ea9397"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("61e315b5-921d-4ad7-8664-56e6515498ad"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("6f76cf97-1b91-423f-8b93-c54cfed6d13f"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("7f4a4075-3e62-4fcd-9b3a-25d73628baed"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("8a0ae792-8795-41f5-a80c-e7d932fc3496"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("8a0c0a7f-b925-47e8-9a48-913467cf82b0"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("8b21b6b0-37bb-4665-bb00-e495cdfbb76e"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("8db2bf43-b3e1-42f6-94e9-456377df059e"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("ab08d7ee-dd44-4aad-a563-9f6c08f497d0"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("b2e574b0-a3d3-46e6-a2ee-83f1b0e2d0ec"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("b4bc027c-a8c4-4749-b85d-5221d7c2c3b3"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("b5e32e69-8bb9-45e1-8972-f13cfef18a34"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("b69e3919-245d-42c5-baad-d50adf20b6a4"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("bc46867f-c5ae-4322-8d95-c1bffdd5877c"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("c53d73bb-70d4-4b51-bce6-bf46850321c1"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("c562e47c-d28f-4023-8ee6-b72beabc955c"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("d206b389-6339-42e2-bafd-6cc484ccc0ec"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("df205189-c0be-4db8-8ce9-f1c843adc283"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("e48330c9-b81d-40be-8a7a-8043bf05aee7"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("f4ca7154-7606-48be-b7ef-b3b48752b991"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("f88c9cd2-a231-4987-9bad-153ee4da4cad"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("fcc25278-21a4-43bd-8a9a-a230f7e428e1"));

		migrationBuilder.DeleteData(
			table: "post_categories",
			keyColumn: "id",
			keyValue: new Guid("fe46730f-3157-4886-8930-543e68e25360"));

		migrationBuilder.DeleteData(
			table: "subscription_plans",
			keyColumn: "id",
			keyValue: new Guid("0f1679de-7c9a-46a5-b19e-8707fb922bb0"));

		migrationBuilder.DeleteData(
			table: "subscription_plans",
			keyColumn: "id",
			keyValue: new Guid("6f71e3d5-1b1b-4458-99ed-bd8d95be1165"));

		migrationBuilder.DeleteData(
			table: "subscription_plans",
			keyColumn: "id",
			keyValue: new Guid("719d7b27-b20e-4260-90d9-0f8797fd9fb8"));

		migrationBuilder.DeleteData(
			table: "admins",
			keyColumn: "id",
			keyValue: new Guid("f8318560-d792-4a23-acf7-a81aa5a6dfbd"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("07c50a6a-c7d1-1d89-84fa-1d57e9b23460"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("13e3cee9-406f-115d-52a7-3faed6bd63f2"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("155443f7-b948-755e-ed1a-abeb63d9d795"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("2154882c-5111-031a-675c-d597652a731f"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("2a09684a-6253-bb5b-b5eb-8b55b1815b07"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("2d370a44-9e74-0d63-a7e0-21c15dc54aa4"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("35404dee-e62f-e435-c800-a1f69e267925"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("4af8876b-1046-1c65-7bca-f2e67ece11ea"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("4e593e5a-49f0-7f1f-f5ae-c0f34d50cd1d"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("5045c22a-a594-e4c0-b0d9-a76b25535ee8"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("563afaad-c07d-4003-3c62-981332004fdd"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("568b5702-916f-1f83-f56f-64c9990e7e73"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("6320d256-b114-5975-5f1f-b0f2a6962142"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("746622bc-296e-8110-3d67-0b0ff9510a88"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("7864d72e-a048-e1e4-8481-2f8f44f8d5fd"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("81283f7c-c169-77e4-8855-79896be2327c"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("837a24e5-3685-b819-d179-1910241c89db"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("86ab8359-5841-92e7-8751-479e09610190"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("8a674c50-d80a-535a-4d99-e131834901af"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("8af0c46f-6f4d-8af3-3823-d88cbd1a60a5"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("a2f854ac-c94a-7583-0c51-f3166da59571"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("ac6fa1f1-dccf-e3b4-62c8-842fbad7ed86"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("bc0adbf6-a7be-b936-5f9c-b170709d5dce"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("bed06075-0813-4292-61f2-fa076d74d5b4"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("c0d3c6de-39d8-2f4d-3fa4-9e3bf768d268"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("c2e17491-2b4c-7550-dc45-c6b3131eb74b"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("d17de2de-8cf7-d12c-0c70-6fb874408fb1"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("db42a994-00e9-f1d4-8336-137d579b991a"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("ea836b66-d80b-bc44-fb29-64f18390995c"));

		migrationBuilder.DeleteData(
			table: "blog_posts",
			keyColumn: "id",
			keyValue: new Guid("fe80351e-be10-76c4-6029-f5df12e802a4"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("12d037c1-8ad4-4347-9796-8b34b1f5c4f3"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("3f23e47f-2c4c-4eb7-9dc2-2030fa63be58"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("78466364-b7fd-4402-8dae-472777e86195"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("7f64b9bb-c6ff-44f8-b370-16e5bdb200a9"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("94de5fdb-c05f-46e1-ad79-753d8ca03327"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("98d1bf91-8360-4806-af8c-16144c8f0276"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("cacca94a-b0f2-428d-a5d8-d5fba54dc09e"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("cf34a0b0-4b9b-4fb5-a80d-fcff570e7444"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("d6b23e05-bfff-4f9c-a30c-d36410adce1f"));

		migrationBuilder.DeleteData(
			table: "categories",
			keyColumn: "id",
			keyValue: new Guid("fda313e0-9081-452a-a669-9342181a315d"));

		migrationBuilder.DeleteData(
			table: "courses",
			keyColumn: "id",
			keyValue: new Guid("adda0879-b995-4c48-80ca-43198fa27c45"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("008dc7ec-0856-4ec5-8172-156693391ac5"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("011c4d40-a69b-42d3-9909-fad2863e9244"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("018fe328-ec3f-4f3b-acbb-68fc263d8293"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("019542c4-3cc6-42b3-9845-fd6912b84a12"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("048114ab-e8cf-4a9c-80ba-5573ef005e39"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("08d25560-04ea-4b27-9c1e-000d1258ef52"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("0d9553dc-8712-4935-8f64-089039406388"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("10a0f2ad-9c7a-4af6-b5b1-c2a842ff8cce"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("178d1951-cdc1-45c3-a0c6-b65faad8fdf8"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("3600cb46-645a-4137-b510-046d732760d5"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("3ed06120-2d6e-4545-9886-4a1b8845cc25"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("423f14af-de51-4112-b18e-54803c5d6792"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("48a4658c-3a9e-4e54-ac58-8139db3a2f1c"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("4cebea30-5096-49c2-8cf0-f92f38185d96"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("4f56575a-ac02-4702-a6d1-78e44039b62c"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("51b6adaa-504d-4be1-af50-63daf9f82922"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("58538d27-2f94-44a6-b2fe-8a2c3993f7f5"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("5bf4aa72-5fde-4328-8bcd-625391341d95"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("64590e25-be72-40d6-a3b2-bc8930b24a33"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("66f11611-f3c4-499f-b8e0-bfa155ceadf9"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("694d0942-a7a0-4c6c-9173-cd066772960d"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("6d11af22-c913-4552-8d6c-9ccaac41604d"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("6e512973-4ce3-462a-bb1f-bdb92ab857e8"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("7027a7c8-1d09-4f34-ae95-034a50213416"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("780e5534-0f0a-4c28-927e-715cae07229c"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("7aa01519-89dd-4dbb-8d79-46bfa872154e"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("80cdb149-fd1b-4ab4-b116-f895e573f2fc"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("83a567a1-2884-4f65-b7ff-99beeebd1c41"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("8aa1a1f0-924e-47f7-9299-da1c908d0193"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("92826420-9e14-4152-b8cb-38a0e41a4263"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("978361cc-86c6-405e-b901-331ce9ce7ff3"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("a3486547-b63c-45a0-a375-36742bd1c9a9"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("a5123659-865b-44fd-b75a-be1df15b1581"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("ad1b1cf4-a57e-4dda-bacf-7fbf590dd3de"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("ad2eb12c-792b-4b71-913b-0cecd0d7d441"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("b72a5e23-e8b9-4341-b278-b9df4c87b6ab"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("be8a4fe2-ca2b-4144-a13e-6840515593e5"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("c8a697d5-469a-4972-b4fc-7ba8e8a6a474"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("c9969727-99b7-45b9-ba55-74dd467c0feb"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("cf803453-8606-46ad-958d-1eeb855a4cf3"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("d4e7e8ba-2fbc-4a53-870d-72227675423d"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("d515e32e-75ee-4a9f-ae3e-26c6192d0006"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("d82fdf03-b026-4690-9661-1f0314f8bc39"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("dc9d2469-9696-42ec-a26e-9189a3a9374b"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("e74d2547-ef4f-494a-8d5a-27878c1c24ed"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("edad418d-dc2f-4c14-b4d4-8208e432085b"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("ee6ecd2f-720f-480f-9cfa-8969c212eff3"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("f412c4a5-2b43-4d92-b119-5201521feddf"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("f723968a-85ba-4c10-adad-8e0377f6d6b8"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("ff11bfff-4a52-405d-88ce-2a04ae271149"));

		migrationBuilder.DeleteData(
			table: "instructors",
			keyColumn: "id",
			keyValue: new Guid("d05532c7-e5c5-47e1-a83f-39d798ef2e33"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("04c12160-bad6-45ce-903a-67d1afeffe72"));

		migrationBuilder.DeleteData(
			table: "users",
			keyColumn: "id",
			keyValue: new Guid("17813b34-21b2-4f1a-b6bc-bb4e2eb4b734"));

		migrationBuilder.DropColumn(
			name: "admin_id",
			table: "subscription_plans");

		migrationBuilder.DropColumn(
			name: "user_id",
			table: "categories");

		migrationBuilder.RenameColumn(
			name: "subscriptionplanid",
			table: "clients",
			newName: "subscriptionplan_id");

		migrationBuilder.RenameIndex(
			name: "ix_clients_subscriptionplanid",
			table: "clients",
			newName: "ix_clients_subscriptionplan_id");

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
			name: "fk_clients_subscription_plans_subscriptionplan_id",
			table: "clients",
			column: "subscriptionplan_id",
			principalTable: "subscription_plans",
			principalColumn: "id");
	}
}
