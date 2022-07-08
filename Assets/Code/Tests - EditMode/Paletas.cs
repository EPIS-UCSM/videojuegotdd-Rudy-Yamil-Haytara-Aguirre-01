using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Paletas
{

    private GameObject Paletas01;
    private GameObject Paletas02;

    [Test]
    public void Paletas01Existen()
    {
        Paletas01 = GameObject.Find("Paleta01");
        Assert.That(Paletas01.transform.position.x == 7.5);     
    }

    [Test]
    public void Paletas02Existen()
    {
        Paletas02 = GameObject.Find("Paleta02");
        Assert.That(Paletas02.transform.position.x == -7.5);
        
    }

    
}

