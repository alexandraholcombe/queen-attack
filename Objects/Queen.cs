using System.Collections.Generic;
using System;
using Nancy;

namespace QueenAttack.Objects
{
  public class Queen
  {
    private int _qXCoord;
    private int _qYCoord;
    private int _pXCoord;
    private int _pYCoord;


    public Queen(int qXCoord, int qYCoord, int pXCoord, int pYCoord)
    {
      _qXCoord = qXCoord;
      _qYCoord = qYCoord;
      _pXCoord = pXCoord;
      _pYCoord = pYCoord;
    }

    public int GetQXCoord()
    {
      return _qXCoord;
    }
    public void SetQXCoord(int inputQXCoord)
    {
      _qXCoord = inputQXCoord;
    }

    public int GetQYCoord()
    {
      return _qYCoord;
    }
    public void SetQYCoord(int inputQYCoord)
    {
      _qYCoord = inputQYCoord;
    }

    public int GetPXCoord()
    {
      return _pXCoord;
    }
    public void SetPXCoord(int inputPXCoord)
    {
      _pXCoord = inputPXCoord;
    }

    public int GetPYCoord()
    {
      return _pYCoord;
    }
    public void SetPYCoord(int inputPYCoord)
    {
      _pYCoord = inputPYCoord;
    }

    public bool CanAttack(Queen newQueen)
    {
      // if (newQueen == null)
      // {
      //   newQueen =
      // }
      int qXCoord = newQueen.GetQXCoord();
      int qYCoord = newQueen.GetQYCoord();
      int pXCoord = newQueen.GetPXCoord();
      int pYCoord = newQueen.GetPYCoord();

      if ((qXCoord == pXCoord) && (qYCoord == pYCoord))
      {
        return false;
      }
      else if ((qXCoord == pXCoord) || (qYCoord == pYCoord))
      {
        return true;
      }
      else if (Math.Abs(qXCoord - pXCoord) == Math.Abs(qYCoord - pYCoord))
      {
        return true;
      }
      else if (Math.Abs(pXCoord - qXCoord) == Math.Abs(qYCoord-pYCoord))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
