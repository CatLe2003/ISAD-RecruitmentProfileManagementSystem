CREATE PROCEDURE sp_LapHopDong
    @MaNV INT,
    @MaDN INT,
    @NgKy DATE,
    @NgHetHan DATE,
    @Noidung NVARCHAR(100),
    @PhuLuc INT,
    @SoDotTT INT,
    @SoTienTT INT,
    @TinhTrangKyDuyet CHAR(2),
    @Uudai TINYINT
AS  
BEGIN      
    -- SET NOCOUNT ON;

    INSERT INTO HopDong (MaNV, MaDN, NgKy, NgHetHan, Noidung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, Uudai)
    VALUES (@MaNV, @MaDN, @NgKy, @NgHetHan, @Noidung, @PhuLuc, @SoDotTT, @SoTienTT, @TinhTrangKyDuyet, @Uudai);
    
    -- Optionally, you can add additional logic as needed        
END
