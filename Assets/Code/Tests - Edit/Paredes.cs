using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Paredes
{
    private GameObject Pared01;
    private GameObject Pared02;
    private GameObject Pared03;

  

    // A Test behaves as an ordinary method
    [Test]
    public void Pared01Existe()
    {
        Pared01 = GameObject.Find("ParedArriba");
        Assert.That(Pared01.transform.position.y == 4.5);
        
    }

    [Test]
    public void Pared02Existe()
    {
        Pared02 = GameObject.Find("ParedAbajo");
        Assert.That(Pared02.transform.position.y == -4.5);
        
    }

    [Test]
    public void Paredmedio()
    {
        Pared03 = GameObject.Find("LineaMedio");
        Assert.That(Pared02.transform.position.x == 0);
        
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    
}
