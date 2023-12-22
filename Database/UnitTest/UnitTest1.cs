namespace UnitTest
{
    [TestClass]
    public class PerClassTest
    {
        [TestMethod]
        public void LimbahKelolaLessThanLimbahHasil()
        {
            double textLimbahHasil = 700;
            double textLimbahKelola = 645;
            Assert.IsTrue(textLimbahHasil > textLimbahKelola, "LimbahKelola > LimbahHasil.");
        }

        [TestMethod] 
        public void SubtractionSuccess()
        {
            double textLimbahHasil = 700;
            double textLimbahKelola = 645;
            double textLimbahSimpan = 55;
            Assert.AreEqual(textLimbahHasil, textLimbahKelola, textLimbahSimpan, "Perhitungan Hasil Salah");
        }

    }
}