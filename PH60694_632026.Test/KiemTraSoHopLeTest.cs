namespace PH60694_632026.Test;
[TestFixture]

public class KiemTraSoHopLeTest
{
    public KiemTraSoHopLe kiemTraSoHopLe = null;
    [SetUp]
    public void Setup()
    {
        kiemTraSoHopLe = new KiemTraSoHopLe();
    }

    [Test]
    public void Test_SoNhoHon1()
    {
        Assert.That(kiemTraSoHopLe.KiemTra(0), Is.False);
    }
    [Test]
    public void Test_SoNhoHon50()
    {
        Assert.That(kiemTraSoHopLe.KiemTra(51), Is.False);
    }
    [Test]
    public void Test_SoChiaHetCho8()
    {
        Assert.That(kiemTraSoHopLe.KiemTra(16), Is.False);
    }
    [Test]
    public void Test_SoHopLe()
    {
        Assert.That(kiemTraSoHopLe.KiemTra(25), Is.True);
    }
    [Test]
    public void Test_SoHopLe50()
    {
        Assert.That(kiemTraSoHopLe.KiemTra(50), Is.True);
    }
}
