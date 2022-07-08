using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Meta
{
    private GameObject MetaI;
    private GameObject MetaD;


    // A Test behaves as an ordinary method
    [Test]
    public void MetaIExisten()
    {
        MetaI = GameObject.Find("Meta01");
        Assert.That(MetaI.transform.position.x == -8.4f );        
    }

    [Test]
    public void MetaDExisten()
    {
        MetaD = GameObject.Find("Meta02");
        Assert.That(MetaD.transform.position.x == 8.4f);
    }
    
}