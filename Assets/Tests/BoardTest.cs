using NUnit.Framework;
using UnityEngine;
using SnakesAndLadders;
using System.Collections.Generic;

[TestFixture]
public class BoardTest : MonoBehaviour
{
    [Test]
    public void SnakeOrLadderMoveOffset_UpBy2()
    {
        var board = new Board();
        //Assert.AreEqual(2, board.SnakeOrLadderMoveOffset(0));
        Assert.IsTrue(false);
    }

    [Test]
    public void SnakeOrLadderMoveOffset_DownBy2()
    {
        var board = new Board();
        //Assert.AreEqual(-2, board.SnakeOrLadderMoveOffset(3));
        Assert.IsTrue(false);
    }
}
