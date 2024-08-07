using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int playerXP;
    public int playerLevel;
    public int ecoCoins;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddXP(int amount)
    {
        playerXP += amount;
        // Logica de subir nivel
    }

    public void AddEcoCoins(int amount)
    {
        ecoCoins += amount;
    }
}
