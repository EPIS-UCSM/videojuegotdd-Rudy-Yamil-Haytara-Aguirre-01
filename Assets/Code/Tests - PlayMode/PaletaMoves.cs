using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PaletaMoves : MonoBehaviour
{

    private GameObject objetoPaleta;
    private Rigidbody2D paletaMv;
    private GameObject RefOP1;

    [SetUp]
    public void Setup()
    {
        
        objetoPaleta = GameObject.Instantiate(new GameObject());
        paletaMv = objetoPaleta.AddComponent<Rigidbody2D>();
        

    }

    [UnityTest]
    public IEnumerator PaletaMovesWithEnumeratorPasses()
    {
        yield return null;

        var posicionInicial = paletaMv.transform.position.y;

        yield return new WaitForSeconds(0.2f);

        var nuevaPosicion = paletaMv.transform.position.y;

        Assert.AreEqual(posicionInicial, nuevaPosicion); 

    }

}
