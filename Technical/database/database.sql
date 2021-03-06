USE [HotelManager]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewCustomerInsert]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_AddNewCustomerInsert]
(
	@CustomerId nvarchar(10),
	@Name nvarchar(100),
	@Gender nvarchar(5),
	@Birthday smalldatetime,
	@Address nvarchar(255),
	@Phone nvarchar(20),
	@Email nvarchar(100),
	@IDNumber nchar(10)
)
AS
	IF(LOWER(@Gender) = N'nữ')
	BEGIN
		INSERT INTO CUSTOMER 
		VALUES(@CustomerId,@Name, @Birthday, @IDNumber, @Phone, @Address, 0, @Email)
	END
ELSE
	BEGIN
		IF(LOWER(@Gender) = N'nam')
			BEGIN
				INSERT INTO CUSTOMER 
				VALUES(@CustomerId,@Name, @Birthday, @IDNumber, @Phone, @Address, 1, @Email)
			END
		ELSE
			BEGIN
				INSERT INTO CUSTOMER 
				VALUES(@CustomerId,@Name, @Birthday, @IDNumber, @Phone, @Address, NULL, @Email)
			END
	END




GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewOrder]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddNewOrder]
	@OrderID char(10),
	@CustomerID char(10),
	@StaffID char(10),
	@OrderOfDate smalldatetime,
	@NumberOfPeople int,
	@Estimate int,
	@Deposit int,
	@Total int,
	@OrderStatus int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    -- Insert statements for procedure here
	INSERT INTO [ORDER] VALUES(@OrderID, @CustomerID, @StaffID, @OrderOfDate, @NumberOfPeople, @Estimate, @Deposit, @Total, @OrderStatus)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewOrderDetail]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddNewOrderDetail]
	@OrderDetailID char(10),
	@OrderID char(10),
	@RoomID char(10),
	@StartDate DateTime,
	@EndDate DateTime,
	@Estimate int,
	@ServicesMoney int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    -- Insert statements for procedure here
	INSERT INTO ORDERDETAIL VALUES(@OrderDetailID, @OrderID, @RoomID, @StartDate, @EndDate, @Estimate, @ServicesMoney)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewOrderInsert]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AddNewOrderInsert]
(
	@OrderID nvarchar(10),
	@CustomerID nvarchar(10),
	@StaffID nvarchar(10),
	@OrderOfDate date,
	@NumberOfPeople int,
	@Deposit int,
	@Total int,
	@OrderStatus nvarchar(50)
)
AS
	INSERT INTO [ORDER]
	VALUES(@OrderID,@CustomerID, @StaffID, @OrderOfDate, @NumberOfPeople, @Deposit, @Total, @OrderStatus)




GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewRolePermissionInsert]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_AddNewRoomInsert]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AddNewRoomInsert]
(
	@RoomID nvarchar(10),
	@RoomName nvarchar(100),
	@RoomTypeID nvarchar(10),
	@NumberOfBeds int, 
	@Description nvarchar(255),
	@RoomStatusID nvarchar(10)
)
AS
	INSERT INTO ROOM 
	VALUES(@RoomID,@RoomName, @RoomTypeID, @NumberOfBeds, @Description, @RoomStatusID)




GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewRoomTypeInsert]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AddNewRoomTypeInsert]
(
	@RoomTypeID nvarchar(10),
	@RoomTypeName nvarchar(100),
	@Price int
)
AS
	INSERT INTO ROOMTYPE 
	VALUES(@RoomTypeID,@RoomTypeName,@Price)




GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewRuleInsert]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_AddNewServiceDetailInsert]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AddNewServiceDetailInsert]
(
	@ServiceDetailID nvarchar(10),
	@OrderDetailID nvarchar(10),
	@ServicesID nvarchar(10),
	@Quantity int,
	@Total int
)
AS
	INSERT INTO SERVICEDETAIL 
	VALUES(@ServiceDetailID, @OrderDetailID, @ServicesID, @Quantity , @Total)




GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewServicesInsert]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AddNewServicesInsert]
(
	@ServicesID nvarchar(10),
	@ServicesName nvarchar(100),
	@ServicesTypeID nvarchar(10),
	@Price int, 
	@ServicesUnitID nvarchar(10)
)
AS
	INSERT INTO SERVICES 
	VALUES(@ServicesTypeID, @ServicesID,@ServicesName, @ServicesUnitID, @Price)




GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewServicesTypeInsert]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AddNewServicesTypeInsert]
(
	@ServicesTypeID nvarchar(10),
	@ServicesTypeName nvarchar(100)
)
AS
	INSERT INTO SERVICESTYPE 
	VALUES(@ServicesTypeID,@ServicesTypeName)




GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewStaffInsert]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_AddNewStatusInsert]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AddNewStatusInsert]
(
	@StatusID nvarchar(10),
	@StatusName nvarchar(100)
)
AS
	INSERT INTO STATUS 
	VALUES(@StatusID,@StatusName)




GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewUnitInsert]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AddNewUnitInsert]
(
	@UnitID nvarchar(10),
	@UnitName nvarchar(100)
)
AS
	INSERT INTO UNIT 
	VALUES(@UnitID,@UnitName)




GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteAllServiceDetailByOrderID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteAllServiceDetailByOrderID]
(
	@OrderDetailID nvarchar(10)
)

AS
	DELETE SERVICEDETAIL 
	WHERE OrderDetailID = @OrderDetailID

RETURN
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCustomer]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteCustomer]
(
	@CustomerId nvarchar(10)
)
AS
BEGIN
		DELETE CUSTOMER 
		WHERE CustomerID = @CustomerId
END




GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteOrder]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ORDER



CREATE PROCEDURE [dbo].[sp_DeleteOrder]
(
	@OrderId nvarchar(10)
)

AS
	DELETE ORDERDETAIL 
	WHERE OrderID = @OrderId;

	DELETE [ORDER] 
	WHERE OrderID = @OrderId

RETURN



GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteOrderDetails]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteOrderDetails]
	@OrderID char(10)
AS
BEGIN
	Delete from [dbo].[ORDER] where OrderID = @OrderID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteRolePermission]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteRolePermission]
(
	@RolePermissionID nvarchar(10)
)
AS
	DELETE ROLEPERMISSION 
	WHERE RolePermissionID = @RolePermissionID


GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteRoom]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteRoom]
(
	@RoomId nvarchar(10)
)

AS
	DELETE ROOM 
	WHERE RoomID = @RoomId

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteRoomType]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteRoomType]
(
	@RoomTypeId nvarchar(10)
)

AS
	DELETE ROOMTYPE 
	WHERE RoomTypeID = @RoomTypeId

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteRule]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteServiceDetail]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteServiceDetail]
(
	@ServiceDetailId nvarchar(10)
)

AS
	DELETE SERVICEDETAIL 
	WHERE SevicesDetailID = @ServiceDetailId

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteServices]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteServices]
(
	@ServicesId nvarchar(10)
)

AS
	DELETE SERVICES 
	WHERE ServicesID = @ServicesId

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteServicesType]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteServicesType]
(
	@ServicesTypeId nvarchar(10)
)

AS
	DELETE SERVICESTYPE 
	WHERE ServicesTypeID = @ServicesTypeId

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteStaff]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteStatus]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteStatus]
(
	@StatusId nvarchar(10)
)

AS
	DELETE STATUS 
	WHERE StatusID = @StatusId

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteUnit]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteUnit]
(
	@UnitId nvarchar(10)
)

AS
	DELETE UNIT 
	WHERE UnitID = @UnitId

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_EditCustomerUpdate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_EditCustomerUpdate]
(
	@CustomerId nvarchar(10),
	@Name nvarchar(100),
	@Gender nvarchar(5),
	@Birthday smalldatetime,
	@Address nvarchar(255),
	@Phone nvarchar(20),
	@Email nvarchar(100), 
	@IDNumber nchar(10)
)
AS
IF(LOWER(@Gender) = N'nữ')
	BEGIN
		UPDATE CUSTOMER 
		SET CustomerName = @Name,
			Gender = 0, 
			DateOfBirth = @Birthday, 
			Address = @Address, 
			PhoneNumber = @Phone, 
			Email = @Email, 
			IDNumber = @IDNumber
		WHERE CustomerID = @CustomerId
	END
ELSE
	BEGIN
		IF(LOWER(@Gender) = N'nam')
			BEGIN
				UPDATE CUSTOMER 
				SET CustomerName = @Name,
					Gender = 1, 
					DateOfBirth = @Birthday, 
					Address = @Address, 
					PhoneNumber = @Phone, 
					Email = @Email, 
					IDNumber = @IDNumber
				WHERE CustomerID = @CustomerId
			END
		ELSE
			BEGIN
				UPDATE CUSTOMER 
				SET CustomerName = @Name,
					Gender = NULL, 
					DateOfBirth = @Birthday, 
					Address = @Address, 
					PhoneNumber = @Phone, 
					Email = @Email, 
					IDNumber = @IDNumber
				WHERE CustomerID = @CustomerId
			END
	END




GO
/****** Object:  StoredProcedure [dbo].[sp_EditOrderDetail]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EditOrderDetail]
	@OrderDetailID char(10),
	@OrderID char(10),
	@RoomID char(10),
	@StartDate DateTime,
	@EndDate DateTime,
	@Estimate int,
	@ServicesMoney int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    -- Insert statements for procedure here
	UPDATE ORDERDETAIL SET OrderDetailID = @OrderDetailID, OrderID = @OrderID, RoomID = @RoomID, StartDate = @StartDate, EndDate = @EndDate, Estimate = @Estimate, ServicesMoney = @ServicesMoney
END

GO
/****** Object:  StoredProcedure [dbo].[sp_EditOrderUpdate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Test
-- sp_AddNewOrder 'DP0000000', 'KH0000001', 'NV000001', '23-08-2015' ,0, 0, 0 , 0, 0

CREATE PROCEDURE [dbo].[sp_EditOrderUpdate]
	@OrderID char(10),
	@CustomerID char(10),
	@StaffID char(10),
	@OrderOfDate smalldatetime,
	@NumberOfPeople int,
	@Estimate int,
	@Deposit int,
	@Total int,
	@OrderStatus int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    -- Insert statements for procedure here
	UPDATE [ORDER] SET OrderID = @OrderID, CustomerID = @CustomerID, StaffID = @StaffID, OrderOfDate = @OrderOfDate, NumberOfPeople = @NumberOfPeople, Estimate = @Estimate, Deposit = @Deposit, Total = @Total, OrderStatus = @OrderStatus
END

GO
/****** Object:  StoredProcedure [dbo].[sp_EditRolePermissionUpdate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_EditRoomTypeUpdate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EditRoomTypeUpdate]
(
	@RoomTypeID nvarchar(10),
	@RoomTypeName nvarchar(100),
	@Price int
)
AS
	UPDATE ROOMTYPE 
	SET RoomTypeName = @RoomTypeName, Price = @Price
	WHERE RoomTypeID = @RoomTypeID




GO
/****** Object:  StoredProcedure [dbo].[sp_EditRoomUpdate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EditRoomUpdate]
(
	@RoomID nvarchar(10),
	@RoomName nvarchar(100),
	@RoomTypeID nvarchar(10),
	@NumberOfBeds int, 
	@Description nvarchar(255),
	@RoomStatusID nvarchar(10)
)
AS
	UPDATE ROOM 
	SET RoomName = @RoomName, RoomTypeID = @RoomTypeID , NumberOfBeds = @NumberOfBeds , Description = @Description , StatusID = @RoomStatusID
	WHERE RoomID = @RoomID




GO
/****** Object:  StoredProcedure [dbo].[sp_EditRuleUpdate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_EditServiceDetailUpdate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EditServiceDetailUpdate]
(
	@ServiceDetailID nvarchar(10),
	@ServicesID nvarchar(10),
	@Quantity int,
	@Total int
)
AS
	UPDATE SERVICEDETAIL 
	SET ServicesID = @ServicesID, Quantity = @Quantity, Monetized = @Total
	WHERE SevicesDetailID = @ServiceDetailID




GO
/****** Object:  StoredProcedure [dbo].[sp_EditServicesTypeUpdate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EditServicesTypeUpdate]
(
	@ServicesTypeID nvarchar(10),
	@ServicesTypeName nvarchar(100)
)
AS
	UPDATE SERVICESTYPE 
	SET ServicesTypeName = @ServicesTypeName
	WHERE ServicesTypeID = @ServicesTypeID




GO
/****** Object:  StoredProcedure [dbo].[sp_EditServicesUpdate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EditServicesUpdate]
(
	@ServicesID nvarchar(10),
	@ServicesName nvarchar(100),
	@ServicesTypeID nvarchar(10),
	@Price int, 
	@ServicesUnitID nvarchar(10)
)
AS
	UPDATE SERVICES 
	SET ServicesName = @ServicesName, ServicesTypeID = @ServicesTypeID , Price = @Price , UnitID = @ServicesUnitID
	WHERE ServicesID = @ServicesID




GO
/****** Object:  StoredProcedure [dbo].[sp_EditStaffUpdate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_EditStaffUpdateForPassword]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_EditStaffUpdateNoUsernamePassword]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_EditStatusUpdate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EditStatusUpdate]
(
	@StatusID nvarchar(10),
	@StatusName nvarchar(100)
)
AS
	UPDATE STATUS 
	SET StatusName = @StatusName
	WHERE StatusID = @StatusID




GO
/****** Object:  StoredProcedure [dbo].[sp_EditUnitUpdate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EditUnitUpdate]
(
	@UnitID nvarchar(10),
	@UnitName nvarchar(100)
)
AS
	UPDATE UNIT 
	SET UnitName = @UnitName
	WHERE UnitID = @UnitID




GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllCustomer]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAllCustomer]

AS
	SELECT  CustomerID, CustomerName,
			CASE Gender
				 WHEN 0 THEN N'Nữ' 
				 WHEN 1 THEN N'Nam'
				 ELSE N'Khác'
			END AS Gender, 
			DateOfBirth, Address, 
			PhoneNumber, Email, IDNumber
	FROM CUSTOMER




GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllOrder]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAllOrder]
AS
	SELECT  A.OrderID, 
		B.CustomerName, 
		(SELECT COUNT(*) FROM ORDERDETAIL WHERE ORDERDETAIL.OrderID = A.OrderID) AS RoomNumber, 
		A.NumberOfPeople, 
		A.OrderOfDate, 
		(SELECT COUNT(Estimate) FROM ORDERDETAIL WHERE ORDERDETAIL.OrderID = A.OrderID) AS TotalRoom, 
		(SELECT COUNT(ServicesMoney) FROM ORDERDETAIL WHERE ORDERDETAIL.OrderID = A.OrderID) AS TotalService, 
		A.Deposit, 
		A.Total, 
		A.OrderStatus, 
		C.StaffName FROM [ORDER] AS A 
	INNER JOIN CUSTOMER AS B 
		ON A.CustomerID=B.CustomerID 
	INNER JOIN STAFF AS C 
		ON A.StaffID=C.StaffID;




GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllOrderByNumberID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetAllOrderByNumberID]
	@CustomerID char(10),
	@IDNumber nvarchar(11)
AS
BEGIN
	SELECT O.OrderID, C.CustomerName, C.IDNumber, O.OrderOfDate, S.StaffName, O.NumberOfPeople, O.OrderStatus, O.Total,
		CASE
			WHEN O.OrderStatus = 0 THEN 'Chưa thanh toán' 
			WHEN O.OrderStatus = 1 THEN 'Đã thanh toán'
			WHEN O.OrderStatus = -1 THEN 'Đã hủy'
		END
		AS OrderStatusName
	FROM [ORDER] O
				INNER JOIN CUSTOMER C ON O.CustomerID = C.CustomerID
				INNER JOIN STAFF S ON O.StaffID = S.StaffID 
	WHERE C.CustomerID = @CustomerID OR C.IDNumber Like @IDNumber
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllOrderByOderID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetAllOrderByOderID]
 @OrderID char(10)
AS
BEGIN
 SELECT OD.OrderDetailID, R.RoomID, R.RoomName, RT.RoomTypeName, OD.StartDate, OD.EndDate, R.NumberOfBeds, RT.Price, OD.Estimate, OD.ServicesMoney, DATEDIFF(dd, OD.StartDate, OD.EndDate) AS Quantity,(DATEDIFF(dd, OD.StartDate, OD.EndDate) * RT.Price) AS Monetized
 FROM [dbo].[ORDERDETAIL] AS OD
        INNER JOIN ROOM AS R ON OD.RoomID = R.RoomID
        INNER JOIN ROOMTYPE AS RT ON R.RoomTypeID = RT.RoomTypeID
        INNER JOIN [STATUS] AS S ON R.StatusID = S.StatusID
 WHERE OrderID = @OrderID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllOrderDetailFromNow]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetAllOrderDetailFromNow]

AS
	SELECT A.RoomID, A.OrderDetailID,  C.CustomerName AS CustomerName, A.ServicesMoney AS ServicesMoney
	FROM ORDERDETAIL AS A 
		INNER JOIN [ORDER] AS B 
			ON A.OrderID=B.OrderID 
		INNER JOIN CUSTOMER AS C
			ON B.CustomerID=C.CustomerID;



GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllRolePermission]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAllRolePermission]

AS
	SELECT *
	FROM ROLEPERMISSION




GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllRoom]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAllRoom]
AS
	SELECT RoomID, RoomName, ROOM.RoomTypeID, ROOMTYPE.RoomTypeName, NumberOfBeds, Description, ROOM.StatusID, STATUS.StatusName
	FROM ROOM, ROOMTYPE, STATUS WHERE ROOM.RoomTypeID=ROOMTYPE.RoomTypeID AND ROOM.StatusID = STATUS.StatusID




GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllRoomByDateFromTo]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetAllRoomByDateFromTo]
(
 @DateFrom date,
 @DateTo date
)
AS
 SELECT * FROM ROOM AS A INNER JOIN ROOMTYPE AS B ON A.RoomTypeID=B.RoomTypeID INNER JOIN [STATUS] AS S ON A.StatusID = S.StatusID WHERE 
  (SELECT COUNT(*) FROM ORDERDETAIL AS C 
  WHERE  
   CONVERT (date, C.EndDate) >= CONVERT (date, GETDATE()) 
   AND RoomID=A.RoomID
   AND (((CONVERT (date, @DateFrom) <= CONVERT (date, C.EndDate) AND CONVERT (date, @DateTo) >= CONVERT (date, C.EndDate))
   OR(CONVERT (date, @DateTo) >= CONVERT (date, C.StartDate) AND CONVERT (date, @DateTo) <= CONVERT (date, C.EndDate)))
   OR(CONVERT (date, @DateFrom) >= CONVERT (date, C.StartDate) AND CONVERT (date, @DateTo) <= CONVERT (date, C.EndDate)))) = 0


GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllRoomType]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetAllRoomType]
AS
	SELECT RoomTypeID, RoomTypeName, Price
	FROM 
		ROOMTYPE



GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllRoomWithDate]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAllRoomWithDate]

AS
	SELECT RoomID, RoomName, (SELECT TOP 1 ORDERDETAIL.StartDate FROM ORDERDETAIL WHERE ORDERDETAIL.RoomID=ROOM.RoomID ORDER BY ORDERDETAIL.StartDate) AS StartDate, (SELECT TOP 1 ORDERDETAIL.EndDate FROM ORDERDETAIL WHERE ORDERDETAIL.RoomID=ROOM.RoomID ORDER BY ORDERDETAIL.StartDate) AS EndDate, ROOM.RoomTypeID, ROOMTYPE.RoomTypeName, NumberOfBeds, Description, ROOM.StatusID, STATUS.StatusName
	FROM ROOM, ROOMTYPE, STATUS WHERE ROOM.RoomTypeID=ROOMTYPE.RoomTypeID AND ROOM.StatusID = STATUS.StatusID


GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllRule]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAllRule]
AS
	SELECT  Id, Label, Value
	FROM [RULE]




GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllServiceDetail]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[sp_GetAllServiceDetail]
AS
	SELECT *
	FROM 
		SERVICEDETAIL AS A INNER JOIN SERVICES AS B ON A.ServicesID=B.ServicesID;
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllServiceDetailByOrderID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetAllServiceDetailByOrderID]
(
	@OrderID nvarchar(10)
)
AS
	SELECT *
	FROM 
		SERVICEDETAIL AS A INNER JOIN SERVICES AS B ON A.ServicesID=B.ServicesID WHERE A.OrderDetailID=@OrderID;


GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllServices]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAllServices]
AS
	SELECT ServicesID, ServicesName, SERVICES.ServicesTypeID, SERVICESTYPE.ServicesTypeName, Price, SERVICES.UnitID, UNIT.UnitName
	FROM SERVICES, SERVICESTYPE, UNIT WHERE SERVICES.ServicesTypeID=SERVICESTYPE.ServicesTypeID AND SERVICES.UnitID = UNIT.UnitID




GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllServicesType]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAllServicesType]
AS
	SELECT ServicesTypeID, ServicesTypeName
	FROM SERVICESTYPE




GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllStaff]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllStatus]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAllStatus]
AS
	SELECT StatusID, StatusName
	FROM STATUS




GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllUnit]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAllUnit]
AS
	SELECT UnitID, UnitName
	FROM UNIT




GO
/****** Object:  StoredProcedure [dbo].[sp_GetCustomerByID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetCustomerByID]
(
	@CustomerId nvarchar(10)
)
AS
	SELECT  CustomerID, CustomerName,
			CASE Gender
				 WHEN 0 THEN N'Nữ' 
				 WHEN 1 THEN N'Nam'
				 ELSE N'Khác'
			END AS Gender, 
			DateOfBirth, Address, 
			PhoneNumber, Email, IDNumber
	FROM CUSTOMER 
	WHERE CustomerID = @CustomerId




GO
/****** Object:  StoredProcedure [dbo].[sp_GetCustomerByOrderID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetCustomerByOrderID]
(
	@Id nvarchar(10)
)
AS
	SELECT  B.CustomerID
	FROM ORDERDETAIL AS A INNER JOIN [ORDER] AS B ON A.OrderID=B.OrderID
	WHERE A.OrderDetailID = @Id


GO
/****** Object:  StoredProcedure [dbo].[sp_GetDataOrderDetailById]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetDataOrderDetailById]
(
	@OrderDetailID nvarchar(10)
)

AS
	SELECT * FROM ORDERDETAIL 
	WHERE OrderDetailID = @OrderDetailID

RETURN



GO
/****** Object:  StoredProcedure [dbo].[sp_GetOrderByID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetOrderByID]
	@OrderID char(10)
AS
BEGIN
	SELECT * FROM [dbo].[ORDER] AS O
	INNER JOIN CUSTOMER AS C ON O.CustomerID = C.CustomerID
	INNER JOIN STAFF AS S ON O.StaffID = S.StaffID
	WHERE OrderID = @OrderID
END


GO
/****** Object:  StoredProcedure [dbo].[sp_GetOrderIDByOrderDetailID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetOrderIDByOrderDetailID]
(
	@Id nvarchar(10)
)
AS
	SELECT  B.OrderID
	FROM ORDERDETAIL AS A INNER JOIN [ORDER] AS B ON A.OrderID=B.OrderID
	WHERE A.OrderDetailID = @Id


GO
/****** Object:  StoredProcedure [dbo].[sp_GetOrderMaxID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetOrderMaxID]
AS
BEGIN
	SELECT Max(OrderID) as OrderMaxID from [dbo].[ORDER]
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetRevenueReportByFromTo]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetRevenueReportByFromTo]
(
	@From date,
	@To date
)
AS
	SELECT A.RoomID, 
		(SELECT ROOM.RoomName FROM ROOM WHERE ROOM.RoomID=A.RoomID) AS RoomName,
		SUM(DATEDIFF(dd, A.StartDate, A.EndDate)) AS QTY , 
		(SELECT C.Price FROM ROOMTYPE AS C INNER JOIN ROOM AS B ON C.RoomTypeID=B.RoomTypeID WHERE B.RoomID=A.RoomID) AS Price,
		(SUM(DATEDIFF(dd, A.StartDate, A.EndDate))*(SELECT C.Price FROM ROOMTYPE AS C INNER JOIN ROOM AS B ON C.RoomTypeID=B.RoomTypeID WHERE B.RoomID=A.RoomID)) AS Total
FROM ORDERDETAIL AS A 
WHERE A.StartDate BETWEEN @From AND @To
group by A.RoomID


GO
/****** Object:  StoredProcedure [dbo].[sp_GetRevenueReportByMY]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetRevenueReportByMY]
(
	@M nvarchar(10),
	@Y nvarchar(10)
)
AS
	SELECT A.RoomID, 
		(SELECT ROOM.RoomName FROM ROOM WHERE ROOM.RoomID=A.RoomID) AS RoomName,
		SUM(DATEDIFF(dd, A.StartDate, A.EndDate)) AS QTY , 
		(SELECT C.Price FROM ROOMTYPE AS C INNER JOIN ROOM AS B ON C.RoomTypeID=B.RoomTypeID WHERE B.RoomID=A.RoomID) AS Price,
		(SUM(DATEDIFF(dd, A.StartDate, A.EndDate))*(SELECT C.Price FROM ROOMTYPE AS C INNER JOIN ROOM AS B ON C.RoomTypeID=B.RoomTypeID WHERE B.RoomID=A.RoomID)) AS Total
FROM ORDERDETAIL AS A 
WHERE MONTH(A.StartDate)=@M AND YEAR(A.StartDate)=@Y
group by A.RoomID


GO
/****** Object:  StoredProcedure [dbo].[sp_GetRevenueReportByY]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetRevenueReportByY]
(
	@Y nvarchar(10)
)
AS
	SELECT A.RoomID, 
		(SELECT ROOM.RoomName FROM ROOM WHERE ROOM.RoomID=A.RoomID) AS RoomName,
		SUM(DATEDIFF(dd, A.StartDate, A.EndDate)) AS QTY , 
		(SELECT C.Price FROM ROOMTYPE AS C INNER JOIN ROOM AS B ON C.RoomTypeID=B.RoomTypeID WHERE B.RoomID=A.RoomID) AS Price,
		(SUM(DATEDIFF(dd, A.StartDate, A.EndDate))*(SELECT C.Price FROM ROOMTYPE AS C INNER JOIN ROOM AS B ON C.RoomTypeID=B.RoomTypeID WHERE B.RoomID=A.RoomID)) AS Total
FROM ORDERDETAIL AS A 
WHERE YEAR(A.StartDate)=@Y
group by A.RoomID


GO
/****** Object:  StoredProcedure [dbo].[sp_GetRolePermissionByID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_GetRolePermissionNameByID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_GetRoomByID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetRoomByID]
(
	@RoomID nvarchar(10)
)
AS
	SELECT *
	FROM ROOM  
	Where ROOM.RoomID = @RoomID




GO
/****** Object:  StoredProcedure [dbo].[sp_GetRoomTypeByID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetRoomTypeByID]
(
	@RoomTypeID nvarchar(10)
)
AS
	SELECT RoomTypeID, RoomTypeName, Price
	FROM ROOMTYPE  
	Where ROOMTYPE.RoomTypeID = @RoomTypeID




GO
/****** Object:  StoredProcedure [dbo].[sp_GetRuleByID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_GetRuleByLabel]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_GetServiceDetailByID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetServiceDetailByID]
(
	@ServiceDetailID nvarchar(10)
)
AS
	SELECT *
	FROM SERVICEDETAIL AS A INNER JOIN SERVICES AS B ON A.ServicesID=B.ServicesID
	Where A.SevicesDetailID = @ServiceDetailID
GO
/****** Object:  StoredProcedure [dbo].[sp_GetServicesByID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetServicesByID]
(
	@ServicesID nvarchar(10)
)
AS
	SELECT ServicesID, ServicesName, SERVICES.ServicesTypeID, SERVICESTYPE.ServicesTypeName, Price, SERVICES.UnitID, UNIT.UnitName
	FROM SERVICES, SERVICESTYPE, UNIT WHERE SERVICES.ServicesTypeID=SERVICESTYPE.ServicesTypeID AND SERVICES.UnitID = UNIT.UnitID  
	AND SERVICES.ServicesID = @ServicesID
GO
/****** Object:  StoredProcedure [dbo].[sp_GetServicesTypeByID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetServicesTypeByID]
(
	@ServicesTypeID nvarchar(10)
)
AS
	SELECT ServicesTypeID, ServicesTypeName
	FROM SERVICESTYPE  
	Where SERVICESTYPE.ServicesTypeID = @ServicesTypeID




GO
/****** Object:  StoredProcedure [dbo].[sp_GetStaffById]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_GetStaffByUserName]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_GetStatusByID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetStatusByID]
(
	@StatusID nvarchar(10)
)
AS
	SELECT StatusID, StatusName
	FROM STATUS  
	Where STATUS.StatusID = @StatusID




GO
/****** Object:  StoredProcedure [dbo].[sp_GetUnitByID]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetUnitByID]
(
	@UnitID nvarchar(10)
)
AS
	SELECT UnitID, UnitName
	FROM UNIT  
	Where UNIT.UnitID = @UnitID




GO
/****** Object:  StoredProcedure [dbo].[sp_LookAtCustomerByIdDataFromDatabase]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_LookAtCustomerByIdDataFromDatabase]
(
	@CustomerId nvarchar(10)
)

AS
	SELECT  CustomerID, CustomerName,
			CASE Gender
				 WHEN 0 THEN N'Nữ' 
				 WHEN 1 THEN N'Nam'
				 ELSE N'Khác'
			END AS Gender, 
			DateOfBirth, Address, 
			PhoneNumber, Email, IDNumber
	
	FROM CUSTOMER 
	WHERE CustomerID like '%'+@CustomerId+'%'

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_LookAtCustomerByNameDataFromDatabase]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_LookAtCustomerByNameDataFromDatabase]
(
	@CustomerName nvarchar(100)
)

AS
	SELECT  CustomerID, CustomerName,
			CASE Gender
				 WHEN 0 THEN N'Nữ' 
				 WHEN 1 THEN N'Nam'
				 ELSE N'Khác'
			END AS Gender, 
			DateOfBirth, Address, 
			PhoneNumber, Email, IDNumber
	FROM CUSTOMER 
	WHERE CustomerName like '%'+@CustomerName+'%'

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_LookAtRolePermissionDataFromDatabase]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_LookAtRoomDataFromDatabase]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* ROOM */


CREATE PROCEDURE [dbo].[sp_LookAtRoomDataFromDatabase]
(
	@RoomName nvarchar(100)
)

AS
	SELECT RoomID, RoomName, ROOM.RoomTypeID, ROOMTYPE.RoomTypeName, NumberOfBeds, Description, ROOM.StatusID, STATUS.StatusName
	FROM ROOM, ROOMTYPE, STATUS WHERE ROOM.RoomTypeID=ROOMTYPE.RoomTypeID AND ROOM.StatusID = STATUS.StatusID AND RoomName like '%'+@RoomName+'%'

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_LookAtRoomTypeDataFromDatabase]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE PROCEDURE [dbo].[sp_LookAtRoomTypeDataFromDatabase]
(
	@RoomTypeName nvarchar(100)
)

AS
	SELECT * 
	FROM ROOMTYPE 
	WHERE RoomTypeName like '%'+@RoomTypeName+'%'

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_LookAtServicesDataFromDatabase]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* SERVICES */


CREATE PROCEDURE [dbo].[sp_LookAtServicesDataFromDatabase]
(
	@ServicesName nvarchar(100)
)

AS
	SELECT ServicesID, ServicesName, SERVICES.ServicesTypeID, SERVICESTYPE.ServicesTypeName, Price, SERVICES.UnitID, UNIT.UnitName
	FROM SERVICES, SERVICESTYPE, UNIT WHERE SERVICES.ServicesTypeID=SERVICESTYPE.ServicesTypeID AND SERVICES.UnitID = UNIT.UnitID AND ServicesName like '%'+@ServicesName+'%'

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_LookAtServicesTypeDataFromDatabase]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Service Type */

CREATE PROCEDURE [dbo].[sp_LookAtServicesTypeDataFromDatabase]
(
	@ServicesTypeName nvarchar(100)
)

AS
	SELECT * 
	FROM SERVICESTYPE 
	WHERE ServicesTypeName like '%'+@ServicesTypeName+'%'

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_LookAtStaffByIdDataFromDatabase]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_LookAtStaffByNameDataFromDatabase]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_LookAtStatusDataFromDatabase]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* STATUS */

CREATE PROCEDURE [dbo].[sp_LookAtStatusDataFromDatabase]
(
	@StatusName nvarchar(100)
)

AS
	SELECT * 
	FROM STATUS 
	WHERE StatusName like '%'+@StatusName+'%'

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_LookAtUnitDataFromDatabase]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* UNIT */


CREATE PROCEDURE [dbo].[sp_LookAtUnitDataFromDatabase]
(
	@UnitName nvarchar(100)
)

AS
	SELECT * 
	FROM UNIT 
	WHERE UnitName like '%'+@UnitName+'%'

RETURN




GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateServiceMoneyOrderDetailById]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateServiceMoneyOrderDetailById]
(
	@OrderDetailID nvarchar(10),
	@ServiceMoney int
)

AS
	UPDATE ORDERDETAIL SET ServicesMoney=@ServiceMoney
	WHERE OrderDetailID = @OrderDetailID

RETURN



GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateTotalOrderById]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateTotalOrderById]
(
	@OrderID nvarchar(10)
)

AS
	UPDATE [ORDER] SET Total = (SELECT sum(ServicesMoney) TotalService FROM ORDERDETAIL WHERE OrderID=@OrderID)+Estimate
	WHERE OrderID = @OrderID

RETURN


GO
/****** Object:  Table [dbo].[BILLDETAIL]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILLDETAIL](
	[BillID] [nchar](10) NOT NULL,
	[OrderID] [nchar](10) NULL,
	[BillDate] [date] NULL,
	[StaffID] [nchar](10) NULL,
	[Total] [int] NULL,
 CONSTRAINT [PK_BILLDETAIL] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[CustomerID] [nchar](10) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[IDNumber] [nvarchar](10) NULL,
	[PhoneNumber] [nvarchar](11) NULL,
	[Address] [nvarchar](255) NULL,
	[Gender] [bit] NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ORDER]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER](
	[OrderID] [nchar](10) NOT NULL,
	[CustomerID] [nchar](10) NULL,
	[StaffID] [nchar](10) NULL,
	[OrderOfDate] [smalldatetime] NULL,
	[NumberOfPeople] [int] NULL,
	[Estimate] [int] NULL,
	[Deposit] [int] NULL,
	[Total] [int] NULL,
	[OrderStatus] [int] NULL,
 CONSTRAINT [PK_ORDER] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ORDERDETAIL]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDERDETAIL](
	[OrderDetailID] [nchar](10) NOT NULL,
	[OrderID] [nchar](10) NULL,
	[RoomID] [nchar](10) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[Estimate] [int] NULL,
	[ServicesMoney] [int] NULL,
 CONSTRAINT [PK_ORDERDETAIL] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ROLEPERMISSION]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[ROOM]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROOM](
	[RoomID] [nchar](10) NOT NULL,
	[RoomName] [nvarchar](50) NULL,
	[RoomTypeID] [nchar](10) NULL,
	[NumberOfBeds] [int] NULL,
	[Description] [nvarchar](255) NULL,
	[StatusID] [nchar](10) NULL,
 CONSTRAINT [PK_ROOM] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ROOMTYPE]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROOMTYPE](
	[RoomTypeID] [nchar](10) NOT NULL,
	[RoomTypeName] [nvarchar](50) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_ROOMTYPE] PRIMARY KEY CLUSTERED 
(
	[RoomTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RULE]    Script Date: 8/24/2015 10:36:34 PM ******/
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
/****** Object:  Table [dbo].[SERVICEDETAIL]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICEDETAIL](
	[SevicesDetailID] [nchar](10) NOT NULL,
	[OrderDetailID] [nchar](10) NULL,
	[ServicesID] [nchar](10) NULL,
	[Quantity] [int] NULL,
	[Monetized] [int] NULL,
 CONSTRAINT [PK_SERVICEDETAIL] PRIMARY KEY CLUSTERED 
(
	[SevicesDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SERVICES]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICES](
	[ServicesTypeID] [nchar](10) NULL,
	[ServicesID] [nchar](10) NOT NULL,
	[ServicesName] [nvarchar](100) NULL,
	[UnitID] [nchar](10) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_SERVICES] PRIMARY KEY CLUSTERED 
(
	[ServicesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SERVICESTYPE]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICESTYPE](
	[ServicesTypeID] [nchar](10) NOT NULL,
	[ServicesTypeName] [nvarchar](100) NULL,
 CONSTRAINT [PK_SERVICE] PRIMARY KEY CLUSTERED 
(
	[ServicesTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[STAFF]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STAFF](
	[StaffID] [nchar](10) NOT NULL,
	[StaffName] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[PhoneNumber] [nchar](11) NULL,
	[Address] [nvarchar](255) NULL,
	[Sex] [bit] NULL,
	[Email] [nvarchar](100) NULL,
	[DateCreated] [smalldatetime] NOT NULL,
	[RolePermissionID] [nvarchar](10) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_STAFF] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[STATUS]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STATUS](
	[StatusID] [nchar](10) NOT NULL,
	[StatusName] [nvarchar](20) NULL,
 CONSTRAINT [PK_STATUS] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UNIT]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNIT](
	[UnitID] [nchar](10) NOT NULL,
	[UnitName] [nvarchar](50) NULL,
 CONSTRAINT [PK_UNIT] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[BILLDETAIL]  WITH CHECK ADD  CONSTRAINT [FK_BILLDETAIL_ORDER] FOREIGN KEY([OrderID])
REFERENCES [dbo].[ORDER] ([OrderID])
GO
ALTER TABLE [dbo].[BILLDETAIL] CHECK CONSTRAINT [FK_BILLDETAIL_ORDER]
GO
ALTER TABLE [dbo].[BILLDETAIL]  WITH CHECK ADD  CONSTRAINT [FK_BILLDETAIL_STAFF] FOREIGN KEY([StaffID])
REFERENCES [dbo].[STAFF] ([StaffID])
GO
ALTER TABLE [dbo].[BILLDETAIL] CHECK CONSTRAINT [FK_BILLDETAIL_STAFF]
GO
ALTER TABLE [dbo].[ORDER]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_CUSTOMER] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[CUSTOMER] ([CustomerID])
GO
ALTER TABLE [dbo].[ORDER] CHECK CONSTRAINT [FK_ORDER_CUSTOMER]
GO
ALTER TABLE [dbo].[ORDER]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_STAFF] FOREIGN KEY([StaffID])
REFERENCES [dbo].[STAFF] ([StaffID])
GO
ALTER TABLE [dbo].[ORDER] CHECK CONSTRAINT [FK_ORDER_STAFF]
GO
ALTER TABLE [dbo].[ORDERDETAIL]  WITH CHECK ADD  CONSTRAINT [FK_ORDERDETAIL_ORDER] FOREIGN KEY([OrderID])
REFERENCES [dbo].[ORDER] ([OrderID])
GO
ALTER TABLE [dbo].[ORDERDETAIL] CHECK CONSTRAINT [FK_ORDERDETAIL_ORDER]
GO
ALTER TABLE [dbo].[ORDERDETAIL]  WITH CHECK ADD  CONSTRAINT [FK_ORDERDETAIL_ROOM] FOREIGN KEY([RoomID])
REFERENCES [dbo].[ROOM] ([RoomID])
GO
ALTER TABLE [dbo].[ORDERDETAIL] CHECK CONSTRAINT [FK_ORDERDETAIL_ROOM]
GO
ALTER TABLE [dbo].[ROOM]  WITH CHECK ADD  CONSTRAINT [FK_ROOM_ROOMTYPE] FOREIGN KEY([RoomTypeID])
REFERENCES [dbo].[ROOMTYPE] ([RoomTypeID])
GO
ALTER TABLE [dbo].[ROOM] CHECK CONSTRAINT [FK_ROOM_ROOMTYPE]
GO
ALTER TABLE [dbo].[ROOM]  WITH CHECK ADD  CONSTRAINT [FK_ROOM_STATUS] FOREIGN KEY([StatusID])
REFERENCES [dbo].[STATUS] ([StatusID])
GO
ALTER TABLE [dbo].[ROOM] CHECK CONSTRAINT [FK_ROOM_STATUS]
GO
ALTER TABLE [dbo].[SERVICEDETAIL]  WITH CHECK ADD  CONSTRAINT [FK_SERVICEDETAIL_ORDERDETAIL] FOREIGN KEY([OrderDetailID])
REFERENCES [dbo].[ORDERDETAIL] ([OrderDetailID])
GO
ALTER TABLE [dbo].[SERVICEDETAIL] CHECK CONSTRAINT [FK_SERVICEDETAIL_ORDERDETAIL]
GO
ALTER TABLE [dbo].[SERVICEDETAIL]  WITH CHECK ADD  CONSTRAINT [FK_SERVICEDETAIL_SERVICES] FOREIGN KEY([ServicesID])
REFERENCES [dbo].[SERVICES] ([ServicesID])
GO
ALTER TABLE [dbo].[SERVICEDETAIL] CHECK CONSTRAINT [FK_SERVICEDETAIL_SERVICES]
GO
ALTER TABLE [dbo].[SERVICES]  WITH CHECK ADD  CONSTRAINT [FK_SERVICES_UNIT] FOREIGN KEY([UnitID])
REFERENCES [dbo].[UNIT] ([UnitID])
GO
ALTER TABLE [dbo].[SERVICES] CHECK CONSTRAINT [FK_SERVICES_UNIT]
GO
ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD  CONSTRAINT [FK_STAFF_ROLEPERMISSION] FOREIGN KEY([RolePermissionID])
REFERENCES [dbo].[ROLEPERMISSION] ([RolePermissionID])
GO
ALTER TABLE [dbo].[STAFF] CHECK CONSTRAINT [FK_STAFF_ROLEPERMISSION]
GO
/****** Object:  Trigger [dbo].[NV_AutoIncrementCustomerId]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[NV_AutoIncrementCustomerId]
ON [dbo].[CUSTOMER]
FOR INSERT
AS
BEGIN
 DECLARE @MAXValue VARCHAR(10),@NEWValue VARCHAR(10),@NEW_ID VARCHAR(10), @OLD_ID VARCHAR(10);
 --Lấy giá trị lớn nhất 
 IF ((SELECT COUNT(CustomerID) FROM CUSTOMER)>1)
  BEGIN
   SELECT @MAXValue=MAX(CustomerID) FROM CUSTOMER;
  END
 ELSE
  BEGIN
   SET @MAXValue='KH0000000';
  END
 --Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
 select @OLD_ID = CustomerID from INSERTED
 --Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
 SET @NEWValue= REPLACE(@MaxValue,'KH','')+1
 -- Kiểm tra NEWValue nếu < 100
 -- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 9
 SET @NEW_ID = 'KH'+
  CASE
     WHEN LEN(@NEWValue)<7
     THEN REPLICATE('0',7-LEN(@newValue))
     ELSE ''
     END +
     @NEWValue
 --Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
 UPDATE CUSTOMER SET CustomerID = @NEW_ID WHERE CustomerID = @OLD_ID
END


GO
/****** Object:  Trigger [dbo].[NV_AutoIncrementOrderId]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[NV_AutoIncrementOrderId]
ON [dbo].[ORDER]
FOR INSERT
AS
BEGIN
 DECLARE @MAXValue VARCHAR(10),@NEWValue VARCHAR(10),@NEW_ID VARCHAR(10), @OLD_ID VARCHAR(10);
 --L?y giá tr? l?n nh?t 
 IF ((SELECT COUNT(OrderID) FROM [ORDER])>1)
  BEGIN
   SELECT @MAXValue=MAX(OrderID) FROM [ORDER];
  END
 ELSE
  BEGIN
   SET @MAXValue='DP0000000';
  END
 --L?y giá tr? ID du?c chèn vào t? bên ngoài (b?t kì, không quan tr?ng)
 select @OLD_ID = OrderID from INSERTED
 --L?y ph?n chu?i s? d?ng sau TL r?i tang lên 1 don v?
 SET @NEWValue= REPLACE(@MaxValue,'DP','')+1
 -- Ki?m tra NEWValue n?u < 100
 -- N?u <100, thêm vào s? 0 sao cho NEWValue có d? dài = 9
 SET @NEW_ID = 'DP'+
  CASE
     WHEN LEN(@NEWValue)<7
     THEN REPLICATE('0',7-LEN(@newValue))
     ELSE ''
     END +
     @NEWValue
 --Thay th? giá tr? Id t? bên ngoài b?ng Id v?a du?c t?o
 UPDATE [ORDER] SET OrderID = @NEW_ID WHERE OrderID = @OLD_ID
END
GO
/****** Object:  Trigger [dbo].[NV_AutoIncrementOrderDetailId]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[NV_AutoIncrementOrderDetailId]
ON [dbo].[ORDERDETAIL]
FOR INSERT
AS
BEGIN
 DECLARE @MAXValue VARCHAR(10),@NEWValue VARCHAR(10),@NEW_ID VARCHAR(10), @OLD_ID VARCHAR(10);
 --L?y giá tr? l?n nh?t 
 IF ((SELECT COUNT(OrderDetailID) FROM [ORDERDETAIL])>1)
  BEGIN
   SELECT @MAXValue=MAX(OrderDetailID) FROM [ORDERDETAIL];
  END
 ELSE
  BEGIN
   SET @MAXValue='CDP0000000';
  END
 --L?y giá tr? ID du?c chèn vào t? bên ngoài (b?t kì, không quan tr?ng)
 select @OLD_ID = OrderDetailID from INSERTED
 --L?y ph?n chu?i s? d?ng sau TL r?i tang lên 1 don v?
 SET @NEWValue= REPLACE(@MaxValue,'CDP','')+1
 -- Ki?m tra NEWValue n?u < 100
 -- N?u <100, thêm vào s? 0 sao cho NEWValue có d? dài = 9
 SET @NEW_ID = 'CDP'+
  CASE
     WHEN LEN(@NEWValue)<7
     THEN REPLICATE('0',7-LEN(@newValue))
     ELSE ''
     END +
     @NEWValue
 --Thay th? giá tr? Id t? bên ngoài b?ng Id v?a du?c t?o
 UPDATE [ORDERDETAIL] SET OrderDetailID = @NEW_ID WHERE OrderDetailID = @OLD_ID
END

GO
/****** Object:  Trigger [dbo].[NV_AutoIncrementRoomId]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[NV_AutoIncrementRoomId]
ON [dbo].[ROOM]
FOR INSERT
AS
BEGIN
 DECLARE @MAXValue VARCHAR(10),@NEWValue VARCHAR(10),@NEW_ID VARCHAR(10), @OLD_ID VARCHAR(10);
 --Lấy giá trị lớn nhất 
 IF ((SELECT COUNT(RoomID) FROM ROOM)>1)
  BEGIN
   SELECT @MAXValue=MAX(RoomID) FROM ROOM;
  END
 ELSE
  BEGIN
   SET @MAXValue='PH0000000';
  END
 --Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
 select @OLD_ID = RoomID from INSERTED
 --Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
 SET @NEWValue= REPLACE(@MaxValue,'PH','')+1
 -- Kiểm tra NEWValue nếu < 100
 -- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 9
 SET @NEW_ID = 'PH'+
  CASE
     WHEN LEN(@NEWValue)<7
     THEN REPLICATE('0',7-LEN(@newValue))
     ELSE ''
     END +
     @NEWValue
 --Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
 UPDATE ROOM SET RoomID = @NEW_ID WHERE RoomID = @OLD_ID
END


GO
/****** Object:  Trigger [dbo].[NV_AutoIncrementRoomTypeId]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[NV_AutoIncrementRoomTypeId]
ON [dbo].[ROOMTYPE]
FOR INSERT
AS
BEGIN
 DECLARE @MAXValue VARCHAR(10),@NEWValue VARCHAR(10),@NEW_ID VARCHAR(10), @OLD_ID VARCHAR(10);
 --Lấy giá trị lớn nhất 
 IF ((SELECT COUNT(RoomTypeID) FROM ROOMTYPE)>1)
  BEGIN
   SELECT @MAXValue=MAX(RoomTypeID) FROM ROOMTYPE;
  END
 ELSE
  BEGIN
   SET @MAXValue='LP0000000';
  END
 --Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
 select @OLD_ID = RoomTypeID from INSERTED
 --Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
 SET @NEWValue= REPLACE(@MaxValue,'LP','')+1
 -- Kiểm tra NEWValue nếu < 100
 -- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 9
 SET @NEW_ID = 'LP'+
  CASE
     WHEN LEN(@NEWValue)<7
     THEN REPLICATE('0',7-LEN(@newValue))
     ELSE ''
     END +
     @NEWValue
 --Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
 UPDATE ROOMTYPE SET RoomTypeID = @NEW_ID WHERE RoomTypeID = @OLD_ID
END


GO
/****** Object:  Trigger [dbo].[NV_AutoIncrementServiceDetailId]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[NV_AutoIncrementServiceDetailId]
ON [dbo].[SERVICEDETAIL]
FOR INSERT
AS
BEGIN
 DECLARE @MAXValue VARCHAR(10),@NEWValue VARCHAR(10),@NEW_ID VARCHAR(10), @OLD_ID VARCHAR(10);
 --Lấy giá trị lớn nhất 
 IF ((SELECT COUNT(SevicesDetailID) FROM SERVICEDETAIL)>1)
  BEGIN
   SELECT @MAXValue=MAX(SevicesDetailID) FROM SERVICEDETAIL;
  END
 ELSE
  BEGIN
   SET @MAXValue='DVC0000000';
  END
 --Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
 select @OLD_ID = SevicesDetailID from INSERTED
 --Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
 SET @NEWValue= REPLACE(@MaxValue,'DVC','')+1
 -- Kiểm tra NEWValue nếu < 100
 -- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 9
 SET @NEW_ID = 'DVC'+
  CASE
     WHEN LEN(@NEWValue)<7
     THEN REPLICATE('0',7-LEN(@newValue))
     ELSE ''
     END +
     @NEWValue
 --Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
 UPDATE SERVICEDETAIL SET SevicesDetailID = @NEW_ID WHERE SevicesDetailID = @OLD_ID
END


GO
/****** Object:  Trigger [dbo].[NV_AutoIncrementServicesId]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[NV_AutoIncrementServicesId]
ON [dbo].[SERVICES]
FOR INSERT
AS
BEGIN
 DECLARE @MAXValue VARCHAR(10),@NEWValue VARCHAR(10),@NEW_ID VARCHAR(10), @OLD_ID VARCHAR(10);
 --Lấy giá trị lớn nhất 
 IF ((SELECT COUNT(ServicesID) FROM SERVICES)>1)
  BEGIN
   SELECT @MAXValue=MAX(ServicesID) FROM SERVICES;
  END
 ELSE
  BEGIN
   SET @MAXValue='DV0000000';
  END
 --Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
 select @OLD_ID = ServicesID from INSERTED
 --Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
 SET @NEWValue= REPLACE(@MaxValue,'DV','')+1
 -- Kiểm tra NEWValue nếu < 100
 -- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 9
 SET @NEW_ID = 'DV'+
  CASE
     WHEN LEN(@NEWValue)<7
     THEN REPLICATE('0',7-LEN(@newValue))
     ELSE ''
     END +
     @NEWValue
 --Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
 UPDATE SERVICES SET ServicesID = @NEW_ID WHERE ServicesID = @OLD_ID
END


GO
/****** Object:  Trigger [dbo].[NV_AutoIncrementServicesTypeId]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[NV_AutoIncrementServicesTypeId]
ON [dbo].[SERVICESTYPE]
FOR INSERT
AS
BEGIN
 DECLARE @MAXValue VARCHAR(10),@NEWValue VARCHAR(10),@NEW_ID VARCHAR(10), @OLD_ID VARCHAR(10);
 --Lấy giá trị lớn nhất 
 IF ((SELECT COUNT(ServicesTypeID) FROM SERVICESTYPE)>1)
  BEGIN
   SELECT @MAXValue=MAX(ServicesTypeID) FROM SERVICESTYPE;
  END
 ELSE
  BEGIN
   SET @MAXValue='LDV0000000';
  END
 --Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
 select @OLD_ID = ServicesTypeID from INSERTED
 --Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
 SET @NEWValue= REPLACE(@MaxValue,'LDV','')+1
 -- Kiểm tra NEWValue nếu < 100
 -- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 9
 SET @NEW_ID = 'LDV'+
  CASE
     WHEN LEN(@NEWValue)<7
     THEN REPLICATE('0',7-LEN(@newValue))
     ELSE ''
     END +
     @NEWValue
 --Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
 UPDATE SERVICESTYPE SET ServicesTypeID = @NEW_ID WHERE ServicesTypeID = @OLD_ID
END


GO
/****** Object:  Trigger [dbo].[NV_AutoIncrementStaffId]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[NV_AutoIncrementStaffId]
ON [dbo].[STAFF]
FOR INSERT
AS
BEGIN
 DECLARE @MAXValue VARCHAR(10),@NEWValue VARCHAR(10),@NEW_ID VARCHAR(10), @OLD_ID VARCHAR(10);
 --Lấy giá trị lớn nhất 
 IF ((SELECT COUNT(StaffID) FROM STAFF)>1)
  BEGIN
   SELECT @MAXValue=MAX(StaffID) FROM STAFF;
  END
 ELSE
  BEGIN
   SET @MAXValue='NV0000000';
  END
 --Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
 select @OLD_ID = StaffID from INSERTED
 --Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
 SET @NEWValue= REPLACE(@MaxValue,'NV','')+1
 -- Kiểm tra NEWValue nếu < 100
 -- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 9
 SET @NEW_ID = 'NV'+
  CASE
     WHEN LEN(@NEWValue)<7
     THEN REPLICATE('0',7-LEN(@newValue))
     ELSE ''
     END +
     @NEWValue
 --Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
 UPDATE STAFF SET StaffID = @NEW_ID WHERE StaffID = @OLD_ID
END


GO
/****** Object:  Trigger [dbo].[NV_AutoIncrementStatusId]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[NV_AutoIncrementStatusId]
ON [dbo].[STATUS]
FOR INSERT
AS
BEGIN
 DECLARE @MAXValue VARCHAR(10),@NEWValue VARCHAR(10),@NEW_ID VARCHAR(10), @OLD_ID VARCHAR(10);
 --Lấy giá trị lớn nhất 
 IF ((SELECT COUNT(StatusID) FROM STATUS)>1)
  BEGIN
   SELECT @MAXValue=MAX(StatusID) FROM STATUS;
  END
 ELSE
  BEGIN
   SET @MAXValue='TT0000000';
  END
 --Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
 select @OLD_ID = StatusID from INSERTED
 --Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
 SET @NEWValue= REPLACE(@MaxValue,'TT','')+1
 -- Kiểm tra NEWValue nếu < 100
 -- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 9
 SET @NEW_ID = 'TT'+
  CASE
     WHEN LEN(@NEWValue)<7
     THEN REPLICATE('0',7-LEN(@newValue))
     ELSE ''
     END +
     @NEWValue
 --Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
 UPDATE STATUS SET StatusID = @NEW_ID WHERE StatusID = @OLD_ID
END


GO
/****** Object:  Trigger [dbo].[NV_AutoIncrementUnitId]    Script Date: 8/24/2015 10:36:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[NV_AutoIncrementUnitId]
ON [dbo].[UNIT]
FOR INSERT
AS
BEGIN
 DECLARE @MAXValue VARCHAR(10),@NEWValue VARCHAR(10),@NEW_ID VARCHAR(10), @OLD_ID VARCHAR(10);
 --Lấy giá trị lớn nhất 
 IF ((SELECT COUNT(UnitID) FROM UNIT)>1)
  BEGIN
   SELECT @MAXValue=MAX(UnitID) FROM UNIT;
  END
 ELSE
  BEGIN
   SET @MAXValue='DOV0000000';
  END
 --Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
 select @OLD_ID = UnitID from INSERTED
 --Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
 SET @NEWValue= REPLACE(@MaxValue,'DOV','')+1
 -- Kiểm tra NEWValue nếu < 100
 -- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 9
 SET @NEW_ID = 'DOV'+
  CASE
     WHEN LEN(@NEWValue)<7
     THEN REPLICATE('0',7-LEN(@newValue))
     ELSE ''
     END +
     @NEWValue
 --Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
 UPDATE UNIT SET UnitID = @NEW_ID WHERE UnitID = @OLD_ID
END


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'"Thành tiền"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SERVICEDETAIL', @level2type=N'COLUMN',@level2name=N'Monetized'
GO
