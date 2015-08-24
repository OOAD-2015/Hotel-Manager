

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
CREATE PROCEDURE [dbo].[sp_GetAllOrderByOderID]
 @OrderID char(10)
AS
BEGIN
 SELECT R.RoomID, R.RoomName, RT.RoomTypeName, OD.StartDate, OD.EndDate, R.NumberOfBeds, RT.Price, OD.Estimate, DATEDIFF(dd, OD.StartDate, OD.EndDate) AS Quantity,(DATEDIFF(dd, OD.StartDate, OD.EndDate) * RT.Price) AS Monetized
 FROM [dbo].[ORDERDETAIL] AS OD
        INNER JOIN ROOM AS R ON OD.RoomID = R.RoomID
        INNER JOIN ROOMTYPE AS RT ON R.RoomTypeID = RT.RoomTypeID
        INNER JOIN [STATUS] AS S ON R.StatusID = S.StatusID
 WHERE OrderID = @OrderID
END

-- select* from orderdetail
-- sp_GetAllOrderByOderID 'DP0000001'