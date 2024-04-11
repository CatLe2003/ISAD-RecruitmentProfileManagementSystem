USE QLHSUNGTUYEN
GO
-- Tạo trigger
CREATE OR ALTER TRIGGER Trigger_KiemTraPhieuThu
ON PHIEUTHU
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaHDong INT;
    DECLARE @SoDotTT INT;
    DECLARE @SoTienTT INT;
    
    -- Lấy thông tin số đợt thanh toán và số tiền thanh toán của hợp đồng vừa thêm hoặc cập nhật
    SELECT @MaHDong = MaHDong, @SoDotTT = SoDotTT, @SoTienTT = SoTienTT
    FROM HOPDONG
    WHERE MaHDong IN (SELECT MaHDong FROM inserted);
    
    -- Kiểm tra số phiếu thu và tổng số tiền của các phiếu thu
    IF EXISTS (
        SELECT MaHDong
        FROM inserted
        WHERE MaHDong = @MaHDong
        GROUP BY MaHDong
        HAVING COUNT(*) > @SoDotTT
    )
    BEGIN
        RAISERROR ('Số phiếu thu vượt quá số đợt thanh toán của hợp đồng.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END;

    IF EXISTS (
        SELECT MaHDong
        FROM PHIEUTHU
        WHERE MaHDong = @MaHDong
        GROUP BY MaHDong
        HAVING SUM(SoTien) > @SoTienTT
    )
    BEGIN
        RAISERROR ('Tổng số tiền của các phiếu thu vượt quá số tiền thanh toán của hợp đồng.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END;
END;

-- Tạo trigger
CREATE OR ALTER TRIGGER UpdateHoaDon
ON HOADON
AFTER INSERT
AS
BEGIN
    DECLARE @MaHDong INT
    DECLARE @SoTienTT INT

    -- Lấy thông tin Mã Hợp đồng và Số tiền thanh toán
    SELECT @MaHDong = i.MaHDong,
           @SoTienTT = h.SoTienTT
    FROM inserted i
    INNER JOIN HOPDONG h ON i.MaHDong = h.MaHDong

    -- Cập nhật tổng tiền của hóa đơn
    UPDATE HOADON
    SET TongTien = @SoTienTT,
        NgLap = GETDATE()
    WHERE MaHD = (SELECT MaHD FROM inserted)
END;
