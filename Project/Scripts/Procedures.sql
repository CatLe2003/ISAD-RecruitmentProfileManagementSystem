USE DATABSASE QLHSUNGTUYEN
GO
Select * from doanhnghiep;

CheckLogin 'dn', 'cblazey0@reuters.com', 'uB5=/2d{FrihRb'
GetUserID 'dn', 'cblazey0@reuters.com', 'uB5=/2d{FrihRb'
-- Kiểm tra login
CREATE OR ALTER PROCEDURE CheckLogin
    @LoaiTK NVARCHAR(2),
    @Email NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF @LoaiTK = 'nv'
    BEGIN
        IF EXISTS (SELECT 1 FROM NHANVIEN WHERE Email = @Email AND Pass_word = @Password AND LoaiNV = 'NV')
        BEGIN
            -- Đăng nhập thành công với loại tài khoản nhân viên
            SELECT 'Login successful' AS Result;
        END
        ELSE
        BEGIN
            -- Đăng nhập không thành công
            SELECT 'Invalid email or password' AS Result;
        END
    END
    ELSE IF @LoaiTK = 'dn'
    BEGIN
        IF EXISTS (SELECT 1 FROM DOANHNGHIEP WHERE Email = @Email AND Pass_word = @Password)
        BEGIN
            -- Đăng nhập thành công với loại tài khoản doanh nghiệp
            DECLARE @MaPhieuDKTVDN INT;
            SELECT @MaPhieuDKTVDN = MaPhieuDKDN FROM DOANHNGHIEP WHERE Email = @Email;
            IF EXISTS (SELECT 1 FROM PHIEUDKTVDN WHERE MaPhieuDKDN = @MaPhieuDKTVDN AND TrangThai = 'Valid')
                SELECT 'Login successful' AS Result;
            ELSE
                SELECT 'Invalid account type' AS Result;
        END
        ELSE
        BEGIN
            -- Đăng nhập không thành công
            SELECT 'Invalid email or password' AS Result;
        END
    END
    ELSE IF @LoaiTK = 'uv'
    BEGIN
        IF EXISTS (SELECT 1 FROM UNGVIEN WHERE Email = @Email AND Pass_word = @Password)
        BEGIN
            -- Đăng nhập thành công với loại tài khoản ứng viên
            DECLARE @MaPhieuDKTVUV INT;
            SELECT @MaPhieuDKTVUV = MaPhieuDKUV FROM UNGVIEN WHERE Email = @Email;
            IF EXISTS (SELECT 1 FROM PHIEUDKTVUV WHERE MaPhieuDKUV = @MaPhieuDKTVUV AND TrangThai = 'Valid')
                SELECT 'Login successful' AS Result;
            ELSE
                SELECT 'Invalid account type' AS Result;
        END
        ELSE
        BEGIN
            -- Đăng nhập không thành công
            SELECT 'Invalid email or password' AS Result;
        END
    END
    ELSE
    BEGIN
        -- Loại tài khoản không hợp lệ
        SELECT 'Invalid account type' AS Result;
    END
END; 

-- Lấy ID của user đã login
CREATE OR ALTER PROCEDURE GetUserID
    @LoaiTK NVARCHAR(2),
    @Email NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF @LoaiTK = 'nv'
    BEGIN
        SELECT MaNV AS UserID
        FROM NHANVIEN
        WHERE Email = @Email AND Pass_word = @Password AND LoaiNV = 'NV';
    END
    ELSE IF @LoaiTK = 'dn'
    BEGIN
        SELECT MaDN AS UserID
        FROM DOANHNGHIEP
        WHERE Email = @Email AND Pass_word = @Password;
    END
    ELSE IF @LoaiTK = 'uv'
    BEGIN
        SELECT MaUV AS UserID
        FROM UNGVIEN
        WHERE Email = @Email AND Pass_word = @Password;
    END
    ELSE
    BEGIN
        -- Loại tài khoản không hợp lệ
        SELECT NULL AS UserID;
    END
END;
-- Xem danh sách phiếu đk quảng cáo theo doanh nghiệp, từ khóa
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

XemPhieuDKQC_DoanhNghiep 4,'2024'

select * from PHIEUDKQUANGCAO
-- Lấy tất cả các tên hình thức đăng tuyển
CREATE OR ALTER PROCEDURE GetTenHinhThucDangTuyen
AS
BEGIN
    SELECT TenHinhThuc FROM HINHTHUCDANGTUYEN
END;
-- Lấy mã đăng tuyển của doanh nghiệp đó
CREATE OR ALTER PROCEDURE GetMaThongTinDangTuyenByMaDN
    @MaDN INT
AS
BEGIN
    SELECT MaDT
    FROM THONGTINDANGTUYEN
    WHERE MaDN = @MaDN;
END;
-- Lấy mã hợp đồng của doanh nghiệp đó
CREATE OR ALTER PROCEDURE GetMaHopDongByMaDN
    @MaDN INT
AS
BEGIN
    SELECT MaHDong
    FROM HOPDONG
    WHERE MaDN = @MaDN;
END;

-- Thêm phiếu đk quảng cáo cho doanh nghiệp
CREATE OR ALTER PROCEDURE ThemPhieuDKQuangCao
    @MaHT INT,
    @MaDT INT,
    @MaHDong INT,
    @NgayLap DATE
AS
BEGIN
    -- Kiểm tra xem MaHT, MaDT và MaHDong có tồn tại trong các bảng tương ứng không
    IF NOT EXISTS (SELECT 1 FROM HINHTHUCDANGTUYEN WHERE MaHT = @MaHT)
    BEGIN
        RAISERROR('MaHT khong ton tai', 16, 1)
        RETURN 0
    END

    IF NOT EXISTS (SELECT 1 FROM THONGTINDANGTUYEN WHERE MaDT = @MaDT)
    BEGIN
        RAISERROR('MaDT khong ton tai', 16, 1)
        RETURN 0
    END

    IF NOT EXISTS (SELECT 1 FROM HOPDONG WHERE MaHDong = @MaHDong)
    BEGIN
        RAISERROR('MaHDong khong ton tai', 16, 1)
        RETURN 0
    END

    -- Thêm bản ghi mới vào bảng PHIEUDKQUANGCAO
    INSERT INTO PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap)
    VALUES (@MaHT, @MaDT, @MaHDong, @NgayLap)

    IF @@ERROR <> 0
    BEGIN
        RAISERROR('Khong the them Phieu DK Quang Cao', 16, 1)
        RETURN 0
    END

    -- Thông báo thành công nếu không có lỗi
    PRINT 'Thêm Phieu DK Quang Cao thành công'
	RETURN 1
END

exec ThemPhieuDKQuangCao 1,2,3,'2023-11-19'
-- Cập nhật phiếu đk quảng cáo
CREATE OR ALTER PROCEDURE CapNhatPhieuDKQuangCao
    @MaHT INT,
    @MaDT INT,
    @MaHDong INT,
    @NgayLap DATE
AS
BEGIN
    -- Kiểm tra xem MaHT, MaDT và MaHDong có tồn tại trong các bảng tương ứng không
    IF NOT EXISTS (SELECT 1 FROM HINHTHUCDANGTUYEN WHERE MaHT = @MaHT)
    BEGIN
        RAISERROR('MaHT khong ton tai', 16, 1)
        RETURN
    END

    IF NOT EXISTS (SELECT 1 FROM THONGTINDANGTUYEN WHERE MaDT = @MaDT)
    BEGIN
        RAISERROR('MaDT khong ton tai', 16, 1)
        RETURN
    END

    IF NOT EXISTS (SELECT 1 FROM HOPDONG WHERE MaHDong = @MaHDong)
    BEGIN
        RAISERROR('MaHDong khong ton tai', 16, 1)
        RETURN
    END

    -- Cập nhật thông tin của Phiếu DK Quang Cao
    UPDATE PHIEUDKQUANGCAO
    SET NgayLap = @NgayLap, MaHDong = @MaHDong
    WHERE MaHT = @MaHT AND MaDT = @MaDT

    IF @@ERROR <> 0
    BEGIN
        RAISERROR('Khong the cap nhat Phieu DK Quang Cao', 16, 1)
        RETURN
    END

    -- Thông báo thành công nếu không có lỗi
    PRINT 'Cập nhật Phieu DK Quang Cao thành công'
END
-- Xem thông tin chi tiết 1 phiếu quảng cáo
CREATE OR ALTER PROCEDURE XemPhieuDKQuangCao
    @MaHT INT,
    @MaDT INT
AS
BEGIN
    -- Kiểm tra xem MaHT và MaDT có tồn tại trong bảng PHIEUDKQUANGCAO không
    IF NOT EXISTS (SELECT 1 FROM PHIEUDKQUANGCAO WHERE MaHT = @MaHT AND MaDT = @MaDT)
    BEGIN
        RAISERROR('Khong tim thay Phieu DK Quang Cao', 16, 1)
        RETURN
    END

    -- Lấy thông tin của Phiếu DK Quang Cao và định dạng ngày thành "dd/mm/yyyy"
    SELECT MaHT, MaDT, MaHDong, FORMAT(NgayLap, 'dd/MM/yyyy') AS NgayLap
    FROM PHIEUDKQUANGCAO
    WHERE MaHT = @MaHT AND MaDT = @MaDT
END

exec XemPhieuDKQuangCao 2,7
exec CapNhatPhieuDKQuangCao 2,7,23,'03-12-2024'
CapNhatPhieuDKQuangCao 2,9,25,'04-11-2024'
ThemPhieuDKQuangCao 3,8,15,'2034-03-20'
