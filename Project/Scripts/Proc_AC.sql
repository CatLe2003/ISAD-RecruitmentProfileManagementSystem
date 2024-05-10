USE QLHSUNGTUYEN
GO

SELECT * FROM UNGVIEN;
SELECT * FROM PHIEUDKTVUV;
GO
CREATE OR ALTER PROCEDURE CheckEmailRegistered
    @Email NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN
        IF EXISTS (SELECT 1 FROM UNGVIEN WHERE Email = @Email)
        BEGIN
            -- Email đã tồn tại trong hệ thống
            SELECT 'Email has been used! Login instead?' AS Result;
        END
    END

END;
go
CREATE OR ALTER PROCEDURE InsertUngVien
	@Hoten NVARCHAR(50),
	@SDT CHAR(10),
	@Gioitinh NVARCHAR(6),
	@Diachi NVARCHAR(50),
    @Email NVARCHAR(50),
	@Pass_word VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN
    DECLARE @maphieu INT;

    -- Insert a new row into PHIEUDKTVUV to get a new MaPhieuDKUV
    INSERT INTO PHIEUDKTVUV (NgayLap, TrangThai) VALUES (GETDATE(), 'Pending');

    -- Get the most recent MaPhieuDKUV from PHIEUDKTVUV
    SELECT TOP 1 @maphieu = MaPhieuDKUV FROM PHIEUDKTVUV ORDER BY MaPhieuDKUV DESC;

    -- Insert the new row into UNGVIEN using the retrieved MaPhieuDKUV
    INSERT INTO UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV)
    VALUES (@Pass_word, @Hoten, @Gioitinh, @SDT, @Diachi, @Email, @maphieu);
    END

END;
go

CREATE OR ALTER PROC XemDSPhieuDKTVUngVien
    @keyword NVARCHAR(100)
AS
BEGIN
    --SELECT * FROM PHIEUDKTVUV;
	SELECT 
        MaPhieuDKUV AS 'Mã phiếu',
		ID AS 'ID',
        NVXetDuyet AS 'Mã NV xét duyệt',
        TrangThai AS 'Trạng thái',
        FORMAT(NgayLap, 'dd/MM/yyyy') AS 'Ngày lập'
    FROM 
        PHIEUDKTVUV phieu
    WHERE 
        CONVERT(NVARCHAR(100), MaPhieuDKUV) LIKE '%' + @keyword + '%'
        OR CONVERT(NVARCHAR(100), NVXetDuyet) LIKE '%' + @keyword + '%'
        OR CONVERT(NVARCHAR(100), TrangThai) LIKE '%' + @keyword + '%'
        OR FORMAT(NgayLap, 'dd/MM/yyyy') LIKE '%' + @keyword + '%'
END;
go
CREATE OR ALTER PROC UpdateTrangThaiPhieuDKTVUV
	@maphieu int,
	@manv int,
	@trang_thai varchar(10)
AS
BEGIN
    UPDATE PHIEUDKTVUV
	SET TrangThai = @trang_thai
	WHERE MaPhieuDKUV = @maphieu; 

	UPDATE PHIEUDKTVUV
	SET NVXetDuyet = @manv
	WHERE MaPhieuDKUV = @maphieu; 

	IF (@trang_thai = 'Invalid')
	BEGIN 
		DELETE FROM UNGVIEN
		WHERE MaPhieuDKUV = @maphieu;
	END;
END;
go
CREATE OR ALTER PROC XemUVTheoMaPhieu
	@maphieu INT
AS
BEGIN
    SELECT * FROM UNGVIEN
	WHERE MaPhieuDKUV = @maphieu;
END;


--CheckEmailRegistered 'tredsell0@live.com'

--InsertUngVien 'yeosang', '1506', 'Male', 'jongho house', 'chickenmaster@gmail.com', '123'

--XemDSPhieuDKTVUngVien ''

--SELECT * FROM UNGVIEN;
--SELECT * FROM PHIEUDKTVUV;

UpdateTrangThaiPhieuDKTVUV '22', '2', 'Pending'

XemUVTheoMaPhieu 23
