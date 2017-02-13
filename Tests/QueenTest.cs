using Xunit;
namespace QueenAttack.Objects
{
  public class QueenTest
  {
    [Fact]
    public void Queen_ForMatchingCoordinates_false()
    {
      Queen testQueen = new Queen(1,1);
      Assert.Equal(false, testQueen.CanAttack(1,1))
    }
  }
}
