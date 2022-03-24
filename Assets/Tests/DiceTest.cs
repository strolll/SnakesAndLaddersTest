using NUnit.Framework;
using UnityEngine;
using SnakesAndLadders;

[TestFixture]
public class DiceTest : MonoBehaviour
{
    [Test]
    public void DiceRandomness()
    {
        var d = new DiceUnityRandom();

        //TODO: A reasonable dice test
        Assert.IsTrue(false);
    }
}
