using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using TMPro;

public class Score
{
    private TMP_Text Score01;
    private GameObject Score02;


    [Test]
    public void Score01Inicial()
    {
        Score01 = TMP_Text.Find("Puntaje01");
        Assert.That(Score01.text == 0 );
    }

   
/*
    [UnityTest]
    public IEnumerator ScoreWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
*/
}
