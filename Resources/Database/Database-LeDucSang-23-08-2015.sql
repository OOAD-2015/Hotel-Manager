-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
SET DATEFORMAT dmy;
GO

--Order procedure
ALTER PROCEDURE sp_AddNewOrder
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

--Test
-- sp_AddNewOrder 'DP0000000', 'KH0000001', 'NV000001', '23-08-2015' ,0, 0, 0 , 0, 0

ALTER PROCEDURE sp_EditOrderUpdate
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

CREATE PROCEDURE sp_DeleteOrder
	@OrderID char(10)
AS
BEGIN
	Delete from [dbo].[ORDER] where OrderID = @OrderID
END
GO

CREATE PROCEDURE sp_GetOrderMaxID
AS
BEGIN
	SELECT Max(OrderID) as OrderMaxID from [dbo].[ORDER]
END
GO

ALTER PROCEDURE sp_AddNewOrderDetail
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

ALTER PROCEDURE sp_EditOrderDetail
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

CREATE PROCEDURE sp_DeleteOrderDetails
	@OrderID char(10)
AS
BEGIN
	Delete from [dbo].[ORDER] where OrderID = @OrderID
END
GO

--Trigger
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

--
ALTER PROCEDURE [dbo].[sp_GetAllRoomByDateFromTo]
(
 @DateFrom date,
 @DateTo date
)
AS
 SELECT * 
 FROM ROOM AS A INNER JOIN ROOMTYPE AS B ON A.RoomTypeID=B.RoomTypeID 
				INNER JOIN [STATUS] AS S ON A.StatusID = S.StatusID
 WHERE 
  (SELECT COUNT(*) FROM ORDERDETAIL AS C 
  WHERE  
   CONVERT (date, C.EndDate) >= CONVERT (date, GETDATE()) 
   AND RoomID=A.RoomID
   AND ((CONVERT (date, @DateFrom) <= CONVERT (date, C.EndDate) AND CONVERT (date, @DateTo) >= CONVERT (date, C.EndDate))
   OR(CONVERT (date, @DateTo) >= CONVERT (date, C.StartDate) AND CONVERT (date, @DateTo) <= CONVERT (date, C.EndDate))
   OR(CONVERT (date, @DateFrom) >= CONVERT (date, C.StartDate) AND CONVERT (date, @DateTo) <= CONVERT (date, C.EndDate))
   OR(CONVERT (date, @DateFrom) <= CONVERT (date, C.StartDate) AND CONVERT (date, @DateTo) >= CONVERT (date, C.EndDate)))) = 0

GO

EXEC sp_GetAllRoomByDateFromTo '2015-08-30', '2015-08-30';




--Thay doi kieu du lieu
ALTER TABLE [ORDER] ALTER COLUMN OrderStatus int
ALTER TABLE [ORDER] ALTER COLUMN OrderOfDate SmallDateTime
ALTER TABLE [ORDER] DROP COLUMN Estimate

----------------------------------------Test-------------------------------
SELECT Count(*) AS DT FROM ORDERDETAIL AS C 
  WHERE  
   C.EndDate >= CONVERT (date, GETDATE()) 
   AND RoomID='PH0000003'
   AND ('2015-08-25' >= C.StartDate AND '2015-08-26' >= C.EndDate)

SELECT * FROM ORDERDETAIL