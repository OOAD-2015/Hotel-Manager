Use HotelManager;
GO

INSERT [dbo].[RULE] ([Id], [Label], [Value]) VALUES (1, N'DoTuoiNhanVienToiThieu', N'18')
GO
INSERT [dbo].[RULE] ([Id], [Label], [Value]) VALUES (2, N'DoTuoiNhanVienToiDa', N'65')

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

/* Customer */
ALTER TABLE CUSTOMER DROP COLUMN Gender;

GO

ALTER TABLE CUSTOMER ADD Gender bit NULL;

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

ALTER TABLE [dbo].[CUSTOMER] ADD [Email] [nvarchar](100) NULL;

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

ALTER TABLE CUSTOMER DROP COLUMN DateOfBirth;

GO

ALTER TABLE CUSTOMER ADD DateOfBirth date NULL;

GO

ALTER TABLE CUSTOMER DROP COLUMN IDNumber;

GO

ALTER TABLE CUSTOMER ADD IDNumber nvarchar(10) NULL;

GO

ALTER TABLE CUSTOMER DROP COLUMN PhoneNumber;

GO

ALTER TABLE CUSTOMER ADD PhoneNumber nvarchar(11) NULL;

GO

ALTER TABLE CUSTOMER DROP COLUMN Address;

GO

ALTER TABLE CUSTOMER ADD Address nvarchar(255) NULL;

GO

ALTER TABLE CUSTOMER DROP COLUMN Gender;

GO

ALTER TABLE CUSTOMER ADD Gender bit NULL;

GO

ALTER TABLE CUSTOMER DROP COLUMN Email;

GO

ALTER TABLE CUSTOMER ADD Email nvarchar(100) NULL;

GO

/* RULE */

INSERT [dbo].[RULE] ([Id], [Label], [Value]) VALUES (3, N'ThueTNDN', N'100')
INSERT [dbo].[RULE] ([Id], [Label], [Value]) VALUES (4, N'TenKhachSan', N'Hotel')
INSERT [dbo].[RULE] ([Id], [Label], [Value]) VALUES (5, N'DiaChi', N'39 Võ Văn Ngân, Phường Bình Thọ, Quận Thủ Đức, Tp HCM')
INSERT [dbo].[RULE] ([Id], [Label], [Value]) VALUES (6, N'Email', N'hotel@hotel.com.vn')
INSERT [dbo].[RULE] ([Id], [Label], [Value]) VALUES (7, N'DienThoai', N'123456789')
INSERT [dbo].[RULE] ([Id], [Label], [Value]) VALUES (8, N'Fax', N'45789')
INSERT [dbo].[RULE] ([Id], [Label], [Value]) VALUES (9, N'MaSoThue', N'45789')
INSERT [dbo].[RULE] ([Id], [Label], [Value]) VALUES (10, N'Website', N'www.hotel.com.vn')

/* ROOM TYPE */
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

CREATE PROCEDURE [dbo].[sp_DeleteRoomType]
(
	@RoomTypeId nvarchar(10)
)

AS
	DELETE ROOMTYPE 
	WHERE RoomTypeID = @RoomTypeId

RETURN



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

CREATE PROCEDURE [dbo].[sp_GetRoomTypeByID]
(
	@RoomTypeID nvarchar(10)
)
AS
	SELECT RoomTypeID, RoomTypeName, Price
	FROM ROOMTYPE  
	Where ROOMTYPE.RoomTypeID = @RoomTypeID



GO

CREATE PROCEDURE [dbo].[sp_GetAllRoomType]
AS
	SELECT RoomTypeID, RoomTypeName, Price
	FROM 



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

CREATE PROCEDURE [dbo].[sp_DeleteServicesType]
(
	@ServicesTypeId nvarchar(10)
)

AS
	DELETE SERVICESTYPE 
	WHERE ServicesTypeID = @ServicesTypeId

RETURN



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

CREATE PROCEDURE [dbo].[sp_AddNewServicesTypeInsert]
(
	@ServicesTypeID nvarchar(10),
	@ServicesTypeName nvarchar(100)
)
AS
	INSERT INTO SERVICESTYPE 
	VALUES(@ServicesTypeID,@ServicesTypeName)



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

CREATE PROCEDURE [dbo].[sp_GetAllServicesType]
AS
	SELECT ServicesTypeID, ServicesTypeName
	FROM SERVICESTYPE



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
