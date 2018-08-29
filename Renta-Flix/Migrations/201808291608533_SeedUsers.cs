namespace Renta_Flix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
			Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7e26b574-449b-485f-ae0a-6d2f97614800', N'guest@rflix.com', 0, N'AAgCK8Fmg6NTiinMsks31dkoKo0qsLNBP0S8hkYY5Fbq1ZuxALoh2JA3ZTScqHUfYA==', N'd9f0ce2d-e406-44d8-914f-afe602477050', NULL, 0, 0, NULL, 1, 0, N'guest@rflix.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'abef5753-1929-42f8-b7c6-2d102e0b5fa8', N'admin@rflix.com', 0, N'ANg3liNy89P9Rr4hLSqY6+JnEG55mgcH7bzHiQ8kHV3xcdBX2N8dlGsuRMjDOPSyow==', N'9b34ecf6-3eb5-498a-aa5f-27b9ac0e2ae2', NULL, 0, 0, NULL, 1, 0, N'admin@rflix.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'48d256ce-8096-4a4b-b9d3-6187c9ed5db2', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'abef5753-1929-42f8-b7c6-2d102e0b5fa8', N'48d256ce-8096-4a4b-b9d3-6187c9ed5db2')

");
        }
        
        public override void Down()
        {
        }
    }
}
