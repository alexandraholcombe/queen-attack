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
  }
}
