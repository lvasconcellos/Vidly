namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
               INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dfa1b2c7-1495-4737-ae05-444a6fe8091e', N'admin@vidly.com', 0, N'AJmauySrhp8gxB9JUpoq91gEKzVx8Pe6IzMNIeOyU/u1GUvC1UbaJNJYPyuYx4UuYQ==', N'c15d74f4-ada7-42c7-8b4f-9d24ff1c7b26', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
               INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'eba1672b-9115-4390-85d9-2007d54fe3e1', N'guest@vidly.com', 0, N'AHXHoPLbSoF0ediJlsyvg+SepZgi/tmZPgLxnX+Oep3ZKs9NsEsNMfG7VZJwpq60oQ==', N'eddbd291-ea50-4d6d-9fd0-915034b8b294', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            
               INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'20895362-c3d9-4372-a05f-bdabe77c21b0', N'CanManageMovies')

               INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dfa1b2c7-1495-4737-ae05-444a6fe8091e', N'20895362-c3d9-4372-a05f-bdabe77c21b0')
               ");
        }
        
        public override void Down()
        {
        }
    }
}
