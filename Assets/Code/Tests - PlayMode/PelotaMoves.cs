using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PelotaMoves : MonoBehaviour
{
    
    private GameObject objetoPelota;
    private Rigidbody2D pelotaRB;
    
    [SetUp]
    public void Setup()
    {
        
        objetoPelota = GameObject.Instantiate(new GameObject());
        pelotaRB = objetoPelota.AddComponent<Rigidbody2D>();

    }
    
    [UnityTest]
    public IEnumerator PelotaMovesWithEnumeratorPasses()
    {
        yield return null;
    
        Vector2 posicionInicial = pelotaRB.transform.position;

        yield return new WaitForSeconds(0.1f);
        
        Vector2 nuevaPosicion =  pelotaRB.transform.position;

        Assert.AreNotEqual(nuevaPosicion, posicionInicial);       

    }
}
