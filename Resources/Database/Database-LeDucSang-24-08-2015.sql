

ALTER PROCEDURE [dbo].[sp_GetOrderByID]
	@OrderID char(10)
AS
BEGIN
	SELECT * FROM [dbo].[ORDER] AS O
	INNER JOIN CUSTOMER AS C ON O.CustomerID = C.CustomerID
	INNER JOIN STAFF AS S ON O.StaffID = S.StaffID
	WHERE OrderID = @OrderID
END

GO 
ALTER PROCEDURE [dbo].[sp_GetAllOrderByOderID]
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

ALTER PROCEDURE [dbo].[sp_GetAllOrderByNumberID]
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

--[sp_GetAllOrderByNumberID] '', '%205%'
-- select* from orderdetail
-- sp_GetAllOrderByOderID 'DP0000001'
--[sp_GetOrderByID] 'DP0000001'