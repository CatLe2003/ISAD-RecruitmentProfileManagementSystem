USE QLHSUNGTUYEN
GO

-- NHANVIEN --
delete from NHANVIEN;
SET IDENTITY_INSERT NHANVIEN OFF
DBCC CHECKIDENT ('NHANVIEN', RESEED, 1);
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('qU4~g?N1,B*P+I', 'Jillane Burleigh', 'Male', 8685863639, '31858 Hintze Alley', 'jburleigh0@indiegogo.com', 'NV');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('qA4\z{v4', 'Isahella Dunning', 'Male', 7168347955, '36152 Brentwood Parkway', 'idunning1@pbs.org', 'NV');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('bP9&&gp1+<', 'Deanne Doddrell', 'Male', 8828007673, '42 Doe Crossing Road', 'ddoddrell2@aboutads.info', 'NV');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('vF5|{i|/Tqd', 'Raymond Duckerin', 'Female', 7221298301, '56 Esch Plaza', 'rduckerin3@google.ru', 'NV');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('vU3&pDo|U<f$P%%', 'Rori Walker', 'Female', 1924891923, '82093 7th Hill', 'rwalker4@techcrunch.com', 'NV');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('jP8*XSCbLOnak', 'Izabel Adamo', 'Male', 9336037405, '58324 New Castle Hill', 'iadamo5@quantcast.com', 'NV');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('dI0?c@EC"n', 'Stu Klezmski', 'Male', 752084927, '07 Schiller Point', 'sklezmski6@bandcamp.com', 'NV');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('oE7<<2PZ"7', 'Dag BURWIN', 'Male', 5459639660, '45 Emmet Drive', 'dburwin7@cpanel.net', 'NV');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('mJ9@g8K1kBj8W!C', 'Harv Monkley', 'Female', 8592825976, '62878 Crowley Parkway', 'hmonkley8@nhs.uk', 'NV');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('jN8!|w3$jujo.iV{', 'Juliette Kneaphsey', 'Female', 8061178930, '0125 Monument Road', 'jkneaphsey9@omniture.com', 'NV');

insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('nN6@+%k/%,bs"Gj', 'Flossie Werrilow', 'Female', 2652435271, '38809 Troy Way', 'fwerrilow0@smugmug.com', 'GD');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('jA4$2=au$sc', 'Nettle Garnham', 'Female', 1037498423, '7 Swallow Trail', 'ngarnham1@china.com.cn', 'GD');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('oC7)YO\|Jn``VzcN', 'Michal Routhorn', 'Female', 400381888, '0 Shoshone Place', 'mrouthorn2@istockphoto.com', 'GD');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('jW1/j!sM##L', 'Stesha Ornils', 'Female', 5154818007, '95075 Meadow Valley Trail', 'sornils3@adobe.com', 'GD');
insert into NHANVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, LoaiNV) values ('hW4{}8}*G', 'Lorna Metzig', 'Female', 4629393745, '389 Golf Circle', 'lmetzig4@msu.edu', 'GD');​

select * from NHANVIEN;

-- PHIEUDKTVDN --
delete from PHIEUDKTVDN;
DBCC CHECKIDENT ('PHIEUDKTVDN', RESEED, 1);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('10/8/2023', 5);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('8/6/2023', 10);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('11/19/2023', 7);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('2/5/2024', 8);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('11/20/2023', 6);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('1/21/2024', 5);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('3/9/2024', 4);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('3/3/2024', 8);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('12/26/2023', 7);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('12/21/2023', 2);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('2/29/2024', 5);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('1/9/2024', 9);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('10/29/2023', 4);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('8/30/2023', 1);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('3/27/2024', 3);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('1/16/2024', 4);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('9/4/2023', 1);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('12/22/2023', 4);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('3/7/2024', 7);
insert into PHIEUDKTVDN (NgayLap, NVLapPhieu) values ('3/9/2024', 7);

select * from PHIEUDKTVDN;

-- DOANHNGHIEP --
delete from DOANHNGHIEP;
DBCC CHECKIDENT ('DOANHNGHIEP', RESEED, 1);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('uB5=/2d{FrihRb', 'Skyba', '4241054141', 'Clarette Blazey', '681 Florence Lane', 'cblazey0@reuters.com', '1', 1);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('bY5''!%pD', 'Kayveo', '5281807518', 'Ajay Lindman', '7773 Raven Alley', 'alindman1@wsj.com', '0', 2);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('sN9&dIzDk', 'Gigabox', '5372147968', 'Brennan Leeke', '812 Fairfield Place', 'bleeke2@t.co', '0', 3);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('nQ3<syVb', 'Fivechat', '2871865930', 'Harrison Ubanks', '695 Oak Valley Junction', 'hubanks3@ed.gov', '1', 4);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('bU0<Y/1S+H@@_', 'Buzzdog', '3566216134', 'Tobye Danter', '4 Magdeline Parkway', 'tdanter4@jugem.jp', '1', 5);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('uA4*YIDOR1', 'Feedbug', '8766054200', 'Waylin Privett', '376 Morningstar Avenue', 'wprivett5@miitbeian.gov.cn', '1', 6);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('rT2"o$0*h=g''c%', 'Blognation', '8994303731', 'Sibeal Scotter', '26738 Saint Paul Hill', 'sscotter6@wikispaces.com', '0', 7);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('wF5%!=cp', 'Skalith', '6828233101', 'Natalie Clemens', '9884 Namekagon Circle', 'nclemens7@tinypic.com', '1', 8);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('iS5}\0CtJZT', 'Skimia', '3443199084', 'Coretta Measham', '09671 Jay Hill', 'cmeasham8@admin.ch', '1', 9);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('mQ3,IncsbY', 'Meedoo', '2351075313', 'Laurie Tomaszkiewicz', '6679 Lillian Trail', 'ltomaszkiewicz9@live.com', '1', 10);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('xS5_yyJ)6E', 'Tagcat', '6214072100', 'Maryanne Biggs', '317 Northwestern Way', 'mbiggsa@tuttocitta.it', '1', 11);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('bP4,!''}zn_F', 'Browsezoom', '7046862736', 'Mano Comino', '2470 Marcy Circle', 'mcominob@java.com', '0', 12);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('kI1~HlEWIF', 'Wordtune', '5370375783', 'Alikee Lintott', '81 Moland Junction', 'alintottc@netscape.com', '1', 13);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('kL0|NWyux', 'Katz', '8818709587', 'Beverley Standon', '459 Bashford Avenue', 'bstandond@people.com.cn', '1', 14);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('iQ7@,1E+Sh', 'Divape', '3941993847', 'Tedie Linkin', '22 Cascade Way', 'tlinkine@cam.ac.uk', '0', 15);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('bN5$I?UYGXk%', 'Topiclounge', '2509642206', 'Earle Caplis', '8 Esch Parkway', 'ecaplisf@friendfeed.com', '1', 16);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('aP7,wV%n4m39ay', 'Buzzdog', '9738775017', 'Pietrek Emlin', '593 Hoard Crossing', 'pemling@toplist.cz', '0', 17);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('jS0_=RodLfB+@B', 'Demivee', '9267822239', 'Conrade Narrie', '405 Hudson Place', 'cnarrieh@free.fr', '1', 18);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('zW8`,d/_v6#h~V', 'Skivee', '5995420360', 'Nina McTear', '9931 Morningstar Circle', 'nmcteari@ftc.gov', '1', 19);
insert into DOANHNGHIEP (Pass_word, TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, TiemNang, MaPhieuDKDN) values ('dD1.Juet', 'Jamia', '7610604067', 'Ethelind Baudinot', '348 Green Ridge Way', 'ebaudinotj@about.me', '1', 20);

-- PHIEUDKTVUV --
delete from PHIEUDKTVUV;
DBCC CHECKIDENT ('PHIEUDKTVUV', RESEED, 1);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('12/24/2023', 2);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('9/3/2023', 1);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('9/8/2023', 7);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('9/1/2023', 4);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('11/18/2023', 3);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('8/19/2023', 2);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('12/16/2023', 10);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('9/7/2023', 1);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('9/3/2023', 10);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('12/31/2023', 4);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('3/18/2024', 5);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('8/31/2023', 6);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('8/20/2023', 7);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('11/9/2023', 1);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('1/28/2024', 2);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('2/19/2024', 9);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('3/14/2024', 2);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('8/28/2023', 7);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('3/24/2024', 8);
insert into PHIEUDKTVUV (NgayLap, NVLapPhieu) values ('10/30/2023', 5);

-- UNGVIEN --
delete from UNGVIEN;
DBCC CHECKIDENT ('UNGVIEN', RESEED, 1);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('eN4|8SUc', 'Theresina', 'Male', '2944481847', '5 David Way', 'tredsell0@live.com', 1);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('vB1`LgNN+', 'Alexia', 'Female', '1652129257', '96 Twin Pines Pass', 'ahiscocks1@tuttocitta.it', 2);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('qC7\G*YOt`#r/.pZ', 'Carolyn', 'Male', '8984323012', '2994 Everett Way', 'chacker2@sbwire.com', 3);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('uO0\s>W=', 'Kamillah', 'Female', '5917222600', '89730 Hoepker Center', 'kmarskell3@free.fr', 4);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('qE9__+PTb"@gxQ', 'Emalee', 'Male', '4351339280', '5 Petterle Lane', 'eclapson4@wired.com', 5);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('vG8$rmE#g@5Y', 'Celine', 'Female', '8008491494', '51141 Elmside Park', 'cbanfield5@typepad.com', 6);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('kC7~WChx+t<Bi!S', 'Derril', 'Male', '9915012092', '3 Dovetail Point', 'dbatecok6@amazon.com', 7);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('eR3)NQ''ZWmQ3pn', 'Edna', 'Female', '6693651052', '1352 Caliangt Circle', 'edowngate7@house.gov', 8);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('gG1%FB8HPD', 'Maxine', 'Male', '3290715171', '91 Dapin Court', 'mpassfield8@gravatar.com', 9);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('kR6~nN~5*Ne<x|(', 'Rollo', 'Female', '4873532779', '7 Hallows Parkway', 'rmilverton9@comsenz.com', 10);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('fI3}?S>C4E}Lg?', 'Star', 'Male', '9492446686', '14 Portage Park', 'sfarnhama@xinhuanet.com', 11);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('uF5*{M_@i\', 'Kyrstin', 'Female', '7856817420', '7457 Dapin Lane', 'kbeinb@utexas.edu', 12);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('cS0<?otp4jIn"_', 'Tadeas', 'Male', '2336802782', '28350 Calypso Center', 'tgerhtsc@domainmarket.com', 13);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('zZ8}{po@CWXJO', 'Tom', 'Male', '5942649972', '187 Sloan Court', 'toherlihyd@ucoz.ru', 14);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('wX1.~*CQSNnG=A', 'Lincoln', 'Male', '7201270644', '92504 Cascade Street', 'lclydee@ezinearticles.com', 15);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('sD9}PYWQm_c', 'Kennedy', 'Female', '9874328411', '77319 Duke Place', 'kmacdwyerf@berkeley.edu', 16);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('eI7%f.gv70y', 'Lexi', 'Male', '424128171', '431 Maple Wood Plaza', 'lwhannelg@nyu.edu', 17);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('kR3{2Ah#v>i)&', 'Chrissy', 'Male', '4847229170', '982 Dapin Place', 'ckeesmanh@mayoclinic.com', 18);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('vX4)6Wc|XpcqfWfy', 'Edward', 'Female', '2588676687', '9 Comanche Hill', 'emeai@vkontakte.ru', 19);
insert into UNGVIEN (Pass_word, Hoten, Gioitinh, Sdt, Diachi, Email, MaPhieuDKUV) values ('kX0?`sCXW}d', 'Katerine', 'Female', '6645555416', '78889 Randy Terrace', 'kkrammerj@seesaa.net', 20);

-- HINHTHUCDANGTUYEN --
delete from HINHTHUCDANGTUYEN;
DBCC CHECKIDENT ('HINHTHUCDANGTUYEN', RESEED, 1);
insert into HINHTHUCDANGTUYEN (TenHinhThuc, MoTa, GiaTien) values (N'Báo giấy', N'Đăng tuyển trên báo giấy', 1500000);
insert into HINHTHUCDANGTUYEN (TenHinhThuc, MoTa, GiaTien) values (N'Banner quảng cáo', N'Đăng tuyển trên banner quảng cáo', 2500000);
insert into HINHTHUCDANGTUYEN (TenHinhThuc, MoTa, GiaTien) values (N'Trang mạng', N'Đăng tuyển trên trang mạng', 3000000);

-- THONGTINDANGTUYEN --
delete from THONGTINDANGTUYEN;
DBCC CHECKIDENT ('THONGTINDANGTUYEN', RESEED, 1);
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('1/20/2024', 14, '12/4/4067', 19.64664, 'Intership', 'Java');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('5/31/2024', 8, '6/30/6532', 26.60402, 'Fresher', 'JavaScript');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('4/3/2024', 1, '2/5/8414', 5.15106, 'Senior', 'MongoDB');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('6/21/2024', 20, '1/6/2538', 14.33992, 'Junior', 'HTML');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('7/23/2024', 8, '2/19/5256', 33.69056, 'Intership', 'PostgreSQL');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('7/20/2024', 19, '6/12/9667', 9.57641, 'Fresher', 'JavaScript');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('5/20/2024', 4, '8/11/6487', 25.27885, 'Senior', 'HTML');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('5/24/2024', 14, '5/24/3390', 21.81348, 'Junior', 'Python');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('7/9/2024', 4, '9/7/4328', 16.08421, 'Intership', 'JavaScript');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('6/13/2024', 11, '4/8/7624', 38.38768, 'Fresher', 'Python');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('7/9/2024', 2, '8/6/4258', 35.8397, 'Senior', 'Yêu cầu một mức độ kinh nghiệm cụ thể trong các ngôn ngữ lập trình');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('2/19/2024', 12, '4/10/7166', 19.25552, 'Junior', 'C++');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('4/29/2024', 4, '5/4/2601', 9.01498, 'Intership', 'MongoDB');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('1/30/2024', 5, '8/14/4357', 43.68125, 'Fresher', 'C++');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('6/28/2024', 4, '2/25/9109', 28.47107, 'Senior', 'Yêu cầu một mức độ kinh nghiệm cụ thể trong các ngôn ngữ lập trình');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('4/25/2024', 8, '5/31/6865', 10.99696, 'Junior', 'MongoDB');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('1/6/2024', 20, '6/25/2077', 29.47324, 'Intership', 'PostgreSQL');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('5/23/2024', 17, '11/7/7668', 25.51704, 'Fresher', 'Python');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('5/27/2024', 19, '1/14/6649', 44.62274, 'Senior', 'Yêu cầu một mức độ kinh nghiệm cụ thể trong các ngôn ngữ lập trình');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('5/22/2024', 8, '7/21/7922', 39.13462, 'Junior', 'CSS');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('6/18/2024', 8, '5/15/2033', 16.8064, 'Intership', 'C++');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('2/8/2024', 15, '12/21/5036', 5.4977, 'Fresher', 'Yêu cầu một mức độ kinh nghiệm cụ thể trong các ngôn ngữ lập trình');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('2/16/2024', 20, '6/17/7383', 36.38864, 'Senior', 'PostgreSQL');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('5/3/2024', 2, '8/20/7828', 30.68741, 'Junior', 'C++');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('1/18/2024', 1, '10/21/2569', 31.85591, 'Intership', 'HTML');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('3/14/2024', 2, '8/29/5159', 32.28868, 'Fresher', 'Java');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('4/20/2024', 19, '8/19/9216', 22.77794, 'Senior', 'Yêu cầu một mức độ kinh nghiệm cụ thể trong các ngôn ngữ lập trình');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('7/9/2024', 9, '4/30/4300', 18.11339, 'Junior', 'C++');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('6/30/2024', 4, '5/11/3063', 22.54595, 'Intership', 'Python');
insert into THONGTINDANGTUYEN (NgDangTuyen, MaDN, NgHetHan, SoLuong, ViTri, YeuCau) values ('6/5/2024', 11, '8/9/3786', 44.53334, 'Fresher', 'Python');

-- PHIEUDKUNGTUYEN --
delete from PHIEUDKUNGTUYEN;
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (12, 9, '04/06/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (9, 13, '01/22/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (10, 7, '04/07/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (13, 13, '04/06/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (5, 4, '01/09/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (2, 23, '01/28/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (19, 10, '03/31/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (6, 12, '04/03/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (19, 21, '01/26/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (20, 30, '03/24/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (13, 21, '03/19/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (1, 21, '02/15/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (17, 22, '02/14/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (10, 12, '03/23/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (16, 8, '02/13/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (5, 25, '01/26/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (3, 6, '01/13/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (4, 23, '01/10/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (11, 7, '03/06/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (14, 22, '01/07/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (14, 11, '02/23/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (1, 26, '02/12/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (14, 25, '03/28/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (20, 22, '03/22/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (20, 20, '03/23/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (12, 14, '02/25/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (1, 11, '01/07/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (20, 25, '04/08/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (7, 9, '02/15/2024');
insert into PHIEUDKUNGTUYEN (MaUV, MaDT, NgayLap) values (17, 4, '03/01/2024');

-- BANGCAP --
delete from BANGCAP;
DBCC CHECKIDENT ('BANGCAP', RESEED, 1);
insert into BANGCAP (TenBang, MaUV) values ('CCNP', 9);
insert into BANGCAP (TenBang, MaUV) values ('CompTIA Network+', 11);
insert into BANGCAP (TenBang, MaUV) values ('CompTIA Security+', 9);
insert into BANGCAP (TenBang, MaUV) values ('Certified Ethical Hacker (CEH)', 16);
insert into BANGCAP (TenBang, MaUV) values ('Certified Ethical Hacker (CEH)', 16);
insert into BANGCAP (TenBang, MaUV) values ('Oracle Certified Professional (OCP)', 3);
insert into BANGCAP (TenBang, MaUV) values ('CompTIA Security+', 2);
insert into BANGCAP (TenBang, MaUV) values ('CompTIA A+', 17);
insert into BANGCAP (TenBang, MaUV) values ('CompTIA Security+', 5);
insert into BANGCAP (TenBang, MaUV) values ('AWS Certified Solutions Architect', 13);
insert into BANGCAP (TenBang, MaUV) values ('Microsoft Certified: Azure Administrator Associate', 18);
insert into BANGCAP (TenBang, MaUV) values ('Microsoft Certified: Azure Administrator Associate', 5);
insert into BANGCAP (TenBang, MaUV) values ('ITIL Foundation', 16);
insert into BANGCAP (TenBang, MaUV) values ('CCNA', 3);
insert into BANGCAP (TenBang, MaUV) values ('CompTIA Network+', 17);
insert into BANGCAP (TenBang, MaUV) values ('ITIL Foundation', 9);
insert into BANGCAP (TenBang, MaUV) values ('AWS Certified Solutions Architect', 6);
insert into BANGCAP (TenBang, MaUV) values ('ITIL Foundation', 16);
insert into BANGCAP (TenBang, MaUV) values ('CompTIA A+', 9);
insert into BANGCAP (TenBang, MaUV) values ('AWS Certified Solutions Architect', 14);
insert into BANGCAP (TenBang, MaUV) values ('Oracle Certified Professional (OCP)', 15);
insert into BANGCAP (TenBang, MaUV) values ('Certified Ethical Hacker (CEH)', 2);
insert into BANGCAP (TenBang, MaUV) values ('Oracle Certified Professional (OCP)', 19);
insert into BANGCAP (TenBang, MaUV) values ('AWS Certified Solutions Architect', 3);
insert into BANGCAP (TenBang, MaUV) values ('AWS Certified Solutions Architect', 15);
insert into BANGCAP (TenBang, MaUV) values ('CompTIA A+', 18);
insert into BANGCAP (TenBang, MaUV) values ('CCNP', 13);
insert into BANGCAP (TenBang, MaUV) values ('Microsoft Certified: Azure Administrator Associate', 16);
insert into BANGCAP (TenBang, MaUV) values ('Oracle Certified Professional (OCP)', 17);
insert into BANGCAP (TenBang, MaUV) values ('Oracle Certified Professional (OCP)', 1);

-- HOSOUNGTUYEN --
delete from HOSOUNGTUYEN;
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (12, 9, 3, 'Completed');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (9, 13, 2, 'Active');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (10, 7, 4, 'Active');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (13, 13, 10, 'Cancelled');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (5, 4, 9, 'Cancelled');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (2, 23, 4, 'Completed');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (20, 6, 2, 'Inactive');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (19, 10, 4, 'Active');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (6, 12, 4, 'Active');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (19, 21, 3, 'Cancelled');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (20, 30, 3, 'Inactive');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (1, 21, 7, 'InProgress');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (17, 22, 10, 'InProgress');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (10, 12, 4, 'Inactive');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (16, 8, 6, 'Active');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (5, 25, 4, 'Completed');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (3, 6, 1, 'Cancelled');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (4, 23, 10, 'Active');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (11, 7, 2, 'Inactive');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (14, 22, 4, 'Active');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (14, 11, 6, 'InProgress');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (1, 26, 6, 'Completed');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (14, 25, 5, 'Active');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (20, 22, 6, 'Completed');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (20, 20, 3, 'Completed');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (12, 14, 5, 'Active');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (1, 11, 9, 'Completed');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (20, 25, 3, 'Completed');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (7, 9, 6, 'InProgress');
insert into HOSOUNGTUYEN (MaUV, MaDT, MaNV, TinhTrang) values (17, 4, 4, 'InProgress');

-- HSUT_BANGCAP --
delete from HSUT_BANGCAP;
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (9, 3, 8, 2, 'Verified');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (26, 3, 3, 24, 'Expired');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (18, 16, 9, 21, 'Pending');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (28, 4, 1, 6, 'Verified');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (9, 6, 9, 2, 'Expired');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (26, 4, 4, 14, 'Pending');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (6, 9, 5, 19, 'Verified');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (13, 7, 7, 12, 'Expired');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (17, 1, 6, 26, 'Pending');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (11, 7, 1, 1, 'Verified');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (21, 5, 6, 3, 'Expired');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (2, 16, 5, 27, 'Pending');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (29, 1, 6, 20, 'Verified');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (27, 1, 7, 1, 'Expired');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (3, 2, 1, 2, 'Pending');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (1, 3, 8, 25, 'Verified');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (8, 11, 7, 25, 'Expired');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (19, 12, 6, 10, 'Pending');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (26, 13, 3, 12, 'Verified');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (10, 6, 1, 15, 'Expired');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (30, 13, 1, 6, 'Pending');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (13, 8, 1, 26, 'Verified');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (4, 12, 8, 11, 'Expired');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (15, 8, 7, 14, 'Pending');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (8, 10, 4, 24, 'Verified');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (11, 5, 1, 16, 'Expired');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (2, 18, 4, 4, 'Pending');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (18, 4, 1, 20, 'Verified');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (3, 20, 2, 11, 'Expired');
insert into HSUT_BANGCAP (MaDT, MaUV, MaNV, MaBang, TinhTrang) values (20, 3, 4, 9, 'Pending');

-- HOPDONG --
delete from HOPDONG;
DBCC CHECKIDENT ('HOPDONG', RESEED, 1);
select * from HOPDONG
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (6, 4, '12/22/2024', '7/28/2024', 'auctor sed tristique in tempus sit amet sem fusce consequat', NULL, 2, 1583682, '1', 0.1);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (5, 14, '5/3/2030', '3/29/2024', 'a nibh in quis justo maecenas', NULL, 2, 678209, '0', 0.3);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (4, 4, '3/5/2028', '2/9/2024', 'vestibulum aliquet ultrices erat tortor sollicitudin mi sit', NULL, 3, 593660, '1', 0.7);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (1, 18, '3/19/2025', '10/26/2024', 'nulla ac enim in tempor turpis nec euismod scelerisque', NULL, 3, 953503, '0', 0.7);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (9, 9, '7/31/2031', '2/7/2024', 'cursus id turpis integer aliquet', NULL, 3, 1827448, '1', 0.4);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (3, 12, '1/16/2031', '5/17/2024', 'aliquet at feugiat non pretium quis lectus', NULL, 1, 334440, '0', 0.4);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (4, 10, '5/19/2030', '3/10/2024', 'ut massa volutpat convallis morbi odio', NULL, 3, 1221181, '1', 0.7);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (5, 16, '6/20/2030', '1/15/2024', 'nec dui luctus rutrum nulla tellus in', NULL, 3, 1412695, '0', 0.8);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (1, 11, '8/4/2025', '1/20/2024', 'ut massa volutpat convallis morbi odio', NULL, 1, 280062, '1', 0.7);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (9, 7, '8/13/2027', '2/16/2024', 'pede ullamcorper augue a suscipit nulla elit', NULL, 2, 531035, '0', 0.2);

insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (2, 8, '3/25/2026', '10/29/2024', 'elementum eu interdum eu tincidunt in leo maecenas', 8, 1, 475190, '1', 0.8);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (8, 14, '6/3/2025', '4/4/2024', 'venenatis non sodales sed tincidunt eu felis', 7, 1, 2204517, '0', 0.5);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (7, 1, '9/5/2031', '6/20/2024', 'adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus', 3, 1, 1697671, '1', 0.9);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (6, 2, '7/7/2029', '1/2/2024', 'nibh fusce lacus purus aliquet', 8, 2, 2318894, '0', 0.4);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (5, 15, '8/15/2029', '2/9/2024', 'dapibus nulla suscipit ligula in lacus curabitur at ipsum ac', 5, 4, 1810918, '1', 0.7);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (4, 14, '6/18/2029', '7/24/2024', 'commodo placerat praesent blandit nam nulla integer pede justo lacinia', 1, 3, 2220281, '0', 0.7);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (7, 20, '5/27/2024', '2/16/2024', 'condimentum id luctus nec molestie sed justo pellentesque', 10, 3, 1223049, '1', 0.6);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (2, 7, '6/30/2027', '5/9/2024', 'etiam pretium iaculis justo in hac habitasse platea dictumst', 2, 4, 511316, '0', 0.4);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (6, 18, '3/18/2029', '7/11/2024', 'accumsan tortor quis turpis sed ante', 1, 3, 1585948, '1', 0.3);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (6, 5, '10/25/2030', '10/10/2024', 'ut dolor morbi vel lectus in quam fringilla rhoncus mauris', 1, 2, 123977, '0', 0.8);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (4, 3, '2/11/2031', '10/30/2024', 'risus dapibus augue vel accumsan tellus', 1, 3, 2922058, '1', 0.9);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (6, 3, '7/8/2030', '5/27/2024', 'dolor sit amet consectetuer adipiscing', 2, 3, 1933209, '0', 0.4);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (2, 8, '2/22/2033', '2/25/2024', 'eu orci mauris lacinia sapien quis libero nullam sit amet', 3, 1, 1864317, '1', 0.1);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (6, 16, '12/10/2025', '8/17/2024', 'lacinia erat vestibulum sed magna at nunc commodo placerat', 7, 2, 2241832, '0', 0.2);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (6, 6, '7/31/2033', '4/8/2024', 'potenti in eleifend quam a odio in', 10, 3, 1627021, '1', 0.6);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (9, 15, '4/25/2033', '6/8/2024', 'pharetra magna ac consequat metus sapien ut nunc vestibulum ante', 3, 1, 1650404, '0', 0.5);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (8, 5, '11/23/2024', '5/28/2024', 'lacinia eget tincidunt eget tempus vel', 4, 4, 2088435, '1', 0.1);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (3, 1, '11/10/2024', '7/11/2024', 'quam suspendisse potenti nullam porttitor lacus at turpis donec', 6, 3, 447763, '0', 0.2);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (10, 16, '12/18/2025', '8/27/2024', 'vulputate ut ultrices vel augue', 1, 3, 1685071, '1', 0.5);
insert into HOPDONG (MaNV, MaDN, NgKy, NgHetHan, NoiDung, PhuLuc, SoDotTT, SoTienTT, TinhTrangKyDuyet, UuDai) values (4, 17, '11/16/2028', '7/30/2024', 'faucibus orci luctus et ultrices posuere cubilia', 7, 3, 1898137, '0', 0.4);


-- PHIEUDKQUANGCAO --
delete from PHIEUDKQUANGCAO;
select * from PHIEUDKQUANGCAO
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (3, 26, 16, '3/23/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (3, 19, 4, '3/29/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (1, 7, 7, '3/6/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (2, 22, 13, '3/10/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (1, 12, 21, '3/4/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (2, 3, 28, '1/27/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (2, 19, 12, '3/24/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (2, 24, 11, '2/9/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (3, 8, 18, '2/26/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (2, 10, 21, '3/30/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (1, 21, 27, '2/26/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (2, 7, 23, '2/3/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (3, 11, 28, '2/12/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (1, 25, 30, '1/9/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (3, 30, 27, '1/2/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (2, 4, 21, '1/21/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (1, 17, 10, '1/27/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (3, 3, 8, '1/2/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (1, 20, 26, '4/5/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (1, 28, 8, '2/23/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (1, 30, 30, '4/5/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (2, 18, 2, '2/26/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (2, 7, 19, '2/28/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (3, 4, 11, '1/16/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (2, 6, 20, '4/4/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (1, 5, 18, '1/29/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (3, 13, 23, '4/6/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (3, 22, 4, '1/9/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (3, 12, 27, '2/6/2024');
insert into PHIEUDKQUANGCAO (MaHT, MaDT, MaHDong, NgayLap) values (3, 14, 21, '2/7/2024');

-- PHIEUTHU --
delete from PHIEUTHU;
DBCC CHECKIDENT ('PHIEUTHU', RESEED, 1);
select * from PHIEUTHU
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (7, 4, '3/20/2024', 2509869, 21);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (5, 3, '1/16/2024', 63521, 28);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (1, 1, '11/13/2023', 21605, 20);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (1, 4, '12/12/2023', 1159103, 5);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (8, 1, '11/29/2023', 88905, 9);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (8, 1, '2/22/2024', 1543228, 29);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (10, 3, '11/11/2023', 1015996, 14);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (8, 3, '3/25/2024', 88897, 11);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (5, 2, '3/11/2024', 241881, 25);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (5, 4, '2/5/2024', 139300, 13);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (10, 1, '12/7/2023', 227613, 11);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (10, 3, '11/2/2023', 108061, 6);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (10, 1, '1/16/2024', 61164, 28);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (3, 3, '3/4/2024', 181723, 10);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (3, 2, '2/28/2024', 237318, 13);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (4, 4, '3/16/2024', 157402, 26);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (2, 3, '10/22/2023', 245983, 25);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (10, 4, '1/12/2024', 116104, 19);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (1, 2, '11/29/2023', 110626, 2);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (6, 4, '2/5/2024', 19423, 11);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (9, 3, '10/5/2023', 296852, 24);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (10, 4, '12/22/2023', 273923, 25);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (8, 2, '3/19/2024', 138822, 14);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (7, 4, '10/4/2023', 14998, 11);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (2, 2, '2/17/2024', 65110, 13);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (8, 1, '1/25/2024', 266120, 25);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (6, 1, '11/24/2023', 73338, 1);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (4, 3, '1/19/2024', 107989, 29);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (8, 2, '12/14/2023', 169705, 5);
insert into PHIEUTHU (MaNV, DotThu, NgayThu, SoTien, MaHDong) values (1, 4, '3/1/2024', 164172, 25);

-- HOADON --
delete from HOADON;
DBCC CHECKIDENT ('HOADON', RESEED, 1);
select * from HOADON
insert into HOADON (MaNV, MaHDong) values (10, 1);
insert into HOADON (MaNV, MaHDong) values (8, 2);
insert into HOADON (MaNV, MaHDong) values (9, 3);
insert into HOADON (MaNV, MaHDong) values (2, 4);
insert into HOADON (MaNV, MaHDong) values (4, 5);
insert into HOADON (MaNV, MaHDong) values (10, 6);
insert into HOADON (MaNV, MaHDong) values (6, 7);
insert into HOADON (MaNV, MaHDong) values (6, 8);
insert into HOADON (MaNV, MaHDong) values (6, 9);
insert into HOADON (MaNV, MaHDong) values (10, 10);
insert into HOADON (MaNV, MaHDong) values (8, 11);
insert into HOADON (MaNV, MaHDong) values (5, 12);
insert into HOADON (MaNV, MaHDong) values (7, 13);
insert into HOADON (MaNV, MaHDong) values (2, 14);
insert into HOADON (MaNV, MaHDong) values (2, 15);
insert into HOADON (MaNV, MaHDong) values (5, 16);
insert into HOADON (MaNV, MaHDong) values (6, 17);
insert into HOADON (MaNV, MaHDong) values (1, 18);
insert into HOADON (MaNV, MaHDong) values (1, 19);
insert into HOADON (MaNV, MaHDong) values (1, 20);