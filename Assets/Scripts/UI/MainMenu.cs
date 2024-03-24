using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private UIDocument uIDocument;
    [SerializeField] private TankSpawnner tankSpawnner;

    private Button greenTankButton ,  blueTankButton , redTakButton ,playBtn , settingBtn , quitBtn;
    

    private void Start() {
        VisualElement visualElement = uIDocument.rootVisualElement;
        // Debug.Log(visualElement.ElementAt(1));

        playBtn = visualElement.Q<Button>("playbtn");
        playBtn.clickable.clicked += () => {};


        settingBtn = visualElement.Q<Button>("settingbtn");
        settingBtn.clickable.clicked += () => {};

        quitBtn = visualElement.Q<Button>("quitbtn");
        quitBtn.clickable.clicked += () => {Application.Quit();};


        greenTankButton = visualElement.Q<Button>("Greentankbtn");
        greenTankButton.clickable.clicked += () => {tankSpawnner.CreateTank(0); uIDocument.gameObject.SetActive(false); };
        
        blueTankButton =visualElement.Q<Button>("Bluetankbtn");
        blueTankButton.clickable.clicked += () => {tankSpawnner.CreateTank(1); uIDocument.gameObject.SetActive(false); };
        
        redTakButton = visualElement.Q<Button>("Redtankbtn");
        redTakButton.clickable.clicked += () => {tankSpawnner.CreateTank(2); uIDocument.gameObject.SetActive(false); };
    }
    
}
