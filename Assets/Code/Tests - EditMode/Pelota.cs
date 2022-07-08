using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Pelota
{
    private GameObject Pelota1;

    [Test]
    public void PelotaExiste()
    {
        Pelota1 = GameObject.Find("Pelota");
        Assert.That(Pelota1.transform.position.x == 0f);       
    }


}
