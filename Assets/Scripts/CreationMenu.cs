using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CreationMenu : MonoBehaviour
{
    public TMP_InputField playerName;
    public RuntimeAnimatorController playerAnimatorController;
    public Sprite playerSprite;

    Button selectedButton;
    Color selectedButtonColor = Color.blue;
    Color defaultButtonColor = Color.white;

    [SerializeField] private Button startButton;

    void Start()
    {
        startButton.interactable = false;
    }
    void Update()
    {
        if (playerName.text != "" && selectedButton != null)
        {
            startButton.interactable = true;
        }
    }

    public void PlayGame()
    {
        PlayerData.playerName = playerName.text;
        PlayerData.playerSprite = playerSprite;
        PlayerData.newController = playerAnimatorController;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void selectController(RuntimeAnimatorController playerSelection)
    {
        playerAnimatorController = playerSelection;
    }

    public void selectSprite(Sprite selectedPlayerSprite)
    {
        playerSprite = selectedPlayerSprite;

    }

    public void ButtonClicked(Button button)
    {

        if (selectedButton == button)
        {
            button.GetComponent<Image>().color = defaultButtonColor;
            selectedButton = null;
        }
        else
        {
            if (selectedButton != null)
                selectedButton.GetComponent<Image>().color = defaultButtonColor;

            button.GetComponent<Image>().color = selectedButtonColor;
            selectedButton = button;
        }
    }

}
