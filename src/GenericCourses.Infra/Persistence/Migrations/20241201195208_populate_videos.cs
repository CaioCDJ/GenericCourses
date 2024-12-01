using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GenericCourses.Infra.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class populate_videos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("71437401-01dc-4c1a-91e2-249b7cc288e3"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("0a478e68-e7ae-4847-9096-0d3e14a313b7"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("22ab4d9d-cf7a-48cd-9458-0dabe57437a4"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("5eacd8d0-77a6-4001-b796-d01db6205f33"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("5ef1a318-94c7-4c55-9d57-0e78f5af2377"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("68aa8e85-9c06-48c3-a9fd-575c9bc4e91f"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("6d21efb8-eda7-46b8-823b-640d13387d74"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("70edd3f0-56dc-4c21-aa0a-e66cbe7d16b7"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("76a52d36-8b1c-4fb4-9e04-cb658ff67ebc"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("a11bd6b4-1853-4e07-883a-f4d2def6fa5b"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("b11d827a-8b67-4e24-9517-4739b848bbc9"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("c1e9a31e-3891-48c4-baea-a765e46e695b"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("df8f70f3-8a09-480a-a318-a4055a5e487f"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("e9222da5-ed7c-4a72-92f1-2dde153e385c"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("ef6ac9d6-dd48-4999-8637-28a06728f1eb"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("02b2fef8-f046-4334-b4d8-681ff5d7837a"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("05230f77-464f-4496-9d33-b9211f4255e6"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("112626c1-0973-44db-aaf7-5b0413a8cf08"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("1148148b-cced-418c-95dc-7da5659155d7"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("1615d073-7ac1-4259-8675-2a45d8fe02e2"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("1871d038-7760-4daa-b6d3-8d28d4bc56bf"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("21b839da-1a8c-45ac-b07d-8cc5ac73f535"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("2663f693-394d-4cb4-8fc1-a802f23b4f49"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("28009f9e-431b-43cb-be0c-b8397f3ab550"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("2bb25501-e005-47bb-ad39-2dd1e21ce4a1"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("3b2ccf59-d87f-4ee7-a2be-536c26662b1b"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("561902b0-ee5b-4dfa-9388-6f3dda4b7cfa"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("627d118b-59a9-457c-abc9-ea61806f817c"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("6492bf67-7023-4d8e-818e-d2d7195896b7"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("772c6d56-4845-4941-9926-5cde73c2af20"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("797a810e-eba6-4579-ab38-4b02e213a186"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("79ffdc58-66a0-422e-82f6-55b1f2b34b73"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("7c8e1ec2-540a-4997-8ffa-bcee1586b88c"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("87cc73e1-5564-42af-8a04-0f9cac650dc1"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("892e79a7-d12c-4cb5-8ece-b5650ed9cbf6"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("9b3c967c-d7b9-4b3b-ab37-c56f3f090d1c"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("a670cc3b-9378-486a-aa2b-ffb21261f261"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("abfb3161-a89b-4eef-abad-eb930312c67c"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("c7e1a6ee-377d-4aa8-b186-845ce819be54"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("ce2d3865-16ea-4646-a61e-9e77dc6a8e76"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("ce3f1b4b-186f-4416-b31e-fec5e44402f6"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("df68acb3-5b8c-4d74-8765-7d5a91706982"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("e5b7a181-7aee-4caf-9628-3035b9d6a986"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("ebaab7a5-7250-4878-95df-b80b56c25016"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("f2d18f8f-668e-42c1-919d-2744835a94c3"));

            migrationBuilder.DeleteData(
                table: "subscription_plans",
                keyColumn: "id",
                keyValue: new Guid("137a74a5-22d6-44d5-b6e4-2c6e0a1113a8"));

            migrationBuilder.DeleteData(
                table: "subscription_plans",
                keyColumn: "id",
                keyValue: new Guid("b3eb22e2-844f-46a0-b34f-78b149c6a836"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("076574aa-f5e9-485a-9a4f-1d06d444533b"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("1477dd53-b997-43b1-b4c2-3d4d53d49e82"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("1c6a39e1-aca3-4464-b0b8-ebfb4701e39d"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("1f526f2e-efaa-47aa-9987-ed92f7562792"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("1fefa3f1-4bc2-4a91-968c-8ec6e051c0e9"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("254675d4-227a-4ce2-b1a2-5323fbb9440d"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("29252470-2e0d-4af0-a12e-e171a10b88ad"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("2d2d0daa-75b2-4e9d-ae86-95132f198940"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("2d54dfd0-04d5-4e34-bb41-37e077bf6ed0"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("383b7430-1ff6-43a7-b2d6-d52591925342"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("385827f3-b0f1-49d4-804f-2193ee47e53a"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("44848ea9-b1e4-447f-a561-e4bdf657ab0c"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("4794a73a-a251-4b85-b52b-f1fb0a35f419"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("53b2787e-e2cb-488b-bffc-cfabd73d9fa5"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("5c116098-51c5-4ac1-8793-06cf93cea478"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("5d8d2ea2-c257-411c-9a20-ceaacce294d8"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("64db0ad4-e901-4aee-9a59-5f806f217e8e"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("6596998a-90bd-4f20-880f-f2dddac29ae5"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("6cd2a5ac-e87d-491c-bbe0-c2b46e5e91bc"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("7109e8a5-523f-4ee9-89a3-d8d8132d6add"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("71bc0bad-6742-49e9-837a-cede145d043e"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("77a7275e-45b9-4514-a8e2-3d9cba18c03b"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("7d53e356-018b-44d3-9dad-6a974f82599c"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("809fe17f-8938-45e1-8db1-7578d3eda470"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("87c3f9aa-41f8-40bc-b401-05e2e0eae07a"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("8cfa6c5f-2302-445b-bd5f-70dfd4287e2d"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("8d6e94f9-bf41-4188-b358-2d1af6f41cc5"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("912b8217-7e04-40fa-941a-6df4a9e0afe9"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("93b5188e-3fcb-469c-be1c-780ffe7eb24f"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("a1e126d5-4966-4cc2-a91f-5f1cd9d5c230"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("a2770318-b662-44b6-aa1a-9a6e49d4ad06"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("a7961f6b-6cf3-42a9-a8bf-28a51d45a9d8"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("a8ca150e-c1c3-4d87-95a6-c0fbc2c0e3f3"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("aac3123a-2e72-4a23-b8fd-586c41ab89e9"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("b45c03c2-90d2-40d2-89c0-d8a33d2b75fa"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("b7e8ce4f-3940-4b6e-a462-0e3d9303fe7c"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("b8f292ef-24e0-44ee-825d-3af99a5a057f"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("bcb4818f-68da-46b6-a9b2-342f6c87023c"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("bceb7d85-2046-43c1-b582-552c67e9e224"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("cce33f32-7929-4546-87ed-c2a79c92d3e7"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("d165271c-0b09-40ba-a323-51aef90201b4"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("d23963d0-f6ae-4174-9a86-f75b2bfda072"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("d292ea94-7723-41ec-909a-913984a1607f"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("d8a5f7ab-32ff-4c1f-baf5-4901a912b6db"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("e59ea8be-4963-41ca-9bb6-64edb2ef4024"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("e9bd3122-65c5-4045-aeba-b075d09c6341"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("ed02cc11-5234-4edd-8947-9c543a83e887"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("f0a2c1a5-17d4-4718-88c4-8f8a2f1ff89f"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("f9f1c652-342b-4d5e-a3de-c3c6c387e62a"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("fbbbcef0-398a-431a-8bbf-dd6c4b727d3e"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("034540b9-da82-4764-94c6-78a6463ca972"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("0f92a9e1-be38-47d7-bcce-9c73b3d6f2c7"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("11d4f818-4de6-4d5b-8570-d11bd50b5154"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("18ae2466-0637-4e56-8517-2d2a1d0c1ef6"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("1ab3e03e-d4b4-488b-b2cf-60067d066298"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("1db51045-f877-49d5-b5b1-3af56450be46"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("35117448-6bb1-4231-a814-370b229a0ad5"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("4202ab2d-ee88-4100-ac6d-fc7f301d4960"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("4560c5eb-3918-4425-91ae-bcb28ecc8ef6"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("4b236da6-3c3c-4cf8-b735-5c68a28014ac"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("4d064dc1-73db-4a90-8555-d52209aa5666"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("4f6b13eb-ea23-48b4-909d-4d9a473762f4"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("55e5b2c9-8de7-46d7-bc90-2452f0eb2de7"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("5a3c2e87-9e52-477a-bd7e-c9f1f843c71a"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("60844889-1a2c-4a7f-b3bf-495959eae202"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("6529c8a8-5457-4382-8bcf-537597cf5f5c"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("6918f18e-3354-482c-934d-81d497f1802a"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("694c0347-f4a9-420c-820a-b2ed194e1a09"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("71f5787d-1742-49e2-8bc1-6d6e7f3860c3"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("73c89436-fe51-4eae-a662-f437fa0a5d62"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("81adf1d9-dbb4-4a70-8e46-08ad0cc21f46"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("950d0de8-4f19-47ed-8abe-6696f3aff10c"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("9588faf7-91df-4965-83d3-9d7d0625c71d"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("9bd9960f-8529-4522-b5b5-0a9b3b88ecbe"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("9df9260d-df86-4c6f-8bca-a4249c848197"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("b75fea0c-1a09-4080-8717-6dd7386c0eb7"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("bf9b54f8-c4bf-4901-a39f-3a832d704359"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("c53c0630-ad98-4f6b-a99e-3380cc6b9b22"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("f4e35620-617e-4bc8-8987-09a6285ff4f3"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("f7f56bca-18b6-47e2-81ae-46d47a68fde8"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("03113096-7277-16d7-1236-e3b72b1a5c2c"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("04617aa2-b625-3e11-3298-2c07d93cac72"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("12c23c11-5136-34c0-07c5-9bf5b97fe0e1"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("16ac12a2-cde3-550d-e707-ac7dc24d3dc1"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("25e947bf-8cfe-8c55-0e09-88d29c945e3a"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("27aacc87-7332-9380-af14-bfd9c25abc05"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("2bb683ce-b44b-64b3-3d0e-4c5545684f4b"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("3b9374c5-ea43-df4f-c651-928e277f9e10"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("3bcef47a-827b-5210-3ce3-1cbd0da9f804"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("44deeef2-1e5a-313a-269e-1c9a0be121af"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("5c21f354-1859-210f-4fd1-164d00edb175"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("71d5f497-c3f5-7ba5-be68-bf5b48ae78f7"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("726d4627-43be-0087-d237-d91e29d7f685"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("7bc274f1-37ca-8c89-55f5-ba48918b0a91"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("7d2124cb-44d1-c562-3394-96d4b15bd3a6"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("7ece7dc2-3454-0445-e14e-3885a11ecc6b"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("82e37d0d-d908-b7d1-5c8b-e0d3e3b99751"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("840824b3-cda1-9246-7b3a-b04853b7c281"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("86a09049-fb4f-dfa2-6694-91a7d12fc6fc"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("aad6c4dd-c2ea-3cf2-4bb5-f13de96fa582"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("b18b945d-c1f4-17cd-5c91-f6a83c68f179"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("bb7fefc6-f358-f7f9-34a6-fb5375e01333"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("c1475282-b552-6268-12cf-7b100c27ffd3"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("c7c8ebae-6684-9725-e580-18f2bb69b04e"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("cc361c8f-3fb7-6ff9-5bda-ae1c18c8f415"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("dfc6cacf-ee87-e982-549a-8f241acc11bb"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("f9ed9e57-efa6-118f-8e77-16c598a08766"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("fbbd59e3-54ef-24bd-d67b-bc48d46a809f"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("fe262ba3-a6c7-02a2-115a-545f8252db6a"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("fe5f7a9b-1e89-b024-2aba-a74e6887cc62"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("0a9b1bfa-8786-4380-b432-236b2713d83b"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("2509ec8d-894a-4bd7-b589-f5cf51b182ea"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("2dc6b4d6-da39-4361-b59f-733a2d6e6e88"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("35ac4204-fe64-47c9-a95e-24ea4bd0af0e"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("3832821e-62a6-4d2a-9678-a7a1daaae782"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("41c0c9b0-0f2e-44c7-b898-03081ca816c9"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("d1744b79-1801-4704-9c48-26832fa10926"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("d445ba32-5a2e-46af-8097-d2eccafb0b12"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e0c19352-2902-44ee-969a-ee2f5034c252"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("0080b621-4c02-4c6c-8fe0-47c4037a6ceb"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("0c448140-80eb-4603-b70b-f9df17e34532"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("13f75d9d-55d7-49d8-bd92-623dcfad435d"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("15df39b0-4cc9-4b85-984e-556f24bec4c7"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("1cf55ba7-f8d3-4a23-a207-409ad11b9569"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("226188f3-9384-415d-80fb-b3aad97e3f29"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("259e5b80-5fc4-4ce9-90b6-80b1151018f2"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("2623fff3-e4f2-4b16-8c53-43e8d439e3a3"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("2e234351-7f87-49d3-9462-86a58f83f675"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("318f1742-dada-4215-9ed3-22bab51ab8f6"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("34ee8734-28a0-49f9-989a-afe5d1c88c7f"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("39e9aef6-64d1-4dd3-ac03-ef4d881ae833"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("3b2773fc-d8a4-4499-a277-4fa5d15f7ec1"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("3bc9aead-3609-46be-a4e1-5904790ffc94"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("4834a7fb-3877-46c0-b7ce-b955a8e9ca01"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("5689ab59-a8a6-48f0-86b1-d596588aebc2"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("604b4b52-c9c5-4097-af1d-417b471e3bbe"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("6569cf25-6b29-4022-a698-6d5454e99601"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("6eb8cd3b-b62e-4d03-b2a6-12d961f68996"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("7bd3528b-e8e6-4c76-b454-26554757bd0d"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("7e17451a-f1a7-4867-8eef-513ec8d9247a"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("7e25fd11-5c96-4923-8452-4dbaf423f65d"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("8ba972ba-e2a3-4061-8464-812f103f77e2"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("8edcb7b7-d0d7-4cb9-b748-97549ac0d644"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("8fb2bad1-2bd6-4510-b6c3-fbcaf6bd6598"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("91f14f7f-45ed-4009-8781-e2c7d09a97ef"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("930b853e-54ff-49d4-b24a-e120ee7bcafa"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("9457a1b3-e988-4f04-be2b-91c6546e7adc"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("966c3dfa-4579-477c-a40a-8eafa5a9b653"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("97768b8f-30c8-4cda-8d2c-20316c5348fc"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("9f18c287-d3c7-444c-bc16-44858779cfa9"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("a7e93cfb-5fb2-4aa6-90e1-73b39a5dfe7a"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("b174fc0f-14cf-42a9-a466-04e30128f65c"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("b4d8a8f0-2d5b-42be-8094-e5630e4f98e5"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("bcaf4dff-dc2c-4277-8adf-b4b0745f3515"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("c0a688c7-07e4-42f1-af4b-5020671abec6"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("c3baac2a-95e6-4f07-9360-f2ad44f1971a"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("c42149f0-6cb0-4b10-93c5-e82b0ae91642"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("cda26145-2357-432e-9d85-b5714ec60f60"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("d247cf23-016c-492e-8ee3-a4e7438caf88"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("d9d1e411-bb83-497f-adfc-49eebd8b992e"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("e0e3a5fb-48c5-43d1-8a0e-31348d7f1bae"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("e1e640ea-1028-4d9b-8092-abb73745cd89"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("e3ffe204-ba7f-4163-bdd6-aba943f38a3e"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("e8b4f59f-426d-4470-8d62-c4eaf0d840db"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("eb1e666f-e9cf-412e-b105-c9d31d45d0e5"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("ecc36acf-5565-4887-9bec-33c02c09cab1"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("ed65540e-8614-40c0-800d-b60be05b5f21"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("f10bcee3-251e-4c5c-abac-0c70f7d8609c"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("f7084b48-0238-46fc-8ad6-7868be7fa721"));

            migrationBuilder.DeleteData(
                table: "modules",
                keyColumn: "id",
                keyValue: new Guid("6154d96d-a065-4d5c-a208-97b2659a6c56"));

            migrationBuilder.DeleteData(
                table: "modules",
                keyColumn: "id",
                keyValue: new Guid("8b015273-3d89-48da-a54b-ee67bcce60fd"));

            migrationBuilder.DeleteData(
                table: "modules",
                keyColumn: "id",
                keyValue: new Guid("aabd7ae5-0926-4fe4-89d2-9ee7bbac5f89"));

            migrationBuilder.DeleteData(
                table: "subscription_plans",
                keyColumn: "id",
                keyValue: new Guid("54fce32b-611c-43ec-97e8-196279c85ffb"));

            migrationBuilder.DeleteData(
                table: "admins",
                keyColumn: "id",
                keyValue: new Guid("8c0e2162-1b8f-44f3-a94a-8f000587e335"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("7922fb70-c12d-4c08-8376-eb3ca40f3f41"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("0a71e436-6fd5-4509-8d00-499d96195b43"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("0b51c53c-56d9-47cf-82c5-99c9d0055864"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("0d1e3bed-7f12-4fb3-b17d-258e4f04efb8"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("0ea719fe-2a1e-4c1f-a8a5-0dda317d7a48"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("1e63c5bb-4c6b-430f-a329-548a05972181"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("207d8b6a-83d3-41fb-ba73-56a41f3b296c"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("2341eaf5-0e88-4dd5-8a03-89f1c841ed80"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("2674045d-95a8-47e1-b775-cd694e59c6ad"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("2aed3e01-d23f-4bf5-94bc-08a96f1988a4"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("3992a175-8687-49e6-8169-c9e2e6e32bc4"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("3d1b5b95-1a55-48f8-8cc3-19d1f73a5880"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("44207249-caa2-4d61-badb-46ad98a377f8"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("4d9daeb8-b51b-4a65-b15f-812f972b8bf1"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("509e9dcd-eb75-4a41-9924-a972ea8abccd"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("57904966-89d1-486c-bab1-49a46900d720"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5c8eb36f-04ee-44a1-8c8d-ee268f835c9e"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5cd134c8-306a-45ba-be55-01b433b6058e"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("665ceb2e-e0bd-4a42-9ebd-2a1d377de1e8"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("6b4a3857-21ae-4382-989f-bce56e2fd635"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("6c929e3a-45f8-4255-9cd7-2f71163274b1"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("71ced500-0ddd-47e0-a18a-edb64193c6f4"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("778c6ffe-f19e-413e-bd82-237a14fde56c"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("7f6949a0-9654-4317-9936-52a356027cda"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("8047a626-9071-45a8-b6e3-dfaef9793fd3"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("820ecd5d-58de-47e0-8d1f-ae4c7f369e49"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("862dc151-bb7f-4238-861d-982abe141267"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("89dca35e-c6e3-4641-9523-97b9af93e55f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("96a812db-e993-41a9-bf56-5381c52f331c"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("9b2b5ee5-72f4-492d-bda2-52018e4d7935"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("9e1d0cf8-9669-418d-b739-ade5dc09d0fb"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("9e65a702-42dc-4087-98e2-b2eb4e77d8e6"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("9fd123a8-12b4-4a90-92d8-c92e39ea187a"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("aef9cddc-92ca-4beb-97a3-a3c71dcf55fc"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("b03fb69a-f0b1-4942-a8b1-6cf94e5ccfa0"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("b1666ea4-b8f4-40be-8830-35defa6699e0"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("b74bb4e6-6b8b-47f8-8eae-535c04a52b0f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ba2440fc-712e-44b6-b96c-237e54b2712f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("bc477eb2-e9ef-403a-b2e7-a37a10504bf1"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("cf09ff0c-08ab-493a-8841-1d4edf58d5f7"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("d0111fdb-9db8-40ce-b0b2-5e4bcbfeb575"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("dec3f32d-75b2-4390-82c9-09e39ea7d606"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("e1818a1c-d026-47f2-af7d-6784537a3b66"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("e4473b1f-6857-46cc-8c74-2f04322e6733"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("edf3cfe0-9c03-44c4-a389-ddd91ff43ff4"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("f01a531c-da6c-4c3f-9f9b-2850728d79bd"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("f6b60f73-b232-4a0e-aad1-bf4eed87d352"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("f8c61400-d1c8-49e3-9e87-7b5d3a53d4a7"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("faa1390d-ae63-451e-b94a-9341c87cef11"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("fc20f29a-4655-4922-bd15-4f1f490875b3"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("fdcc8502-12fd-458c-be02-c4e484b9dd0f"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "id",
                keyValue: new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("cdaf0fe3-bac1-4313-b53d-a2d9dd5ea5dc"));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "cpf", "created_at", "email", "is_active", "name", "password", "phone" },
                values: new object[,]
                {
                    { new Guid("064397b2-22d9-4d4c-88c7-8967381f6376"), 13748312806.0, new DateTime(2024, 12, 1, 16, 52, 2, 372, DateTimeKind.Local).AddTicks(7122), "Alessandra_Souza@live.com", true, "Margarida Nogueira", "$2a$11$B.lBWbBcYXUkFDhnoV2N5eRybvllf5l7gyXJP/RKDM7IiygK2BOPm", 80549969658.0 },
                    { new Guid("083066ae-76c2-4e9a-85ec-89517c4df628"), 67614531434.0, new DateTime(2024, 12, 1, 16, 52, 7, 639, DateTimeKind.Local).AddTicks(1318), "EnzoGabriel_Carvalho0@yahoo.com", true, "Matheus Moreira", "$2a$11$QGGXYckV9o/7o4OOj8.o/.jeLW6F0Xnclb2OnCiXpGqrdfQLXVJMS", 556339728768.0 },
                    { new Guid("0cf6542b-8d88-40be-bd6c-193237a8277d"), 74175989862.0, new DateTime(2024, 12, 1, 16, 52, 2, 606, DateTimeKind.Local).AddTicks(5790), "Isadora_Melo9@yahoo.com", true, "Júlio César Nogueira", "$2a$11$FRS6aXxmdu87tZOBfBGnyu.LJUJKcq2sB0vhLK8r9BeC.LTJJVc/m", 558026884091.0 },
                    { new Guid("0eaea012-832a-426c-b207-1d9d3a5cfe65"), 8432328545.0, new DateTime(2024, 12, 1, 16, 52, 4, 365, DateTimeKind.Local).AddTicks(3772), "Rafael19@hotmail.com", true, "Beatriz Silva", "$2a$11$GhpCJ.W/ke2BJvY5iwvaJ.t3.Ytd1h.RWTMl1q//TavnI8ZQE5.rm", 553803566714.0 },
                    { new Guid("138b44cd-e074-4c3e-9ac6-ce59379f7138"), 74227232465.0, new DateTime(2024, 12, 1, 16, 52, 2, 840, DateTimeKind.Local).AddTicks(1104), "Valentina2@bol.com.br", true, "Alessandro Reis", "$2a$11$vHeL2Ep27OwOvUOpU4HEAO.vnrvkfyqYu08vqRfjJaLEEhHRIggqi", 16095033652.0 },
                    { new Guid("1648b9be-0713-461f-923e-326ed771ed4e"), 92367032246.0, new DateTime(2024, 12, 1, 16, 52, 7, 54, DateTimeKind.Local).AddTicks(8307), "Fabio_Souza@gmail.com", true, "Sílvia Souza", "$2a$11$M0LLVDLlQULB4SRib.hWcOxnRjlsSVHPF3.HxKhF8bnsIZwlXHUbO", 557374767331.0 },
                    { new Guid("192fcf7c-c7f8-42fd-a711-c075799483a8"), 123456789.0, new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(3540), "professor@preofessor.com", true, "instrutor 1", "$2a$11$oCBzi98SsxyyTMc/ey2SHess1a2TRr.nMpG5ttiCiw6NRB96yiURy", 123456789.0 },
                    { new Guid("1b490536-daf8-415d-8af2-73e7e4c94738"), 57557627830.0, new DateTime(2024, 12, 1, 16, 52, 6, 586, DateTimeKind.Local).AddTicks(4008), "Silas16@live.com", true, "Enzo Gabriel Silva", "$2a$11$.wyb3gRSbIuYc2OR8wAT7OmCPBxHDW1FRLKlQzujOBjPD9Iqv.lu6", 554063855817.0 },
                    { new Guid("1eac9ce2-33bc-485a-bddc-4834b529dbc0"), 5432447924.0, new DateTime(2024, 12, 1, 16, 52, 4, 14, DateTimeKind.Local).AddTicks(9909), "Natalia38@yahoo.com", true, "Valentina Moraes", "$2a$11$oWC7L/LCAeGImCBPDHLFu.fxLU2Fm/Bhdydv/cNOY4K38J3fxn7OS", 46113185240.0 },
                    { new Guid("25593bc9-6849-4e48-b0d5-861ed2b1bfa7"), 92680109503.0, new DateTime(2024, 12, 1, 16, 52, 6, 469, DateTimeKind.Local).AddTicks(5350), "Fabiano.Silva53@hotmail.com", true, "Pedro Nogueira", "$2a$11$Iqyd2BW6LSp3k2MtKaIw0.0WqrQRq7k8yvGnmDtSkWmpHsmwORHgO", 558310417890.0 },
                    { new Guid("34b8d886-3510-49e3-8f9d-5f30433d0329"), 44615558953.0, new DateTime(2024, 12, 1, 16, 52, 1, 904, DateTimeKind.Local).AddTicks(7950), "AnaClara50@gmail.com", true, "Isabella Martins", "$2a$11$mWTJBpqW3l2pVjh/MGMgyeexj.PVHAymn8wAtEg5.a..ugthaqKQG", 559722518147.0 },
                    { new Guid("374656ce-5d39-4f10-b2a0-b18733b59d5b"), 77449898306.0, new DateTime(2024, 12, 1, 16, 52, 2, 21, DateTimeKind.Local).AddTicks(8156), "Fabio_Saraiva63@yahoo.com", true, "João Miguel Moraes", "$2a$11$eP4JvPBce.aEX0xEP2nbouD2zA5aHtCPt84bbPuWa0H0RWFmrdsfS", 634891406.0 },
                    { new Guid("3d467700-b50b-4965-81d4-f772d68f5f01"), 8688173761.0, new DateTime(2024, 12, 1, 16, 52, 3, 543, DateTimeKind.Local).AddTicks(9693), "Fabricia17@hotmail.com", true, "Ana Clara Braga", "$2a$11$W/O9t.3Bm5jvAKiUlgbqOu1SnP5HxfvffKqe..IuiQmmmACQf4Fym", 3853184577.0 },
                    { new Guid("3f980e2b-abef-401e-97ac-d2fc95b43271"), 85635336221.0, new DateTime(2024, 12, 1, 16, 52, 3, 73, DateTimeKind.Local).AddTicks(6112), "Suelen.Barros@live.com", true, "Luiza Costa", "$2a$11$BitnLVNFOt8FdZI8RtsOf.KAqxUl/JdMGAfnWZrnRta/qq0yyb0Sy", 557103240181.0 },
                    { new Guid("467d2937-e9e5-4dd8-8727-4e9eeb97560a"), 41602655960.0, new DateTime(2024, 12, 1, 16, 52, 5, 417, DateTimeKind.Local).AddTicks(9718), "Gubio_Franco79@hotmail.com", true, "Marli Braga", "$2a$11$kAfGWdpKGbJYNJsiY8H2s.CbglaGcvuL3pmwLbnWhjvoRCnTTNzYi", 552752080297.0 },
                    { new Guid("4b8db70c-30bd-4219-97b5-7682f58a19ee"), 26985081673.0, new DateTime(2024, 12, 1, 16, 52, 2, 723, DateTimeKind.Local).AddTicks(2807), "Antonella_Oliveira@gmail.com", true, "Yasmin Reis", "$2a$11$CQwveTSCEQVNDoOFjWyES.vnLwiXovC6h3VCweHuOUAlj.tLBfpZS", 66979672657.0 },
                    { new Guid("4c65bf0f-41c3-4cb2-ac66-5437927fb874"), 78655450022.0, new DateTime(2024, 12, 1, 16, 52, 2, 489, DateTimeKind.Local).AddTicks(7806), "Isabela.Carvalho82@live.com", true, "Maria Helena Melo", "$2a$11$YkCnzdOsTP6WtoWfgtDk4OWe2UQ97Yhc2m9jiT17PWdBxc3JWHe3G", 79722715730.0 },
                    { new Guid("4e0a9611-bb9a-4944-a408-80cb836c05db"), 66533992732.0, new DateTime(2024, 12, 1, 16, 52, 3, 307, DateTimeKind.Local).AddTicks(3351), "Sara.Carvalho@yahoo.com", true, "Lorraine Melo", "$2a$11$.9PemDgkMJA0Jdta4nUkiO97V/JXnAptgEwN76C5SC7DWHNdr56p6", 90604748422.0 },
                    { new Guid("58afc5d0-9d94-48c0-81b1-4399d7c448e6"), 19201848056.0, new DateTime(2024, 12, 1, 16, 52, 4, 599, DateTimeKind.Local).AddTicks(1563), "MariaJulia.Saraiva90@yahoo.com", true, "Murilo Melo", "$2a$11$Ac.iJASZjxkOYJoMNeWpd.AykIPrwOunv7CutlKA8Hmg/HPAUvA3q", 557884976483.0 },
                    { new Guid("5dce78ed-bdd4-4e1a-927d-8ea0037bca0a"), 53660628700.0, new DateTime(2024, 12, 1, 16, 52, 5, 768, DateTimeKind.Local).AddTicks(5270), "Caua43@live.com", true, "Norberto Moraes", "$2a$11$Cgj1g732Te3RLUNt4kOwSOTXdK4A6w5DYCL3ssWUQUtxCw3n08SyS", 74633460.0 },
                    { new Guid("5ff114ba-cfe0-42ba-99ed-531e98147d47"), 343963493.0, new DateTime(2024, 12, 1, 16, 52, 7, 288, DateTimeKind.Local).AddTicks(8171), "Feliciano78@yahoo.com", true, "Yago Macedo", "$2a$11$u3vx6Ua/KG/R8FAKZFtXO.5WMrvK/qY8VrWYu8nmsrFB4HXME8Kpq", 66842945815.0 },
                    { new Guid("616c8716-43d9-46ba-bb46-2be4d6e8132c"), 48142045583.0, new DateTime(2024, 12, 1, 16, 52, 2, 956, DateTimeKind.Local).AddTicks(7928), "Lucas21@gmail.com", true, "Hugo Carvalho", "$2a$11$L9GzcU.HJVKTyMWRCDgXMeyWsgfQZPQh3SFj6ywwcPLFsA6AaTvby", 555075617058.0 },
                    { new Guid("626edd52-ad1e-478a-a031-072c9de14e73"), 17931991672.0, new DateTime(2024, 12, 1, 16, 52, 6, 236, DateTimeKind.Local).AddTicks(1657), "Isabela28@gmail.com", true, "Lorraine Saraiva", "$2a$11$WDngkcbLTt5u7kYquxGZr.nGy.CATdU6zoZd6g9lS7qCpXmjIZGIa", 552768074023.0 },
                    { new Guid("651458aa-aea2-49c4-b5a5-bf7dc0568279"), 15895958907.0, new DateTime(2024, 12, 1, 16, 52, 5, 534, DateTimeKind.Local).AddTicks(9350), "DaviLucca_Moreira@hotmail.com", true, "Tertuliano Franco", "$2a$11$nuQaD4X6UjnNNHOoBtB4h..aquZPb6sGSZm6ZTe33hZz6B8xEKQWe", 557902678513.0 },
                    { new Guid("668bf2e4-30f7-4143-be67-058d64d68a3b"), 1138213950.0, new DateTime(2024, 12, 1, 16, 52, 5, 66, DateTimeKind.Local).AddTicks(5751), "Hugo.Santos51@yahoo.com", true, "Rafaela Moreira", "$2a$11$J9vR4Njms8GnKA4TAdTuvOe73ZU5nCWXDMFf.Qyr/WzVnqMqb.Mr6", 5217182707.0 },
                    { new Guid("75ea41c8-079c-45fb-9ba8-c9a55931fe88"), 92431241106.0, new DateTime(2024, 12, 1, 16, 52, 5, 885, DateTimeKind.Local).AddTicks(5009), "Rafael96@live.com", true, "Yango Batista", "$2a$11$hrzMLLQqK34iN2dpQv3nU.tnaT6hO8siDuCiBaFumyA9IIjqbDAs.", 20000609461.0 },
                    { new Guid("76734a2e-5643-4105-8176-c579a1333790"), 39629860066.0, new DateTime(2024, 12, 1, 16, 52, 7, 405, DateTimeKind.Local).AddTicks(6833), "Salvador.Saraiva@hotmail.com", true, "Sirineu Batista", "$2a$11$vsg9Eh1PeQ8dr2d0VY1Q.eNVzxtzA3u/cGoZX9tEADpusmH9rcpKC", 8463060854.0 },
                    { new Guid("796d9a4c-99aa-4d56-9d52-71b93067b6cc"), 83009988885.0, new DateTime(2024, 12, 1, 16, 52, 6, 352, DateTimeKind.Local).AddTicks(8654), "Paula_Moreira87@hotmail.com", true, "Núbia Oliveira", "$2a$11$Iec8CjCoOuF.4r//MhTMTOXLqRNNm7V.UsPexpkZWj7Q1kY390g16", 551124345894.0 },
                    { new Guid("7b660412-b087-4577-8fff-02d7c9c580e5"), 49509355771.0, new DateTime(2024, 12, 1, 16, 52, 2, 255, DateTimeKind.Local).AddTicks(6293), "Sarah.Oliveira@yahoo.com", true, "Liz Moraes", "$2a$11$CEUNJ15A2ppmWDjL0g16kOonOd6RTvTWwwjtVeih2tjG6YySGu8bW", 556257547674.0 },
                    { new Guid("81ca2d3c-b0ad-45ff-804b-b4c375b111fd"), 71107487587.0, new DateTime(2024, 12, 1, 16, 52, 3, 425, DateTimeKind.Local).AddTicks(7751), "Breno26@yahoo.com", true, "Gabriel Souza", "$2a$11$N0dJpgIeSPA3iOVQgSxu9ugikH/g9jAZhK8qwZ.b666fcUkMQYnea", 92758670500.0 },
                    { new Guid("823759e3-4d2a-4534-90bb-7d99d8649b0a"), 79317775497.0, new DateTime(2024, 12, 1, 16, 52, 3, 780, DateTimeKind.Local).AddTicks(1602), "Murilo.Barros@yahoo.com", true, "Clara Carvalho", "$2a$11$uLib99Md0yB90xc09pQg7OXywr7Kfdyo2TtYsYaro2jGdCLVYG7W2", 554971823756.0 },
                    { new Guid("898bd9f9-b4b1-4cf1-81f8-dc49d19ff72a"), 88790926773.0, new DateTime(2024, 12, 1, 16, 52, 5, 651, DateTimeKind.Local).AddTicks(6981), "Vitoria_Xavier75@bol.com.br", true, "Paulo Batista", "$2a$11$aTNIK6AqbGQFZmWNiLL5rePc1R8QVtif6g.bcCrIKNlzN82V.2r2m", 556366974950.0 },
                    { new Guid("8dc4ccba-7862-4994-bf53-27908b4e60a1"), 2138392457.0, new DateTime(2024, 12, 1, 16, 52, 6, 937, DateTimeKind.Local).AddTicks(8633), "Clara79@hotmail.com", true, "Gúbio Franco", "$2a$11$Wq2El49RnUHPAZtl7FCHJeXxrrelcvBYgCzuscDndstM2snMkTrma", 551497335675.0 },
                    { new Guid("9d39252a-283c-4d28-9f93-5090120fcdb9"), 52833082436.0, new DateTime(2024, 12, 1, 16, 52, 4, 949, DateTimeKind.Local).AddTicks(7985), "DaviLucca_Santos@hotmail.com", true, "Gael Albuquerque", "$2a$11$IdT5YfS3Bdu9ascSsgXcBeuZ3zXE.Cbfid/cY0jVDhX1c2SvaDJP6", 555187595661.0 },
                    { new Guid("b1d30a3b-fd99-49cd-a5ab-c9856f25090f"), 30246551909.0, new DateTime(2024, 12, 1, 16, 52, 6, 2, DateTimeKind.Local).AddTicks(2374), "Rebeca_Franco@yahoo.com", true, "Enzo Gabriel Silva", "$2a$11$HXfN/PN/8sJ40fhlFWw0cOFK/W.0lmlGLic9Iiac0kFmq.PB6rsbS", 1199401152.0 },
                    { new Guid("b83bb4e9-6ecf-4fd3-bb42-1b1cd6109cdd"), 83618792859.0, new DateTime(2024, 12, 1, 16, 52, 7, 522, DateTimeKind.Local).AddTicks(3631), "Esther.Braga@hotmail.com", true, "Caio Moreira", "$2a$11$GfuWGKMReQvHzW3ZTyR0/.avJspxSECfsaWhpMoQSLgd3693BP.Si", 50125029406.0 },
                    { new Guid("bca18a80-d64f-4dfa-bcd0-c037b49bc53a"), 75239476977.0, new DateTime(2024, 12, 1, 16, 52, 4, 132, DateTimeKind.Local).AddTicks(304), "Miguel_Carvalho90@bol.com.br", true, "Luiza Santos", "$2a$11$YrBNeOHkBFOYfhI3l5TIguc/VwsEtCN9IubFKiLgKX36SMHu9ND3i", 550555458490.0 },
                    { new Guid("be54b398-e326-4937-a88f-e873913cc7bd"), 51044378921.0, new DateTime(2024, 12, 1, 16, 52, 4, 716, DateTimeKind.Local).AddTicks(489), "Rafael_Nogueira@hotmail.com", true, "Ladislau Carvalho", "$2a$11$KX5chFkxUv2b0TCtFGmbTOyBW4REd4L6rxAO6c1mGnmgpdMwTsvgW", 555903939128.0 },
                    { new Guid("c1f29127-91f0-466a-b7e7-d541f4575c53"), 41663748420.0, new DateTime(2024, 12, 1, 16, 52, 6, 703, DateTimeKind.Local).AddTicks(7329), "EnzoGabriel83@yahoo.com", true, "Aline Moreira", "$2a$11$TJl3gmqddFo0ODq2CWBuKuWhseP3Dg7HWZqpSWRYze0GqVHBPuT56", 80844466271.0 },
                    { new Guid("c315b7c9-0098-4cbb-8b2a-23874e4cfa2f"), 45654913204.0, new DateTime(2024, 12, 1, 16, 52, 7, 171, DateTimeKind.Local).AddTicks(9655), "Murilo_Souza@hotmail.com", true, "Júlio Barros", "$2a$11$Ohcwxsd6d3.gozjcFgxaY.FNzaUzeeVAJiRjYKPytZdoZnUKzqFoK", 52072737931.0 },
                    { new Guid("ce7ef1da-fe0f-43b4-9fb5-1ae593b26fb1"), 19673000115.0, new DateTime(2024, 12, 1, 16, 52, 2, 138, DateTimeKind.Local).AddTicks(6103), "Rebeca41@bol.com.br", true, "Vitor Franco", "$2a$11$n7.w0GiZmZc4NC0tICjF0ucvOxHG4WXoW2L2Ld.pcS0jAHLzXQj8u", 2456787204.0 },
                    { new Guid("d549db43-8731-462b-870f-2151d12f4f0f"), 77300140769.0, new DateTime(2024, 12, 1, 16, 52, 3, 662, DateTimeKind.Local).AddTicks(5690), "Marli_Albuquerque@gmail.com", true, "Maitê Carvalho", "$2a$11$AHL1DhHT/ZSDV4YdGJS3ouuUVgPukDLx0lg1hlduw1RgD/hjpZIYi", 551163719969.0 },
                    { new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8"), 123456789.0, new DateTime(2024, 12, 1, 16, 52, 7, 755, DateTimeKind.Local).AddTicks(7614), "admin@admin", true, "Admin", "$2a$11$r8W53S5qXgLOtv30S1KZ4OoFhtI4JD1niLk7ktwg4fn08tVMoihw.", 123456789.0 },
                    { new Guid("d94ca5bb-da78-4ee1-940c-3b67281b1e82"), 47077490467.0, new DateTime(2024, 12, 1, 16, 52, 5, 300, DateTimeKind.Local).AddTicks(2666), "Theo.Martins32@gmail.com", true, "Ana Clara Franco", "$2a$11$gUE30ItjbCkK3E7e3XeBEuG80yodjmhEijg.zGBXWukIFJGBGAWbq", 99457867304.0 },
                    { new Guid("da1cb3e2-82b6-41b9-9bee-c0868aa32995"), 1272264190.0, new DateTime(2024, 12, 1, 16, 52, 4, 833, DateTimeKind.Local).AddTicks(499), "Paulo.Barros38@gmail.com", true, "Víctor Braga", "$2a$11$F/i2cNRFGhFKFzf6mcCyDezPQOiVh5vIH9gAdsvVodGT0DSWfkBo.", 550022236255.0 },
                    { new Guid("da5a1c6f-bcac-45c5-90cf-5030fd95da56"), 85380249140.0, new DateTime(2024, 12, 1, 16, 52, 6, 119, DateTimeKind.Local).AddTicks(1828), "Elisa_Martins44@bol.com.br", true, "Larissa Moraes", "$2a$11$ng9veNVCA6S1NVwtQmlQOe2YAQOtLvLdL1FRU4j7WLc6HK/Rep73m", 9915387420.0 },
                    { new Guid("e54629cb-8bf0-4fa2-9876-855395b46d46"), 45541280168.0, new DateTime(2024, 12, 1, 16, 52, 5, 183, DateTimeKind.Local).AddTicks(5618), "Laura.Oliveira@gmail.com", true, "Lorena Moreira", "$2a$11$A0Lttcqp6ePl4dYHdJ4WO./7BL32vmgpDbF0WfeJFEgRI6oJSKy/a", 70713284242.0 },
                    { new Guid("e7299ffe-efa7-411c-8784-c827d6a1743d"), 39153306201.0, new DateTime(2024, 12, 1, 16, 52, 4, 248, DateTimeKind.Local).AddTicks(7295), "Fabio.Saraiva80@bol.com.br", true, "Isaac Macedo", "$2a$11$6fuChYdp/hpAc6tXFzFoQee16opHfWfIfeDW/CdockCa6kp7ZHzhi", 57070111329.0 },
                    { new Guid("e7dab215-0513-4320-983f-07127aa24fe0"), 58350375469.0, new DateTime(2024, 12, 1, 16, 52, 3, 190, DateTimeKind.Local).AddTicks(4497), "Ricardo.Carvalho@bol.com.br", true, "Júlia Santos", "$2a$11$09yS3NI6eMKlfmK5Bw11quyZJKw.uHlop8sK35ym6QtimWqOYOU8a", 552207395719.0 },
                    { new Guid("ea34a581-79ca-42b1-8aae-e2af24720103"), 23035252335.0, new DateTime(2024, 12, 1, 16, 52, 3, 897, DateTimeKind.Local).AddTicks(3436), "Gael_Braga38@hotmail.com", true, "Vitor Reis", "$2a$11$uwpeGIZ80f1w5zFarIYj4eQxB0mmnx4i8Ec3US8WQS2erVRB5VQDS", 553726845583.0 },
                    { new Guid("eedbe98a-5538-40c8-94ea-422f0897369d"), 32541039204.0, new DateTime(2024, 12, 1, 16, 52, 4, 482, DateTimeKind.Local).AddTicks(4031), "Marcela_Braga3@yahoo.com", true, "Isabelly Moreira", "$2a$11$zC5fBKiDHc22DPSrCPW.busVF5DAxrPaiQFOb83Y0o/iiv9V9x74G", 88125012042.0 },
                    { new Guid("f16dbcb4-2dd2-4bcb-afcf-47d5b12934b8"), 67820800798.0, new DateTime(2024, 12, 1, 16, 52, 6, 820, DateTimeKind.Local).AddTicks(8987), "Isabel_Carvalho@hotmail.com", true, "Davi Lucca Barros", "$2a$11$k.JWctnKAY9sKNB8qnJsrOsFTpuJHFiGp9jKnTrvFv3GyDlIU/tse", 554849769173.0 }
                });

            migrationBuilder.InsertData(
                table: "admins",
                columns: new[] { "id", "user_id" },
                values: new object[] { new Guid("344de1e4-c5cc-4c60-aad5-508006dfb6ed"), new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8") });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "name", "user_id" },
                values: new object[,]
                {
                    { new Guid("221ecd6f-ba3c-46d2-badb-38910d01848c"), "F#", new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8") },
                    { new Guid("4a9aa0bb-2376-40e0-b8ad-1ce84ffa825f"), "Js", new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8") },
                    { new Guid("5ddb66a7-a154-408e-ba54-954038bb5b2d"), "Java", new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8") },
                    { new Guid("5de4ae9f-00ea-4a48-bf16-5289dc13a250"), "PHP", new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8") },
                    { new Guid("a6386299-25f8-42cf-943e-cf080adf69e7"), "Rust", new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8") },
                    { new Guid("b9fb36df-0af9-4647-8a3e-bbdced746503"), "c#", new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8") },
                    { new Guid("cefa72f0-3154-4cb1-97b6-d770be9985ef"), "MySql", new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8") },
                    { new Guid("da6ba5f1-c6a9-4a7c-8295-5aa0a4b57eab"), "c", new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8") },
                    { new Guid("df8c4b01-58a5-4509-8c45-8dcb9dbb9559"), "Typescript", new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8") },
                    { new Guid("e5d64e09-22a2-4b7f-aecc-7b5a8f63bb7c"), "SQL", new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8") }
                });

            migrationBuilder.InsertData(
                table: "clients",
                columns: new[] { "id", "subscriptionplanid", "user_id" },
                values: new object[,]
                {
                    { new Guid("08399f5b-7bbd-4ab7-8d31-c8aabbb71453"), null, new Guid("da1cb3e2-82b6-41b9-9bee-c0868aa32995") },
                    { new Guid("09ed4c40-0b92-4d12-b57f-d54c09cebc85"), null, new Guid("0eaea012-832a-426c-b207-1d9d3a5cfe65") },
                    { new Guid("0f23eaa3-d923-4de6-b10b-89c824d9bc5a"), null, new Guid("d549db43-8731-462b-870f-2151d12f4f0f") },
                    { new Guid("1328e5bb-1643-4256-9a26-e6f5b6ce4650"), null, new Guid("76734a2e-5643-4105-8176-c579a1333790") },
                    { new Guid("13e04d0d-93f2-4b54-ae39-c2fbdf81a36f"), null, new Guid("eedbe98a-5538-40c8-94ea-422f0897369d") },
                    { new Guid("173fda28-4305-48bc-8b0d-38aa7bfaa017"), null, new Guid("5ff114ba-cfe0-42ba-99ed-531e98147d47") },
                    { new Guid("1826a0f9-475d-4e87-acba-4b3975358d6f"), null, new Guid("c315b7c9-0098-4cbb-8b2a-23874e4cfa2f") },
                    { new Guid("18e76320-761f-4972-95a3-5417184e6059"), null, new Guid("467d2937-e9e5-4dd8-8727-4e9eeb97560a") },
                    { new Guid("1b96e94c-7b27-4859-ab17-dbb5e13ccc8f"), null, new Guid("e7299ffe-efa7-411c-8784-c827d6a1743d") },
                    { new Guid("1e756cef-4ec3-441a-ad18-cf3c2000d1da"), null, new Guid("1eac9ce2-33bc-485a-bddc-4834b529dbc0") },
                    { new Guid("23125089-73f5-4670-80c7-36d1353f060d"), null, new Guid("34b8d886-3510-49e3-8f9d-5f30433d0329") },
                    { new Guid("24aabc0f-862e-4dea-a23e-c30572a39ce5"), null, new Guid("1648b9be-0713-461f-923e-326ed771ed4e") },
                    { new Guid("31d1f9a8-fd25-4fc0-80b7-30fe40c53d71"), null, new Guid("25593bc9-6849-4e48-b0d5-861ed2b1bfa7") },
                    { new Guid("42299a4f-0bc8-4ca6-bfaa-961681dee41a"), null, new Guid("651458aa-aea2-49c4-b5a5-bf7dc0568279") },
                    { new Guid("464e2d0f-6027-487d-a018-0e9bba118b19"), null, new Guid("083066ae-76c2-4e9a-85ec-89517c4df628") },
                    { new Guid("4e38b9fc-4e2c-4023-85a0-243019afb381"), null, new Guid("0cf6542b-8d88-40be-bd6c-193237a8277d") },
                    { new Guid("5b70997e-a16b-4369-a939-c87be194cef7"), null, new Guid("da5a1c6f-bcac-45c5-90cf-5030fd95da56") },
                    { new Guid("5c6f5b50-69a5-4a91-b1de-23371e0f99c6"), null, new Guid("616c8716-43d9-46ba-bb46-2be4d6e8132c") },
                    { new Guid("67ca3237-6091-4c14-8e81-b85ca5a21075"), null, new Guid("81ca2d3c-b0ad-45ff-804b-b4c375b111fd") },
                    { new Guid("6e6cb200-8cf7-4fc0-b1cf-1fb390b86465"), null, new Guid("e7dab215-0513-4320-983f-07127aa24fe0") },
                    { new Guid("77e6bcfd-35aa-470e-9921-f26ac277c2bd"), null, new Guid("4b8db70c-30bd-4219-97b5-7682f58a19ee") },
                    { new Guid("781d9ab6-802f-4e64-b417-dfcacb7e84f3"), null, new Guid("5dce78ed-bdd4-4e1a-927d-8ea0037bca0a") },
                    { new Guid("7e6cfa6e-f8fe-4365-bb47-2cac1f4c3942"), null, new Guid("b1d30a3b-fd99-49cd-a5ab-c9856f25090f") },
                    { new Guid("7ef29d00-3f67-4e12-b444-6840785059a0"), null, new Guid("9d39252a-283c-4d28-9f93-5090120fcdb9") },
                    { new Guid("86c035e0-f7ff-4bbe-8521-1f01fe0091df"), null, new Guid("c1f29127-91f0-466a-b7e7-d541f4575c53") },
                    { new Guid("87bf6400-aca1-4650-a921-4eb18fa8086a"), null, new Guid("138b44cd-e074-4c3e-9ac6-ce59379f7138") },
                    { new Guid("894ffe26-a3ff-49d6-81ba-c13e466172b4"), null, new Guid("ce7ef1da-fe0f-43b4-9fb5-1ae593b26fb1") },
                    { new Guid("8b039ba1-727d-4772-8fe0-9ff1d75acdaa"), null, new Guid("374656ce-5d39-4f10-b2a0-b18733b59d5b") },
                    { new Guid("8c91a9c7-7570-4e18-a8b0-ecd5d214493e"), null, new Guid("668bf2e4-30f7-4143-be67-058d64d68a3b") },
                    { new Guid("8cfdf48a-a0ed-4027-a980-12244ae5f160"), null, new Guid("b83bb4e9-6ecf-4fd3-bb42-1b1cd6109cdd") },
                    { new Guid("8e2e38bb-bb29-4f4b-94ee-74bb83e2f116"), null, new Guid("3d467700-b50b-4965-81d4-f772d68f5f01") },
                    { new Guid("8f266345-19ee-4d2b-a462-41cf604fc025"), null, new Guid("8dc4ccba-7862-4994-bf53-27908b4e60a1") },
                    { new Guid("9041b028-eb68-4127-9b2a-079c8f05ad6f"), null, new Guid("d94ca5bb-da78-4ee1-940c-3b67281b1e82") },
                    { new Guid("9690bd7b-5ba6-41c3-8bf5-a610756232cb"), null, new Guid("7b660412-b087-4577-8fff-02d7c9c580e5") },
                    { new Guid("9b973fdc-3a94-4ca6-b502-e84bc58df4e1"), null, new Guid("be54b398-e326-4937-a88f-e873913cc7bd") },
                    { new Guid("9e2a4f1b-5ccc-42c4-a72d-9ed7febec88b"), null, new Guid("823759e3-4d2a-4534-90bb-7d99d8649b0a") },
                    { new Guid("a412e104-92c8-4678-b51e-8042585898f9"), null, new Guid("4c65bf0f-41c3-4cb2-ac66-5437927fb874") },
                    { new Guid("afeb3424-cdc3-423e-985e-ed42fafce4c0"), null, new Guid("f16dbcb4-2dd2-4bcb-afcf-47d5b12934b8") },
                    { new Guid("b55379b3-fa5b-45b0-8df5-55fd9fac13df"), null, new Guid("75ea41c8-079c-45fb-9ba8-c9a55931fe88") },
                    { new Guid("c3c84884-8e39-4d6d-a506-d647368ff192"), null, new Guid("bca18a80-d64f-4dfa-bcd0-c037b49bc53a") },
                    { new Guid("c82987ea-6b09-4567-a06e-a0893e2f1801"), null, new Guid("898bd9f9-b4b1-4cf1-81f8-dc49d19ff72a") },
                    { new Guid("c866dd90-cda9-44c9-8a03-672ee0ccd517"), null, new Guid("ea34a581-79ca-42b1-8aae-e2af24720103") },
                    { new Guid("d38d8561-6423-40f9-9e9a-6f48e5ae3357"), null, new Guid("4e0a9611-bb9a-4944-a408-80cb836c05db") },
                    { new Guid("da218660-009f-4249-a8cd-0c4d39f6ed7f"), null, new Guid("e54629cb-8bf0-4fa2-9876-855395b46d46") },
                    { new Guid("dd6e9a79-d132-4092-9c0d-55beeb3a4455"), null, new Guid("1b490536-daf8-415d-8af2-73e7e4c94738") },
                    { new Guid("e3074c9d-ab43-4f93-b16a-44e2deba4b55"), null, new Guid("58afc5d0-9d94-48c0-81b1-4399d7c448e6") },
                    { new Guid("e5eae2f4-88d2-4ed8-8575-7a2bcdf1ef18"), null, new Guid("796d9a4c-99aa-4d56-9d52-71b93067b6cc") },
                    { new Guid("e9753ca5-3c16-44f1-8080-05a44640e2c4"), null, new Guid("626edd52-ad1e-478a-a031-072c9de14e73") },
                    { new Guid("ee2504c6-693d-401c-b474-f4d1880ebbbd"), null, new Guid("3f980e2b-abef-401e-97ac-d2fc95b43271") },
                    { new Guid("fd88f959-3c61-4348-b4c1-680d7bc0e8b5"), null, new Guid("064397b2-22d9-4d4c-88c7-8967381f6376") }
                });

            migrationBuilder.InsertData(
                table: "instructors",
                columns: new[] { "id", "github", "social_network", "user_id" },
                values: new object[] { new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), null, null, new Guid("192fcf7c-c7f8-42fd-a711-c075799483a8") });

            migrationBuilder.InsertData(
                table: "blog_posts",
                columns: new[] { "id", "acesses", "created_at", "instructor_id", "text", "thumb", "title" },
                values: new object[,]
                {
                    { new Guid("00dd6672-bb1d-38ae-9c0b-e9a8321f9919"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(7462), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Quia culpa perspiciatis sed optio natus. Quia qui delectus nam ipsum alias ducimus porro voluptatibus eum. Enim voluptatem pariatur. Recusandae beatae et error exercitationem quae nihil repellendus.\n\nModi sint officia. Molestias sapiente enim nesciunt ut facilis. Sequi ab aliquid et voluptatem aut saepe omnis placeat non. Dolore in id doloribus nulla quas. Et amet vero est distinctio qui aperiam culpa sunt aliquid. Numquam occaecati ut optio ut id blanditiis quaerat distinctio.\n\nBlanditiis et commodi. Dolor omnis voluptas veniam neque. Earum quis neque ea ut beatae omnis quasi. Quidem sequi corporis. Quaerat autem hic.", null, "Usability" },
                    { new Guid("04d43348-cdda-0261-8226-fb0a6d522d69"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(6056), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Doloremque asperiores dolorem libero illo facere cumque. Quo dolorem magnam quasi eaque fugit nisi. Esse omnis porro sed consequuntur voluptas mollitia quia. Provident quia et eaque sapiente quia et quas.\n\nAlias ut accusantium qui facilis. Sed pariatur saepe consequatur ea. Et autem omnis officia veritatis. Laborum dolor accusamus laudantium fugiat. Sunt dicta culpa non quibusdam.\n\nError esse earum officiis quae odit. Consequuntur dolorum est quibusdam. Qui voluptatem est dolor qui. Ullam in odit debitis maxime pariatur dolore assumenda. Sed alias doloremque dolore molestiae cumque.", null, "Usability" },
                    { new Guid("09b25f5b-e7b5-0d72-dba2-76cfceb3e724"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(2115), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Aut dicta quis et animi voluptas. Beatae impedit sed alias quia laudantium. Delectus dolorem quod ullam nihil necessitatibus dolores et.\n\nQuia pariatur aspernatur quas quo tempore accusamus eveniet. Consequatur repellendus dolorem. Similique laboriosam illum et.\n\nBeatae vero aut sed facere earum architecto illo. Ut quibusdam eligendi mollitia corrupti. Reprehenderit at modi illo et magnam tempora quod maxime.", null, "Paradigm" },
                    { new Guid("37a189b9-85e6-c510-5c6f-24eff907c3ef"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(9335), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Non magnam soluta tenetur vel. Dolor beatae voluptates eaque totam qui. Illo harum dignissimos. Voluptatum odio eveniet id.\n\nIllum quis aut consequatur. Impedit nisi vel sed inventore quibusdam accusantium ab similique laudantium. Veritatis est rerum in reprehenderit dolorem perferendis aut. Nihil eius ut. Vel dolores enim consequatur est consectetur dicta. Odio at molestiae et.\n\nEst ut molestias explicabo error ut. Nostrum et harum maxime aliquam accusantium sed est non alias. Repellat culpa sit qui.", null, "Integration" },
                    { new Guid("3c75d55d-7c85-700e-6903-9d01be339e1f"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(9918), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Facere odit ab architecto sit aut officiis et. Voluptatem nihil voluptatem quo explicabo. Soluta atque quae temporibus ratione tempore voluptates numquam.\n\nFuga nam quibusdam rerum qui dolores blanditiis. Non sed voluptatibus sit consectetur iusto repellat facere quo. Totam aspernatur dolor voluptatem et dolores aut aut nesciunt. Doloremque omnis eos et unde. Doloremque iure neque.\n\nOfficiis eum maxime laboriosam laboriosam vero eos consequatur minus eos. Occaecati tempora soluta rerum minus sunt quisquam quae ea. Aut sint voluptatem qui deleniti autem. Perspiciatis tempora autem pariatur ipsum ipsum ut nostrum. Et fugiat eos voluptatem fugit. Harum dolores occaecati facere in.", null, "Tactics" },
                    { new Guid("42908f44-af0f-5778-c57d-dd9b0b0f65aa"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(1241), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Fuga ipsa aut ea repudiandae fugit nemo nisi. Ipsam consectetur in. Ut odit consectetur ut eum facere.\n\nTempora doloribus in occaecati ut sint. Consequatur quaerat vero. Quidem odio magni sed rerum at earum molestias minus officiis. Iusto commodi atque dolore. Qui nostrum quis nobis excepturi accusamus qui quibusdam.\n\nAperiam voluptatem illum ipsam iusto suscipit voluptatibus voluptas ducimus. Est nisi asperiores amet repudiandae aut. Voluptatum ab harum voluptatem quia ut vitae explicabo. Et adipisci velit ut debitis sed impedit rerum recusandae. Delectus et laboriosam laudantium est quam accusamus velit quibusdam aut.", null, "Division" },
                    { new Guid("480a9c8d-bb3c-5e76-78b7-d566f9aa3905"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(1030), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Et voluptas reiciendis. Aliquid sunt quia. Totam suscipit consequatur odit voluptatem odit eveniet blanditiis ratione. Iste itaque voluptas consequatur quibusdam sed recusandae est aliquam. Hic consequatur tempore similique earum tempora qui sit mollitia.\n\nRem est voluptas aliquam et qui reprehenderit. Aut atque ipsam consequatur hic laborum magni vel ut. Minus ut corporis magnam aperiam quia blanditiis officia facilis necessitatibus. Similique voluptates officia totam deserunt et consequatur quia enim laboriosam.\n\nSaepe vel quae ratione aperiam maiores maxime hic rem vero. Laboriosam et est nam ipsam velit. Qui velit sunt quis maxime.", null, "Functionality" },
                    { new Guid("516237b6-316d-0cb4-3c0f-ccb5cd426913"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(2448), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Atque dolorem pariatur dolore cumque quasi non deserunt ipsum id. Doloribus autem vitae unde rerum. Odit aliquid ut quasi adipisci aut ut molestias nam. Rerum qui ut officiis nihil tenetur dolorem tempore necessitatibus. Consequatur voluptas itaque repudiandae velit.\n\nTempore aut quia provident expedita rerum non et dolore excepturi. Deleniti laudantium sapiente aut maiores natus molestias consequatur. Officiis quam et iste corrupti eaque consequatur facilis. Aspernatur vel ipsum reiciendis beatae incidunt mollitia. Ducimus deserunt sequi eum molestias voluptas qui molestiae neque. Veritatis ratione qui quas tempore.\n\nOptio maxime enim sed nihil eos nobis dolorem. Qui non possimus rem eaque consequuntur deleniti id illo. Et repellat quae dolorum minima autem sed fugiat.", null, "Directives" },
                    { new Guid("56b8f0c9-238d-d8c4-2400-d1d4c563bf54"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(2263), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Sequi iusto nemo autem fugiat quo qui dolorem totam. Voluptas nobis sed veritatis maxime corrupti inventore necessitatibus. Nostrum dicta quae hic non ut voluptas corporis labore magni.\n\nMaxime qui voluptas nemo hic aut sapiente natus beatae facere. Repellat harum doloribus quo unde officia a facilis maiores. Molestias odio sapiente vel vel non.\n\nAut excepturi totam velit deleniti. Voluptas vel repudiandae sed tempore eveniet. Architecto accusamus sint quis nesciunt. Natus necessitatibus nihil delectus minus cum laudantium.", null, "Infrastructure" },
                    { new Guid("5f141f0b-8170-8dae-9feb-dc5783e7c736"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(153), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Est qui eos dolor voluptatum consequatur quia aspernatur. Eum atque dolores atque. Quidem amet velit enim. Quas id non sunt minima.\n\nIpsa laborum ut accusantium et id. Et repellendus laboriosam neque quos qui dignissimos beatae eveniet. Similique a quia rerum voluptates vel dolores harum sed. Quia nobis sequi voluptatem et rem sit porro rerum aut. Ut qui accusantium vel voluptatem ut magnam similique. A voluptatem et autem.\n\nMagni quibusdam maxime recusandae inventore illo. Molestias quibusdam sit aut nisi exercitationem quisquam quis. Odit est perspiciatis quaerat a debitis molestiae.", null, "Configuration" },
                    { new Guid("737e36a0-de19-5c8f-0048-6205ce108da1"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(2862), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Vel labore consequuntur autem dolorum sunt non nihil omnis. Officia laborum deleniti quo enim animi voluptatem. Dolorem et nihil.\n\nFacere et sint enim voluptatem blanditiis voluptatum voluptate. Veniam dignissimos quis. Quis aut suscipit voluptas magnam quod. Ratione enim voluptatem qui libero consequuntur illo vitae et et. Odit est pariatur et qui.\n\nAb vitae itaque provident pariatur itaque sed dicta non. In rem repudiandae quis omnis delectus. Exercitationem ab voluptate ut nemo labore beatae. Reprehenderit sit est et deleniti sed natus. Maxime magni animi repudiandae et ipsam non.", null, "Factors" },
                    { new Guid("7ad11b41-410b-1e7d-c28f-7f719b68b184"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(9111), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Et laborum non impedit nulla et velit qui perferendis. Ad ut earum. Officiis inventore explicabo reiciendis corrupti. Omnis minus et aut.\n\nQuae nobis illum consequatur velit aut iusto ipsum. Corporis iure aut omnis animi tenetur. Qui vero et architecto rem qui vero libero. Deleniti deserunt eaque. Iste non quia voluptas earum omnis pariatur vel quia qui. Fuga expedita ipsa sequi architecto itaque esse aliquid.\n\nCorporis reprehenderit nisi consequatur at nulla rerum molestiae assumenda vel. Qui aut est est est blanditiis. Neque quis alias quod vitae atque.", null, "Security" },
                    { new Guid("8406a1ae-318c-01d0-0f2e-dd3cfce9e766"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(3074), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Consequatur explicabo occaecati quidem consequatur nesciunt aut aliquid. At suscipit a incidunt cumque quo adipisci qui unde velit. Excepturi quis inventore quos libero animi ducimus voluptate aut incidunt. Magnam facere molestiae. Quo dolore maxime ullam deserunt.\n\nVoluptatem qui nesciunt dicta. Quas reprehenderit id. Quaerat id voluptatibus minus. Nihil quae doloribus et in laboriosam. Amet eaque ut quis quaerat necessitatibus dicta odio.\n\nRerum doloribus repudiandae error. Temporibus sed fugiat cumque commodi et sit sit. Est nihil non vel eos quam. Et dolorum tempore. Numquam et perferendis ut aliquam culpa maiores ipsum. Corrupti sequi eius dolorem sed aut illum.", null, "Factors" },
                    { new Guid("8ba8c410-c95c-3a68-8ce4-4d40f57510b0"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(1907), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Reprehenderit inventore voluptas autem eos. Esse quod quos sint deserunt et neque voluptas necessitatibus eos. Nesciunt quam cum autem ut neque adipisci explicabo quia vero. Non libero mollitia. Et suscipit dolorum eius vitae velit numquam. Aut saepe ullam.\n\nVoluptatibus voluptates officiis. Dolorem neque dignissimos sapiente error ut doloribus. Vel asperiores delectus natus cum iusto est sed.\n\nCorporis numquam aut tenetur dignissimos rem quia iure optio aliquid. Itaque quia veniam deserunt sed dolor exercitationem quas. Voluptatum veniam molestiae consequatur consequatur animi dolorem tenetur quam.", null, "Implementation" },
                    { new Guid("8e3e6c1a-c785-2ff7-2be6-438cbc712b35"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(8868), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Sit ut sit dignissimos vel. Accusamus et alias unde et. Officiis autem delectus ducimus ducimus quod dicta. Ut vitae esse id nisi doloremque dignissimos sequi molestiae. Dolor quidem in eligendi sit. Et quia velit quas.\n\nLibero qui consequatur ut sint inventore illum pariatur. Sit sit veniam neque odit. Necessitatibus magnam quam fugiat libero ad ad quidem molestiae incidunt. Et maiores provident corporis cumque.\n\nUt commodi officiis est harum. Earum nihil voluptate tenetur. Autem deleniti nemo ex. Eum rerum sequi rem eum. Sit omnis et asperiores sed. Aut qui aut praesentium doloribus quo et.", null, "Directives" },
                    { new Guid("90362389-1e41-e4e1-2340-4bf7652c6517"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(9526), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Corporis accusamus inventore voluptatum repellendus quis. Optio ipsam rerum voluptates deserunt quisquam. Cupiditate et cumque sunt.\n\nQuo doloribus et ea accusamus enim. Perspiciatis labore aliquam et itaque quam repellendus ratione. Eveniet magni omnis error cumque soluta labore et. Eum sed laboriosam beatae eum provident voluptatem corrupti voluptates. Iusto occaecati omnis sit tempore culpa sint perferendis. Laboriosam fugit asperiores nostrum dolorem autem.\n\nSunt cumque quia qui omnis quos voluptas. Occaecati officia minus quis cumque eos in aut quae esse. Dolorum labore quas ipsum odit. Voluptate illo aut voluptatibus dolorum omnis sit aliquam quo fuga.", null, "Accounts" },
                    { new Guid("97a66f36-1a50-96c2-7dea-2d620ad232f5"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(2702), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Est doloremque qui quia. Ut eum et. Totam numquam temporibus ratione cum commodi neque animi non doloremque.\n\nQuis consequuntur ut et dolor sapiente non cumque a. Eaque quia voluptatem deserunt alias. Tenetur ea itaque qui quae quibusdam nesciunt. Ut molestias ipsum est sit sit qui similique non.\n\nOmnis aliquam deserunt dolorem. Delectus omnis qui numquam neque. Omnis ab architecto quibusdam aut est.", null, "Configuration" },
                    { new Guid("9883eb4a-4618-59f3-89ad-010f802223e2"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(6827), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Ratione eligendi sequi corporis. Suscipit quod expedita possimus et. Sit repellendus omnis molestiae itaque accusamus quos eum ipsum. Autem voluptas dignissimos libero similique placeat qui voluptas. Pariatur et quis quaerat vel quis consequuntur qui. Perferendis asperiores magni aut amet quo.\n\nInventore sit labore cumque debitis consequuntur nisi quis iure rerum. Expedita deleniti voluptas fuga natus ea tenetur ut. Quod eaque temporibus est nam autem et quidem. Doloremque totam qui odio distinctio pariatur reiciendis. Maiores voluptatem et libero.\n\nTemporibus laudantium non eum occaecati. Velit debitis id. Qui officia nobis fugit. Reprehenderit quis sit est recusandae ducimus in. Aut quibusdam porro qui error. Minus culpa praesentium.", null, "Data" },
                    { new Guid("a15df535-40ff-c6d0-9997-df5b3ba3102a"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(568), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Voluptatibus pariatur laborum et cumque molestiae. Atque veritatis consectetur. Voluptas dolores officia sunt aliquam earum earum consequuntur. Dolorem est odio eos cupiditate sint pariatur laudantium. Qui quia deleniti enim ad voluptas.\n\nNihil rerum omnis. Quod est ad laudantium impedit quam rem debitis. Libero quia odit. Aut voluptatem alias sit ipsa possimus aut deleniti. Perspiciatis quam ratione non similique eos vel et neque est.\n\nVoluptatem commodi animi ipsa ducimus quia porro doloribus. Deserunt accusantium eum nihil et non laborum molestias accusamus. Et debitis harum nam voluptas. Minus quos dolores incidunt voluptate sequi et alias. Sed accusamus nisi impedit eius voluptatum sed sit aut. Maiores incidunt doloribus et.", null, "Accounts" },
                    { new Guid("a52f41a7-8eae-199e-2c41-8b6da7c1f257"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(1722), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Voluptatem corporis quisquam rerum ab minus ab id temporibus. Ut facere qui quis enim ipsum et voluptas itaque. Magni earum dolor porro.\n\nSunt consectetur dignissimos nobis fugiat quisquam facilis. Adipisci minus ut eaque. Voluptatum facilis voluptatem molestias. Porro eius doloribus accusantium explicabo voluptatem consequuntur optio temporibus animi.\n\nQuia corrupti illum soluta voluptate recusandae voluptas earum dolorem. Dignissimos possimus porro. Harum odit et voluptas mollitia dolore id occaecati. Officiis vitae magnam quas.", null, "Research" },
                    { new Guid("a599c57b-8d4a-7a14-ed4a-a62cd916a9fe"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(8373), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Eaque qui laborum enim molestias. Et aliquam eum nihil. Et et sed. Sunt nobis laudantium. Quaerat quo cumque aut quam qui ratione. Amet eligendi tempora nostrum sapiente libero molestiae.\n\nCum debitis ut quis earum facere accusamus commodi. Laudantium quis mollitia non culpa nobis vel a itaque. Voluptas necessitatibus veniam doloremque. Aperiam tempora dolores suscipit aperiam ipsum ut excepturi consectetur quasi. Velit repellendus eligendi molestiae facere illum cupiditate.\n\nA esse animi totam eligendi. Expedita numquam incidunt est. Quos sed facere modi quo. Autem velit reprehenderit distinctio laboriosam sunt necessitatibus ut. Veniam itaque repellendus ut omnis quos voluptatem autem maiores qui. Sed voluptatibus saepe quasi.", null, "Applications" },
                    { new Guid("acc4db4f-5630-b24c-9a0c-d3a62ff16395"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(373), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Illo sunt autem nesciunt facilis. Vel ex et reprehenderit id rerum placeat. Consequatur ipsum voluptatem eos iure temporibus animi.\n\nEaque quidem reprehenderit deleniti. Amet fugiat delectus voluptate facilis hic. Illum laborum nostrum ea.\n\nEnim saepe laudantium enim ducimus corporis quisquam. Et at in est consequatur ipsa accusantium vel. Alias tempora autem rerum nemo fuga modi dolor aspernatur et. Nesciunt vel illo porro dolore est tenetur totam. Similique veritatis distinctio. Vitae consequatur eius molestias omnis aut voluptatem facere.", null, "Creative" },
                    { new Guid("acdeeb33-5a07-7718-cef9-230b21e04cfb"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(7699), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Voluptas hic nam officiis assumenda ea distinctio suscipit libero ut. Consequatur repellat repudiandae similique consequatur veritatis sint sed tenetur sapiente. Omnis necessitatibus voluptate. Voluptatum fuga eos optio eligendi similique qui voluptatum tempora ea. Distinctio consequuntur quod ipsa asperiores rerum accusamus. Quas qui minima enim incidunt vero dolorem.\n\nNisi aliquid ab. Voluptas atque distinctio est omnis dolore. Dignissimos voluptatibus esse voluptates voluptatem in officiis enim et illo. Numquam minus iste et. Mollitia adipisci exercitationem excepturi et illum molestias et.\n\nUt nesciunt et. Ut est dolorem et. Accusamus ut doloribus est dolor praesentium repellendus et.", null, "Security" },
                    { new Guid("ad02e85c-a40e-75a9-48ae-7b31ec0a1a34"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(8143), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "In eos non non nemo. Sit quia quasi odio. Ut fugit quae. Earum ipsa voluptatem accusantium consequatur fuga soluta. Sed deserunt quis optio dolorem illo qui.\n\nNeque numquam nihil aut. Nobis nisi voluptate inventore dicta numquam impedit provident. Esse eveniet blanditiis error ut non ut velit harum. Quia nisi deserunt rerum modi error occaecati qui fuga. Ea veritatis molestiae. Iste rem quia molestiae sunt saepe quo id quas dolores.\n\nMaiores unde libero omnis. Aut molestias voluptas. Dolores nam aut deserunt quasi nobis. Veritatis ut nesciunt.", null, "Branding" },
                    { new Guid("aec6d115-cf79-2236-47d4-4056918cdaf7"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(824), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Eligendi magni sapiente nulla molestias numquam sit. Porro sunt ipsam illo quas sapiente omnis tempora. At aliquam omnis laboriosam doloribus dolor neque. Dolores perspiciatis illum.\n\nEnim enim quisquam quibusdam et dolorem doloribus quasi dolorem quia. Consequatur ullam ut. Commodi est est dolorum hic alias tempora est harum. Dolor est et odio.\n\nQuia veniam autem earum et. Distinctio ea adipisci laudantium sunt dolores quam odio a perferendis. Enim et sequi. Et vero laboriosam. Modi officiis optio facere incidunt ratione assumenda neque quaerat.", null, "Solutions" },
                    { new Guid("b2562f68-b399-9890-3fa4-dec73170ff22"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(7184), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Molestias in sit. Natus non itaque iure. Mollitia omnis quae debitis suscipit quos dignissimos. Cum velit ex minus sapiente quas nemo dolorem. Molestias quasi accusantium fugit minima suscipit voluptate sed reiciendis. A minus dicta consequatur sint sapiente.\n\nVoluptates quibusdam quod. Deleniti et a quidem in doloribus dolor. Quis numquam sed atque eos voluptatum ipsam. Cupiditate maiores aut suscipit excepturi non eligendi. Nihil repellendus consectetur modi officiis animi minima esse ad. Quasi in magni id eum ipsam odio iure.\n\nRepellendus mollitia ut aliquam. Aliquid et architecto. Voluptas aperiam occaecati voluptates modi ea provident labore. Porro sapiente nesciunt ea aliquam. Dolorem magnam illum molestiae deleniti.", null, "Factors" },
                    { new Guid("c557cad9-062c-6ae9-71b2-beccbf17f23a"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(8650), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Fugiat eum deserunt impedit est ea ipsa ad. Deserunt in eligendi et et expedita. Praesentium sit nostrum est. Vitae veniam quia. Reiciendis neque ad eaque quidem fuga.\n\nNon atque possimus. Omnis eveniet aperiam mollitia et perspiciatis deleniti distinctio iure. Eum deleniti est earum non. Adipisci est enim maiores voluptatem voluptas delectus.\n\nSint enim sunt in. Voluptates autem hic. Qui expedita fugit quaerat repellendus exercitationem velit quae. Officia sint est facere et perferendis quisquam et aut. Perspiciatis mollitia laborum tenetur soluta architecto.", null, "Program" },
                    { new Guid("d94ebd6f-3e65-57e9-afa2-36b7a6cc1845"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(7926), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Veritatis est earum officia pariatur officia sit adipisci. Eaque ex voluptas a. Voluptatem velit id explicabo eum quo beatae. Beatae quam vitae. Maiores voluptas omnis qui voluptatum et.\n\nDicta laudantium accusamus hic. Explicabo dolorum quas quod dolores officiis vitae et earum. Ut quo suscipit et consectetur harum minus ea. Facere voluptate ab eum.\n\nPraesentium aut aliquam omnis dolores enim aut ea rerum sunt. Nihil voluptatem vel qui voluptatem recusandae. Et autem ea facilis nostrum. Minus iusto et. Doloremque ullam dolores sit inventore fugit quo aut.", null, "Quality" },
                    { new Guid("f10a6263-7663-fcd6-f5b4-caa06cf651e0"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 875, DateTimeKind.Local).AddTicks(1469), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Repudiandae ipsum dicta impedit illum et vitae pariatur et atque. Sed incidunt est expedita. Repellendus quo sequi enim incidunt alias. Accusamus quas aliquid. Qui fugit voluptatum occaecati voluptas. Similique repudiandae vero voluptates.\n\nRepellat sunt ea sit velit ipsum quia dolores voluptas. Voluptas est voluptates deserunt cumque reprehenderit eveniet. Et numquam ullam tempora quia eius sit veniam adipisci dolor. Recusandae necessitatibus eaque omnis et consequatur deleniti laborum tenetur. Accusantium ea cupiditate autem eos. Sed labore ad sequi corrupti.\n\nEaque aspernatur a id quis doloribus. Sequi inventore ea fuga numquam. Deleniti facere illo. Delectus inventore assumenda aliquam sit sequi similique quasi.", null, "Group" },
                    { new Guid("f6f39d3b-924a-3bb1-d49a-86dfe7d41127"), 0, new DateTime(2024, 12, 1, 16, 52, 7, 874, DateTimeKind.Local).AddTicks(9756), new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), "Autem ut est nostrum eum vel molestiae nemo. Et ea non. Voluptatem ea ad cumque sed quod qui velit. Et ducimus repudiandae.\n\nEt et cum voluptatem debitis atque et. Et qui incidunt exercitationem explicabo. Perferendis cum facilis.\n\nIpsam laborum soluta beatae dicta architecto. Ratione et asperiores enim id. Ut sit laudantium reiciendis laudantium. Delectus occaecati cum qui ad.", null, "Interactions" }
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "id", "active", "created_at", "description", "duration", "instructor_id", "is_free", "lastupdate", "thumb", "title" },
                values: new object[,]
                {
                    { new Guid("1b5a35a1-30e4-4fc0-ade1-7ce519f79278"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5383), "Porro hic omnis molestiae assumenda esse. Facilis sed voluptas aliquam assumenda. Reprehenderit dolorem id fugiat deleniti dolores. Rerum voluptas cumque et sapiente ut architecto.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5384), null, "Bacon" },
                    { new Guid("3164dd2a-6fa2-412d-ae92-256bbd54b553"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5735), null, null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5736), null, "Curso de baixa qualidade" },
                    { new Guid("47ca623a-fd0b-4f0b-a249-ee157f131793"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(4320), "Quam sit quae. Eos modi quaerat. Quibusdam molestiae est dicta similique. Aut neque qui magnam excepturi enim quo itaque voluptatum facilis. Iste veniam nihil sunt eos fuga id repellat.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(4323), null, "Cadeira" },
                    { new Guid("496fef17-57d4-491e-8133-ac26cbbe8ea7"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5457), "Dolore dicta aut non accusantium mollitia. Velit veniam id ut beatae. Officia consequuntur aspernatur.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5458), null, "Salada" },
                    { new Guid("4a5781af-9cc2-4d11-bd70-6036b307a891"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5163), "Debitis quasi exercitationem est sapiente. Animi in nobis molestiae voluptatem labore nisi debitis perferendis ipsa. Voluptas porro corrupti sed. Repellat sed eius. Iusto ipsa qui facilis et. Pariatur deserunt sint dolorem veritatis.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5164), null, "Bacon" },
                    { new Guid("4aa5f1a2-dd97-43b9-93fe-65fbea051f5e"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(4641), "Aliquam omnis labore et non dolores dolores nihil. Nemo aperiam enim vero quod non quis eius laboriosam provident. Excepturi blanditiis consectetur esse. Delectus aspernatur assumenda. Praesentium voluptas ea ut tempore. Eos et impedit rem enim aperiam dicta delectus.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(4642), null, "Peixe" },
                    { new Guid("657d4077-f95d-4552-b68a-acb527fd60cf"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5660), "Laboriosam qui dolores et impedit qui. Et cumque enim explicabo dignissimos voluptatem quam cupiditate. Asperiores numquam reiciendis quasi facere magni rerum recusandae error voluptates.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5661), null, "Computador" },
                    { new Guid("7856391d-7344-4b57-9d95-fbcd9154502a"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5027), "Rerum non facilis. Dolores aut et voluptas. Magnam et quod. Consequatur voluptas cumque consequatur veniam aut et excepturi ea. Qui reprehenderit quasi nemo sint. Molestias saepe ratione nostrum officia iusto vel autem id eum.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5029), null, "Frango" },
                    { new Guid("9263c266-85a5-45a1-b800-3a66076b3df0"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5295), "Quia qui sit et. Debitis perspiciatis ducimus quasi reiciendis qui iure minus eum qui. Iusto sapiente explicabo nam iure velit qui ullam voluptas. Voluptate autem aut deleniti illo occaecati autem. Quia ut ut.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5297), null, "Queijo" },
                    { new Guid("a3b185f5-cc60-44fd-8793-9b71204ca99a"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(1927), "Velit voluptates modi vel beatae aut. Id consequatur sed. Est excepturi doloremque.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(1937), null, "Luvas" },
                    { new Guid("aa26a5b5-a275-4ffd-a19f-5bd4cc9f474d"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(4514), "Fugiat placeat et. Quam dolores sit facilis tempore quas. Id ullam dignissimos sunt. Neque enim quam. Ea quam enim perferendis commodi totam. Vitae quia laboriosam natus inventore asperiores neque qui.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(4516), null, "Salgadinhos" },
                    { new Guid("abfc6c39-ab4d-4a85-9d02-9317b9f6d7db"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(4880), "Iusto natus asperiores molestiae aut alias. Molestias voluptatibus molestias enim voluptas nulla excepturi vel animi eos. Adipisci consectetur voluptatem minus eum aut porro rerum. Animi eum labore reiciendis provident. Repellat aliquid quia maxime non occaecati dolorem odio dolor. Sed necessitatibus vitae est officia nemo praesentium ex sit nihil.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(4882), null, "Bola" },
                    { new Guid("da563e3d-4197-4e0e-b40f-63034ba0700d"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5505), "Unde sunt doloribus sunt a labore cupiditate repellat nam. Voluptas dignissimos molestiae est magnam molestiae nobis quia. Aut eaque ea ut quia id velit ut. Dolores quasi consequatur eius veniam quaerat et aut.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5506), null, "Pizza" },
                    { new Guid("ed7dca20-e92c-45af-956a-e773a1a4e71b"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(4788), "Sit nam non aliquid commodi enim dicta. Iure fugit sint quasi non aspernatur. Omnis ipsa consequatur similique quas. Eum eos quo recusandae libero harum.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(4789), null, "Chapéu" },
                    { new Guid("f8870581-8b0b-4512-ac49-32843937b77b"), true, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5593), "Voluptatibus necessitatibus eaque nihil. Nihil sapiente molestiae. Autem id repellat totam ad. Quis facere magnam doloribus omnis molestiae dolorum. Deserunt eos neque.", null, new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"), false, new DateTime(2024, 12, 1, 16, 52, 7, 877, DateTimeKind.Local).AddTicks(5594), null, "Frango" }
                });

            migrationBuilder.InsertData(
                table: "subscription_plans",
                columns: new[] { "id", "admin_id", "created_at", "description", "months", "price" },
                values: new object[,]
                {
                    { new Guid("1c924f4a-8d9f-4846-93f0-c792a85af61a"), new Guid("344de1e4-c5cc-4c60-aad5-508006dfb6ed"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(4884), "Mensal", 1, 35f },
                    { new Guid("7f1ba514-67b9-413b-bc25-427ac6da2787"), new Guid("344de1e4-c5cc-4c60-aad5-508006dfb6ed"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(4892), "Anual", 12, 399.99f },
                    { new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87"), new Guid("344de1e4-c5cc-4c60-aad5-508006dfb6ed"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(4876), "Free", 0, 0f }
                });

            migrationBuilder.InsertData(
                table: "modules",
                columns: new[] { "id", "complete", "course_id", "description", "order", "title" },
                values: new object[,]
                {
                    { new Guid("149a0a87-a0c6-4c8f-8309-07207ec3798b"), false, new Guid("3164dd2a-6fa2-412d-ae92-256bbd54b553"), null, 2, "Modulo 3" },
                    { new Guid("a2ab6a00-918b-4443-931d-7cc80e3ac3a4"), false, new Guid("3164dd2a-6fa2-412d-ae92-256bbd54b553"), null, 0, "introducao" },
                    { new Guid("b2000ed8-a372-4848-baff-6ae0d983591c"), false, new Guid("3164dd2a-6fa2-412d-ae92-256bbd54b553"), null, 1, "Modulo 2" }
                });

            migrationBuilder.InsertData(
                table: "post_categories",
                columns: new[] { "id", "blog_post_id", "category_id" },
                values: new object[,]
                {
                    { new Guid("0563db23-e4a5-4b10-aff1-cd8d02815b9c"), new Guid("56b8f0c9-238d-d8c4-2400-d1d4c563bf54"), new Guid("cefa72f0-3154-4cb1-97b6-d770be9985ef") },
                    { new Guid("0c08a6be-ee4e-46ee-82e2-97ab5477a3ae"), new Guid("90362389-1e41-e4e1-2340-4bf7652c6517"), new Guid("221ecd6f-ba3c-46d2-badb-38910d01848c") },
                    { new Guid("1452c598-d359-4de7-b52c-d14853b63976"), new Guid("aec6d115-cf79-2236-47d4-4056918cdaf7"), new Guid("e5d64e09-22a2-4b7f-aecc-7b5a8f63bb7c") },
                    { new Guid("1ad21a2c-7964-4c50-a620-e04f1dc5d871"), new Guid("7ad11b41-410b-1e7d-c28f-7f719b68b184"), new Guid("df8c4b01-58a5-4509-8c45-8dcb9dbb9559") },
                    { new Guid("275c54c6-2fbe-4411-a481-9694dd0cf1f9"), new Guid("f6f39d3b-924a-3bb1-d49a-86dfe7d41127"), new Guid("5de4ae9f-00ea-4a48-bf16-5289dc13a250") },
                    { new Guid("38a94eab-622e-4360-9967-d7fb309e99fb"), new Guid("480a9c8d-bb3c-5e76-78b7-d566f9aa3905"), new Guid("4a9aa0bb-2376-40e0-b8ad-1ce84ffa825f") },
                    { new Guid("3cffd69e-b4d6-43fa-92bd-179adced1991"), new Guid("a52f41a7-8eae-199e-2c41-8b6da7c1f257"), new Guid("da6ba5f1-c6a9-4a7c-8295-5aa0a4b57eab") },
                    { new Guid("44770466-fc78-4c6b-a46f-7d6003dea217"), new Guid("a15df535-40ff-c6d0-9997-df5b3ba3102a"), new Guid("df8c4b01-58a5-4509-8c45-8dcb9dbb9559") },
                    { new Guid("49953844-466e-4c73-afdd-07a6b93dba5e"), new Guid("5f141f0b-8170-8dae-9feb-dc5783e7c736"), new Guid("221ecd6f-ba3c-46d2-badb-38910d01848c") },
                    { new Guid("5bcd4dd8-80f5-41c3-ab29-a0e53ebe05d6"), new Guid("09b25f5b-e7b5-0d72-dba2-76cfceb3e724"), new Guid("221ecd6f-ba3c-46d2-badb-38910d01848c") },
                    { new Guid("71c5aebb-be55-43af-914d-f16f8bc368e1"), new Guid("516237b6-316d-0cb4-3c0f-ccb5cd426913"), new Guid("da6ba5f1-c6a9-4a7c-8295-5aa0a4b57eab") },
                    { new Guid("76baa8f7-060d-4d14-b87f-e0e608c575ee"), new Guid("d94ebd6f-3e65-57e9-afa2-36b7a6cc1845"), new Guid("da6ba5f1-c6a9-4a7c-8295-5aa0a4b57eab") },
                    { new Guid("7d870e8b-ddda-4163-ab75-915af27f620d"), new Guid("b2562f68-b399-9890-3fa4-dec73170ff22"), new Guid("a6386299-25f8-42cf-943e-cf080adf69e7") },
                    { new Guid("821dcf70-97cf-4900-8633-fa1c77f5ea68"), new Guid("a599c57b-8d4a-7a14-ed4a-a62cd916a9fe"), new Guid("221ecd6f-ba3c-46d2-badb-38910d01848c") },
                    { new Guid("92974fd2-6974-44ec-b835-ab5da19a81ef"), new Guid("acc4db4f-5630-b24c-9a0c-d3a62ff16395"), new Guid("b9fb36df-0af9-4647-8a3e-bbdced746503") },
                    { new Guid("948df305-3ced-41fe-8eb9-ea32f2e88d66"), new Guid("c557cad9-062c-6ae9-71b2-beccbf17f23a"), new Guid("cefa72f0-3154-4cb1-97b6-d770be9985ef") },
                    { new Guid("9ba1ad2a-f10d-4899-9072-78fc40cceb12"), new Guid("737e36a0-de19-5c8f-0048-6205ce108da1"), new Guid("da6ba5f1-c6a9-4a7c-8295-5aa0a4b57eab") },
                    { new Guid("a360a2a2-f39d-4b06-bcec-73186afe7905"), new Guid("f10a6263-7663-fcd6-f5b4-caa06cf651e0"), new Guid("e5d64e09-22a2-4b7f-aecc-7b5a8f63bb7c") },
                    { new Guid("b6ce62f6-a976-4ba1-b7b0-799a66836e3d"), new Guid("9883eb4a-4618-59f3-89ad-010f802223e2"), new Guid("df8c4b01-58a5-4509-8c45-8dcb9dbb9559") },
                    { new Guid("b9342bc7-a07a-4e9d-92f1-8b5fdbdcdcd8"), new Guid("42908f44-af0f-5778-c57d-dd9b0b0f65aa"), new Guid("b9fb36df-0af9-4647-8a3e-bbdced746503") },
                    { new Guid("bafe3be8-a81e-4ad5-8831-191424230a85"), new Guid("3c75d55d-7c85-700e-6903-9d01be339e1f"), new Guid("cefa72f0-3154-4cb1-97b6-d770be9985ef") },
                    { new Guid("bb4a0c15-8d02-457f-8132-2790666468fe"), new Guid("ad02e85c-a40e-75a9-48ae-7b31ec0a1a34"), new Guid("b9fb36df-0af9-4647-8a3e-bbdced746503") },
                    { new Guid("d94de3a9-a998-4775-9cf0-b59189502ea5"), new Guid("8ba8c410-c95c-3a68-8ce4-4d40f57510b0"), new Guid("a6386299-25f8-42cf-943e-cf080adf69e7") },
                    { new Guid("d9714078-2197-4232-af75-a38828f3bbd0"), new Guid("00dd6672-bb1d-38ae-9c0b-e9a8321f9919"), new Guid("4a9aa0bb-2376-40e0-b8ad-1ce84ffa825f") },
                    { new Guid("de3ddc0f-ac1f-43e1-adf1-8197d517042d"), new Guid("acdeeb33-5a07-7718-cef9-230b21e04cfb"), new Guid("4a9aa0bb-2376-40e0-b8ad-1ce84ffa825f") },
                    { new Guid("de9c79df-adbd-422f-91c5-0ae4eea13e36"), new Guid("97a66f36-1a50-96c2-7dea-2d620ad232f5"), new Guid("5ddb66a7-a154-408e-ba54-954038bb5b2d") },
                    { new Guid("e4799635-f83f-4f8a-bfcf-f340d192e1d6"), new Guid("8406a1ae-318c-01d0-0f2e-dd3cfce9e766"), new Guid("5ddb66a7-a154-408e-ba54-954038bb5b2d") },
                    { new Guid("ec74a9a1-c788-4df8-8d78-c94052d8266d"), new Guid("8e3e6c1a-c785-2ff7-2be6-438cbc712b35"), new Guid("a6386299-25f8-42cf-943e-cf080adf69e7") },
                    { new Guid("f4a54455-c72e-4a81-a808-b77a3d681c38"), new Guid("04d43348-cdda-0261-8226-fb0a6d522d69"), new Guid("5ddb66a7-a154-408e-ba54-954038bb5b2d") },
                    { new Guid("f623e2d8-eb2a-4d37-8a61-a7da80695e43"), new Guid("37a189b9-85e6-c510-5c6f-24eff907c3ef"), new Guid("df8c4b01-58a5-4509-8c45-8dcb9dbb9559") }
                });

            migrationBuilder.InsertData(
                table: "user_plan",
                columns: new[] { "id", "client_id", "created_at", "is_active", "subscriptionplan_id" },
                values: new object[,]
                {
                    { new Guid("06552576-790e-4016-b5a0-1607d5671773"), new Guid("8b039ba1-727d-4772-8fe0-9ff1d75acdaa"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5345), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("089bf5d4-b3d1-41e9-ad5a-09496124b8c9"), new Guid("1328e5bb-1643-4256-9a26-e6f5b6ce4650"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5657), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("0c3353f8-adb8-4d6f-8549-ca4f368160b0"), new Guid("8cfdf48a-a0ed-4027-a980-12244ae5f160"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5663), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("22c5b92b-520b-4ba8-8fee-50ced8ae7bc3"), new Guid("4e38b9fc-4e2c-4023-85a0-243019afb381"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5379), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("32a22db1-8c03-40ee-90eb-d30c1f46b46b"), new Guid("0f23eaa3-d923-4de6-b10b-89c824d9bc5a"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5446), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("3380714a-c32e-45d5-a04e-c73919440daa"), new Guid("8f266345-19ee-4d2b-a462-41cf604fc025"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5631), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("359e988c-0235-46a6-8378-96b518ac2852"), new Guid("c82987ea-6b09-4567-a06e-a0893e2f1801"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5558), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("359f5e8f-cc4f-40b2-beab-90e1a7588462"), new Guid("e9753ca5-3c16-44f1-8080-05a44640e2c4"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5591), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("376ede94-5291-47a3-9399-decb1e2a9a1e"), new Guid("c3c84884-8e39-4d6d-a506-d647368ff192"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5473), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("38288dfe-b503-46bb-955b-720448dd7d0c"), new Guid("afeb3424-cdc3-423e-985e-ed42fafce4c0"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5624), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("3a420aa6-f11d-4aea-9719-424a4a66c253"), new Guid("9b973fdc-3a94-4ca6-b502-e84bc58df4e1"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5506), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("4b05f77d-4c16-4bec-bd31-c9895e1785ef"), new Guid("fd88f959-3c61-4348-b4c1-680d7bc0e8b5"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5365), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("4c37249c-4ce8-4d1e-a674-b411de3ed30e"), new Guid("23125089-73f5-4670-80c7-36d1353f060d"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5336), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("4dc2c8b8-c0c2-433b-a2ea-b29d754e12fa"), new Guid("b55379b3-fa5b-45b0-8df5-55fd9fac13df"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5572), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("56c6593d-452d-4105-8f79-7053f7ebfdee"), new Guid("894ffe26-a3ff-49d6-81ba-c13e466172b4"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5352), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("5895daec-34f5-42d0-9844-64b94eb71bed"), new Guid("42299a4f-0bc8-4ca6-bfaa-961681dee41a"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5551), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("637c1b85-0bf9-4249-9c81-a44c7a414fe3"), new Guid("7ef29d00-3f67-4e12-b444-6840785059a0"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5519), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("64c0ec09-d5ed-4ded-afbb-4d0f03ff187e"), new Guid("5c6f5b50-69a5-4a91-b1de-23371e0f99c6"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5399), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("64fdcef0-dc01-4ef5-b03c-d19affacf8bf"), new Guid("7e6cfa6e-f8fe-4365-bb47-2cac1f4c3942"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5578), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("653ecebb-9d1d-448c-9d0f-37dd524e67f9"), new Guid("1e756cef-4ec3-441a-ad18-cf3c2000d1da"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5466), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("69409c63-edfc-4bf5-90b9-a7bfd117026a"), new Guid("77e6bcfd-35aa-470e-9921-f26ac277c2bd"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5386), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("69e0cbac-b6fb-4d0a-96d2-98281daa6527"), new Guid("1826a0f9-475d-4e87-acba-4b3975358d6f"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5644), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("6b36dee9-9c16-4f54-a78b-22b90e6f1061"), new Guid("9e2a4f1b-5ccc-42c4-a72d-9ed7febec88b"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5452), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("78fa57a2-1427-48e8-b967-a2e04d18a276"), new Guid("a412e104-92c8-4678-b51e-8042585898f9"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5372), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("7a758547-6367-45ca-b674-edbec859c971"), new Guid("13e04d0d-93f2-4b54-ae39-c2fbdf81a36f"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5492), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("7eb66f17-eb6d-4333-9e08-c71e965f268c"), new Guid("86c035e0-f7ff-4bbe-8521-1f01fe0091df"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5618), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("8b000289-1032-42a7-bb25-eb318e18334c"), new Guid("08399f5b-7bbd-4ab7-8d31-c8aabbb71453"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5512), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("8dc7380f-f7a8-48e1-bffe-2b0716e8ceae"), new Guid("31d1f9a8-fd25-4fc0-80b7-30fe40c53d71"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5605), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("91f71a3e-e03d-4f68-a502-548e85e03646"), new Guid("18e76320-761f-4972-95a3-5417184e6059"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5545), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("952c300f-aebf-4f90-bd73-41be54638e50"), new Guid("8e2e38bb-bb29-4f4b-94ee-74bb83e2f116"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5440), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("9ad3a28b-4d38-4976-b454-c1764728b540"), new Guid("24aabc0f-862e-4dea-a23e-c30572a39ce5"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5637), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("9e15f8a9-0346-4016-8610-266e48b8dc51"), new Guid("67ca3237-6091-4c14-8e81-b85ca5a21075"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5433), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("a3c05c0a-e811-4c89-970c-553b0938868c"), new Guid("e5eae2f4-88d2-4ed8-8575-7a2bcdf1ef18"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5598), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("aa439a15-4214-46ff-b59e-e6c182aebcf6"), new Guid("ee2504c6-693d-401c-b474-f4d1880ebbbd"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5413), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("bba80985-01c6-409a-ba9a-e8f63aa974ca"), new Guid("da218660-009f-4249-a8cd-0c4d39f6ed7f"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5532), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("c5ebfcd2-a18a-4751-b8ca-4618019ddebd"), new Guid("1b96e94c-7b27-4859-ab17-dbb5e13ccc8f"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5479), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("ca3de8fd-1cb4-4c75-965a-7a81b4c1a3ac"), new Guid("6e6cb200-8cf7-4fc0-b1cf-1fb390b86465"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5420), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("d514febf-7b95-4044-a886-4eb622dfb759"), new Guid("5b70997e-a16b-4369-a939-c87be194cef7"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5585), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("d76698de-28f7-4304-9ee3-12beeba42a78"), new Guid("8c91a9c7-7570-4e18-a8b0-ecd5d214493e"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5525), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("d8941c89-b810-4469-913a-7bb9a18a8e1b"), new Guid("9690bd7b-5ba6-41c3-8bf5-a610756232cb"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5358), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("d923949e-bd61-45f1-8eb0-c0ff7b492417"), new Guid("9041b028-eb68-4127-9b2a-079c8f05ad6f"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5538), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("d9a3a7c5-39c8-4237-9a14-006ab79ff168"), new Guid("87bf6400-aca1-4650-a921-4eb18fa8086a"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5392), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("dde4bdcb-808a-4b13-ab46-b734e97dd68a"), new Guid("781d9ab6-802f-4e64-b417-dfcacb7e84f3"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5565), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("e293ed79-ba48-49b3-a4ee-e41b97bb6912"), new Guid("09ed4c40-0b92-4d12-b57f-d54c09cebc85"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5486), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("e98d7205-a28b-42c0-8680-938d3d39aab7"), new Guid("d38d8561-6423-40f9-9e9a-6f48e5ae3357"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5427), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("ebd2fecc-5c0c-416d-8b53-21035a284335"), new Guid("dd6e9a79-d132-4092-9c0d-55beeb3a4455"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5611), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("eebe6f20-a6b9-4bac-aabf-efc06e2fdff1"), new Guid("464e2d0f-6027-487d-a018-0e9bba118b19"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5670), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("f03ab1c9-8b23-4b20-9962-23a4ce2eee4b"), new Guid("173fda28-4305-48bc-8b0d-38aa7bfaa017"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5650), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("f40709a4-c438-442f-9f6b-b638a600e78a"), new Guid("e3074c9d-ab43-4f93-b16a-44e2deba4b55"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5499), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") },
                    { new Guid("f8123b40-4e5b-4a4e-876d-8f64c470ac92"), new Guid("c866dd90-cda9-44c9-8a03-672ee0ccd517"), new DateTime(2024, 12, 1, 16, 52, 7, 872, DateTimeKind.Local).AddTicks(5460), true, new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87") }
                });

            migrationBuilder.InsertData(
                table: "videos",
                columns: new[] { "id", "created_at", "description", "duration", "module_id", "order", "title", "video_url" },
                values: new object[,]
                {
                    { new Guid("007a8637-c19c-4692-bca7-28d0b7001785"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(5007), null, null, new Guid("b2000ed8-a372-4848-baff-6ae0d983591c"), 19, "Prático Plástico Pizza", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("01ee1d2a-a74b-4755-926e-1a672a6b48a4"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4755), null, null, new Guid("a2ab6a00-918b-4443-931d-7cc80e3ac3a4"), 4, "Incrível Metal Mesa", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("0c47e34c-dcc1-4ba6-a524-491fd86733aa"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4853), null, null, new Guid("b2000ed8-a372-4848-baff-6ae0d983591c"), 10, "Prático Granito Sabonete", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("127f7099-b3f0-49bc-b853-9806d2c2772b"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(5166), null, null, new Guid("149a0a87-a0c6-4c8f-8309-07207ec3798b"), 29, "Lindo Granito Queijo", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("1a5befb3-60bf-4fab-8f4d-c6f86dd597e6"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(5037), null, null, new Guid("149a0a87-a0c6-4c8f-8309-07207ec3798b"), 21, "Licenciado Madeira Computador", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("1b9a661f-d347-4985-a316-f381e06d2bbd"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(5082), null, null, new Guid("149a0a87-a0c6-4c8f-8309-07207ec3798b"), 24, "Lindo Borracha Mouse", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("2b91de63-b22a-4cd0-a5fd-9507ae954c81"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4909), null, null, new Guid("b2000ed8-a372-4848-baff-6ae0d983591c"), 13, "Inteligente Aço Sapatos", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("2c794ddb-41ff-4199-95cc-efd16c6e57d8"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(5136), null, null, new Guid("149a0a87-a0c6-4c8f-8309-07207ec3798b"), 27, "Gostoso Madeira Computador", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("32a4c731-8224-4d63-8100-f1a85cf2ed49"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4805), null, null, new Guid("a2ab6a00-918b-4443-931d-7cc80e3ac3a4"), 7, "Ergonômico Macio Sabonete", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("36dc6eca-128c-4250-aa9b-770fd4af31bd"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4962), null, null, new Guid("b2000ed8-a372-4848-baff-6ae0d983591c"), 16, "Licenciado Plástico Salgadinhos", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("3b291273-d8e1-44e7-b279-4b335354e280"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(5096), null, null, new Guid("149a0a87-a0c6-4c8f-8309-07207ec3798b"), 25, "Refinado Aço Computador", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("44e987be-8ecd-4aa9-a7ef-91960e516a22"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4978), null, null, new Guid("b2000ed8-a372-4848-baff-6ae0d983591c"), 17, "Gostoso Congelado Mesa", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("6e6d2ace-7020-4384-89ce-bd16fc0b4468"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4822), null, null, new Guid("a2ab6a00-918b-4443-931d-7cc80e3ac3a4"), 8, "Inteligente Madeira Computador", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("78e974de-daea-41bf-99c8-9263aec599dd"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(5151), null, null, new Guid("149a0a87-a0c6-4c8f-8309-07207ec3798b"), 28, "Incrível Plástico Chapéu", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("793fbde2-5921-4e8f-93c4-89cbbb3caece"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4736), null, null, new Guid("a2ab6a00-918b-4443-931d-7cc80e3ac3a4"), 3, "Lindo Aço Salsicha", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("7e50d631-6285-4f79-a291-b5914f165795"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4992), null, null, new Guid("b2000ed8-a372-4848-baff-6ae0d983591c"), 18, "Rústico Algodão Sapatos", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("98863df4-561e-48b5-9073-3de653d3ee40"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4940), null, null, new Guid("b2000ed8-a372-4848-baff-6ae0d983591c"), 15, "Lustroso Algodão Teclado", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("994ceefd-cb64-4c48-82f7-9a37ff62bbf8"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(2828), null, null, new Guid("a2ab6a00-918b-4443-931d-7cc80e3ac3a4"), 0, "Rústico Algodão Mouse", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("acd52a0f-26c2-4497-8c6d-fc8880718018"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4717), null, null, new Guid("a2ab6a00-918b-4443-931d-7cc80e3ac3a4"), 2, "Fantástico Granito Salgadinhos", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("b1bbb385-e80e-4803-8dd7-e8725d8dde5d"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4772), null, null, new Guid("a2ab6a00-918b-4443-931d-7cc80e3ac3a4"), 5, "Lindo Borracha Frango", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("b9ea3868-53ec-4a2e-9052-292169dbade0"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(5023), null, null, new Guid("149a0a87-a0c6-4c8f-8309-07207ec3798b"), 20, "Genérico Metal Camiseta", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("bc378597-3708-4212-aafb-359f471a3467"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4837), null, null, new Guid("a2ab6a00-918b-4443-931d-7cc80e3ac3a4"), 9, "Inteligente Borracha Salada", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("bebbb393-81ab-4c38-ac84-999e884bf17a"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(5052), null, null, new Guid("149a0a87-a0c6-4c8f-8309-07207ec3798b"), 22, "Gostoso Granito Bacon", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("cd7eaf94-063e-4477-a203-98d98c979eed"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(5111), null, null, new Guid("149a0a87-a0c6-4c8f-8309-07207ec3798b"), 26, "Lindo Borracha Salsicha", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("d29d7a74-4edb-4729-9a41-f6ea0ab082e6"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4789), null, null, new Guid("a2ab6a00-918b-4443-931d-7cc80e3ac3a4"), 6, "Feito à mão Congelado Luvas", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("d400f68a-9d5f-4f20-b949-a4fbe9b14f32"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4676), null, null, new Guid("a2ab6a00-918b-4443-931d-7cc80e3ac3a4"), 1, "Fantástico Fresco Mouse", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("d8bb5129-c90f-4719-9ca5-a6b2bf539c04"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4925), null, null, new Guid("b2000ed8-a372-4848-baff-6ae0d983591c"), 14, "Lindo Macio Mesa", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("f9890965-1c5c-44d5-8b70-15828d31536c"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(5067), null, null, new Guid("149a0a87-a0c6-4c8f-8309-07207ec3798b"), 23, "Incrível Macio Mesa", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("fd7f251b-d975-487c-9a04-cd0e3b688ddf"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4883), null, null, new Guid("b2000ed8-a372-4848-baff-6ae0d983591c"), 12, "Feito à mão Congelado Toalhas", "https://www.youtube.com/watch?v=P_rG9ttOgj4" },
                    { new Guid("ff68f8d2-52f7-4658-9f30-c0e99167e60c"), new DateTime(2024, 12, 1, 16, 52, 7, 879, DateTimeKind.Local).AddTicks(4868), null, null, new Guid("b2000ed8-a372-4848-baff-6ae0d983591c"), 11, "Prático Fresco Carro", "https://www.youtube.com/watch?v=P_rG9ttOgj4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("1b5a35a1-30e4-4fc0-ade1-7ce519f79278"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("47ca623a-fd0b-4f0b-a249-ee157f131793"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("496fef17-57d4-491e-8133-ac26cbbe8ea7"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("4a5781af-9cc2-4d11-bd70-6036b307a891"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("4aa5f1a2-dd97-43b9-93fe-65fbea051f5e"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("657d4077-f95d-4552-b68a-acb527fd60cf"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("7856391d-7344-4b57-9d95-fbcd9154502a"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("9263c266-85a5-45a1-b800-3a66076b3df0"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("a3b185f5-cc60-44fd-8793-9b71204ca99a"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("aa26a5b5-a275-4ffd-a19f-5bd4cc9f474d"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("abfc6c39-ab4d-4a85-9d02-9317b9f6d7db"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("da563e3d-4197-4e0e-b40f-63034ba0700d"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("ed7dca20-e92c-45af-956a-e773a1a4e71b"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("f8870581-8b0b-4512-ac49-32843937b77b"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("0563db23-e4a5-4b10-aff1-cd8d02815b9c"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("0c08a6be-ee4e-46ee-82e2-97ab5477a3ae"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("1452c598-d359-4de7-b52c-d14853b63976"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("1ad21a2c-7964-4c50-a620-e04f1dc5d871"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("275c54c6-2fbe-4411-a481-9694dd0cf1f9"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("38a94eab-622e-4360-9967-d7fb309e99fb"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("3cffd69e-b4d6-43fa-92bd-179adced1991"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("44770466-fc78-4c6b-a46f-7d6003dea217"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("49953844-466e-4c73-afdd-07a6b93dba5e"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("5bcd4dd8-80f5-41c3-ab29-a0e53ebe05d6"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("71c5aebb-be55-43af-914d-f16f8bc368e1"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("76baa8f7-060d-4d14-b87f-e0e608c575ee"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("7d870e8b-ddda-4163-ab75-915af27f620d"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("821dcf70-97cf-4900-8633-fa1c77f5ea68"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("92974fd2-6974-44ec-b835-ab5da19a81ef"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("948df305-3ced-41fe-8eb9-ea32f2e88d66"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("9ba1ad2a-f10d-4899-9072-78fc40cceb12"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("a360a2a2-f39d-4b06-bcec-73186afe7905"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("b6ce62f6-a976-4ba1-b7b0-799a66836e3d"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("b9342bc7-a07a-4e9d-92f1-8b5fdbdcdcd8"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("bafe3be8-a81e-4ad5-8831-191424230a85"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("bb4a0c15-8d02-457f-8132-2790666468fe"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("d94de3a9-a998-4775-9cf0-b59189502ea5"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("d9714078-2197-4232-af75-a38828f3bbd0"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("de3ddc0f-ac1f-43e1-adf1-8197d517042d"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("de9c79df-adbd-422f-91c5-0ae4eea13e36"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("e4799635-f83f-4f8a-bfcf-f340d192e1d6"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("ec74a9a1-c788-4df8-8d78-c94052d8266d"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("f4a54455-c72e-4a81-a808-b77a3d681c38"));

            migrationBuilder.DeleteData(
                table: "post_categories",
                keyColumn: "id",
                keyValue: new Guid("f623e2d8-eb2a-4d37-8a61-a7da80695e43"));

            migrationBuilder.DeleteData(
                table: "subscription_plans",
                keyColumn: "id",
                keyValue: new Guid("1c924f4a-8d9f-4846-93f0-c792a85af61a"));

            migrationBuilder.DeleteData(
                table: "subscription_plans",
                keyColumn: "id",
                keyValue: new Guid("7f1ba514-67b9-413b-bc25-427ac6da2787"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("06552576-790e-4016-b5a0-1607d5671773"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("089bf5d4-b3d1-41e9-ad5a-09496124b8c9"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("0c3353f8-adb8-4d6f-8549-ca4f368160b0"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("22c5b92b-520b-4ba8-8fee-50ced8ae7bc3"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("32a22db1-8c03-40ee-90eb-d30c1f46b46b"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("3380714a-c32e-45d5-a04e-c73919440daa"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("359e988c-0235-46a6-8378-96b518ac2852"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("359f5e8f-cc4f-40b2-beab-90e1a7588462"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("376ede94-5291-47a3-9399-decb1e2a9a1e"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("38288dfe-b503-46bb-955b-720448dd7d0c"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("3a420aa6-f11d-4aea-9719-424a4a66c253"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("4b05f77d-4c16-4bec-bd31-c9895e1785ef"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("4c37249c-4ce8-4d1e-a674-b411de3ed30e"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("4dc2c8b8-c0c2-433b-a2ea-b29d754e12fa"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("56c6593d-452d-4105-8f79-7053f7ebfdee"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("5895daec-34f5-42d0-9844-64b94eb71bed"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("637c1b85-0bf9-4249-9c81-a44c7a414fe3"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("64c0ec09-d5ed-4ded-afbb-4d0f03ff187e"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("64fdcef0-dc01-4ef5-b03c-d19affacf8bf"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("653ecebb-9d1d-448c-9d0f-37dd524e67f9"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("69409c63-edfc-4bf5-90b9-a7bfd117026a"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("69e0cbac-b6fb-4d0a-96d2-98281daa6527"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("6b36dee9-9c16-4f54-a78b-22b90e6f1061"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("78fa57a2-1427-48e8-b967-a2e04d18a276"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("7a758547-6367-45ca-b674-edbec859c971"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("7eb66f17-eb6d-4333-9e08-c71e965f268c"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("8b000289-1032-42a7-bb25-eb318e18334c"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("8dc7380f-f7a8-48e1-bffe-2b0716e8ceae"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("91f71a3e-e03d-4f68-a502-548e85e03646"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("952c300f-aebf-4f90-bd73-41be54638e50"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("9ad3a28b-4d38-4976-b454-c1764728b540"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("9e15f8a9-0346-4016-8610-266e48b8dc51"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("a3c05c0a-e811-4c89-970c-553b0938868c"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("aa439a15-4214-46ff-b59e-e6c182aebcf6"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("bba80985-01c6-409a-ba9a-e8f63aa974ca"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("c5ebfcd2-a18a-4751-b8ca-4618019ddebd"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("ca3de8fd-1cb4-4c75-965a-7a81b4c1a3ac"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("d514febf-7b95-4044-a886-4eb622dfb759"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("d76698de-28f7-4304-9ee3-12beeba42a78"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("d8941c89-b810-4469-913a-7bb9a18a8e1b"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("d923949e-bd61-45f1-8eb0-c0ff7b492417"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("d9a3a7c5-39c8-4237-9a14-006ab79ff168"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("dde4bdcb-808a-4b13-ab46-b734e97dd68a"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("e293ed79-ba48-49b3-a4ee-e41b97bb6912"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("e98d7205-a28b-42c0-8680-938d3d39aab7"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("ebd2fecc-5c0c-416d-8b53-21035a284335"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("eebe6f20-a6b9-4bac-aabf-efc06e2fdff1"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("f03ab1c9-8b23-4b20-9962-23a4ce2eee4b"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("f40709a4-c438-442f-9f6b-b638a600e78a"));

            migrationBuilder.DeleteData(
                table: "user_plan",
                keyColumn: "id",
                keyValue: new Guid("f8123b40-4e5b-4a4e-876d-8f64c470ac92"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("007a8637-c19c-4692-bca7-28d0b7001785"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("01ee1d2a-a74b-4755-926e-1a672a6b48a4"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("0c47e34c-dcc1-4ba6-a524-491fd86733aa"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("127f7099-b3f0-49bc-b853-9806d2c2772b"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("1a5befb3-60bf-4fab-8f4d-c6f86dd597e6"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("1b9a661f-d347-4985-a316-f381e06d2bbd"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("2b91de63-b22a-4cd0-a5fd-9507ae954c81"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("2c794ddb-41ff-4199-95cc-efd16c6e57d8"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("32a4c731-8224-4d63-8100-f1a85cf2ed49"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("36dc6eca-128c-4250-aa9b-770fd4af31bd"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("3b291273-d8e1-44e7-b279-4b335354e280"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("44e987be-8ecd-4aa9-a7ef-91960e516a22"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("6e6d2ace-7020-4384-89ce-bd16fc0b4468"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("78e974de-daea-41bf-99c8-9263aec599dd"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("793fbde2-5921-4e8f-93c4-89cbbb3caece"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("7e50d631-6285-4f79-a291-b5914f165795"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("98863df4-561e-48b5-9073-3de653d3ee40"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("994ceefd-cb64-4c48-82f7-9a37ff62bbf8"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("acd52a0f-26c2-4497-8c6d-fc8880718018"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("b1bbb385-e80e-4803-8dd7-e8725d8dde5d"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("b9ea3868-53ec-4a2e-9052-292169dbade0"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("bc378597-3708-4212-aafb-359f471a3467"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("bebbb393-81ab-4c38-ac84-999e884bf17a"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("cd7eaf94-063e-4477-a203-98d98c979eed"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("d29d7a74-4edb-4729-9a41-f6ea0ab082e6"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("d400f68a-9d5f-4f20-b949-a4fbe9b14f32"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("d8bb5129-c90f-4719-9ca5-a6b2bf539c04"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("f9890965-1c5c-44d5-8b70-15828d31536c"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("fd7f251b-d975-487c-9a04-cd0e3b688ddf"));

            migrationBuilder.DeleteData(
                table: "videos",
                keyColumn: "id",
                keyValue: new Guid("ff68f8d2-52f7-4658-9f30-c0e99167e60c"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("00dd6672-bb1d-38ae-9c0b-e9a8321f9919"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("04d43348-cdda-0261-8226-fb0a6d522d69"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("09b25f5b-e7b5-0d72-dba2-76cfceb3e724"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("37a189b9-85e6-c510-5c6f-24eff907c3ef"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("3c75d55d-7c85-700e-6903-9d01be339e1f"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("42908f44-af0f-5778-c57d-dd9b0b0f65aa"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("480a9c8d-bb3c-5e76-78b7-d566f9aa3905"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("516237b6-316d-0cb4-3c0f-ccb5cd426913"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("56b8f0c9-238d-d8c4-2400-d1d4c563bf54"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("5f141f0b-8170-8dae-9feb-dc5783e7c736"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("737e36a0-de19-5c8f-0048-6205ce108da1"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("7ad11b41-410b-1e7d-c28f-7f719b68b184"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("8406a1ae-318c-01d0-0f2e-dd3cfce9e766"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("8ba8c410-c95c-3a68-8ce4-4d40f57510b0"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("8e3e6c1a-c785-2ff7-2be6-438cbc712b35"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("90362389-1e41-e4e1-2340-4bf7652c6517"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("97a66f36-1a50-96c2-7dea-2d620ad232f5"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("9883eb4a-4618-59f3-89ad-010f802223e2"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("a15df535-40ff-c6d0-9997-df5b3ba3102a"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("a52f41a7-8eae-199e-2c41-8b6da7c1f257"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("a599c57b-8d4a-7a14-ed4a-a62cd916a9fe"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("acc4db4f-5630-b24c-9a0c-d3a62ff16395"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("acdeeb33-5a07-7718-cef9-230b21e04cfb"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("ad02e85c-a40e-75a9-48ae-7b31ec0a1a34"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("aec6d115-cf79-2236-47d4-4056918cdaf7"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("b2562f68-b399-9890-3fa4-dec73170ff22"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("c557cad9-062c-6ae9-71b2-beccbf17f23a"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("d94ebd6f-3e65-57e9-afa2-36b7a6cc1845"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("f10a6263-7663-fcd6-f5b4-caa06cf651e0"));

            migrationBuilder.DeleteData(
                table: "blog_posts",
                keyColumn: "id",
                keyValue: new Guid("f6f39d3b-924a-3bb1-d49a-86dfe7d41127"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("221ecd6f-ba3c-46d2-badb-38910d01848c"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("4a9aa0bb-2376-40e0-b8ad-1ce84ffa825f"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("5ddb66a7-a154-408e-ba54-954038bb5b2d"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("5de4ae9f-00ea-4a48-bf16-5289dc13a250"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("a6386299-25f8-42cf-943e-cf080adf69e7"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("b9fb36df-0af9-4647-8a3e-bbdced746503"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("cefa72f0-3154-4cb1-97b6-d770be9985ef"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("da6ba5f1-c6a9-4a7c-8295-5aa0a4b57eab"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("df8c4b01-58a5-4509-8c45-8dcb9dbb9559"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e5d64e09-22a2-4b7f-aecc-7b5a8f63bb7c"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("08399f5b-7bbd-4ab7-8d31-c8aabbb71453"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("09ed4c40-0b92-4d12-b57f-d54c09cebc85"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("0f23eaa3-d923-4de6-b10b-89c824d9bc5a"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("1328e5bb-1643-4256-9a26-e6f5b6ce4650"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("13e04d0d-93f2-4b54-ae39-c2fbdf81a36f"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("173fda28-4305-48bc-8b0d-38aa7bfaa017"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("1826a0f9-475d-4e87-acba-4b3975358d6f"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("18e76320-761f-4972-95a3-5417184e6059"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("1b96e94c-7b27-4859-ab17-dbb5e13ccc8f"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("1e756cef-4ec3-441a-ad18-cf3c2000d1da"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("23125089-73f5-4670-80c7-36d1353f060d"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("24aabc0f-862e-4dea-a23e-c30572a39ce5"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("31d1f9a8-fd25-4fc0-80b7-30fe40c53d71"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("42299a4f-0bc8-4ca6-bfaa-961681dee41a"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("464e2d0f-6027-487d-a018-0e9bba118b19"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("4e38b9fc-4e2c-4023-85a0-243019afb381"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("5b70997e-a16b-4369-a939-c87be194cef7"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("5c6f5b50-69a5-4a91-b1de-23371e0f99c6"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("67ca3237-6091-4c14-8e81-b85ca5a21075"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("6e6cb200-8cf7-4fc0-b1cf-1fb390b86465"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("77e6bcfd-35aa-470e-9921-f26ac277c2bd"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("781d9ab6-802f-4e64-b417-dfcacb7e84f3"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("7e6cfa6e-f8fe-4365-bb47-2cac1f4c3942"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("7ef29d00-3f67-4e12-b444-6840785059a0"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("86c035e0-f7ff-4bbe-8521-1f01fe0091df"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("87bf6400-aca1-4650-a921-4eb18fa8086a"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("894ffe26-a3ff-49d6-81ba-c13e466172b4"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("8b039ba1-727d-4772-8fe0-9ff1d75acdaa"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("8c91a9c7-7570-4e18-a8b0-ecd5d214493e"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("8cfdf48a-a0ed-4027-a980-12244ae5f160"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("8e2e38bb-bb29-4f4b-94ee-74bb83e2f116"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("8f266345-19ee-4d2b-a462-41cf604fc025"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("9041b028-eb68-4127-9b2a-079c8f05ad6f"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("9690bd7b-5ba6-41c3-8bf5-a610756232cb"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("9b973fdc-3a94-4ca6-b502-e84bc58df4e1"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("9e2a4f1b-5ccc-42c4-a72d-9ed7febec88b"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("a412e104-92c8-4678-b51e-8042585898f9"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("afeb3424-cdc3-423e-985e-ed42fafce4c0"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("b55379b3-fa5b-45b0-8df5-55fd9fac13df"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("c3c84884-8e39-4d6d-a506-d647368ff192"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("c82987ea-6b09-4567-a06e-a0893e2f1801"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("c866dd90-cda9-44c9-8a03-672ee0ccd517"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("d38d8561-6423-40f9-9e9a-6f48e5ae3357"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("da218660-009f-4249-a8cd-0c4d39f6ed7f"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("dd6e9a79-d132-4092-9c0d-55beeb3a4455"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("e3074c9d-ab43-4f93-b16a-44e2deba4b55"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("e5eae2f4-88d2-4ed8-8575-7a2bcdf1ef18"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("e9753ca5-3c16-44f1-8080-05a44640e2c4"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("ee2504c6-693d-401c-b474-f4d1880ebbbd"));

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: new Guid("fd88f959-3c61-4348-b4c1-680d7bc0e8b5"));

            migrationBuilder.DeleteData(
                table: "modules",
                keyColumn: "id",
                keyValue: new Guid("149a0a87-a0c6-4c8f-8309-07207ec3798b"));

            migrationBuilder.DeleteData(
                table: "modules",
                keyColumn: "id",
                keyValue: new Guid("a2ab6a00-918b-4443-931d-7cc80e3ac3a4"));

            migrationBuilder.DeleteData(
                table: "modules",
                keyColumn: "id",
                keyValue: new Guid("b2000ed8-a372-4848-baff-6ae0d983591c"));

            migrationBuilder.DeleteData(
                table: "subscription_plans",
                keyColumn: "id",
                keyValue: new Guid("e0c4a442-e157-4d46-84f7-a5cc1a3ffd87"));

            migrationBuilder.DeleteData(
                table: "admins",
                keyColumn: "id",
                keyValue: new Guid("344de1e4-c5cc-4c60-aad5-508006dfb6ed"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: new Guid("3164dd2a-6fa2-412d-ae92-256bbd54b553"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("064397b2-22d9-4d4c-88c7-8967381f6376"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("083066ae-76c2-4e9a-85ec-89517c4df628"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("0cf6542b-8d88-40be-bd6c-193237a8277d"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("0eaea012-832a-426c-b207-1d9d3a5cfe65"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("138b44cd-e074-4c3e-9ac6-ce59379f7138"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("1648b9be-0713-461f-923e-326ed771ed4e"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("1b490536-daf8-415d-8af2-73e7e4c94738"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("1eac9ce2-33bc-485a-bddc-4834b529dbc0"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("25593bc9-6849-4e48-b0d5-861ed2b1bfa7"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("34b8d886-3510-49e3-8f9d-5f30433d0329"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("374656ce-5d39-4f10-b2a0-b18733b59d5b"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("3d467700-b50b-4965-81d4-f772d68f5f01"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("3f980e2b-abef-401e-97ac-d2fc95b43271"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("467d2937-e9e5-4dd8-8727-4e9eeb97560a"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("4b8db70c-30bd-4219-97b5-7682f58a19ee"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("4c65bf0f-41c3-4cb2-ac66-5437927fb874"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("4e0a9611-bb9a-4944-a408-80cb836c05db"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("58afc5d0-9d94-48c0-81b1-4399d7c448e6"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5dce78ed-bdd4-4e1a-927d-8ea0037bca0a"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5ff114ba-cfe0-42ba-99ed-531e98147d47"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("616c8716-43d9-46ba-bb46-2be4d6e8132c"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("626edd52-ad1e-478a-a031-072c9de14e73"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("651458aa-aea2-49c4-b5a5-bf7dc0568279"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("668bf2e4-30f7-4143-be67-058d64d68a3b"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("75ea41c8-079c-45fb-9ba8-c9a55931fe88"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("76734a2e-5643-4105-8176-c579a1333790"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("796d9a4c-99aa-4d56-9d52-71b93067b6cc"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("7b660412-b087-4577-8fff-02d7c9c580e5"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("81ca2d3c-b0ad-45ff-804b-b4c375b111fd"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("823759e3-4d2a-4534-90bb-7d99d8649b0a"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("898bd9f9-b4b1-4cf1-81f8-dc49d19ff72a"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("8dc4ccba-7862-4994-bf53-27908b4e60a1"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("9d39252a-283c-4d28-9f93-5090120fcdb9"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("b1d30a3b-fd99-49cd-a5ab-c9856f25090f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("b83bb4e9-6ecf-4fd3-bb42-1b1cd6109cdd"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("bca18a80-d64f-4dfa-bcd0-c037b49bc53a"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("be54b398-e326-4937-a88f-e873913cc7bd"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("c1f29127-91f0-466a-b7e7-d541f4575c53"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("c315b7c9-0098-4cbb-8b2a-23874e4cfa2f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ce7ef1da-fe0f-43b4-9fb5-1ae593b26fb1"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("d549db43-8731-462b-870f-2151d12f4f0f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("d94ca5bb-da78-4ee1-940c-3b67281b1e82"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("da1cb3e2-82b6-41b9-9bee-c0868aa32995"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("da5a1c6f-bcac-45c5-90cf-5030fd95da56"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("e54629cb-8bf0-4fa2-9876-855395b46d46"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("e7299ffe-efa7-411c-8784-c827d6a1743d"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("e7dab215-0513-4320-983f-07127aa24fe0"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ea34a581-79ca-42b1-8aae-e2af24720103"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("eedbe98a-5538-40c8-94ea-422f0897369d"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("f16dbcb4-2dd2-4bcb-afcf-47d5b12934b8"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "id",
                keyValue: new Guid("a3678796-f3fd-4e48-94f3-870b88cdb151"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("d7b8ee4e-ffb6-4563-87a8-26ca31c898a8"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("192fcf7c-c7f8-42fd-a711-c075799483a8"));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "cpf", "created_at", "email", "is_active", "name", "password", "phone" },
                values: new object[,]
                {
                    { new Guid("0a71e436-6fd5-4509-8d00-499d96195b43"), 68992059639.0, new DateTime(2024, 12, 1, 16, 42, 28, 67, DateTimeKind.Local).AddTicks(4565), "Vicente13@hotmail.com", true, "Maria Clara Moreira", "$2a$11$jcA5iQ.YVBBE5dkrNJSVjeEtKnZq6X.5EC6JNXT3.cJjAD60pmGyW", 554277225547.0 },
                    { new Guid("0b51c53c-56d9-47cf-82c5-99c9d0055864"), 65843770400.0, new DateTime(2024, 12, 1, 16, 42, 31, 804, DateTimeKind.Local).AddTicks(5150), "Lucas93@live.com", true, "Manuela Carvalho", "$2a$11$8aLMyipQb2AfN.euz/dDmOTdEBcOs4FXL0BZ07lleJBVZPx/ap8Ia", 550306022305.0 },
                    { new Guid("0d1e3bed-7f12-4fb3-b17d-258e4f04efb8"), 83176347871.0, new DateTime(2024, 12, 1, 16, 42, 27, 716, DateTimeKind.Local).AddTicks(8844), "EnzoGabriel_Martins@yahoo.com", true, "Marina Barros", "$2a$11$a5OkQXiqF94k2rdVMIIile0xQygOJ.attvgzUcmbsrJs4Xfx4AD6a", 554140152703.0 },
                    { new Guid("0ea719fe-2a1e-4c1f-a8a5-0dda317d7a48"), 53329774258.0, new DateTime(2024, 12, 1, 16, 42, 32, 272, DateTimeKind.Local).AddTicks(2850), "Marcia.Carvalho@yahoo.com", true, "Sirineu Macedo", "$2a$11$V7FQ8NLwLamzWYVzoAxrieUgToSrz68bp2kSl5lbAMj2mEW/50eTu", 550554929455.0 },
                    { new Guid("1e63c5bb-4c6b-430f-a329-548a05972181"), 88664747709.0, new DateTime(2024, 12, 1, 16, 42, 27, 249, DateTimeKind.Local).AddTicks(5660), "Rafaela55@bol.com.br", true, "Núbia Xavier", "$2a$11$a/xjlr8KgGwYU2jdiNi59eztaA9obP61UscCiyTvPn4HTlnz9KA2u", 559072604566.0 },
                    { new Guid("207d8b6a-83d3-41fb-ba73-56a41f3b296c"), 24912737305.0, new DateTime(2024, 12, 1, 16, 42, 27, 950, DateTimeKind.Local).AddTicks(5513), "Yango_Macedo55@bol.com.br", true, "Paula Reis", "$2a$11$krqUvocV40JPgHpEUsUIBe6iMG/USdcmfIGgjcmCDmWndxFa./qJ.", 553196285352.0 },
                    { new Guid("2341eaf5-0e88-4dd5-8a03-89f1c841ed80"), 16556013269.0, new DateTime(2024, 12, 1, 16, 42, 30, 986, DateTimeKind.Local).AddTicks(3844), "Victor.Macedo@gmail.com", true, "Pablo Reis", "$2a$11$1mxjduGCDqWtLG3bUURCKu/tuYJrvY.wt.MpHENqdmfHMcsR137TK", 77254651217.0 },
                    { new Guid("2674045d-95a8-47e1-b775-cd694e59c6ad"), 41765518954.0, new DateTime(2024, 12, 1, 16, 42, 30, 402, DateTimeKind.Local).AddTicks(8442), "Pedro.Pereira@bol.com.br", true, "Joaquim Costa", "$2a$11$VEvfQDMSs0WFjpqb991Wy.CJs/SemOf12Cc/gDNyXdblKsStcWYGC", 64336792106.0 },
                    { new Guid("2aed3e01-d23f-4bf5-94bc-08a96f1988a4"), 35028000905.0, new DateTime(2024, 12, 1, 16, 42, 31, 220, DateTimeKind.Local).AddTicks(524), "Deneval.Martins0@bol.com.br", true, "Janaína Silva", "$2a$11$Xw.8qPvJPkXZ4tSrnJjHH.0iRshhKxU.8TVB8BUum4rPldgtta59W", 554615679131.0 },
                    { new Guid("3992a175-8687-49e6-8169-c9e2e6e32bc4"), 24543203046.0, new DateTime(2024, 12, 1, 16, 42, 32, 389, DateTimeKind.Local).AddTicks(1758), "Yango_Moraes@gmail.com", true, "Pablo Souza", "$2a$11$G56AfkHG7gEBfGjytC259OFaTcK8rJHgSPGZn/7kk0tW8sjDE8xJ6", 5922444680.0 },
                    { new Guid("3d1b5b95-1a55-48f8-8cc3-19d1f73a5880"), 5823777221.0, new DateTime(2024, 12, 1, 16, 42, 30, 169, DateTimeKind.Local).AddTicks(5270), "Alexandre_Barros@yahoo.com", true, "Antônio Franco", "$2a$11$xZ421VFv0OQt113RmWcjSuAdRiseppbvJi9kxbQxiNwp7T01JCKb.", 86143824950.0 },
                    { new Guid("44207249-caa2-4d61-badb-46ad98a377f8"), 32944549618.0, new DateTime(2024, 12, 1, 16, 42, 29, 702, DateTimeKind.Local).AddTicks(1949), "Mariana64@gmail.com", true, "Fabiano Costa", "$2a$11$S76lvTp91zE0JKzUT.6Gw.Vbn1IcXf6GJR61PeUnRmztZM45vUiQ.", 7747736981.0 },
                    { new Guid("4d9daeb8-b51b-4a65-b15f-812f972b8bf1"), 74165807303.0, new DateTime(2024, 12, 1, 16, 42, 32, 38, DateTimeKind.Local).AddTicks(4353), "Marcia_Reis@live.com", true, "Melissa Carvalho", "$2a$11$bV9TwBOC1m5QIj7eGKRpP.NXp8aBNCoJ88fdnyR3RH5jGSSpC0vG6", 96024423524.0 },
                    { new Guid("509e9dcd-eb75-4a41-9924-a972ea8abccd"), 11617287750.0, new DateTime(2024, 12, 1, 16, 42, 32, 155, DateTimeKind.Local).AddTicks(3112), "Marcos_Costa86@live.com", true, "Isabel Xavier", "$2a$11$59HsybSll4XFyVkq3s9ZcO6E0l5fIrWmaQC3TfSXrOtmaDj0Mt4DK", 4231145703.0 },
                    { new Guid("57904966-89d1-486c-bab1-49a46900d720"), 43711892299.0, new DateTime(2024, 12, 1, 16, 42, 32, 739, DateTimeKind.Local).AddTicks(8715), "Lorena.Batista87@gmail.com", true, "Miguel Xavier", "$2a$11$IEAVuBCdMOfQZbHUWbb77.lyHtXOvseKywva.s7qgUevH2X0K0iGu", 554942321698.0 },
                    { new Guid("5c8eb36f-04ee-44a1-8c8d-ee268f835c9e"), 28177311581.0, new DateTime(2024, 12, 1, 16, 42, 31, 103, DateTimeKind.Local).AddTicks(3023), "Miguel55@yahoo.com", true, "Ana Júlia Macedo", "$2a$11$rXvvU41ucqPNvxqko282l.uGenPbvOLsn8FQ2d5GMpIWKwTfMz36S", 3086953701.0 },
                    { new Guid("5cd134c8-306a-45ba-be55-01b433b6058e"), 47066345800.0, new DateTime(2024, 12, 1, 16, 42, 29, 819, DateTimeKind.Local).AddTicks(2211), "Feliciano.Oliveira@live.com", true, "Júlio Xavier", "$2a$11$h3DnFHQocl3AGzdVQqrb3uAGNe2tACekjBUUkUaQKt1F2b5QyY6Bq", 4082962907.0 },
                    { new Guid("665ceb2e-e0bd-4a42-9ebd-2a1d377de1e8"), 77840471269.0, new DateTime(2024, 12, 1, 16, 42, 30, 869, DateTimeKind.Local).AddTicks(7072), "Valentina22@yahoo.com", true, "Benjamin Melo", "$2a$11$3rRyNU/GX9Q/Tp5LABFWEOB.ixwi/faEd1CWSMZlDsAuPyAzPsVPW", 6762630300.0 },
                    { new Guid("6b4a3857-21ae-4382-989f-bce56e2fd635"), 25246242340.0, new DateTime(2024, 12, 1, 16, 42, 27, 366, DateTimeKind.Local).AddTicks(3362), "Gabriel33@hotmail.com", true, "Maria Júlia Melo", "$2a$11$ZiLXhqy34TEX9KN1rdJdauTxy4v8ONzWovOGYz9iRwwVbWpun4MfK", 83975844987.0 },
                    { new Guid("6c929e3a-45f8-4255-9cd7-2f71163274b1"), 95453147024.0, new DateTime(2024, 12, 1, 16, 42, 30, 53, DateTimeKind.Local).AddTicks(718), "Victor_Costa@live.com", true, "Carlos Moreira", "$2a$11$ePJOGkqzy4NKI8hk5OVHM.xS6zMLhIVWjx81bYpAR.mSDqq2rhN8O", 10099960709.0 },
                    { new Guid("71ced500-0ddd-47e0-a18a-edb64193c6f4"), 11471642232.0, new DateTime(2024, 12, 1, 16, 42, 28, 300, DateTimeKind.Local).AddTicks(9099), "Margarida_Albuquerque@hotmail.com", true, "Maria Cecília Melo", "$2a$11$WfvndI.jIz7KA5bl1eeG.eJVmZzXFmcEfUjiCwZgXE.hNfK1CW6z2", 6440490666.0 },
                    { new Guid("778c6ffe-f19e-413e-bd82-237a14fde56c"), 50664101984.0, new DateTime(2024, 12, 1, 16, 42, 31, 687, DateTimeKind.Local).AddTicks(5230), "Yango.Melo74@yahoo.com", true, "Yasmin Xavier", "$2a$11$NaNNQJFc/5QYR4Wt0OlHnO2.98vKwgKBWWmD2rhPIXRf3poTNE2Ky", 555880795542.0 },
                    { new Guid("7f6949a0-9654-4317-9936-52a356027cda"), 88182860482.0, new DateTime(2024, 12, 1, 16, 42, 31, 570, DateTimeKind.Local).AddTicks(6191), "Gustavo12@live.com", true, "Caio Macedo", "$2a$11$9espIl.u/PAoQB.5EpzYHezlrvY/05SP83H/rINNUgmXxQ.3JRykG", 8864673419.0 },
                    { new Guid("8047a626-9071-45a8-b6e3-dfaef9793fd3"), 84575359602.0, new DateTime(2024, 12, 1, 16, 42, 27, 132, DateTimeKind.Local).AddTicks(6950), "Isabelly35@live.com", true, "Calebe Xavier", "$2a$11$DT9Y7NF2USMADBtjsbv5u.ApeXzIQDRHy2JzC3hE860CbBEwWPNXy", 552005451482.0 },
                    { new Guid("820ecd5d-58de-47e0-8d1f-ae4c7f369e49"), 64368796845.0, new DateTime(2024, 12, 1, 16, 42, 32, 856, DateTimeKind.Local).AddTicks(7711), "Gael.Silva18@bol.com.br", true, "Rafael Pereira", "$2a$11$HENxzT4nEJ8Lrc//I3RkY.XT6SMf1Rm2PWvpUvmwtqNCUpANlZFmK", 8230755942.0 },
                    { new Guid("862dc151-bb7f-4238-861d-982abe141267"), 69807096405.0, new DateTime(2024, 12, 1, 16, 42, 28, 767, DateTimeKind.Local).AddTicks(7395), "Lara16@yahoo.com", true, "Isabel Silva", "$2a$11$Uv7AZ.JNCz9r62wRrSEuo.GmCJ/UKTuAuNM70U4HGqe1XKkfDq7h.", 554093009603.0 },
                    { new Guid("89dca35e-c6e3-4641-9523-97b9af93e55f"), 91446342859.0, new DateTime(2024, 12, 1, 16, 42, 30, 519, DateTimeKind.Local).AddTicks(4396), "Bernardo.Souza19@yahoo.com", true, "Lorenzo Martins", "$2a$11$FVsPVn2MJO5jK.Sf.GI/c.RqUdNzwYmLsGaD/DM1rcD5SVFBjzK6W", 4110398027.0 },
                    { new Guid("96a812db-e993-41a9-bf56-5381c52f331c"), 30891960007.0, new DateTime(2024, 12, 1, 16, 42, 31, 453, DateTimeKind.Local).AddTicks(5981), "Karla95@bol.com.br", true, "Raul Saraiva", "$2a$11$6heFFYCnbvVVVE1O027vluko8qaN6FT61MIDVZ11n1qDK7jfQFEZm", 34595791915.0 },
                    { new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7"), 123456789.0, new DateTime(2024, 12, 1, 16, 42, 32, 973, DateTimeKind.Local).AddTicks(5464), "admin@admin", true, "Admin", "$2a$11$HbtbTsfgeqrl7MSrrK4sx.3xMMdvy0HWEA.JIwrFzv.bhYYSXfrbm", 123456789.0 },
                    { new Guid("9b2b5ee5-72f4-492d-bda2-52018e4d7935"), 24574521716.0, new DateTime(2024, 12, 1, 16, 42, 30, 286, DateTimeKind.Local).AddTicks(682), "Fabiano.Carvalho0@bol.com.br", true, "Hélio Moreira", "$2a$11$aZAWF.6H.SAUqnS.s0rbn.xWhUNMncwoitJGVQpC6qv86RI5cimlq", 6101673171.0 },
                    { new Guid("9e1d0cf8-9669-418d-b739-ade5dc09d0fb"), 23511160383.0, new DateTime(2024, 12, 1, 16, 42, 28, 417, DateTimeKind.Local).AddTicks(6673), "Alessandra28@bol.com.br", true, "Anthony Carvalho", "$2a$11$h2IOSCVulmeyUxPuzgpORubMnNGnySsX0mgclMC3p8RdWjHEXQv/2", 554317811909.0 },
                    { new Guid("9e65a702-42dc-4087-98e2-b2eb4e77d8e6"), 34949893890.0, new DateTime(2024, 12, 1, 16, 42, 28, 534, DateTimeKind.Local).AddTicks(3505), "JoaoPedro43@hotmail.com", true, "Emanuelly Barros", "$2a$11$00bMC7lU9z6iNbd4YtI/6ud9/ahM3eqxJdBWDgqNBiNs50LLDANfy", 555637357120.0 },
                    { new Guid("9fd123a8-12b4-4a90-92d8-c92e39ea187a"), 9558200735.0, new DateTime(2024, 12, 1, 16, 42, 28, 651, DateTimeKind.Local).AddTicks(695), "Salvador.Moreira@bol.com.br", true, "Théo Souza", "$2a$11$fAXQSh72MJlSSoeH0bbB1.TluiL71/XrYCiKpCzgd5WkYb1CEr/Da", 6429832070.0 },
                    { new Guid("aef9cddc-92ca-4beb-97a3-a3c71dcf55fc"), 63238692410.0, new DateTime(2024, 12, 1, 16, 42, 32, 506, DateTimeKind.Local).AddTicks(401), "Alessandra_Melo@gmail.com", true, "Arthur Saraiva", "$2a$11$GUSKCR1RWD/YSy3KN5aFEuTsuVTrUwQSItNHcICTCxD1GQxc0ZWF6", 1299898453.0 },
                    { new Guid("b03fb69a-f0b1-4942-a8b1-6cf94e5ccfa0"), 48033963700.0, new DateTime(2024, 12, 1, 16, 42, 30, 752, DateTimeKind.Local).AddTicks(9653), "Daniel.Souza44@bol.com.br", true, "Natália Batista", "$2a$11$/2NxGavla2Fn7FnLkpQTo.wHgWeM4jKZH9rXlUH6X1s225Pebf2ni", 552872657866.0 },
                    { new Guid("b1666ea4-b8f4-40be-8830-35defa6699e0"), 20634654101.0, new DateTime(2024, 12, 1, 16, 42, 28, 184, DateTimeKind.Local).AddTicks(2566), "Talita97@yahoo.com", true, "Fabiano Saraiva", "$2a$11$6LbMkzF62sfHPJyeTGL00uMyokYfXZqbWd/i/oWw7RSpYAkryVyre", 554836585845.0 },
                    { new Guid("b74bb4e6-6b8b-47f8-8eae-535c04a52b0f"), 94185282079.0, new DateTime(2024, 12, 1, 16, 42, 28, 884, DateTimeKind.Local).AddTicks(3143), "Pietro.Franco58@yahoo.com", true, "Lorraine Melo", "$2a$11$2Ql8gpa0QR8S7dgWoRR.2.dqWMP11JZxHCAJvxaDNOKQp1HKrsWY6", 66479179975.0 },
                    { new Guid("ba2440fc-712e-44b6-b96c-237e54b2712f"), 1009149342.0, new DateTime(2024, 12, 1, 16, 42, 29, 0, DateTimeKind.Local).AddTicks(9808), "Pietro_Macedo91@hotmail.com", true, "Emanuel Saraiva", "$2a$11$X4HuDkiHz299poDKF751bOHZFea2SkV32yq2FN.P91s3kNZRMlw5W", 47367938380.0 },
                    { new Guid("bc477eb2-e9ef-403a-b2e7-a37a10504bf1"), 50823145050.0, new DateTime(2024, 12, 1, 16, 42, 31, 336, DateTimeKind.Local).AddTicks(7543), "JoaoMiguel_Braga@yahoo.com", true, "Isabela Moreira", "$2a$11$x90xcBsLNIRimIOLucs/1OiZuf.JY/mg18.RJ1A8XcNvT4wxizDVS", 5327819362.0 },
                    { new Guid("cdaf0fe3-bac1-4313-b53d-a2d9dd5ea5dc"), 123456789.0, new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(2797), "professor@preofessor.com", true, "instrutor 1", "$2a$11$.gCgrYNkLi0H11cIPx.Pauk5wL2xHCxaK3zUwbBgO73QbVSb0wGFa", 123456789.0 },
                    { new Guid("cf09ff0c-08ab-493a-8841-1d4edf58d5f7"), 53869367008.0, new DateTime(2024, 12, 1, 16, 42, 29, 468, DateTimeKind.Local).AddTicks(3332), "Salvador83@bol.com.br", true, "Maria Cecília Pereira", "$2a$11$/j5/0crH2O2A2cNSGWaDV.lb0osVWEN4D2y1Bxv2ZrBLFnwKAUxMm", 558839547138.0 },
                    { new Guid("d0111fdb-9db8-40ce-b0b2-5e4bcbfeb575"), 70884363708.0, new DateTime(2024, 12, 1, 16, 42, 29, 351, DateTimeKind.Local).AddTicks(2838), "Natalia_Moreira@live.com", true, "Elísio Martins", "$2a$11$.rY3TNjZY3Lj2FFCpBDRGOofB2Gqz66VpKjJkGU/88t.yQNYv3F8.", 63977318702.0 },
                    { new Guid("dec3f32d-75b2-4390-82c9-09e39ea7d606"), 32400760390.0, new DateTime(2024, 12, 1, 16, 42, 27, 483, DateTimeKind.Local).AddTicks(2084), "Marli_Nogueira@hotmail.com", true, "Fábio Costa", "$2a$11$aeYqgCI5T6wD6/wUoEJYi.Fkpdz0i5R3MH713w57NrYV8a0CMuVM6", 3678626715.0 },
                    { new Guid("e1818a1c-d026-47f2-af7d-6784537a3b66"), 77217948894.0, new DateTime(2024, 12, 1, 16, 42, 29, 117, DateTimeKind.Local).AddTicks(6518), "Nataniel.Pereira55@live.com", true, "Murilo Melo", "$2a$11$eRLPpGlRCkIKeXBpTQ11QuKkS6mBezAW6VC4C/drm0HhvxV9/YW/O", 554083485513.0 },
                    { new Guid("e4473b1f-6857-46cc-8c74-2f04322e6733"), 16953451424.0, new DateTime(2024, 12, 1, 16, 42, 27, 833, DateTimeKind.Local).AddTicks(7277), "Isabel.Moreira13@bol.com.br", true, "Elísio Silva", "$2a$11$iUUEOfQFveb7fng1z3.FE.1Ws.kBWViQgo9/CuWfm5JH2IAAcFsES", 559635616884.0 },
                    { new Guid("edf3cfe0-9c03-44c4-a389-ddd91ff43ff4"), 24886830196.0, new DateTime(2024, 12, 1, 16, 42, 29, 585, DateTimeKind.Local).AddTicks(2952), "Gael_Barros45@bol.com.br", true, "Deneval Souza", "$2a$11$o5sEB3ItlATUoCKOUbAvMOpg6vyBogho3CWS3/oga.3dvCdZwTOYa", 85526518810.0 },
                    { new Guid("f01a531c-da6c-4c3f-9f9b-2850728d79bd"), 81800540124.0, new DateTime(2024, 12, 1, 16, 42, 29, 234, DateTimeKind.Local).AddTicks(5008), "Felix.Oliveira99@yahoo.com", true, "Melissa Macedo", "$2a$11$O/ZPshucyPv063VlDOhst.Jjwpi7HbBPg.bi20Jl8ce7uSudpxnN2", 78893213054.0 },
                    { new Guid("f6b60f73-b232-4a0e-aad1-bf4eed87d352"), 96587283918.0, new DateTime(2024, 12, 1, 16, 42, 29, 936, DateTimeKind.Local).AddTicks(2269), "MariaClara8@bol.com.br", true, "Vicente Silva", "$2a$11$obQJJzyq/5cqzhbQj/qw7O4/wmy0VOdjynY.u44mchnYUtrIrPnI.", 7624153742.0 },
                    { new Guid("f8c61400-d1c8-49e3-9e87-7b5d3a53d4a7"), 11339439182.0, new DateTime(2024, 12, 1, 16, 42, 27, 599, DateTimeKind.Local).AddTicks(8347), "Isis.Reis11@hotmail.com", true, "Marcos Batista", "$2a$11$CRXjf5bxkMZ3WuVpt/Ys6eoMCtccOxJDB6VNFm2IT2NM9orluJcfa", 20315579288.0 },
                    { new Guid("faa1390d-ae63-451e-b94a-9341c87cef11"), 2009485203.0, new DateTime(2024, 12, 1, 16, 42, 30, 636, DateTimeKind.Local).AddTicks(1127), "Elisa_Nogueira@gmail.com", true, "Rebeca Carvalho", "$2a$11$2xkihNUFaWoOjhdi.e93nuVD3eL2IfuZe0j/6GlPHYDymRTAyASAC", 8465753574.0 },
                    { new Guid("fc20f29a-4655-4922-bd15-4f1f490875b3"), 35309343997.0, new DateTime(2024, 12, 1, 16, 42, 31, 921, DateTimeKind.Local).AddTicks(3556), "Felicia.Pereira4@live.com", true, "Valentina Reis", "$2a$11$My4jHYVRzbJg.WKCxAq/p.u9V.qS/pkDNZuzQ3CRmg/cWi4PKWND.", 555092271032.0 },
                    { new Guid("fdcc8502-12fd-458c-be02-c4e484b9dd0f"), 68378830039.0, new DateTime(2024, 12, 1, 16, 42, 32, 622, DateTimeKind.Local).AddTicks(9182), "Igor44@bol.com.br", true, "Melissa Moraes", "$2a$11$McXFcv2l3KFf3tJ7qBDdxeLAiwy4SUpoVw.RulER2QKyeoW0dkdU6", 558566916425.0 }
                });

            migrationBuilder.InsertData(
                table: "admins",
                columns: new[] { "id", "user_id" },
                values: new object[] { new Guid("8c0e2162-1b8f-44f3-a94a-8f000587e335"), new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7") });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "name", "user_id" },
                values: new object[,]
                {
                    { new Guid("0a9b1bfa-8786-4380-b432-236b2713d83b"), "Java", new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7") },
                    { new Guid("2509ec8d-894a-4bd7-b589-f5cf51b182ea"), "PHP", new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7") },
                    { new Guid("2dc6b4d6-da39-4361-b59f-733a2d6e6e88"), "Js", new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7") },
                    { new Guid("35ac4204-fe64-47c9-a95e-24ea4bd0af0e"), "F#", new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7") },
                    { new Guid("3832821e-62a6-4d2a-9678-a7a1daaae782"), "c", new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7") },
                    { new Guid("41c0c9b0-0f2e-44c7-b898-03081ca816c9"), "MySql", new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7") },
                    { new Guid("71437401-01dc-4c1a-91e2-249b7cc288e3"), "c#", new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7") },
                    { new Guid("d1744b79-1801-4704-9c48-26832fa10926"), "Typescript", new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7") },
                    { new Guid("d445ba32-5a2e-46af-8097-d2eccafb0b12"), "SQL", new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7") },
                    { new Guid("e0c19352-2902-44ee-969a-ee2f5034c252"), "Rust", new Guid("98a61ecc-b0d2-4e46-912f-ad33241b5aa7") }
                });

            migrationBuilder.InsertData(
                table: "clients",
                columns: new[] { "id", "subscriptionplanid", "user_id" },
                values: new object[,]
                {
                    { new Guid("0080b621-4c02-4c6c-8fe0-47c4037a6ceb"), null, new Guid("0a71e436-6fd5-4509-8d00-499d96195b43") },
                    { new Guid("0c448140-80eb-4603-b70b-f9df17e34532"), null, new Guid("5cd134c8-306a-45ba-be55-01b433b6058e") },
                    { new Guid("13f75d9d-55d7-49d8-bd92-623dcfad435d"), null, new Guid("207d8b6a-83d3-41fb-ba73-56a41f3b296c") },
                    { new Guid("15df39b0-4cc9-4b85-984e-556f24bec4c7"), null, new Guid("0ea719fe-2a1e-4c1f-a8a5-0dda317d7a48") },
                    { new Guid("1cf55ba7-f8d3-4a23-a207-409ad11b9569"), null, new Guid("2aed3e01-d23f-4bf5-94bc-08a96f1988a4") },
                    { new Guid("226188f3-9384-415d-80fb-b3aad97e3f29"), null, new Guid("fc20f29a-4655-4922-bd15-4f1f490875b3") },
                    { new Guid("259e5b80-5fc4-4ce9-90b6-80b1151018f2"), null, new Guid("96a812db-e993-41a9-bf56-5381c52f331c") },
                    { new Guid("2623fff3-e4f2-4b16-8c53-43e8d439e3a3"), null, new Guid("b1666ea4-b8f4-40be-8830-35defa6699e0") },
                    { new Guid("2e234351-7f87-49d3-9462-86a58f83f675"), null, new Guid("71ced500-0ddd-47e0-a18a-edb64193c6f4") },
                    { new Guid("318f1742-dada-4215-9ed3-22bab51ab8f6"), null, new Guid("e4473b1f-6857-46cc-8c74-2f04322e6733") },
                    { new Guid("34ee8734-28a0-49f9-989a-afe5d1c88c7f"), null, new Guid("3d1b5b95-1a55-48f8-8cc3-19d1f73a5880") },
                    { new Guid("39e9aef6-64d1-4dd3-ac03-ef4d881ae833"), null, new Guid("2674045d-95a8-47e1-b775-cd694e59c6ad") },
                    { new Guid("3b2773fc-d8a4-4499-a277-4fa5d15f7ec1"), null, new Guid("b03fb69a-f0b1-4942-a8b1-6cf94e5ccfa0") },
                    { new Guid("3bc9aead-3609-46be-a4e1-5904790ffc94"), null, new Guid("faa1390d-ae63-451e-b94a-9341c87cef11") },
                    { new Guid("4834a7fb-3877-46c0-b7ce-b955a8e9ca01"), null, new Guid("4d9daeb8-b51b-4a65-b15f-812f972b8bf1") },
                    { new Guid("5689ab59-a8a6-48f0-86b1-d596588aebc2"), null, new Guid("fdcc8502-12fd-458c-be02-c4e484b9dd0f") },
                    { new Guid("604b4b52-c9c5-4097-af1d-417b471e3bbe"), null, new Guid("f6b60f73-b232-4a0e-aad1-bf4eed87d352") },
                    { new Guid("6569cf25-6b29-4022-a698-6d5454e99601"), null, new Guid("778c6ffe-f19e-413e-bd82-237a14fde56c") },
                    { new Guid("6eb8cd3b-b62e-4d03-b2a6-12d961f68996"), null, new Guid("9b2b5ee5-72f4-492d-bda2-52018e4d7935") },
                    { new Guid("7bd3528b-e8e6-4c76-b454-26554757bd0d"), null, new Guid("edf3cfe0-9c03-44c4-a389-ddd91ff43ff4") },
                    { new Guid("7e17451a-f1a7-4867-8eef-513ec8d9247a"), null, new Guid("3992a175-8687-49e6-8169-c9e2e6e32bc4") },
                    { new Guid("7e25fd11-5c96-4923-8452-4dbaf423f65d"), null, new Guid("ba2440fc-712e-44b6-b96c-237e54b2712f") },
                    { new Guid("8ba972ba-e2a3-4061-8464-812f103f77e2"), null, new Guid("509e9dcd-eb75-4a41-9924-a972ea8abccd") },
                    { new Guid("8edcb7b7-d0d7-4cb9-b748-97549ac0d644"), null, new Guid("aef9cddc-92ca-4beb-97a3-a3c71dcf55fc") },
                    { new Guid("8fb2bad1-2bd6-4510-b6c3-fbcaf6bd6598"), null, new Guid("44207249-caa2-4d61-badb-46ad98a377f8") },
                    { new Guid("91f14f7f-45ed-4009-8781-e2c7d09a97ef"), null, new Guid("5c8eb36f-04ee-44a1-8c8d-ee268f835c9e") },
                    { new Guid("930b853e-54ff-49d4-b24a-e120ee7bcafa"), null, new Guid("d0111fdb-9db8-40ce-b0b2-5e4bcbfeb575") },
                    { new Guid("9457a1b3-e988-4f04-be2b-91c6546e7adc"), null, new Guid("1e63c5bb-4c6b-430f-a329-548a05972181") },
                    { new Guid("966c3dfa-4579-477c-a40a-8eafa5a9b653"), null, new Guid("9e65a702-42dc-4087-98e2-b2eb4e77d8e6") },
                    { new Guid("97768b8f-30c8-4cda-8d2c-20316c5348fc"), null, new Guid("9e1d0cf8-9669-418d-b739-ade5dc09d0fb") },
                    { new Guid("9f18c287-d3c7-444c-bc16-44858779cfa9"), null, new Guid("9fd123a8-12b4-4a90-92d8-c92e39ea187a") },
                    { new Guid("a7e93cfb-5fb2-4aa6-90e1-73b39a5dfe7a"), null, new Guid("f01a531c-da6c-4c3f-9f9b-2850728d79bd") },
                    { new Guid("b174fc0f-14cf-42a9-a466-04e30128f65c"), null, new Guid("2341eaf5-0e88-4dd5-8a03-89f1c841ed80") },
                    { new Guid("b4d8a8f0-2d5b-42be-8094-e5630e4f98e5"), null, new Guid("0b51c53c-56d9-47cf-82c5-99c9d0055864") },
                    { new Guid("bcaf4dff-dc2c-4277-8adf-b4b0745f3515"), null, new Guid("6b4a3857-21ae-4382-989f-bce56e2fd635") },
                    { new Guid("c0a688c7-07e4-42f1-af4b-5020671abec6"), null, new Guid("57904966-89d1-486c-bab1-49a46900d720") },
                    { new Guid("c3baac2a-95e6-4f07-9360-f2ad44f1971a"), null, new Guid("0d1e3bed-7f12-4fb3-b17d-258e4f04efb8") },
                    { new Guid("c42149f0-6cb0-4b10-93c5-e82b0ae91642"), null, new Guid("820ecd5d-58de-47e0-8d1f-ae4c7f369e49") },
                    { new Guid("cda26145-2357-432e-9d85-b5714ec60f60"), null, new Guid("8047a626-9071-45a8-b6e3-dfaef9793fd3") },
                    { new Guid("d247cf23-016c-492e-8ee3-a4e7438caf88"), null, new Guid("7f6949a0-9654-4317-9936-52a356027cda") },
                    { new Guid("d9d1e411-bb83-497f-adfc-49eebd8b992e"), null, new Guid("bc477eb2-e9ef-403a-b2e7-a37a10504bf1") },
                    { new Guid("e0e3a5fb-48c5-43d1-8a0e-31348d7f1bae"), null, new Guid("6c929e3a-45f8-4255-9cd7-2f71163274b1") },
                    { new Guid("e1e640ea-1028-4d9b-8092-abb73745cd89"), null, new Guid("f8c61400-d1c8-49e3-9e87-7b5d3a53d4a7") },
                    { new Guid("e3ffe204-ba7f-4163-bdd6-aba943f38a3e"), null, new Guid("dec3f32d-75b2-4390-82c9-09e39ea7d606") },
                    { new Guid("e8b4f59f-426d-4470-8d62-c4eaf0d840db"), null, new Guid("89dca35e-c6e3-4641-9523-97b9af93e55f") },
                    { new Guid("eb1e666f-e9cf-412e-b105-c9d31d45d0e5"), null, new Guid("b74bb4e6-6b8b-47f8-8eae-535c04a52b0f") },
                    { new Guid("ecc36acf-5565-4887-9bec-33c02c09cab1"), null, new Guid("862dc151-bb7f-4238-861d-982abe141267") },
                    { new Guid("ed65540e-8614-40c0-800d-b60be05b5f21"), null, new Guid("cf09ff0c-08ab-493a-8841-1d4edf58d5f7") },
                    { new Guid("f10bcee3-251e-4c5c-abac-0c70f7d8609c"), null, new Guid("665ceb2e-e0bd-4a42-9ebd-2a1d377de1e8") },
                    { new Guid("f7084b48-0238-46fc-8ad6-7868be7fa721"), null, new Guid("e1818a1c-d026-47f2-af7d-6784537a3b66") }
                });

            migrationBuilder.InsertData(
                table: "instructors",
                columns: new[] { "id", "github", "social_network", "user_id" },
                values: new object[] { new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), null, null, new Guid("cdaf0fe3-bac1-4313-b53d-a2d9dd5ea5dc") });

            migrationBuilder.InsertData(
                table: "blog_posts",
                columns: new[] { "id", "acesses", "created_at", "instructor_id", "text", "thumb", "title" },
                values: new object[,]
                {
                    { new Guid("03113096-7277-16d7-1236-e3b72b1a5c2c"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(5903), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Possimus quisquam perspiciatis eaque laudantium deserunt sequi velit sequi. Autem omnis quasi autem atque. Ex velit velit similique eos dolorem animi cum dolor aut. Adipisci dignissimos sint repudiandae non quo ipsam.\n\nEnim molestiae deserunt illo distinctio quod cumque ratione veritatis optio. Consequatur aliquam et aspernatur iusto voluptatum impedit dolores. Sed nulla et sequi consequatur quidem modi distinctio consequatur sunt. Dignissimos dolorem delectus aut cumque eaque voluptatibus. Enim voluptas maxime vel aut quisquam maxime. Adipisci commodi rerum ratione quos temporibus.\n\nQuia temporibus omnis modi et iure dolor repellendus. Repudiandae quasi id reprehenderit porro rerum sed. Alias excepturi saepe est earum illum optio voluptatem voluptas aut. Debitis tenetur est quis dignissimos qui quia consectetur. Consectetur nesciunt omnis est. Possimus qui tempore iusto praesentium.", null, "Intranet" },
                    { new Guid("04617aa2-b625-3e11-3298-2c07d93cac72"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(6196), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Labore eligendi non repellat. Doloribus eaque et optio iste exercitationem officiis deserunt. Vel est quam quam velit explicabo.\n\nDistinctio sed laborum praesentium aperiam non. Dolor dolor et officia voluptatem minus est dignissimos. Inventore nostrum praesentium. Aut alias corporis ratione in. Cupiditate blanditiis odit esse. Ducimus et aperiam est aspernatur.\n\nHic est quam aspernatur fugiat et totam voluptatum nostrum. Laudantium quos est ad unde blanditiis fugit voluptate. Ut omnis quos.", null, "Web" },
                    { new Guid("12c23c11-5136-34c0-07c5-9bf5b97fe0e1"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(8875), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Cupiditate amet consequatur libero. Eum est beatae aliquam facilis quia sapiente libero. Autem qui omnis iusto quas nihil. Unde eveniet dolore asperiores. Quod quaerat et.\n\nNesciunt et porro non. Qui vel quia recusandae labore veniam ad occaecati fuga. Eveniet voluptate omnis. Alias reprehenderit asperiores dolorum sunt officia ab enim molestias. Ipsa quaerat iusto saepe debitis.\n\nQuia sit perspiciatis asperiores molestiae distinctio quis. Voluptatum nesciunt blanditiis ratione et facilis nemo sed. Assumenda quaerat nesciunt tempore odit sed mollitia et delectus. Perferendis reprehenderit facere quia nihil voluptate a aut quibusdam. Adipisci inventore occaecati est illo minima. Delectus odit velit.", null, "Operations" },
                    { new Guid("16ac12a2-cde3-550d-e707-ac7dc24d3dc1"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(7802), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Fuga nihil excepturi ipsum alias. Doloribus odio a aut quasi fugiat explicabo aspernatur eius nisi. Iusto qui nostrum itaque dicta. Modi et illo nostrum est quia. Fuga occaecati ducimus voluptatum voluptatum minus consequatur optio consequatur.\n\nEst id et vero quia. Rerum tempora omnis et. Cum sed illum sunt. Et ullam sed maiores excepturi corrupti quia. Vero ducimus assumenda fugiat repellat deleniti iste et repudiandae.\n\nSit ut minus sint. Magni nobis velit. Aut libero eum fuga quia fugit ut omnis. Et enim dolorem. Quia quam ex dolores non ut voluptatem nesciunt quis. Libero accusantium illum quae.", null, "Response" },
                    { new Guid("25e947bf-8cfe-8c55-0e09-88d29c945e3a"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(7009), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Id aut non. Explicabo fuga corporis ducimus temporibus est rerum provident expedita quae. Ut deleniti dolore non molestiae aut ut aut aut hic.\n\nSed facere mollitia explicabo ea occaecati quo veritatis odit magnam. Dolores veniam vel ipsam recusandae. Ut reiciendis quis rem. Quaerat magnam voluptas. Mollitia sint quis. Voluptatum ad voluptatibus.\n\nEst qui et. Modi occaecati iste tempore est ea animi est. Aperiam fugiat error deserunt delectus accusantium.", null, "Brand" },
                    { new Guid("27aacc87-7332-9380-af14-bfd9c25abc05"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(9358), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Repellendus fugiat quae est qui perspiciatis voluptas. Officia soluta ducimus. Sit ad repellendus autem eius molestiae.\n\nAut nemo quibusdam doloribus blanditiis aspernatur placeat esse sunt assumenda. Magnam veritatis quidem. Dignissimos quaerat rerum soluta at cumque nam assumenda. Expedita unde cupiditate numquam placeat temporibus aperiam.\n\nEa inventore vel quis possimus accusamus perspiciatis laborum omnis et. Eos est distinctio unde nesciunt dicta est repellat omnis. Quos incidunt est voluptas soluta omnis quaerat alias.", null, "Division" },
                    { new Guid("2bb683ce-b44b-64b3-3d0e-4c5545684f4b"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 93, DateTimeKind.Local).AddTicks(785), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Placeat laboriosam quia quos vitae libero magnam excepturi reprehenderit. Et sapiente iste explicabo asperiores laborum placeat architecto qui. Exercitationem quo libero ut facilis.\n\nCum libero cumque quaerat quis harum. Ea suscipit recusandae provident distinctio quibusdam ratione fuga aliquid rerum. Ut ipsum vero rerum maxime et veniam. Cupiditate eum velit velit ullam et harum et mollitia. Quasi debitis ex omnis.\n\nEarum nemo pariatur sed commodi consequatur eaque autem officia. Alias quia quas. Sint neque et. Ipsa assumenda est at id id accusamus nihil odio.", null, "Solutions" },
                    { new Guid("3b9374c5-ea43-df4f-c651-928e277f9e10"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 93, DateTimeKind.Local).AddTicks(120), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Ipsum debitis ea. Aut deserunt accusamus unde aut vitae. Non iusto iste dolorum. Laudantium architecto voluptates quia ipsa ea. Unde hic autem autem.\n\nDelectus deserunt ea occaecati. Et aut autem doloribus enim velit sint optio aut. Id magnam accusamus ipsa rerum aliquid est.\n\nIllo at possimus aliquam et sint labore. Aliquid provident hic dolore placeat corrupti. Sit unde recusandae quasi animi ducimus. Asperiores assumenda dolorem nemo laboriosam sint officia. Fuga quis sunt.", null, "Implementation" },
                    { new Guid("3bcef47a-827b-5210-3ce3-1cbd0da9f804"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(8403), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Dolore odit non nulla id fugiat quas consequatur voluptas. Commodi neque ducimus eaque deleniti. Exercitationem et doloribus dolores nihil eligendi perspiciatis soluta eveniet. Eligendi nostrum qui. In quas est vero.\n\nAb voluptatem aut ut aperiam iste in reiciendis sint. Illo ut aspernatur ipsa ut aspernatur non. Voluptatum natus ut. Est nemo quaerat dolorem qui. Et blanditiis qui. Adipisci eum sit ab ducimus ut.\n\nUt et est alias vel dolor. Odit aut a vitae iure. Quis pariatur quasi architecto iure dolorem quia. Hic aut adipisci asperiores quod delectus et. Tempora illum magnam est sint iste esse ipsum est.", null, "Quality" },
                    { new Guid("44deeef2-1e5a-313a-269e-1c9a0be121af"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(6769), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Aut neque accusamus cum quos dolorem id ut qui aut. Voluptas molestias quia minus ut vel sed esse. Qui impedit iure numquam adipisci. Rerum accusantium voluptas et nulla et blanditiis est. Non sit ratione voluptas praesentium labore aut esse dolor voluptatem.\n\nDolores voluptas quo placeat velit inventore porro est enim nihil. Deserunt et occaecati natus dolor fugiat eos nisi et praesentium. Cupiditate et sed aut nesciunt omnis.\n\nOfficiis a quidem. Cupiditate rerum omnis quia eligendi occaecati esse quam ea adipisci. Vel ipsa perspiciatis blanditiis. Quia sequi minus vitae laudantium iusto et adipisci. Provident optio quo quibusdam assumenda hic officia. Sint id aspernatur vel.", null, "Quality" },
                    { new Guid("5c21f354-1859-210f-4fd1-164d00edb175"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(9113), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Quas et vel aut numquam sit commodi laboriosam. Facere aperiam sed doloribus quasi mollitia. Velit accusamus autem et quia. Autem doloremque non ut enim enim qui placeat quam dolores.\n\nDolorem a esse incidunt sed iure aut autem aliquam. Officiis ad ab quia quisquam facere beatae neque minus totam. Minus et dolorum error dolorum qui dolorem est eius qui. Sequi et assumenda harum nam quasi non quidem consequatur. Facere assumenda ad quia quo voluptatem ipsum nihil. Non qui aliquam.\n\nDebitis possimus non. Sapiente laboriosam adipisci ut nemo ad commodi quaerat ea. Rerum quisquam dolor ipsa omnis atque id perspiciatis inventore odio. Perferendis maiores laudantium exercitationem illo sunt sed.", null, "Branding" },
                    { new Guid("71d5f497-c3f5-7ba5-be68-bf5b48ae78f7"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(7616), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Est enim hic dicta possimus non. Est omnis officiis voluptatem. Rerum dolorum pariatur. Voluptatibus eius esse in. Quis voluptas totam occaecati id ipsum autem.\n\nPerspiciatis aut recusandae vel. Sunt error id vero. Dolor quis maiores quia. Et et iure quis officia modi molestiae. Voluptatum est necessitatibus doloremque at aut qui voluptatem autem.\n\nNihil enim et natus. Tempora maiores ducimus voluptatem non qui deserunt sed fuga a. Quia aliquid ut nam cumque autem ut eos necessitatibus ut.", null, "Data" },
                    { new Guid("726d4627-43be-0087-d237-d91e29d7f685"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(8031), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Neque est eveniet officia voluptatibus. Et enim pariatur maiores perferendis. Qui sapiente aliquid eligendi earum ducimus. Esse quaerat et natus consectetur rem.\n\nAdipisci vitae quasi possimus aut quasi non aut dolores. Accusantium ipsa saepe tenetur quo minima. Voluptate molestias ducimus vero dolores.\n\nNon aut quidem non cum impedit natus quo. Commodi provident aliquid dolores. In in reprehenderit eos.", null, "Program" },
                    { new Guid("7bc274f1-37ca-8c89-55f5-ba48918b0a91"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 93, DateTimeKind.Local).AddTicks(981), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Rem dignissimos ut nihil quam voluptas eius necessitatibus quia unde. Quia et repudiandae enim dicta itaque. Laborum quaerat ab sunt dolorum quisquam quae molestiae. Vitae quis assumenda libero et soluta.\n\nQuas earum et excepturi sequi ullam magnam deserunt aliquid omnis. Eos quia quasi sed quidem qui. Facere repellendus sit nisi sed rem dolorem eum quibusdam.\n\nDolores recusandae dolorem et. Est omnis provident voluptas quisquam nam iste nam. Temporibus corrupti reiciendis atque. Necessitatibus delectus earum quia ipsum occaecati enim consectetur temporibus illum.", null, "Configuration" },
                    { new Guid("7d2124cb-44d1-c562-3394-96d4b15bd3a6"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(8192), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Libero dignissimos eligendi nisi beatae pariatur dolorem maxime velit. Perferendis et et quas dolorum a laborum. Veniam enim facilis veniam numquam eos eum doloribus dolorum possimus.\n\nVoluptatem sit sit est et possimus placeat est quia. Quidem quos vel quia sit et aut qui eos ut. Ipsa consequatur nulla et. Quibusdam ipsum inventore et quisquam accusantium fugiat voluptate dolores. Dolores voluptas culpa natus quis ut. Maxime est debitis quae quo.\n\nUt et occaecati corrupti. Deleniti architecto quos et. Quibusdam pariatur a amet quia ad.", null, "Implementation" },
                    { new Guid("7ece7dc2-3454-0445-e14e-3885a11ecc6b"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(6377), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Nostrum dolorem repudiandae sunt tempore et et explicabo. Rerum laboriosam eius qui autem. Voluptatem minus qui iusto sed sit molestias.\n\nExpedita porro rerum commodi occaecati ex expedita natus ab itaque. Voluptatem enim laudantium omnis. Vel sit ipsum. Atque asperiores quibusdam. Tempore ut reiciendis. Totam quos ex voluptatibus esse dolorem quis magnam illum voluptatibus.\n\nImpedit nihil sint consequatur dolorem omnis minus rerum commodi repudiandae. Ut aut voluptas recusandae. Autem eos corporis ratione ut magnam nam sed consequatur. Blanditiis ut eius et illum. Aut molestiae esse.", null, "Research" },
                    { new Guid("82e37d0d-d908-b7d1-5c8b-e0d3e3b99751"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 93, DateTimeKind.Local).AddTicks(304), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Voluptatem accusamus deserunt temporibus facere aspernatur aut ex est. Voluptas nihil quis quo tempora. Sit est et eius ut nihil ratione nihil.\n\nVelit nihil earum consequuntur maiores veritatis. Sunt dolorem consectetur est ullam quia. Repellat quis quia nemo consequuntur enim repudiandae. Perferendis dolore quia. Distinctio voluptatum quo sit fuga. Aut aut quia excepturi nihil.\n\nEt sit eos unde assumenda deleniti exercitationem. Reiciendis rem minima voluptas. Dolores ut quia consectetur. Voluptatem dicta perferendis enim voluptatum iure nemo. Sequi impedit architecto temporibus commodi voluptas quia neque dolore labore. Magni voluptatibus nobis praesentium impedit facere voluptate provident ut.", null, "Marketing" },
                    { new Guid("840824b3-cda1-9246-7b3a-b04853b7c281"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(7183), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Explicabo sint ratione dignissimos neque temporibus nemo doloremque ea. Ex ipsa fuga modi ea ut accusantium id eum. Est nisi esse. Soluta impedit ex. Libero praesentium adipisci nisi velit ut delectus.\n\nOmnis id quidem doloribus illum nobis quia praesentium. Magni laborum amet ipsam. Id facere unde non corrupti vero assumenda provident. Voluptatum velit rerum ut.\n\nVeritatis qui ad. Rerum et ut ea occaecati qui ullam repudiandae expedita. Atque explicabo quia et ut omnis distinctio quod eligendi officiis. Sit esse ullam consectetur excepturi quis excepturi. Ratione repellat aliquam repudiandae.", null, "Functionality" },
                    { new Guid("86a09049-fb4f-dfa2-6694-91a7d12fc6fc"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(9882), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Aspernatur soluta illum nesciunt explicabo quo. Quo veniam asperiores quo est odit deserunt asperiores eum. Corrupti magni esse nihil in cumque quia iusto quia. Beatae voluptatem quidem non labore error sunt suscipit velit. Ex distinctio quia facilis asperiores sit ea esse ipsum temporibus. Non nam a non cupiditate autem cupiditate nemo sequi ratione.\n\nOccaecati debitis et aut qui maxime voluptate. Itaque iste voluptate. Qui harum dolorum voluptates laboriosam omnis et debitis molestias.\n\nUt necessitatibus minus id odio qui voluptates id qui dolor. Neque sapiente voluptatem. Modi voluptatem qui assumenda recusandae dolorum itaque. Repellendus dolore iure omnis. Et illum est.", null, "Implementation" },
                    { new Guid("aad6c4dd-c2ea-3cf2-4bb5-f13de96fa582"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(8672), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Quidem dolor molestiae repellendus in sit architecto et. Corporis et sint. Eligendi enim amet inventore vel et dolorem et quidem autem. Et vero ut deserunt quas facilis. Praesentium aut odit. Consectetur minus provident qui sed molestias quis quaerat.\n\nExercitationem optio maxime. Omnis ex aperiam vero rem dolorem. Ipsum ipsam eum autem quasi sunt deserunt iure. Quaerat omnis et quibusdam sed eaque tempore.\n\nNihil voluptas fuga nostrum asperiores suscipit consectetur. Natus quis perspiciatis commodi consectetur eaque sint. Ea aliquid non molestiae in vero nostrum.", null, "Brand" },
                    { new Guid("b18b945d-c1f4-17cd-5c91-f6a83c68f179"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 93, DateTimeKind.Local).AddTicks(536), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "In vero iure. Perspiciatis libero sit ea quia mollitia modi. Voluptatem odit id qui consequatur ullam modi laborum. Recusandae blanditiis quos corporis dolor dolorem ut dolores quidem dolore. Qui qui ut ut quo debitis quia.\n\nFacilis est at incidunt nemo aspernatur. Laudantium quisquam ducimus rerum non. Esse voluptates voluptatem corporis et autem optio. Recusandae adipisci deleniti sit culpa sint sed et. Quis non aperiam recusandae ab aut natus unde fugit sed. Omnis voluptatum ut iure aspernatur et voluptas et.\n\nQuia qui et optio. Eum aspernatur et dolores in et. Alias placeat qui nesciunt quaerat ea tempore qui eum expedita. Vitae non cupiditate accusantium consectetur. Dolorem sed ad a recusandae.", null, "Tactics" },
                    { new Guid("bb7fefc6-f358-f7f9-34a6-fb5375e01333"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(9531), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Qui reiciendis non quibusdam commodi id eius. Necessitatibus sit hic vero qui voluptatem eos. Voluptatum totam praesentium quam.\n\nEum temporibus quis harum. Maiores earum et quis et repellendus nam est omnis deserunt. Enim cum ut in quo placeat a sit ullam.\n\nQui eaque est tempora non harum. Ut ad assumenda quia. Rerum delectus ratione totam. Harum vitae necessitatibus velit ea et enim quia aut. Hic consequuntur molestiae.", null, "Operations" },
                    { new Guid("c1475282-b552-6268-12cf-7b100c27ffd3"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(7405), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Porro sint quos tempore dolore in. Sed ducimus odit at error voluptatem. Architecto perspiciatis ipsum dolores ut labore aliquam. Ut saepe rem odio. Non quos ducimus. Aperiam architecto modi laboriosam illum deserunt ut et.\n\nRepellendus et non ut. Sit perspiciatis quidem corrupti quisquam distinctio neque reprehenderit omnis. Iusto dicta debitis et quam similique in non et blanditiis. Provident voluptatum et et ea possimus et fugiat vitae quia.\n\nAut eaque qui est cum qui necessitatibus necessitatibus impedit. Corrupti optio dolorem non mollitia. Laborum sint eaque quas aut explicabo.", null, "Factors" },
                    { new Guid("c7c8ebae-6684-9725-e580-18f2bb69b04e"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 93, DateTimeKind.Local).AddTicks(1435), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Provident labore deleniti quis. Magni perspiciatis qui facilis commodi aliquid ut et repellendus et. Ducimus mollitia quis earum et et qui animi. Sit quo itaque.\n\nId placeat nobis. Quae porro assumenda. Illum consequatur delectus autem minima ipsum cum placeat. Quibusdam nesciunt in. Perferendis laborum ab totam dolorum explicabo aliquam natus. Exercitationem tempore consequatur tempore quibusdam id sed.\n\nQuidem sunt dolorum ipsa exercitationem aut alias aliquid. Nisi non nulla perspiciatis non dignissimos at neque eum. Exercitationem dignissimos et exercitationem aut qui et quia. Natus sint voluptas dolore neque eos non. Sit dolorum non est impedit sit.", null, "Response" },
                    { new Guid("cc361c8f-3fb7-6ff9-5bda-ae1c18c8f415"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(5615), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Eveniet tenetur iste qui sint eius est. Fuga quos non sequi corrupti et delectus omnis consequatur. Expedita soluta iste molestias et non quis inventore. Iste odit quo qui qui. Explicabo illum aut suscipit ullam. Veniam est consequatur consequatur et facilis ex doloribus.\n\nMinus totam tenetur quidem dolorem. Ut non sapiente nisi eius non in provident nisi quibusdam. Placeat sed aliquid explicabo iure dolore ducimus. Iusto animi quos enim autem sit eum. Repudiandae et eveniet eum dolores maiores quod.\n\nRem quasi et. Laudantium fugiat quidem deserunt esse doloremque dolores quia vero. Molestiae magni neque. Repellendus voluptas voluptates et. Laboriosam et qui. Qui ratione sit.", null, "Branding" },
                    { new Guid("dfc6cacf-ee87-e982-549a-8f241acc11bb"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(5299), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "In aut nihil vel magnam quisquam. Veritatis aut perferendis labore at eligendi. Et dolor temporibus ratione voluptas quam. Ut qui facere pariatur perferendis recusandae quia totam.\n\nOmnis inventore atque consectetur voluptas qui. Dolorum omnis occaecati fuga ipsum sit ut pariatur ipsa voluptate. Voluptatem ut ea error natus omnis praesentium voluptatibus. Aut delectus sit aliquid quidem qui voluptatem. Quia sit corporis nostrum natus suscipit vel laudantium id. Quod ad vel illum corporis veniam reprehenderit corporis expedita.\n\nEt enim atque dolor. Ipsa fugit aut nisi. Cupiditate sint architecto officiis quasi quis veniam error corporis. Dolores dolorem eum vel mollitia repellendus ut architecto. Necessitatibus praesentium doloribus non ipsa ut optio. Facere pariatur eos et ullam sint distinctio iste.", null, "Response" },
                    { new Guid("f9ed9e57-efa6-118f-8e77-16c598a08766"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(9705), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Nihil quia quo vel minus sunt nostrum iusto. Odit asperiores earum aperiam dignissimos hic consectetur impedit. Sint ipsam enim. Molestiae facere iste et sit. A aspernatur animi cumque sit possimus ullam.\n\nId autem repudiandae quaerat vel magnam consequatur. Harum tempora sunt. Est ipsam saepe cupiditate ex.\n\nAliquid et qui. Sed labore at dolor ut et temporibus non rerum ut. Eos sed quo molestiae est recusandae. Quia pariatur totam dolore quidem ut.", null, "Metrics" },
                    { new Guid("fbbd59e3-54ef-24bd-d67b-bc48d46a809f"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(4522), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Optio maxime beatae ea dolorum culpa autem quia aut aut. Quia autem veritatis. Soluta molestiae nisi voluptas ad tenetur labore.\n\nQuo qui sunt ea veritatis quis ab. Ex est dolores consequatur. Accusantium laborum ex minima ut explicabo eum in qui. Magni quis itaque tenetur in laboriosam vel praesentium maiores esse.\n\nVoluptas aliquid assumenda itaque totam asperiores nihil dolor. Omnis libero numquam in. Possimus repudiandae doloribus suscipit voluptatem laudantium expedita eos. Dolor deserunt occaecati perferendis id dolores unde ad error. Nisi minus et necessitatibus consequuntur incidunt aut qui saepe tempore.", null, "Solutions" },
                    { new Guid("fe262ba3-a6c7-02a2-115a-545f8252db6a"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 93, DateTimeKind.Local).AddTicks(1167), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Enim veritatis mollitia voluptatibus tempora numquam. Est ex qui dolores consequatur sit expedita odit quam aspernatur. Iure sint accusamus cum eius consequatur magnam repudiandae. Vitae iure sit dolor adipisci totam. Aliquam ullam sed est cumque quia maxime tenetur assumenda. Provident doloremque totam repellendus et molestias consequatur ex non.\n\nSunt at nostrum aliquam hic. Quaerat architecto earum ut animi tempora ad voluptatibus. Distinctio sit veniam est quod omnis ut. Quasi ut non magni accusamus quia nisi autem quasi. Nam minima earum sit. Quia reprehenderit vel totam labore.\n\nAliquam consequatur laboriosam eaque reiciendis voluptatem nam non aut. Esse in et ipsam fugit repellat. Ducimus sed cum et cum asperiores fugiat. Quia assumenda doloremque dicta dolor vel.", null, "Program" },
                    { new Guid("fe5f7a9b-1e89-b024-2aba-a74e6887cc62"), 0, new DateTime(2024, 12, 1, 16, 42, 33, 92, DateTimeKind.Local).AddTicks(6588), new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), "Eum rerum necessitatibus. Eos autem voluptates explicabo tempore ipsam consectetur. Alias id eveniet nobis sed rem rerum.\n\nIllo commodi dolorum quasi atque est consequatur amet culpa voluptatem. Et tenetur porro corrupti. Cupiditate provident qui aut qui et aut quis. Et sapiente quaerat et sed qui soluta optio. Accusamus voluptates rerum.\n\nDucimus perferendis perspiciatis ut. Enim repellat aut sed est incidunt. Sit voluptas et autem voluptas sed ad et nihil qui.", null, "Brand" }
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "id", "active", "created_at", "description", "duration", "instructor_id", "is_free", "lastupdate", "thumb", "title" },
                values: new object[,]
                {
                    { new Guid("0a478e68-e7ae-4847-9096-0d3e14a313b7"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(1340), "Consequatur delectus nemo. Consequatur rerum iste non temporibus aut odit incidunt illo. Animi nihil modi molestiae cum dolores earum sit. Molestias ut culpa tempora ut labore sequi ad eius. Adipisci similique dignissimos voluptas. Ea ducimus quia beatae id.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(1341), null, "Sapatos" },
                    { new Guid("22ab4d9d-cf7a-48cd-9458-0dabe57437a4"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(1019), "Sed distinctio aspernatur quidem id deleniti quos laboriosam harum laborum. Commodi minima reprehenderit tempore voluptatibus facere. Non nulla beatae rem reiciendis placeat dolorum.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(1020), null, "Pizza" },
                    { new Guid("5eacd8d0-77a6-4001-b796-d01db6205f33"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(1178), "Et aperiam labore qui nihil sit pariatur. Perspiciatis quam rerum eum veritatis aliquam. Voluptatem possimus consectetur rerum veritatis deserunt sapiente ut. Eum odit aspernatur aspernatur nulla dolore maxime vel. Porro eaque sapiente dolor nihil in aut quam molestias quia.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(1179), null, "Salada" },
                    { new Guid("5ef1a318-94c7-4c55-9d57-0e78f5af2377"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(901), "Et nihil explicabo facere ipsa repellendus illum aut dicta. Ullam est ipsam dicta placeat. Tempora ut eum quia ea ipsam repudiandae.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(902), null, "Mouse" },
                    { new Guid("68aa8e85-9c06-48c3-a9fd-575c9bc4e91f"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(965), "Deserunt tempora adipisci facere laudantium dicta vero qui. Nisi voluptatem ipsum. Similique placeat veniam facere nihil cumque odit odio.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(966), null, "Luvas" },
                    { new Guid("6d21efb8-eda7-46b8-823b-640d13387d74"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(1287), "Pariatur similique voluptatem nesciunt. Voluptas vero molestiae molestiae corporis fugiat voluptatem possimus enim. Ipsa rerum quia aut.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(1288), null, "Salsicha" },
                    { new Guid("70edd3f0-56dc-4c21-aa0a-e66cbe7d16b7"), true, new DateTime(2024, 12, 1, 16, 42, 33, 94, DateTimeKind.Local).AddTicks(8008), "Voluptas accusamus fugiat quia numquam quae dicta ut molestias modi. Quia et consequatur qui ut. In odit qui. Animi vel similique adipisci magni hic voluptas.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 94, DateTimeKind.Local).AddTicks(8015), null, "Peixe" },
                    { new Guid("76a52d36-8b1c-4fb4-9e04-cb658ff67ebc"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(807), "Quia consequatur perspiciatis voluptates. Quam non atque quia qui ut et. Dolore ut eveniet harum rerum neque fugiat deserunt. Aut quia ea doloremque voluptas eveniet animi explicabo et cumque. Ad quia ex aliquam saepe et accusantium. Illum vel aperiam.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(808), null, "Frango" },
                    { new Guid("7922fb70-c12d-4c08-8376-eb3ca40f3f41"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(1447), null, null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(1448), null, "Curso de baixa qualidade" },
                    { new Guid("a11bd6b4-1853-4e07-883a-f4d2def6fa5b"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(315), "Fugit modi sed. Accusantium nobis officiis consequatur sequi ducimus nemo repellat dignissimos. Odio cum praesentium tempore et. Omnis mollitia facilis quas reprehenderit fuga laboriosam laboriosam dolor harum.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(318), null, "Mouse" },
                    { new Guid("b11d827a-8b67-4e24-9517-4739b848bbc9"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(1087), "In cum ut nesciunt est est cumque corrupti sed. Eum dolore non laudantium blanditiis eum doloribus cumque dolores. Ipsa et tempora minus porro. Quidem sit et sit dolorem. Omnis est incidunt explicabo corrupti deserunt rerum quisquam enim ea.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(1088), null, "Sapatos" },
                    { new Guid("c1e9a31e-3891-48c4-baea-a765e46e695b"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(621), "Porro omnis autem dolores est mollitia eligendi sit. Quas ipsam et sed et culpa occaecati porro eos a. Et earum quia deleniti porro consectetur ullam aut ut. Libero qui iure consequatur minus tempore voluptas aut. Neque dolorem impedit et.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(622), null, "Pizza" },
                    { new Guid("df8f70f3-8a09-480a-a318-a4055a5e487f"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(549), "Ipsa aut voluptas eligendi recusandae voluptate incidunt repellat. Aut minus natus quia at rem. Hic dolores hic voluptatem aut qui occaecati facere hic.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(550), null, "Queijo" },
                    { new Guid("e9222da5-ed7c-4a72-92f1-2dde153e385c"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(726), "Qui adipisci nisi totam consequatur tempore sint debitis. Nostrum temporibus soluta dolore sit architecto sit molestiae. Non debitis dignissimos. Et et labore tempore adipisci voluptates est illum sed possimus.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(727), null, "Bola" },
                    { new Guid("ef6ac9d6-dd48-4999-8637-28a06728f1eb"), true, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(451), "Sint inventore molestiae odio minima adipisci. Assumenda eius quibusdam saepe molestiae est eum vero. A qui optio dolorem non. Repellendus ratione dolorum ad. Voluptatem ut exercitationem molestiae incidunt velit.", null, new Guid("59047194-a6ee-4f96-acb2-f4f9609e5035"), false, new DateTime(2024, 12, 1, 16, 42, 33, 95, DateTimeKind.Local).AddTicks(452), null, "Mouse" }
                });

            migrationBuilder.InsertData(
                table: "subscription_plans",
                columns: new[] { "id", "admin_id", "created_at", "description", "months", "price" },
                values: new object[,]
                {
                    { new Guid("137a74a5-22d6-44d5-b6e4-2c6e0a1113a8"), new Guid("8c0e2162-1b8f-44f3-a94a-8f000587e335"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4191), "Mensal", 1, 35f },
                    { new Guid("54fce32b-611c-43ec-97e8-196279c85ffb"), new Guid("8c0e2162-1b8f-44f3-a94a-8f000587e335"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4181), "Free", 0, 0f },
                    { new Guid("b3eb22e2-844f-46a0-b34f-78b149c6a836"), new Guid("8c0e2162-1b8f-44f3-a94a-8f000587e335"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4200), "Anual", 12, 399.99f }
                });

            migrationBuilder.InsertData(
                table: "modules",
                columns: new[] { "id", "complete", "course_id", "description", "order", "title" },
                values: new object[,]
                {
                    { new Guid("6154d96d-a065-4d5c-a208-97b2659a6c56"), false, new Guid("7922fb70-c12d-4c08-8376-eb3ca40f3f41"), null, 0, "introducao" },
                    { new Guid("8b015273-3d89-48da-a54b-ee67bcce60fd"), false, new Guid("7922fb70-c12d-4c08-8376-eb3ca40f3f41"), null, 1, "Modulo 2" },
                    { new Guid("aabd7ae5-0926-4fe4-89d2-9ee7bbac5f89"), false, new Guid("7922fb70-c12d-4c08-8376-eb3ca40f3f41"), null, 2, "Modulo 3" }
                });

            migrationBuilder.InsertData(
                table: "post_categories",
                columns: new[] { "id", "blog_post_id", "category_id" },
                values: new object[,]
                {
                    { new Guid("02b2fef8-f046-4334-b4d8-681ff5d7837a"), new Guid("2bb683ce-b44b-64b3-3d0e-4c5545684f4b"), new Guid("3832821e-62a6-4d2a-9678-a7a1daaae782") },
                    { new Guid("05230f77-464f-4496-9d33-b9211f4255e6"), new Guid("82e37d0d-d908-b7d1-5c8b-e0d3e3b99751"), new Guid("d1744b79-1801-4704-9c48-26832fa10926") },
                    { new Guid("112626c1-0973-44db-aaf7-5b0413a8cf08"), new Guid("dfc6cacf-ee87-e982-549a-8f241acc11bb"), new Guid("d445ba32-5a2e-46af-8097-d2eccafb0b12") },
                    { new Guid("1148148b-cced-418c-95dc-7da5659155d7"), new Guid("86a09049-fb4f-dfa2-6694-91a7d12fc6fc"), new Guid("3832821e-62a6-4d2a-9678-a7a1daaae782") },
                    { new Guid("1615d073-7ac1-4259-8675-2a45d8fe02e2"), new Guid("7bc274f1-37ca-8c89-55f5-ba48918b0a91"), new Guid("d445ba32-5a2e-46af-8097-d2eccafb0b12") },
                    { new Guid("1871d038-7760-4daa-b6d3-8d28d4bc56bf"), new Guid("f9ed9e57-efa6-118f-8e77-16c598a08766"), new Guid("41c0c9b0-0f2e-44c7-b898-03081ca816c9") },
                    { new Guid("21b839da-1a8c-45ac-b07d-8cc5ac73f535"), new Guid("fe262ba3-a6c7-02a2-115a-545f8252db6a"), new Guid("2509ec8d-894a-4bd7-b589-f5cf51b182ea") },
                    { new Guid("2663f693-394d-4cb4-8fc1-a802f23b4f49"), new Guid("04617aa2-b625-3e11-3298-2c07d93cac72"), new Guid("41c0c9b0-0f2e-44c7-b898-03081ca816c9") },
                    { new Guid("28009f9e-431b-43cb-be0c-b8397f3ab550"), new Guid("7d2124cb-44d1-c562-3394-96d4b15bd3a6"), new Guid("d445ba32-5a2e-46af-8097-d2eccafb0b12") },
                    { new Guid("2bb25501-e005-47bb-ad39-2dd1e21ce4a1"), new Guid("25e947bf-8cfe-8c55-0e09-88d29c945e3a"), new Guid("35ac4204-fe64-47c9-a95e-24ea4bd0af0e") },
                    { new Guid("3b2ccf59-d87f-4ee7-a2be-536c26662b1b"), new Guid("840824b3-cda1-9246-7b3a-b04853b7c281"), new Guid("2dc6b4d6-da39-4361-b59f-733a2d6e6e88") },
                    { new Guid("561902b0-ee5b-4dfa-9388-6f3dda4b7cfa"), new Guid("27aacc87-7332-9380-af14-bfd9c25abc05"), new Guid("e0c19352-2902-44ee-969a-ee2f5034c252") },
                    { new Guid("627d118b-59a9-457c-abc9-ea61806f817c"), new Guid("7ece7dc2-3454-0445-e14e-3885a11ecc6b"), new Guid("3832821e-62a6-4d2a-9678-a7a1daaae782") },
                    { new Guid("6492bf67-7023-4d8e-818e-d2d7195896b7"), new Guid("aad6c4dd-c2ea-3cf2-4bb5-f13de96fa582"), new Guid("2dc6b4d6-da39-4361-b59f-733a2d6e6e88") },
                    { new Guid("772c6d56-4845-4941-9926-5cde73c2af20"), new Guid("71d5f497-c3f5-7ba5-be68-bf5b48ae78f7"), new Guid("41c0c9b0-0f2e-44c7-b898-03081ca816c9") },
                    { new Guid("797a810e-eba6-4579-ab38-4b02e213a186"), new Guid("fbbd59e3-54ef-24bd-d67b-bc48d46a809f"), new Guid("2dc6b4d6-da39-4361-b59f-733a2d6e6e88") },
                    { new Guid("79ffdc58-66a0-422e-82f6-55b1f2b34b73"), new Guid("bb7fefc6-f358-f7f9-34a6-fb5375e01333"), new Guid("d1744b79-1801-4704-9c48-26832fa10926") },
                    { new Guid("7c8e1ec2-540a-4997-8ffa-bcee1586b88c"), new Guid("12c23c11-5136-34c0-07c5-9bf5b97fe0e1"), new Guid("d445ba32-5a2e-46af-8097-d2eccafb0b12") },
                    { new Guid("87cc73e1-5564-42af-8a04-0f9cac650dc1"), new Guid("16ac12a2-cde3-550d-e707-ac7dc24d3dc1"), new Guid("d445ba32-5a2e-46af-8097-d2eccafb0b12") },
                    { new Guid("892e79a7-d12c-4cb5-8ece-b5650ed9cbf6"), new Guid("c7c8ebae-6684-9725-e580-18f2bb69b04e"), new Guid("35ac4204-fe64-47c9-a95e-24ea4bd0af0e") },
                    { new Guid("9b3c967c-d7b9-4b3b-ab37-c56f3f090d1c"), new Guid("44deeef2-1e5a-313a-269e-1c9a0be121af"), new Guid("2509ec8d-894a-4bd7-b589-f5cf51b182ea") },
                    { new Guid("a670cc3b-9378-486a-aa2b-ffb21261f261"), new Guid("c1475282-b552-6268-12cf-7b100c27ffd3"), new Guid("d445ba32-5a2e-46af-8097-d2eccafb0b12") },
                    { new Guid("abfb3161-a89b-4eef-abad-eb930312c67c"), new Guid("03113096-7277-16d7-1236-e3b72b1a5c2c"), new Guid("41c0c9b0-0f2e-44c7-b898-03081ca816c9") },
                    { new Guid("c7e1a6ee-377d-4aa8-b186-845ce819be54"), new Guid("b18b945d-c1f4-17cd-5c91-f6a83c68f179"), new Guid("3832821e-62a6-4d2a-9678-a7a1daaae782") },
                    { new Guid("ce2d3865-16ea-4646-a61e-9e77dc6a8e76"), new Guid("cc361c8f-3fb7-6ff9-5bda-ae1c18c8f415"), new Guid("d445ba32-5a2e-46af-8097-d2eccafb0b12") },
                    { new Guid("ce3f1b4b-186f-4416-b31e-fec5e44402f6"), new Guid("726d4627-43be-0087-d237-d91e29d7f685"), new Guid("d1744b79-1801-4704-9c48-26832fa10926") },
                    { new Guid("df68acb3-5b8c-4d74-8765-7d5a91706982"), new Guid("3bcef47a-827b-5210-3ce3-1cbd0da9f804"), new Guid("0a9b1bfa-8786-4380-b432-236b2713d83b") },
                    { new Guid("e5b7a181-7aee-4caf-9628-3035b9d6a986"), new Guid("5c21f354-1859-210f-4fd1-164d00edb175"), new Guid("2509ec8d-894a-4bd7-b589-f5cf51b182ea") },
                    { new Guid("ebaab7a5-7250-4878-95df-b80b56c25016"), new Guid("fe5f7a9b-1e89-b024-2aba-a74e6887cc62"), new Guid("3832821e-62a6-4d2a-9678-a7a1daaae782") },
                    { new Guid("f2d18f8f-668e-42c1-919d-2744835a94c3"), new Guid("3b9374c5-ea43-df4f-c651-928e277f9e10"), new Guid("2dc6b4d6-da39-4361-b59f-733a2d6e6e88") }
                });

            migrationBuilder.InsertData(
                table: "user_plan",
                columns: new[] { "id", "client_id", "created_at", "is_active", "subscriptionplan_id" },
                values: new object[,]
                {
                    { new Guid("076574aa-f5e9-485a-9a4f-1d06d444533b"), new Guid("318f1742-dada-4215-9ed3-22bab51ab8f6"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4716), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("1477dd53-b997-43b1-b4c2-3d4d53d49e82"), new Guid("7bd3528b-e8e6-4c76-b454-26554757bd0d"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4815), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("1c6a39e1-aca3-4464-b0b8-ebfb4701e39d"), new Guid("5689ab59-a8a6-48f0-86b1-d596588aebc2"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4997), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("1f526f2e-efaa-47aa-9987-ed92f7562792"), new Guid("bcaf4dff-dc2c-4277-8adf-b4b0745f3515"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4689), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("1fefa3f1-4bc2-4a91-968c-8ec6e051c0e9"), new Guid("3b2773fc-d8a4-4499-a277-4fa5d15f7ec1"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4881), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("254675d4-227a-4ce2-b1a2-5323fbb9440d"), new Guid("f10bcee3-251e-4c5c-abac-0c70f7d8609c"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4887), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("29252470-2e0d-4af0-a12e-e171a10b88ad"), new Guid("7e17451a-f1a7-4867-8eef-513ec8d9247a"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4983), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("2d2d0daa-75b2-4e9d-ae86-95132f198940"), new Guid("a7e93cfb-5fb2-4aa6-90e1-73b39a5dfe7a"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4796), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("2d54dfd0-04d5-4e34-bb41-37e077bf6ed0"), new Guid("d9d1e411-bb83-497f-adfc-49eebd8b992e"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4925), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("383b7430-1ff6-43a7-b2d6-d52591925342"), new Guid("0c448140-80eb-4603-b70b-f9df17e34532"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4829), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("385827f3-b0f1-49d4-804f-2193ee47e53a"), new Guid("6eb8cd3b-b62e-4d03-b2a6-12d961f68996"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4855), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("44848ea9-b1e4-447f-a561-e4bdf657ab0c"), new Guid("e8b4f59f-426d-4470-8d62-c4eaf0d840db"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4868), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("4794a73a-a251-4b85-b52b-f1fb0a35f419"), new Guid("9457a1b3-e988-4f04-be2b-91c6546e7adc"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4682), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("53b2787e-e2cb-488b-bffc-cfabd73d9fa5"), new Guid("b4d8a8f0-2d5b-42be-8094-e5630e4f98e5"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4951), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("5c116098-51c5-4ac1-8793-06cf93cea478"), new Guid("7e25fd11-5c96-4923-8452-4dbaf423f65d"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4782), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("5d8d2ea2-c257-411c-9a20-ceaacce294d8"), new Guid("e1e640ea-1028-4d9b-8092-abb73745cd89"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4702), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("64db0ad4-e901-4aee-9a59-5f806f217e8e"), new Guid("e0e3a5fb-48c5-43d1-8a0e-31348d7f1bae"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4841), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("6596998a-90bd-4f20-880f-f2dddac29ae5"), new Guid("604b4b52-c9c5-4097-af1d-417b471e3bbe"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4835), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("6cd2a5ac-e87d-491c-bbe0-c2b46e5e91bc"), new Guid("9f18c287-d3c7-444c-bc16-44858779cfa9"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4762), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("7109e8a5-523f-4ee9-89a3-d8d8132d6add"), new Guid("226188f3-9384-415d-80fb-b3aad97e3f29"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4957), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("71bc0bad-6742-49e9-837a-cede145d043e"), new Guid("97768b8f-30c8-4cda-8d2c-20316c5348fc"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4749), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("77a7275e-45b9-4514-a8e2-3d9cba18c03b"), new Guid("d247cf23-016c-492e-8ee3-a4e7438caf88"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4938), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("7d53e356-018b-44d3-9dad-6a974f82599c"), new Guid("34ee8734-28a0-49f9-989a-afe5d1c88c7f"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4848), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("809fe17f-8938-45e1-8db1-7578d3eda470"), new Guid("c3baac2a-95e6-4f07-9360-f2ad44f1971a"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4710), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("87c3f9aa-41f8-40bc-b401-05e2e0eae07a"), new Guid("6569cf25-6b29-4022-a698-6d5454e99601"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4944), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("8cfa6c5f-2302-445b-bd5f-70dfd4287e2d"), new Guid("8ba972ba-e2a3-4061-8464-812f103f77e2"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4970), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("8d6e94f9-bf41-4188-b358-2d1af6f41cc5"), new Guid("2e234351-7f87-49d3-9462-86a58f83f675"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4743), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("912b8217-7e04-40fa-941a-6df4a9e0afe9"), new Guid("3bc9aead-3609-46be-a4e1-5904790ffc94"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4874), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("93b5188e-3fcb-469c-be1c-780ffe7eb24f"), new Guid("c0a688c7-07e4-42f1-af4b-5020671abec6"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(5003), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("a1e126d5-4966-4cc2-a91f-5f1cd9d5c230"), new Guid("91f14f7f-45ed-4009-8781-e2c7d09a97ef"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4911), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("a2770318-b662-44b6-aa1a-9a6e49d4ad06"), new Guid("15df39b0-4cc9-4b85-984e-556f24bec4c7"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4977), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("a7961f6b-6cf3-42a9-a8bf-28a51d45a9d8"), new Guid("39e9aef6-64d1-4dd3-ac03-ef4d881ae833"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4861), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("a8ca150e-c1c3-4d87-95a6-c0fbc2c0e3f3"), new Guid("eb1e666f-e9cf-412e-b105-c9d31d45d0e5"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4776), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("aac3123a-2e72-4a23-b8fd-586c41ab89e9"), new Guid("8fb2bad1-2bd6-4510-b6c3-fbcaf6bd6598"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4822), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("b45c03c2-90d2-40d2-89c0-d8a33d2b75fa"), new Guid("b174fc0f-14cf-42a9-a466-04e30128f65c"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4905), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("b7e8ce4f-3940-4b6e-a462-0e3d9303fe7c"), new Guid("13f75d9d-55d7-49d8-bd92-623dcfad435d"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4723), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("b8f292ef-24e0-44ee-825d-3af99a5a057f"), new Guid("cda26145-2357-432e-9d85-b5714ec60f60"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4672), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("bcb4818f-68da-46b6-a9b2-342f6c87023c"), new Guid("966c3dfa-4579-477c-a40a-8eafa5a9b653"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4756), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("bceb7d85-2046-43c1-b582-552c67e9e224"), new Guid("4834a7fb-3877-46c0-b7ce-b955a8e9ca01"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4964), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("cce33f32-7929-4546-87ed-c2a79c92d3e7"), new Guid("8edcb7b7-d0d7-4cb9-b748-97549ac0d644"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4990), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("d165271c-0b09-40ba-a323-51aef90201b4"), new Guid("2623fff3-e4f2-4b16-8c53-43e8d439e3a3"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4736), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("d23963d0-f6ae-4174-9a86-f75b2bfda072"), new Guid("ecc36acf-5565-4887-9bec-33c02c09cab1"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4769), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("d292ea94-7723-41ec-909a-913984a1607f"), new Guid("e3ffe204-ba7f-4163-bdd6-aba943f38a3e"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4696), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("d8a5f7ab-32ff-4c1f-baf5-4901a912b6db"), new Guid("930b853e-54ff-49d4-b24a-e120ee7bcafa"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4802), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("e59ea8be-4963-41ca-9bb6-64edb2ef4024"), new Guid("1cf55ba7-f8d3-4a23-a207-409ad11b9569"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4918), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("e9bd3122-65c5-4045-aeba-b075d09c6341"), new Guid("ed65540e-8614-40c0-800d-b60be05b5f21"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4809), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("ed02cc11-5234-4edd-8947-9c543a83e887"), new Guid("259e5b80-5fc4-4ce9-90b6-80b1151018f2"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4931), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("f0a2c1a5-17d4-4718-88c4-8f8a2f1ff89f"), new Guid("0080b621-4c02-4c6c-8fe0-47c4037a6ceb"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4729), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("f9f1c652-342b-4d5e-a3de-c3c6c387e62a"), new Guid("c42149f0-6cb0-4b10-93c5-e82b0ae91642"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(5010), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") },
                    { new Guid("fbbbcef0-398a-431a-8bbf-dd6c4b727d3e"), new Guid("f7084b48-0238-46fc-8ad6-7868be7fa721"), new DateTime(2024, 12, 1, 16, 42, 33, 90, DateTimeKind.Local).AddTicks(4789), true, new Guid("54fce32b-611c-43ec-97e8-196279c85ffb") }
                });

            migrationBuilder.InsertData(
                table: "videos",
                columns: new[] { "id", "created_at", "description", "duration", "module_id", "order", "title", "video_url" },
                values: new object[,]
                {
                    { new Guid("034540b9-da82-4764-94c6-78a6463ca972"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(517), null, null, new Guid("aabd7ae5-0926-4fe4-89d2-9ee7bbac5f89"), 25, "Fantástico Madeira Pizza", "" },
                    { new Guid("0f92a9e1-be38-47d7-bcce-9c73b3d6f2c7"), new DateTime(2024, 12, 1, 16, 42, 33, 96, DateTimeKind.Local).AddTicks(8251), null, null, new Guid("6154d96d-a065-4d5c-a208-97b2659a6c56"), 0, "Rústico Borracha Cadeira", "" },
                    { new Guid("11d4f818-4de6-4d5b-8570-d11bd50b5154"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(502), null, null, new Guid("aabd7ae5-0926-4fe4-89d2-9ee7bbac5f89"), 24, "Prático Aço Salada", "" },
                    { new Guid("18ae2466-0637-4e56-8517-2d2a1d0c1ef6"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(194), null, null, new Guid("6154d96d-a065-4d5c-a208-97b2659a6c56"), 5, "Gostoso Borracha Peixe", "" },
                    { new Guid("1ab3e03e-d4b4-488b-b2cf-60067d066298"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(546), null, null, new Guid("aabd7ae5-0926-4fe4-89d2-9ee7bbac5f89"), 27, "Inteligente Congelado Frango", "" },
                    { new Guid("1db51045-f877-49d5-b5b1-3af56450be46"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(442), null, null, new Guid("aabd7ae5-0926-4fe4-89d2-9ee7bbac5f89"), 20, "Rústico Plástico Camiseta", "" },
                    { new Guid("35117448-6bb1-4231-a814-370b229a0ad5"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(226), null, null, new Guid("6154d96d-a065-4d5c-a208-97b2659a6c56"), 7, "Incrível Madeira Frango", "" },
                    { new Guid("4202ab2d-ee88-4100-ac6d-fc7f301d4960"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(382), null, null, new Guid("8b015273-3d89-48da-a54b-ee67bcce60fd"), 16, "Gostoso Congelado Carro", "" },
                    { new Guid("4560c5eb-3918-4425-91ae-bcb28ecc8ef6"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(412), null, null, new Guid("8b015273-3d89-48da-a54b-ee67bcce60fd"), 18, "Incrível Granito Salsicha", "" },
                    { new Guid("4b236da6-3c3c-4cf8-b735-5c68a28014ac"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(487), null, null, new Guid("aabd7ae5-0926-4fe4-89d2-9ee7bbac5f89"), 23, "Lindo Macio Chapéu", "" },
                    { new Guid("4d064dc1-73db-4a90-8555-d52209aa5666"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(304), null, null, new Guid("8b015273-3d89-48da-a54b-ee67bcce60fd"), 12, "Genérico Aço Computador", "" },
                    { new Guid("4f6b13eb-ea23-48b4-909d-4d9a473762f4"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(398), null, null, new Guid("8b015273-3d89-48da-a54b-ee67bcce60fd"), 17, "Feito à mão Borracha Frango", "" },
                    { new Guid("55e5b2c9-8de7-46d7-bc90-2452f0eb2de7"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(531), null, null, new Guid("aabd7ae5-0926-4fe4-89d2-9ee7bbac5f89"), 26, "Refinado Plástico Atum", "" },
                    { new Guid("5a3c2e87-9e52-477a-bd7e-c9f1f843c71a"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(257), null, null, new Guid("6154d96d-a065-4d5c-a208-97b2659a6c56"), 9, "Refinado Plástico Carro", "" },
                    { new Guid("60844889-1a2c-4a7f-b3bf-495959eae202"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(289), null, null, new Guid("8b015273-3d89-48da-a54b-ee67bcce60fd"), 11, "Pequeno Congelado Peixe", "" },
                    { new Guid("6529c8a8-5457-4382-8bcf-537597cf5f5c"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(350), null, null, new Guid("8b015273-3d89-48da-a54b-ee67bcce60fd"), 15, "Ergonômico Algodão Frango", "" },
                    { new Guid("6918f18e-3354-482c-934d-81d497f1802a"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(139), null, null, new Guid("6154d96d-a065-4d5c-a208-97b2659a6c56"), 2, "Pequeno Fresco Carro", "" },
                    { new Guid("694c0347-f4a9-420c-820a-b2ed194e1a09"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(211), null, null, new Guid("6154d96d-a065-4d5c-a208-97b2659a6c56"), 6, "Pequeno Madeira Salada", "" },
                    { new Guid("71f5787d-1742-49e2-8bc1-6d6e7f3860c3"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(335), null, null, new Guid("8b015273-3d89-48da-a54b-ee67bcce60fd"), 14, "Gostoso Fresco Salsicha", "" },
                    { new Guid("73c89436-fe51-4eae-a662-f437fa0a5d62"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(320), null, null, new Guid("8b015273-3d89-48da-a54b-ee67bcce60fd"), 13, "Pequeno Madeira Toalhas", "" },
                    { new Guid("81adf1d9-dbb4-4a70-8e46-08ad0cc21f46"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(472), null, null, new Guid("aabd7ae5-0926-4fe4-89d2-9ee7bbac5f89"), 22, "Genérico Macio Computador", "" },
                    { new Guid("950d0de8-4f19-47ed-8abe-6696f3aff10c"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(242), null, null, new Guid("6154d96d-a065-4d5c-a208-97b2659a6c56"), 8, "Refinado Plástico Camiseta", "" },
                    { new Guid("9588faf7-91df-4965-83d3-9d7d0625c71d"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(575), null, null, new Guid("aabd7ae5-0926-4fe4-89d2-9ee7bbac5f89"), 29, "Prático Aço Peixe", "" },
                    { new Guid("9bd9960f-8529-4522-b5b5-0a9b3b88ecbe"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(176), null, null, new Guid("6154d96d-a065-4d5c-a208-97b2659a6c56"), 4, "Incrível Algodão Sabonete", "" },
                    { new Guid("9df9260d-df86-4c6f-8bca-a4249c848197"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(87), null, null, new Guid("6154d96d-a065-4d5c-a208-97b2659a6c56"), 1, "Inteligente Plástico Chapéu", "" },
                    { new Guid("b75fea0c-1a09-4080-8717-6dd7386c0eb7"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(457), null, null, new Guid("aabd7ae5-0926-4fe4-89d2-9ee7bbac5f89"), 21, "Fantástico Concreto Mesa", "" },
                    { new Guid("bf9b54f8-c4bf-4901-a39f-3a832d704359"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(272), null, null, new Guid("8b015273-3d89-48da-a54b-ee67bcce60fd"), 10, "Incrível Madeira Mouse", "" },
                    { new Guid("c53c0630-ad98-4f6b-a99e-3380cc6b9b22"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(427), null, null, new Guid("8b015273-3d89-48da-a54b-ee67bcce60fd"), 19, "Prático Macio Teclado", "" },
                    { new Guid("f4e35620-617e-4bc8-8987-09a6285ff4f3"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(157), null, null, new Guid("6154d96d-a065-4d5c-a208-97b2659a6c56"), 3, "Licenciado Madeira Chapéu", "" },
                    { new Guid("f7f56bca-18b6-47e2-81ae-46d47a68fde8"), new DateTime(2024, 12, 1, 16, 42, 33, 97, DateTimeKind.Local).AddTicks(560), null, null, new Guid("aabd7ae5-0926-4fe4-89d2-9ee7bbac5f89"), 28, "Feito à mão Madeira Bola", "" }
                });
        }
    }
}
