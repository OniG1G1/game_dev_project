using UnityEngine;
using UnityEngine.UI;

public class menuController : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject descrPanel;
    public GameObject menuPanel;
    private enum ScreenState { Title, Descr, Menu }
    private ScreenState currentState;

    void Start()
    {
        currentState = ScreenState.Title;
        UpdateScreen();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SwitchScreen();
        }
    }

    void SwitchScreen()
    {
        if (currentState == ScreenState.Title)
        {
            currentState = ScreenState.Descr;
        }
        else if (currentState == ScreenState.Descr)
        {
            currentState = ScreenState.Menu;
        }
        UpdateScreen();
    }

    void UpdateScreen()
    {
        titleScreen.SetActive(currentState == ScreenState.Title);
        descrPanel.SetActive(currentState == ScreenState.Descr);
        menuPanel.SetActive(currentState == ScreenState.Menu);
    }
}
