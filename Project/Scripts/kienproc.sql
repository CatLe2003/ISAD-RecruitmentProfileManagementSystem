CREATE OR ALTER PROCEDURE GetHopDong
	@MaDN INT
AS
BEGIN
    SELECT hd.MaHDong,  hd.SoDotTT
    FROM HOPDONG hd 
    WHERE hd.NgKy >= DATEADD(day, -30, GETDATE()) and hd.MaDN = @MaDN   -- NgKy within the last 10 days
END;

go

CREATE OR ALTER PROCEDURE GetDoanhNghiep
AS
BEGIN
    SELECT MaDN, TenDN
    FROM DOANHNGHIEP 
END;

go

insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (4, 17, '4/11/2024', '7/30/2024', 'faucibus orci luctus et ultrices posuere cubilia', 7, 3, 1898137, '0', 0.4);

go

CREATE OR ALTER PROCEDURE GetTenNhanVien
    @MaNV INT
AS
BEGIN
    SELECT Hoten
    FROM NHANVIEN
    WHERE MaNV = @MaNV;
END;


go

CREATE OR ALTER PROCEDURE LapPhieuThu
    @MaNV INT,
    @DotThu CHAR(2),
    @NgayThu DATE,
    @SoTien INT,
    @MaHDong INT
AS
BEGIN
    DECLARE @SoTienTT INT;
	DECLARE @DOTTHUTIEN INT;
    DECLARE @PhieuThuCount INT;
	DECLARE @SoTienTichLuy INT;
    DECLARE @SoTienConLai INT;

    -- Kiểm tra xem MaHDong đã tồn tại trong PHIEUTHU hay chưa
    SELECT @PhieuThuCount = COUNT(*)
    FROM PHIEUTHU
    WHERE MaHDong = @MaHDong
      AND DotThu = @DotThu;

    -- Nếu MaHDong đã tồn tại cho đợt thu đó, không thêm mới
    IF (@PhieuThuCount = @DotThu)
    BEGIN
        RAISERROR ('Đợt thu đã tồn tại cho hợp đồng này.', 16, 1);
        RETURN; -- Kết thúc procedure
    END;

	-- Lấy tổng số tiền đã thu tới đợt thu trước đó
    SELECT @SoTienTichLuy = SUM(SoTien)
    FROM PHIEUTHU
    WHERE MaHDong = @MaHDong
      AND DotThu < @DotThu;

    -- Lấy tổng số tiền thanh toán từ HOPDONG
    SELECT @SoTienTT =SoTienTT ,@DOTTHUTIEN = SoDotTT
    FROM HOPDONG
    WHERE MaHDong = @MaHDong;

	-- Tính số tiền còn lại cần thanh toán trong đợt này
    SET @SoTienConLai = @SoTienTT - @SoTienTichLuy;

	IF (@DotThu = @DOTTHUTIEN)
    BEGIN
        -- Kiểm tra nếu số tiền không bằng tổng số tiền còn lại cần thanh toán
        IF (@SoTien <> @SoTienConLai)
        BEGIN
            -- Thông báo lỗi phải thanh toán hết trong đợt này
            RAISERROR ('Số tiền thu phải bằng tổng số tiền còn lại cần thanh toán trong đợt này.', 16, 1);
            RETURN; -- Kết thúc procedure
        END;
    END;

    -- Kiểm tra nếu số tiền lớn hơn 30% tổng số tiền thanh toán
    IF (@SoTien > 0.3 * @SoTienTT)
    BEGIN
        -- Thêm mới phiếu thu
            IF (@SoTien < 0.7@SoTienTT)
            BEGIN
                -- Thêm mới phiếu thu
                INSERT INTO PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong)
                VALUES (@MaNV, @DotThu, @NgayThu, @SoTien, @MaHDong);
            END
            ELSE
            BEGIN
                -- Thông báo lỗi nếu số tiền không lớn hơn 30% tổng số tiền thanh toán
                RAISERROR ('Số tiền thu phải nhỏ hơn tổng số tiền thanh toán trong HOPDONG.', 16, 1);
            END;
    END
    ELSE
    BEGIN
        -- Thông báo lỗi nếu số tiền không lớn hơn 30% tổng số tiền thanh toán
        RAISERROR ('Số tiền thu phải lớn hơn 30%% tổng số tiền thanh toán trong HOPDONG.', 16, 1);
    END;
END;


CREATE OR ALTER PROCEDURE TimDotThuLonNhat
    @MaHDong integer
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @DotThu integer;

    -- Lấy DotThu lớn nhất từ bảng PhiếuThu
    SELECT @DotThu = MAX(DotThu)
    FROM PhieuThu
    WHERE MaHDong = @MaHDong;

    -- Nếu không tìm thấy DotThu, trả về 0
    IF @DotThu IS NULL
    BEGIN
        SET @DotThu = 0;
    END

    -- Trả về DotThu lớn nhất
    SELECT @DotThu AS DotThu;
END;