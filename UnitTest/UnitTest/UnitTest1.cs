using StudentServiceLib;

namespace UnitTest
{
    [TestClass]
    public class TestScoreStudent
    {
        [TestMethod]
        public void IfScoreGreaterThan10_ResultShouldThrow_SystemException()
        {
            Student s = new Student();

            bool exceptionOccured = false;

            try
            {
                s.Score = 14;
            }
            catch(SystemException e)
            {
                exceptionOccured = true;
            }

            Assert.IsTrue(exceptionOccured);
        }

        [TestMethod]
        public void IfScoreIs8_ResultEqualA()
        {
            Student s = new Student();

            s.Score = 8;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void IfScoreIs7_ResultEqualB()
        {
            Student s = new Student();

            s.Score = 7;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void IfScoreIs5_ResultEqualC()
        {
            Student s = new Student();

            s.Score = 5;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void IfScoreIs3dot5_ResultEqualD()
        {
            Student s = new Student();

            s.Score = 3.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void IfScoreIs2_ResultEqualE()
        {
            Student s = new Student();

            s.Score = 2;

            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }
    }
}