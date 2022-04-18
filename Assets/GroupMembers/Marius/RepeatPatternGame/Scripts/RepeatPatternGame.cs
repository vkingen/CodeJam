using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Source: https://www.youtube.com/watch?v=PC02l13iew8

public class RepeatPatternGame : MonoBehaviour
{
    [SerializeField] GameObject[] buttons; //Array of buttons that are to be pressed based on the pattern. 
    [SerializeField] GameObject[] lightArray; //Array containing the images that change color to form a pattern.
    [SerializeField] GameObject[] rowLights; //Array containing the row of images that change color according to level.
    [SerializeField] int[] lightOrder; //This contains the randomly generated light order

    [SerializeField] GameObject repeatPatternGamePanel;
    [SerializeField] GameObject startGameButton;
    [SerializeField] GameObject instructionClue;

    private int _level = 0;
    private int _buttonsClicked;
    private int _colorOrderRunCount;

    public float lightDuration;
    public float blinkDuration;

    private bool _passed = false;
    private bool _won = false;

    Color32 red = new Color32(255, 39, 0, 255);
    Color32 green = new Color32(4, 204, 0, 255);
    Color32 invisible = new Color32(4, 204, 0, 0);
    Color32 white = new Color32(255, 255, 255, 255);

    private void Start()
    {
        repeatPatternGamePanel.SetActive(false);
    }

    public void StartGame()
    {
        startGameButton.SetActive(false);
        instructionClue.SetActive(false);
        repeatPatternGamePanel.SetActive(true);
    }


    public void OnEnable()
    {
        _level = 0;
        _buttonsClicked = 0;
        _colorOrderRunCount = -1; //because we add one and we want this value to be set to 0 at start.
        _won = false;
        for(int i = 0; i < lightOrder.Length; i++) //Checks to see when i is less than the lighOrder length
        {
            lightOrder[i] = (Random.Range(0, 8));
        }
        for(int i = 0; i < rowLights.Length; i++)
        {
            rowLights[i].GetComponent<Image>().color = white;
        }

        _level = 1;

        if(repeatPatternGamePanel == isActiveAndEnabled) //Only when the 'Panel' is active is the 'ColorOrder()' method running
        {
            StartCoroutine(ColorOrder());
        }
    }
    public void ButtonClickOrder(int button)
    {
        _buttonsClicked++;
        if(button == lightOrder[_buttonsClicked - 1])
        {
            Debug.Log("Pass");
            _passed = true;
        }
        else
        {
            Debug.Log("failed");
            _won = false;
            _passed = false;
            StartCoroutine(ColorBlink(red));
        }
        if (_buttonsClicked == _level && _passed == true && _buttonsClicked != 5)
        {
            _level++;
            _passed = false;
            StartCoroutine(ColorOrder());
        }
        if(_buttonsClicked == _level && _passed == true && _buttonsClicked == 5)
        {
            Debug.Log("failed");
            _won = true;
            StartCoroutine(ColorBlink(green));
        }
    }

    public void ClosePanel() //Sets the 'Panel' gameobject not active
    {
        repeatPatternGamePanel.SetActive(false);
    }

    public void OpenPanel() //Sets the 'Panel' gameobject to active
    {
        repeatPatternGamePanel.SetActive(true);
    }

    IEnumerator ColorBlink(Color32 colorToBlink) //Controls the colors that blink when winning or failing
    {
        DisableInteractableButtons();

        for(int j = 0; j < 3; j++) //This for loop controls t
        {
            Debug.Log("I run this many times" + j);


            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Image>().color = colorToBlink;
            }
            for (int i = 0; i < rowLights.Length; i++)
            {
                rowLights[i].GetComponent<Image>().color = colorToBlink;
            }

            yield return new WaitForSeconds(blinkDuration);

            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Image>().color = white;
            }
            for (int i = 5; i < rowLights.Length; i++)
            {
                rowLights[i].GetComponent<Image>().color = white;
            }

            yield return new WaitForSeconds(blinkDuration);
        }

        if (_won == true)
        {
            ClosePanel();
            MainSceneManager.instance.LoadNextScene(1);
        }

        EnableInteractableButtons();
        OnEnable();
    }
    IEnumerator ColorOrder()
    {
        _buttonsClicked = 0;
        _colorOrderRunCount++;
        DisableInteractableButtons();

        for(int i = 0; i <= _colorOrderRunCount; i++)
        {
            if(_level >= _colorOrderRunCount)
            {
                lightArray[lightOrder[i]].GetComponent<Image>().color = invisible;
                yield return new WaitForSeconds(lightDuration);
                lightArray[lightOrder[i]].GetComponent<Image>().color = green;
                yield return new WaitForSeconds(lightDuration);
                lightArray[lightOrder[i]].GetComponent<Image>().color = invisible;
                rowLights[i].GetComponent<Image>().color = green;
            }             
        }
        EnableInteractableButtons();
    }
    void DisableInteractableButtons()
    {
        for(int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<Button>().interactable = false;
        }
    }
    void EnableInteractableButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<Button>().interactable = true;
        }
    }
}
