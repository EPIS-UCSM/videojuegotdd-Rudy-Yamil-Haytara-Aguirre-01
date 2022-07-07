using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text puntaje01Text;
    [SerializeField] private TMP_Text puntaje02Text;

    [SerializeField] private Transform P01Transform;
    [SerializeField] private Transform P02Transform; 
    [SerializeField] private Transform pelotaTransform;

    private int puntaje01;
    private int puntaje02;

    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if(instance == null){
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    public void paleta01puntaje()
    {
        puntaje01++;
        puntaje01Text.text = puntaje01.ToString();
    }
    public void paleta02puntaje()
    {
        puntaje02++;
        puntaje02Text.text = puntaje02.ToString();
    }

    public void Restart()
    {
        P01Transform.position = new Vector2(P01Transform.position.x, 0);
        P02Transform.position = new Vector2(P02Transform.position.x, 0);
        pelotaTransform.position = new Vector2(0, 0);
    }
}
