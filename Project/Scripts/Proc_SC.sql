USE QLHSUNGTUYEN
GO

SELECT * FROM DOANHNGHIEP;
SELECT * FROM PHIEUDKTVDN;
go
CREATE OR ALTER PROCEDURE CheckEmailRegisteredDoanhNghiep
    @Email NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN
        IF EXISTS (SELECT 1 FROM DOANHNGHIEP WHERE Email = @Email)
        BEGIN
            -- Email đã tồn tại trong hệ thống
            SELECT 'Email has been used! Login instead?' AS Result;
        END
    END

END;
-- CheckEmailRegisteredDoanhNghiep 'caddweqqweqwe@live.com'
-- Registered : CheckEmailRegisteredDoanhNghiep 'cblazey0@reuters.com'
go
CREATE OR ALTER PROCEDURE InsertDoanhNghiep
	@TenDN NVARCHAR(50),
	@MaSoThue char(10),
	@NguoiDaiDien NVARCHAR(50),
	@Diachi NVARCHAR(50),
    @Email NVARCHAR(50),
	@Pass_word VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN
    DECLARE @maphieu INT;

    -- Insert a new row into PHIEUDKTVDN to get a new MaPhieuDKDN
    INSERT INTO PHIEUDKTVDN (NgayLap, TrangThai) VALUES (GETDATE(), 'Pending');

    -- Get the most recent MaPhieuDKDN from PHIEUDKTVDN
    SELECT TOP 1 @maphieu = MaPhieuDKDN FROM PHIEUDKTVDN ORDER BY MaPhieuDKDN DESC;

    -- Insert the new row into DOANHNGHIEP using the retrieved MaPhieuDKDN
    INSERT INTO DOANHNGHIEP (TenDN, MaSoThue, NguoiDaiDien, Diachi, Email,Pass_word, MaPhieuDKDN)
    VALUES (@TenDN, @MaSoThue, @NguoiDaiDien, @Diachi, @Email, @Pass_word, @maphieu);
    END

END;

go

CREATE OR ALTER PROC XemDSPhieuDKTVDN
    @keyword NVARCHAR(100)
AS
BEGIN
    --SELECT * FROM PHIEUDKTVDN;
	SELECT 
        MaPhieuDKDN AS 'Mã phiếu',
		ID AS 'ID',
        NVXetDuyet AS 'Mã NV xét duyệt',
        TrangThai AS 'Trạng thái',
        FORMAT(NgayLap, 'dd/MM/yyyy') AS 'Ngày lập'
    FROM 
        PHIEUDKTVDN phieu
    WHERE 
        CONVERT(NVARCHAR(100), MaPhieuDKDN) LIKE '%' + @keyword + '%'
        OR CONVERT(NVARCHAR(100), NVXetDuyet) LIKE '%' + @keyword + '%'
        OR CONVERT(NVARCHAR(100), TrangThai) LIKE '%' + @keyword + '%'
        OR FORMAT(NgayLap, 'dd/MM/yyyy') LIKE '%' + @keyword + '%'
END;

-- XemDSPhieuDKTVDN ''
go
CREATE OR ALTER PROC UpdateTrangThaiPhieuDKTVDN
	@maphieu int,
	@manv int,
	@trang_thai varchar(10)
AS
BEGIN
    UPDATE PHIEUDKTVDN
	SET TrangThai = @trang_thai, NVXetDuyet = @manv
	WHERE MaPhieuDKDN = @maphieu; 

	IF (@trang_thai = 'Invalid')
	BEGIN 
		DELETE FROM DOANHNGHIEP
		WHERE MaPhieuDKDN = @maphieu;
	END;
END;

-- UpdateTrangThaiPhieuDKTVDN '21', '2', 'Valid'
-- UpdateTrangThaiPhieuDKTVDN '21', '2', 'Pending'
go
CREATE OR ALTER PROC XemDNTheoMaPhieu
	@maphieu INT
AS
BEGIN
    SELECT * FROM DOANHNGHIEP
	WHERE MaPhieuDKDN = @maphieu;
END;

--- XemDNTheoMaPhieu 21
