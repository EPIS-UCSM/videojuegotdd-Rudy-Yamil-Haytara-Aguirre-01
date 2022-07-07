using UnityEngine;

public class Paletas : MonoBehaviour
{
    [SerializeField] private float velocidad = 7f;
    [SerializeField] private bool esPaleta1;
    [SerializeField] private float yLimite = 3.75f;


    // Update is called once per frame
    void Update()
    {
        float movimiento;
        if(esPaleta1){
            movimiento = Input.GetAxisRaw("Vertical");
        }
        else{
            movimiento = Input.GetAxisRaw("Vertical2");
        }

        Vector2 PosicionPaletas = transform.position;
        PosicionPaletas.y = Mathf.Clamp(PosicionPaletas.y + movimiento * velocidad * Time.deltaTime, 
            -yLimite, yLimite);

        transform.position = PosicionPaletas;

       
    }
}
