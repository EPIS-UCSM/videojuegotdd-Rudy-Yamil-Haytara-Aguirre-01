using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Pelota : MonoBehaviour
{

    [SerializeField] private float velocidadInicial = 4f;
    [SerializeField] private float MultiplicadordeVelocidad = 1.1f;

    private Rigidbody2D pelotaRB;


    // Start is called before the first frame update
    void Start()
    {
        pelotaRB = GetComponent<Rigidbody2D>();
        Lanzar();
    }

    private void Lanzar()
    {
        float xVelocidad = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocidad = Random.Range(0, 2) == 0 ? 1 : -1;
        pelotaRB.velocity = new Vector2(xVelocidad, yVelocidad) * velocidadInicial;

    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Paleta"))
        {
            pelotaRB.velocity *= MultiplicadordeVelocidad;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("meta1"))
        {
            GameManager.Instance.paleta01puntaje();
            GameManager.Instance.Restart();
            Lanzar();

        }
        else
        {
            GameManager.Instance.paleta02puntaje();
            GameManager.Instance.Restart();
            Lanzar();

        }
    }


}
