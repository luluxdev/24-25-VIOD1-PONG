using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int puntA;
    public TMP_Text puntAtext;
    public int puntB;
    public TMP_Text puntBtext;

    private void Update()
    {
        puntAtext.text = puntA.ToString();
        puntBtext.text = puntB.ToString();
        if (puntA >= 10 || puntB >= 10)
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }
}
