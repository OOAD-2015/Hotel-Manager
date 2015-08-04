Use HotelManager;
GO

CREATE TABLE [dbo].[ROLEPERMISSION](
	[RolePermissionID] [nvarchar](10) NOT NULL,
	[RolePermissionName] [nvarchar](100) NOT NULL,
	[ThietLapHeThong] [bit] NULL,
	[ThayDoiQuyDinh] [bit] NULL,
 CONSTRAINT [PK_ROLEPERMISSION] PRIMARY KEY CLUSTERED 
(
	[RolePermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[STAFF] ADD [Sex] [bit] NULL,[Email] [nvarchar](100) NULL,
	[DateCreated] [smalldatetime] NOT NULL,
	[RolePermissionID] [nvarchar](10) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL;

GO

ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD CONSTRAINT [FK_STAFF_ROLEPERMISSION] FOREIGN KEY([RolePermissionID])
REFERENCES [dbo].[ROLEPERMISSION] ([RolePermissionID])
GO

CREATE PROCEDURE [dbo].[sp_LookAtRolePermissionDataFromDatabase]
(
	@RolePermissionName nvarchar(100)
)

AS
	SELECT * 
	FROM ROLEPERMISSION 
	WHERE RolePermissionName like '%'+@RolePermissionName+'%'

RETURN

GO

CREATE PROCEDURE [dbo].[sp_DeleteRolePermission]
(
	@RolePermissionID nvarchar(10)
)
AS
	DELETE ROLEPERMISSION 
	WHERE RolePermissionID = @RolePermissionID

GO

CREATE PROCEDURE [dbo].[sp_EditRolePermissionUpdate]
(
	@RolePermissionID nvarchar(10),
	@RolePermissionName nvarchar(100)
)
AS
	UPDATE ROLEPERMISSION 
	SET RolePermissionName = @RolePermissionName
	WHERE RolePermissionID = @RolePermissionID



GO

CREATE PROCEDURE [dbo].[sp_AddNewRolePermissionInsert]
(
	@RolePermissionID nvarchar(10),
	@RolePermissionName nvarchar(100)
)
AS
	INSERT INTO ROLEPERMISSION (RolePermissionID, RolePermissionName)
	VALUES (@RolePermissionID, @RolePermissionName)



GO

CREATE PROCEDURE [dbo].[sp_GetRolePermissionNameByID]
(
	@RolePermissionID nvarchar(10)
)
AS
	SELECT RolePermissionName
	FROM ROLEPERMISSION 
	WHERE RolePermissionID = @RolePermissionID



GO

CREATE PROCEDURE [dbo].[sp_GetRolePermissionByID]
(
	@RolePermissionID nvarchar(10)
)
AS
	SELECT *
	FROM ROLEPERMISSION 
	WHERE RolePermissionID = @RolePermissionID



GO

CREATE PROCEDURE [dbo].[sp_GetAllRolePermission]

AS
	SELECT *
	FROM ROLEPERMISSION



GO


/*Staff*/

CREATE PROCEDURE [dbo].[sp_LookAtStaffByNameDataFromDatabase]
(
	@StaffName nvarchar(100)
)

AS
	SELECT StaffID, StaffName,
			CASE Sex
				 WHEN 0 THEN N'Nữ' 
				 WHEN 1 THEN N'Nam'
				 ELSE N'Khác'
			END AS Sex, 
			DateOfBirth, Address, 
			PhoneNumber, Email, 
			DateCreated, RolePermissionID, 
			UserName, [Password]
	FROM STAFF 
	WHERE StaffName like '%'+@StaffName+'%'

RETURN



GO

CREATE PROCEDURE [dbo].[sp_LookAtStaffByIdDataFromDatabase]
(
	@StaffId nvarchar(10)
)

AS
	SELECT StaffID, StaffName,
			CASE Sex
				 WHEN 0 THEN N'Nữ' 
				 WHEN 1 THEN N'Nam'
				 ELSE N'Khác'
			END AS Sex, 
			DateOfBirth, Address, 
			PhoneNumber, Email, 
			DateCreated, RolePermissionID, 
			UserName, [Password]
	FROM STAFF 
	WHERE StaffID like '%'+@StaffId+'%'

RETURN



GO

CREATE PROCEDURE [dbo].[sp_DeleteStaff]
(
	@StaffId nvarchar(10)
)
AS
BEGIN
		DELETE STAFF 
		WHERE StaffID = @StaffId
END



GO

CREATE PROCEDURE [dbo].[sp_EditStaffUpdateNoUsernamePassword]
(
	@StaffId nvarchar(10),
	@Name nvarchar(100),
	@Gender nvarchar(5),
	@Birthday smallDateTime,
	@Address nvarchar(255),
	@Phone nvarchar(20),
	@Email nvarchar(100),
	@DateStart smalldatetime,
	@PositionId nvarchar(10)
)
AS
IF(LOWER(@Gender) = N'nữ')
	BEGIN
		UPDATE STAFF 
		SET StaffName = @Name,
			Sex = 0, 
			DateOfBirth = @Birthday, 
			Address = @Address, 
			PhoneNumber = @Phone, 
			Email = @Email, 
			DateCreated = @DateStart, 
			RolePermissionID = @PositionId 
		WHERE StaffID = @StaffId
	END
ELSE
	BEGIN
		IF(LOWER(@Gender) = N'nam')
			BEGIN
				UPDATE STAFF 
				SET StaffName = @Name,
					Sex = 1, 
					DateOfBirth = @Birthday, 
					Address = @Address, 
					PhoneNumber = @Phone, 
					Email = @Email, 
					DateCreated = @DateStart, 
					RolePermissionID = @PositionId
				WHERE StaffID = @StaffId
			END
		ELSE
			BEGIN
				UPDATE STAFF 
				SET StaffName = @Name,
					Sex = NULL, 
					DateOfBirth = @Birthday, 
					Address = @Address, 
					PhoneNumber = @Phone, 
					Email = @Email, 
					DateCreated = @DateStart, 
					RolePermissionID = @PositionId
				WHERE StaffID = @StaffId
			END
	END



GO

CREATE PROCEDURE [dbo].[sp_EditStaffUpdateForPassword]
(
	@StaffId nvarchar(10),
	@Password nvarchar(100)
)
AS
BEGIN
		UPDATE STAFF 
		SET [Password] = @Password
		WHERE StaffID = @StaffId
END



GO

CREATE PROCEDURE [dbo].[sp_EditStaffUpdate]
(
	@StaffId nvarchar(10),
	@Name nvarchar(100),
	@Gender nvarchar(5),
	@Birthday smallDateTime,
	@Address nvarchar(255),
	@Phone nvarchar(20),
	@Email nvarchar(100),
	@DateStart smalldatetime,
	@PositionId nvarchar(10),
	@Password nvarchar(100)
)
AS
IF(LOWER(@Gender) = N'nữ')
	BEGIN
		UPDATE STAFF 
		SET StaffName = @Name,
			Sex = 0, 
			DateOfBirth = @Birthday, 
			Address = @Address, 
			PhoneNumber = @Phone, 
			Email = @Email, 
			DateCreated = @DateStart, 
			RolePermissionID = @PositionId, 
			[Password] = @Password
		WHERE StaffID = @StaffId
	END
ELSE
	BEGIN
		IF(LOWER(@Gender) = N'nam')
			BEGIN
				UPDATE STAFF 
				SET StaffName = @Name,
					Sex = 1, 
					DateOfBirth = @Birthday, 
					Address = @Address, 
					PhoneNumber = @Phone, 
					Email = @Email, 
					DateCreated = @DateStart, 
					RolePermissionID = @PositionId, 
					[Password] = @Password
				WHERE StaffID = @StaffId
			END
		ELSE
			BEGIN
				UPDATE STAFF 
				SET StaffName = @Name,
					Sex = NULL, 
					DateOfBirth = @Birthday, 
					Address = @Address, 
					PhoneNumber = @Phone, 
					Email = @Email, 
					DateCreated = @DateStart, 
					RolePermissionID = @PositionId, 
					[Password] = @Password
				WHERE StaffID = @StaffId
			END
	END



GO

CREATE PROCEDURE [dbo].[sp_AddNewStaffInsert]
(
	@StaffId nvarchar(10),
	@Name nvarchar(100),
	@Gender nvarchar(5),
	@Birthday smallDateTime,
	@Address nvarchar(255),
	@Phone nvarchar(20),
	@Email nvarchar(100),
	@DateStart smalldatetime,
	@PositionId nvarchar(10),
	@UserName nvarchar(100),
	@Password nvarchar(100)
)
AS
IF(LOWER(@Gender) = N'nữ')
	BEGIN
		INSERT INTO STAFF ([StaffID], [StaffName], [Sex], [DateOfBirth], [Address], [PhoneNumber], [Email], [DateCreated], [RolePermissionID], [UserName], [Password])
		VALUES(@StaffId,@Name,0, @Birthday, @Address, @Phone, @Email, @DateStart, @PositionId, @UserName, @Password)
	END
ELSE
	BEGIN
		IF(LOWER(@Gender) = N'nam')
			BEGIN
				INSERT INTO STAFF ([StaffID], [StaffName], [Sex], [DateOfBirth], [Address], [PhoneNumber], [Email], [DateCreated], [RolePermissionID], [UserName], [Password]) 
				VALUES(@StaffId,@Name,1, @Birthday, @Address, @Phone, @Email, @DateStart, @PositionId, @UserName, @Password)
			END
		ELSE
			BEGIN
				INSERT INTO STAFF ([StaffID], [StaffName], [Sex], [DateOfBirth], [Address], [PhoneNumber], [Email], [DateCreated], [RolePermissionID], [UserName], [Password]) 
				VALUES(@StaffId,@Name,NULL, @Birthday, @Address, @Phone, @Email, @DateStart, @PositionId, @UserName, @Password)
			END
	END



GO

CREATE PROCEDURE [dbo].[sp_GetStaffByUserName]
(
	@StaffUserName nvarchar(100)
)
AS
	SELECT StaffID, StaffName,
			CASE Sex
				 WHEN 0 THEN N'Nữ' 
				 WHEN 1 THEN N'Nam'
				 ELSE N'Khác'
			END AS Sex, 
			DateOfBirth, Address, 
			PhoneNumber, Email, 
			DateCreated, RolePermissionID, 
			UserName, [Password] 
	FROM STAFF  
	Where STAFF.UserName = @StaffUserName



GO

CREATE PROCEDURE [dbo].[sp_GetStaffById]
(
	@StaffId nvarchar(10)
)
AS
	SELECT StaffID, StaffName,
			CASE Sex
				 WHEN 0 THEN N'Nữ' 
				 WHEN 1 THEN N'Nam'
				 ELSE N'Khác'
			END AS Sex, 
			DateOfBirth, Address, 
			PhoneNumber, Email, 
			DateCreated, RolePermissionID, 
			UserName, [Password]
	FROM STAFF  
	Where STAFF.StaffID = @StaffId



GO

CREATE PROCEDURE [dbo].[sp_GetAllStaff]

AS
	SELECT  StaffID, StaffName,
			CASE Sex
				 WHEN 0 THEN N'Nữ' 
				 WHEN 1 THEN N'Nam'
				 ELSE N'Khác'
			END AS Sex, 
			DateOfBirth, Address, 
			PhoneNumber, Email, 
			DateCreated, RolePermissionID, 
			UserName, [Password]
	FROM STAFF



GO

/****** Object:  Table [dbo].[RULE]    Script Date: 7/29/2015 1:17:37 AM ******/
DROP TABLE [dbo].[RULE]
GO

/****** Object:  Table [dbo].[RULE]    Script Date: 7/29/2015 1:17:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RULE](
	[Id] [int] NOT NULL,
	[Label] [nvarchar](255) NOT NULL,
	[Value] [nvarchar](100) NOT NULL,
CONSTRAINT [PK_RULE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/*Rule*/

CREATE PROCEDURE [dbo].[sp_DeleteRule]
(
	@Id int
)
AS
	DELETE [RULE]
	WHERE Id =  @Id



GO

CREATE PROCEDURE [dbo].[sp_EditRuleUpdate]
(
	@Id int,
	@Label nvarchar(255), 
	@Value nvarchar(100)
)
AS
	UPDATE [RULE]
	SET Value = @Value
	WHERE Id =  @Id



GO

CREATE PROCEDURE [dbo].[sp_AddNewRuleInsert]
(
	@Id int,
	@Label nvarchar(255), 
	@Value nvarchar(100)
)
AS
	INSERT INTO [RULE]
	VALUES(@Id, @Label, @Value)



GO

CREATE PROCEDURE [dbo].[sp_GetRuleByLabel]
(
	@Label nvarchar(255)
)
AS
	SELECT  Value
	FROM [RULE]
	WHERE Label = @Label



GO

CREATE PROCEDURE [dbo].[sp_GetRuleByID]
(
	@Id int
)
AS
	SELECT  Value
	FROM [RULE]
	WHERE Id = @Id



GO

CREATE PROCEDURE [dbo].[sp_GetAllRule]
AS
	SELECT  Id, Label, Value
	FROM [RULE]



GO

INSERT [dbo].[ROLEPERMISSION] ([RolePermissionID], [RolePermissionName], [ThietLapHeThong], [ThayDoiQuyDinh]) VALUES (N'CV00000001', N'Admin', 1, 1)

GO

INSERT INTO [dbo].[STAFF]
           ([StaffID]
           ,[StaffName]
           ,[DateOfBirth]
           ,[PhoneNumber]
           ,[Address]
           ,[Sex]
           ,[Email]
           ,[DateCreated]
           ,[RolePermissionID]
           ,[UserName]
           ,[Password])
     VALUES
           ('NV000001'
           ,N'Trung'
           ,'1/1/1993'
           ,'0111111111'
           ,''
           ,1
           ,''
           ,'07/07/2015'
           ,'CV00000001'
           ,'trungpv'
           ,'a73840d748dc1313e307afbf9d9a79f3')

GO

