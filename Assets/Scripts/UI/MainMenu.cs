using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private UIDocument uIDocument;
    [SerializeField] private TankSpawnner tankSpawnner;

    private Button greenTankButton ,  blueTankButton , redTakButton;

    private void Start() {
        VisualElement visualElement = uIDocument.rootVisualElement;
        greenTankButton = visualElement.Q<Button>("Greentankbtn");
        greenTankButton.clickable.clicked += () => {tankSpawnner.CreateTank(0); uIDocument.gameObject.SetActive(false); };
        
        blueTankButton =visualElement.Q<Button>("Bluetankbtn");
        blueTankButton.clickable.clicked += () => {tankSpawnner.CreateTank(1); uIDocument.gameObject.SetActive(false); };
        redTakButton = visualElement.Q<Button>("Redtankbtn");
        redTakButton.clickable.clicked += () => {tankSpawnner.CreateTank(2); uIDocument.gameObject.SetActive(false); };
    }
    
}
