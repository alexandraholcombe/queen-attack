using Xunit;
namespace QueenAttack.Objects
{
  public class QueenTest
  {
    [Fact]
    public void Queen_ForMatchingCoordinates_false()
    {
      Queen testQueen = new Queen(1,1);
      Assert.Equal(false, testQueen.CanAttack(testQueen,1,1));
    }

    [Fact]
    public void Queen_ForUnalignedCoordinates_false()
    {
      Queen testQueen = new Queen(1,1);
      Assert.Equal(false, testQueen.CanAttack(testQueen,3,2));
    }

    [Fact]
    public void Queen_ForMatchingYCoordinates_true()
    {
      Queen testQueen = new Queen(1,1);
      Assert.Equal(true, testQueen.CanAttack(testQueen,8,1));
    }

    [Fact]
    public void Queen_ForMatchingXCoordinates_true()
    {
      Queen testQueen = new Queen(1,1);
      Assert.Equal(true, testQueen.CanAttack(testQueen,1,8));
    }

    [Fact]
    public void Queen_ForNESWDiagonal_true()
    {
      Queen testQueen = new Queen(2,3);
      Assert.Equal(true, testQueen.CanAttack(testQueen,5,6));
    }

    [Fact]
    public void Queen_ForNWSEDiagonal_true()
    {
      Queen testQueen = new Queen(1,6);
      Assert.Equal(true, testQueen.CanAttack(testQueen,5,2));
    }
  }
}
