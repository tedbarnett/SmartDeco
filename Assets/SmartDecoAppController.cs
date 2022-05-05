using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmartDecoAppController : MonoBehaviour
{

    public GameObject marketPlacePanel;
    public GameObject itemViewPanelTJJ;
    public GameObject itemViewPanelRed;
    public GameObject itemViewPanelVoodoo;
    public GameObject faceCastPanel;
    public GameObject ARPumpkin;
    public GameObject devicesPanel;
    public GameObject accountPanel;
    public GameObject searchPanel;
    public GameObject Background;

    public Button marketPlaceButton;
    public Button faceCastButton;
    public Button devicesButton;
    public Button accountButton;
    public Button searchButton;

    private List<Button> ButtonList;
    public Color pressedButtonColor;

    public void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    void Start()
    {
        marketPlacePanel.SetActive(true);
        itemViewPanelTJJ.SetActive(false);
        itemViewPanelRed.SetActive(false);
        if(itemViewPanelVoodoo)
            itemViewPanelVoodoo.SetActive(false);
        faceCastPanel.SetActive(false);
        ARPumpkin.SetActive(false);
        devicesPanel.SetActive(false);
        accountPanel.SetActive(false);
        searchPanel.SetActive(false);

        marketPlaceButton.onClick.AddListener(pressedMarketPlaceButton);
        faceCastButton.onClick.AddListener(pressedFaceCastButton);
        devicesButton.onClick.AddListener(pressedDevicesButton);
        accountButton.onClick.AddListener(pressedAccountButton);
        searchButton.onClick.AddListener(pressedSearchButton);

        ButtonList = new List<Button>();
        ButtonList.Add(marketPlaceButton);
        ButtonList.Add(faceCastButton);
        ButtonList.Add(devicesButton);
        ButtonList.Add(accountButton);
        ButtonList.Add(searchButton);

        // Start with marketPlaceButton pressed
        pressedMarketPlaceButton();

    }



    public void pressedMarketPlaceButton()
    {
        HighlightPressedButton(marketPlaceButton);
        HideAllPanels();
        marketPlacePanel.SetActive(true);
    }
    public void pressedFaceCastButton()
    {
        HighlightPressedButton(faceCastButton);
        HideAllPanels();
        Background.SetActive(false);
        faceCastPanel.SetActive(true);
        ARPumpkin.SetActive(true);
    }
    public void pressedDevicesButton()
    {
        HighlightPressedButton(devicesButton);
        HideAllPanels();
        devicesPanel.SetActive(true);
    }
    public void pressedAccountButton()
    {
        HighlightPressedButton(accountButton);
        HideAllPanels();
        accountPanel.SetActive(true);
    }
    public void pressedSearchButton()
    {
        HighlightPressedButton(searchButton);
        // HideAllPanels(); // search panel pops up over others
        searchPanel.SetActive(true);
    }

    public void HighlightPressedButton(Button pressedButton)
    {
        foreach (Button b in ButtonList)
        {
            var buttonImageToClear = b.GetComponentInChildren<Image>();
            if (b == pressedButton)
            {
                buttonImageToClear.color = pressedButtonColor;
            }
            else
            {
                buttonImageToClear.color = Color.white;
            }
        }
    }
    public void HideAllPanels()
    {
        // hide all panels...
        marketPlacePanel.SetActive(false);
        faceCastPanel.SetActive(false);
        ARPumpkin.SetActive(false);
        devicesPanel.SetActive(false);
        accountPanel.SetActive(false);
        searchPanel.SetActive(false);

        itemViewPanelTJJ.SetActive(false);
        itemViewPanelRed.SetActive(false);
        if (itemViewPanelVoodoo)
            itemViewPanelVoodoo.SetActive(false);

        Background.SetActive(true);
    }
}
