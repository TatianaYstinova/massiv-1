using Arrays;
namespace TestArrays
{
    public class UnitTest1
    {
        [TestCase(new int[] { 2, 4, 6 }, 6)]
        [TestCase(new int[] { 2 }, 2)]
        [TestCase(new int[] { 1, 4, 13, 9, 5, -3 }, 13)]
        public static void EmployeeRatingTest(int[] EmployeeRating, int expected)
        {
            int actual = RatingSystem.EmployeeRating(EmployeeRating);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new double[] { 1 }, new double[] { 1.18 })]
        public static void ProductsFromSuppliersTest(double[] ProductsFromSuppliers, double[] expected)
        {
            double[] actual = RatingSystem.ProductsFromSuppliers(ProductsFromSuppliers);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 3 }, 250,0)]
        public static void SalesAmountsOfEachEmployee(  int[] SalesAmountsOfEachEmployee ,int SalesPlan, int expected)
        {
            int actual = RatingSystem.SalesAmountsOfEachEmployee (SalesAmountsOfEachEmployee,SalesPlan);

            Assert.AreEqual(expected, actual);
        }




}
    }