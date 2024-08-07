using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text xpText;
    public Text ecoCoinsText;

    private void Update()
    {
        xpText.text = "XP: " + GameManager.instance.playerXP;
        ecoCoinsText.text = "Eco Coins: " + GameManager.instance.ecoCoins;
    }
}
