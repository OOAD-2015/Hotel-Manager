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
		ROOMTYPE


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

CREATE PROCEDURE [dbo].[sp_DeleteStatus]
(
	@StatusId nvarchar(10)
)

AS
	DELETE STATUS 
	WHERE StatusID = @StatusId

RETURN



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

CREATE PROCEDURE [dbo].[sp_AddNewStatusInsert]
(
	@StatusID nvarchar(10),
	@StatusName nvarchar(100)
)
AS
	INSERT INTO STATUS 
	VALUES(@StatusID,@StatusName)



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

CREATE PROCEDURE [dbo].[sp_GetAllStatus]
AS
	SELECT StatusID, StatusName
	FROM STATUS



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

CREATE PROCEDURE [dbo].[sp_DeleteUnit]
(
	@UnitId nvarchar(10)
)

AS
	DELETE UNIT 
	WHERE UnitID = @UnitId

RETURN



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

CREATE PROCEDURE [dbo].[sp_AddNewUnitInsert]
(
	@UnitID nvarchar(10),
	@UnitName nvarchar(100)
)
AS
	INSERT INTO UNIT 
	VALUES(@UnitID,@UnitName)



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

CREATE PROCEDURE [dbo].[sp_GetAllUnit]
AS
	SELECT UnitID, UnitName
	FROM UNIT



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

CREATE PROCEDURE [dbo].[sp_DeleteRoom]
(
	@RoomId nvarchar(10)
)

AS
	DELETE ROOM 
	WHERE RoomID = @RoomId

RETURN



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

CREATE PROCEDURE [dbo].[sp_GetRoomByID]
(
	@RoomID nvarchar(10)
)
AS
	SELECT *
	FROM ROOM  
	Where ROOM.RoomID = @RoomID



GO

CREATE PROCEDURE [dbo].[sp_GetAllRoom]
AS
	SELECT RoomID, RoomName, ROOM.RoomTypeID, ROOMTYPE.RoomTypeName, NumberOfBeds, Description, ROOM.StatusID, STATUS.StatusName
	FROM ROOM, ROOMTYPE, STATUS WHERE ROOM.RoomTypeID=ROOMTYPE.RoomTypeID AND ROOM.StatusID = STATUS.StatusID



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

CREATE PROCEDURE [dbo].[sp_DeleteServices]
(
	@ServicesId nvarchar(10)
)

AS
	DELETE SERVICES 
	WHERE ServicesID = @ServicesId

RETURN



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

CREATE PROCEDURE [dbo].[sp_GetServicesByID]
(
	@ServicesID nvarchar(10)
)
AS
	SELECT *
	FROM SERVICES  
	Where SERVICES.ServicesID = @ServicesID



GO

CREATE PROCEDURE [dbo].[sp_GetAllServices]
AS
	SELECT ServicesID, ServicesName, SERVICES.ServicesTypeID, SERVICESTYPE.ServicesTypeName, Price, SERVICES.UnitID, UNIT.UnitName
	FROM SERVICES, SERVICESTYPE, UNIT WHERE SERVICES.ServicesTypeID=SERVICESTYPE.ServicesTypeID AND SERVICES.UnitID = UNIT.UnitID



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