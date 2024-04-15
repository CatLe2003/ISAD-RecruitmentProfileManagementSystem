USE QLHSUNGTUYEN
GO

SELECT * FROM UNGVIEN;
SELECT * FROM PHIEUDKTVUV;

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

CREATE OR ALTER PROC XemDSPhieuDKTVUngVien
AS
BEGIN
    SELECT * FROM PHIEUDKTVUV;
END;

CREATE OR ALTER PROC XemPhieuDKQC_DoanhNghiep
    @madn INT,
    @keyword NVARCHAR(100)
AS
BEGIN
    SELECT 
        MaHT AS 'Mã hình thức',
        MaDT AS 'Mã đăng tuyển',
        MaHDong AS 'Mã hợp đồng',
        FORMAT(NgayLap, 'dd/MM/yyyy') AS 'Ngày lập'
    FROM 
        PHIEUDKQUANGCAO qc
    WHERE 
        qc.MaDT IN (SELECT MaDT FROM THONGTINDANGTUYEN WHERE MaDN = @madn)
        AND (
            CONVERT(NVARCHAR(100), MaHT) LIKE '%' + @keyword + '%'
            OR CONVERT(NVARCHAR(100), MaDT) LIKE '%' + @keyword + '%'
            OR CONVERT(NVARCHAR(100), MaHDong) LIKE '%' + @keyword + '%'
            OR FORMAT(NgayLap, 'dd/MM/yyyy') LIKE '%' + @keyword + '%'
        )
END

--hello its me
--wtheck
CheckEmailRegistered 'tredsell0@live.com'

InsertUngVien 'yeosang', '1506', 'Male', 'jongho house', 'chickenmaster@gmail.com', '123'