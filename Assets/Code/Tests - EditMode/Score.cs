using NUnit.Framework;
using UnityEngine;

public class Score
{
    private GameObject canva01;
    private GameObject canva02;    


    [Test]
    public void Score1Existe()
    {
        canva01 = GameObject.Find("Puntaje01");
        //Assert.IsNotNull(canva01);
        Assert.That(canva01.transform.position.x == 401.796875f);
    }

    [Test]
    public void Score2Existe()
    {
        canva02 = GameObject.Find("Puntaje02");
        Assert.That(canva02.transform.position.x == 293.203125f);
    }


}
