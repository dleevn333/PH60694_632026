namespace PH60694_632026.Test;

public class NhanVienServiceTest
{
    private NhanVienService nhanVienService = null;
    [SetUp]
    public void Setup()
    {
        nhanVienService = new NhanVienService();
    }

    [Test]
    public void KiemTraMaNVDaTonTai_ThanhCong()
    {
        Assert.That(nhanVienService.KiemTraToiTaiRoi("NV01"), Is.True);
    }
    [Test]
    public void SuaNhanVien_ThanhCong()
    {
        var nhanVienMoi = new NhanVien() { maNV = "NV01", Ten = "Nguyen Van A", luong = 7000, soNamLamViec = 6, phongBan = "IT" };
        var result = nhanVienService.SuaNhanVien(nhanVienMoi);
        Assert.That(result, Is.True);
        var after = nhanVienService.GetByMaNhanVien("NV01");
        Assert.That(after.Ten, Is.EqualTo("Nguyen Van A"));
        Assert.That(after.luong, Is.EqualTo(7000));
        Assert.That(after.soNamLamViec, Is.EqualTo(6));
        Assert.That(after.phongBan, Is.EqualTo("IT"));

    }
    [Test]
    public void SuaNhanVien_KhongTonTai_ThatBai()
    {
        var nhanVienMoi = new NhanVien() { maNV = "NV99", Ten = "Nguyen Van Z", luong = 7000, soNamLamViec = 6, phongBan = "IT" };
        var result = nhanVienService.SuaNhanVien(nhanVienMoi);
        Assert.That(result, Is.False);
    }
     [Test]
     public void SuaNhanVien_LuongAm_ThatBai()
     {
         var nhanVienMoi = new NhanVien() { maNV = "NV01", Ten = "Nguyen Van A", luong = -1000, soNamLamViec = 6, phongBan = "IT" };
         var result = nhanVienService.SuaNhanVien(nhanVienMoi);
         Assert.That(result, Is.False);
    }
    [Test]
    public void SuaNhanVien_SoNamLamViecAm_ThatBai()
    {
        var nhanVienMoi = new NhanVien() { maNV = "NV01", Ten = "Nguyen Van A", luong = 7000, soNamLamViec = -1, phongBan = "IT" };
        var result = nhanVienService.SuaNhanVien(nhanVienMoi);
        Assert.That(result, Is.False);
    }
    [Test]
    public void SuaNhanVien_Null_ThatBai()
    {
        var result = nhanVienService.SuaNhanVien(null);
        Assert.That(result, Is.False);
    }
    [Test]
    public void SuaNhanVien_MaNVNull_ThatBai()
    {
        var nhanVienMoi = new NhanVien() { maNV = "", Ten = "Nguyen Van A", luong = 7000, soNamLamViec = 6, phongBan = "IT" };
        var result = nhanVienService.SuaNhanVien(nhanVienMoi);
        Assert.That(result, Is.False);
    }
}
