Use HotelManager;
GO

CREATE PROCEDURE [dbo].[sp_GetAllRoomWithDate]

AS
	SELECT RoomID, RoomName, (SELECT TOP 1 ORDERDETAIL.StartDate FROM ORDERDETAIL WHERE ORDERDETAIL.RoomID=ROOM.RoomID ORDER BY ORDERDETAIL.StartDate) AS StartDate, (SELECT TOP 1 ORDERDETAIL.EndDate FROM ORDERDETAIL WHERE ORDERDETAIL.RoomID=ROOM.RoomID ORDER BY ORDERDETAIL.StartDate) AS EndDate, ROOM.RoomTypeID, ROOMTYPE.RoomTypeName, NumberOfBeds, Description, ROOM.StatusID, STATUS.StatusName
	FROM ROOM, ROOMTYPE, STATUS WHERE ROOM.RoomTypeID=ROOMTYPE.RoomTypeID AND ROOM.StatusID = STATUS.StatusID

GO

-- Search Room Date From To
CREATE PROCEDURE [dbo].[sp_GetAllRoomByDateFromTo]
(
	@DateFrom date,
	@DateTo date
)
AS
	SELECT * FROM ROOM AS A INNER JOIN ROOMTYPE AS B ON A.RoomTypeID=B.RoomTypeID WHERE 
		(SELECT COUNT(*) FROM ORDERDETAIL AS C 
		WHERE  
			C.StartDate >= GETDATE() 
			AND RoomID=A.RoomID
			AND (((@DateFrom >= C.StartDate AND @DateFrom <= C.EndDate) OR (@DateFrom <= C.StartDate AND @DateFrom >= C.EndDate))
					OR ((@DateTo >= C.StartDate AND @DateTo <= C.EndDate) OR (@DateTo <= C.StartDate AND @DateTo >= C.EndDate)))) = 0

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

CREATE PROCEDURE [dbo].[sp_GetOrderByID]
(
	@OrderID nvarchar(10)
)
AS
	SELECT *
	FROM [ORDER]  
	Where [ORDER].OrderID = @OrderID



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

CREATE TRIGGER [dbo].[NV_AutoIncrementOrderId]
ON [dbo].[ORDER]
FOR INSERT
AS
BEGIN
 DECLARE @MAXValue VARCHAR(10),@NEWValue VARCHAR(10),@NEW_ID VARCHAR(10), @OLD_ID VARCHAR(10);
 --Lấy giá trị lớn nhất 
 IF ((SELECT COUNT(OrderID) FROM [ORDER])>1)
  BEGIN
   SELECT @MAXValue=MAX(OrderID) FROM [ORDER];
  END
 ELSE
  BEGIN
   SET @MAXValue='DH0000000';
  END
 --Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
 select @OLD_ID = OrderID from INSERTED
 --Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
 SET @NEWValue= REPLACE(@MaxValue,'DH','')+1
 -- Kiểm tra NEWValue nếu < 100
 -- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 9
 SET @NEW_ID = 'DH'+
  CASE
     WHEN LEN(@NEWValue)<7
     THEN REPLICATE('0',7-LEN(@newValue))
     ELSE ''
     END +
     @NEWValue
 --Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
 UPDATE [ORDER] SET OrderID = @NEW_ID WHERE OrderID = @OLD_ID
END

GO

/* -- SERVICE DETAILS -- */


CREATE PROCEDURE [dbo].[sp_DeleteServiceDetail]
(
	@ServiceDetailId nvarchar(10)
)

AS
	DELETE SERVICEDETAIL 
	WHERE SevicesDetailID = @ServiceDetailId

RETURN



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

CREATE PROCEDURE [dbo].[sp_GetServiceDetailByID]
(
	@ServiceDetailID nvarchar(10)
)
AS
	SELECT *
	FROM SERVICEDETAIL  
	Where SERVICEDETAIL.SevicesDetailID = @ServiceDetailID



GO

CREATE PROCEDURE [dbo].[sp_GetAllServiceDetail]
AS
	SELECT *
	FROM 
		SERVICEDETAIL


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

ALTER PROCEDURE [dbo].[sp_GetServicesByID]
(
	@ServicesID nvarchar(10)
)
AS
	SELECT ServicesID, ServicesName, SERVICES.ServicesTypeID, SERVICESTYPE.ServicesTypeName, Price, SERVICES.UnitID, UNIT.UnitName
	FROM SERVICES, SERVICESTYPE, UNIT WHERE SERVICES.ServicesTypeID=SERVICESTYPE.ServicesTypeID AND SERVICES.UnitID = UNIT.UnitID  
	AND SERVICES.ServicesID = @ServicesID


	--Update Store 
	go
	ALTER PROCEDURE [dbo].[sp_GetAllServiceDetail]
AS
	SELECT *
	FROM 
		SERVICEDETAIL AS A INNER JOIN SERVICES AS B ON A.ServicesID=B.ServicesID;
go


CREATE PROCEDURE [dbo].[sp_GetAllOrderDetailFromNow]

AS
	SELECT A.OrderDetailID, A.RoomID, C.CustomerName AS CustomerName, A.ServicesMoney AS ServicesMoney
	FROM ORDERDETAIL AS A 
		INNER JOIN [ORDER] AS B 
			ON A.OrderID=B.OrderID 
		INNER JOIN CUSTOMER AS C
			ON B.CustomerID=C.CustomerID;

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


CREATE PROCEDURE [dbo].[sp_DeleteAllServiceDetailByOrderID]
(
	@OrderDetailID nvarchar(10)
)

AS
	DELETE SERVICEDETAIL 
	WHERE OrderDetailID = @OrderDetailID

RETURN

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