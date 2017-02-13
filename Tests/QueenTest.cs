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
    
  }
}
