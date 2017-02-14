using Xunit;
namespace QueenAttack.Objects
{
  public class QueenTest
  {
    [Fact]
    public void Queen_ForMatchingCoordinates_false()
    {
      Queen testQueen = new Queen(1,1,1,1);
      Assert.Equal(false, testQueen.CanAttack(testQueen));
    }

    [Fact]
    public void Queen_ForUnalignedCoordinates_false()
    {
      Queen testQueen = new Queen(1,1,3,2);
      Assert.Equal(false, testQueen.CanAttack(testQueen));
    }

    [Fact]
    public void Queen_ForMatchingYCoordinates_true()
    {
      Queen testQueen = new Queen(1,1,8,1);
      Assert.Equal(true, testQueen.CanAttack(testQueen));
    }

    [Fact]
    public void Queen_ForMatchingXCoordinates_true()
    {
      Queen testQueen = new Queen(1,1,1,8);
      Assert.Equal(true, testQueen.CanAttack(testQueen));
    }

    [Fact]
    public void Queen_ForSWNEDiagonal_true()
    {
      Queen testQueen = new Queen(2,3,5,6);
      Assert.Equal(true, testQueen.CanAttack(testQueen));
    }

    [Fact]
    public void Queen_ForSENWDiagonal_true()
    {
      Queen testQueen = new Queen(1,6,5,2);
      Assert.Equal(true, testQueen.CanAttack(testQueen));
    }

    [Fact]
    public void Queen_ForNESWDiagonal_true()
    {
      Queen testQueen = new Queen(3,6,2,5);
      Assert.Equal(true, testQueen.CanAttack(testQueen));
    }

    [Fact]
    public void Queen_ForNWSEDiagonal_true()
    {
      Queen testQueen = new Queen(8,1,5,4);
      Assert.Equal(true, testQueen.CanAttack(testQueen));
    }
  }
}
