using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PelotaMoves : MonoBehaviour
{
    
    private GameObject objetoPelota;
    //private Transform pelota;
    
    [SetUp]
    public void Setup()
    {
        //objetoPelota = GameObject.Find("Pelota");
        objetoPelota = GameObject.Instantiate(new GameObject());
        //pelota = objetoPelota.AddComponent<Pelota>();

    }
    
    [UnityTest]
    public IEnumerator PelotaMovesWithEnumeratorPasses()
    {
        yield return null;

        //var objetoPelota = GameObject.FindGameObjectWithTag("pelota");
        //var asdf = GameObject.Instantiate(objetoPelota);

    
        Vector2 posicionInicial = objetoPelota.transform.position;

        yield return new WaitForSeconds(0.1f);
        
        Vector2 nuevaPosicion =  objetoPelota.transform.position;

        Assert.AreNotEqual(nuevaPosicion, posicionInicial);       

    }
}
