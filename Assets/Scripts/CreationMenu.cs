using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CreationMenu : MonoBehaviour
{
    public TMP_InputField playerName;
    public RuntimeAnimatorController playerSprite;

    public void PlayGame()
    {
        PlayerData.playerName = playerName.text;
        PlayerData.newController = playerSprite;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void selectSprite(RuntimeAnimatorController playerSelection)
    {
        playerSprite = playerSelection;
    }

}
